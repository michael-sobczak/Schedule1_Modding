internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 11206
{
	// Fields
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; // 0x0
	private readonly Func<TKey, TValue> _creator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TKey, TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12705D0 Offset: 0x126EFD0 VA: 0x1812705D0
	|-ThreadSafeStore<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x12706A0 Offset: 0x126F0A0 VA: 0x1812706A0
	|-ThreadSafeStore<object, object>..ctor
	|
	|-RVA: 0x1270500 Offset: 0x126EF00 VA: 0x181270500
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12704C0 Offset: 0x126EEC0 VA: 0x1812704C0
	|-ThreadSafeStore<StructMultiKey<object, object>, object>.Get
	|
	|-RVA: 0x1270330 Offset: 0x126ED30 VA: 0x181270330
	|-ThreadSafeStore<object, object>.Get
	|
	|-RVA: 0x1270370 Offset: 0x126ED70 VA: 0x181270370
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}
