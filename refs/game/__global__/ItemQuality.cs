public static class ItemQuality // TypeDefIndex: 3075
{
	// Fields
	public const float Heavenly_Threshold = 0.9;
	public const float Premium_Threshold = 0.75;
	public const float Standard_Threshold = 0.4;
	public const float Poor_Threshold = 0.25;
	public static Color Heavenly_Color; // 0x0
	public static Color Premium_Color; // 0x10
	public static Color Standard_Color; // 0x20
	public static Color Poor_Color; // 0x30
	public static Color Trash_Color; // 0x40

	// Methods

	// RVA: 0x9987D0 Offset: 0x9971D0 VA: 0x1809987D0
	public static EQuality GetQuality(float qualityScalar) { }

	// RVA: 0x998600 Offset: 0x997000 VA: 0x180998600
	public static Color GetColor(EQuality quality) { }

	// RVA: 0x998810 Offset: 0x997210 VA: 0x180998810
	private static void .cctor() { }
}
