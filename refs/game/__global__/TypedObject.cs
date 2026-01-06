internal class TypedObject // TypeDefIndex: 8251
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_Dim() { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_IsList() { }

	// RVA: 0x256CAA0 Offset: 0x256B4A0 VA: 0x18256CAA0
	public bool get_IsDecimal() { }

	// RVA: 0x1B1E570 Offset: 0x1B1CF70 VA: 0x181B1E570
	public Decimal[] get_Dvalue() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public object get_Value() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x256C920 Offset: 0x256B320 VA: 0x18256C920
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x256C670 Offset: 0x256B070 VA: 0x18256C670
	public void SetDecimal() { }

	// RVA: 0x256C550 Offset: 0x256AF50 VA: 0x18256C550
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x256C1B0 Offset: 0x256ABB0 VA: 0x18256C1B0
	public bool Equals(TypedObject other) { }
}
