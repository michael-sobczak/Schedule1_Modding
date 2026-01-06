using System;
using UnityEngine;

namespace S1API.Internal.Utils;

[Obsolete("This class is for internal API use only. Mod developers should use S1API.Utils.ColorUtils instead. This class will be made internal in a future version.")]
public static class ColorUtils
{
	public static Color ToColor(this uint hexColor)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ToColorInternal(hexColor);
	}

	private static Color ToColorInternal(uint hexColor)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		float num = (float)((hexColor >> 24) & 0xFF) / 255f;
		float num2 = (float)((hexColor >> 16) & 0xFF) / 255f;
		float num3 = (float)((hexColor >> 8) & 0xFF) / 255f;
		float num4 = (float)(hexColor & 0xFF) / 255f;
		return new Color(num2, num3, num4, num);
	}
}
