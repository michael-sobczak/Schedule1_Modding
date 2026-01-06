internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 4450
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B56610 Offset: 0x1B55010 VA: 0x181B56610 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B564A0 Offset: 0x1B54EA0 VA: 0x181B564A0
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B56580 Offset: 0x1B54F80 VA: 0x181B56580 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B56670 Offset: 0x1B55070 VA: 0x181B56670 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B56220 Offset: 0x1B54C20 VA: 0x181B56220 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B56250 Offset: 0x1B54C50 VA: 0x181B56250 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B56430 Offset: 0x1B54E30 VA: 0x181B56430 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B565E0 Offset: 0x1B54FE0 VA: 0x181B565E0 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0xFDBC40 Offset: 0xFDA640 VA: 0x180FDBC40 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x1B56280 Offset: 0x1B54C80 VA: 0x181B56280
	internal object InternalGetValue(object obj) { }

	// RVA: 0x1B56460 Offset: 0x1B54E60 VA: 0x181B56460 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x1B56330 Offset: 0x1B54D30 VA: 0x181B56330
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x1B565B0 Offset: 0x1B54FB0 VA: 0x181B565B0 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x1B56550 Offset: 0x1B54F50 VA: 0x181B56550 Slot: 16
	public override FieldAttributes get_Attributes() { }
}
