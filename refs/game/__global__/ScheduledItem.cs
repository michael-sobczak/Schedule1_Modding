internal abstract class ScheduledItem // TypeDefIndex: 6763
{
	// Fields
	public Func<bool> timerUpdateStopCondition; // 0x10
	public static readonly Func<bool> OnceCondition; // 0x0
	public static readonly Func<bool> ForeverCondition; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <startMs>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private long <delayMs>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <intervalMs>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <endTimeMs>k__BackingField; // 0x30

	// Properties
	public long startMs { get; set; }
	public long delayMs { get; set; }
	public long intervalMs { get; set; }
	public long endTimeMs { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public long get_startMs() { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_startMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public long get_delayMs() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	public void set_delayMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public long get_intervalMs() { }

	[CompilerGenerated]
	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	public void set_intervalMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public long get_endTimeMs() { }

	// RVA: 0x2EE1570 Offset: 0x2EDFF70 VA: 0x182EE1570
	public void .ctor() { }

	// RVA: 0x2EE13B0 Offset: 0x2EDFDB0 VA: 0x182EE13B0
	protected void ResetStartTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PerformTimerUpdate(TimerState state);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	internal virtual void OnItemUnscheduled() { }

	// RVA: 0x2EE1400 Offset: 0x2EDFE00 VA: 0x182EE1400 Slot: 6
	public virtual bool ShouldUnschedule() { }

	// RVA: 0x2EE1430 Offset: 0x2EDFE30 VA: 0x182EE1430
	private static void .cctor() { }
}
