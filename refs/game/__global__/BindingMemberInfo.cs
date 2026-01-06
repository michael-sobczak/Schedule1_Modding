public struct BindingMemberInfo // TypeDefIndex: 5245
{
	// Fields
	private string data_member; // 0x0
	private string data_field; // 0x8
	private string data_path; // 0x10

	// Properties
	public string BindingField { get; }
	public string BindingPath { get; }

	// Methods

	// RVA: 0x21C4C60 Offset: 0x21C3660 VA: 0x1821C4C60
	public void .ctor(string dataMember) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public string get_BindingField() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_BindingPath() { }

	// RVA: 0x21C4AF0 Offset: 0x21C34F0 VA: 0x1821C4AF0 Slot: 0
	public override bool Equals(object otherObject) { }

	// RVA: 0x21C4C40 Offset: 0x21C3640 VA: 0x1821C4C40 Slot: 2
	public override int GetHashCode() { }
}
