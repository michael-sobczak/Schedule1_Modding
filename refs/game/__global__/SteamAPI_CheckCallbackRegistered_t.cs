public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate // TypeDefIndex: 14756
{
	// Methods

	// RVA: 0x8447E0 Offset: 0x8431E0 VA: 0x1808447E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(int iCallbackNum) { }

	// RVA: 0xCB1AC0 Offset: 0xCB04C0 VA: 0x180CB1AC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
