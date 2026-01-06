public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 11239
{
	// Methods

	// RVA: 0xD073B0 Offset: 0xD05DB0 VA: 0x180D073B0
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0xD07380 Offset: 0xD05D80 VA: 0x180D07380 Slot: 13
	public virtual void Invoke(object o, StreamingContext context) { }

	// RVA: 0x1D93C00 Offset: 0x1D92600 VA: 0x181D93C00 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
