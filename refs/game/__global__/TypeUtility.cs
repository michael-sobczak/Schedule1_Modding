public static class TypeUtility // TypeDefIndex: 18392
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x2D40F60 Offset: 0x2D3F960 VA: 0x182D40F60
	private static void .cctor() { }

	// RVA: 0x2D404C0 Offset: 0x2D3EEC0 VA: 0x182D404C0
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x2D405E0 Offset: 0x2D3EFE0 VA: 0x182D405E0
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x2D402E0 Offset: 0x2D3ECE0 VA: 0x182D402E0
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x2D40000 Offset: 0x2D3EA00 VA: 0x182D40000
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF630D0 Offset: 0xF61AD0 VA: 0x180F630D0
	|-TypeUtility.CreateTypeConstructor<Bounds>
	|
	|-RVA: 0xF62F80 Offset: 0xF61980 VA: 0x180F62F80
	|-TypeUtility.CreateTypeConstructor<BoundsInt>
	|
	|-RVA: 0xF63220 Offset: 0xF61C20 VA: 0x180F63220
	|-TypeUtility.CreateTypeConstructor<Color>
	|
	|-RVA: 0xF63760 Offset: 0xF62160 VA: 0x180F63760
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0xF63610 Offset: 0xF62010 VA: 0x180F63610
	|-TypeUtility.CreateTypeConstructor<Rect>
	|
	|-RVA: 0xF634C0 Offset: 0xF61EC0 VA: 0x180F634C0
	|-TypeUtility.CreateTypeConstructor<RectInt>
	|
	|-RVA: 0xF63A00 Offset: 0xF62400 VA: 0x180F63A00
	|-TypeUtility.CreateTypeConstructor<Vector2>
	|
	|-RVA: 0xF638B0 Offset: 0xF622B0 VA: 0x180F638B0
	|-TypeUtility.CreateTypeConstructor<Vector2Int>
	|
	|-RVA: 0xF63CA0 Offset: 0xF626A0 VA: 0x180F63CA0
	|-TypeUtility.CreateTypeConstructor<Vector3>
	|
	|-RVA: 0xF63B50 Offset: 0xF62550 VA: 0x180F63B50
	|-TypeUtility.CreateTypeConstructor<Vector3Int>
	|
	|-RVA: 0xF63DF0 Offset: 0xF627F0 VA: 0x180F63DF0
	|-TypeUtility.CreateTypeConstructor<Vector4>
	|
	|-RVA: 0xF63370 Offset: 0xF61D70 VA: 0x180F63370
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D40400 Offset: 0x2D3EE00 VA: 0x182D40400
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF63FF0 Offset: 0xF629F0 VA: 0x180F63FF0
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0xF63F40 Offset: 0xF62940 VA: 0x180F63F40
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D3FC90 Offset: 0x2D3E690 VA: 0x182D3FC90
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62DE0 Offset: 0xF617E0 VA: 0x180F62DE0
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF64E90 Offset: 0xF63890 VA: 0x180F64E90
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0xF64D80 Offset: 0xF63780 VA: 0x180F64D80
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF64A60 Offset: 0xF63460 VA: 0x180F64A60
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF65430 Offset: 0xF63E30 VA: 0x180F65430
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF64BC0 Offset: 0xF635C0 VA: 0x180F64BC0
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF65250 Offset: 0xF63C50 VA: 0x180F65250
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF64620 Offset: 0xF63020 VA: 0x180F64620
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF64FA0 Offset: 0xF639A0 VA: 0x180F64FA0
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF641E0 Offset: 0xF62BE0 VA: 0x180F641E0
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D3FE80 Offset: 0x2D3E880 VA: 0x182D3FE80
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF62E60 Offset: 0xF61860 VA: 0x180F62E60
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D3FDA0 Offset: 0x2D3E7A0 VA: 0x182D3FDA0
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}
