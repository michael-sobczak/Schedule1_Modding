public sealed class RenderFunc<PassData> : MulticastDelegate // TypeDefIndex: 13506
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BB30 Offset: 0x65A530 VA: 0x18065BB30
	|-RenderFunc<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(PassData data, RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-RenderFunc<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(PassData data, RenderGraphContext renderGraphContext, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0
	|-RenderFunc<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454C00 Offset: 0x453600 VA: 0x180454C00
	|-RenderFunc<object>.EndInvoke
	*/
}
