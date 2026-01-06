public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13020
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x20EF9F0 Offset: 0x20EE3F0 VA: 0x1820EF9F0
	private void .ctor(bool fNull) { }

	// RVA: 0x10AC180 Offset: 0x10AAB80 VA: 0x1810AC180
	public void .ctor(long value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20F5CF0 Offset: 0x20F46F0 VA: 0x1820F5CF0
	public long get_Value() { }

	// RVA: 0x20F6740 Offset: 0x20F5140 VA: 0x1820F6740
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x20F5BA0 Offset: 0x20F45A0 VA: 0x1820F5BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F6E70 Offset: 0x20F5870 VA: 0x1820F6E70
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x20F5D50 Offset: 0x20F4750 VA: 0x1820F5D50
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F6CF0 Offset: 0x20F56F0 VA: 0x1820F6CF0
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F69C0 Offset: 0x20F53C0 VA: 0x1820F69C0
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F5EC0 Offset: 0x20F48C0 VA: 0x1820F5EC0
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F6830 Offset: 0x20F5230 VA: 0x1820F6830
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F6670 Offset: 0x20F5070 VA: 0x1820F6670
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x20F65A0 Offset: 0x20F4FA0 VA: 0x1820F65A0
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x20F64A0 Offset: 0x20F4EA0 VA: 0x1820F64A0
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x20F6120 Offset: 0x20F4B20 VA: 0x1820F6120
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x20F5380 Offset: 0x20F3D80 VA: 0x1820F5380
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x20F6050 Offset: 0x20F4A50 VA: 0x1820F6050
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F6760 Offset: 0x20F5160 VA: 0x1820F6760
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F63D0 Offset: 0x20F4DD0 VA: 0x1820F63D0
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F5280 Offset: 0x20F3C80 VA: 0x1820F5280
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F5180 Offset: 0x20F3B80 VA: 0x1820F5180
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x20F55E0 Offset: 0x20F3FE0 VA: 0x1820F55E0
	public SqlByte ToSqlByte() { }

	// RVA: 0x20F5760 Offset: 0x20F4160 VA: 0x1820F5760
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20F58E0 Offset: 0x20F42E0 VA: 0x1820F58E0
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x20F5A40 Offset: 0x20F4440 VA: 0x1820F5A40
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x20F5640 Offset: 0x20F4040 VA: 0x1820F5640
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x20F4CF0 Offset: 0x20F36F0 VA: 0x1820F4CF0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F4AC0 Offset: 0x20F34C0 VA: 0x1820F4AC0
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x20F4E20 Offset: 0x20F3820 VA: 0x1820F4E20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F5050 Offset: 0x20F3A50 VA: 0x1820F5050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F53A0 Offset: 0x20F3DA0 VA: 0x1820F53A0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F54C0 Offset: 0x20F3EC0 VA: 0x1820F54C0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F5110 Offset: 0x20F3B10 VA: 0x1820F5110
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20F5C00 Offset: 0x20F4600 VA: 0x1820F5C00
	private static void .cctor() { }
}
