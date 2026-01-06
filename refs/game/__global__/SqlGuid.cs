public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13017
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x20CB750 Offset: 0x20CA150 VA: 0x1820CB750
	private void .ctor(bool fNull) { }

	// RVA: 0x20F1640 Offset: 0x20F0040 VA: 0x1820F1640
	public void .ctor(Guid g) { }

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20F1670 Offset: 0x20F0070 VA: 0x1820F1670
	public Guid get_Value() { }

	// RVA: 0x20F1900 Offset: 0x20F0300 VA: 0x1820F1900
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x20F14D0 Offset: 0x20EFED0 VA: 0x1820F14D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F0DF0 Offset: 0x20EF7F0 VA: 0x1820F0DF0
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x20F1720 Offset: 0x20F0120 VA: 0x1820F1720
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x20F1940 Offset: 0x20F0340 VA: 0x1820F1940
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x20F1810 Offset: 0x20F0210 VA: 0x1820F1810
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x20F09F0 Offset: 0x20EF3F0 VA: 0x1820F09F0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F0B10 Offset: 0x20EF510 VA: 0x1820F0B10
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x20F0F00 Offset: 0x20EF900 VA: 0x1820F0F00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F10E0 Offset: 0x20EFAE0 VA: 0x1820F10E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F1260 Offset: 0x20EFC60 VA: 0x1820F1260 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F1390 Offset: 0x20EFD90 VA: 0x1820F1390 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F11F0 Offset: 0x20EFBF0 VA: 0x1820F11F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20F1550 Offset: 0x20EFF50 VA: 0x1820F1550
	private static void .cctor() { }
}
