public static class LazyInitializer // TypeDefIndex: 3918
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEABD0 Offset: 0xEE95D0 VA: 0x180EEABD0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA8F0 Offset: 0xEE92F0 VA: 0x180EEA8F0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEACC0 Offset: 0xEE96C0 VA: 0x180EEACC0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA990 Offset: 0xEE9390 VA: 0x180EEA990
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEAA40 Offset: 0xEE9440 VA: 0x180EEAA40
	|-LazyInitializer.EnsureInitialized<bool>
	|
	|-RVA: 0xEEAAD0 Offset: 0xEE94D0 VA: 0x180EEAAD0
	|-LazyInitializer.EnsureInitialized<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA4D0 Offset: 0xEE8ED0 VA: 0x180EEA4D0
	|-LazyInitializer.EnsureInitializedCore<bool>
	|
	|-RVA: 0xEEA5E0 Offset: 0xEE8FE0 VA: 0x180EEA5E0
	|-LazyInitializer.EnsureInitializedCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEAC40 Offset: 0xEE9640 VA: 0x180EEAC40
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA7B0 Offset: 0xEE91B0 VA: 0x180EEA7B0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: 0x1CDEA70 Offset: 0x1CDD470 VA: 0x181CDEA70
	private static object EnsureLockInitialized(ref object syncLock) { }
}
