internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 4743
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x1B8C1D0 Offset: 0x1B8ABD0 VA: 0x181B8C1D0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x1B8BEE0 Offset: 0x1B8A8E0 VA: 0x181B8BEE0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x1B8C200 Offset: 0x1B8AC00 VA: 0x181B8C200
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B8B160 Offset: 0x1B89B60 VA: 0x181B8B160 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B8B1C0 Offset: 0x1B89BC0 VA: 0x181B8B1C0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}
