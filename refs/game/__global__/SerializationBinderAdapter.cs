internal class SerializationBinderAdapter : ISerializationBinder // TypeDefIndex: 11275
{
	// Fields
	public readonly SerializationBinder SerializationBinder; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(SerializationBinder serializationBinder) { }

	// RVA: 0x1DAEED0 Offset: 0x1DAD8D0 VA: 0x181DAEED0 Slot: 4
	public Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x1DAEEA0 Offset: 0x1DAD8A0 VA: 0x181DAEEA0 Slot: 5
	public void BindToName(Type serializedType, out string assemblyName, out string typeName) { }
}
