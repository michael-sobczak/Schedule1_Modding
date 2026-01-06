public class SlotInfo : Attribute, IComparable // TypeDefIndex: 10694
{
	// Fields
	[NotNull]
	[ItemNotNull]
	public readonly Type[] DataTypes; // 0x10
	public string Name; // 0x18
	private string displayName; // 0x20
	public string Tooltip; // 0x28
	public bool Array; // 0x30
	public SlotInfo.SlotArrayType ArrayType; // 0x34

	// Properties
	public string DisplayName { get; set; }

	// Methods

	// RVA: 0x527520 Offset: 0x525F20 VA: 0x180527520
	public string get_DisplayName() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DisplayName(string value) { }

	// RVA: 0x5274C0 Offset: 0x525EC0 VA: 0x1805274C0
	protected void .ctor(string name, Type[] type) { }

	// RVA: 0x527470 Offset: 0x525E70 VA: 0x180527470
	protected void .ctor(Type[] type) { }

	// RVA: 0x5273E0 Offset: 0x525DE0 VA: 0x1805273E0 Slot: 7
	public int CompareTo(object obj) { }

	// RVA: 0x527250 Offset: 0x525C50 VA: 0x180527250
	public void CheckDataTypes() { }
}
