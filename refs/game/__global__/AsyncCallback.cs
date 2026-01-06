public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 3601
{
	// Methods

	// RVA: 0x593440 Offset: 0x591E40 VA: 0x180593440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
