public sealed class SteamInputActionEventCallbackPointer : MulticastDelegate // TypeDefIndex: 14774
{
	// Methods

	// RVA: 0xC84F40 Offset: 0xC83940 VA: 0x180C84F40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(IntPtr SteamInputActionEvent) { }

	// RVA: 0xCB2900 Offset: 0xCB1300 VA: 0x180CB2900 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr SteamInputActionEvent, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
