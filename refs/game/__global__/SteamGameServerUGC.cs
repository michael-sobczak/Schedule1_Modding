public static class SteamGameServerUGC // TypeDefIndex: 14332
{
	// Methods

	// RVA: 0xC5F960 Offset: 0xC5E360 VA: 0x180C5F960
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0xC5F660 Offset: 0xC5E060 VA: 0x180C5F660
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0xC5F730 Offset: 0xC5E130 VA: 0x180C5F730
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor) { }

	// RVA: 0xC5F8C0 Offset: 0xC5E2C0 VA: 0x180C5F8C0
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC61450 Offset: 0xC5FE50 VA: 0x180C61450
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xC60880 Offset: 0xC5F280 VA: 0x180C60880
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	// RVA: 0xC60710 Offset: 0xC5F110 VA: 0x180C60710
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC60AC0 Offset: 0xC5F4C0 VA: 0x180C60AC0
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC60990 Offset: 0xC5F390 VA: 0x180C60990
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC60770 Offset: 0xC5F170 VA: 0x180C60770
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	// RVA: 0xC60540 Offset: 0xC5EF40 VA: 0x180C60540
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xC60080 Offset: 0xC5EA80 VA: 0x180C60080
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xC60900 Offset: 0xC5F300 VA: 0x180C60900
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	// RVA: 0xC60650 Offset: 0xC5F050 VA: 0x180C60650
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC5FEE0 Offset: 0xC5E8E0 VA: 0x180C5FEE0
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	// RVA: 0xC606B0 Offset: 0xC5F0B0 VA: 0x180C606B0
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC603B0 Offset: 0xC5EDB0 VA: 0x180C603B0
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC601F0 Offset: 0xC5EBF0 VA: 0x180C601F0
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC5FE80 Offset: 0xC5E880 VA: 0x180C5FE80
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC60C50 Offset: 0xC5F650 VA: 0x180C60C50
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	// RVA: 0xC60110 Offset: 0xC5EB10 VA: 0x180C60110
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0xC60F50 Offset: 0xC5F950 VA: 0x180C60F50
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xC5F380 Offset: 0xC5DD80 VA: 0x180C5F380
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xC5F2C0 Offset: 0xC5DCC0 VA: 0x180C5F2C0
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) { }

	// RVA: 0xC5EB10 Offset: 0xC5D510 VA: 0x180C5EB10
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xC624B0 Offset: 0xC60EB0 VA: 0x180C624B0
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xC62390 Offset: 0xC60D90 VA: 0x180C62390
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xC623F0 Offset: 0xC60DF0 VA: 0x180C623F0
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xC62450 Offset: 0xC60E50 VA: 0x180C62450
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xC62330 Offset: 0xC60D30 VA: 0x180C62330
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xC622D0 Offset: 0xC60CD0 VA: 0x180C622D0
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xC62570 Offset: 0xC60F70 VA: 0x180C62570
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xC62510 Offset: 0xC60F10 VA: 0x180C62510
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xC61F20 Offset: 0xC60920 VA: 0x180C61F20
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	// RVA: 0xC61540 Offset: 0xC5FF40 VA: 0x180C61540
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xC614E0 Offset: 0xC5FEE0 VA: 0x180C614E0
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	// RVA: 0xC61600 Offset: 0xC60000 VA: 0x180C61600
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	// RVA: 0xC62040 Offset: 0xC60A40 VA: 0x180C62040
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xC625D0 Offset: 0xC60FD0 VA: 0x180C625D0
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xC620A0 Offset: 0xC60AA0 VA: 0x180C620A0
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xC626F0 Offset: 0xC610F0 VA: 0x180C626F0
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0xC62770 Offset: 0xC61170 VA: 0x180C62770
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0xC5F0F0 Offset: 0xC5DAF0 VA: 0x180C5F0F0
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xC613B0 Offset: 0xC5FDB0 VA: 0x180C613B0
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	// RVA: 0xC5F5C0 Offset: 0xC5DFC0 VA: 0x180C5F5C0
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	// RVA: 0xC628E0 Offset: 0xC612E0 VA: 0x180C628E0
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC61C80 Offset: 0xC60680 VA: 0x180C61C80
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xC61840 Offset: 0xC60240 VA: 0x180C61840
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xC61DA0 Offset: 0xC607A0 VA: 0x180C61DA0
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xC61960 Offset: 0xC60360 VA: 0x180C61960
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xC61EC0 Offset: 0xC608C0 VA: 0x180C61EC0
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xC61BA0 Offset: 0xC605A0 VA: 0x180C61BA0
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = False) { }

	// RVA: 0xC61720 Offset: 0xC60120 VA: 0x180C61720
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xC61A80 Offset: 0xC60480 VA: 0x180C61A80
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xC615A0 Offset: 0xC5FFA0 VA: 0x180C615A0
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	// RVA: 0xC60FA0 Offset: 0xC5F9A0 VA: 0x180C60FA0
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	// RVA: 0xC61230 Offset: 0xC5FC30 VA: 0x180C61230
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xC5EC30 Offset: 0xC5D630 VA: 0x180C5EC30
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xC5EE00 Offset: 0xC5D800 VA: 0x180C5EE00
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	// RVA: 0xC5EF30 Offset: 0xC5D930 VA: 0x180C5EF30
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	// RVA: 0xC62E10 Offset: 0xC61810 VA: 0x180C62E10
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	// RVA: 0xC62F40 Offset: 0xC61940 VA: 0x180C62F40
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

	// RVA: 0xC61350 Offset: 0xC5FD50 VA: 0x180C61350
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	// RVA: 0xC5EA10 Offset: 0xC5D410 VA: 0x180C5EA10
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0xC61090 Offset: 0xC5FA90 VA: 0x180C61090
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0xC62100 Offset: 0xC60B00 VA: 0x180C62100
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	// RVA: 0xC62B50 Offset: 0xC61550 VA: 0x180C62B50
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xC5FDB0 Offset: 0xC5E7B0 VA: 0x180C5FDB0
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	// RVA: 0xC627F0 Offset: 0xC611F0 VA: 0x180C627F0
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xC60E30 Offset: 0xC5F830 VA: 0x180C60E30
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC5F050 Offset: 0xC5DA50 VA: 0x180C5F050
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC61190 Offset: 0xC5FB90 VA: 0x180C61190
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC62CA0 Offset: 0xC616A0 VA: 0x180C62CA0
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC62D80 Offset: 0xC61780 VA: 0x180C62D80
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC5FE30 Offset: 0xC5E830 VA: 0x180C5FE30
	public static uint GetNumSubscribedItems() { }

	// RVA: 0xC60BF0 Offset: 0xC5F5F0 VA: 0x180C60BF0
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xC5FD60 Offset: 0xC5E760 VA: 0x180C5FD60
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC5FC40 Offset: 0xC5E640 VA: 0x180C5FC40
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	// RVA: 0xC5FBC0 Offset: 0xC5E5C0 VA: 0x180C5FBC0
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0xC5FAD0 Offset: 0xC5E4D0 VA: 0x180C5FAD0
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xC5F4A0 Offset: 0xC5DEA0 VA: 0x180C5F4A0
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	// RVA: 0xC62D30 Offset: 0xC61730 VA: 0x180C62D30
	public static void SuspendDownloads(bool bSuspend) { }

	// RVA: 0xC62980 Offset: 0xC61380 VA: 0x180C62980
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC62AB0 Offset: 0xC614B0 VA: 0x180C62AB0
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC62A20 Offset: 0xC61420 VA: 0x180C62A20
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	// RVA: 0xC5EA70 Offset: 0xC5D470 VA: 0x180C5EA70
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0xC610F0 Offset: 0xC5FAF0 VA: 0x180C610F0
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0xC5E970 Offset: 0xC5D370 VA: 0x180C5E970
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0xC60FF0 Offset: 0xC5F9F0 VA: 0x180C60FF0
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0xC5FB30 Offset: 0xC5E530 VA: 0x180C5FB30
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC5FA40 Offset: 0xC5E440 VA: 0x180C5FA40
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC62890 Offset: 0xC61290 VA: 0x180C62890
	public static bool ShowWorkshopEULA() { }

	// RVA: 0xC60EC0 Offset: 0xC5F8C0 VA: 0x180C60EC0
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	// RVA: 0xC60DD0 Offset: 0xC5F7D0 VA: 0x180C60DD0
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }
}
