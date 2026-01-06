public static class SteamUGC // TypeDefIndex: 14353
{
	// Methods

	// RVA: 0xC77F70 Offset: 0xC76970 VA: 0x180C77F70
	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0xC77C70 Offset: 0xC76670 VA: 0x180C77C70
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	// RVA: 0xC77D40 Offset: 0xC76740 VA: 0x180C77D40
	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor) { }

	// RVA: 0xC77ED0 Offset: 0xC768D0 VA: 0x180C77ED0
	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC79A60 Offset: 0xC78460 VA: 0x180C79A60
	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xC78E90 Offset: 0xC77890 VA: 0x180C78E90
	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	// RVA: 0xC78D20 Offset: 0xC77720 VA: 0x180C78D20
	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC790D0 Offset: 0xC77AD0 VA: 0x180C790D0
	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC78FA0 Offset: 0xC779A0 VA: 0x180C78FA0
	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC78D80 Offset: 0xC77780 VA: 0x180C78D80
	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	// RVA: 0xC78B50 Offset: 0xC77550 VA: 0x180C78B50
	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xC78690 Offset: 0xC77090 VA: 0x180C78690
	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xC78F10 Offset: 0xC77910 VA: 0x180C78F10
	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	// RVA: 0xC78C60 Offset: 0xC77660 VA: 0x180C78C60
	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC784F0 Offset: 0xC76EF0 VA: 0x180C784F0
	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	// RVA: 0xC78CC0 Offset: 0xC776C0 VA: 0x180C78CC0
	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC78800 Offset: 0xC77200 VA: 0x180C78800
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC78990 Offset: 0xC77390 VA: 0x180C78990
	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	// RVA: 0xC78490 Offset: 0xC76E90 VA: 0x180C78490
	public static uint GetNumSupportedGameVersions(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xC79260 Offset: 0xC77C60 VA: 0x180C79260
	public static bool GetSupportedGameVersionData(UGCQueryHandle_t handle, uint index, uint versionIndex, out string pchGameBranchMin, out string pchGameBranchMax, uint cchGameBranchSize) { }

	// RVA: 0xC78720 Offset: 0xC77120 VA: 0x180C78720
	public static uint GetQueryUGCContentDescriptors(UGCQueryHandle_t handle, uint index, EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }

	// RVA: 0xC79560 Offset: 0xC77F60 VA: 0x180C79560
	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xC77990 Offset: 0xC76390 VA: 0x180C77990
	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xC778D0 Offset: 0xC762D0 VA: 0x180C778D0
	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups) { }

	// RVA: 0xC77120 Offset: 0xC75B20 VA: 0x180C77120
	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xC7AAC0 Offset: 0xC794C0 VA: 0x180C7AAC0
	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xC7A9A0 Offset: 0xC793A0 VA: 0x180C7A9A0
	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xC7AA00 Offset: 0xC79400 VA: 0x180C7AA00
	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xC7AA60 Offset: 0xC79460 VA: 0x180C7AA60
	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xC7A940 Offset: 0xC79340 VA: 0x180C7A940
	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xC7A8E0 Offset: 0xC792E0 VA: 0x180C7A8E0
	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xC7AB80 Offset: 0xC79580 VA: 0x180C7AB80
	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xC7AB20 Offset: 0xC79520 VA: 0x180C7AB20
	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xC7A530 Offset: 0xC78F30 VA: 0x180C7A530
	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	// RVA: 0xC79B50 Offset: 0xC78550 VA: 0x180C79B50
	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xC79AF0 Offset: 0xC784F0 VA: 0x180C79AF0
	public static bool SetAdminQuery(UGCUpdateHandle_t handle, bool bAdminQuery) { }

	// RVA: 0xC79C10 Offset: 0xC78610 VA: 0x180C79C10
	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	// RVA: 0xC7A650 Offset: 0xC79050 VA: 0x180C7A650
	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xC7ABE0 Offset: 0xC795E0 VA: 0x180C7ABE0
	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xC7A6B0 Offset: 0xC790B0 VA: 0x180C7A6B0
	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xC7AD00 Offset: 0xC79700 VA: 0x180C7AD00
	public static bool SetTimeCreatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0xC7AD80 Offset: 0xC79780 VA: 0x180C7AD80
	public static bool SetTimeUpdatedDateRange(UGCQueryHandle_t handle, uint rtStart, uint rtEnd) { }

	// RVA: 0xC77700 Offset: 0xC76100 VA: 0x180C77700
	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xC799C0 Offset: 0xC783C0 VA: 0x180C799C0
	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	// RVA: 0xC77BD0 Offset: 0xC765D0 VA: 0x180C77BD0
	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	// RVA: 0xC7AEF0 Offset: 0xC798F0 VA: 0x180C7AEF0
	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC7A290 Offset: 0xC78C90 VA: 0x180C7A290
	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xC79E50 Offset: 0xC78850 VA: 0x180C79E50
	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xC7A3B0 Offset: 0xC78DB0 VA: 0x180C7A3B0
	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xC79F70 Offset: 0xC78970 VA: 0x180C79F70
	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xC7A4D0 Offset: 0xC78ED0 VA: 0x180C7A4D0
	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xC7A1B0 Offset: 0xC78BB0 VA: 0x180C7A1B0
	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags, bool bAllowAdminTags = False) { }

	// RVA: 0xC79D30 Offset: 0xC78730 VA: 0x180C79D30
	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xC7A090 Offset: 0xC78A90 VA: 0x180C7A090
	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xC79BB0 Offset: 0xC785B0 VA: 0x180C79BB0
	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	// RVA: 0xC795B0 Offset: 0xC77FB0 VA: 0x180C795B0
	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	// RVA: 0xC79840 Offset: 0xC78240 VA: 0x180C79840
	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xC77240 Offset: 0xC75C40 VA: 0x180C77240
	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xC77410 Offset: 0xC75E10 VA: 0x180C77410
	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	// RVA: 0xC77540 Offset: 0xC75F40 VA: 0x180C77540
	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	// RVA: 0xC7B420 Offset: 0xC79E20 VA: 0x180C7B420
	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	// RVA: 0xC7B550 Offset: 0xC79F50 VA: 0x180C7B550
	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

	// RVA: 0xC79960 Offset: 0xC78360 VA: 0x180C79960
	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	// RVA: 0xC77020 Offset: 0xC75A20 VA: 0x180C77020
	public static bool AddContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0xC796A0 Offset: 0xC780A0 VA: 0x180C796A0
	public static bool RemoveContentDescriptor(UGCUpdateHandle_t handle, EUGCContentDescriptorID descid) { }

	// RVA: 0xC7A710 Offset: 0xC79110 VA: 0x180C7A710
	public static bool SetRequiredGameVersions(UGCUpdateHandle_t handle, string pszGameBranchMin, string pszGameBranchMax) { }

	// RVA: 0xC7B160 Offset: 0xC79B60 VA: 0x180C7B160
	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xC783C0 Offset: 0xC76DC0 VA: 0x180C783C0
	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	// RVA: 0xC7AE00 Offset: 0xC79800 VA: 0x180C7AE00
	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xC79440 Offset: 0xC77E40 VA: 0x180C79440
	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC77660 Offset: 0xC76060 VA: 0x180C77660
	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC797A0 Offset: 0xC781A0 VA: 0x180C797A0
	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC7B2B0 Offset: 0xC79CB0 VA: 0x180C7B2B0
	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC7B390 Offset: 0xC79D90 VA: 0x180C7B390
	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC78440 Offset: 0xC76E40 VA: 0x180C78440
	public static uint GetNumSubscribedItems() { }

	// RVA: 0xC79200 Offset: 0xC77C00 VA: 0x180C79200
	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xC78370 Offset: 0xC76D70 VA: 0x180C78370
	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC78250 Offset: 0xC76C50 VA: 0x180C78250
	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	// RVA: 0xC781D0 Offset: 0xC76BD0 VA: 0x180C781D0
	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	// RVA: 0xC780E0 Offset: 0xC76AE0 VA: 0x180C780E0
	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xC77AB0 Offset: 0xC764B0 VA: 0x180C77AB0
	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	// RVA: 0xC7B340 Offset: 0xC79D40 VA: 0x180C7B340
	public static void SuspendDownloads(bool bSuspend) { }

	// RVA: 0xC7AF90 Offset: 0xC79990 VA: 0x180C7AF90
	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC7B0C0 Offset: 0xC79AC0 VA: 0x180C7B0C0
	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xC7B030 Offset: 0xC79A30 VA: 0x180C7B030
	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	// RVA: 0xC77080 Offset: 0xC75A80 VA: 0x180C77080
	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0xC79700 Offset: 0xC78100 VA: 0x180C79700
	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	// RVA: 0xC76F80 Offset: 0xC75980 VA: 0x180C76F80
	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0xC79600 Offset: 0xC78000 VA: 0x180C79600
	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	// RVA: 0xC78140 Offset: 0xC76B40 VA: 0x180C78140
	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC78050 Offset: 0xC76A50 VA: 0x180C78050
	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	// RVA: 0xC7AEA0 Offset: 0xC798A0 VA: 0x180C7AEA0
	public static bool ShowWorkshopEULA() { }

	// RVA: 0xC794D0 Offset: 0xC77ED0 VA: 0x180C794D0
	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	// RVA: 0xC793E0 Offset: 0xC77DE0 VA: 0x180C793E0
	public static uint GetUserContentDescriptorPreferences(EUGCContentDescriptorID[] pvecDescriptors, uint cMaxEntries) { }
}
