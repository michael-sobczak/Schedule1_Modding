public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 3566
{
	// Fields
	private static Lazy<bool> lazyHaveRegistry; // 0x0
	private readonly string _id; // 0x10
	private readonly string _displayName; // 0x18
	private readonly string _standardDisplayName; // 0x20
	private readonly string _daylightDisplayName; // 0x28
	private readonly TimeSpan _baseUtcOffset; // 0x30
	private readonly bool _supportsDaylightSavingTime; // 0x38
	private readonly TimeZoneInfo.AdjustmentRule[] _adjustmentRules; // 0x40
	private static readonly TimeZoneInfo s_utcTimeZone; // 0x8
	private static TimeZoneInfo.CachedData s_cachedData; // 0x10
	private static readonly DateTime s_maxDateOnly; // 0x18
	private static readonly DateTime s_minDateOnly; // 0x20
	private static readonly TimeSpan MaxOffset; // 0x28
	private static readonly TimeSpan MinOffset; // 0x30

	// Properties
	private static bool HaveRegistry { get; }
	public string Id { get; }
	public string DisplayName { get; }
	public string StandardName { get; }
	public string DaylightName { get; }
	public TimeSpan BaseUtcOffset { get; }
	public bool SupportsDaylightSavingTime { get; }
	public static TimeZoneInfo Local { get; }
	public static TimeZoneInfo Utc { get; }

	// Methods

	// RVA: 0x1BCCE80 Offset: 0x1BCB880 VA: 0x181BCCE80
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x1BD1D10 Offset: 0x1BD0710 VA: 0x181BD1D10
	private static void PopulateAllSystemTimeZones(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BD1B60 Offset: 0x1BD0560 VA: 0x181BD1B60
	private static void PopulateAllSystemTimeZonesFromRegistry(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BD6AB0 Offset: 0x1BD54B0 VA: 0x181BD6AB0
	private void .ctor(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	// RVA: 0x1BCA740 Offset: 0x1BC9140 VA: 0x181BCA740
	private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone) { }

	// RVA: 0x1BCBD90 Offset: 0x1BCA790 VA: 0x181BCBD90
	private static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1BCC400 Offset: 0x1BCAE00 VA: 0x181BCC400
	private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	// RVA: 0x1BCF240 Offset: 0x1BCDC40 VA: 0x181BCF240
	private static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BCED70 Offset: 0x1BCD770 VA: 0x181BCED70
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	// RVA: 0x1BCC850 Offset: 0x1BCB250 VA: 0x181BCC850
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x1BCCF20 Offset: 0x1BCB920 VA: 0x181BCCF20
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1BD2FF0 Offset: 0x1BD19F0 VA: 0x181BD2FF0
	private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1BD3980 Offset: 0x1BD2380 VA: 0x181BD3980
	private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out TimeZoneInfo.AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	// RVA: 0x1BD50F0 Offset: 0x1BD3AF0 VA: 0x181BD50F0
	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi) { }

	// RVA: 0x1BD34B0 Offset: 0x1BD1EB0 VA: 0x181BD34B0
	private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo) { }

	// RVA: 0x1BD34F0 Offset: 0x1BD1EF0 VA: 0x181BD34F0
	private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	// RVA: 0x1BD4D20 Offset: 0x1BD3720 VA: 0x181BD4D20
	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	// RVA: 0x1BD4FA0 Offset: 0x1BD39A0 VA: 0x181BD4FA0
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	// RVA: 0x1BCF630 Offset: 0x1BCE030 VA: 0x181BCF630
	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	// RVA: 0x1BD5550 Offset: 0x1BD3F50 VA: 0x181BD5550
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	// RVA: 0x1BD5630 Offset: 0x1BD4030 VA: 0x181BD5630
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	// RVA: 0x1BD6EF0 Offset: 0x1BD58F0 VA: 0x181BD6EF0
	private static bool get_HaveRegistry() { }

	// RVA: 0x1BCC1A0 Offset: 0x1BCABA0 VA: 0x181BCC1A0
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x1BCD730 Offset: 0x1BCC130 VA: 0x181BCD730
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x1BCD5B0 Offset: 0x1BCBFB0 VA: 0x181BCD5B0
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x1BD0600 Offset: 0x1BCF000 VA: 0x181BD0600
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x1BCB7E0 Offset: 0x1BCA1E0 VA: 0x181BCB7E0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x1BD2150 Offset: 0x1BD0B50 VA: 0x181BD2150
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1BD43C0 Offset: 0x1BD2DC0 VA: 0x181BD43C0
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x1BCEE90 Offset: 0x1BCD890 VA: 0x181BCEE90
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x1BCC5C0 Offset: 0x1BCAFC0 VA: 0x181BCC5C0
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x1BCFB10 Offset: 0x1BCE510 VA: 0x181BCFB10
	private static void GetSystemTimeZonesWinRTFallback(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Id() { }

	// RVA: 0x1BD2100 Offset: 0x1BD0B00 VA: 0x181BD2100
	public string get_DisplayName() { }

	// RVA: 0x1BD6FF0 Offset: 0x1BD59F0 VA: 0x181BD6FF0
	public string get_StandardName() { }

	// RVA: 0x1BD6EA0 Offset: 0x1BD58A0 VA: 0x181BD6EA0
	public string get_DaylightName() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x1BCFA00 Offset: 0x1BCE400 VA: 0x181BCFA00
	private TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x1BD1340 Offset: 0x1BCFD40 VA: 0x181BD1340
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x1BCF570 Offset: 0x1BCDF70 VA: 0x181BCF570
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BD0BF0 Offset: 0x1BCF5F0 VA: 0x181BD0BF0
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BD0D50 Offset: 0x1BCF750 VA: 0x181BD0D50
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BD16E0 Offset: 0x1BD00E0 VA: 0x181BD16E0
	internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BD1770 Offset: 0x1BD0170 VA: 0x181BD1770
	private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BCADB0 Offset: 0x1BC97B0 VA: 0x181BCADB0
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BCAE50 Offset: 0x1BC9850 VA: 0x181BCAE50
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BCAC10 Offset: 0x1BC9610 VA: 0x181BCAC10
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BCAD20 Offset: 0x1BC9720 VA: 0x181BCAD20
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x1BCC300 Offset: 0x1BCAD00 VA: 0x181BCC300 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x1BCC360 Offset: 0x1BCAD60 VA: 0x181BCC360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BCD890 Offset: 0x1BCC290 VA: 0x181BCD890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BD0290 Offset: 0x1BCEC90 VA: 0x181BD0290
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1BD13C0 Offset: 0x1BCFDC0 VA: 0x181BD13C0
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1BD6F60 Offset: 0x1BD5960 VA: 0x181BD6F60
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x1BD2100 Offset: 0x1BD0B00 VA: 0x181BD2100 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BD7040 Offset: 0x1BD5A40 VA: 0x181BD7040
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x1BD6990 Offset: 0x1BD5390 VA: 0x181BD6990
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x1BCC100 Offset: 0x1BCAB00 VA: 0x181BCC100
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x1BD1DA0 Offset: 0x1BD07A0 VA: 0x181BD1DA0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1BD1F60 Offset: 0x1BD0960 VA: 0x181BD1F60 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BD6470 Offset: 0x1BD4E70 VA: 0x181BD6470
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BCCE60 Offset: 0x1BCB860 VA: 0x181BCCE60
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<int> ruleIndex) { }

	// RVA: 0x1BCCC40 Offset: 0x1BCB640 VA: 0x181BCCC40
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<int> ruleIndex) { }

	// RVA: 0x1BCAA10 Offset: 0x1BC9410 VA: 0x181BCAA10
	private int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	// RVA: 0x1BCB560 Offset: 0x1BC9F60 VA: 0x181BCB560
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1BCABF0 Offset: 0x1BC95F0 VA: 0x181BCABF0
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1BCB3A0 Offset: 0x1BC9DA0 VA: 0x181BCB3A0
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	// RVA: 0x1BCB580 Offset: 0x1BC9F80 VA: 0x181BCB580
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1BCD430 Offset: 0x1BCBE30 VA: 0x181BCD430
	private DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x1BCE570 Offset: 0x1BCCF70 VA: 0x181BCE570
	private static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BCD350 Offset: 0x1BCBD50 VA: 0x181BCD350
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x1BCD2C0 Offset: 0x1BCBCC0 VA: 0x181BCD2C0
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x1BCDCB0 Offset: 0x1BCC6B0 VA: 0x181BCDCB0
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	// RVA: 0x1BCA770 Offset: 0x1BC9170 VA: 0x181BCA770
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x1BCD940 Offset: 0x1BCC340 VA: 0x181BCD940
	private static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x1BCEA00 Offset: 0x1BCD400 VA: 0x181BCEA00
	private static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x1BD1130 Offset: 0x1BCFB30 VA: 0x181BD1130
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	// RVA: 0x1BD0810 Offset: 0x1BCF210 VA: 0x181BD0810
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	// RVA: 0x1BD0790 Offset: 0x1BCF190 VA: 0x181BD0790
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	// RVA: 0x1BD08C0 Offset: 0x1BCF2C0 VA: 0x181BD08C0
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1BD31E0 Offset: 0x1BD1BE0 VA: 0x181BD31E0
	internal static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime) { }

	// RVA: 0x1BD5AD0 Offset: 0x1BD44D0 VA: 0x181BD5AD0
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine = False) { }

	// RVA: 0x1BD51D0 Offset: 0x1BD3BD0 VA: 0x181BD51D0
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x1BD5DD0 Offset: 0x1BD47D0 VA: 0x181BD5DD0
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

	// RVA: 0x1BD5CE0 Offset: 0x1BD46E0 VA: 0x181BD5CE0
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x1BD0C80 Offset: 0x1BCF680 VA: 0x181BD0C80
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x1BD1A50 Offset: 0x1BD0450 VA: 0x181BD1A50
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x1BD61D0 Offset: 0x1BD4BD0 VA: 0x181BD61D0
	private static void .cctor() { }

	// RVA: 0x1BD6960 Offset: 0x1BD5360 VA: 0x181BD6960
	internal void .ctor() { }
}
