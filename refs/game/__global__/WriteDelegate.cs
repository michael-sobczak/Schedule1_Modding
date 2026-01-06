public sealed class WriteDelegate : MulticastDelegate // TypeDefIndex: 16576
{
	// Methods

	// RVA: 0xCB1600 Offset: 0xCB0000 VA: 0x180CB1600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(string entryName, Stream stream) { }

	// RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string entryName, Stream stream, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
