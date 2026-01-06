internal sealed class Gen2GcCallback : CriticalFinalizerObject // TypeDefIndex: 3633
{
	// Fields
	private Func<object, bool> _callback; // 0x10
	private GCHandle _weakTargetObj; // 0x18

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0x1C5F540 Offset: 0x1C5DF40 VA: 0x181C5F540
	public static void Register(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x1C5F5D0 Offset: 0x1C5DFD0 VA: 0x181C5F5D0
	private void Setup(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x1C5F430 Offset: 0x1C5DE30 VA: 0x181C5F430 Slot: 1
	protected override void Finalize() { }
}
