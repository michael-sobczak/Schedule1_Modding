internal class PersistentCallGroup // TypeDefIndex: 11961
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_Listeners")]
	private List<PersistentCall> m_Calls; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x2CE2980 Offset: 0x2CE1380 VA: 0x182CE2980
	public void .ctor() { }

	// RVA: 0x2CE2A00 Offset: 0x2CE1400 VA: 0x182CE2A00
	public int get_Count() { }

	// RVA: 0x2CE1D40 Offset: 0x2CE0740 VA: 0x182CE1D40
	public PersistentCall GetListener(int index) { }

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public IEnumerable<PersistentCall> GetListeners() { }

	// RVA: 0x2CE1B00 Offset: 0x2CE0500 VA: 0x182CE1B00
	public void AddListener() { }

	// RVA: 0x2CE1C30 Offset: 0x2CE0630 VA: 0x182CE1C30
	public void AddListener(PersistentCall call) { }

	// RVA: 0x2CE2650 Offset: 0x2CE1050 VA: 0x182CE2650
	public void RemoveListener(int index) { }

	// RVA: 0x2CE1CE0 Offset: 0x2CE06E0 VA: 0x182CE1CE0
	public void Clear() { }

	// RVA: 0x2CE2010 Offset: 0x2CE0A10 VA: 0x182CE2010
	public void RegisterEventPersistentListener(int index, Object targetObj, Type targetObjType, string methodName) { }

	// RVA: 0x2CE2570 Offset: 0x2CE0F70 VA: 0x182CE2570
	public void RegisterVoidPersistentListener(int index, Object targetObj, Type targetObjType, string methodName) { }

	// RVA: 0x2CE22D0 Offset: 0x2CE0CD0 VA: 0x182CE22D0
	public void RegisterObjectPersistentListener(int index, Object targetObj, Type targetObjType, Object argument, string methodName) { }

	// RVA: 0x2CE21E0 Offset: 0x2CE0BE0 VA: 0x182CE21E0
	public void RegisterIntPersistentListener(int index, Object targetObj, Type targetObjType, int argument, string methodName) { }

	// RVA: 0x2CE20F0 Offset: 0x2CE0AF0 VA: 0x182CE20F0
	public void RegisterFloatPersistentListener(int index, Object targetObj, Type targetObjType, float argument, string methodName) { }

	// RVA: 0x2CE2470 Offset: 0x2CE0E70 VA: 0x182CE2470
	public void RegisterStringPersistentListener(int index, Object targetObj, Type targetObjType, string argument, string methodName) { }

	// RVA: 0x2CE1F20 Offset: 0x2CE0920 VA: 0x182CE1F20
	public void RegisterBoolPersistentListener(int index, Object targetObj, Type targetObjType, bool argument, string methodName) { }

	// RVA: 0x2CE28B0 Offset: 0x2CE12B0 VA: 0x182CE28B0
	public void UnregisterPersistentListener(int index) { }

	// RVA: 0x2CE26B0 Offset: 0x2CE10B0 VA: 0x182CE26B0
	public void RemoveListeners(Object target, string methodName) { }

	// RVA: 0x2CE1DA0 Offset: 0x2CE07A0 VA: 0x182CE1DA0
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }
}
