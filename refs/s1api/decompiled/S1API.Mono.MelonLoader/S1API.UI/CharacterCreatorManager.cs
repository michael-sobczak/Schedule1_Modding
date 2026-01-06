using System;
using System.Collections;
using System.Collections.Generic;
using MelonLoader;
using S1API.Avatar;
using S1API.Entities;
using S1API.Logging;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace S1API.UI;

public static class CharacterCreatorManager
{
	private static readonly Log Logger = new Log("CharacterCreatorManager");

	private static CharacterCreator _s1Creator;

	private static bool _isInitialized;

	private static bool _eventsRegistered;

	public static bool IsOpen
	{
		get
		{
			EnsureInitialized();
			CharacterCreator s1Creator = _s1Creator;
			return s1Creator != null && s1Creator.IsOpen;
		}
	}

	public static BasicAvatarSettings ActiveSettings
	{
		get
		{
			EnsureInitialized();
			CharacterCreator s1Creator = _s1Creator;
			if ((Object)(object)((s1Creator != null) ? s1Creator.ActiveSettings : null) == (Object)null)
			{
				return null;
			}
			return new BasicAvatarSettings(_s1Creator.ActiveSettings);
		}
	}

	public static event Action OnOpened;

	public static event Action OnClosed;

	public static event Action<BasicAvatarSettings> OnCompleted;

	public static void Open(BasicAvatarSettings initialSettings = null, bool showUI = true)
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Error("CharacterCreator singleton is not available");
			return;
		}
		if (_s1Creator.IsOpen)
		{
			Logger.Warning("CharacterCreator is already open");
			return;
		}
		RegisterEvents();
		if (initialSettings == null)
		{
			initialSettings = GetPlayerAvatarSettings();
		}
		if (showUI && PlayerSingleton<PlayerCamera>.InstanceExists)
		{
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(((Object)_s1Creator).name);
		}
		BasicAvatarSettings val = initialSettings?.S1BasicAvatarSettings;
		_s1Creator.Open(val, showUI);
		try
		{
			CharacterCreatorManager.OnOpened?.Invoke();
		}
		catch (Exception arg)
		{
			Logger.Error($"Error in OnOpened event handler: {arg}");
		}
	}

	public static void Close()
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Error("CharacterCreator singleton is not available");
			return;
		}
		if (!_s1Creator.IsOpen)
		{
			Logger.Warning("CharacterCreator is not open");
			return;
		}
		_s1Creator.Close();
		MelonCoroutines.Start(RestoreAfterClose());
		try
		{
			CharacterCreatorManager.OnClosed?.Invoke();
		}
		catch (Exception arg)
		{
			Logger.Error($"Error in OnClosed event handler: {arg}");
		}
	}

	public static void Complete()
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Error("CharacterCreator singleton is not available");
		}
		else if (!_s1Creator.IsOpen)
		{
			Logger.Warning("CharacterCreator is not open");
		}
		else
		{
			_s1Creator.Done();
		}
	}

	public static void SelectPreset(string presetName)
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Error("CharacterCreator singleton is not available");
		}
		else if (!_s1Creator.IsOpen)
		{
			Logger.Warning("CharacterCreator must be open to select a preset");
		}
		else if (string.IsNullOrWhiteSpace(presetName))
		{
			Logger.Warning("Preset name cannot be null or empty");
		}
		else
		{
			_s1Creator.SelectPreset(presetName);
		}
	}

	public static string[] GetAvailablePresets()
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null || _s1Creator.Presets == null)
		{
			return Array.Empty<string>();
		}
		List<string> list = new List<string>();
		for (int i = 0; i < _s1Creator.Presets.Count; i++)
		{
			BasicAvatarSettings val = _s1Creator.Presets[i];
			if ((Object)(object)val != (Object)null && !string.IsNullOrWhiteSpace(((Object)val).name))
			{
				list.Add(((Object)val).name);
			}
		}
		return list.ToArray();
	}

	public static void SetRigRotation(float normalizedValue)
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Error("CharacterCreator singleton is not available");
		}
		else if (!_s1Creator.IsOpen)
		{
			Logger.Warning("CharacterCreator must be open to set rig rotation");
		}
		else
		{
			_s1Creator.SliderChanged(Mathf.Clamp01(normalizedValue));
		}
	}

	public static void PreRegisterAsActiveUI()
	{
		EnsureInitialized();
		if ((Object)(object)_s1Creator == (Object)null)
		{
			Logger.Warning("CharacterCreator singleton is not available for pre-registration");
		}
		else if (PlayerSingleton<PlayerCamera>.InstanceExists)
		{
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(((Object)_s1Creator).name);
		}
	}

	private static void EnsureInitialized()
	{
		if (_isInitialized)
		{
			return;
		}
		try
		{
			_s1Creator = Singleton<CharacterCreator>.Instance;
			if ((Object)(object)_s1Creator == (Object)null)
			{
				Logger.Warning("CharacterCreator singleton not found. Make sure you're in the correct scene.");
			}
			_isInitialized = true;
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to initialize CharacterCreatorManager: {arg}");
			_isInitialized = true;
		}
	}

	private static void RegisterEvents()
	{
		if (_eventsRegistered || (Object)(object)_s1Creator == (Object)null)
		{
			return;
		}
		try
		{
			if (_s1Creator.onComplete != null)
			{
				_s1Creator.onComplete.AddListener((UnityAction<BasicAvatarSettings>)OnCreatorCompleted);
			}
			_eventsRegistered = true;
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to register CharacterCreator events: {arg}");
		}
	}

	private static void OnCreatorCompleted(BasicAvatarSettings s1Settings)
	{
		try
		{
			if ((Object)(object)s1Settings == (Object)null)
			{
				Logger.Warning("CharacterCreator completed with null settings");
				return;
			}
			BasicAvatarSettings obj = new BasicAvatarSettings(s1Settings);
			MelonCoroutines.Start(RestoreGameState());
			CharacterCreatorManager.OnCompleted?.Invoke(obj);
		}
		catch (Exception arg)
		{
			Logger.Error($"Error in OnCompleted event handler: {arg}");
		}
	}

	private static IEnumerator RestoreAfterClose()
	{
		yield return RestoreGameState();
	}

	private static IEnumerator RestoreGameState()
	{
		yield return null;
		yield return (object)new WaitForSeconds(0.1f);
		if (PlayerSingleton<PlayerCamera>.InstanceExists)
		{
			PlayerCamera camera = PlayerSingleton<PlayerCamera>.Instance;
			CharacterCreator s1Creator = _s1Creator;
			camera.RemoveActiveUIElement(((s1Creator != null) ? ((Object)s1Creator).name : null) ?? "CharacterCreator");
			if (camera.activeUIElementCount == 0)
			{
				camera.StopTransformOverride(0f, true, false);
				camera.StopFOVOverride(0f);
				camera.SetCanLook(true);
				camera.LockMouse();
			}
		}
		if (PlayerSingleton<PlayerMovement>.InstanceExists)
		{
			PlayerSingleton<PlayerMovement>.Instance.CanMove = true;
		}
		if (PlayerSingleton<PlayerInventory>.InstanceExists)
		{
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
		}
		if (Singleton<HUD>.InstanceExists)
		{
			((Behaviour)Singleton<HUD>.Instance.canvas).enabled = true;
		}
	}

	private static BasicAvatarSettings GetPlayerAvatarSettings()
	{
		try
		{
			Player local = Player.Local;
			if (local == null || (Object)(object)local.S1Player == (Object)null)
			{
				Logger.Warning("Local player not available");
				return null;
			}
			BasicAvatarSettings currentAvatarSettings = local.S1Player.CurrentAvatarSettings;
			if ((Object)(object)currentAvatarSettings == (Object)null)
			{
				Logger.Msg("Player has no current avatar settings, using default");
				return null;
			}
			BasicAvatarSettings settings = Object.Instantiate<BasicAvatarSettings>(currentAvatarSettings);
			return new BasicAvatarSettings(settings);
		}
		catch (Exception arg)
		{
			Logger.Error($"Failed to get player avatar settings: {arg}");
			return null;
		}
	}
}
