public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 11963
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[SerializeField]
	[FormerlySerializedAs("m_PersistentListeners")]
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x2CED6B0 Offset: 0x2CEC0B0 VA: 0x182CED6B0
	protected void .ctor() { }

	// RVA: 0x2CED6A0 Offset: 0x2CEC0A0 VA: 0x182CED6A0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2CED6A0 Offset: 0x2CEC0A0 VA: 0x182CED6A0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2CEC750 Offset: 0x2CEB150 VA: 0x182CEC750
	protected MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x2CEC7A0 Offset: 0x2CEB1A0 VA: 0x182CEC7A0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x2CEC980 Offset: 0x2CEB380 VA: 0x182CEC980
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x2CECD40 Offset: 0x2CEB740 VA: 0x182CECD40
	internal int GetCallsCount() { }

	// RVA: 0x2CECD90 Offset: 0x2CEB790 VA: 0x182CECD90
	public int GetPersistentEventCount() { }

	// RVA: 0x2CECFF0 Offset: 0x2CEB9F0 VA: 0x182CECFF0
	public Object GetPersistentTarget(int index) { }

	// RVA: 0x2CECF50 Offset: 0x2CEB950 VA: 0x182CECF50
	public string GetPersistentMethodName(int index) { }

	// RVA: 0x2CEC670 Offset: 0x2CEB070 VA: 0x182CEC670
	private void DirtyPersistentCalls() { }

	// RVA: 0x2CED450 Offset: 0x2CEBE50 VA: 0x182CED450
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x2CED580 Offset: 0x2CEBF80 VA: 0x182CED580
	public void SetPersistentListenerState(int index, UnityEventCallState state) { }

	// RVA: 0x2CECDE0 Offset: 0x2CEB7E0 VA: 0x182CECDE0
	public UnityEventCallState GetPersistentListenerState(int index) { }

	// RVA: 0x2CEC630 Offset: 0x2CEB030 VA: 0x182CEC630
	protected void AddListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2CEC610 Offset: 0x2CEB010 VA: 0x182CEC610
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x2CED560 Offset: 0x2CEBF60 VA: 0x182CED560
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2CED490 Offset: 0x2CEBE90 VA: 0x182CED490
	public void RemoveAllListeners() { }

	// RVA: 0x2CED370 Offset: 0x2CEBD70 VA: 0x182CED370
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2CED2C0 Offset: 0x2CEBCC0 VA: 0x182CED2C0
	protected void Invoke(object[] parameters) { }

	// RVA: 0x2CED610 Offset: 0x2CEC010 VA: 0x182CED610 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CED060 Offset: 0x2CEBA60 VA: 0x182CED060
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }

	// RVA: 0x2CED0A0 Offset: 0x2CEBAA0 VA: 0x182CED0A0
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}
