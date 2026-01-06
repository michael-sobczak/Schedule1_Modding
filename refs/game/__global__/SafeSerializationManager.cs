internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 4444
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B55E70 Offset: 0x1B54870 VA: 0x181B55E70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x99F540 Offset: 0x99DF40 VA: 0x18099F540
	internal bool get_IsActive() { }

	// RVA: 0x1B55690 Offset: 0x1B54090 VA: 0x181B55690
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B553B0 Offset: 0x1B53DB0 VA: 0x181B553B0
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x1B55D20 Offset: 0x1B54720 VA: 0x181B55D20 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B559E0 Offset: 0x1B543E0 VA: 0x181B559E0 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1B55930 Offset: 0x1B54330 VA: 0x181B55930
	private void OnDeserialized(StreamingContext context) { }
}
