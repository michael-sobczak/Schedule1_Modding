public class GridEntry // TypeDefIndex: 12658
{
	// Fields
	public Vector2Int Position; // 0x10
	public HashSet<GridEntry> NearbyEntries; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	public void .ctor(HashSet<GridEntry> nearby) { }

	// RVA: 0xD27DC0 Offset: 0xD267C0 VA: 0x180D27DC0
	public void SetValues(Vector2Int position, HashSet<GridEntry> nearby) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void SetValues(HashSet<GridEntry> nearby) { }

	// RVA: 0xCC46F0 Offset: 0xCC30F0 VA: 0x180CC46F0
	public void SetValues(Vector2Int position) { }

	// RVA: 0xD27D40 Offset: 0xD26740 VA: 0x180D27D40
	public void Reset() { }
}
