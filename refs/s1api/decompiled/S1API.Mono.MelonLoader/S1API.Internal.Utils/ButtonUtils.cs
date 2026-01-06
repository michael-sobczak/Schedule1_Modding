using System;
using S1API.Internal.Abstraction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.ButtonUtils instead. This class will be made internal in a future version.")]
public static class ButtonUtils
{
	public static void AddListener(Button button, Action action)
	{
		if (!((Object)(object)button == (Object)null) && action != null)
		{
			EventHelper.AddListener(action, (UnityEvent)(object)button.onClick);
		}
	}

	public static void RemoveListener(Button button, Action action)
	{
		if (!((Object)(object)button == (Object)null) && action != null)
		{
			EventHelper.RemoveListener(action, (UnityEvent)(object)button.onClick);
		}
	}

	public static void ClearListeners(Button button)
	{
		if (!((Object)(object)button == (Object)null))
		{
			((UnityEventBase)button.onClick).RemoveAllListeners();
		}
	}

	public static void Enable(Button button, Text? label = null, string? text = null)
	{
		if ((Object)(object)button != (Object)null)
		{
			((Selectable)button).interactable = true;
		}
		if ((Object)(object)label != (Object)null && !string.IsNullOrEmpty(text))
		{
			label.text = text;
		}
	}

	public static void Disable(Button button, Text? label = null, string? text = null)
	{
		if ((Object)(object)button != (Object)null)
		{
			((Selectable)button).interactable = false;
		}
		if ((Object)(object)label != (Object)null && !string.IsNullOrEmpty(text))
		{
			label.text = text;
		}
	}

	public static void SetLabel(Text label, string text)
	{
		if ((Object)(object)label != (Object)null)
		{
			label.text = text;
		}
	}

	public static void SetStyle(Button button, Text label, string text, Color bg)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)button == (Object)null) && !((Object)(object)label == (Object)null))
		{
			label.text = text;
			((Graphic)((Selectable)button).image).color = bg;
		}
	}
}
