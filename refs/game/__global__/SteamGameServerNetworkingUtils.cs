public static class SteamGameServerNetworkingUtils // TypeDefIndex: 14330
{
	// Methods

	// RVA: 0xC5C700 Offset: 0xC5B100 VA: 0x180C5C700
	public static IntPtr AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xC5CD60 Offset: 0xC5B760 VA: 0x180C5CD60
	public static void InitRelayNetworkAccess() { }

	// RVA: 0xC5CD10 Offset: 0xC5B710 VA: 0x180C5CD10
	public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) { }

	// RVA: 0xC5CB00 Offset: 0xC5B500 VA: 0x180C5CB00
	public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) { }

	// RVA: 0xC5C890 Offset: 0xC5B290 VA: 0x180C5C890
	public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	// RVA: 0xC5C8F0 Offset: 0xC5B2F0 VA: 0x180C5C8F0
	public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) { }

	// RVA: 0xC5C7B0 Offset: 0xC5B1B0 VA: 0x180C5C7B0
	public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) { }

	// RVA: 0xC5CE60 Offset: 0xC5B860 VA: 0x180C5CE60
	public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) { }

	// RVA: 0xC5C750 Offset: 0xC5B150 VA: 0x180C5C750
	public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) { }

	// RVA: 0xC5CC50 Offset: 0xC5B650 VA: 0x180C5CC50
	public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	// RVA: 0xC5CA60 Offset: 0xC5B460 VA: 0x180C5CA60
	public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) { }

	// RVA: 0xC5CBA0 Offset: 0xC5B5A0 VA: 0x180C5CBA0
	public static int GetPOPCount() { }

	// RVA: 0xC5CBF0 Offset: 0xC5B5F0 VA: 0x180C5CBF0
	public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) { }

	// RVA: 0xC5CB50 Offset: 0xC5B550 VA: 0x180C5CB50
	public static SteamNetworkingMicroseconds GetLocalTimestamp() { }

	// RVA: 0xC5D010 Offset: 0xC5BA10 VA: 0x180C5D010
	public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	// RVA: 0xC5CDB0 Offset: 0xC5B7B0 VA: 0x180C5CDB0
	public static bool IsFakeIPv4(uint nIPv4) { }

	// RVA: 0xC5CAB0 Offset: 0xC5B4B0 VA: 0x180C5CAB0
	public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) { }

	// RVA: 0xC5CCB0 Offset: 0xC5B6B0 VA: 0x180C5CCB0
	public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity) { }

	// RVA: 0xC5CF80 Offset: 0xC5B980 VA: 0x180C5CF80
	public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	// RVA: 0xC5C9C0 Offset: 0xC5B3C0 VA: 0x180C5C9C0
	public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	// RVA: 0xC5C940 Offset: 0xC5B340 VA: 0x180C5C940
	public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope) { }

	// RVA: 0xC5CE00 Offset: 0xC5B800 VA: 0x180C5CE00
	public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars) { }

	// RVA: 0xC5D1E0 Offset: 0xC5BBE0 VA: 0x180C5D1E0
	public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0xC5D0C0 Offset: 0xC5BAC0 VA: 0x180C5D0C0
	public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) { }

	// RVA: 0xC5D070 Offset: 0xC5BA70 VA: 0x180C5D070
	public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) { }

	// RVA: 0xC5D400 Offset: 0xC5BE00 VA: 0x180C5D400
	public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) { }

	// RVA: 0xC5D2E0 Offset: 0xC5BCE0 VA: 0x180C5D2E0
	public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) { }
}
