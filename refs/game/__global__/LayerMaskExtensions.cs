public static class LayerMaskExtensions // TypeDefIndex: 14033
{
	// Methods

	// RVA: 0xDA68A0 Offset: 0xDA52A0 VA: 0x180DA68A0
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x1EA9050 Offset: 0x1EA7A50 VA: 0x181EA9050
	public static LayerMask Create(string[] layerNames) { }

	// RVA: 0x1EA90F0 Offset: 0x1EA7AF0 VA: 0x181EA90F0
	public static LayerMask Create(int[] layerNumbers) { }

	// RVA: 0x1EA9050 Offset: 0x1EA7A50 VA: 0x181EA9050
	public static LayerMask NamesToMask(string[] layerNames) { }

	// RVA: 0x1EA90F0 Offset: 0x1EA7AF0 VA: 0x181EA90F0
	public static LayerMask LayerNumbersToMask(int[] layerNumbers) { }

	[Extension]
	// RVA: 0x1EA9170 Offset: 0x1EA7B70 VA: 0x181EA9170
	public static LayerMask Inverse(LayerMask original) { }

	[Extension]
	// RVA: 0x1EA8F90 Offset: 0x1EA7990 VA: 0x181EA8F90
	public static LayerMask AddToMask(LayerMask original, string[] layerNames) { }

	[Extension]
	// RVA: 0x1EA95E0 Offset: 0x1EA7FE0 VA: 0x181EA95E0
	public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames) { }

	[Extension]
	// RVA: 0x1EA9190 Offset: 0x1EA7B90 VA: 0x181EA9190
	public static string[] MaskToNames(LayerMask original) { }

	[Extension]
	// RVA: 0x1EA9290 Offset: 0x1EA7C90 VA: 0x181EA9290
	public static int[] MaskToNumbers(LayerMask original) { }

	[Extension]
	// RVA: 0x1EA9380 Offset: 0x1EA7D80 VA: 0x181EA9380
	public static string MaskToString(LayerMask original) { }

	[Extension]
	// RVA: 0x1EA94C0 Offset: 0x1EA7EC0 VA: 0x181EA94C0
	public static string MaskToString(LayerMask original, string delimiter) { }
}
