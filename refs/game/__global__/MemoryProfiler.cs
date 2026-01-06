public static class MemoryProfiler // TypeDefIndex: 11509
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x2C94D70 Offset: 0x2C93770 VA: 0x182C94D70
	public static void add_CreatingMetadata(Action<MemorySnapshotMetadata> value) { }

	[CompilerGenerated]
	// RVA: 0x2C94E50 Offset: 0x2C93850 VA: 0x182C94E50
	public static void remove_CreatingMetadata(Action<MemorySnapshotMetadata> value) { }

	[RequiredByNativeCode]
	// RVA: 0x2C947F0 Offset: 0x2C931F0 VA: 0x182C947F0
	private static byte[] PrepareMetadata() { }

	// RVA: 0x2C94C50 Offset: 0x2C93650 VA: 0x182C94C50
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x2C94CD0 Offset: 0x2C936D0 VA: 0x182C94CD0
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCode]
	// RVA: 0x2C94760 Offset: 0x2C93160 VA: 0x182C94760
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x2C94B20 Offset: 0x2C93520 VA: 0x182C94B20
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}
