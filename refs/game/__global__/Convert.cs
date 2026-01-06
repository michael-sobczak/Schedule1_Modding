public static class Convert // TypeDefIndex: 3612
{
	// Fields
	private static readonly sbyte[] s_decodingMap; // 0x0
	internal static readonly Type[] ConvertTypes; // 0x8
	private static readonly Type EnumType; // 0x10
	internal static readonly char[] base64Table; // 0x18
	public static readonly object DBNull; // 0x20

	// Methods

	// RVA: 0x1BC9340 Offset: 0x1BC7D40 VA: 0x181BC9340
	private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written) { }

	// RVA: 0x1BC2760 Offset: 0x1BC1160 VA: 0x181BC2760
	private static int Decode(ref char encodedChars, ref sbyte decodingMap) { }

	// RVA: 0x1BC9D00 Offset: 0x1BC8700 VA: 0x181BC9D00
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

	// RVA: 0x1BC3850 Offset: 0x1BC2250 VA: 0x181BC3850
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x1BC1DA0 Offset: 0x1BC07A0 VA: 0x181BC1DA0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x1BC27C0 Offset: 0x1BC11C0 VA: 0x181BC27C0
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x1BC1390 Offset: 0x1BBFD90 VA: 0x181BC1390
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x1BC1430 Offset: 0x1BBFE30 VA: 0x181BC1430
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1BC3940 Offset: 0x1BC2340 VA: 0x181BC3940
	private static void ThrowCharOverflowException() { }

	// RVA: 0x1BC38F0 Offset: 0x1BC22F0 VA: 0x181BC38F0
	private static void ThrowByteOverflowException() { }

	// RVA: 0x1BC3A80 Offset: 0x1BC2480 VA: 0x181BC3A80
	private static void ThrowSByteOverflowException() { }

	// RVA: 0x1BC3990 Offset: 0x1BC2390 VA: 0x181BC3990
	private static void ThrowInt16OverflowException() { }

	// RVA: 0x1BC3AD0 Offset: 0x1BC24D0 VA: 0x181BC3AD0
	private static void ThrowUInt16OverflowException() { }

	// RVA: 0x1BC39E0 Offset: 0x1BC23E0 VA: 0x181BC39E0
	private static void ThrowInt32OverflowException() { }

	// RVA: 0x1BC3B20 Offset: 0x1BC2520 VA: 0x181BC3B20
	private static void ThrowUInt32OverflowException() { }

	// RVA: 0x1BC3A30 Offset: 0x1BC2430 VA: 0x181BC3A30
	private static void ThrowInt64OverflowException() { }

	// RVA: 0x1BC3B70 Offset: 0x1BC2570 VA: 0x181BC3B70
	private static void ThrowUInt64OverflowException() { }

	// RVA: 0x1BC47A0 Offset: 0x1BC31A0 VA: 0x181BC47A0
	public static bool ToBoolean(object value) { }

	// RVA: 0x1BC46E0 Offset: 0x1BC30E0 VA: 0x181BC46E0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0xD3AC60 Offset: 0xD39660 VA: 0x180D3AC60
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0xD3AC60 Offset: 0xD39660 VA: 0x180D3AC60
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1BC48B0 Offset: 0x1BC32B0 VA: 0x181BC48B0
	public static bool ToBoolean(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC48B0 Offset: 0x1BC32B0 VA: 0x181BC48B0
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x1BC4790 Offset: 0x1BC3190 VA: 0x181BC4790
	public static bool ToBoolean(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC4790 Offset: 0x1BC3190 VA: 0x181BC4790
	public static bool ToBoolean(uint value) { }

	// RVA: 0x4D76B0 Offset: 0x4D60B0 VA: 0x1804D76B0
	public static bool ToBoolean(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x4D76B0 Offset: 0x4D60B0 VA: 0x1804D76B0
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1BC4840 Offset: 0x1BC3240 VA: 0x181BC4840
	public static bool ToBoolean(string value) { }

	// RVA: 0x1BC4960 Offset: 0x1BC3360 VA: 0x181BC4960
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1BC48A0 Offset: 0x1BC32A0 VA: 0x181BC48A0
	public static bool ToBoolean(float value) { }

	// RVA: 0x1BC48C0 Offset: 0x1BC32C0 VA: 0x181BC48C0
	public static bool ToBoolean(double value) { }

	// RVA: 0x1BC48E0 Offset: 0x1BC32E0 VA: 0x181BC48E0
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x1BC5360 Offset: 0x1BC3D60 VA: 0x181BC5360
	public static char ToChar(object value) { }

	// RVA: 0x1BC55E0 Offset: 0x1BC3FE0 VA: 0x181BC55E0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5590 Offset: 0x1BC3F90 VA: 0x181BC5590
	public static char ToChar(sbyte value) { }

	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static char ToChar(byte value) { }

	// RVA: 0x1BC54F0 Offset: 0x1BC3EF0 VA: 0x181BC54F0
	public static char ToChar(short value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static char ToChar(ushort value) { }

	// RVA: 0x1BC5690 Offset: 0x1BC4090 VA: 0x181BC5690
	public static char ToChar(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5540 Offset: 0x1BC3F40 VA: 0x181BC5540
	public static char ToChar(uint value) { }

	// RVA: 0x1BC5310 Offset: 0x1BC3D10 VA: 0x181BC5310
	public static char ToChar(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5200 Offset: 0x1BC3C00 VA: 0x181BC5200
	public static char ToChar(ulong value) { }

	// RVA: 0x1BC5400 Offset: 0x1BC3E00 VA: 0x181BC5400
	public static char ToChar(string value) { }

	// RVA: 0x1BC5250 Offset: 0x1BC3C50 VA: 0x181BC5250
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC73A0 Offset: 0x1BC5DA0 VA: 0x181BC73A0
	public static sbyte ToSByte(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7980 Offset: 0x1BC6380 VA: 0x181BC7980
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0xD3AC60 Offset: 0xD39660 VA: 0x180D3AC60
	public static sbyte ToSByte(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7890 Offset: 0x1BC6290 VA: 0x181BC7890
	public static sbyte ToSByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7930 Offset: 0x1BC6330 VA: 0x181BC7930
	public static sbyte ToSByte(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC77E0 Offset: 0x1BC61E0 VA: 0x181BC77E0
	public static sbyte ToSByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC75D0 Offset: 0x1BC5FD0 VA: 0x181BC75D0
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7840 Offset: 0x1BC6240 VA: 0x181BC7840
	public static sbyte ToSByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7440 Offset: 0x1BC5E40 VA: 0x181BC7440
	public static sbyte ToSByte(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7490 Offset: 0x1BC5E90 VA: 0x181BC7490
	public static sbyte ToSByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC78E0 Offset: 0x1BC62E0 VA: 0x181BC78E0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC74F0 Offset: 0x1BC5EF0 VA: 0x181BC74F0
	public static sbyte ToSByte(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7300 Offset: 0x1BC5D00 VA: 0x181BC7300
	public static sbyte ToSByte(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7620 Offset: 0x1BC6020 VA: 0x181BC7620
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC75C0 Offset: 0x1BC5FC0 VA: 0x181BC75C0
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x1BC5090 Offset: 0x1BC3A90 VA: 0x181BC5090
	public static byte ToByte(object value) { }

	// RVA: 0x1BC4B30 Offset: 0x1BC3530 VA: 0x181BC4B30
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0xD3AC60 Offset: 0xD39660 VA: 0x180D3AC60
	public static byte ToByte(bool value) { }

	// RVA: 0x1BC4D50 Offset: 0x1BC3750 VA: 0x181BC4D50
	public static byte ToByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC4FF0 Offset: 0x1BC39F0 VA: 0x181BC4FF0
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1BC4A10 Offset: 0x1BC3410 VA: 0x181BC4A10
	public static byte ToByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5040 Offset: 0x1BC3A40 VA: 0x181BC5040
	public static byte ToByte(ushort value) { }

	// RVA: 0x1BC4DA0 Offset: 0x1BC37A0 VA: 0x181BC4DA0
	public static byte ToByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC4E90 Offset: 0x1BC3890 VA: 0x181BC4E90
	public static byte ToByte(uint value) { }

	// RVA: 0x1BC4D00 Offset: 0x1BC3700 VA: 0x181BC4D00
	public static byte ToByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC49C0 Offset: 0x1BC33C0 VA: 0x181BC49C0
	public static byte ToByte(ulong value) { }

	// RVA: 0x1BC4A60 Offset: 0x1BC3460 VA: 0x181BC4A60
	public static byte ToByte(float value) { }

	// RVA: 0x1BC4C60 Offset: 0x1BC3660 VA: 0x181BC4C60
	public static byte ToByte(double value) { }

	// RVA: 0x1BC4BE0 Offset: 0x1BC35E0 VA: 0x181BC4BE0
	public static byte ToByte(Decimal value) { }

	// RVA: 0x1BC5130 Offset: 0x1BC3B30 VA: 0x181BC5130
	public static byte ToByte(string value) { }

	// RVA: 0x1BC4DF0 Offset: 0x1BC37F0 VA: 0x181BC4DF0
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x1BC6620 Offset: 0x1BC5020 VA: 0x181BC6620
	public static short ToInt16(object value) { }

	// RVA: 0x1BC61C0 Offset: 0x1BC4BC0 VA: 0x181BC61C0
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	public static short ToInt16(bool value) { }

	// RVA: 0x1BC64D0 Offset: 0x1BC4ED0 VA: 0x181BC64D0
	public static short ToInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6520 Offset: 0x1BC4F20 VA: 0x181BC6520
	public static short ToInt16(sbyte value) { }

	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static short ToInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6170 Offset: 0x1BC4B70 VA: 0x181BC6170
	public static short ToInt16(ushort value) { }

	// RVA: 0x1BC66C0 Offset: 0x1BC50C0 VA: 0x181BC66C0
	public static short ToInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6710 Offset: 0x1BC5110 VA: 0x181BC6710
	public static short ToInt16(uint value) { }

	// RVA: 0x1BC6270 Offset: 0x1BC4C70 VA: 0x181BC6270
	public static short ToInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC62D0 Offset: 0x1BC4CD0 VA: 0x181BC62D0
	public static short ToInt16(ulong value) { }

	// RVA: 0x1BC6550 Offset: 0x1BC4F50 VA: 0x181BC6550
	public static short ToInt16(float value) { }

	// RVA: 0x1BC6760 Offset: 0x1BC5160 VA: 0x181BC6760
	public static short ToInt16(double value) { }

	// RVA: 0x1BC6450 Offset: 0x1BC4E50 VA: 0x181BC6450
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1BC6530 Offset: 0x1BC4F30 VA: 0x181BC6530
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8440 Offset: 0x1BC6E40 VA: 0x181BC8440
	public static ushort ToUInt16(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8390 Offset: 0x1BC6D90 VA: 0x181BC8390
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	public static ushort ToUInt16(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static ushort ToUInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8200 Offset: 0x1BC6C00 VA: 0x181BC8200
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static ushort ToUInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8340 Offset: 0x1BC6D40 VA: 0x181BC8340
	public static ushort ToUInt16(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC84E0 Offset: 0x1BC6EE0 VA: 0x181BC84E0
	public static ushort ToUInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8580 Offset: 0x1BC6F80 VA: 0x181BC8580
	public static ushort ToUInt16(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC82D0 Offset: 0x1BC6CD0 VA: 0x181BC82D0
	public static ushort ToUInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8530 Offset: 0x1BC6F30 VA: 0x181BC8530
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8670 Offset: 0x1BC7070 VA: 0x181BC8670
	public static ushort ToUInt16(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC85D0 Offset: 0x1BC6FD0 VA: 0x181BC85D0
	public static ushort ToUInt16(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8250 Offset: 0x1BC6C50 VA: 0x181BC8250
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8320 Offset: 0x1BC6D20 VA: 0x181BC8320
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x1BC6B50 Offset: 0x1BC5550 VA: 0x181BC6B50
	public static int ToInt32(object value) { }

	// RVA: 0x1BC6990 Offset: 0x1BC5390 VA: 0x181BC6990
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	public static int ToInt32(bool value) { }

	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static int ToInt32(char value) { }

	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static int ToInt32(byte value) { }

	// RVA: 0x1BC6B40 Offset: 0x1BC5540 VA: 0x181BC6B40
	public static int ToInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static int ToInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6940 Offset: 0x1BC5340 VA: 0x181BC6940
	public static int ToInt32(uint value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static int ToInt32(int value) { }

	// RVA: 0x1BC6BF0 Offset: 0x1BC55F0 VA: 0x181BC6BF0
	public static int ToInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6890 Offset: 0x1BC5290 VA: 0x181BC6890
	public static int ToInt32(ulong value) { }

	// RVA: 0x1BC68E0 Offset: 0x1BC52E0 VA: 0x181BC68E0
	public static int ToInt32(float value) { }

	// RVA: 0x1BC6A40 Offset: 0x1BC5440 VA: 0x181BC6A40
	public static int ToInt32(double value) { }

	// RVA: 0x1BC6C50 Offset: 0x1BC5650 VA: 0x181BC6C50
	public static int ToInt32(Decimal value) { }

	// RVA: 0x1BC6800 Offset: 0x1BC5200 VA: 0x181BC6800
	public static int ToInt32(string value) { }

	// RVA: 0x1BC6870 Offset: 0x1BC5270 VA: 0x181BC6870
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8930 Offset: 0x1BC7330 VA: 0x181BC8930
	public static uint ToUInt32(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8C40 Offset: 0x1BC7640 VA: 0x181BC8C40
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	public static uint ToUInt32(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static uint ToUInt32(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8BD0 Offset: 0x1BC75D0 VA: 0x181BC8BD0
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static uint ToUInt32(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8740 Offset: 0x1BC7140 VA: 0x181BC8740
	public static uint ToUInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static uint ToUInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC88E0 Offset: 0x1BC72E0 VA: 0x181BC88E0
	public static uint ToUInt32(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8AC0 Offset: 0x1BC74C0 VA: 0x181BC8AC0
	public static uint ToUInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8890 Offset: 0x1BC7290 VA: 0x181BC8890
	public static uint ToUInt32(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8790 Offset: 0x1BC7190 VA: 0x181BC8790
	public static uint ToUInt32(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8B10 Offset: 0x1BC7510 VA: 0x181BC8B10
	public static uint ToUInt32(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8CF0 Offset: 0x1BC76F0 VA: 0x181BC8CF0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8C20 Offset: 0x1BC7620 VA: 0x181BC8C20
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x1BC71E0 Offset: 0x1BC5BE0 VA: 0x181BC71E0
	public static long ToInt64(object value) { }

	// RVA: 0x1BC7000 Offset: 0x1BC5A00 VA: 0x181BC7000
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x1BC72F0 Offset: 0x1BC5CF0 VA: 0x181BC72F0
	public static long ToInt64(bool value) { }

	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static long ToInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC70E0 Offset: 0x1BC5AE0 VA: 0x181BC70E0
	public static long ToInt64(sbyte value) { }

	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static long ToInt64(byte value) { }

	// RVA: 0x1BC6FF0 Offset: 0x1BC59F0 VA: 0x181BC6FF0
	public static long ToInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static long ToInt64(ushort value) { }

	// RVA: 0x1BC70D0 Offset: 0x1BC5AD0 VA: 0x181BC70D0
	public static long ToInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static long ToInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC70F0 Offset: 0x1BC5AF0 VA: 0x181BC70F0
	public static long ToInt64(ulong value) { }

	// RVA: 0x1BC6EB0 Offset: 0x1BC58B0 VA: 0x181BC6EB0
	public static long ToInt64(float value) { }

	// RVA: 0x1BC7150 Offset: 0x1BC5B50 VA: 0x181BC7150
	public static long ToInt64(double value) { }

	// RVA: 0x1BC6F70 Offset: 0x1BC5970 VA: 0x181BC6F70
	public static long ToInt64(Decimal value) { }

	// RVA: 0x1BC7280 Offset: 0x1BC5C80 VA: 0x181BC7280
	public static long ToInt64(string value) { }

	// RVA: 0x1BC70B0 Offset: 0x1BC5AB0 VA: 0x181BC70B0
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8FA0 Offset: 0x1BC79A0 VA: 0x181BC8FA0
	public static ulong ToUInt64(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8EF0 Offset: 0x1BC78F0 VA: 0x181BC8EF0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static ulong ToUInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8D70 Offset: 0x1BC7770 VA: 0x181BC8D70
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	public static ulong ToUInt64(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC91B0 Offset: 0x1BC7BB0 VA: 0x181BC91B0
	public static ulong ToUInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8DE0 Offset: 0x1BC77E0 VA: 0x181BC8DE0
	public static ulong ToUInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC9200 Offset: 0x1BC7C00 VA: 0x181BC9200
	public static ulong ToUInt64(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC9040 Offset: 0x1BC7A40 VA: 0x181BC9040
	public static ulong ToUInt64(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8E30 Offset: 0x1BC7830 VA: 0x181BC8E30
	public static ulong ToUInt64(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC9130 Offset: 0x1BC7B30 VA: 0x181BC9130
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC8DC0 Offset: 0x1BC77C0 VA: 0x181BC8DC0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x1BC7AF0 Offset: 0x1BC64F0 VA: 0x181BC7AF0
	public static float ToSingle(object value) { }

	// RVA: 0x1BC7C70 Offset: 0x1BC6670 VA: 0x181BC7C70
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7B90 Offset: 0x1BC6590 VA: 0x181BC7B90
	public static float ToSingle(sbyte value) { }

	// RVA: 0x1BC7A40 Offset: 0x1BC6440 VA: 0x181BC7A40
	public static float ToSingle(byte value) { }

	// RVA: 0x1BC7A50 Offset: 0x1BC6450 VA: 0x181BC7A50
	public static float ToSingle(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7A30 Offset: 0x1BC6430 VA: 0x181BC7A30
	public static float ToSingle(ushort value) { }

	// RVA: 0x1BC7C60 Offset: 0x1BC6660 VA: 0x181BC7C60
	public static float ToSingle(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7AD0 Offset: 0x1BC64D0 VA: 0x181BC7AD0
	public static float ToSingle(uint value) { }

	// RVA: 0x1BC7AE0 Offset: 0x1BC64E0 VA: 0x181BC7AE0
	public static float ToSingle(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC7BC0 Offset: 0x1BC65C0 VA: 0x181BC7BC0
	public static float ToSingle(ulong value) { }

	// RVA: 0x96B2A0 Offset: 0x969CA0 VA: 0x18096B2A0
	public static float ToSingle(double value) { }

	// RVA: 0x1BC7BF0 Offset: 0x1BC65F0 VA: 0x181BC7BF0
	public static float ToSingle(Decimal value) { }

	// RVA: 0x1BC7A60 Offset: 0x1BC6460 VA: 0x181BC7A60
	public static float ToSingle(string value) { }

	// RVA: 0x1BC7BA0 Offset: 0x1BC65A0 VA: 0x181BC7BA0
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x1BC7C50 Offset: 0x1BC6650 VA: 0x181BC7C50
	public static float ToSingle(bool value) { }

	// RVA: 0x1BC5FD0 Offset: 0x1BC49D0 VA: 0x181BC5FD0
	public static double ToDouble(object value) { }

	// RVA: 0x1BC6070 Offset: 0x1BC4A70 VA: 0x181BC6070
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5EE0 Offset: 0x1BC48E0 VA: 0x181BC5EE0
	public static double ToDouble(sbyte value) { }

	// RVA: 0x1BC5FC0 Offset: 0x1BC49C0 VA: 0x181BC5FC0
	public static double ToDouble(byte value) { }

	// RVA: 0x1BC6160 Offset: 0x1BC4B60 VA: 0x181BC6160
	public static double ToDouble(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5F50 Offset: 0x1BC4950 VA: 0x181BC5F50
	public static double ToDouble(ushort value) { }

	// RVA: 0x1BC5EF0 Offset: 0x1BC48F0 VA: 0x181BC5EF0
	public static double ToDouble(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC6120 Offset: 0x1BC4B20 VA: 0x181BC6120
	public static double ToDouble(uint value) { }

	// RVA: 0x1BC5F00 Offset: 0x1BC4900 VA: 0x181BC5F00
	public static double ToDouble(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5F20 Offset: 0x1BC4920 VA: 0x181BC5F20
	public static double ToDouble(ulong value) { }

	// RVA: 0x1BC6130 Offset: 0x1BC4B30 VA: 0x181BC6130
	public static double ToDouble(float value) { }

	// RVA: 0x1BC5F60 Offset: 0x1BC4960 VA: 0x181BC5F60
	public static double ToDouble(Decimal value) { }

	// RVA: 0x1BC6140 Offset: 0x1BC4B40 VA: 0x181BC6140
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x1BC5F10 Offset: 0x1BC4910 VA: 0x181BC5F10
	public static double ToDouble(bool value) { }

	// RVA: 0x1BC59A0 Offset: 0x1BC43A0 VA: 0x181BC59A0
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5C00 Offset: 0x1BC4600 VA: 0x181BC5C00
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1BC58C0 Offset: 0x1BC42C0 VA: 0x181BC58C0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x1BC5B90 Offset: 0x1BC4590 VA: 0x181BC5B90
	public static Decimal ToDecimal(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5C70 Offset: 0x1BC4670 VA: 0x181BC5C70
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x1BC5AB0 Offset: 0x1BC44B0 VA: 0x181BC5AB0
	public static Decimal ToDecimal(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5DC0 Offset: 0x1BC47C0 VA: 0x181BC5DC0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x1BC5930 Offset: 0x1BC4330 VA: 0x181BC5930
	public static Decimal ToDecimal(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC5CE0 Offset: 0x1BC46E0 VA: 0x181BC5CE0
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x1BC5850 Offset: 0x1BC4250 VA: 0x181BC5850
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x1BC5D50 Offset: 0x1BC4750 VA: 0x181BC5D50
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x1BC5E30 Offset: 0x1BC4830 VA: 0x181BC5E30
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x1BC5B20 Offset: 0x1BC4520 VA: 0x181BC5B20
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x1BC56E0 Offset: 0x1BC40E0 VA: 0x181BC56E0
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x1BC57C0 Offset: 0x1BC41C0 VA: 0x181BC57C0
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x1BC7DB0 Offset: 0x1BC67B0 VA: 0x181BC7DB0
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x1BC8060 Offset: 0x1BC6A60 VA: 0x181BC8060
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x1BC7FB0 Offset: 0x1BC69B0 VA: 0x181BC7FB0
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x1BC4EE0 Offset: 0x1BC38E0 VA: 0x181BC4EE0
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC76A0 Offset: 0x1BC60A0 VA: 0x181BC76A0
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x1BC6320 Offset: 0x1BC4D20 VA: 0x181BC6320
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC80E0 Offset: 0x1BC6AE0 VA: 0x181BC80E0
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x1BC6CD0 Offset: 0x1BC56D0 VA: 0x181BC6CD0
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC89D0 Offset: 0x1BC73D0 VA: 0x181BC89D0
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x1BC6DC0 Offset: 0x1BC57C0 VA: 0x181BC6DC0
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x1BC9250 Offset: 0x1BC7C50 VA: 0x181BC9250
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x1BC7D20 Offset: 0x1BC6720 VA: 0x181BC7D20
	public static string ToString(byte value, int toBase) { }

	// RVA: 0x1BC7F20 Offset: 0x1BC6920 VA: 0x181BC7F20
	public static string ToString(int value, int toBase) { }

	// RVA: 0x1BC7FD0 Offset: 0x1BC69D0 VA: 0x181BC7FD0
	public static string ToString(long value, int toBase) { }

	// RVA: 0x1BC44A0 Offset: 0x1BC2EA0 VA: 0x181BC44A0
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x1BC4570 Offset: 0x1BC2F70 VA: 0x181BC4570
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	// RVA: 0x1BC4090 Offset: 0x1BC2A90 VA: 0x181BC4090
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x1BC42D0 Offset: 0x1BC2CD0 VA: 0x181BC42D0
	public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = 0) { }

	// RVA: 0x1BC3BC0 Offset: 0x1BC25C0 VA: 0x181BC3BC0
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	// RVA: 0x1BC3C50 Offset: 0x1BC2650 VA: 0x181BC3C50
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1BC22E0 Offset: 0x1BC0CE0 VA: 0x181BC22E0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x1BC45F0 Offset: 0x1BC2FF0 VA: 0x181BC45F0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x1BC36D0 Offset: 0x1BC20D0 VA: 0x181BC36D0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x1BC96F0 Offset: 0x1BC80F0 VA: 0x181BC96F0
	public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten) { }

	// RVA: 0x1BC2640 Offset: 0x1BC1040 VA: 0x181BC2640
	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten) { }

	[Extension]
	// RVA: 0x1BC38C0 Offset: 0x1BC22C0 VA: 0x181BC38C0
	private static bool IsSpace(char c) { }

	// RVA: 0x1BC3230 Offset: 0x1BC1C30 VA: 0x181BC3230
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x1BC34B0 Offset: 0x1BC1EB0 VA: 0x181BC34B0
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1BC3790 Offset: 0x1BC2190 VA: 0x181BC3790
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x1BC9D20 Offset: 0x1BC8720 VA: 0x181BC9D20
	private static void .cctor() { }
}
