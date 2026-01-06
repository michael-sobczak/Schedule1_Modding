internal static class FastEncoderStatics // TypeDefIndex: 17642
{
	// Fields
	internal static readonly byte[] FastEncoderTreeStructureData; // 0x0
	internal static readonly byte[] BFinalFastEncoderTreeStructureData; // 0x8
	internal static readonly uint[] FastEncoderLiteralCodeInfo; // 0x10
	internal static readonly uint[] FastEncoderDistanceCodeInfo; // 0x18
	internal static readonly uint[] BitMask; // 0x20
	internal static readonly byte[] ExtraLengthBits; // 0x28
	internal static readonly byte[] ExtraDistanceBits; // 0x30
	private static readonly byte[] s_distLookup; // 0x38

	// Methods

	// RVA: 0x216C490 Offset: 0x216AE90 VA: 0x18216C490
	private static byte[] CreateDistanceLookup() { }

	// RVA: 0x216C630 Offset: 0x216B030 VA: 0x18216C630
	internal static int GetSlot(int pos) { }

	// RVA: 0x216C470 Offset: 0x216AE70 VA: 0x18216C470
	public static uint BitReverse(uint code, int length) { }

	// RVA: 0x216C6C0 Offset: 0x216B0C0 VA: 0x18216C6C0
	private static void .cctor() { }
}
