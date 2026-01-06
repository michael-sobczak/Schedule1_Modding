public sealed class OpenDelegate : MulticastDelegate // TypeDefIndex: 16577
{
	// Methods

	// RVA: 0x1E34830 Offset: 0x1E33230 VA: 0x181E34830
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual Stream Invoke(string entryName) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(string entryName, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual Stream EndInvoke(IAsyncResult result) { }
}
