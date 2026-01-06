public class ItemList : Option // TypeDefIndex: 1257
{
	// Fields
	public bool All; // 0x18
	public bool None; // 0x19
	public List<string> Selection; // 0x20
	[CompilerGenerated]
	private bool <CanBeAll>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <CanBeNone>k__BackingField; // 0x29
	[CompilerGenerated]
	private List<string> <OptionList>k__BackingField; // 0x30

	// Properties
	public bool CanBeAll { get; set; }
	public bool CanBeNone { get; set; }
	public List<string> OptionList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_CanBeAll() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_CanBeAll(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_CanBeNone() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	protected void set_CanBeNone(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<string> get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_OptionList(List<string> value) { }

	// RVA: 0x611D40 Offset: 0x610740 VA: 0x180611D40
	public void .ctor(string name, List<string> optionList, bool canBeAll, bool canBeNone) { }

	// RVA: 0x611A20 Offset: 0x610420 VA: 0x180611A20 Slot: 4
	public override void CopyTo(Option other) { }

	// RVA: 0x611B60 Offset: 0x610560 VA: 0x180611B60 Slot: 5
	public override string GetDisplayString() { }
}
