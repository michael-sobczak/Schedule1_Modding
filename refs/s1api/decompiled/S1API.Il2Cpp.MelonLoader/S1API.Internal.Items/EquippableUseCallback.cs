using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.Attributes;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppScheduleOne;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.PlayerScripts;
using MelonLoader;
using S1API.Items;
using UnityEngine.Events;

namespace S1API.Internal.Items;

[RegisterTypeInIl2Cpp]
internal class EquippableUseCallback : Equippable_Viewmodel
{
	public UnityEvent OnUse = new UnityEvent();

	private readonly List<Action<ItemInstance>> _callbacks = new List<Action<ItemInstance>>();

	[HideFromIl2Cpp]
	internal void AddCallback(Action<ItemInstance> callback)
	{
		if (callback != null && !_callbacks.Contains(callback))
		{
			_callbacks.Add(callback);
		}
	}

	public EquippableUseCallback(IntPtr ptr)
		: base(ptr)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_000b: Expected O, but got Unknown


	public EquippableUseCallback()
		: base(ClassInjector.DerivedConstructorPointer<EquippableUseCallback>())
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ClassInjector.DerivedConstructorBody((Il2CppObjectBase)(object)this);
	}

	public override void Update()
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
