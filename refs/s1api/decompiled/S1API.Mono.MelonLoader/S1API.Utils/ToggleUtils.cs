using System;
using S1API.Internal.Utils;
using UnityEngine.UI;

namespace S1API.Utils;

public static class ToggleUtils
{
	public static void AddListener(Toggle toggle, Action<bool> listener)
	{
		global::S1API.Internal.Utils.ToggleUtils.AddListener(toggle, listener);
	}

	public static void RemoveListener(Toggle toggle, Action<bool> listener)
	{
		global::S1API.Internal.Utils.ToggleUtils.RemoveListener(toggle, listener);
	}

	public static void ClearListeners(Toggle toggle)
	{
		global::S1API.Internal.Utils.ToggleUtils.ClearListeners(toggle);
	}

	public static void SetGraphic(Toggle toggle, Graphic graphic)
	{
		global::S1API.Internal.Utils.ToggleUtils.SetGraphic(toggle, graphic);
	}

	public static Graphic? GetGraphic(Toggle toggle)
	{
		return global::S1API.Internal.Utils.ToggleUtils.GetGraphic(toggle);
	}
}
