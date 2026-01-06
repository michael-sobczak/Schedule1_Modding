internal struct StartDragArgs // TypeDefIndex: 6475
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <title>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly DragVisualMode <visualMode>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Hashtable <genericData>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IEnumerable<Object> <unityObjectReferences>k__BackingField; // 0x18

	// Properties
	public string title { get; }
	public DragVisualMode visualMode { get; }
	internal Hashtable genericData { get; set; }
	internal IEnumerable<Object> unityObjectReferences { get; set; }

	// Methods

	// RVA: 0x2E9B470 Offset: 0x2E99E70 VA: 0x182E9B470
	public void .ctor(string title, DragVisualMode visualMode) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_title() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public DragVisualMode get_visualMode() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Hashtable get_genericData() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_genericData(Hashtable value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IEnumerable<Object> get_unityObjectReferences() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_unityObjectReferences(IEnumerable<Object> value) { }

	// RVA: 0x2E9B3C0 Offset: 0x2E99DC0 VA: 0x182E9B3C0
	public void SetGenericData(string key, object data) { }
}
