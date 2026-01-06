public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 11302
{
	// Methods

	// RVA: 0x65BB30 Offset: 0x65A530 VA: 0x18065BB30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(object sender, ValidationEventArgs e) { }

	// RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
