public static class InputTracking // TypeDefIndex: 18899
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F60010 Offset: 0x2F5EA10 VA: 0x182F60010
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }
}
