internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 3614
{
	// Fields
	private long m_ticksOffset; // 0x10
	private string m_standardName; // 0x18
	private string m_daylightName; // 0x20
	private readonly Hashtable m_CachedDaylightChanges; // 0x28

	// Methods

	// RVA: 0x1C436A0 Offset: 0x1C420A0 VA: 0x181C436A0
	internal void .ctor() { }

	// RVA: 0x1C43430 Offset: 0x1C41E30 VA: 0x181C43430 Slot: 5
	public override DaylightTime GetDaylightChanges(int year) { }

	// RVA: 0x1C42E90 Offset: 0x1C41890 VA: 0x181C42E90
	private static DaylightTime CreateDaylightChanges(int year) { }

	// RVA: 0x1C43520 Offset: 0x1C41F20 VA: 0x181C43520 Slot: 4
	public override TimeSpan GetUtcOffset(DateTime time) { }

	// RVA: 0x1C43220 Offset: 0x1C41C20 VA: 0x181C43220
	private DaylightTime GetCachedDaylightChanges(int year) { }
}
