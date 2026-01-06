public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13019
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x20F3E40 Offset: 0x20F2840 VA: 0x1820F3E40
	private void .ctor(bool fNull) { }

	// RVA: 0x10AC110 Offset: 0x10AAB10 VA: 0x1810AC110
	public void .ctor(int value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20F3E50 Offset: 0x20F2850 VA: 0x1820F3E50
	public int get_Value() { }

	// RVA: 0x20F45C0 Offset: 0x20F2FC0 VA: 0x1820F45C0
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x20F3D00 Offset: 0x20F2700 VA: 0x1820F3D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F4A20 Offset: 0x20F3420 VA: 0x1820F4A20
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x20F3EE0 Offset: 0x20F28E0 VA: 0x1820F3EE0
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F48E0 Offset: 0x20F32E0 VA: 0x1820F48E0
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F4780 Offset: 0x20F3180 VA: 0x1820F4780
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F4040 Offset: 0x20F2A40 VA: 0x1820F4040
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F4500 Offset: 0x20F2F00 VA: 0x1820F4500
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x20F45E0 Offset: 0x20F2FE0 VA: 0x1820F45E0
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x20F42C0 Offset: 0x20F2CC0 VA: 0x1820F42C0
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x20F37D0 Offset: 0x20F21D0 VA: 0x1820F37D0
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x20F41E0 Offset: 0x20F2BE0 VA: 0x1820F41E0
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F46A0 Offset: 0x20F30A0 VA: 0x1820F46A0
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F4420 Offset: 0x20F2E20 VA: 0x1820F4420
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F3770 Offset: 0x20F2170 VA: 0x1820F3770
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F3710 Offset: 0x20F2110 VA: 0x1820F3710
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x20F3A20 Offset: 0x20F2420 VA: 0x1820F3A20
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20F3BC0 Offset: 0x20F25C0 VA: 0x1820F3BC0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x20F3300 Offset: 0x20F1D00 VA: 0x1820F3300 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F3190 Offset: 0x20F1B90 VA: 0x1820F3190
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x20F3420 Offset: 0x20F1E20 VA: 0x1820F3420 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F3620 Offset: 0x20F2020 VA: 0x1820F3620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F37E0 Offset: 0x20F21E0 VA: 0x1820F37E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F3900 Offset: 0x20F2300 VA: 0x1820F3900 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F36A0 Offset: 0x20F20A0 VA: 0x1820F36A0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20F3D60 Offset: 0x20F2760 VA: 0x1820F3D60
	private static void .cctor() { }
}
