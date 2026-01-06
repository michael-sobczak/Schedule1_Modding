public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 9585
{
	// Fields
	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private TraceOptions traceOptions; // 0x20
	private bool needIndent; // 0x24
	private string listenerName; // 0x28
	private TraceFilter filter; // 0x30

	// Properties
	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	[ComVisible(False)]
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisible(False)]
	public TraceOptions TraceOutputOptions { get; }

	// Methods

	// RVA: 0x263F6B0 Offset: 0x263E0B0 VA: 0x18263F6B0
	protected void .ctor(string name) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x263EB40 Offset: 0x263D540 VA: 0x18263EB40 Slot: 6
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x263F6F0 Offset: 0x263E0F0 VA: 0x18263F6F0
	public void set_IndentLevel(int value) { }

	// RVA: 0x263F710 Offset: 0x263E110 VA: 0x18263F710
	public void set_IndentSize(int value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public TraceFilter get_Filter() { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	protected bool get_NeedIndent() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x263F600 Offset: 0x263E000 VA: 0x18263F600 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisible(False)]
	// RVA: 0x263EBC0 Offset: 0x263D5C0 VA: 0x18263EBC0 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x263F4F0 Offset: 0x263DEF0 VA: 0x18263F4F0
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x263ED60 Offset: 0x263D760 VA: 0x18263ED60
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x263EBB0 Offset: 0x263D5B0 VA: 0x18263EBB0
	internal bool IsEnabled(TraceOptions opts) { }
}
