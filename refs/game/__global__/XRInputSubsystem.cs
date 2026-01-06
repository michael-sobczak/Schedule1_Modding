public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 18920
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2F61350 Offset: 0x2F5FD50 VA: 0x182F61350
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x2F612A0 Offset: 0x2F5FCA0 VA: 0x182F612A0
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x2F61400 Offset: 0x2F5FE00 VA: 0x182F61400
	public void .ctor() { }
}
