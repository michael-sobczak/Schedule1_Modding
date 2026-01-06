public sealed class OnBeforeFocusEvent : MulticastDelegate // TypeDefIndex: 9305
{
	// Methods

	// RVA: 0x18070E0 Offset: 0x1805AE0 VA: 0x1818070E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual float Invoke(float currentFocusDistance) { }

	// RVA: 0x2AC4E10 Offset: 0x2AC3810 VA: 0x182AC4E10 Slot: 14
	public virtual IAsyncResult BeginInvoke(float currentFocusDistance, AsyncCallback callback, object object) { }

	// RVA: 0x574830 Offset: 0x573230 VA: 0x180574830 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}
