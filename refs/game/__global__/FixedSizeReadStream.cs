internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 10058
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties
	public long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_ContentLength() { }

	// RVA: 0x25B3420 Offset: 0x25B1E20 VA: 0x1825B3420
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	[AsyncStateMachine(typeof(FixedSizeReadStream.<ProcessReadAsync>d__5))]
	// RVA: 0x25B32D0 Offset: 0x25B1CD0 VA: 0x1825B32D0 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }
}
