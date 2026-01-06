public sealed class ProvidePropertyAttribute : Attribute // TypeDefIndex: 9744
{
	// Fields
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Properties
	public string PropertyName { get; }
	public string ReceiverTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x266FC50 Offset: 0x266E650 VA: 0x18266FC50
	public void .ctor(string propertyName, Type receiverType) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_ReceiverTypeName() { }

	// RVA: 0x266FBA0 Offset: 0x266E5A0 VA: 0x18266FBA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2167AC0 Offset: 0x21664C0 VA: 0x182167AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2646FE0 Offset: 0x26459E0 VA: 0x182646FE0 Slot: 4
	public override object get_TypeId() { }
}
