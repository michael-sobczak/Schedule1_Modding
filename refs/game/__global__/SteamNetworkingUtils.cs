public static class SteamNetworkingUtils // TypeDefIndex: 14347
{
	// Methods

	// RVA: 0xC70B60 Offset: 0xC6F560 VA: 0x180C70B60
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xC71200 Offset: 0xC6FC00 VA: 0x180C71200
	public static void InitRelayNetworkAccess() { }

	// RVA: 0xC711A0 Offset: 0xC6FBA0 VA: 0x180C711A0
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	// RVA: 0xC70F70 Offset: 0xC6F970 VA: 0x180C70F70
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	// RVA: 0xC70CF0 Offset: 0xC6F6F0 VA: 0x180C70CF0
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	// RVA: 0xC70D50 Offset: 0xC6F750 VA: 0x180C70D50
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	// RVA: 0xC70C10 Offset: 0xC6F610 VA: 0x180C70C10
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	// RVA: 0xC71300 Offset: 0xC6FD00 VA: 0x180C71300
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	// RVA: 0xC70BB0 Offset: 0xC6F5B0 VA: 0x180C70BB0
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	// RVA: 0xC710E0 Offset: 0xC6FAE0 VA: 0x180C710E0
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	// RVA: 0xC70ED0 Offset: 0xC6F8D0 VA: 0x180C70ED0
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	// RVA: 0xC71030 Offset: 0xC6FA30 VA: 0x180C71030
	public static int GetPOPCount() { }

	// RVA: 0xC71080 Offset: 0xC6FA80 VA: 0x180C71080
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	// RVA: 0xC70FD0 Offset: 0xC6F9D0 VA: 0x180C70FD0
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	// RVA: 0xC714B0 Offset: 0xC6FEB0 VA: 0x180C714B0
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	// RVA: 0xC71250 Offset: 0xC6FC50 VA: 0x180C71250
	public static bool IsFakeIPv4(uint nIPv4) { }

	// RVA: 0xC70F20 Offset: 0xC6F920 VA: 0x180C70F20
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	// RVA: 0xC71140 Offset: 0xC6FB40 VA: 0x180C71140
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	// RVA: 0xC71420 Offset: 0xC6FE20 VA: 0x180C71420
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	// RVA: 0xC70E30 Offset: 0xC6F830 VA: 0x180C70E30
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	// RVA: 0xC70DB0 Offset: 0xC6F7B0 VA: 0x180C70DB0
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	// RVA: 0xC712A0 Offset: 0xC6FCA0 VA: 0x180C712A0
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	// RVA: 0xC71690 Offset: 0xC70090 VA: 0x180C71690
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0xC71570 Offset: 0xC6FF70 VA: 0x180C71570
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	// RVA: 0xC71510 Offset: 0xC6FF10 VA: 0x180C71510
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	// RVA: 0xC718B0 Offset: 0xC702B0 VA: 0x180C718B0
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	// RVA: 0xC71790 Offset: 0xC70190 VA: 0x180C71790
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }
}
