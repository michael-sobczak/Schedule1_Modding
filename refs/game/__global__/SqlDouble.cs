public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13016
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x20EF9F0 Offset: 0x20EE3F0 VA: 0x1820EF9F0
	private void .ctor(bool fNull) { }

	// RVA: 0x20EF960 Offset: 0x20EE360 VA: 0x1820EF960
	public void .ctor(double value) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20EFA00 Offset: 0x20EE400 VA: 0x1820EFA00
	public double get_Value() { }

	// RVA: 0x20F0230 Offset: 0x20EEC30 VA: 0x1820F0230
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x20EF6F0 Offset: 0x20EE0F0 VA: 0x1820EF6F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20F0940 Offset: 0x20EF340 VA: 0x1820F0940
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x20EFA60 Offset: 0x20EE460 VA: 0x1820EFA60
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20F07F0 Offset: 0x20EF1F0 VA: 0x1820F07F0
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20F06A0 Offset: 0x20EF0A0 VA: 0x1820F06A0
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20EFBB0 Offset: 0x20EE5B0 VA: 0x1820EFBB0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20F04F0 Offset: 0x20EEEF0 VA: 0x1820F04F0
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x20F0420 Offset: 0x20EEE20 VA: 0x1820F0420
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x20F0250 Offset: 0x20EEC50 VA: 0x1820F0250
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x20EFF30 Offset: 0x20EE930 VA: 0x1820EFF30
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x20F0350 Offset: 0x20EED50 VA: 0x1820F0350
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x20F0160 Offset: 0x20EEB60 VA: 0x1820F0160
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x20F0040 Offset: 0x20EEA40 VA: 0x1820F0040
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x20EFD60 Offset: 0x20EE760 VA: 0x1820EFD60
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20F05D0 Offset: 0x20EEFD0 VA: 0x1820F05D0
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20EFE60 Offset: 0x20EE860 VA: 0x1820EFE60
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20EF1F0 Offset: 0x20EDBF0 VA: 0x1820EF1F0
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20EF0D0 Offset: 0x20EDAD0 VA: 0x1820EF0D0
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x20EF560 Offset: 0x20EDF60 VA: 0x1820EF560
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x20EEA00 Offset: 0x20ED400 VA: 0x1820EEA00 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20EEB30 Offset: 0x20ED530 VA: 0x1820EEB30
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x20EED60 Offset: 0x20ED760 VA: 0x1820EED60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20EEF90 Offset: 0x20ED990 VA: 0x1820EEF90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20EF310 Offset: 0x20EDD10 VA: 0x1820EF310 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20EF430 Offset: 0x20EDE30 VA: 0x1820EF430 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20EF060 Offset: 0x20EDA60 VA: 0x1820EF060
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20EF750 Offset: 0x20EE150 VA: 0x1820EF750
	private static void .cctor() { }
}
