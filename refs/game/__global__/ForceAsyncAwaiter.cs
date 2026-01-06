internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4019
{
	// Fields
	private readonly Task _task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	internal void .ctor(Task task) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public ForceAsyncAwaiter GetAwaiter() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_IsCompleted() { }

	// RVA: 0x1CF0E40 Offset: 0x1CEF840 VA: 0x181CF0E40
	public void GetResult() { }

	// RVA: 0x1CF0E80 Offset: 0x1CEF880 VA: 0x181CF0E80 Slot: 4
	public void UnsafeOnCompleted(Action action) { }
}
