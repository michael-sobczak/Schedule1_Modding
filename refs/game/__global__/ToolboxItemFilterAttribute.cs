public sealed class ToolboxItemFilterAttribute : Attribute // TypeDefIndex: 9755
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <FilterString>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ToolboxItemFilterType <FilterType>k__BackingField; // 0x20

	// Properties
	public string FilterString { get; }
	public ToolboxItemFilterType FilterType { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2678730 Offset: 0x2677130 VA: 0x182678730
	public void .ctor(string filterString) { }

	// RVA: 0x26786A0 Offset: 0x26770A0 VA: 0x1826786A0
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_FilterString() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x26787B0 Offset: 0x26771B0 VA: 0x1826787B0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x2678430 Offset: 0x2676E30 VA: 0x182678430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20749B0 Offset: 0x20733B0 VA: 0x1820749B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2678530 Offset: 0x2676F30 VA: 0x182678530 Slot: 5
	public override bool Match(object obj) { }

	// RVA: 0x26785B0 Offset: 0x2676FB0 VA: 0x1826785B0 Slot: 3
	public override string ToString() { }
}
