public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13022
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x20F3E40 Offset: 0x20F2840 VA: 0x1820F3E40
	private void .ctor(bool fNull) { }

	// RVA: 0x20FA410 Offset: 0x20F8E10 VA: 0x1820FA410
	public void .ctor(float value) { }

	// RVA: 0x20FA3B0 Offset: 0x20F8DB0 VA: 0x1820FA3B0
	public void .ctor(double value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20FA490 Offset: 0x20F8E90 VA: 0x1820FA490
	public float get_Value() { }

	// RVA: 0x20FB230 Offset: 0x20F9C30 VA: 0x1820FB230
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x20FA160 Offset: 0x20F8B60 VA: 0x1820FA160 Slot: 3
	public override string ToString() { }

	// RVA: 0x20FB810 Offset: 0x20FA210 VA: 0x1820FB810
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x20FA4F0 Offset: 0x20F8EF0 VA: 0x1820FA4F0
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FB680 Offset: 0x20FA080 VA: 0x1820FB680
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FB4F0 Offset: 0x20F9EF0 VA: 0x1820FB4F0
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FA680 Offset: 0x20F9080 VA: 0x1820FA680
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FB110 Offset: 0x20F9B10 VA: 0x1820FB110
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x20FAFF0 Offset: 0x20F99F0 VA: 0x1820FAFF0
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x20FB2C0 Offset: 0x20F9CC0 VA: 0x1820FB2C0
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x20FAE90 Offset: 0x20F9890 VA: 0x1820FAE90
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x20FAB80 Offset: 0x20F9580 VA: 0x1820FAB80
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x20FACE0 Offset: 0x20F96E0 VA: 0x1820FACE0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x20FA910 Offset: 0x20F9310 VA: 0x1820FA910
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x20FA810 Offset: 0x20F9210 VA: 0x1820FA810
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FB410 Offset: 0x20F9E10 VA: 0x1820FB410
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20FAAA0 Offset: 0x20F94A0 VA: 0x1820FAAA0
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20F9D40 Offset: 0x20F8740 VA: 0x1820F9D40
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20F9CE0 Offset: 0x20F86E0 VA: 0x1820F9CE0
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x20F9FF0 Offset: 0x20F89F0 VA: 0x1820F9FF0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20F9880 Offset: 0x20F8280 VA: 0x1820F9880 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20F9710 Offset: 0x20F8110 VA: 0x1820F9710
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x20F99A0 Offset: 0x20F83A0 VA: 0x1820F99A0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20F9BB0 Offset: 0x20F85B0 VA: 0x1820F9BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20F9DA0 Offset: 0x20F87A0 VA: 0x1820F9DA0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20F9EC0 Offset: 0x20F88C0 VA: 0x1820F9EC0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20F9C70 Offset: 0x20F8670 VA: 0x1820F9C70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20FA1C0 Offset: 0x20F8BC0 VA: 0x1820FA1C0
	private static void .cctor() { }
}
