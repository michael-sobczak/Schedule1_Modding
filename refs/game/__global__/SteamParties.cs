public static class SteamParties // TypeDefIndex: 14341
{
	// Methods

	// RVA: 0xC72C10 Offset: 0xC71610 VA: 0x180C72C10
	public static uint GetNumActiveBeacons() { }

	// RVA: 0xC72930 Offset: 0xC71330 VA: 0x180C72930
	public static PartyBeaconID_t GetBeaconByIndex(uint unIndex) { }

	// RVA: 0xC729C0 Offset: 0xC713C0 VA: 0x180C729C0
	public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata) { }

	// RVA: 0xC72CC0 Offset: 0xC716C0 VA: 0x180C72CC0
	public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID) { }

	// RVA: 0xC72C60 Offset: 0xC71660 VA: 0x180C72C60
	public static bool GetNumAvailableBeaconLocations(out uint puNumLocations) { }

	// RVA: 0xC728D0 Offset: 0xC712D0 VA: 0x180C728D0
	public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	// RVA: 0xC72660 Offset: 0xC71060 VA: 0x180C72660
	public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata) { }

	// RVA: 0xC72D50 Offset: 0xC71750 VA: 0x180C72D50
	public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0xC72560 Offset: 0xC70F60 VA: 0x180C72560
	public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	// RVA: 0xC725C0 Offset: 0xC70FC0 VA: 0x180C725C0
	public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	// RVA: 0xC72870 Offset: 0xC71270 VA: 0x180C72870
	public static bool DestroyBeacon(PartyBeaconID_t ulBeacon) { }

	// RVA: 0xC72AF0 Offset: 0xC714F0 VA: 0x180C72AF0
	public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut) { }
}
