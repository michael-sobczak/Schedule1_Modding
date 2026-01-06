public class ITilemap // TypeDefIndex: 19036
{
	// Fields
	internal static ITilemap s_Instance; // 0x0
	internal Tilemap m_Tilemap; // 0x10
	internal bool m_AddToList; // 0x18
	internal int m_RefreshCount; // 0x1C
	internal NativeArray<Vector3Int> m_RefreshPos; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2D8C610 Offset: 0x2D8B010 VA: 0x182D8C610
	public void RefreshTile(Vector3Int position) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8BF70 Offset: 0x2D8A970 VA: 0x182D8BF70
	private static ITilemap CreateInstance() { }

	[RequiredByNativeCode]
	// RVA: 0x2D8BFF0 Offset: 0x2D8A9F0 VA: 0x182D8BFF0
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8C380 Offset: 0x2D8AD80 VA: 0x182D8C380
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }
}
