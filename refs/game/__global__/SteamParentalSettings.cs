public static class SteamParentalSettings // TypeDefIndex: 14348
{
	// Methods

	// RVA: 0xC724C0 Offset: 0xC70EC0 VA: 0x180C724C0
	public static bool BIsParentalLockEnabled() { }

	// RVA: 0xC72510 Offset: 0xC70F10 VA: 0x180C72510
	public static bool BIsParentalLockLocked() { }

	// RVA: 0xC72380 Offset: 0xC70D80 VA: 0x180C72380
	public static bool BIsAppBlocked(AppId_t nAppID) { }

	// RVA: 0xC723D0 Offset: 0xC70DD0 VA: 0x180C723D0
	public static bool BIsAppInBlockList(AppId_t nAppID) { }

	// RVA: 0xC72420 Offset: 0xC70E20 VA: 0x180C72420
	public static bool BIsFeatureBlocked(EParentalFeature eFeature) { }

	// RVA: 0xC72470 Offset: 0xC70E70 VA: 0x180C72470
	public static bool BIsFeatureInBlockList(EParentalFeature eFeature) { }
}
