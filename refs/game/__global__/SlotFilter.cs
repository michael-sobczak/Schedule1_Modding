public class SlotFilter // TypeDefIndex: 3088
{
	// Fields
	public SlotFilter.EType Type; // 0x10
	public List<string> ItemIDs; // 0x18
	public List<EQuality> AllowedQualities; // 0x20

	// Methods

	// RVA: 0x9A6000 Offset: 0x9A4A00 VA: 0x1809A6000
	public void .ctor() { }

	// RVA: 0x9A5E40 Offset: 0x9A4840 VA: 0x1809A5E40
	public bool DoesItemMatchFilter(ItemInstance instance) { }

	// RVA: 0x9A5F90 Offset: 0x9A4990 VA: 0x1809A5F90
	public bool IsDefault() { }

	// RVA: 0x9A5D20 Offset: 0x9A4720 VA: 0x1809A5D20
	public SlotFilter Clone() { }
}
