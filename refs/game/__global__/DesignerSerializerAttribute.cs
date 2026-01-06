public sealed class DesignerSerializerAttribute : Attribute // TypeDefIndex: 9843
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x20

	// Properties
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x269FB40 Offset: 0x269E540 VA: 0x18269FB40
	public void .ctor(string serializerTypeName, string baseSerializerTypeName) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x269FB90 Offset: 0x269E590 VA: 0x18269FB90 Slot: 4
	public override object get_TypeId() { }
}
