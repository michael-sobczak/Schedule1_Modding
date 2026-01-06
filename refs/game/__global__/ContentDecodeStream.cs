internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 10049
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties
	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x25A8F80 Offset: 0x25A7980 VA: 0x1825A8F80
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x25A8ED0 Offset: 0x25A78D0 VA: 0x1825A8ED0
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x25A9150 Offset: 0x25A7B50 VA: 0x1825A9150 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x25A9060 Offset: 0x25A7A60 VA: 0x1825A9060 Slot: 41
	internal override Task FinishReading(CancellationToken cancellationToken) { }
}
