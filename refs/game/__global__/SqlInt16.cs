public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13018
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x20F2690 Offset: 0x20F1090 VA: 0x1820F2690
	private void .ctor(bool fNull) { }

	// RVA: 0x10AC1C0 Offset: 0x10AABC0 VA: 0x1810AC1C0
	public void .ctor(short value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20F26A0 Offset: 0x20F10A0 VA: 0x1820F26A0
	public short get_Value() { }

	// RVA: 0x20F2D70 Offset: 0x20F1770 VA: 0x1820F2D70
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x20F2570 Offset: 0x20F0F70 VA: 0x1820F2570 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F30F0 Offset: 0x20F1AF0 VA: 0x1820F30F0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x20F2700 Offset: 0x20F1100 VA: 0x1820F2700
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2FD0 Offset: 0x20F19D0 VA: 0x1820F2FD0
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2E70 Offset: 0x20F1870 VA: 0x1820F2E70
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2820 Offset: 0x20F1220 VA: 0x1820F2820
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2CB0 Offset: 0x20F16B0 VA: 0x1820F2CB0
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x20F2A80 Offset: 0x20F1480 VA: 0x1820F2A80
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x20F29A0 Offset: 0x20F13A0 VA: 0x1820F29A0
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2D90 Offset: 0x20F1790 VA: 0x1820F2D90
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2BD0 Offset: 0x20F15D0 VA: 0x1820F2BD0
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F2050 Offset: 0x20F0A50 VA: 0x1820F2050
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F1FF0 Offset: 0x20F09F0 VA: 0x1820F1FF0
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x20F22F0 Offset: 0x20F0CF0 VA: 0x1820F22F0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20F2460 Offset: 0x20F0E60 VA: 0x1820F2460
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x20F1A30 Offset: 0x20F0430 VA: 0x1820F1A30 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F1B50 Offset: 0x20F0550 VA: 0x1820F1B50
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x20F1CC0 Offset: 0x20F06C0 VA: 0x1820F1CC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F1EC0 Offset: 0x20F08C0 VA: 0x1820F1EC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F20B0 Offset: 0x20F0AB0 VA: 0x1820F20B0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F21D0 Offset: 0x20F0BD0 VA: 0x1820F21D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F1F80 Offset: 0x20F0980 VA: 0x1820F1F80
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20F25D0 Offset: 0x20F0FD0 VA: 0x1820F25D0
	private static void .cctor() { }
}
