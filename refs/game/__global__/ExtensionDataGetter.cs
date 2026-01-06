public sealed class ExtensionDataGetter : MulticastDelegate // TypeDefIndex: 11242
{
	// Methods

	// RVA: 0x1807370 Offset: 0x1805D70 VA: 0x181807370
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual IEnumerable<KeyValuePair<object, object>> Invoke(object o) { }

	// RVA: 0x593400 Offset: 0x591E00 VA: 0x180593400 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual IEnumerable<KeyValuePair<object, object>> EndInvoke(IAsyncResult result) { }
}
