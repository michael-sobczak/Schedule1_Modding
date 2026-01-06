using System;
using System.Collections.Generic;
using MelonLoader;
using S1API.Items;
using ScheduleOne;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace S1API.Internal.Items;

internal class EquippableUseCallback : Equippable_Viewmodel
{
	public UnityEvent OnUse = new UnityEvent();

	private readonly List<Action<ItemInstance>> _callbacks = new List<Action<ItemInstance>>();

	internal void AddCallback(Action<ItemInstance> callback)
	{
		if (callback != null && !_callbacks.Contains(callback))
		{
			_callbacks.Add(callback);
		}
	}

	protected override void Update()
	{
		((Equippable)this).Update();
		if (OnUse == null || !GameInput.GetButtonDown((ButtonCode)0) || GameInput.IsTyping || PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount != 0 || ((Equippable)this).itemInstance == null)
		{
			return;
		}
		try
		{
			ItemInstance obj = new ItemInstance(((Equippable)this).itemInstance);
			if (_callbacks != null)
			{
				foreach (Action<ItemInstance> callback in _callbacks)
				{
					try
					{
						callback?.Invoke(obj);
					}
					catch (Exception ex)
					{
						MelonLogger.Error("[EquippableUseCallback] Exception in callback: " + ex.Message);
						MelonLogger.Error(ex.StackTrace);
					}
				}
			}
			UnityEvent onUse = OnUse;
			if (onUse != null)
			{
				onUse.Invoke();
			}
		}
		catch (Exception ex2)
		{
			MelonLogger.Error("[EquippableUseCallback] Exception in use callback: " + ex2.Message);
			MelonLogger.Error(ex2.StackTrace);
		}
	}
}
