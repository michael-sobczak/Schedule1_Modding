internal static class MeshGenerationContextUtils // TypeDefIndex: 6751
{
	// Methods

	[Extension]
	// RVA: 0x2EDCCC0 Offset: 0x2EDB6C0 VA: 0x182EDCCC0
	public static void Rectangle(MeshGenerationContext mgc, MeshGenerationContextUtils.RectangleParams rectParams) { }

	[Extension]
	// RVA: 0x2EDCE30 Offset: 0x2EDB830 VA: 0x182EDCE30
	public static void Text(MeshGenerationContext mgc, TextElement te) { }

	// RVA: 0x2EDC9C0 Offset: 0x2EDB3C0 VA: 0x182EDC9C0
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	// RVA: 0x2EDCA20 Offset: 0x2EDB420 VA: 0x182EDCA20
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	// RVA: 0x2EDC5F0 Offset: 0x2EDAFF0 VA: 0x182EDC5F0
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref MeshGenerationContextUtils.RectangleParams rectParams) { }
}
