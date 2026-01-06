public sealed class SyncVarReadDelegate : MulticastDelegate // TypeDefIndex: 12612
{
	// Methods

	// RVA: 0xD3E7B0 Offset: 0xD3D1B0 VA: 0x180D3E7B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40 Slot: 13
	public virtual bool Invoke(PooledReader reader, byte index, bool asServer) { }

	// RVA: 0xD3E710 Offset: 0xD3D110 VA: 0x180D3E710 Slot: 14
	public virtual IAsyncResult BeginInvoke(PooledReader reader, byte index, bool asServer, AsyncCallback callback, object object) { }

	// RVA: 0x5F34C0 Offset: 0x5F1EC0 VA: 0x1805F34C0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}
