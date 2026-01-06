public static class NavMeshBuilder // TypeDefIndex: 18856
{
	// Methods

	// RVA: 0x2C63350 Offset: 0x2C61D50 VA: 0x182C63350
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	// RVA: 0x2C63170 Offset: 0x2C61B70 VA: 0x182C63170
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	// RVA: 0x2C630D0 Offset: 0x2C61AD0 VA: 0x182C630D0
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects) { }

	// RVA: 0x2C62E10 Offset: 0x2C61810 VA: 0x182C62E10
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x2C63890 Offset: 0x2C62290 VA: 0x182C63890
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x2C63690 Offset: 0x2C62090 VA: 0x182C63690
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x2C63620 Offset: 0x2C62020 VA: 0x182C63620
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x2C63040 Offset: 0x2C61A40 VA: 0x182C63040
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects) { }

	// RVA: 0x2C63820 Offset: 0x2C62220 VA: 0x182C63820
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x2C635B0 Offset: 0x2C61FB0 VA: 0x182C635B0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }
}
