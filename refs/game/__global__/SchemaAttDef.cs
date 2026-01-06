internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 8371
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x23FB9D0 Offset: 0x23FA3D0 VA: 0x1823FB9D0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x23FB9C0 Offset: 0x23FA3C0 VA: 0x1823FB9C0
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x23FB9E0 Offset: 0x23FA3E0 VA: 0x1823FB9E0
	private void .ctor() { }

	// RVA: 0x23FB8F0 Offset: 0x23FA2F0 VA: 0x1823FB8F0 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x13C7AA0 Offset: 0x13C64A0 VA: 0x1813C7AA0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x23FB8B0 Offset: 0x23FA2B0 VA: 0x1823FB8B0 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x23FB8E0 Offset: 0x23FA2E0 VA: 0x1823FB8E0 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x23FB900 Offset: 0x23FA300 VA: 0x1823FB900 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	internal int get_LinePosition() { }

	// RVA: 0xA9F820 Offset: 0xA9E220 VA: 0x180A9F820
	internal void set_LinePosition(int value) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	internal int get_LineNumber() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	internal void set_LineNumber(int value) { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	internal int get_ValueLinePosition() { }

	// RVA: 0xA9F810 Offset: 0xA9E210 VA: 0x180A9F810
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	internal int get_ValueLineNumber() { }

	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x23FB9F0 Offset: 0x23FA3F0 VA: 0x1823FB9F0
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x23FBA40 Offset: 0x23FA440 VA: 0x1823FBA40
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x23FBA70 Offset: 0x23FA470 VA: 0x1823FBA70
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x23FB590 Offset: 0x23F9F90 VA: 0x1823FB590
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x23FB850 Offset: 0x23FA250 VA: 0x1823FB850
	internal SchemaAttDef Clone() { }

	// RVA: 0x23FB950 Offset: 0x23FA350 VA: 0x1823FB950
	private static void .cctor() { }
}
