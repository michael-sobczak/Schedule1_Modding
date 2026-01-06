public static class BitConverter // TypeDefIndex: 3606
{
	// Fields
	[Intrinsic]
	public static readonly bool IsLittleEndian; // 0x0

	// Methods

	// RVA: 0x1BBC1F0 Offset: 0x1BBABF0 VA: 0x181BBC1F0
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x1BBC010 Offset: 0x1BBAA10 VA: 0x181BBC010
	public static byte[] GetBytes(char value) { }

	// RVA: 0x1BBBFB0 Offset: 0x1BBA9B0 VA: 0x181BBBFB0
	public static byte[] GetBytes(short value) { }

	// RVA: 0x1BBC2B0 Offset: 0x1BBACB0 VA: 0x181BBC2B0
	public static byte[] GetBytes(int value) { }

	// RVA: 0x1BBC190 Offset: 0x1BBAB90 VA: 0x181BBC190
	public static byte[] GetBytes(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC070 Offset: 0x1BBAA70 VA: 0x181BBC070
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC130 Offset: 0x1BBAB30 VA: 0x181BBC130
	public static byte[] GetBytes(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC950 Offset: 0x1BBB350 VA: 0x181BBC950
	public static bool TryWriteBytes(Span<byte> destination, uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC0D0 Offset: 0x1BBAAD0 VA: 0x181BBC0D0
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x1BBC250 Offset: 0x1BBAC50 VA: 0x181BBC250
	public static byte[] GetBytes(float value) { }

	// RVA: 0x1BBC310 Offset: 0x1BBAD10 VA: 0x181BBC310
	public static byte[] GetBytes(double value) { }

	// RVA: 0x1BBC420 Offset: 0x1BBAE20 VA: 0x181BBC420
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x1BBC4A0 Offset: 0x1BBAEA0 VA: 0x181BBC4A0
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x1BBC520 Offset: 0x1BBAF20 VA: 0x181BBC520
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC420 Offset: 0x1BBAE20 VA: 0x181BBC420
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC4A0 Offset: 0x1BBAEA0 VA: 0x181BBC4A0
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1BBC520 Offset: 0x1BBAF20 VA: 0x181BBC520
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x1BBC5A0 Offset: 0x1BBAFA0 VA: 0x181BBC5A0
	public static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x1BBC3A0 Offset: 0x1BBADA0 VA: 0x181BBC3A0
	public static double ToDouble(byte[] value, int startIndex) { }

	// RVA: 0x1BBC650 Offset: 0x1BBB050 VA: 0x181BBC650
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x1BBC620 Offset: 0x1BBB020 VA: 0x181BBC620
	public static string ToString(byte[] value) { }

	// RVA: 0x1BBBFA0 Offset: 0x1BBA9A0 VA: 0x181BBBFA0
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x1BBC380 Offset: 0x1BBAD80 VA: 0x181BBC380
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x1BBC390 Offset: 0x1BBAD90 VA: 0x181BBC390
	public static int SingleToInt32Bits(float value) { }

	// RVA: 0x1BBC370 Offset: 0x1BBAD70 VA: 0x181BBC370
	public static float Int32BitsToSingle(int value) { }

	// RVA: 0x1BBC9D0 Offset: 0x1BBB3D0 VA: 0x181BBC9D0
	private static void .cctor() { }
}
