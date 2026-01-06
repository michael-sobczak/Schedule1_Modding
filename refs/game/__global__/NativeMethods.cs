internal static class NativeMethods // TypeDefIndex: 17291
{
	// Fields
	public const int ErrorFileNotFound = 2;
	public const int WM_USER = 1024;
	public const int WM_GETICON = 127;
	public const int WM_SETICON = 128;
	public const int ICON_SMALL = 0;
	public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = 4;
	public const int WM_NCHITTEST = 132;
	public const int WM_DWMCOMPOSITIONCHANGED = 798;
	internal const int CREDUI_MAX_USERNAME_LENGTH = 513;
	internal const int CREDUI_MAX_PASSWORD_LENGTH = 256;

	// Properties
	public static bool IsWindowsVistaOrLater { get; }
	public static bool IsWindowsXPOrLater { get; }

	// Methods

	// RVA: 0x1E096B0 Offset: 0x1E080B0 VA: 0x181E096B0
	public static bool get_IsWindowsVistaOrLater() { }

	// RVA: 0x1E09760 Offset: 0x1E08160 VA: 0x181E09760
	public static bool get_IsWindowsXPOrLater() { }

	// RVA: 0x1E08F40 Offset: 0x1E07940 VA: 0x181E08F40
	public static extern SafeModuleHandle LoadLibraryEx(string lpFileName, IntPtr hFile, NativeMethods.LoadLibraryExFlags dwFlags) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1E08BF0 Offset: 0x1E075F0 VA: 0x181E08BF0
	public static extern bool FreeLibrary(IntPtr hModule) { }

	// RVA: 0x1E08C80 Offset: 0x1E07680 VA: 0x181E08C80
	public static extern IntPtr GetActiveWindow() { }

	// RVA: 0x1E08EB0 Offset: 0x1E078B0 VA: 0x181E08EB0
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId) { }

	// RVA: 0x1E08CF0 Offset: 0x1E076F0 VA: 0x181E08CF0
	public static extern int GetCurrentThreadId() { }

	// RVA: 0x1E094F0 Offset: 0x1E07EF0 VA: 0x181E094F0
	public static extern void TaskDialogIndirect(in NativeMethods.TASKDIALOGCONFIG pTaskConfig, out int pnButton, out int pnRadioButton, out bool pfVerificationFlagChecked) { }

	// RVA: 0x1E09450 Offset: 0x1E07E50 VA: 0x181E09450
	public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam) { }

	// RVA: 0x1E072A0 Offset: 0x1E05CA0 VA: 0x181E072A0
	public static extern ActivationContextSafeHandle CreateActCtx(ref NativeMethods.ACTCTX actctx) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1E09170 Offset: 0x1E07B70 VA: 0x181E09170
	public static extern void ReleaseActCtx(IntPtr hActCtx) { }

	// RVA: 0x1E07070 Offset: 0x1E05A70 VA: 0x181E07070
	public static extern bool ActivateActCtx(ActivationContextSafeHandle hActCtx, out IntPtr lpCookie) { }

	// RVA: 0x1E08500 Offset: 0x1E06F00 VA: 0x181E08500
	public static extern bool DeactivateActCtx(uint dwFlags, IntPtr lpCookie) { }

	// RVA: 0x1E091F0 Offset: 0x1E07BF0 VA: 0x181E091F0
	public static extern int SHCreateItemFromParsingName(string pszPath, IntPtr pbc, ref Guid riid, out object ppv) { }

	// RVA: 0x1E07870 Offset: 0x1E06270 VA: 0x181E07870
	public static IShellItem CreateItemFromParsingName(string path) { }

	// RVA: 0x1E09040 Offset: 0x1E07A40 VA: 0x181E09040
	public static extern int LoadString(SafeModuleHandle hInstance, uint uID, StringBuilder lpBuffer, int nBufferMax) { }

	// RVA: 0x1E08A50 Offset: 0x1E07450 VA: 0x181E08A50
	public static extern uint FormatMessage(NativeMethods.FormatMessageFlags dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, ref IntPtr lpBuffer, uint nSize, string[] Arguments) { }

	// RVA: 0x1E08910 Offset: 0x1E07310 VA: 0x181E08910
	public static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, in NativeMethods.MARGINS pMarInset) { }

	// RVA: 0x1E089B0 Offset: 0x1E073B0 VA: 0x181E089B0
	public static extern bool DwmIsCompositionEnabled() { }

	// RVA: 0x1E074F0 Offset: 0x1E05EF0 VA: 0x181E074F0
	public static extern SafeDeviceHandle CreateCompatibleDC(IntPtr hDC) { }

	// RVA: 0x1E09320 Offset: 0x1E07D20 VA: 0x181E09320
	public static extern IntPtr SelectObject(SafeDeviceHandle hDC, SafeGDIHandle hObject) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1E08630 Offset: 0x1E07030 VA: 0x181E08630
	public static extern bool DeleteObject(IntPtr hObject) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1E085A0 Offset: 0x1E06FA0 VA: 0x181E085A0
	public static extern bool DeleteDC(IntPtr hdc) { }

	// RVA: 0x1E07150 Offset: 0x1E05B50 VA: 0x181E07150
	public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, SafeDeviceHandle hdcSrc, int nXSrc, int nYSrc, uint dwRop) { }

	// RVA: 0x1E086C0 Offset: 0x1E070C0 VA: 0x181E086C0
	public static extern void DrawThemeTextEx(IntPtr hTheme, SafeDeviceHandle hdc, int iPartId, int iStateId, string text, int iCharCount, int dwFlags, ref NativeMethods.RECT pRect, ref NativeMethods.DTTOPTS pOptions) { }

	// RVA: 0x1E075C0 Offset: 0x1E05FC0 VA: 0x181E075C0
	public static extern SafeGDIHandle CreateDIBSection(IntPtr hdc, NativeMethods.BITMAPINFO pbmi, uint iUsage, IntPtr ppvBits, IntPtr hSection, uint dwOffset) { }

	// RVA: 0x1E08D60 Offset: 0x1E07760 VA: 0x181E08D60
	public static extern void GetThemeTextExtent(IntPtr hTheme, SafeDeviceHandle hdc, int iPartId, int iStateId, string text, int iCharCount, int dwTextFlags, in NativeMethods.RECT bounds, out NativeMethods.RECT rect) { }

	// RVA: 0x1E076E0 Offset: 0x1E060E0 VA: 0x181E076E0
	public static SafeGDIHandle CreateDib(Rectangle bounds, IntPtr primaryHdc, SafeDeviceHandle memoryHdc) { }

	// RVA: 0x1E07D30 Offset: 0x1E06730 VA: 0x181E07D30
	internal static extern NativeMethods.CredUIReturnCodes CredUIPromptForCredentials(ref NativeMethods.CREDUI_INFO pUiInfo, string targetName, IntPtr Reserved, int dwAuthError, StringBuilder pszUserName, uint ulUserNameMaxChars, StringBuilder pszPassword, uint ulPaswordMaxChars, ref bool pfSave, NativeMethods.CREDUI_FLAGS dwFlags) { }

	// RVA: 0x1E07F60 Offset: 0x1E06960 VA: 0x181E07F60
	public static extern NativeMethods.CredUIReturnCodes CredUIPromptForWindowsCredentials(ref NativeMethods.CREDUI_INFO pUiInfo, uint dwAuthError, ref uint pulAuthPackage, IntPtr pvInAuthBuffer, uint ulInAuthBufferSize, out IntPtr ppvOutAuthBuffer, out uint pulOutAuthBufferSize, ref bool pfSave, NativeMethods.CredUIWinFlags dwFlags) { }

	// RVA: 0x1E07C70 Offset: 0x1E06670 VA: 0x181E07C70
	internal static extern bool CredRead(string TargetName, NativeMethods.CredTypes Type, int Flags, out IntPtr Credential) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1E07B10 Offset: 0x1E06510 VA: 0x181E07B10
	internal static extern void CredFree(IntPtr Buffer) { }

	// RVA: 0x1E07A60 Offset: 0x1E06460 VA: 0x181E07A60
	internal static extern bool CredDelete(string TargetName, NativeMethods.CredTypes Type, int Flags) { }

	// RVA: 0x1E082A0 Offset: 0x1E06CA0 VA: 0x181E082A0
	internal static extern bool CredWrite(ref NativeMethods.CREDENTIAL Credential, int Flags) { }

	// RVA: 0x1E07B90 Offset: 0x1E06590 VA: 0x181E07B90
	public static extern bool CredPackAuthenticationBuffer(uint dwFlags, string pszUserName, string pszPassword, IntPtr pPackedCredentials, ref uint pcbPackedCredentials) { }

	// RVA: 0x1E08130 Offset: 0x1E06B30 VA: 0x181E08130
	public static extern bool CredUnPackAuthenticationBuffer(uint dwFlags, IntPtr pAuthBuffer, uint cbAuthBuffer, StringBuilder pszUserName, ref uint pcchMaxUserName, StringBuilder pszDomainName, ref uint pcchMaxDomainName, StringBuilder pszPassword, ref uint pcchMaxPassword) { }
}
