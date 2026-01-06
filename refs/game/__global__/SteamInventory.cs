public static class SteamInventory // TypeDefIndex: 14337
{
	// Methods

	// RVA: 0xC6A8E0 Offset: 0xC692E0 VA: 0x180C6A8E0
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC6A810 Offset: 0xC69210 VA: 0x180C6A810
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0xC6A640 Offset: 0xC69040 VA: 0x180C6A640
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0xC6A930 Offset: 0xC69330 VA: 0x180C6A930
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC69CA0 Offset: 0xC686A0 VA: 0x180C69CA0
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	// RVA: 0xC69E10 Offset: 0xC68810 VA: 0x180C69E10
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0xC69FA0 Offset: 0xC689A0 VA: 0x180C69FA0
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC6A3D0 Offset: 0xC68DD0 VA: 0x180C6A3D0
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	// RVA: 0xC6AE00 Offset: 0xC69800 VA: 0x180C6AE00
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize) { }

	// RVA: 0xC69D80 Offset: 0xC68780 VA: 0x180C69D80
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = False) { }

	// RVA: 0xC69F10 Offset: 0xC68910 VA: 0x180C69F10
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0xC6A980 Offset: 0xC69380 VA: 0x180C6A980
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC69BC0 Offset: 0xC685C0 VA: 0x180C69BC0
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	// RVA: 0xC69C20 Offset: 0xC68620 VA: 0x180C69C20
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	// RVA: 0xC69D00 Offset: 0xC68700 VA: 0x180C69D00
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	// RVA: 0xC69E60 Offset: 0xC68860 VA: 0x180C69E60
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0xC6B6A0 Offset: 0xC6A0A0 VA: 0x180C6B6A0
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	// RVA: 0xC6ADB0 Offset: 0xC697B0 VA: 0x180C6ADB0
	public static void SendItemDropHeartbeat() { }

	// RVA: 0xC6B730 Offset: 0xC6A130 VA: 0x180C6B730
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	// RVA: 0xC6B5E0 Offset: 0xC69FE0 VA: 0x180C6B5E0
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength) { }

	// RVA: 0xC6AB00 Offset: 0xC69500 VA: 0x180C6AB00
	public static bool LoadItemDefinitions() { }

	// RVA: 0xC6A0D0 Offset: 0xC68AD0 VA: 0x180C6A0D0
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0xC6A190 Offset: 0xC68B90 VA: 0x180C6A190
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0xC6AC90 Offset: 0xC69690 VA: 0x180C6AC90
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	// RVA: 0xC6A000 Offset: 0xC68A00 VA: 0x180C6A000
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0xC6B430 Offset: 0xC69E30 VA: 0x180C6B430
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0xC6AD20 Offset: 0xC69720 VA: 0x180C6AD20
	public static SteamAPICall_t RequestPrices() { }

	// RVA: 0xC6A5F0 Offset: 0xC68FF0 VA: 0x180C6A5F0
	public static uint GetNumItemsWithPrices() { }

	// RVA: 0xC6A450 Offset: 0xC68E50 VA: 0x180C6A450
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0xC6A350 Offset: 0xC68D50 VA: 0x180C6A350
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	// RVA: 0xC6B4F0 Offset: 0xC69EF0 VA: 0x180C6B4F0
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	// RVA: 0xC6AB50 Offset: 0xC69550 VA: 0x180C6AB50
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	// RVA: 0xC6B120 Offset: 0xC69B20 VA: 0x180C6B120
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	// RVA: 0xC6AE80 Offset: 0xC69880 VA: 0x180C6AE80
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	// RVA: 0xC6B2F0 Offset: 0xC69CF0 VA: 0x180C6B2F0
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	// RVA: 0xC6AFC0 Offset: 0xC699C0 VA: 0x180C6AFC0
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	// RVA: 0xC6B580 Offset: 0xC69F80 VA: 0x180C6B580
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	// RVA: 0xC6A9E0 Offset: 0xC693E0 VA: 0x180C6A9E0
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }
}
