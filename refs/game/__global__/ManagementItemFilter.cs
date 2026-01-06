public class ManagementItemFilter // TypeDefIndex: 1241
{
	// Fields
	[CompilerGenerated]
	private ManagementItemFilter.EMode <Mode>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<ItemDefinition> <Items>k__BackingField; // 0x18

	// Properties
	public ManagementItemFilter.EMode Mode { get; set; }
	public List<ItemDefinition> Items { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public ManagementItemFilter.EMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_Mode(ManagementItemFilter.EMode value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<ItemDefinition> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Items(List<ItemDefinition> value) { }

	// RVA: 0x61A090 Offset: 0x618A90 VA: 0x18061A090
	public void .ctor(ManagementItemFilter.EMode mode) { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void SetMode(ManagementItemFilter.EMode mode) { }

	// RVA: 0x619D80 Offset: 0x618780 VA: 0x180619D80
	public void AddItem(ItemDefinition item) { }

	// RVA: 0x61A030 Offset: 0x618A30 VA: 0x18061A030
	public void RemoveItem(ItemDefinition item) { }

	// RVA: 0x619E30 Offset: 0x618830 VA: 0x180619E30
	public bool Contains(ItemDefinition item) { }

	// RVA: 0x619E90 Offset: 0x618890 VA: 0x180619E90
	public bool DoesItemMeetFilter(ItemInstance item) { }

	// RVA: 0x619F40 Offset: 0x618940 VA: 0x180619F40
	public string GetDescription() { }
}
