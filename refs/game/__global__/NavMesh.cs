public static class NavMesh // TypeDefIndex: 18871
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2C64D60 Offset: 0x2C63760 VA: 0x182C64D60
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x2C64980 Offset: 0x2C63380 VA: 0x182C64980
	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x2C64910 Offset: 0x2C63310 VA: 0x182C64910
	private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x2C65080 Offset: 0x2C63A80 VA: 0x182C65080
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	// RVA: 0x2C646B0 Offset: 0x2C630B0 VA: 0x182C646B0
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeName("IsValidSurfaceID")]
	[StaticAccessor("GetNavMeshManager()")]
	// RVA: 0x2C64DF0 Offset: 0x2C637F0 VA: 0x182C64DF0
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessor("GetNavMeshManager()")]
	// RVA: 0x2C64DB0 Offset: 0x2C637B0 VA: 0x182C64DB0
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("SetSurfaceUserID")]
	// RVA: 0x2C64D20 Offset: 0x2C63720 VA: 0x182C64D20
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("SetLinkUserID")]
	// RVA: 0x2C64CE0 Offset: 0x2C636E0 VA: 0x182C64CE0
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("LoadData")]
	// RVA: 0x2C64650 Offset: 0x2C63050 VA: 0x182C64650
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeName("UnloadData")]
	[StaticAccessor("GetNavMeshManager()")]
	// RVA: 0x2C64E70 Offset: 0x2C63870 VA: 0x182C64E70
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x2C64570 Offset: 0x2C62F70 VA: 0x182C64570
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeName("AddLink")]
	[StaticAccessor("GetNavMeshManager()")]
	// RVA: 0x2C64510 Offset: 0x2C62F10 VA: 0x182C64510
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessor("GetNavMeshManager()")]
	[NativeName("RemoveLink")]
	// RVA: 0x2C64E30 Offset: 0x2C63830 VA: 0x182C64E30
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x2C65000 Offset: 0x2C63A00 VA: 0x182C65000
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter filter) { }

	// RVA: 0x2C64F20 Offset: 0x2C63920 VA: 0x182C64F20
	private static bool SamplePositionFilter(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask) { }

	// RVA: 0x2C64A50 Offset: 0x2C63450 VA: 0x182C64A50
	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, NavMeshQueryFilter filter, NavMeshPath path) { }

	// RVA: 0x2C64820 Offset: 0x2C63220 VA: 0x182C64820
	private static bool CalculatePathFilterInternal(Vector3 sourcePosition, Vector3 targetPosition, NavMeshPath path, int type, int mask, float[] costs) { }

	// RVA: 0x2C64B70 Offset: 0x2C63570 VA: 0x182C64B70
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	[StaticAccessor("GetNavMeshProjectSettings()")]
	// RVA: 0x2C64C70 Offset: 0x2C63670 VA: 0x182C64C70
	public static int GetSettingsCount() { }

	// RVA: 0x2C64C10 Offset: 0x2C63610 VA: 0x182C64C10
	public static NavMeshBuildSettings GetSettingsByIndex(int index) { }

	// RVA: 0x2C64CA0 Offset: 0x2C636A0 VA: 0x182C64CA0
	public static string GetSettingsNameFromID(int agentTypeID) { }

	// RVA: 0x2C648A0 Offset: 0x2C632A0 VA: 0x182C648A0
	private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x2C64F90 Offset: 0x2C63990 VA: 0x182C64F90
	private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	// RVA: 0x2C645F0 Offset: 0x2C62FF0 VA: 0x182C645F0
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2C644B0 Offset: 0x2C62EB0 VA: 0x182C644B0
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2C64EB0 Offset: 0x2C638B0 VA: 0x182C64EB0
	private static bool SamplePositionFilter_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask) { }

	// RVA: 0x2C647B0 Offset: 0x2C631B0 VA: 0x182C647B0
	private static bool CalculatePathFilterInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, NavMeshPath path, int type, int mask, float[] costs) { }

	// RVA: 0x2C64B30 Offset: 0x2C63530 VA: 0x182C64B30
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

	// RVA: 0x2C64BD0 Offset: 0x2C635D0 VA: 0x182C64BD0
	private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret) { }
}
