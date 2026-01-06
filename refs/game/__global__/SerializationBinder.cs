public abstract class SerializationBinder // TypeDefIndex: 4424
{
	// Methods

	// RVA: 0x1B3FC70 Offset: 0x1B3E670 VA: 0x181B3FC70 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
