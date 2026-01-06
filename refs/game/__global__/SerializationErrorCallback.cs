public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 11240
{
	// Methods

	// RVA: 0x1D93D20 Offset: 0x1D92720 VA: 0x181D93D20
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x157D5D0 Offset: 0x157BFD0 VA: 0x18157D5D0 Slot: 13
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x1D93C90 Offset: 0x1D92690 VA: 0x181D93C90 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	// RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}
