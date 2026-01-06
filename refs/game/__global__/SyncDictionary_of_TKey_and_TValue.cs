public class SyncDictionary<TKey, TValue> : SyncIDictionary<TKey, TValue> // TypeDefIndex: 12630
{
	// Properties
	[APIExclude]
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	[APIExclude]
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }

	// Methods

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE2B0 Offset: 0x11ECCB0 VA: 0x1811EE2B0
	|-SyncDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> eq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE340 Offset: 0x11ECD40 VA: 0x1811EE340
	|-SyncDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE4F0 Offset: 0x11ECEF0 VA: 0x1811EE4F0
	|-SyncDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE3E0 Offset: 0x11ECDE0 VA: 0x1811EE3E0
	|-SyncDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EE150 Offset: 0x11ECB50 VA: 0x1811EE150
	|-SyncDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/
}
