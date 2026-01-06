internal class ReflectedPropertyBagProvider // TypeDefIndex: 18447
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x2D3F1C0 Offset: 0x2D3DBC0 VA: 0x182D3F1C0
	public void .ctor() { }

	// RVA: 0x2D3EDC0 Offset: 0x2D3D7C0 VA: 0x182D3EDC0
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2E520 Offset: 0xF2CF20 VA: 0x180F2E520
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30020 Offset: 0xF2EA20 VA: 0x180F30020
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5B20 Offset: 0xDC4520 VA: 0x180DC5B20
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x2D3EF10 Offset: 0x2D3D910 VA: 0x182D3EF10
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x2D3EF90 Offset: 0x2D3D990 VA: 0x182D3EF90
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x2D3F0D0 Offset: 0x2D3DAD0 VA: 0x182D3F0D0
	private static bool IsValidPropertyType(Type type) { }
}
