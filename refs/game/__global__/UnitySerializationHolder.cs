internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 3828
{
	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x1CD0800 Offset: 0x1CCF200 VA: 0x181CD0800
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x1CD18E0 Offset: 0x1CD02E0 VA: 0x181CD18E0
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x1CD17B0 Offset: 0x1CD01B0 VA: 0x181CD17B0
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) { }

	// RVA: 0x1CD1160 Offset: 0x1CCFB60 VA: 0x181CD1160
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x1CD1630 Offset: 0x1CD0030 VA: 0x181CD1630
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x1CD1AC0 Offset: 0x1CD04C0 VA: 0x181CD1AC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CD1A10 Offset: 0x1CD0410 VA: 0x181CD1A10
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x1CD0A70 Offset: 0x1CCF470 VA: 0x181CD0A70 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CD0AD0 Offset: 0x1CCF4D0 VA: 0x181CD0AD0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}
