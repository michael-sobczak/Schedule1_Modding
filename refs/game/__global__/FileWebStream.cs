internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 10031
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x25B3180 Offset: 0x25B1B80 VA: 0x1825B3180
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x25B3220 Offset: 0x25B1C20 VA: 0x1825B3220
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x25B2F00 Offset: 0x25B1900 VA: 0x1825B2F00 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x25B30A0 Offset: 0x25B1AA0 VA: 0x1825B30A0 Slot: 42
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x25B3010 Offset: 0x25B1A10 VA: 0x1825B3010 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x25B30F0 Offset: 0x25B1AF0 VA: 0x1825B30F0 Slot: 37
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x25B2D00 Offset: 0x25B1700 VA: 0x1825B2D00 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x25B2F90 Offset: 0x25B1990 VA: 0x1825B2F90 Slot: 25
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x25B2DB0 Offset: 0x25B17B0 VA: 0x1825B2DB0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x25B2FD0 Offset: 0x25B19D0 VA: 0x1825B2FD0 Slot: 29
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x25B2E60 Offset: 0x25B1860 VA: 0x1825B2E60
	private void CheckError() { }
}
