internal sealed class BitConverterLE // TypeDefIndex: 17479
{
	// Methods

	// RVA: 0x1A56E90 Offset: 0x1A55890 VA: 0x181A56E90
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1A56F10 Offset: 0x1A55910 VA: 0x181A56F10
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1A56E00 Offset: 0x1A55800 VA: 0x181A56E00
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1A56D30 Offset: 0x1A55730 VA: 0x181A56D30
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1A57100 Offset: 0x1A55B00 VA: 0x181A57100
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1A57090 Offset: 0x1A55A90 VA: 0x181A57090
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1A56FD0 Offset: 0x1A559D0 VA: 0x181A56FD0
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x1A57040 Offset: 0x1A55A40 VA: 0x181A57040
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1A56FD0 Offset: 0x1A559D0 VA: 0x181A56FD0
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}
