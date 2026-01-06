public sealed class EditorAttribute : Attribute // TypeDefIndex: 9712
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Properties
	public string EditorBaseTypeName { get; }
	public string EditorTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2664E80 Offset: 0x2663880 VA: 0x182664E80
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x2664DC0 Offset: 0x26637C0 VA: 0x182664DC0
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x2664D30 Offset: 0x2663730 VA: 0x182664D30
	public void .ctor(Type type, Type baseType) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_EditorTypeName() { }

	// RVA: 0x2664F30 Offset: 0x2663930 VA: 0x182664F30 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x2664C80 Offset: 0x2663680 VA: 0x182664C80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }
}
