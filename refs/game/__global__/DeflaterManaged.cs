internal sealed class DeflaterManaged // TypeDefIndex: 17640
{
	// Fields
	private readonly FastEncoder _deflateEncoder; // 0x10
	private readonly CopyEncoder _copyEncoder; // 0x18
	private readonly DeflateInput _input; // 0x20
	private readonly OutputBuffer _output; // 0x28
	private DeflaterManaged.DeflaterState _processingState; // 0x30
	private DeflateInput _inputFromHistory; // 0x38

	// Methods

	// RVA: 0x216BBD0 Offset: 0x216A5D0 VA: 0x18216BBD0
	internal bool NeedsInput() { }

	// RVA: 0x216BC10 Offset: 0x216A610 VA: 0x18216BC10
	internal void SetInput(byte[] inputBuffer, int startIndex, int count) { }

	// RVA: 0x216B740 Offset: 0x216A140 VA: 0x18216B740
	internal int GetDeflateOutput(byte[] outputBuffer) { }

	// RVA: 0x216B5D0 Offset: 0x2169FD0 VA: 0x18216B5D0
	internal bool Finish(byte[] outputBuffer, out int bytesRead) { }

	// RVA: 0x216BCB0 Offset: 0x216A6B0 VA: 0x18216BCB0
	private bool UseCompressed(double ratio) { }

	// RVA: 0x216B720 Offset: 0x216A120 VA: 0x18216B720
	private void FlushInputWindows() { }

	// RVA: 0x216BCC0 Offset: 0x216A6C0 VA: 0x18216BCC0
	private void WriteFinal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void Dispose() { }
}
