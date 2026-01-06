public sealed class OnScanDelegate : MulticastDelegate // TypeDefIndex: 13128
{
	// Methods

	// RVA: 0xB0F650 Offset: 0xB0E050 VA: 0x180B0F650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(AstarPath script) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(AstarPath script, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
