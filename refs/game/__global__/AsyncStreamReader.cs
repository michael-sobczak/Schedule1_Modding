internal class AsyncStreamReader // TypeDefIndex: 9589
{
	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private byte[] byteBuffer; // 0x28
	private char[] charBuffer; // 0x30
	private bool cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private object syncObject; // 0x48
	private IAsyncResult asyncReadResult; // 0x50

	// Methods

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public virtual void Close() { }

	// RVA: 0x262B7A0 Offset: 0x262A1A0 VA: 0x18262B7A0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x867D60 Offset: 0x866760 VA: 0x180867D60
	internal void CancelOperation() { }
}
