public enum EMarketNotAllowedReasonFlags // TypeDefIndex: 14663
{
	// Fields
	public int value__; // 0x0
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_None = 0;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_TemporaryFailure = 1;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountDisabled = 2;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountLockedDown = 4;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountLimited = 8;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_TradeBanned = 16;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AccountNotTrusted = 32;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_RecentPasswordReset = 256;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NewPaymentMethod = 512;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_InvalidCookie = 1024;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_UsingNewDevice = 2048;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_RecentSelfRefund = 4096;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_NoRecentPurchases = 16384;
	public const EMarketNotAllowedReasonFlags k_EMarketNotAllowedReason_AcceptedWalletGift = 32768;
}
