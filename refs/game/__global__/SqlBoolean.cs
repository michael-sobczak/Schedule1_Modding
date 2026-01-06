public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13009
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x20CC850 Offset: 0x20CB250 VA: 0x1820CC850
	public void .ctor(bool value) { }

	// RVA: 0x20CC7D0 Offset: 0x20CB1D0 VA: 0x1820CC7D0
	public void .ctor(int value) { }

	// RVA: 0x20CC830 Offset: 0x20CB230 VA: 0x1820CC830
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20CC920 Offset: 0x20CB320 VA: 0x1820CC920
	public bool get_Value() { }

	// RVA: 0x20CC910 Offset: 0x20CB310 VA: 0x1820CC910
	public bool get_IsTrue() { }

	// RVA: 0x20CC8F0 Offset: 0x20CB2F0 VA: 0x1820CC8F0
	public bool get_IsFalse() { }

	// RVA: 0x20CCBF0 Offset: 0x20CB5F0 VA: 0x1820CCBF0
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x20CCC00 Offset: 0x20CB600 VA: 0x1820CCC00
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x20CC980 Offset: 0x20CB380 VA: 0x1820CC980
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x20CCA60 Offset: 0x20CB460 VA: 0x1820CCA60
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x20CC860 Offset: 0x20CB260 VA: 0x1820CC860
	public byte get_ByteValue() { }

	// RVA: 0x20CC5E0 Offset: 0x20CAFE0 VA: 0x1820CC5E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20CCB40 Offset: 0x20CB540 VA: 0x1820CCB40
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x20CBC50 Offset: 0x20CA650 VA: 0x1820CBC50
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x20CC2A0 Offset: 0x20CACA0 VA: 0x1820CC2A0
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x20CBE80 Offset: 0x20CA880 VA: 0x1820CBE80 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20CBD60 Offset: 0x20CA760 VA: 0x1820CBD60
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x20CBFA0 Offset: 0x20CA9A0 VA: 0x1820CBFA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20CC150 Offset: 0x20CAB50 VA: 0x1820CC150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20CC3B0 Offset: 0x20CADB0 VA: 0x1820CC3B0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20CC4D0 Offset: 0x20CAED0 VA: 0x1820CC4D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20CC230 Offset: 0x20CAC30 VA: 0x1820CC230
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20CC6E0 Offset: 0x20CB0E0 VA: 0x1820CC6E0
	private static void .cctor() { }
}
