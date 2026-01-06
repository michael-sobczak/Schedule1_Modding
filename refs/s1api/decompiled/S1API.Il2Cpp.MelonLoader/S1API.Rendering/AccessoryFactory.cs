using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework;
using S1API.Logging;
using UnityEngine;

namespace S1API.Rendering;

public static class AccessoryFactory
{
	private static readonly Log Logger = new Log("AccessoryFactory");

	internal static readonly Dictionary<string, Dictionary<string, Texture2D>> _accessoryTextureRegistry = new Dictionary<string, Dictionary<string, Texture2D>>();

	public static GameObject CloneAccessoryWithCustomTextures(string sourceResourcePath, string newName, Dictionary<string, Texture2D> textureReplacements = null, Color? colorTint = null, string targetResourcePath = null)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			GameObject val = Resources.Load<GameObject>(sourceResourcePath);
			if ((Object)(object)val == (Object)null)
			{
				Logger.Error("Failed to load source accessory at path: " + sourceResourcePath);
				return null;
			}
			GameObject val2 = Object.Instantiate<GameObject>(val);
			((Object)val2).name = newName;
			Object.DontDestroyOnLoad((Object)(object)val2);
			val2.SetActive(false);
			Accessory component = val2.GetComponent<Accessory>();
			if ((Object)(object)component != (Object)null)
			{
				component.AssetPath = targetResourcePath ?? sourceResourcePath;
				component.Name = newName;
			}
			if (textureReplacements != null && textureReplacements.Count > 0)
			{
				ApplyTexturesToAccessory(val2, textureReplacements);
			}
			if (colorTint.HasValue && (Object)(object)component != (Object)null)
			{
				component.ApplyColor(colorTint.Value);
			}
			val2.SetActive(true);
			return val2;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to clone accessory '" + sourceResourcePath + "': " + ex.Message);
			Logger.Error(ex.StackTrace);
			return null;
		}
	}

	private static void ApplyTexturesToAccessory(GameObject accessory, Dictionary<string, Texture2D> textureReplacements)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		Il2CppArrayBase<Renderer> componentsInChildren = accessory.GetComponentsInChildren<Renderer>(true);
		foreach (Renderer item in componentsInChildren)
		{
			Il2CppReferenceArray<Material> materials = item.materials;
			for (int i = 0; i < ((Il2CppArrayBase<Material>)(object)materials).Length; i++)
			{
				Material val = new Material(((Il2CppArrayBase<Material>)(object)materials)[i]);
				foreach (KeyValuePair<string, Texture2D> textureReplacement in textureReplacements)
				{
					if (val.HasProperty(textureReplacement.Key))
					{
						val.SetTexture(textureReplacement.Key, (Texture)(object)textureReplacement.Value);
					}
				}
				((Il2CppArrayBase<Material>)(object)materials)[i] = val;
			}
			item.materials = materials;
		}
	}

	public static bool RegisterAccessory(string resourcePath, GameObject accessory)
	{
		if ((Object)(object)accessory == (Object)null)
		{
			Logger.Error("Cannot register null accessory");
			return false;
		}
		Accessory component = accessory.GetComponent<Accessory>();
		if ((Object)(object)component == (Object)null)
		{
			Logger.Warning("GameObject '" + ((Object)accessory).name + "' does not have an Accessory component. It may not work correctly as clothing.");
		}
		return RuntimeResourceRegistry.RegisterGameObject(resourcePath, accessory);
	}

	public static bool CreateAndRegisterAccessory(string sourceResourcePath, string targetResourcePath, string newName, Dictionary<string, Texture2D> textureReplacements = null, Color? colorTint = null)
	{
		GameObject val = CloneAccessoryWithCustomTextures(sourceResourcePath, newName, textureReplacements, colorTint, targetResourcePath);
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		if (textureReplacements != null && textureReplacements.Count > 0)
		{
			_accessoryTextureRegistry[targetResourcePath] = textureReplacements;
		}
		return RegisterAccessory(targetResourcePath, val);
	}

	internal static Dictionary<string, Texture2D> GetTextureReplacements(string resourcePath)
	{
		_accessoryTextureRegistry.TryGetValue(resourcePath, out Dictionary<string, Texture2D> value);
		return value;
	}
}
