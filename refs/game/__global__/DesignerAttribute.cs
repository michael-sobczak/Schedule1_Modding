public sealed class DesignerAttribute : Attribute // TypeDefIndex: 9783
{
	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public string DesignerBaseTypeName { get; }
	public string DesignerTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x26646D0 Offset: 0x26630D0 VA: 0x1826646D0
	public void .ctor(string designerTypeName) { }

	// RVA: 0x26647C0 Offset: 0x26631C0 VA: 0x1826647C0
	public void .ctor(Type designerType) { }

	// RVA: 0x26648A0 Offset: 0x26632A0 VA: 0x1826648A0
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x2664610 Offset: 0x2663010 VA: 0x182664610
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_DesignerTypeName() { }

	// RVA: 0x2664950 Offset: 0x2663350 VA: 0x182664950 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x2664560 Offset: 0x2662F60 VA: 0x182664560 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2167AC0 Offset: 0x21664C0 VA: 0x182167AC0 Slot: 2
	public override int GetHashCode() { }
}
