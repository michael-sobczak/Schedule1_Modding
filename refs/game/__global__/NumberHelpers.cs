internal static class NumberHelpers // TypeDefIndex: 7826
{
	// Methods

	[Extension]
	// RVA: 0x278FAC0 Offset: 0x278E4C0 VA: 0x18278FAC0
	public static int AlignToMultipleOf(int number, int alignment) { }

	[Extension]
	// RVA: 0x278FB00 Offset: 0x278E500 VA: 0x18278FB00
	public static long AlignToMultipleOf(long number, long alignment) { }

	[Extension]
	// RVA: 0x278FAE0 Offset: 0x278E4E0 VA: 0x18278FAE0
	public static uint AlignToMultipleOf(uint number, uint alignment) { }

	// RVA: 0x278FB20 Offset: 0x278E520 VA: 0x18278FB20
	public static bool Approximately(double a, double b) { }

	// RVA: 0x278FBC0 Offset: 0x278E5C0 VA: 0x18278FBC0
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	// RVA: 0x278FC10 Offset: 0x278E610 VA: 0x18278FC10
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	// RVA: 0x278CA30 Offset: 0x278B430 VA: 0x18278CA30
	public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue) { }

	// RVA: 0x278C9C0 Offset: 0x278B3C0 VA: 0x18278C9C0
	public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue) { }

	// RVA: 0x278FC60 Offset: 0x278E660 VA: 0x18278FC60
	public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize) { }
}
