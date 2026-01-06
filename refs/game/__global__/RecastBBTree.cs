public class RecastBBTree // TypeDefIndex: 13277
{
	// Fields
	private RecastBBTreeBox root; // 0x10

	// Methods

	// RVA: 0xB75130 Offset: 0xB73B30 VA: 0x180B75130
	public void QueryInBounds(Rect bounds, List<RecastMeshObj> buffer) { }

	// RVA: 0xB74F00 Offset: 0xB73900 VA: 0x180B74F00
	private void QueryBoxInBounds(RecastBBTreeBox box, Rect bounds, List<RecastMeshObj> boxes) { }

	// RVA: 0xB75480 Offset: 0xB73E80 VA: 0x180B75480
	public bool Remove(RecastMeshObj mesh) { }

	// RVA: 0xB751D0 Offset: 0xB73BD0 VA: 0x180B751D0
	private RecastBBTreeBox RemoveBox(RecastBBTreeBox c, RecastMeshObj mesh, Rect bounds, ref bool found) { }

	// RVA: 0xB74AC0 Offset: 0xB734C0 VA: 0x180B74AC0
	public void Insert(RecastMeshObj mesh) { }

	// RVA: 0xB75180 Offset: 0xB73B80 VA: 0x180B75180
	private static bool RectIntersectsRect(Rect r, Rect r2) { }

	// RVA: 0xB74A50 Offset: 0xB73450 VA: 0x180B74A50
	private static float ExpansionRequired(Rect r, Rect r2) { }

	// RVA: 0xB749D0 Offset: 0xB733D0 VA: 0x180B749D0
	private static Rect ExpandToContain(Rect r, Rect r2) { }

	// RVA: 0xB75170 Offset: 0xB73B70 VA: 0x180B75170
	private static float RectArea(Rect r) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
