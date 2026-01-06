public static class GraphUtilities // TypeDefIndex: 13173
{
	// Methods

	// RVA: 0xB19DE0 Offset: 0xB187E0 VA: 0x180B19DE0
	public static List<Vector3> GetContours(NavGraph graph) { }

	// RVA: 0xB18F80 Offset: 0xB17980 VA: 0x180B18F80
	public static void GetContours(INavmesh navmesh, Action<List<Int3>, bool> results) { }

	// RVA: 0xB19240 Offset: 0xB17C40 VA: 0x180B19240
	public static void GetContours(GridGraph grid, Action<Vector3[]> callback, float yMergeThreshold, GridNodeBase[] nodes) { }
}
