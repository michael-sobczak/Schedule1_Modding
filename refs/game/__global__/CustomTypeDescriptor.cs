public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 9700
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x26611A0 Offset: 0x265FBA0 VA: 0x1826611A0 Slot: 16
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x26612A0 Offset: 0x265FCA0 VA: 0x1826612A0 Slot: 17
	public virtual string GetClassName() { }

	// RVA: 0x26612F0 Offset: 0x265FCF0 VA: 0x1826612F0 Slot: 18
	public virtual string GetComponentName() { }

	// RVA: 0x2661340 Offset: 0x265FD40 VA: 0x182661340 Slot: 19
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x2661440 Offset: 0x265FE40 VA: 0x182661440 Slot: 20
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x2661500 Offset: 0x265FF00 VA: 0x182661500 Slot: 21
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x26615C0 Offset: 0x265FFC0 VA: 0x1826615C0 Slot: 22
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x2661620 Offset: 0x2660020 VA: 0x182661620 Slot: 23
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x2661720 Offset: 0x2660120 VA: 0x182661720 Slot: 24
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x2661940 Offset: 0x2660340 VA: 0x182661940 Slot: 25
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x2661830 Offset: 0x2660230 VA: 0x182661830 Slot: 26
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x2661A40 Offset: 0x2660440 VA: 0x182661A40 Slot: 27
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }
}
