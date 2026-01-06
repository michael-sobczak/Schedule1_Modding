internal class FSharpUtils // TypeDefIndex: 11163
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <IsUnion>k__BackingField; // 0x28
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCases>k__BackingField; // 0x30
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	[CompilerGenerated]
	[Nullable(new[] { 1, 2, 1 })]
	private MethodCall<object, object> <PreComputeUnionReader>k__BackingField; // 0x40
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField; // 0x68
	public const string FSharpSetTypeName = "FSharpSet`1";
	public const string FSharpListTypeName = "FSharpList`1";
	public const string FSharpMapTypeName = "FSharpMap`2";

	// Properties
	public static FSharpUtils Instance { get; }
	public Assembly FSharpCoreAssembly { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> IsUnion { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> GetUnionCases { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionTagReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionConstructor { get; set; }
	public Func<object, object> GetUnionCaseInfoDeclaringType { get; set; }
	public Func<object, object> GetUnionCaseInfoName { get; set; }
	public Func<object, object> GetUnionCaseInfoTag { get; set; }
	[Nullable(new[] { 1, 1, 2 })]
	public MethodCall<object, object> GetUnionCaseInfoFields { get; set; }

	// Methods

	// RVA: 0x1D674B0 Offset: 0x1D65EB0 VA: 0x181D674B0
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0x1D67A50 Offset: 0x1D66450 VA: 0x181D67A50
	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Assembly get_FSharpCoreAssembly() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public MethodCall<object, object> get_IsUnion() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_IsUnion(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public MethodCall<object, object> get_GetUnionCases() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_GetUnionCases(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public MethodCall<object, object> get_PreComputeUnionTagReader() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_PreComputeUnionTagReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public MethodCall<object, object> get_PreComputeUnionReader() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_PreComputeUnionReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public MethodCall<object, object> get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_PreComputeUnionConstructor(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Func<object, object> get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_GetUnionCaseInfoDeclaringType(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Func<object, object> get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_GetUnionCaseInfoName(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Func<object, object> get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_GetUnionCaseInfoTag(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public MethodCall<object, object> get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_GetUnionCaseInfoFields(MethodCall<object, object> value) { }

	// RVA: 0x1D67230 Offset: 0x1D65C30 VA: 0x181D67230
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0x1D673B0 Offset: 0x1D65DB0 VA: 0x181D673B0
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0x1D66CE0 Offset: 0x1D656E0 VA: 0x181D66CE0
	private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0x1D67110 Offset: 0x1D65B10 VA: 0x181D67110
	public ObjectConstructor<object> CreateSeq(Type t) { }

	// RVA: 0x1D66F20 Offset: 0x1D65920 VA: 0x181D66F20
	public ObjectConstructor<object> CreateMap(Type keyType, Type valueType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA0CC0 Offset: 0xE9F6C0 VA: 0x180EA0CC0
	|-FSharpUtils.BuildMapCreator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D67430 Offset: 0x1D65E30 VA: 0x181D67430
	private static void .cctor() { }
}
