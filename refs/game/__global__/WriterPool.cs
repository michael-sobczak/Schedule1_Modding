public static class WriterPool // TypeDefIndex: 12513
{
	// Fields
	private static readonly Stack<PooledWriter> _pool; // 0x0
	private static readonly Dictionary<int, Stack<PooledWriter>> _lengthPool; // 0x8
	internal const int LENGTH_BRACKET = 1000;

	// Methods

	[Obsolete("Use Retrieve(NetworkManager).")]
	// RVA: 0xD1F1C0 Offset: 0xD1DBC0 VA: 0x180D1F1C0
	public static PooledWriter GetWriter(NetworkManager networkManager) { }

	// RVA: 0xD1F640 Offset: 0xD1E040 VA: 0x180D1F640
	public static PooledWriter Retrieve(NetworkManager networkManager) { }

	[Obsolete("Use Retrieve().")]
	// RVA: 0xD1F210 Offset: 0xD1DC10 VA: 0x180D1F210
	public static PooledWriter GetWriter() { }

	// RVA: 0xD1F410 Offset: 0xD1DE10 VA: 0x180D1F410
	public static PooledWriter Retrieve() { }

	[Obsolete("Use Retrieve(int).")]
	// RVA: 0xD1F2F0 Offset: 0xD1DCF0 VA: 0x180D1F2F0
	public static PooledWriter GetWriter(int length) { }

	// RVA: 0xD1F460 Offset: 0xD1DE60 VA: 0x180D1F460
	public static PooledWriter Retrieve(int length) { }

	[Obsolete("Use Retrieve(NetworkManager, int).")]
	// RVA: 0xD1F290 Offset: 0xD1DC90 VA: 0x180D1F290
	public static PooledWriter GetWriter(NetworkManager networkManager, int length) { }

	// RVA: 0xD1F4B0 Offset: 0xD1DEB0 VA: 0x180D1F4B0
	public static PooledWriter Retrieve(NetworkManager networkManager, int length) { }

	[Obsolete("Use StoreLength(PooledWriter).")]
	// RVA: 0xD1F370 Offset: 0xD1DD70 VA: 0x180D1F370
	public static void RecycleLength(PooledWriter writer) { }

	// RVA: 0xD1F790 Offset: 0xD1E190 VA: 0x180D1F790
	public static void StoreLength(PooledWriter writer) { }

	[Obsolete("Use Store(PooledWriter).")]
	// RVA: 0xD1F3C0 Offset: 0xD1DDC0 VA: 0x180D1F3C0
	public static void Recycle(PooledWriter writer) { }

	// RVA: 0xD1F9B0 Offset: 0xD1E3B0 VA: 0x180D1F9B0
	public static void Store(PooledWriter writer) { }

	// RVA: 0xD1F120 Offset: 0xD1DB20 VA: 0x180D1F120
	private static int GetDictionaryIndex(int length) { }

	// RVA: 0xD1F040 Offset: 0xD1DA40 VA: 0x180D1F040
	private static int GetDictionaryIndex(PooledWriter writer) { }

	// RVA: 0xD1FA30 Offset: 0xD1E430 VA: 0x180D1FA30
	private static void .cctor() { }
}
