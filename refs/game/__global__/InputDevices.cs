public class InputDevices // TypeDefIndex: 18912
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceConnected; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<InputDevice> deviceDisconnected; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<InputDevice> deviceConfigChanged; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F5FDD0 Offset: 0x2F5E7D0 VA: 0x182F5FDD0
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
}
