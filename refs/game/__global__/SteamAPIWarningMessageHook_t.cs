public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate // TypeDefIndex: 14755
{
	// Methods

	// RVA: 0x825A40 Offset: 0x824440 VA: 0x180825A40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(int nSeverity, StringBuilder pchDebugText) { }

	// RVA: 0xCB1A30 Offset: 0xCB0430 VA: 0x180CB1A30 Slot: 14
	public virtual IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
