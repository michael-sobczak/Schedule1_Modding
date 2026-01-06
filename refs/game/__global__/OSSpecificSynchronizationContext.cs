internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 3971
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	private void .ctor(object osContext) { }

	// RVA: 0x1CE1980 Offset: 0x1CE0380 VA: 0x181CE1980
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1CE1900 Offset: 0x1CE0300 VA: 0x181CE1900 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1CE1DD0 Offset: 0x1CE07D0 VA: 0x181CE1DD0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1CE1C10 Offset: 0x1CE0610 VA: 0x181CE1C10 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
	// RVA: 0x1CE1B10 Offset: 0x1CE0510 VA: 0x181CE1B10
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1CE1970 Offset: 0x1CE0370 VA: 0x181CE1970
	private static object GetOSContext() { }

	// RVA: 0x1CE1C00 Offset: 0x1CE0600 VA: 0x181CE1C00
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1CE1E10 Offset: 0x1CE0810 VA: 0x181CE1E10
	private static void .cctor() { }
}
