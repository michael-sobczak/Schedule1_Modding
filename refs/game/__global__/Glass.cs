public static class Glass // TypeDefIndex: 17250
{
	// Properties
	public static bool OSSupportsDwmComposition { get; }
	public static bool IsDwmCompositionEnabled { get; }

	// Methods

	// RVA: 0x1E04C50 Offset: 0x1E03650 VA: 0x181E04C50
	public static bool get_OSSupportsDwmComposition() { }

	// RVA: 0x1E04BB0 Offset: 0x1E035B0 VA: 0x181E04BB0
	public static bool get_IsDwmCompositionEnabled() { }

	[Extension]
	// RVA: 0x1E04380 Offset: 0x1E02D80 VA: 0x181E04380
	public static void ExtendFrameIntoClientArea(IWin32Window window, Padding glassMargin) { }

	// RVA: 0x1E03C80 Offset: 0x1E02680 VA: 0x181E03C80
	public static void DrawCompositedText(IDeviceContext dc, string text, Font font, Rectangle bounds, Padding padding, Color foreColor, int glowSize, TextFormatFlags textFormat) { }

	// RVA: 0x1E04560 Offset: 0x1E02F60 VA: 0x181E04560
	public static Size MeasureCompositedText(IDeviceContext dc, string text, Font font, TextFormatFlags textFormat) { }
}
