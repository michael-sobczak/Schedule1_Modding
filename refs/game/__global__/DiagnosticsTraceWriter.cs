public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 11227
{
	// Fields
	[CompilerGenerated]
	private TraceLevel <LevelFilter>k__BackingField; // 0x10

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x1D7F370 Offset: 0x1D7DD70 VA: 0x181D7F370
	private TraceEventType GetTraceEventType(TraceLevel level) { }

	[NullableContext(1)]
	// RVA: 0x1D7F410 Offset: 0x1D7DE10 VA: 0x181D7F410 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
