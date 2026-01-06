internal static class DictionaryExtensions // TypeDefIndex: 17882
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TDictionary MergeNoOverride<TDictionary, TKey, TValue>(TDictionary self, IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE802E0 Offset: 0xE7ECE0 VA: 0x180E802E0
	|-DictionaryExtensions.MergeNoOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE80040 Offset: 0xE7EA40 VA: 0x180E80040
	|-DictionaryExtensions.MergeAllowOverride<object, int, object>
	|
	|-RVA: 0xE7FBC0 Offset: 0xE7E5C0 VA: 0x180E7FBC0
	|-DictionaryExtensions.MergeAllowOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE81100 Offset: 0xE7FB00 VA: 0x180E81100
	|-DictionaryExtensions.ValueEquals<object, object>
	|
	|-RVA: 0xE80D10 Offset: 0xE7F710 VA: 0x180E80D10
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ValueEquals<TKey, TValue, TComparer>(IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE80D90 Offset: 0xE7F790 VA: 0x180E80D90
	|-DictionaryExtensions.ValueEquals<object, object, object>
	|
	|-RVA: 0xE80840 Offset: 0xE7F240 VA: 0x180E80840
	|-DictionaryExtensions.ValueEquals<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
