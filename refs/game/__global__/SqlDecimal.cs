public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13015
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x20E6A60 Offset: 0x20E5460 VA: 0x1820E6A60
	private byte CalculatePrecision() { }

	// RVA: 0x20EA8F0 Offset: 0x20E92F0 VA: 0x1820EA8F0
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x20EB5C0 Offset: 0x20E9FC0 VA: 0x1820EB5C0
	private void .ctor(bool fNull) { }

	// RVA: 0x20EB9A0 Offset: 0x20EA3A0 VA: 0x1820EB9A0
	public void .ctor(Decimal value) { }

	// RVA: 0x20EB340 Offset: 0x20E9D40 VA: 0x1820EB340
	public void .ctor(int value) { }

	// RVA: 0x20EB630 Offset: 0x20EA030 VA: 0x1820EB630
	public void .ctor(long value) { }

	// RVA: 0x20EB730 Offset: 0x20EA130 VA: 0x1820EB730
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x20EBC60 Offset: 0x20EA660 VA: 0x1820EBC60 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20EBEC0 Offset: 0x20EA8C0 VA: 0x1820EBEC0
	public Decimal get_Value() { }

	// RVA: 0x20EBCC0 Offset: 0x20EA6C0 VA: 0x1820EBCC0
	public bool get_IsPositive() { }

	// RVA: 0x20E9810 Offset: 0x20E8210 VA: 0x1820E9810
	private void SetPositive() { }

	// RVA: 0x20E9880 Offset: 0x20E8280 VA: 0x1820E9880
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x20EBDD0 Offset: 0x20EA7D0 VA: 0x1820EBDD0
	public byte get_Scale() { }

	// RVA: 0x20EBB20 Offset: 0x20EA520 VA: 0x1820EBB20
	public int[] get_Data() { }

	// RVA: 0x20EA4C0 Offset: 0x20E8EC0 VA: 0x1820EA4C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x20E90B0 Offset: 0x20E7AB0 VA: 0x1820E90B0
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x20E9EC0 Offset: 0x20E88C0 VA: 0x1820E9EC0
	public double ToDouble() { }

	// RVA: 0x20E9D00 Offset: 0x20E8700 VA: 0x1820E9D00
	private Decimal ToDecimal() { }

	// RVA: 0x20ED120 Offset: 0x20EBB20 VA: 0x1820ED120
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x20ED160 Offset: 0x20EBB60 VA: 0x1820ED160
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x20EE800 Offset: 0x20ED200 VA: 0x1820EE800
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x20EBF30 Offset: 0x20EA930 VA: 0x1820EBF30
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20EE590 Offset: 0x20ECF90 VA: 0x1820EE590
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20ED830 Offset: 0x20EC230 VA: 0x1820ED830
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20EC760 Offset: 0x20EB160 VA: 0x1820EC760
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20ED3B0 Offset: 0x20EBDB0 VA: 0x1820ED3B0
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x20ED1B0 Offset: 0x20EBBB0 VA: 0x1820ED1B0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x20ED580 Offset: 0x20EBF80 VA: 0x1820ED580
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x20ED290 Offset: 0x20EBC90 VA: 0x1820ED290
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x20ED490 Offset: 0x20EBE90 VA: 0x1820ED490
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x20EAB30 Offset: 0x20E9530 VA: 0x1820EAB30
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x20E7A10 Offset: 0x20E6410 VA: 0x1820E7A10
	private bool FZero() { }

	// RVA: 0x20E7980 Offset: 0x20E6380 VA: 0x1820E7980
	private bool FGt10_38() { }

	// RVA: 0x20E79C0 Offset: 0x20E63C0 VA: 0x1820E79C0
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x20E6530 Offset: 0x20E4F30 VA: 0x1820E6530
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x20E66D0 Offset: 0x20E50D0 VA: 0x1820E66D0
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x20E5EE0 Offset: 0x20E48E0 VA: 0x1820E5EE0
	private void AddULong(uint ulAdd) { }

	// RVA: 0x20E8DE0 Offset: 0x20E77E0 VA: 0x1820E8DE0
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x20E73A0 Offset: 0x20E5DA0 VA: 0x1820E73A0
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x20E6160 Offset: 0x20E4B60 VA: 0x1820E6160
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x20E7C90 Offset: 0x20E6690 VA: 0x1820E7C90
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x20E8C30 Offset: 0x20E7630 VA: 0x1820E8C30
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x20E8DB0 Offset: 0x20E77B0 VA: 0x1820E8DB0
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x20E8D70 Offset: 0x20E7770 VA: 0x1820E8D70
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x20E8CA0 Offset: 0x20E76A0 VA: 0x1820E8CA0
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x20E7ED0 Offset: 0x20E68D0 VA: 0x1820E7ED0
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x20E7390 Offset: 0x20E5D90 VA: 0x1820E7390
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x1C6D210 Offset: 0x1C6BC10 VA: 0x181C6D210
	private static uint HI(ulong x) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	private static uint LO(ulong x) { }

	// RVA: 0x20E7FD0 Offset: 0x20E69D0 VA: 0x1820E7FD0
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x20E6DC0 Offset: 0x20E57C0 VA: 0x1820E6DC0
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x20E6CE0 Offset: 0x20E56E0 VA: 0x1820E6CE0
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x20ECDE0 Offset: 0x20EB7E0 VA: 0x1820ECDE0
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20ED690 Offset: 0x20EC090 VA: 0x1820ED690
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20ECF80 Offset: 0x20EB980 VA: 0x1820ECF80
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20E7E50 Offset: 0x20E6850 VA: 0x1820E7E50
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20E7C10 Offset: 0x20E6610 VA: 0x1820E7C10
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x20EA0A0 Offset: 0x20E8AA0 VA: 0x1820EA0A0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x20EA270 Offset: 0x20E8C70 VA: 0x1820EA270
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x20EA2F0 Offset: 0x20E8CF0 VA: 0x1820EA2F0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x20E6CD0 Offset: 0x20E56D0 VA: 0x1820E6CD0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x20E99A0 Offset: 0x20E83A0 VA: 0x1820E99A0
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x20E9930 Offset: 0x20E8330 VA: 0x1820E9930
	private void SetToZero() { }

	// RVA: 0x20E7260 Offset: 0x20E5C60 VA: 0x1820E7260 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20E6FA0 Offset: 0x20E59A0 VA: 0x1820E6FA0
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x20E7590 Offset: 0x20E5F90 VA: 0x1820E7590 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20E7A30 Offset: 0x20E6430 VA: 0x1820E7A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20E99F0 Offset: 0x20E83F0 VA: 0x1820E99F0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20E9BA0 Offset: 0x20E85A0 VA: 0x1820E9BA0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20E7BA0 Offset: 0x20E65A0 VA: 0x1820E7BA0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20EABB0 Offset: 0x20E95B0 VA: 0x1820EABB0
	private static void .cctor() { }
}
