public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 3872
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x1CC8900 Offset: 0x1CC7300 VA: 0x181CC8900
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x1CC8760 Offset: 0x1CC7160 VA: 0x181CC8760
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public IntPtr get_Value() { }

	// RVA: 0x1CC8070 Offset: 0x1CC6A70 VA: 0x181CC8070 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CC7EE0 Offset: 0x1CC68E0 VA: 0x181CC7EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CC7FF0 Offset: 0x1CC69F0 VA: 0x181CC7FF0
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1CC8050 Offset: 0x1CC6A50 VA: 0x181CC8050
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x1CC8050 Offset: 0x1CC6A50 VA: 0x181CC8050
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x1CC8040 Offset: 0x1CC6A40 VA: 0x181CC8040
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x1CC8040 Offset: 0x1CC6A40 VA: 0x181CC8040
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1CC86E0 Offset: 0x1CC70E0 VA: 0x181CC86E0
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1CC85B0 Offset: 0x1CC6FB0 VA: 0x181CC85B0
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x1CC86C0 Offset: 0x1CC70C0 VA: 0x181CC86C0
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1CC8590 Offset: 0x1CC6F90 VA: 0x181CC8590
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1CC8740 Offset: 0x1CC7140 VA: 0x181CC8740
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x1CC8540 Offset: 0x1CC6F40 VA: 0x181CC8540
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1CC8010 Offset: 0x1CC6A10 VA: 0x181CC8010
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	// RVA: 0x1CC8570 Offset: 0x1CC6F70 VA: 0x181CC8570
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1CC8690 Offset: 0x1CC7090 VA: 0x181CC8690
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1CC8580 Offset: 0x1CC6F80 VA: 0x181CC8580
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x1CC85D0 Offset: 0x1CC6FD0 VA: 0x181CC85D0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x1CC85E0 Offset: 0x1CC6FE0 VA: 0x181CC85E0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1CC86A0 Offset: 0x1CC70A0 VA: 0x181CC86A0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x1CC7FD0 Offset: 0x1CC69D0 VA: 0x181CC7FD0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x1CC7FE0 Offset: 0x1CC69E0 VA: 0x181CC7FE0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1CC8020 Offset: 0x1CC6A20 VA: 0x181CC8020
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1CC8060 Offset: 0x1CC6A60 VA: 0x181CC8060
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1CC8680 Offset: 0x1CC7080 VA: 0x181CC8680
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1CC8000 Offset: 0x1CC6A00 VA: 0x181CC8000
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1CC7ED0 Offset: 0x1CC68D0 VA: 0x181CC7ED0
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1CC8950 Offset: 0x1CC7350 VA: 0x181CC8950
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1CC8670 Offset: 0x1CC7070 VA: 0x181CC8670
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1CC8030 Offset: 0x1CC6A30 VA: 0x181CC8030
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	// RVA: 0x1CC8710 Offset: 0x1CC7110 VA: 0x181CC8710
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	// RVA: 0x1CC8940 Offset: 0x1CC7340 VA: 0x181CC8940
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	// RVA: 0x1CC8920 Offset: 0x1CC7320 VA: 0x181CC8920
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	// RVA: 0x1CC81F0 Offset: 0x1CC6BF0 VA: 0x181CC81F0
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }
}
