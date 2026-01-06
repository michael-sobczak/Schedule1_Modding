public sealed class InputDeviceCommandDelegate : MulticastDelegate // TypeDefIndex: 7612
{
	// Methods

	// RVA: 0x285FC30 Offset: 0x285E630 VA: 0x18285FC30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1808CB0 Offset: 0x18076B0 VA: 0x181808CB0 Slot: 13
	public virtual Nullable<long> Invoke(InputDevice device, InputDeviceCommand* command) { }

	// RVA: 0x65BAF0 Offset: 0x65A4F0 VA: 0x18065BAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(InputDevice device, InputDeviceCommand* command, AsyncCallback callback, object object) { }

	// RVA: 0xC23560 Offset: 0xC21F60 VA: 0x180C23560 Slot: 15
	public virtual Nullable<long> EndInvoke(IAsyncResult result) { }
}
