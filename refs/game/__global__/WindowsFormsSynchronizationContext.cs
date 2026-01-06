public sealed class WindowsFormsSynchronizationContext : SynchronizationContext, IDisposable // TypeDefIndex: 5708
{
	// Fields
	private static bool auto_installed; // 0x0
	private static Control invoke_control; // 0x8
	private static SynchronizationContext previous_context; // 0x10

	// Properties
	[EditorBrowsable(2)]
	public static bool AutoInstall { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x2270340 Offset: 0x226ED40 VA: 0x182270340
	private static void .cctor() { }

	// RVA: 0x2270420 Offset: 0x226EE20 VA: 0x182270420
	public static bool get_AutoInstall() { }

	// RVA: 0x2270130 Offset: 0x226EB30 VA: 0x182270130 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public void Dispose() { }

	// RVA: 0x2270140 Offset: 0x226EB40 VA: 0x182270140 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x2270240 Offset: 0x226EC40 VA: 0x182270240 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }
}
