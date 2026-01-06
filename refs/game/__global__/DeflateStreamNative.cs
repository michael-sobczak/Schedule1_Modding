internal class DeflateStreamNative // TypeDefIndex: 9921
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x269D400 Offset: 0x269BE00 VA: 0x18269D400
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x269D790 Offset: 0x269C190 VA: 0x18269D790 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x269D680 Offset: 0x269C080 VA: 0x18269D680
	public void Dispose(bool disposing) { }

	// RVA: 0x269D7F0 Offset: 0x269C1F0 VA: 0x18269D7F0
	public void Flush() { }

	// RVA: 0x269D910 Offset: 0x269C310 VA: 0x18269D910
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x269DEB0 Offset: 0x269C8B0 VA: 0x18269DEB0
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x269DA50 Offset: 0x269C450 VA: 0x18269DA50
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x269DB10 Offset: 0x269C510 VA: 0x18269DB10
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x269DDF0 Offset: 0x269C7F0 VA: 0x18269DDF0
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x269DC70 Offset: 0x269C670 VA: 0x18269DC70
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x269D210 Offset: 0x269BC10 VA: 0x18269D210
	private void CheckResult(int result, string where) { }

	// RVA: 0x269D370 Offset: 0x269BD70 VA: 0x18269D370
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x269D360 Offset: 0x269BD60 VA: 0x18269D360
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x269D8A0 Offset: 0x269C2A0 VA: 0x18269D8A0
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x269D9D0 Offset: 0x269C3D0 VA: 0x18269D9D0
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x269DF70 Offset: 0x269C970 VA: 0x18269DF70
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}
