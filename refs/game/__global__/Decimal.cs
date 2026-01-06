public struct Decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 3911
{
	// Fields
	private const int SignMask = -2147483648;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	[DecimalConstant(0, 0, 0, 0, 0)]
	public static readonly Decimal Zero; // 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	public static readonly Decimal One; // 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	public static readonly Decimal MinusOne; // 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MaxValue; // 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MinValue; // 0x40
	private readonly int flags; // 0x0
	private readonly int hi; // 0x4
	private readonly int lo; // 0x8
	private readonly int mid; // 0xC
	private readonly ulong ulomidLE; // 0x8

	// Properties
	internal uint High { get; }
	internal uint Low { get; }
	internal uint Mid { get; }
	internal bool IsNegative { get; }
	internal int Scale { get; }
	private ulong Low64 { get; }

	// Methods

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	internal uint get_High() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	internal uint get_Low() { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	internal uint get_Mid() { }

	// RVA: 0x1CD9900 Offset: 0x1CD8300 VA: 0x181CD9900
	internal bool get_IsNegative() { }

	// RVA: 0x1CDBFD0 Offset: 0x1CDA9D0 VA: 0x181CDBFD0
	internal int get_Scale() { }

	// RVA: 0x1CDBF90 Offset: 0x1CDA990 VA: 0x181CDBF90
	private ulong get_Low64() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	private static ref Decimal.DecCalc AsMutable(ref Decimal d) { }

	// RVA: 0x1CD9B90 Offset: 0x1CD8590 VA: 0x181CD9B90
	internal static uint DecDivMod1E9(ref Decimal value) { }

	// RVA: 0x1CDBCA0 Offset: 0x1CDA6A0 VA: 0x181CDBCA0
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDBC10 Offset: 0x1CDA610 VA: 0x181CDBC10
	public void .ctor(uint value) { }

	// RVA: 0x1CDBD90 Offset: 0x1CDA790 VA: 0x181CDBD90
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDBCD0 Offset: 0x1CDA6D0 VA: 0x181CDBCD0
	public void .ctor(ulong value) { }

	// RVA: 0x1CDBF10 Offset: 0x1CDA910 VA: 0x181CDBF10
	public void .ctor(float value) { }

	// RVA: 0x1CDBC20 Offset: 0x1CDA620 VA: 0x181CDBC20
	public void .ctor(double value) { }

	// RVA: 0x1CDA050 Offset: 0x1CD8A50 VA: 0x181CDA050
	private static bool IsValid(int flags) { }

	// RVA: 0x1CDBDC0 Offset: 0x1CDA7C0 VA: 0x181CDBDC0
	public void .ctor(int[] bits) { }

	// RVA: 0x1CDBCF0 Offset: 0x1CDA6F0 VA: 0x181CDBCF0
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	// RVA: 0x1CDAD20 Offset: 0x1CD9720 VA: 0x181CDAD20 Slot: 25
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1CDBCE0 Offset: 0x1CDA6E0 VA: 0x181CDBCE0
	private void .ctor(in Decimal d, int flags) { }

	// RVA: 0x1CD9910 Offset: 0x1CD8310 VA: 0x181CD9910
	internal static Decimal Abs(ref Decimal d) { }

	// RVA: 0x1CD9930 Offset: 0x1CD8330 VA: 0x181CD9930
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x1CD9B30 Offset: 0x1CD8530 VA: 0x181CD9B30
	public static int Compare(Decimal d1, Decimal d2) { }

	// RVA: 0x1CD99D0 Offset: 0x1CD83D0 VA: 0x181CD99D0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1CD9AD0 Offset: 0x1CD84D0 VA: 0x181CD9AD0 Slot: 23
	public int CompareTo(Decimal value) { }

	// RVA: 0x1CD9C70 Offset: 0x1CD8670 VA: 0x181CD9C70
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x1CD9D70 Offset: 0x1CD8770 VA: 0x181CD9D70 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1CD9D10 Offset: 0x1CD8710 VA: 0x181CD9D10 Slot: 24
	public bool Equals(Decimal value) { }

	// RVA: 0x1CD9EC0 Offset: 0x1CD88C0 VA: 0x181CD9EC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CDB520 Offset: 0x1CD9F20 VA: 0x181CDB520 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CDB380 Offset: 0x1CD9D80 VA: 0x181CDB380 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1CDB430 Offset: 0x1CD9E30 VA: 0x181CDB430 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1CDB960 Offset: 0x1CDA360 VA: 0x181CDB960 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1CDA330 Offset: 0x1CD8D30 VA: 0x181CDA330
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1CDA210 Offset: 0x1CD8C10 VA: 0x181CDA210
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1CDBA30 Offset: 0x1CDA430 VA: 0x181CDBA30
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x1CD9E30 Offset: 0x1CD8830 VA: 0x181CD9E30
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x1CDA070 Offset: 0x1CD8A70 VA: 0x181CDA070
	internal static ref Decimal Max(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x1CDA0E0 Offset: 0x1CD8AE0 VA: 0x181CDA0E0
	internal static ref Decimal Min(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x1CDA150 Offset: 0x1CD8B50 VA: 0x181CDA150
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDA1F0 Offset: 0x1CD8BF0 VA: 0x181CDA1F0
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x1CDA430 Offset: 0x1CD8E30 VA: 0x181CDA430
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x1CDA580 Offset: 0x1CD8F80 VA: 0x181CDA580
	private static Decimal Round(ref Decimal d, int decimals, MidpointRounding mode) { }

	// RVA: 0x1CDADD0 Offset: 0x1CD97D0 VA: 0x181CDADD0
	public static byte ToByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDB1F0 Offset: 0x1CD9BF0 VA: 0x181CDB1F0
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x1CDAF30 Offset: 0x1CD9930 VA: 0x181CDAF30
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1CDAEE0 Offset: 0x1CD98E0 VA: 0x181CDAEE0
	public static double ToDouble(Decimal d) { }

	// RVA: 0x1CDB040 Offset: 0x1CD9A40 VA: 0x181CDB040
	public static int ToInt32(Decimal d) { }

	// RVA: 0x1CDB110 Offset: 0x1CD9B10 VA: 0x181CDB110
	public static long ToInt64(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDB5C0 Offset: 0x1CD9FC0 VA: 0x181CDB5C0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDB6D0 Offset: 0x1CDA0D0 VA: 0x181CDB6D0
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDB790 Offset: 0x1CDA190 VA: 0x181CDB790
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x1CDB300 Offset: 0x1CD9D00 VA: 0x181CDB300
	public static float ToSingle(Decimal d) { }

	// RVA: 0x1CDB900 Offset: 0x1CDA300 VA: 0x181CDB900
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x1CDB870 Offset: 0x1CDA270 VA: 0x181CDB870
	private static void Truncate(ref Decimal d) { }

	// RVA: 0x1CDC870 Offset: 0x1CDB270 VA: 0x181CDC870
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDC7E0 Offset: 0x1CDB1E0 VA: 0x181CDC7E0
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x1CDC840 Offset: 0x1CDB240 VA: 0x181CDC840
	public static Decimal op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDC750 Offset: 0x1CDB150 VA: 0x181CDC750
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x1CDC750 Offset: 0x1CDB150 VA: 0x181CDC750
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x1CDC810 Offset: 0x1CDB210 VA: 0x181CDC810
	public static Decimal op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDC7D0 Offset: 0x1CDB1D0 VA: 0x181CDC7D0
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x1CDC770 Offset: 0x1CDB170 VA: 0x181CDC770
	public static Decimal op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDC7B0 Offset: 0x1CDB1B0 VA: 0x181CDC7B0
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x1CDC310 Offset: 0x1CDAD10 VA: 0x181CDC310
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x1CDC550 Offset: 0x1CDAF50 VA: 0x181CDC550
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x1CDC570 Offset: 0x1CDAF70 VA: 0x181CDC570
	public static int op_Explicit(Decimal value) { }

	// RVA: 0x1CDC180 Offset: 0x1CDAB80 VA: 0x181CDC180
	public static long op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDC330 Offset: 0x1CDAD30 VA: 0x181CDC330
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x1CDC5D0 Offset: 0x1CDAFD0 VA: 0x181CDC5D0
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x1CDC4C0 Offset: 0x1CDAEC0 VA: 0x181CDC4C0
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x1CDA1F0 Offset: 0x1CD8BF0 VA: 0x181CDA1F0
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x1CDC890 Offset: 0x1CDB290 VA: 0x181CDC890
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x1CDBFE0 Offset: 0x1CDA9E0 VA: 0x181CDBFE0
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDCB30 Offset: 0x1CDB530 VA: 0x181CDCB30
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDCA90 Offset: 0x1CDB490 VA: 0x181CDCA90
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC080 Offset: 0x1CDAA80 VA: 0x181CDC080
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC120 Offset: 0x1CDAB20 VA: 0x181CDC120
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC970 Offset: 0x1CDB370 VA: 0x181CDC970
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDCA30 Offset: 0x1CDB430 VA: 0x181CDCA30
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC9D0 Offset: 0x1CDB3D0 VA: 0x181CDC9D0
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC6F0 Offset: 0x1CDB0F0 VA: 0x181CDC6F0
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDC690 Offset: 0x1CDB090 VA: 0x181CDC690
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x1CDA040 Offset: 0x1CD8A40 VA: 0x181CDA040 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1CDA740 Offset: 0x1CD9140 VA: 0x181CDA740 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1CDA800 Offset: 0x1CD9200 VA: 0x181CDA800 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1CDAAA0 Offset: 0x1CD94A0 VA: 0x181CDAAA0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1CDA7A0 Offset: 0x1CD91A0 VA: 0x181CDA7A0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1CDA980 Offset: 0x1CD9380 VA: 0x181CDA980 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1CDAC00 Offset: 0x1CD9600 VA: 0x181CDAC00 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1CDA9E0 Offset: 0x1CD93E0 VA: 0x181CDA9E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1CDAC60 Offset: 0x1CD9660 VA: 0x181CDAC60 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1CDAA40 Offset: 0x1CD9440 VA: 0x181CDAA40 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1CDACC0 Offset: 0x1CD96C0 VA: 0x181CDACC0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1CDAB00 Offset: 0x1CD9500 VA: 0x181CDAB00 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1CDA920 Offset: 0x1CD9320 VA: 0x181CDA920 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1CDA890 Offset: 0x1CD9290 VA: 0x181CDA890 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1CDAB60 Offset: 0x1CD9560 VA: 0x181CDAB60 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1CDBB20 Offset: 0x1CDA520 VA: 0x181CDBB20
	private static void .cctor() { }
}
