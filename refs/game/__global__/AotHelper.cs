public static class AotHelper // TypeDefIndex: 11108
{
	// Fields
	private static bool s_alwaysFalse; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: 0x1D58080 Offset: 0x1D56A80 VA: 0x181D58080
	public static void Ensure(Action action) { }

	// RVA: -1 Offset: -1
	public static void EnsureType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFF940 Offset: 0xDFE340 VA: 0x180DFF940
	|-AotHelper.EnsureType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureList<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFF940 Offset: 0xDFE340 VA: 0x180DFF940
	|-AotHelper.EnsureList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureDictionary<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFF940 Offset: 0xDFE340 VA: 0x180DFF940
	|-AotHelper.EnsureDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D58190 Offset: 0x1D56B90 VA: 0x181D58190
	public static bool IsFalse() { }

	// RVA: 0x1D581E0 Offset: 0x1D56BE0 VA: 0x181D581E0
	private static void .cctor() { }
}
