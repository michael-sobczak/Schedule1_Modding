public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 18597
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x219EF30 Offset: 0x219D930 VA: 0x18219EF30
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x219E7A0 Offset: 0x219D1A0 VA: 0x18219E7A0
	public void .ctor(uint value) { }

	// RVA: 0x219E600 Offset: 0x219D000 VA: 0x18219E600
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x219DEF0 Offset: 0x219C8F0 VA: 0x18219DEF0
	public void .ctor(ulong value) { }

	// RVA: 0x219E5A0 Offset: 0x219CFA0 VA: 0x18219E5A0
	public void .ctor(float value) { }

	// RVA: 0x219E010 Offset: 0x219CA10 VA: 0x18219E010
	public void .ctor(double value) { }

	// RVA: 0x219E3B0 Offset: 0x219CDB0 VA: 0x18219E3B0
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x219DE00 Offset: 0x219C800 VA: 0x18219DE00
	public void .ctor(byte[] value) { }

	// RVA: 0x219E860 Offset: 0x219D260 VA: 0x18219E860
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0xD59F60 Offset: 0xD58960 VA: 0x180D59F60
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x219DC20 Offset: 0x219C620 VA: 0x18219DC20
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x219F010 Offset: 0x219DA10 VA: 0x18219F010
	public static BigInteger get_Zero() { }

	// RVA: 0x219EFB0 Offset: 0x219D9B0 VA: 0x18219EFB0
	public static BigInteger get_MinusOne() { }

	// RVA: 0xD92CF0 Offset: 0xD916F0 VA: 0x180D92CF0
	public bool get_IsZero() { }

	// RVA: 0x219CC20 Offset: 0x219B620 VA: 0x18219CC20
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x219CCC0 Offset: 0x219B6C0 VA: 0x18219CCC0
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x219CAF0 Offset: 0x219B4F0 VA: 0x18219CAF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x219C9D0 Offset: 0x219B3D0 VA: 0x18219C9D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x219C940 Offset: 0x219B340 VA: 0x18219C940
	public bool Equals(long other) { }

	// RVA: 0x219C820 Offset: 0x219B220 VA: 0x18219C820 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x219C670 Offset: 0x219B070 VA: 0x18219C670
	public int CompareTo(long other) { }

	// RVA: 0x219C4B0 Offset: 0x219AEB0 VA: 0x18219C4B0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x219C710 Offset: 0x219B110 VA: 0x18219C710 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x219CFF0 Offset: 0x219B9F0 VA: 0x18219CFF0
	public byte[] ToByteArray() { }

	// RVA: 0x219CF40 Offset: 0x219B940 VA: 0x18219CF40
	public byte[] ToByteArray(bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x219D820 Offset: 0x219C220 VA: 0x18219D820
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x219D8E0 Offset: 0x219C2E0 VA: 0x18219D8E0
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x219D2D0 Offset: 0x219BCD0 VA: 0x18219D2D0
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x219D040 Offset: 0x219BA40 VA: 0x18219D040 Slot: 3
	public override string ToString() { }

	// RVA: 0x219D100 Offset: 0x219BB00 VA: 0x18219D100
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x219D1D0 Offset: 0x219BBD0 VA: 0x18219D1D0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x219C2F0 Offset: 0x219ACF0 VA: 0x18219C2F0
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x21A12D0 Offset: 0x219FCD0 VA: 0x1821A12D0
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x219CD20 Offset: 0x219B720 VA: 0x18219CD20
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x21A0110 Offset: 0x219EB10 VA: 0x1821A0110
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x21A0070 Offset: 0x219EA70 VA: 0x1821A0070
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x21A00E0 Offset: 0x219EAE0 VA: 0x1821A00E0
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x21A0160 Offset: 0x219EB60 VA: 0x1821A0160
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x21A0050 Offset: 0x219EA50 VA: 0x1821A0050
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x21A00C0 Offset: 0x219EAC0 VA: 0x1821A00C0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x21A0140 Offset: 0x219EB40 VA: 0x1821A0140
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x21A00A0 Offset: 0x219EAA0 VA: 0x1821A00A0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x219FEA0 Offset: 0x219E8A0 VA: 0x18219FEA0
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x219F9D0 Offset: 0x219E3D0 VA: 0x18219F9D0
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x219F6D0 Offset: 0x219E0D0 VA: 0x18219F6D0
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x219FE20 Offset: 0x219E820 VA: 0x18219FE20
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x219F8A0 Offset: 0x219E2A0 VA: 0x18219F8A0
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x219FB90 Offset: 0x219E590 VA: 0x18219FB90
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x219FF20 Offset: 0x219E920 VA: 0x18219FF20
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x219FD60 Offset: 0x219E760 VA: 0x18219FD60
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x219FA50 Offset: 0x219E450 VA: 0x18219FA50
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x219FC40 Offset: 0x219E640 VA: 0x18219FC40
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x219F750 Offset: 0x219E150 VA: 0x18219F750
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x21A0260 Offset: 0x219EC60 VA: 0x1821A0260
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x21A0DC0 Offset: 0x219F7C0 VA: 0x1821A0DC0
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x21A14E0 Offset: 0x219FEE0 VA: 0x1821A14E0
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x219F070 Offset: 0x219DA70 VA: 0x18219F070
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x21A0AA0 Offset: 0x219F4A0 VA: 0x1821A0AA0
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x219F280 Offset: 0x219DC80 VA: 0x18219F280
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x21A07A0 Offset: 0x219F1A0 VA: 0x1821A07A0
	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x21A05B0 Offset: 0x219EFB0 VA: 0x1821A05B0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x21A01F0 Offset: 0x219EBF0 VA: 0x1821A01F0
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x21A0740 Offset: 0x219F140 VA: 0x1821A0740
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x21A0620 Offset: 0x219F020 VA: 0x1821A0620
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x219F670 Offset: 0x219E070 VA: 0x18219F670
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x21A0190 Offset: 0x219EB90 VA: 0x1821A0190
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x21A06E0 Offset: 0x219F0E0 VA: 0x1821A06E0
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x21A0680 Offset: 0x219F080 VA: 0x1821A0680
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x219CB50 Offset: 0x219B550 VA: 0x18219CB50
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x219CA80 Offset: 0x219B480 VA: 0x18219CA80
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x219D990 Offset: 0x219C390 VA: 0x18219D990
	private static void .cctor() { }
}
