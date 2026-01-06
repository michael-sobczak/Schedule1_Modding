public static class SteamGameServerHTTP // TypeDefIndex: 14325
{
	// Methods

	// RVA: 0xC57D80 Offset: 0xC56780 VA: 0x180C57D80
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	// RVA: 0xC58820 Offset: 0xC57220 VA: 0x180C58820
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	// RVA: 0xC58C60 Offset: 0xC57660 VA: 0x180C58C60
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	// RVA: 0xC58AA0 Offset: 0xC574A0 VA: 0x180C58AA0
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	// RVA: 0xC588E0 Offset: 0xC572E0 VA: 0x180C588E0
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	// RVA: 0xC58510 Offset: 0xC56F10 VA: 0x180C58510
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0xC584B0 Offset: 0xC56EB0 VA: 0x180C584B0
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0xC57ED0 Offset: 0xC568D0 VA: 0x180C57ED0
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC583C0 Offset: 0xC56DC0 VA: 0x180C583C0
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC580C0 Offset: 0xC56AC0 VA: 0x180C580C0
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	// RVA: 0xC581F0 Offset: 0xC56BF0 VA: 0x180C581F0
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) { }

	// RVA: 0xC58060 Offset: 0xC56A60 VA: 0x180C58060
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	// RVA: 0xC57FE0 Offset: 0xC569E0 VA: 0x180C57FE0
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0xC58330 Offset: 0xC56D30 VA: 0x180C58330
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0xC58460 Offset: 0xC56E60 VA: 0x180C58460
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC57F20 Offset: 0xC56920 VA: 0x180C57F20
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	// RVA: 0xC58CC0 Offset: 0xC576C0 VA: 0x180C58CC0
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) { }

	// RVA: 0xC57CF0 Offset: 0xC566F0 VA: 0x180C57CF0
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	// RVA: 0xC58410 Offset: 0xC56E10 VA: 0x180C58410
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0xC58570 Offset: 0xC56F70 VA: 0x180C58570
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	// RVA: 0xC58880 Offset: 0xC57280 VA: 0x180C58880
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0xC58E60 Offset: 0xC57860 VA: 0x180C58E60
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

	// RVA: 0xC58E00 Offset: 0xC57800 VA: 0x180C58E00
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	// RVA: 0xC587C0 Offset: 0xC571C0 VA: 0x180C587C0
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	// RVA: 0xC57F80 Offset: 0xC56980 VA: 0x180C57F80
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }
}
