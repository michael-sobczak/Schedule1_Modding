internal static class BurstString // TypeDefIndex: 16311
{
	// Fields
	private static readonly char[] SplitByColon; // 0x0
	private static readonly byte[] logTable; // 0x8
	private static readonly uint[] g_PowerOf10_U32; // 0x10
	private static readonly byte[] InfinityString; // 0x18
	private static readonly byte[] NanString; // 0x20
	private const int SinglePrecision = 9;
	private const int DoublePrecision = 17;
	internal const int SingleNumberBufferLength = 10;
	internal const int DoubleNumberBufferLength = 18;
	private const int SinglePrecisionCustomFormat = 7;
	private const int DoublePrecisionCustomFormat = 15;

	// Methods

	[Preserve]
	// RVA: 0x26DCDC0 Offset: 0x26DB7C0 VA: 0x1826DCDC0
	public static void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength) { }

	[Preserve]
	// RVA: 0x26DF2C0 Offset: 0x26DDCC0 VA: 0x1826DF2C0
	public static void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF710 Offset: 0x26DE110 VA: 0x1826DF710
	public static void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF440 Offset: 0x26DDE40 VA: 0x1826DF440
	public static void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF4C0 Offset: 0x26DDEC0 VA: 0x1826DF4C0
	public static void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DED30 Offset: 0x26DD730 VA: 0x1826DED30
	public static void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF790 Offset: 0x26DE190 VA: 0x1826DF790
	public static void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DEF90 Offset: 0x26DD990 VA: 0x1826DEF90
	public static void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF3C0 Offset: 0x26DDDC0 VA: 0x1826DF3C0
	public static void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DEF10 Offset: 0x26DD910 VA: 0x1826DEF10
	public static void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF050 Offset: 0x26DDA50 VA: 0x1826DF050
	public static void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF1F0 Offset: 0x26DDBF0 VA: 0x1826DF1F0
	public static void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF120 Offset: 0x26DDB20 VA: 0x1826DF120
	public static void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[Preserve]
	// RVA: 0x26DF640 Offset: 0x26DE040 VA: 0x1826DF640
	public static void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	// RVA: 0x26DCC10 Offset: 0x26DB610 VA: 0x1826DCC10
	private static void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, BurstString.FormatOptions options) { }

	// RVA: 0x26DF990 Offset: 0x26DE390 VA: 0x1826DF990
	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	// RVA: 0x26DCA50 Offset: 0x26DB450 VA: 0x1826DCA50
	private static void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, BurstString.FormatOptions options) { }

	// RVA: 0x26DE550 Offset: 0x26DCF50 VA: 0x1826DE550
	private static void FormatNumber(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, BurstString.FormatOptions options) { }

	// RVA: 0x26DE120 Offset: 0x26DCB20 VA: 0x1826DE120
	private static void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	// RVA: 0x26E02B0 Offset: 0x26DECB0 VA: 0x1826E02B0
	private static byte ValueToIntegerChar(int value, bool uppercase) { }

	// RVA: 0x26DFB30 Offset: 0x26DE530 VA: 0x1826DFB30
	private static void OptsSplit(string fullFormat, out string padding, out string format) { }

	// RVA: 0x26DFD00 Offset: 0x26DE700 VA: 0x1826DFD00
	public static BurstString.FormatOptions ParseFormatToFormatOptions(string fullFormat) { }

	// RVA: 0x26DB610 Offset: 0x26DA010 VA: 0x1826DB610
	private static bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	// RVA: 0x26DB5D0 Offset: 0x26D9FD0 VA: 0x1826DB5D0
	private static bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length) { }

	// RVA: 0x26DF850 Offset: 0x26DE250 VA: 0x1826DF850
	private static int GetLengthForFormatGeneral(ref BurstString.NumberBuffer number, int nMaxDigits) { }

	// RVA: 0x26DE1D0 Offset: 0x26DCBD0 VA: 0x1826DE1D0
	private static void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref BurstString.NumberBuffer number, int nMaxDigits, byte expChar) { }

	// RVA: 0x26E0160 Offset: 0x26DEB60 VA: 0x1826E0160
	private static void RoundNumber(ref BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	// RVA: 0x26E0280 Offset: 0x26DEC80 VA: 0x1826E0280
	private static bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded) { }

	// RVA: 0x26DF9C0 Offset: 0x26DE3C0 VA: 0x1826DF9C0
	private static uint LogBase2(uint val) { }

	// RVA: 0x26DB810 Offset: 0x26DA210 VA: 0x1826DB810
	private static int BigInt_Compare(in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x26DB780 Offset: 0x26DA180 VA: 0x1826DB780
	private static void BigInt_Add(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x26DB6B0 Offset: 0x26DA0B0 VA: 0x1826DB6B0
	private static void BigInt_Add_internal(out BurstString.tBigInt pResult, in BurstString.tBigInt pLarge, in BurstString.tBigInt pSmall) { }

	// RVA: 0x26DBFF0 Offset: 0x26DA9F0 VA: 0x1826DBFF0
	private static void BigInt_Multiply(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, in BurstString.tBigInt rhs) { }

	// RVA: 0x26DBE70 Offset: 0x26DA870 VA: 0x1826DBE70
	private static void BigInt_Multiply_internal(out BurstString.tBigInt pResult, in BurstString.tBigInt pLarge, in BurstString.tBigInt pSmall) { }

	// RVA: 0x26DBF70 Offset: 0x26DA970 VA: 0x1826DBF70
	private static void BigInt_Multiply(out BurstString.tBigInt pResult, in BurstString.tBigInt lhs, uint rhs) { }

	// RVA: 0x26DBA90 Offset: 0x26DA490 VA: 0x1826DBA90
	private static void BigInt_Multiply2(out BurstString.tBigInt pResult, in BurstString.tBigInt input) { }

	// RVA: 0x26DBB00 Offset: 0x26DA500 VA: 0x1826DBB00
	private static void BigInt_Multiply2(ref BurstString.tBigInt pResult) { }

	// RVA: 0x26DBA50 Offset: 0x26DA450 VA: 0x1826DBA50
	private static void BigInt_Multiply10(ref BurstString.tBigInt pResult) { }

	// RVA: 0x26E0510 Offset: 0x26DEF10 VA: 0x1826E0510
	private static BurstString.tBigInt g_PowerOf10_Big(int i) { }

	// RVA: 0x26DC080 Offset: 0x26DAA80 VA: 0x1826DC080
	private static void BigInt_Pow10(out BurstString.tBigInt pResult, uint exponent) { }

	// RVA: 0x26DBB50 Offset: 0x26DA550 VA: 0x1826DBB50
	private static void BigInt_MultiplyPow10(out BurstString.tBigInt pResult, in BurstString.tBigInt input, uint exponent) { }

	// RVA: 0x26DC2F0 Offset: 0x26DACF0 VA: 0x1826DC2F0
	private static void BigInt_Pow2(out BurstString.tBigInt pResult, uint exponent) { }

	// RVA: 0x26DB870 Offset: 0x26DA270 VA: 0x1826DB870
	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref BurstString.tBigInt pDividend, in BurstString.tBigInt divisor) { }

	// RVA: 0x26DC350 Offset: 0x26DAD50 VA: 0x1826DC350
	private static void BigInt_ShiftLeft(ref BurstString.tBigInt pResult, uint shift) { }

	// RVA: 0x26DCDF0 Offset: 0x26DB7F0 VA: 0x1826DCDF0
	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	// RVA: 0x26DE900 Offset: 0x26DD300 VA: 0x1826DE900
	private static int FormatPositional(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	// RVA: 0x26DEB00 Offset: 0x26DD500 VA: 0x1826DEB00
	private static int FormatScientific(byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	// RVA: 0x26DE360 Offset: 0x26DCD60 VA: 0x1826DE360
	private static void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x26DC7B0 Offset: 0x26DB1B0 VA: 0x1826DC7B0
	private static void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x26DC4F0 Offset: 0x26DAEF0 VA: 0x1826DC4F0
	private static void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, BurstString.FormatOptions formatOptions) { }

	// RVA: 0x26E02E0 Offset: 0x26DECE0 VA: 0x1826E02E0
	private static void .cctor() { }
}
