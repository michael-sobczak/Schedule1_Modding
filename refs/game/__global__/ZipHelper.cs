internal static class ZipHelper // TypeDefIndex: 17673
{
	// Fields
	private static readonly DateTime s_invalidDateIndicator; // 0x0

	// Methods

	// RVA: 0x217BC80 Offset: 0x217A680 VA: 0x18217BC80
	internal static bool RequiresUnicode(string test) { }

	// RVA: 0x217BBB0 Offset: 0x217A5B0 VA: 0x18217BBB0
	internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead) { }

	// RVA: 0x217BB00 Offset: 0x217A500 VA: 0x18217BB00
	internal static DateTime DosTimeToDateTime(uint dateTime) { }

	// RVA: 0x217BA20 Offset: 0x217A420 VA: 0x18217BA20
	internal static uint DateTimeToDosTime(DateTime dateTime) { }

	// RVA: 0x217BE70 Offset: 0x217A870 VA: 0x18217BE70
	internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind) { }

	[Extension]
	// RVA: 0x217B920 Offset: 0x217A320 VA: 0x18217B920
	internal static void AdvanceToPosition(Stream stream, long position) { }

	// RVA: 0x217BCE0 Offset: 0x217A6E0 VA: 0x18217BCE0
	private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer) { }

	// RVA: 0x217C0D0 Offset: 0x217AAD0 VA: 0x18217C0D0
	private static void .cctor() { }
}
