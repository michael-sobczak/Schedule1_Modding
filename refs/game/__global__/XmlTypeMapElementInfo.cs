internal class XmlTypeMapElementInfo // TypeDefIndex: 8211
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0x2573260 Offset: 0x2571C60 VA: 0x182573260
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public TypeData get_TypeData() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public object get_ChoiceValue() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_ChoiceValue(object value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_ElementName() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_ElementName(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Namespace() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Namespace(string value) { }

	// RVA: 0x2573350 Offset: 0x2571D50 VA: 0x182573350
	public string get_DataTypeNamespace() { }

	// RVA: 0x2573320 Offset: 0x2571D20 VA: 0x182573320
	public string get_DataTypeName() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public XmlSchemaForm get_Form() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_IsNullable() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_IsNullable(bool value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public XmlTypeMapMember get_Member() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_NestingLevel(int value) { }

	// RVA: 0x2573460 Offset: 0x2571E60 VA: 0x182573460
	public bool get_MultiReferenceType() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_WrappedElement() { }

	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	public void set_WrappedElement(bool value) { }

	// RVA: 0x25733D0 Offset: 0x2571DD0 VA: 0x1825733D0
	public bool get_IsTextElement() { }

	// RVA: 0x2573480 Offset: 0x2571E80 VA: 0x182573480
	public void set_IsTextElement(bool value) { }

	// RVA: 0x2573410 Offset: 0x2571E10 VA: 0x182573410
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x2573550 Offset: 0x2571F50 VA: 0x182573550
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_ExplicitOrder() { }

	// RVA: 0xD80F50 Offset: 0xD7F950 VA: 0x180D80F50
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x2573120 Offset: 0x2571B20 VA: 0x182573120 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }
}
