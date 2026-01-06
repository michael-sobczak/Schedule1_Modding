internal sealed class FastEncoder // TypeDefIndex: 17641
{
	// Fields
	private readonly FastEncoderWindow _inputWindow; // 0x10
	private readonly Match _currentMatch; // 0x18
	private double _lastCompressionRatio; // 0x20

	// Properties
	internal int BytesInHistory { get; }
	internal DeflateInput UnprocessedInput { get; }
	internal double LastCompressionRatio { get; }

	// Methods

	// RVA: 0x216E110 Offset: 0x216CB10 VA: 0x18216E110
	internal int get_BytesInHistory() { }

	// RVA: 0x216E130 Offset: 0x216CB30 VA: 0x18216E130
	internal DeflateInput get_UnprocessedInput() { }

	// RVA: 0x216D650 Offset: 0x216C050 VA: 0x18216D650
	internal void FlushInput() { }

	// RVA: 0xD056C0 Offset: 0xD040C0 VA: 0x180D056C0
	internal double get_LastCompressionRatio() { }

	// RVA: 0x216D7B0 Offset: 0x216C1B0 VA: 0x18216D7B0
	internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	// RVA: 0x216D890 Offset: 0x216C290 VA: 0x18216D890
	internal void GetCompressedData(DeflateInput input, OutputBuffer output) { }

	// RVA: 0x216D7A0 Offset: 0x216C1A0 VA: 0x18216D7A0
	internal void GetBlockHeader(OutputBuffer output) { }

	// RVA: 0x216D710 Offset: 0x216C110 VA: 0x18216D710
	internal void GetBlockFooter(OutputBuffer output) { }

	// RVA: 0x216D9B0 Offset: 0x216C3B0 VA: 0x18216D9B0
	private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	// RVA: 0x216D8B0 Offset: 0x216C2B0 VA: 0x18216D8B0
	private void GetCompressedOutput(OutputBuffer output) { }

	// RVA: 0x216DC30 Offset: 0x216C630 VA: 0x18216DC30
	private bool InputAvailable(DeflateInput input) { }

	// RVA: 0x216DC70 Offset: 0x216C670 VA: 0x18216DC70
	private bool SafeToWriteTo(OutputBuffer output) { }

	// RVA: 0x216D710 Offset: 0x216C110 VA: 0x18216D710
	private void WriteEndOfBlock(OutputBuffer output) { }

	// RVA: 0x216DEA0 Offset: 0x216C8A0 VA: 0x18216DEA0
	internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output) { }

	// RVA: 0x216DCA0 Offset: 0x216C6A0 VA: 0x18216DCA0
	internal static void WriteChar(byte b, OutputBuffer output) { }

	// RVA: 0x216DD40 Offset: 0x216C740 VA: 0x18216DD40
	internal static void WriteDeflatePreamble(OutputBuffer output) { }
}
