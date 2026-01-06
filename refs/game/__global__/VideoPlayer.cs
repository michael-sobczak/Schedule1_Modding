public sealed class VideoPlayer : Behaviour // TypeDefIndex: 19163
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2F5F2E0 Offset: 0x2F5DCE0 VA: 0x182F5F2E0
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F260 Offset: 0x2F5DC60 VA: 0x182F5F260
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F2A0 Offset: 0x2F5DCA0 VA: 0x182F5F2A0
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F360 Offset: 0x2F5DD60 VA: 0x182F5F360
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F220 Offset: 0x2F5DC20 VA: 0x182F5F220
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F1E0 Offset: 0x2F5DBE0 VA: 0x182F5F1E0
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F320 Offset: 0x2F5DD20 VA: 0x182F5F320
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F1A0 Offset: 0x2F5DBA0 VA: 0x182F5F1A0
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }
}
