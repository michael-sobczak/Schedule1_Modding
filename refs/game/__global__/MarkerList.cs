internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 17416
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private List<ScriptableObject> m_Objects; // 0x0
	[HideInInspector]
	private List<IMarker> m_Cache; // 0x8
	private bool m_CacheDirty; // 0x10
	private bool m_HasNotifications; // 0x11

	// Properties
	public List<IMarker> markers { get; }
	public int Count { get; }
	public IMarker Item { get; }

	// Methods

	// RVA: 0x2C48960 Offset: 0x2C47360 VA: 0x182C48960
	public List<IMarker> get_markers() { }

	// RVA: 0x2C48BC0 Offset: 0x2C475C0 VA: 0x182C48BC0
	public void .ctor(int capacity) { }

	// RVA: 0x2C48290 Offset: 0x2C46C90 VA: 0x182C48290
	public void Add(ScriptableObject item) { }

	// RVA: 0x2C489A0 Offset: 0x2C473A0 VA: 0x182C489A0
	public bool Remove(IMarker item) { }

	// RVA: 0x2C48B10 Offset: 0x2C47510 VA: 0x182C48B10
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	// RVA: 0x2C48570 Offset: 0x2C46F70 VA: 0x182C48570
	public void Clear() { }

	// RVA: 0x2C485D0 Offset: 0x2C46FD0 VA: 0x182C485D0
	public bool Contains(ScriptableObject item) { }

	// RVA: 0x2C48960 Offset: 0x2C47360 VA: 0x182C48960
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x2C48C90 Offset: 0x2C47690 VA: 0x182C48C90
	public int get_Count() { }

	// RVA: 0x2C48CE0 Offset: 0x2C476E0 VA: 0x182C48CE0
	public IMarker get_Item(int idx) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public List<ScriptableObject> GetRawMarkerList() { }

	// RVA: 0x2C48630 Offset: 0x2C47030 VA: 0x182C48630
	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	// RVA: 0x2C48980 Offset: 0x2C47380 VA: 0x182C48980
	public bool HasNotifications() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x50C890 Offset: 0x50B290 VA: 0x18050C890 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2C48320 Offset: 0x2C46D20 VA: 0x182C48320
	private void BuildCache() { }
}
