public static class NavMeshUtility // TypeDefIndex: 1917
{
	// Fields
	public const float SAMPLE_MAX_DISTANCE = 2;
	public static Dictionary<Vector3, Vector3> SampleCache; // 0x0
	public static List<Vector3> sampleCacheKeys; // 0x8
	public const float SAMPLE_CACHE_MAX_SQR_DIST = 1;
	public const float MAX_CACHE_SIZE = 10000;

	// Methods

	// RVA: 0x78C6B0 Offset: 0x78B0B0 VA: 0x18078C6B0
	public static float GetPathLength(NavMeshPath path) { }

	// RVA: 0x78C880 Offset: 0x78B280 VA: 0x18078C880
	public static Transform GetReachableAccessPoint(ITransitEntity entity, NPC npc) { }

	// RVA: 0x78CEE0 Offset: 0x78B8E0 VA: 0x18078CEE0
	public static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4) { }

	// RVA: 0x78C5D0 Offset: 0x78AFD0 VA: 0x18078C5D0
	public static int GetNavMeshAgentID(string name) { }

	// RVA: 0x78D280 Offset: 0x78BC80 VA: 0x18078D280
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = True) { }

	// RVA: 0x78D1E0 Offset: 0x78BBE0 VA: 0x18078D1E0
	private static Vector3 Quantize(Vector3 position, float precision = 0.1) { }

	// RVA: 0x78C530 Offset: 0x78AF30 VA: 0x18078C530
	public static void ClearCache() { }

	// RVA: 0x78D7A0 Offset: 0x78C1A0 VA: 0x18078D7A0
	private static void .cctor() { }
}
