public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 9845
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Properties
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x26B4A00 Offset: 0x26B3400 VA: 0x1826B4A00
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x26B4A70 Offset: 0x26B3470 VA: 0x1826B4A70 Slot: 4
	public override object get_TypeId() { }
}
