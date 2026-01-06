public sealed class InputDeviceExecuteCommandDelegate : MulticastDelegate // TypeDefIndex: 7613
{
	// Methods

	// RVA: 0x17C69D0 Offset: 0x17C53D0 VA: 0x1817C69D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430 Slot: 13
	public virtual long Invoke(ref InputDeviceCommand command) { }

	// RVA: 0x285FE30 Offset: 0x285E830 VA: 0x18285FE30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InputDeviceCommand command, AsyncCallback callback, object object) { }

	// RVA: 0x285FEC0 Offset: 0x285E8C0 VA: 0x18285FEC0 Slot: 15
	public virtual long EndInvoke(ref InputDeviceCommand command, IAsyncResult result) { }
}
