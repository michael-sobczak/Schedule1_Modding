public class EventSource : IDisposable // TypeDefIndex: 4881
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	private string Name { set; }

	// Methods

	// RVA: 0x1BF8880 Offset: 0x1BF7280 VA: 0x181BF8880
	protected void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(string eventSourceName) { }

	// RVA: 0x1BF8840 Offset: 0x1BF7240 VA: 0x181BF8840
	internal void .ctor(Guid eventSourceGuid, string eventSourceName) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Name(string value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool IsEnabled() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0x1BF8090 Offset: 0x1BF6A90 VA: 0x181BF8090 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1BF8450 Offset: 0x1BF6E50 VA: 0x181BF8450
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0x1BF8100 Offset: 0x1BF6B00 VA: 0x181BF8100
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0x1BF8710 Offset: 0x1BF7110 VA: 0x181BF8710
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	// RVA: 0x1BF81A0 Offset: 0x1BF6BA0 VA: 0x181BF81A0
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0x1BF8650 Offset: 0x1BF7050 VA: 0x181BF8650
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0x1BF8340 Offset: 0x1BF6D40 VA: 0x181BF8340
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0x1BF8510 Offset: 0x1BF6F10 VA: 0x181BF8510
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CLSCompliant(False)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }
}
