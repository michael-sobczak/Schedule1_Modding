public sealed class SetCompressionCallback : MulticastDelegate // TypeDefIndex: 16579
{
	// Methods

	// RVA: 0x1E350A0 Offset: 0x1E33AA0 VA: 0x181E350A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual CompressionLevel Invoke(string localFileName, string fileNameInArchive) { }

	// RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string localFileName, string fileNameInArchive, AsyncCallback callback, object object) { }

	// RVA: 0x1C39910 Offset: 0x1C38310 VA: 0x181C39910 Slot: 15
	public virtual CompressionLevel EndInvoke(IAsyncResult result) { }
}
