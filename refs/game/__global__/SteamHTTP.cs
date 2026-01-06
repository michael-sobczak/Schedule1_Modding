public static class SteamHTTP // TypeDefIndex: 14335
{
	// Methods

	// RVA: 0xC67170 Offset: 0xC65B70 VA: 0x180C67170
	public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) { }

	// RVA: 0xC67C10 Offset: 0xC66610 VA: 0x180C67C10
	public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) { }

	// RVA: 0xC68050 Offset: 0xC66A50 VA: 0x180C68050
	public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	// RVA: 0xC67E90 Offset: 0xC66890 VA: 0x180C67E90
	public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) { }

	// RVA: 0xC67CD0 Offset: 0xC666D0 VA: 0x180C67CD0
	public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) { }

	// RVA: 0xC67900 Offset: 0xC66300 VA: 0x180C67900
	public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0xC678A0 Offset: 0xC662A0 VA: 0x180C678A0
	public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	// RVA: 0xC672C0 Offset: 0xC65CC0 VA: 0x180C672C0
	public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC677B0 Offset: 0xC661B0 VA: 0x180C677B0
	public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC674B0 Offset: 0xC65EB0 VA: 0x180C674B0
	public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) { }

	// RVA: 0xC675E0 Offset: 0xC65FE0 VA: 0x180C675E0
	public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) { }

	// RVA: 0xC67450 Offset: 0xC65E50 VA: 0x180C67450
	public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) { }

	// RVA: 0xC673D0 Offset: 0xC65DD0 VA: 0x180C673D0
	public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0xC67720 Offset: 0xC66120 VA: 0x180C67720
	public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) { }

	// RVA: 0xC67850 Offset: 0xC66250 VA: 0x180C67850
	public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) { }

	// RVA: 0xC67310 Offset: 0xC65D10 VA: 0x180C67310
	public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) { }

	// RVA: 0xC680B0 Offset: 0xC66AB0 VA: 0x180C680B0
	public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) { }

	// RVA: 0xC670E0 Offset: 0xC65AE0 VA: 0x180C670E0
	public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) { }

	// RVA: 0xC67800 Offset: 0xC66200 VA: 0x180C67800
	public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0xC67960 Offset: 0xC66360 VA: 0x180C67960
	public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) { }

	// RVA: 0xC67C70 Offset: 0xC66670 VA: 0x180C67C70
	public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	// RVA: 0xC68250 Offset: 0xC66C50 VA: 0x180C68250
	public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) { }

	// RVA: 0xC681F0 Offset: 0xC66BF0 VA: 0x180C681F0
	public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	// RVA: 0xC67BB0 Offset: 0xC665B0 VA: 0x180C67BB0
	public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) { }

	// RVA: 0xC67370 Offset: 0xC65D70 VA: 0x180C67370
	public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }
}
