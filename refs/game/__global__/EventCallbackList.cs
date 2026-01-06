internal class EventCallbackList // TypeDefIndex: 6533
{
	// Fields
	private List<EventCallbackFunctorBase> m_List; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Properties
	public int trickleDownCallbackCount { get; set; }
	public int bubbleUpCallbackCount { get; set; }
	public int Count { get; }
	public EventCallbackFunctorBase Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_trickleDownCallbackCount() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_trickleDownCallbackCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_bubbleUpCallbackCount() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0x2E8E0B0 Offset: 0x2E8CAB0 VA: 0x182E8E0B0
	public void .ctor() { }

	// RVA: 0x2E8E130 Offset: 0x2E8CB30 VA: 0x182E8E130
	public void .ctor(EventCallbackList source) { }

	// RVA: 0x2E8DD90 Offset: 0x2E8C790 VA: 0x182E8DD90
	public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x2E8DE90 Offset: 0x2E8C890 VA: 0x182E8DE90
	public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x2E8DF90 Offset: 0x2E8C990 VA: 0x182E8DF90
	public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x2E8DC50 Offset: 0x2E8C650 VA: 0x182E8DC50
	public void Add(EventCallbackFunctorBase item) { }

	// RVA: 0x2E8DB00 Offset: 0x2E8C500 VA: 0x182E8DB00
	public void AddRange(EventCallbackList list) { }

	// RVA: 0x2E8E1D0 Offset: 0x2E8CBD0 VA: 0x182E8E1D0
	public int get_Count() { }

	// RVA: 0x2E8E210 Offset: 0x2E8CC10 VA: 0x182E8E210
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0x2E8DD20 Offset: 0x2E8C720 VA: 0x182E8DD20
	public void Clear() { }
}
