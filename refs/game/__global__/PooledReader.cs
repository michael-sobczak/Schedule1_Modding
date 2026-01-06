public sealed class PooledReader : Reader, IDisposable // TypeDefIndex: 12504
{
	// Methods

	// RVA: 0xD166D0 Offset: 0xD150D0 VA: 0x180D166D0
	internal void .ctor(byte[] bytes, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD16730 Offset: 0xD15130 VA: 0x180D16730
	internal void .ctor(ArraySegment<byte> segment, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD16680 Offset: 0xD15080 VA: 0x180D16680
	public void Store() { }

	[Obsolete("Use Store().")]
	// RVA: 0xD16680 Offset: 0xD15080 VA: 0x180D16680 Slot: 4
	public void Dispose() { }
}
