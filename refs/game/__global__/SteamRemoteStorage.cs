public static class SteamRemoteStorage // TypeDefIndex: 14350
{
	// Methods

	// RVA: 0xC743F0 Offset: 0xC72DF0 VA: 0x180C743F0
	public static bool FileWrite(string pchFile, byte[] pvData, int cubData) { }

	// RVA: 0xC73DA0 Offset: 0xC727A0 VA: 0x180C73DA0
	public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead) { }

	// RVA: 0xC74020 Offset: 0xC72A20 VA: 0x180C74020
	public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData) { }

	// RVA: 0xC73C30 Offset: 0xC72630 VA: 0x180C73C30
	public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead) { }

	// RVA: 0xC73BB0 Offset: 0xC725B0 VA: 0x180C73BB0
	public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead) { }

	// RVA: 0xC73990 Offset: 0xC72390 VA: 0x180C73990
	public static bool FileForget(string pchFile) { }

	// RVA: 0xC73770 Offset: 0xC72170 VA: 0x180C73770
	public static bool FileDelete(string pchFile) { }

	// RVA: 0xC73EE0 Offset: 0xC728E0 VA: 0x180C73EE0
	public static SteamAPICall_t FileShare(string pchFile) { }

	// RVA: 0xC756F0 Offset: 0xC740F0 VA: 0x180C756F0
	public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	// RVA: 0xC74230 Offset: 0xC72C30 VA: 0x180C74230
	public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile) { }

	// RVA: 0xC74370 Offset: 0xC72D70 VA: 0x180C74370
	public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData) { }

	// RVA: 0xC741E0 Offset: 0xC72BE0 VA: 0x180C741E0
	public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0xC74190 Offset: 0xC72B90 VA: 0x180C74190
	public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle) { }

	// RVA: 0xC73880 Offset: 0xC72280 VA: 0x180C73880
	public static bool FileExists(string pchFile) { }

	// RVA: 0xC73AA0 Offset: 0xC724A0 VA: 0x180C73AA0
	public static bool FilePersisted(string pchFile) { }

	// RVA: 0xC746C0 Offset: 0xC730C0 VA: 0x180C746C0
	public static int GetFileSize(string pchFile) { }

	// RVA: 0xC747D0 Offset: 0xC731D0 VA: 0x180C747D0
	public static long GetFileTimestamp(string pchFile) { }

	// RVA: 0xC74B50 Offset: 0xC73550 VA: 0x180C74B50
	public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile) { }

	// RVA: 0xC74600 Offset: 0xC73000 VA: 0x180C74600
	public static int GetFileCount() { }

	// RVA: 0xC74650 Offset: 0xC73050 VA: 0x180C74650
	public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes) { }

	// RVA: 0xC74AF0 Offset: 0xC734F0 VA: 0x180C74AF0
	public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	// RVA: 0xC74E30 Offset: 0xC73830 VA: 0x180C74E30
	public static bool IsCloudEnabledForAccount() { }

	// RVA: 0xC74E80 Offset: 0xC73880 VA: 0x180C74E80
	public static bool IsCloudEnabledForApp() { }

	// RVA: 0xC756A0 Offset: 0xC740A0 VA: 0x180C756A0
	public static void SetCloudEnabledForApp(bool bEnabled) { }

	// RVA: 0xC75AB0 Offset: 0xC744B0 VA: 0x180C75AB0
	public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority) { }

	// RVA: 0xC74D20 Offset: 0xC73720 VA: 0x180C74D20
	public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	// RVA: 0xC74C60 Offset: 0xC73660 VA: 0x180C74C60
	public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	// RVA: 0xC75B50 Offset: 0xC74550 VA: 0x180C75B50
	public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	// RVA: 0xC74520 Offset: 0xC72F20 VA: 0x180C74520
	public static int GetCachedUGCCount() { }

	// RVA: 0xC74570 Offset: 0xC72F70 VA: 0x180C74570
	public static UGCHandle_t GetCachedUGCHandle(int iCachedContent) { }

	// RVA: 0xC75300 Offset: 0xC73D00 VA: 0x180C75300
	public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType) { }

	// RVA: 0xC731C0 Offset: 0xC71BC0 VA: 0x180C731C0
	public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC75D90 Offset: 0xC74790 VA: 0x180C75D90
	public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile) { }

	// RVA: 0xC75EB0 Offset: 0xC748B0 VA: 0x180C75EB0
	public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile) { }

	// RVA: 0xC761B0 Offset: 0xC74BB0 VA: 0x180C761B0
	public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle) { }

	// RVA: 0xC75C70 Offset: 0xC74670 VA: 0x180C75C70
	public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription) { }

	// RVA: 0xC762D0 Offset: 0xC74CD0 VA: 0x180C762D0
	public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xC760F0 Offset: 0xC74AF0 VA: 0x180C760F0
	public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags) { }

	// RVA: 0xC73130 Offset: 0xC71B30 VA: 0x180C73130
	public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle) { }

	// RVA: 0xC749C0 Offset: 0xC733C0 VA: 0x180C749C0
	public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	// RVA: 0xC73250 Offset: 0xC71C50 VA: 0x180C73250
	public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC73520 Offset: 0xC71F20 VA: 0x180C73520
	public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex) { }

	// RVA: 0xC758B0 Offset: 0xC742B0 VA: 0x180C758B0
	public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC736E0 Offset: 0xC720E0 VA: 0x180C736E0
	public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex) { }

	// RVA: 0xC75BE0 Offset: 0xC745E0 VA: 0x180C75BE0
	public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC75FD0 Offset: 0xC749D0 VA: 0x180C75FD0
	public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription) { }

	// RVA: 0xC74A60 Offset: 0xC73460 VA: 0x180C74A60
	public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC76330 Offset: 0xC74D30 VA: 0x180C76330
	public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

	// RVA: 0xC74DA0 Offset: 0xC737A0 VA: 0x180C74DA0
	public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	// RVA: 0xC735B0 Offset: 0xC71FB0 VA: 0x180C735B0
	public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags) { }

	// RVA: 0xC74ED0 Offset: 0xC738D0 VA: 0x180C74ED0
	public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags) { }

	// RVA: 0xC75810 Offset: 0xC74210 VA: 0x180C75810
	public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	// RVA: 0xC73330 Offset: 0xC71D30 VA: 0x180C73330
	public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex) { }

	// RVA: 0xC733D0 Offset: 0xC71DD0 VA: 0x180C733D0
	public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags) { }

	// RVA: 0xC75940 Offset: 0xC74340 VA: 0x180C75940
	public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority) { }

	// RVA: 0xC748F0 Offset: 0xC732F0 VA: 0x180C748F0
	public static int GetLocalFileChangeCount() { }

	// RVA: 0xC74940 Offset: 0xC73340 VA: 0x180C74940
	public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	// RVA: 0xC730E0 Offset: 0xC71AE0 VA: 0x180C730E0
	public static bool BeginFileWriteBatch() { }

	// RVA: 0xC732E0 Offset: 0xC71CE0 VA: 0x180C732E0
	public static bool EndFileWriteBatch() { }
}
