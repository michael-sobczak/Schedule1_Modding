public sealed class PropertiesChangedEvent : MulticastDelegate // TypeDefIndex: 383
{
	// Methods

	// RVA: 0x5A15A0 Offset: 0x59FFA0 VA: 0x1805A15A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(LiquidVolume lv) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(LiquidVolume lv, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
