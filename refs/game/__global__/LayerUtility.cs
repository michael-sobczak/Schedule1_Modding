internal static class LayerUtility // TypeDefIndex: 8716
{
	// Fields
	private static LayerBatch[] s_LayerBatches; // 0x0
	[CompilerGenerated]
	private static uint <maxTextureCount>k__BackingField; // 0x8

	// Properties
	public static uint maxTextureCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2A7BA10 Offset: 0x2A7A410 VA: 0x182A7BA10
	public static uint get_maxTextureCount() { }

	[CompilerGenerated]
	// RVA: 0x2A7BA50 Offset: 0x2A7A450 VA: 0x182A7BA50
	private static void set_maxTextureCount(uint value) { }

	// RVA: 0x2A7B9C0 Offset: 0x2A7A3C0 VA: 0x182A7B9C0
	public static void InitializeBudget(uint maxTextureCount) { }

	// RVA: 0x2A7B2E0 Offset: 0x2A79CE0 VA: 0x182A7B2E0
	private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult) { }

	// RVA: 0x2A7B840 Offset: 0x2A7A240 VA: 0x182A7B840
	private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult) { }

	// RVA: 0x2A7B8C0 Offset: 0x2A7A2C0 VA: 0x182A7B8C0
	private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers) { }

	// RVA: 0x2A7AF30 Offset: 0x2A79930 VA: 0x182A7AF30
	public static LayerBatch[] CalculateBatches(ILight2DCullResult lightCullResult, out int batchCount) { }
}
