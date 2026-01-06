public static class ScreenshotUtil // TypeDefIndex: 18000
{
	// Fields
	private const int BixTex = 4082;
	private const float TexDimensionMax = 1920;

	// Methods

	// RVA: 0x441EB0 Offset: 0x4408B0 VA: 0x180441EB0
	public static IEnumerator CaptureScreenshot(ScreenshotMode mode, bool resizeLargeScreenshots, Action<byte[]> onCapturedCallback, Action<string> onErrorCallback) { }

	[IteratorStateMachine(typeof(ScreenshotUtil.<CaptureScreenshotAsTexture>d__3))]
	// RVA: 0x441DA0 Offset: 0x4407A0 VA: 0x180441DA0
	private static IEnumerator CaptureScreenshotAsTexture(bool resizeLargeScreenshots, Action<byte[]> onCapturedCallback) { }

	[IteratorStateMachine(typeof(ScreenshotUtil.<CaptureScreenshotLegacy>d__4))]
	// RVA: 0x441E20 Offset: 0x440820 VA: 0x180441E20
	private static IEnumerator CaptureScreenshotLegacy(Action<byte[]> onCapturedCallback, Action<string> onErrorCallback) { }
}
