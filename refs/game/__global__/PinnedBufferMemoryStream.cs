internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 5054
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x1C13C60 Offset: 0x1C12660 VA: 0x181C13C60
	internal void .ctor(byte[] array) { }

	// RVA: 0x1C13C20 Offset: 0x1C12620 VA: 0x181C13C20 Slot: 35
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1C13C40 Offset: 0x1C12640 VA: 0x181C13C40 Slot: 38
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1B20CA0 Offset: 0x1B1F6A0 VA: 0x181B20CA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C13BD0 Offset: 0x1C125D0 VA: 0x181C13BD0 Slot: 21
	protected override void Dispose(bool disposing) { }
}
