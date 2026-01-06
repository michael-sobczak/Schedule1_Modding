public static class SteamHTMLSurface // TypeDefIndex: 14334
{
	// Methods

	// RVA: 0xC66270 Offset: 0xC64C70 VA: 0x180C66270
	public static bool Init() { }

	// RVA: 0xC66FA0 Offset: 0xC659A0 VA: 0x180C66FA0
	public static bool Shutdown() { }

	// RVA: 0xC65CE0 Offset: 0xC646E0 VA: 0x180C65CE0
	public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS) { }

	// RVA: 0xC66960 Offset: 0xC65360 VA: 0x180C66960
	public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC664B0 Offset: 0xC64EB0 VA: 0x180C664B0
	public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) { }

	// RVA: 0xC66EC0 Offset: 0xC658C0 VA: 0x180C66EC0
	public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	// RVA: 0xC67040 Offset: 0xC65A40 VA: 0x180C67040
	public static void StopLoad(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC66910 Offset: 0xC65310 VA: 0x180C66910
	public static void Reload(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC661D0 Offset: 0xC64BD0 VA: 0x180C661D0
	public static void GoBack(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC66220 Offset: 0xC64C20 VA: 0x180C66220
	public static void GoForward(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC65A70 Offset: 0xC64470 VA: 0x180C65A70
	public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue) { }

	// RVA: 0xC65EB0 Offset: 0xC648B0 VA: 0x180C65EB0
	public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) { }

	// RVA: 0xC667B0 Offset: 0xC651B0 VA: 0x180C667B0
	public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0xC666D0 Offset: 0xC650D0 VA: 0x180C666D0
	public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0xC66670 Offset: 0xC65070 VA: 0x180C66670
	public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	// RVA: 0xC66730 Offset: 0xC65130 VA: 0x180C66730
	public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0xC66810 Offset: 0xC65210 VA: 0x180C66810
	public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) { }

	// RVA: 0xC663A0 Offset: 0xC64DA0 VA: 0x180C663A0
	public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = False) { }

	// RVA: 0xC66430 Offset: 0xC64E30 VA: 0x180C66430
	public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0xC66320 Offset: 0xC64D20 VA: 0x180C66320
	public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	// RVA: 0xC66D70 Offset: 0xC65770 VA: 0x180C66D70
	public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0xC66F40 Offset: 0xC65940 VA: 0x180C66F40
	public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	// RVA: 0xC66DD0 Offset: 0xC657D0 VA: 0x180C66DD0
	public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	// RVA: 0xC67090 Offset: 0xC65A90 VA: 0x180C67090
	public static void ViewSource(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC65C90 Offset: 0xC64690 VA: 0x180C65C90
	public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC668C0 Offset: 0xC652C0 VA: 0x180C668C0
	public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC66020 Offset: 0xC64A20 VA: 0x180C66020
	public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	// RVA: 0xC66FF0 Offset: 0xC659F0 VA: 0x180C66FF0
	public static void StopFind(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC66150 Offset: 0xC64B50 VA: 0x180C66150
	public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) { }

	// RVA: 0xC66A10 Offset: 0xC65410 VA: 0x180C66A10
	public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0, bool bSecure = False, bool bHTTPOnly = False) { }

	// RVA: 0xC66E30 Offset: 0xC65830 VA: 0x180C66E30
	public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	// RVA: 0xC669B0 Offset: 0xC653B0 VA: 0x180C669B0
	public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	// RVA: 0xC66D10 Offset: 0xC65710 VA: 0x180C66D10
	public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	// RVA: 0xC66870 Offset: 0xC65270 VA: 0x180C66870
	public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) { }

	// RVA: 0xC65C30 Offset: 0xC64630 VA: 0x180C65C30
	public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	// RVA: 0xC662C0 Offset: 0xC64CC0 VA: 0x180C662C0
	public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) { }

	// RVA: 0xC65FC0 Offset: 0xC649C0 VA: 0x180C65FC0
	public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }
}
