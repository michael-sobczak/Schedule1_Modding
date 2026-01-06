internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 11960
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("instance")]
	private Object m_Target; // 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; // 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; // 0x20
	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode; // 0x28
	[SerializeField]
	[FormerlySerializedAs("arguments")]
	private ArgumentCache m_Arguments; // 0x30
	[FormerlySerializedAs("enabled")]
	[FormerlySerializedAs("m_Enabled")]
	[SerializeField]
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; set; }
	public ArgumentCache arguments { get; }
	public UnityEventCallState callState { get; set; }

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public Object get_target() { }

	// RVA: 0x2CE3440 Offset: 0x2CE1E40 VA: 0x182CE3440
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public string get_methodName() { }

	// RVA: 0x1263FC0 Offset: 0x12629C0 VA: 0x181263FC0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_mode(PersistentListenerMode value) { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	public ArgumentCache get_arguments() { }

	// RVA: 0x2CE3430 Offset: 0x2CE1E30 VA: 0x182CE3430
	public UnityEventCallState get_callState() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_callState(UnityEventCallState value) { }

	// RVA: 0x2CE3270 Offset: 0x2CE1C70 VA: 0x182CE3270
	public bool IsValid() { }

	// RVA: 0x2CE2F60 Offset: 0x2CE1960 VA: 0x182CE2F60
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x2CE2A40 Offset: 0x2CE1440 VA: 0x182CE2A40
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x2CE32B0 Offset: 0x2CE1CB0 VA: 0x182CE32B0
	public void RegisterPersistentListener(Object ttarget, Type targetType, string mmethodName) { }

	// RVA: 0x2CE3330 Offset: 0x2CE1D30 VA: 0x182CE3330
	public void UnregisterPersistentListener() { }

	// RVA: 0x2CD40C0 Offset: 0x2CD2AC0 VA: 0x182CD40C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2CD40C0 Offset: 0x2CD2AC0 VA: 0x182CD40C0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2CE33B0 Offset: 0x2CE1DB0 VA: 0x182CE33B0
	public void .ctor() { }
}
