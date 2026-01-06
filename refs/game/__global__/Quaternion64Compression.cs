public static class Quaternion64Compression // TypeDefIndex: 12524
{
	// Fields
	private const float Maximum = 0.70710653;
	private const int BitsPerAxis_H = 21;
	private const int BitsPerAxis_L = 20;
	private const int LargestComponentShift = 62;
	private const int AShift = 41;
	private const int BShift = 20;
	private const int IntScale_H = 1048575;
	private const int IntMask_H = 2097151;
	private const int IntScale_L = 524287;
	private const int IntMask_L = 1048575;

	// Methods

	// RVA: 0xD16D70 Offset: 0xD15770 VA: 0x180D16D70
	public static ulong Compress(Quaternion quaternion) { }

	// RVA: 0xD172E0 Offset: 0xD15CE0 VA: 0x180D172E0
	private static ulong ScaleToUint_H(float v) { }

	// RVA: 0xD17310 Offset: 0xD15D10 VA: 0x180D17310
	private static ulong ScaleToUint_L(float v) { }

	// RVA: 0xD17240 Offset: 0xD15C40 VA: 0x180D17240
	private static float ScaleToFloat_H(ulong v) { }

	// RVA: 0xD17290 Offset: 0xD15C90 VA: 0x180D17290
	private static float ScaleToFloat_L(ulong v) { }

	// RVA: 0xD16F00 Offset: 0xD15900 VA: 0x180D16F00
	public static Quaternion Decompress(ulong compressed) { }
}
