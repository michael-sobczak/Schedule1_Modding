public enum EItemState // TypeDefIndex: 14633
{
	// Fields
	public int value__; // 0x0
	public const EItemState k_EItemStateNone = 0;
	public const EItemState k_EItemStateSubscribed = 1;
	public const EItemState k_EItemStateLegacyItem = 2;
	public const EItemState k_EItemStateInstalled = 4;
	public const EItemState k_EItemStateNeedsUpdate = 8;
	public const EItemState k_EItemStateDownloading = 16;
	public const EItemState k_EItemStateDownloadPending = 32;
	public const EItemState k_EItemStateDisabledLocally = 64;
}
