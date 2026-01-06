public sealed class ServerRpcDelegate : MulticastDelegate // TypeDefIndex: 12610
{
	// Methods

	// RVA: 0xD3AF10 Offset: 0xD39910 VA: 0x180D3AF10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40 Slot: 13
	public virtual void Invoke(PooledReader reader, Channel channel, NetworkConnection sender) { }

	// RVA: 0xD3AE80 Offset: 0xD39880 VA: 0x180D3AE80 Slot: 14
	public virtual IAsyncResult BeginInvoke(PooledReader reader, Channel channel, NetworkConnection sender, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
