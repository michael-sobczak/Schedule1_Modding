public sealed class InputDeviceFindControlLayoutDelegate : MulticastDelegate // TypeDefIndex: 7737
{
	// Methods

	// RVA: 0x28745F0 Offset: 0x2872FF0 VA: 0x1828745F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40 Slot: 13
	public virtual string Invoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x2874560 Offset: 0x2872F60 VA: 0x182874560 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand, AsyncCallback callback, object object) { }

	// RVA: 0x12C7ED0 Offset: 0x12C68D0 VA: 0x1812C7ED0 Slot: 15
	public virtual string EndInvoke(ref InputDeviceDescription description, IAsyncResult result) { }
}
