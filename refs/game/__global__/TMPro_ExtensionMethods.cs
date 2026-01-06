public static class TMPro_ExtensionMethods // TypeDefIndex: 14853
{
	// Methods

	[Extension]
	// RVA: 0x2BEB6A0 Offset: 0x2BEA0A0 VA: 0x182BEB6A0
	internal static int TagToInt(string s) { }

	[Extension]
	// RVA: 0x2BEB830 Offset: 0x2BEA230 VA: 0x182BEB830
	public static int[] ToIntArray(string text) { }

	[Extension]
	// RVA: 0x2BEB080 Offset: 0x2BE9A80 VA: 0x182BEB080
	public static string ArrayToString(char[] chars) { }

	[Extension]
	// RVA: 0x2BEB3F0 Offset: 0x2BE9DF0 VA: 0x182BEB3F0
	public static string IntToString(int[] unicodes) { }

	[Extension]
	// RVA: 0x2BEB8D0 Offset: 0x2BEA2D0 VA: 0x182BEB8D0
	internal static string UintToString(List<uint> unicodes) { }

	[Extension]
	// RVA: 0x2BEB480 Offset: 0x2BE9E80 VA: 0x182BEB480
	public static string IntToString(int[] unicodes, int start, int length) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C280 Offset: 0xF5AC80 VA: 0x180F5C280
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[Extension]
	// RVA: 0x4526B0 Offset: 0x4510B0 VA: 0x1804526B0
	public static bool Compare(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x2BEB160 Offset: 0x2BE9B60 VA: 0x182BEB160
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0
	public static bool Compare(Color a, Color b) { }

	[Extension]
	// RVA: 0x292F1D0 Offset: 0x292DBD0 VA: 0x18292F1D0
	public static bool CompareRGB(Color a, Color b) { }

	[Extension]
	// RVA: 0x2BEB5C0 Offset: 0x2BE9FC0 VA: 0x182BEB5C0
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x2BEB5C0 Offset: 0x2BE9FC0 VA: 0x182BEB5C0
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x2BEB750 Offset: 0x2BEA150 VA: 0x182BEB750
	public static Color32 Tint(Color32 c1, float tint) { }

	[Extension]
	// RVA: 0x2BEB3A0 Offset: 0x2BE9DA0 VA: 0x182BEB3A0
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x2BEB2F0 Offset: 0x2BE9CF0 VA: 0x182BEB2F0
	private static byte GammaToLinear(byte value) { }

	[Extension]
	// RVA: 0x2BEB590 Offset: 0x2BE9F90 VA: 0x182BEB590
	public static Color MinAlpha(Color c1, Color c2) { }

	[Extension]
	// RVA: 0x2BEB260 Offset: 0x2BE9C60 VA: 0x182BEB260
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Extension]
	// RVA: 0x2BEB190 Offset: 0x2BE9B90 VA: 0x182BEB190
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}
