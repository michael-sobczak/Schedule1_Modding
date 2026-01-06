public class StreamContent : HttpContent // TypeDefIndex: 17714
{
	// Fields
	private readonly Stream content; // 0x28
	private readonly int bufferSize; // 0x30
	private readonly CancellationToken cancellationToken; // 0x38
	private readonly long startPosition; // 0x40
	private bool contentCopied; // 0x48

	// Methods

	// RVA: 0x2193B10 Offset: 0x2192510 VA: 0x182193B10
	public void .ctor(Stream content) { }

	// RVA: 0x21939F0 Offset: 0x21923F0 VA: 0x1821939F0
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x2193BD0 Offset: 0x21925D0 VA: 0x182193BD0
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x2193830 Offset: 0x2192230 VA: 0x182193830 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2193880 Offset: 0x2192280 VA: 0x182193880 Slot: 6
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x2193970 Offset: 0x2192370 VA: 0x182193970 Slot: 7
	protected internal override bool TryComputeLength(out long length) { }
}
