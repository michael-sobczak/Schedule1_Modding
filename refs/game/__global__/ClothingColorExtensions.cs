public static class ClothingColorExtensions // TypeDefIndex: 2011
{
	// Methods

	[Extension]
	// RVA: 0x7CF390 Offset: 0x7CDD90 VA: 0x1807CF390
	public static Color GetActualColor(EClothingColor color) { }

	[Extension]
	// RVA: 0x7CF7C0 Offset: 0x7CE1C0 VA: 0x1807CF7C0
	public static Color GetLabelColor(EClothingColor color) { }

	[Extension]
	// RVA: 0x7CF860 Offset: 0x7CE260 VA: 0x1807CF860
	public static string GetLabel(EClothingColor color) { }

	// RVA: 0x7CF430 Offset: 0x7CDE30 VA: 0x1807CF430
	public static EClothingColor GetClothingColor(Color color) { }

	// RVA: 0x7CF320 Offset: 0x7CDD20 VA: 0x1807CF320
	public static bool ColorEquals(Color a, Color b, float tolerance = 0.004) { }
}
