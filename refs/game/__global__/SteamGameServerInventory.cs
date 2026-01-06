public static class SteamGameServerInventory // TypeDefIndex: 14326
{
	// Methods

	// RVA: 0xC59C80 Offset: 0xC58680 VA: 0x180C59C80
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC59BB0 Offset: 0xC585B0 VA: 0x180C59BB0
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0xC599F0 Offset: 0xC583F0 VA: 0x180C599F0
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0xC59CD0 Offset: 0xC586D0 VA: 0x180C59CD0
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC59060 Offset: 0xC57A60 VA: 0x180C59060
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	// RVA: 0xC591D0 Offset: 0xC57BD0 VA: 0x180C591D0
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC59360 Offset: 0xC57D60 VA: 0x180C59360
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC59780 Offset: 0xC58180 VA: 0x180C59780
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	// RVA: 0xC5A180 Offset: 0xC58B80 VA: 0x180C5A180
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) { }

	// RVA: 0xC59140 Offset: 0xC57B40 VA: 0x180C59140
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = False) { }

	// RVA: 0xC592D0 Offset: 0xC57CD0 VA: 0x180C592D0
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0xC59D20 Offset: 0xC58720 VA: 0x180C59D20
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC58F80 Offset: 0xC57980 VA: 0x180C58F80
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	// RVA: 0xC58FE0 Offset: 0xC579E0 VA: 0x180C58FE0
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	// RVA: 0xC590C0 Offset: 0xC57AC0 VA: 0x180C590C0
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	// RVA: 0xC59220 Offset: 0xC57C20 VA: 0x180C59220
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0xC5AA10 Offset: 0xC59410 VA: 0x180C5AA10
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	// RVA: 0xC5A130 Offset: 0xC58B30 VA: 0x180C5A130
	public static void SendItemDropHeartbeat() { }

	// RVA: 0xC5AAA0 Offset: 0xC594A0 VA: 0x180C5AAA0
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	// RVA: 0xC5A950 Offset: 0xC59350 VA: 0x180C5A950
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) { }

	// RVA: 0xC59E90 Offset: 0xC58890 VA: 0x180C59E90
	public static bool LoadItemDefinitions() { }

	// RVA: 0xC59480 Offset: 0xC57E80 VA: 0x180C59480
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0xC59540 Offset: 0xC57F40 VA: 0x180C59540
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0xC5A010 Offset: 0xC58A10 VA: 0x180C5A010
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	// RVA: 0xC593B0 Offset: 0xC57DB0 VA: 0x180C593B0
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0xC5A7A0 Offset: 0xC591A0 VA: 0x180C5A7A0
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0xC5A0A0 Offset: 0xC58AA0 VA: 0x180C5A0A0
	public static SteamAPICall_t RequestPrices() { }

	// RVA: 0xC599A0 Offset: 0xC583A0 VA: 0x180C599A0
	public static uint GetNumItemsWithPrices() { }

	// RVA: 0xC59800 Offset: 0xC58200 VA: 0x180C59800
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0xC59700 Offset: 0xC58100 VA: 0x180C59700
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	// RVA: 0xC5A860 Offset: 0xC59260 VA: 0x180C5A860
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	// RVA: 0xC59EE0 Offset: 0xC588E0 VA: 0x180C59EE0
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	// RVA: 0xC5A200 Offset: 0xC58C00 VA: 0x180C5A200
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	// RVA: 0xC5A660 Offset: 0xC59060 VA: 0x180C5A660
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	// RVA: 0xC5A3D0 Offset: 0xC58DD0 VA: 0x180C5A3D0
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	// RVA: 0xC5A510 Offset: 0xC58F10 VA: 0x180C5A510
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	// RVA: 0xC5A8F0 Offset: 0xC592F0 VA: 0x180C5A8F0
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC59D70 Offset: 0xC58770 VA: 0x180C59D70
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }
}
