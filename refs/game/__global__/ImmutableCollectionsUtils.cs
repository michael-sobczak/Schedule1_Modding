internal static class ImmutableCollectionsUtils // TypeDefIndex: 11168
{
	// Fields
	private const string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1";
	private const string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1";
	private const string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1";
	private const string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1";
	private const string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray";
	private const string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1";
	private const string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList";
	private const string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1";
	private const string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue";
	private const string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1";
	private const string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack";
	private const string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1";
	private const string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet";
	private const string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1";
	private const string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet";
	private const string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1";
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private const string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2";
	private const string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary";
	private const string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2";
	private const string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary";
	private const string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2";
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0x1D67AA0 Offset: 0x1D664A0 VA: 0x181D67AA0
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1D67FB0 Offset: 0x1D669B0 VA: 0x181D67FB0
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1D68550 Offset: 0x1D66F50 VA: 0x181D68550
	private static void .cctor() { }
}
