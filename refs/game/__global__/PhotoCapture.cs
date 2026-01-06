public class PhotoCapture : IDisposable // TypeDefIndex: 11938
{
	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2CC28E0 Offset: 0x2CC12E0 VA: 0x182CC28E0
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2820 Offset: 0x2CC1220 VA: 0x182CC2820
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x7C2A20 Offset: 0x7C1420 VA: 0x1807C2A20
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2670 Offset: 0x2CC1070 VA: 0x182CC2670
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2670 Offset: 0x2CC1070 VA: 0x182CC2670
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2670 Offset: 0x2CC1070 VA: 0x182CC2670
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2710 Offset: 0x2CC1110 VA: 0x182CC2710
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2CC2540 Offset: 0x2CC0F40 VA: 0x182CC2540 Slot: 4
	public void Dispose() { }

	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	// RVA: 0x2CC2500 Offset: 0x2CC0F00 VA: 0x182CC2500
	private void Dispose_Internal() { }

	// RVA: 0x2CC25D0 Offset: 0x2CC0FD0 VA: 0x182CC25D0 Slot: 1
	protected override void Finalize() { }

	[NativeName("DisposeThreaded")]
	[ThreadAndSerializationSafe]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	// RVA: 0x2CC24C0 Offset: 0x2CC0EC0 VA: 0x182CC24C0
	private void DisposeThreaded_Internal() { }
}
