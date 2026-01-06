public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 11269
{
	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	private readonly object _lock; // 0x18
	[CompilerGenerated]
	private TraceLevel <LevelFilter>k__BackingField; // 0x20

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x1DAE560 Offset: 0x1DACF60 VA: 0x181DAE560
	public void .ctor() { }

	// RVA: 0x1DAE2D0 Offset: 0x1DACCD0 VA: 0x181DAE2D0 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IEnumerable<string> GetTraceMessages() { }

	// RVA: 0x1DAE060 Offset: 0x1DACA60 VA: 0x181DAE060 Slot: 3
	public override string ToString() { }
}
