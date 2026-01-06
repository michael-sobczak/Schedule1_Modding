public sealed class ExtensionDataSetter : MulticastDelegate // TypeDefIndex: 11241
{
	// Methods

	// RVA: 0xD069E0 Offset: 0xD053E0 VA: 0x180D069E0
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40 Slot: 13
	public virtual void Invoke(object o, string key, object value) { }

	// RVA: 0xBF4160 Offset: 0xBF2B60 VA: 0x180BF4160 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, string key, object value, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
