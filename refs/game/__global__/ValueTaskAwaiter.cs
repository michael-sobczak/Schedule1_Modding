public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4616
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1318800 Offset: 0x1317200 VA: 0x181318800
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1B773A0 Offset: 0x1B75DA0 VA: 0x181B773A0
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1B77050 Offset: 0x1B75A50 VA: 0x181B77050
	public void GetResult() { }

	// RVA: 0x1B770A0 Offset: 0x1B75AA0 VA: 0x181B770A0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1B772D0 Offset: 0x1B75CD0 VA: 0x181B772D0
	private static void .cctor() { }
}
