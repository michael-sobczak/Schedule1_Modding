internal sealed class ComCtlv6ActivationContext : IDisposable // TypeDefIndex: 17243
{
	// Fields
	private IntPtr _cookie; // 0x10
	private static NativeMethods.ACTCTX _enableThemingActivationContext; // 0x0
	private static ActivationContextSafeHandle _activationContext; // 0x30
	private static bool _contextCreationSucceeded; // 0x38
	private static readonly object _contextCreationLock; // 0x40

	// Methods

	// RVA: 0x1DFEA20 Offset: 0x1DFD420 VA: 0x181DFEA20
	public void .ctor(bool enable) { }

	// RVA: 0x1DFE940 Offset: 0x1DFD340 VA: 0x181DFE940 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1DFE530 Offset: 0x1DFCF30 VA: 0x181DFE530 Slot: 4
	public void Dispose() { }

	// RVA: 0x1DFE470 Offset: 0x1DFCE70 VA: 0x181DFE470
	private void Dispose(bool disposing) { }

	// RVA: 0x1DFE590 Offset: 0x1DFCF90 VA: 0x181DFE590
	private static bool EnsureActivateContextCreated() { }

	// RVA: 0x1DFE9A0 Offset: 0x1DFD3A0 VA: 0x181DFE9A0
	private static void .cctor() { }
}
