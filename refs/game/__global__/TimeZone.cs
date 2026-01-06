public abstract class TimeZone // TypeDefIndex: 3736
{
	// Fields
	private static TimeZone currentTimeZone; // 0x0
	private static object s_InternalSyncObject; // 0x8

	// Properties
	private static object InternalSyncObject { get; }
	public static TimeZone CurrentTimeZone { get; }

	// Methods

	// RVA: 0x1C8C0A0 Offset: 0x1C8AAA0 VA: 0x181C8C0A0
	private static object get_InternalSyncObject() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1C8BED0 Offset: 0x1C8A8D0 VA: 0x181C8BED0
	public static TimeZone get_CurrentTimeZone() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeSpan GetUtcOffset(DateTime time);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DaylightTime GetDaylightChanges(int year);

	// RVA: 0x1C8BC00 Offset: 0x1C8A600 VA: 0x181C8BC00
	internal static TimeSpan CalculateUtcOffset(DateTime time, DaylightTime daylightTimes) { }
}
