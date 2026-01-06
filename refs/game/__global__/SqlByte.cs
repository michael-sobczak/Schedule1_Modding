public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13010
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x20E1F40 Offset: 0x20E0940 VA: 0x1820E1F40
	private void .ctor(bool fNull) { }

	// RVA: 0x10AC440 Offset: 0x10AAE40 VA: 0x1810AC440
	public void .ctor(byte value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20E1F50 Offset: 0x20E0950 VA: 0x1820E1F50
	public byte get_Value() { }

	// RVA: 0x20E25B0 Offset: 0x20E0FB0 VA: 0x1820E25B0
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x20E1E20 Offset: 0x20E0820 VA: 0x1820E1E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20E1FB0 Offset: 0x20E09B0 VA: 0x1820E1FB0
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x20E27D0 Offset: 0x20E11D0 VA: 0x1820E27D0
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x20E26A0 Offset: 0x20E10A0 VA: 0x1820E26A0
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x20E20E0 Offset: 0x20E0AE0 VA: 0x1820E20E0
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x20E22E0 Offset: 0x20E0CE0 VA: 0x1820E22E0
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x20E2200 Offset: 0x20E0C00 VA: 0x1820E2200
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x20E25C0 Offset: 0x20E0FC0 VA: 0x1820E25C0
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x20E24D0 Offset: 0x20E0ED0 VA: 0x1820E24D0
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x20E18F0 Offset: 0x20E02F0 VA: 0x1820E18F0
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x20E1890 Offset: 0x20E0290 VA: 0x1820E1890
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x20E1B90 Offset: 0x20E0590 VA: 0x1820E1B90
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20E1D10 Offset: 0x20E0710 VA: 0x1820E1D10
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x20E1440 Offset: 0x20DFE40 VA: 0x1820E1440 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20E12D0 Offset: 0x20DFCD0 VA: 0x1820E12D0
	public int CompareTo(SqlByte value) { }

	// RVA: 0x20E1560 Offset: 0x20DFF60 VA: 0x1820E1560 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20E1760 Offset: 0x20E0160 VA: 0x1820E1760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20E1950 Offset: 0x20E0350 VA: 0x1820E1950 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20E1A70 Offset: 0x20E0470 VA: 0x1820E1A70 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20E1820 Offset: 0x20E0220 VA: 0x1820E1820
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20E1E80 Offset: 0x20E0880 VA: 0x1820E1E80
	private static void .cctor() { }
}
