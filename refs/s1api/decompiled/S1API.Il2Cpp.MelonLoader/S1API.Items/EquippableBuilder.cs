using System;
using System.Collections.Generic;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Equipping;
using S1API.Internal.Items;
using S1API.Internal.Utils;
using UnityEngine;

namespace S1API.Items;

public sealed class EquippableBuilder
{
	private GameObject _gameObject;

	private Equippable _equippable;

	private bool _canInteract = true;

	private bool _canPickup = true;

	private Vector3? _viewmodelPosition;

	private Vector3? _viewmodelRotation;

	private Vector3? _viewmodelScale;

	private string _avatarEquippableAssetPath;

	private EHand _avatarHand = (EHand)1;

	private string _avatarAnimationTrigger;

	private readonly List<Action<ItemInstance>> _useCallbacks = new List<Action<ItemInstance>>();

	public EquippableBuilder CreateEquippable<T>(string name = null) where T : Equippable
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		string text = (string.IsNullOrEmpty(name) ? ("Equippable_" + typeof(T).Name) : name);
		_gameObject = new GameObject(text);
		_equippable = (Equippable)(object)_gameObject.AddComponent<T>();
		return this;
	}

	public EquippableBuilder CreateBasicEquippable(string name = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = (string.IsNullOrEmpty(name) ? "Equippable_Basic" : name);
		_gameObject = new GameObject(text);
		_equippable = _gameObject.AddComponent<Equippable>();
		return this;
	}

	public EquippableBuilder CreateViewmodelEquippable(string name = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		string text = (string.IsNullOrEmpty(name) ? "Equippable_Viewmodel" : name);
		_gameObject = new GameObject(text);
		_equippable = (Equippable)(object)_gameObject.AddComponent<Equippable_Viewmodel>();
		return this;
	}

	public EquippableBuilder WithInteraction(bool canInteract, bool canPickup)
	{
		_canInteract = canInteract;
		_canPickup = canPickup;
		return this;
	}

	public EquippableBuilder WithViewmodelTransform(Vector3 position, Vector3 rotation, Vector3? scale = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_viewmodelPosition = position;
		_viewmodelRotation = rotation;
		_viewmodelScale = (Vector3)(((_003F?)scale) ?? Vector3.one);
		return this;
	}

	public EquippableBuilder WithAvatarEquippable(string assetPath, AvatarHand hand = AvatarHand.Right, string animationTrigger = "RightArm_Hold_ClosedHand")
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_avatarEquippableAssetPath = assetPath;
		_avatarHand = (EHand)((hand != AvatarHand.Left) ? 1 : 0);
		_avatarAnimationTrigger = animationTrigger;
		return this;
	}

	public EquippableBuilder WithUseCallback(Action<ItemInstance> callback)
	{
		if (callback != null && !_useCallbacks.Contains(callback))
		{
			_useCallbacks.Add(callback);
		}
		return this;
	}

	public Equippable Build()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)_equippable == (Object)null)
		{
			throw new InvalidOperationException("Cannot build equippable: No equippable component created. Call CreateEquippable<T>(), CreateBasicEquippable(), or CreateViewmodelEquippable() first.");
		}
		_equippable.CanInteractWhenEquipped = _canInteract;
		_equippable.CanPickUpWhenEquipped = _canPickup;
		Equippable equippable = _equippable;
		Equippable_Viewmodel val = (Equippable_Viewmodel)(object)((equippable is Equippable_Viewmodel) ? equippable : null);
		if (val != null)
		{
			if (_useCallbacks != null && _useCallbacks.Count > 0)
			{
				Vector3 localPosition = (Vector3)(((_003F?)_viewmodelPosition) ?? val.localPosition);
				Vector3 localEulerAngles = (Vector3)(((_003F?)_viewmodelRotation) ?? val.localEulerAngles);
				Vector3 localScale = (Vector3)(((_003F?)_viewmodelScale) ?? val.localScale);
				AvatarEquippable avatarEquippable = val.AvatarEquippable;
				Object.DestroyImmediate((Object)(object)val);
				EquippableUseCallback equippableUseCallback = _gameObject.AddComponent<EquippableUseCallback>();
				foreach (Action<ItemInstance> useCallback in _useCallbacks)
				{
					equippableUseCallback.AddCallback(useCallback);
				}
				((Equippable_Viewmodel)equippableUseCallback).localPosition = localPosition;
				((Equippable_Viewmodel)equippableUseCallback).localEulerAngles = localEulerAngles;
				((Equippable_Viewmodel)equippableUseCallback).localScale = localScale;
				((Equippable_Viewmodel)equippableUseCallback).AvatarEquippable = avatarEquippable;
				_equippable = (Equippable)(object)equippableUseCallback;
				val = (Equippable_Viewmodel)(object)equippableUseCallback;
			}
			if (_viewmodelPosition.HasValue)
			{
				val.localPosition = _viewmodelPosition.Value;
			}
			if (_viewmodelRotation.HasValue)
			{
				val.localEulerAngles = _viewmodelRotation.Value;
			}
			if (_viewmodelScale.HasValue)
			{
				val.localScale = _viewmodelScale.Value;
			}
			if (!string.IsNullOrEmpty(_avatarEquippableAssetPath))
			{
				GameObject val2 = new GameObject("AvatarEquippable");
				val2.transform.SetParent(_gameObject.transform);
				AvatarEquippable val3 = val2.AddComponent<AvatarEquippable>();
				val3.AssetPath = _avatarEquippableAssetPath;
				val3.Hand = _avatarHand;
				val3.AnimationTrigger = _avatarAnimationTrigger;
				if ((Object)(object)val3.AlignmentPoint == (Object)null)
				{
					GameObject val4 = new GameObject("AlignmentPoint");
					val4.transform.SetParent(val2.transform);
					val4.transform.localPosition = Vector3.zero;
					val4.transform.localRotation = Quaternion.identity;
					val3.AlignmentPoint = val4.transform;
				}
				val.AvatarEquippable = val3;
			}
		}
		ApplyInteractionSettings(_equippable);
		Object.DontDestroyOnLoad((Object)(object)_gameObject);
		_gameObject.SetActive(false);
		return new Equippable(_equippable);
	}

	internal Equippable BuildInternal()
	{
		if ((Object)(object)_equippable == (Object)null)
		{
			throw new InvalidOperationException("Cannot build equippable: No equippable component created. Call CreateEquippable<T>() or CreateBasicEquippable() first.");
		}
		ApplyInteractionSettings(_equippable);
		Object.DontDestroyOnLoad((Object)(object)_gameObject);
		_gameObject.SetActive(false);
		return _equippable;
	}

	private void ApplyInteractionSettings(Equippable equippable)
	{
		if (!((Object)(object)equippable == (Object)null))
		{
			try
			{
				equippable.CanInteractWhenEquipped = _canInteract;
			}
			catch
			{
			}
			try
			{
				equippable.CanPickUpWhenEquipped = _canPickup;
			}
			catch
			{
			}
			ReflectionUtils.TrySetFieldOrProperty(equippable, "CanInteractWhenEquipped", _canInteract);
			ReflectionUtils.TrySetFieldOrProperty(equippable, "canInteractWhenEquipped", _canInteract);
			ReflectionUtils.TrySetFieldOrProperty(equippable, "CanPickUpWhenEquipped", _canPickup);
			ReflectionUtils.TrySetFieldOrProperty(equippable, "canPickUpWhenEquipped", _canPickup);
		}
	}
}
