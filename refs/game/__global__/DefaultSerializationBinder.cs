public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 11226
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	[Nullable(new[] { 1, 0, 2, 1, 1 })]
	private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x1D7F2B0 Offset: 0x1D7DCB0 VA: 0x181D7F2B0
	public void .ctor() { }

	// RVA: 0x1D7ED50 Offset: 0x1D7D750 VA: 0x181D7ED50
	private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x1D7EA60 Offset: 0x1D7D460 VA: 0x181D7EA60
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0x1D7ECF0 Offset: 0x1D7D6F0 VA: 0x181D7ECF0
	private Type GetTypeByName(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x1D7E9A0 Offset: 0x1D7D3A0 VA: 0x181D7E9A0 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x1D7E900 Offset: 0x1D7D300 VA: 0x181D7E900 Slot: 4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0x1D7F1A0 Offset: 0x1D7DBA0 VA: 0x181D7F1A0
	private static void .cctor() { }
}
