public class RVOSquareObstacle : RVOObstacle // TypeDefIndex: 13433
{
	// Fields
	public float height; // 0xA0
	public Vector2 size; // 0xA4
	public Vector2 center; // 0xAC

	// Properties
	protected override bool StaticObstacle { get; }
	protected override bool ExecuteInEditor { get; }
	protected override bool LocalCoordinates { get; }
	protected override float Height { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	protected override bool get_StaticObstacle() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 11
	protected override bool get_ExecuteInEditor() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 12
	protected override bool get_LocalCoordinates() { }

	// RVA: 0x8B3450 Offset: 0x8B1E50 VA: 0x1808B3450 Slot: 14
	protected override float get_Height() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	protected override bool AreGizmosDirty() { }

	// RVA: 0xBC79B0 Offset: 0xBC63B0 VA: 0x180BC79B0 Slot: 10
	protected override void CreateObstacles() { }

	// RVA: 0xBC7B70 Offset: 0xBC6570 VA: 0x180BC7B70
	public void .ctor() { }
}
