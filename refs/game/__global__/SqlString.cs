public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13024
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x20FD3F0 Offset: 0x20FBDF0 VA: 0x1820FD3F0
	private void .ctor(bool fNull) { }

	// RVA: 0x20FD150 Offset: 0x20FBB50 VA: 0x1820FD150
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x20FD1F0 Offset: 0x20FBBF0 VA: 0x1820FD1F0
	public void .ctor(string data) { }

	// RVA: 0x20FD330 Offset: 0x20FBD30 VA: 0x1820FD330
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x20FD430 Offset: 0x20FBE30 VA: 0x1820FD430 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20FD440 Offset: 0x20FBE40 VA: 0x1820FD440
	public string get_Value() { }

	// RVA: 0x20FC770 Offset: 0x20FB170 VA: 0x1820FC770
	private void SetCompareInfo() { }

	// RVA: 0x20FD7D0 Offset: 0x20FC1D0 VA: 0x1820FD7D0
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x20FCE70 Offset: 0x20FB870 VA: 0x1820FCE70 Slot: 3
	public override string ToString() { }

	// RVA: 0x20FD4D0 Offset: 0x20FBED0 VA: 0x1820FD4D0
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x20FC810 Offset: 0x20FB210 VA: 0x1820FC810
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x20FBFE0 Offset: 0x20FA9E0 VA: 0x1820FBFE0
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x20FD670 Offset: 0x20FC070 VA: 0x1820FD670
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x20FCED0 Offset: 0x20FB8D0 VA: 0x1820FCED0
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x20FBCA0 Offset: 0x20FA6A0 VA: 0x1820FBCA0
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x20FC460 Offset: 0x20FAE60 VA: 0x1820FC460
	private bool FBinarySort() { }

	// RVA: 0x20FBA70 Offset: 0x20FA470 VA: 0x1820FBA70
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x20FB910 Offset: 0x20FA310 VA: 0x1820FB910
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x20FBD60 Offset: 0x20FA760 VA: 0x1820FBD60 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20FBEA0 Offset: 0x20FA8A0 VA: 0x1820FBEA0
	public int CompareTo(SqlString value) { }

	// RVA: 0x20FC150 Offset: 0x20FAB50 VA: 0x1820FC150 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20FC4C0 Offset: 0x20FAEC0 VA: 0x1820FC4C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20FCC80 Offset: 0x20FB680 VA: 0x1820FCC80 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20FCD90 Offset: 0x20FB790 VA: 0x1820FCD90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20FC700 Offset: 0x20FB100 VA: 0x1820FC700
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20FCF80 Offset: 0x20FB980 VA: 0x1820FCF80
	private static void .cctor() { }
}
