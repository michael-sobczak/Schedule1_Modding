public static class ReaderPool // TypeDefIndex: 12505
{
	// Fields
	private static readonly Stack<PooledReader> _pool; // 0x0

	// Methods

	[Obsolete("Use Retrieve(byte[], NetworkManager, DataSource)")]
	// RVA: 0xD173C0 Offset: 0xD15DC0 VA: 0x180D173C0
	public static PooledReader GetReader(byte[] bytes, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD17610 Offset: 0xD16010 VA: 0x180D17610
	public static PooledReader Retrieve(byte[] bytes, NetworkManager networkManager, Reader.DataSource source = 0) { }

	[Obsolete("Use Retrieve(ArraySegment, NetworkManager, DataSource)")]
	// RVA: 0xD17340 Offset: 0xD15D40 VA: 0x180D17340
	public static PooledReader GetReader(ArraySegment<byte> segment, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD174E0 Offset: 0xD15EE0 VA: 0x180D174E0
	public static PooledReader Retrieve(ArraySegment<byte> segment, NetworkManager networkManager, Reader.DataSource source = 0) { }

	[Obsolete("Use Store(PooledReader)")]
	// RVA: 0xD17490 Offset: 0xD15E90 VA: 0x180D17490
	public static void Recycle(PooledReader reader) { }

	// RVA: 0xD176B0 Offset: 0xD160B0 VA: 0x180D176B0
	public static void Store(PooledReader reader) { }

	// RVA: 0xD17730 Offset: 0xD16130 VA: 0x180D17730
	private static void .cctor() { }
}
