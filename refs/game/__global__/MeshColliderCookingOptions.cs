public enum MeshColliderCookingOptions // TypeDefIndex: 18452
{
	// Fields
	public int value__; // 0x0
	public const MeshColliderCookingOptions None = 0;
	[Obsolete("No longer used because the problem this was trying to solve is gone since Unity 2018.3", True)]
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}
