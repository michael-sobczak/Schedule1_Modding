public sealed class ReplicateRpcDelegate : MulticastDelegate // TypeDefIndex: 12604
{
	// Methods

	// RVA: 0xD3AB70 Offset: 0xD39570 VA: 0x180D3AB70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40 Slot: 13
	public virtual void Invoke(PooledReader reader, NetworkConnection sender, Channel channel) { }

	// RVA: 0xD3AAE0 Offset: 0xD394E0 VA: 0x180D3AAE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(PooledReader reader, NetworkConnection sender, Channel channel, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
