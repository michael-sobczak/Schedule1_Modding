public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13008
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x20CB750 Offset: 0x20CA150 VA: 0x1820CB750
	private void .ctor(bool fNull) { }

	// RVA: 0x20CB760 Offset: 0x20CA160 VA: 0x1820CB760
	public void .ctor(byte[] value) { }

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20CB7F0 Offset: 0x20CA1F0 VA: 0x1820CB7F0
	public byte[] get_Value() { }

	// RVA: 0x20CBAC0 Offset: 0x20CA4C0 VA: 0x1820CBAC0
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x20CB5F0 Offset: 0x20C9FF0 VA: 0x1820CB5F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20CB240 Offset: 0x20C9C40 VA: 0x1820CB240
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x20CB8C0 Offset: 0x20CA2C0 VA: 0x1820CB8C0
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x20CBB50 Offset: 0x20CA550 VA: 0x1820CBB50
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x20CB9C0 Offset: 0x20CA3C0 VA: 0x1820CB9C0
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x20CAD30 Offset: 0x20C9730 VA: 0x1820CAD30 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20CA9F0 Offset: 0x20C93F0 VA: 0x1820CA9F0
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x20CAE50 Offset: 0x20C9850 VA: 0x1820CAE50 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20CB1E0 Offset: 0x20C9BE0 VA: 0x1820CB1E0
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x20CB080 Offset: 0x20C9A80 VA: 0x1820CB080 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20CB370 Offset: 0x20C9D70 VA: 0x1820CB370 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20CB4D0 Offset: 0x20C9ED0 VA: 0x1820CB4D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20CB170 Offset: 0x20C9B70 VA: 0x1820CB170
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20CB6E0 Offset: 0x20CA0E0 VA: 0x1820CB6E0
	private static void .cctor() { }
}
