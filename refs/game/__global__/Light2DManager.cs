internal static class Light2DManager // TypeDefIndex: 8704
{
	// Fields
	private static SortingLayer[] s_SortingLayers; // 0x0
	[CompilerGenerated]
	private static readonly List<Light2D> <lights>k__BackingField; // 0x8

	// Properties
	public static List<Light2D> lights { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2A7D5B0 Offset: 0x2A7BFB0 VA: 0x182A7D5B0
	public static List<Light2D> get_lights() { }

	// RVA: 0x2A7D410 Offset: 0x2A7BE10 VA: 0x182A7D410
	public static void RegisterLight(Light2D light) { }

	// RVA: 0x2A7CEE0 Offset: 0x2A7B8E0 VA: 0x182A7CEE0
	public static void DeregisterLight(Light2D light) { }

	// RVA: 0x2A7CF90 Offset: 0x2A7B990 VA: 0x182A7CF90
	public static void ErrorIfDuplicateGlobalLight(Light2D light) { }

	// RVA: 0x2A7D1E0 Offset: 0x2A7BBE0 VA: 0x182A7D1E0
	public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color) { }

	// RVA: 0x2A7CD20 Offset: 0x2A7B720 VA: 0x182A7CD20
	private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex) { }

	// RVA: 0x2A7D100 Offset: 0x2A7BB00 VA: 0x182A7D100
	public static SortingLayer[] GetCachedSortingLayer() { }

	// RVA: 0x2A7D520 Offset: 0x2A7BF20 VA: 0x182A7D520
	private static void .cctor() { }
}
