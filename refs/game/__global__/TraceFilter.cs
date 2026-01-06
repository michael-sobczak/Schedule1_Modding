public abstract class TraceFilter // TypeDefIndex: 9582
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

	// RVA: 0x263DB20 Offset: 0x263C520 VA: 0x18263DB20
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }
}
