internal static class HIDParser // TypeDefIndex: 7566
{
	// Methods

	// RVA: 0x285E190 Offset: 0x285CB90 VA: 0x18285E190
	public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x285E220 Offset: 0x285CC20 VA: 0x18285E220
	public static bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor) { }

	// RVA: 0x285F030 Offset: 0x285DA30 VA: 0x18285F030
	private static int ReadData(int itemSize, byte* currentPtr, byte* endPtr) { }
}
