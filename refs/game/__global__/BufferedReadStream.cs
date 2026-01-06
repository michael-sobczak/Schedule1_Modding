internal class BufferedReadStream : WebReadStream // TypeDefIndex: 10047
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x25A8ED0 Offset: 0x25A78D0 VA: 0x1825A8ED0
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(BufferedReadStream.<ProcessReadAsync>d__2))]
	// RVA: 0x25A8CE0 Offset: 0x25A76E0 VA: 0x1825A8CE0 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25A8E30 Offset: 0x25A7830 VA: 0x1825A8E30
	internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) { }
}
