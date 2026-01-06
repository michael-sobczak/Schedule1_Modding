public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13021
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x20EF9F0 Offset: 0x20EE3F0 VA: 0x1820EF9F0
	private void .ctor(bool fNull) { }

	// RVA: 0x10AC180 Offset: 0x10AAB80 VA: 0x1810AC180
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x20F8270 Offset: 0x20F6C70 VA: 0x1820F8270
	public void .ctor(int value) { }

	// RVA: 0x20F8170 Offset: 0x20F6B70 VA: 0x1820F8170
	public void .ctor(long value) { }

	// RVA: 0x20F82E0 Offset: 0x20F6CE0 VA: 0x1820F82E0
	public void .ctor(Decimal value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20F84D0 Offset: 0x20F6ED0 VA: 0x1820F84D0
	public Decimal get_Value() { }

	// RVA: 0x20F7A50 Offset: 0x20F6450 VA: 0x1820F7A50
	public Decimal ToDecimal() { }

	// RVA: 0x20F7B60 Offset: 0x20F6560 VA: 0x1820F7B60
	public double ToDouble() { }

	// RVA: 0x20F8C60 Offset: 0x20F7660 VA: 0x1820F8C60
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x20F8E60 Offset: 0x20F7860 VA: 0x1820F8E60
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x20F7F20 Offset: 0x20F6920 VA: 0x1820F7F20 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F9390 Offset: 0x20F7D90 VA: 0x1820F9390
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x20F8580 Offset: 0x20F6F80 VA: 0x1820F8580
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F9200 Offset: 0x20F7C00 VA: 0x1820F9200
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F9090 Offset: 0x20F7A90 VA: 0x1820F9090
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F8710 Offset: 0x20F7110 VA: 0x1820F8710
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F8D90 Offset: 0x20F7790 VA: 0x1820F8D90
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x20F8B90 Offset: 0x20F7590 VA: 0x1820F8B90
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x20F8C90 Offset: 0x20F7690 VA: 0x1820F8C90
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x20F8EB0 Offset: 0x20F78B0 VA: 0x1820F8EB0
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x20F8950 Offset: 0x20F7350 VA: 0x1820F8950
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x20F8880 Offset: 0x20F7280 VA: 0x1820F8880
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F8FC0 Offset: 0x20F79C0 VA: 0x1820F8FC0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F8AC0 Offset: 0x20F74C0 VA: 0x1820F8AC0
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F7680 Offset: 0x20F6080 VA: 0x1820F7680
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F7580 Offset: 0x20F5F80 VA: 0x1820F7580
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x20F7D30 Offset: 0x20F6730 VA: 0x1820F7D30
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20F7BF0 Offset: 0x20F65F0 VA: 0x1820F7BF0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x20F7150 Offset: 0x20F5B50 VA: 0x1820F7150 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F6F20 Offset: 0x20F5920 VA: 0x1820F6F20
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x20F7280 Offset: 0x20F5C80 VA: 0x1820F7280 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F74B0 Offset: 0x20F5EB0 VA: 0x1820F74B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F7780 Offset: 0x20F6180 VA: 0x1820F7780 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F7900 Offset: 0x20F6300 VA: 0x1820F7900 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F7510 Offset: 0x20F5F10 VA: 0x1820F7510
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20F7FF0 Offset: 0x20F69F0 VA: 0x1820F7FF0
	private static void .cctor() { }
}
