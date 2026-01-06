public class VideoCapture : IDisposable // TypeDefIndex: 11947
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2CEE5E0 Offset: 0x2CECFE0 VA: 0x182CEE5E0
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CEE480 Offset: 0x2CECE80 VA: 0x182CEE480
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x7C2A20 Offset: 0x7C1420 VA: 0x1807C2A20
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x2CEE540 Offset: 0x2CECF40 VA: 0x182CEE540
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CEE540 Offset: 0x2CECF40 VA: 0x182CEE540
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CEE540 Offset: 0x2CECF40 VA: 0x182CEE540
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CEE540 Offset: 0x2CECF40 VA: 0x182CEE540
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x2CEE350 Offset: 0x2CECD50 VA: 0x182CEE350 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	// RVA: 0x2CEE310 Offset: 0x2CECD10 VA: 0x182CEE310
	private void Dispose_Internal() { }

	// RVA: 0x2CEE3E0 Offset: 0x2CECDE0 VA: 0x182CEE3E0 Slot: 1
	protected override void Finalize() { }

	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	// RVA: 0x2CEE2D0 Offset: 0x2CECCD0 VA: 0x182CEE2D0
	private void DisposeThreaded_Internal() { }
}
