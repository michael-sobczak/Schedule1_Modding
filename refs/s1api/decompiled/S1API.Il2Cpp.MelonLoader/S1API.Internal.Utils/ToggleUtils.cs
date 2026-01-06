using System;
using System.Reflection;
using S1API.Internal.Abstraction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.ToggleUtils instead. This class will be made internal in a future version.")]
public static class ToggleUtils
{
	private static FieldInfo? _onValueChangedField;

	private static PropertyInfo? _onValueChangedProperty;

	private static FieldInfo? _graphicField;

	private static PropertyInfo? _graphicProperty;

	public static void AddListener(Toggle toggle, Action<bool> listener)
	{
		if (!((Object)(object)toggle == (Object)null) && listener != null && TryGetOnValueChanged(toggle, out UnityEvent<bool> evt) && evt != null)
		{
			EventHelper.AddListener(listener, evt);
		}
	}

	public static void RemoveListener(Toggle toggle, Action<bool> listener)
	{
		if (!((Object)(object)toggle == (Object)null) && listener != null && TryGetOnValueChanged(toggle, out UnityEvent<bool> evt) && evt != null)
		{
			EventHelper.RemoveListener(listener, evt);
		}
	}

	public static void ClearListeners(Toggle toggle)
	{
		if (TryGetOnValueChanged(toggle, out UnityEvent<bool> evt) && evt != null)
		{
			((UnityEventBase)evt).RemoveAllListeners();
		}
	}

	private static bool TryGetOnValueChanged(Toggle toggle, out UnityEvent<bool>? evt)
	{
		evt = null;
		if ((object)_onValueChangedField == null)
		{
			_onValueChangedField = typeof(Toggle).GetField("onValueChanged", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_onValueChangedField != null && _onValueChangedField.GetValue(toggle) is UnityEvent<bool> val)
		{
			evt = val;
			return true;
		}
		if ((object)_onValueChangedProperty == null)
		{
			_onValueChangedProperty = typeof(Toggle).GetProperty("onValueChanged", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_onValueChangedProperty?.GetMethod != null && _onValueChangedProperty.GetValue(toggle) is UnityEvent<bool> val2)
		{
			evt = val2;
			return true;
		}
		return false;
	}

	public static void SetGraphic(Toggle toggle, Graphic graphic)
	{
		if ((Object)(object)toggle == (Object)null)
		{
			return;
		}
		if ((object)_graphicField == null)
		{
			_graphicField = typeof(Toggle).GetField("graphic", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_graphicField != null)
		{
			_graphicField.SetValue(toggle, graphic);
			return;
		}
		if ((object)_graphicProperty == null)
		{
			_graphicProperty = typeof(Toggle).GetProperty("graphic", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_graphicProperty?.SetMethod != null)
		{
			_graphicProperty.SetValue(toggle, graphic);
		}
	}

	public static Graphic? GetGraphic(Toggle toggle)
	{
		if ((Object)(object)toggle == (Object)null)
		{
			return null;
		}
		if ((object)_graphicField == null)
		{
			_graphicField = typeof(Toggle).GetField("graphic", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_graphicField != null)
		{
			object? value = _graphicField.GetValue(toggle);
			return (Graphic?)((value is Graphic) ? value : null);
		}
		if ((object)_graphicProperty == null)
		{
			_graphicProperty = typeof(Toggle).GetProperty("graphic", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (_graphicProperty?.GetMethod != null)
		{
			object? value2 = _graphicProperty.GetValue(toggle);
			return (Graphic?)((value2 is Graphic) ? value2 : null);
		}
		return null;
	}
}
