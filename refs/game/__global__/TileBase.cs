public abstract class TileBase : ScriptableObject // TypeDefIndex: 19039
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D8C950 Offset: 0x2D8B350 VA: 0x182D8C950 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2D8C870 Offset: 0x2D8B270 VA: 0x182D8C870
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x2D8C7A0 Offset: 0x2D8B1A0 VA: 0x182D8C7A0
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8C830 Offset: 0x2D8B230 VA: 0x182D8C830
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[RequiredByNativeCode]
	// RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[RequiredByNativeCode]
	// RVA: 0x2D8CAF0 Offset: 0x2D8B4F0 VA: 0x182D8CAF0
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
