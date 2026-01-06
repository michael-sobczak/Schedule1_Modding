internal static class EncodingTable // TypeDefIndex: 4847
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Dictionary<string, int> hashByName; // 0x18
	private static Dictionary<int, CodePageDataItem> hashByCodePage; // 0x20

	// Methods

	// RVA: 0x1BE02B0 Offset: 0x1BDECB0 VA: 0x181BE02B0
	private static int GetNumEncodingItems() { }

	// RVA: 0x1BDFD70 Offset: 0x1BDE770 VA: 0x181BDFD70
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x1BE0310 Offset: 0x1BDED10 VA: 0x181BE0310
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x1BE0350 Offset: 0x1BDED50 VA: 0x181BE0350
	private static void .cctor() { }

	// RVA: 0x1BEAAC0 Offset: 0x1BE94C0 VA: 0x181BEAAC0
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x1BE0070 Offset: 0x1BDEA70 VA: 0x181BE0070
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x1BDFDB0 Offset: 0x1BDE7B0 VA: 0x181BDFDB0
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}
