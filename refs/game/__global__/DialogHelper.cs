internal static class DialogHelper // TypeDefIndex: 17246
{
	// Properties
	public static bool IsTaskDialogThemeSupported { get; }

	// Methods

	// RVA: 0x1E02780 Offset: 0x1E01180 VA: 0x181E02780
	public static bool get_IsTaskDialogThemeSupported() { }

	// RVA: 0x1E02460 Offset: 0x1E00E60 VA: 0x181E02460
	public static int GetTextHeight(IDeviceContext dc, string mainInstruction, string content, Font mainInstructionFallbackFont, Font contentFallbackFont, int width) { }

	// RVA: 0x1E02510 Offset: 0x1E00F10 VA: 0x181E02510
	public static Size SizeDialog(IDeviceContext dc, string mainInstruction, string content, Screen screen, Font mainInstructionFallbackFont, Font contentFallbackFont, int horizontalSpacing, int verticalSpacing, int minimumWidth, int textMinimumHeight) { }

	// RVA: 0x1E01F90 Offset: 0x1E00990 VA: 0x181E01F90
	public static void DrawText(IDeviceContext dc, string text, VisualStyleElement element, Font fallbackFont, ref Point location, bool measureOnly, int width) { }

	// RVA: 0x1E02250 Offset: 0x1E00C50 VA: 0x181E02250
	public static void DrawText(IDeviceContext dc, string mainInstruction, string content, ref Point location, Font mainInstructionFallbackFont, Font contentFallbackFont, bool measureOnly, int width) { }
}
