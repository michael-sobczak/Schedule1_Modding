public sealed class ResponseCallback : MulticastDelegate // TypeDefIndex: 1156
{
	// Methods

	// RVA: 0x5EB340 Offset: 0x5E9D40 VA: 0x1805EB340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual void Invoke(string responseLabel) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(string responseLabel, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
