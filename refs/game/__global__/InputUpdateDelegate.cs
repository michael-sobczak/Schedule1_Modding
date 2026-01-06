internal sealed class InputUpdateDelegate : MulticastDelegate // TypeDefIndex: 7690
{
	// Methods

	// RVA: 0x825A40 Offset: 0x824440 VA: 0x180825A40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0 Slot: 13
	public virtual void Invoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	// RVA: 0x287AD30 Offset: 0x2879730 VA: 0x18287AD30 Slot: 14
	public virtual IAsyncResult BeginInvoke(InputUpdateType updateType, ref InputEventBuffer eventBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x12C7ED0 Offset: 0x12C68D0 VA: 0x1812C7ED0 Slot: 15
	public virtual void EndInvoke(ref InputEventBuffer eventBuffer, IAsyncResult result) { }
}
