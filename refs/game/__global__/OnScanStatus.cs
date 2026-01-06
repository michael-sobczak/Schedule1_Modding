public sealed class OnScanStatus : MulticastDelegate // TypeDefIndex: 13129
{
	// Methods

	// RVA: 0xB0F840 Offset: 0xB0E240 VA: 0x180B0F840
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB0F810 Offset: 0xB0E210 VA: 0x180B0F810 Slot: 13
	public virtual void Invoke(Progress progress) { }

	// RVA: 0xB0F780 Offset: 0xB0E180 VA: 0x180B0F780 Slot: 14
	public virtual IAsyncResult BeginInvoke(Progress progress, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
