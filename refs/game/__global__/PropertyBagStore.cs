internal static class PropertyBagStore // TypeDefIndex: 18442
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Type, IPropertyBag> NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Methods

	// RVA: 0x2D3E7E0 Offset: 0x2D3D1E0 VA: 0x182D3E7E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF27D60 Offset: 0xF26760 VA: 0x180F27D60
	|-PropertyBagStore.AddPropertyBag<Bounds>
	|-PropertyBagStore.AddPropertyBag<BoundsInt>
	|-PropertyBagStore.AddPropertyBag<Color>
	|-PropertyBagStore.AddPropertyBag<object>
	|-PropertyBagStore.AddPropertyBag<Rect>
	|-PropertyBagStore.AddPropertyBag<RectInt>
	|-PropertyBagStore.AddPropertyBag<Vector2>
	|-PropertyBagStore.AddPropertyBag<Vector2Int>
	|-PropertyBagStore.AddPropertyBag<Vector3>
	|-PropertyBagStore.AddPropertyBag<Vector3Int>
	|-PropertyBagStore.AddPropertyBag<Vector4>
	|
	|-RVA: 0xF283F0 Offset: 0xF26DF0 VA: 0x180F283F0
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF289A0 Offset: 0xF273A0 VA: 0x180F289A0
	|-PropertyBagStore.GetPropertyBag<Bounds>
	|-PropertyBagStore.GetPropertyBag<BoundsInt>
	|-PropertyBagStore.GetPropertyBag<Color>
	|-PropertyBagStore.GetPropertyBag<object>
	|-PropertyBagStore.GetPropertyBag<Rect>
	|-PropertyBagStore.GetPropertyBag<RectInt>
	|-PropertyBagStore.GetPropertyBag<Vector2>
	|-PropertyBagStore.GetPropertyBag<Vector2Int>
	|-PropertyBagStore.GetPropertyBag<Vector3>
	|-PropertyBagStore.GetPropertyBag<Vector3Int>
	|-PropertyBagStore.GetPropertyBag<Vector4>
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D3E360 Offset: 0x2D3CD60 VA: 0x182D3E360
	internal static IPropertyBag GetPropertyBag(Type type) { }
}
