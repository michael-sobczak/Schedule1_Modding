using System;
using S1API.Internal.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace S1API.Utils;

public static class ButtonUtils
{
	public static void AddListener(Button button, Action action)
	{
		global::S1API.Internal.Utils.ButtonUtils.AddListener(button, action);
	}

	public static void RemoveListener(Button button, Action action)
	{
		global::S1API.Internal.Utils.ButtonUtils.RemoveListener(button, action);
	}

	public static void ClearListeners(Button button)
	{
		global::S1API.Internal.Utils.ButtonUtils.ClearListeners(button);
	}

	public static void Enable(Button button, Text? label = null, string? text = null)
	{
		global::S1API.Internal.Utils.ButtonUtils.Enable(button, label, text);
	}

	public static void Disable(Button button, Text? label = null, string? text = null)
	{
		global::S1API.Internal.Utils.ButtonUtils.Disable(button, label, text);
	}

	public static void SetLabel(Text label, string text)
	{
		global::S1API.Internal.Utils.ButtonUtils.SetLabel(label, text);
	}

	public static void SetStyle(Button button, Text label, string text, Color bg)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		global::S1API.Internal.Utils.ButtonUtils.SetStyle(button, label, text, bg);
	}
}
