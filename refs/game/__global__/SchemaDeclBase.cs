internal abstract class SchemaDeclBase // TypeDefIndex: 8377
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x242C280 Offset: 0x242AC80 VA: 0x18242C280
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x242C340 Offset: 0x242AD40 VA: 0x18242C340
	protected void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x242C400 Offset: 0x242AE00 VA: 0x18242C400
	internal string get_Prefix() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Prefix(string value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal long get_MaxLength() { }

	// RVA: 0xCC6410 Offset: 0xCC4E10 VA: 0x180CC6410
	internal void set_MaxLength(long value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal long get_MinLength() { }

	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	internal void set_MinLength(long value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x242C050 Offset: 0x242AA50 VA: 0x18242C050
	internal void AddValue(string value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal List<string> get_Values() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	internal void set_Values(List<string> value) { }

	// RVA: 0x242C3B0 Offset: 0x242ADB0 VA: 0x18242C3B0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal object get_DefaultValueTyped() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x242C150 Offset: 0x242AB50 VA: 0x18242C150
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x242C220 Offset: 0x242AC20 VA: 0x18242C220
	internal bool CheckValue(object pVal) { }
}
