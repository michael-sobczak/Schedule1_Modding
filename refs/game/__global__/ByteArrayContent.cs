public class ByteArrayContent : HttpContent // TypeDefIndex: 17699
{
	// Fields
	private readonly byte[] content; // 0x28
	private readonly int offset; // 0x30
	private readonly int count; // 0x34

	// Methods

	// RVA: 0x217E9C0 Offset: 0x217D3C0 VA: 0x18217E9C0
	public void .ctor(byte[] content) { }

	// RVA: 0x217E970 Offset: 0x217D370 VA: 0x18217E970 Slot: 6
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x217E9B0 Offset: 0x217D3B0 VA: 0x18217E9B0 Slot: 7
	protected internal override bool TryComputeLength(out long length) { }
}
