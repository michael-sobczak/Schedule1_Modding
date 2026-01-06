public sealed class Tilemap : GridLayout // TypeDefIndex: 19042
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Tilemap, Tilemap.SyncTile[]> tilemapTileChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged; // 0x8
	private bool m_BufferSyncTile; // 0x18

	// Properties
	internal bool bufferSyncTile { get; }

	// Methods

	// RVA: 0x2D8D6C0 Offset: 0x2D8C0C0 VA: 0x182D8D6C0
	internal bool get_bufferSyncTile() { }

	// RVA: 0x2D8D430 Offset: 0x2D8BE30 VA: 0x182D8D430
	internal static bool HasSyncTileCallback() { }

	// RVA: 0x2D8D3F0 Offset: 0x2D8BDF0 VA: 0x182D8D3F0
	internal static bool HasPositionsChangedCallback() { }

	// RVA: 0x2D8D300 Offset: 0x2D8BD00 VA: 0x182D8D300
	private void HandleSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x2D8D260 Offset: 0x2D8BC60 VA: 0x182D8D260
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x2D8D620 Offset: 0x2D8C020 VA: 0x182D8D620
	private void SendTilemapTileChangedCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x2D8D570 Offset: 0x2D8BF70 VA: 0x182D8D570
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[NativeMethod(Name = "RefreshTileAsset")]
	// RVA: 0x2D8D4C0 Offset: 0x2D8BEC0 VA: 0x182D8D4C0
	public void RefreshTile(Vector3Int position) { }

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	// RVA: 0x2D8D510 Offset: 0x2D8BF10 VA: 0x182D8D510
	internal void RefreshTilesNative(void* positions, int count) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8D360 Offset: 0x2D8BD60 VA: 0x182D8D360
	internal void GetSyncTileCallbackSettings(ref Tilemap.SyncTileCallbackSettings settings) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8D300 Offset: 0x2D8BD00 VA: 0x182D8D300
	private void DoSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8D260 Offset: 0x2D8BC60 VA: 0x182D8D260
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x2D8D470 Offset: 0x2D8BE70 VA: 0x182D8D470
	private void RefreshTile_Injected(ref Vector3Int position) { }
}
