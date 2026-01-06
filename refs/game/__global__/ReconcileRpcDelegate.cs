public sealed class ReconcileRpcDelegate : MulticastDelegate // TypeDefIndex: 12605
{
	// Methods

	// RVA: 0xD25FF0 Offset: 0xD249F0 VA: 0x180D25FF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(PooledReader reader, Channel channel) { }

	// RVA: 0xD3AA40 Offset: 0xD39440 VA: 0x180D3AA40 Slot: 14
	public virtual IAsyncResult BeginInvoke(PooledReader reader, Channel channel, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
