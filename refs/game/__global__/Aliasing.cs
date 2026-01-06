public static class Aliasing // TypeDefIndex: 16352
{
	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void ExpectAliased(void* a, void* b) { }

	// RVA: -1 Offset: -1
	public static void ExpectAliased<A, B>(in A a, in B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectAliased<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ExpectAliased<B>(void* a, in B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectAliased<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ExpectAliased<A>(in A a, void* b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectAliased<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void ExpectNotAliased(void* a, void* b) { }

	// RVA: -1 Offset: -1
	public static void ExpectNotAliased<A, B>(in A a, in B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectNotAliased<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ExpectNotAliased<B>(void* a, in B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectNotAliased<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void ExpectNotAliased<A>(in A a, void* b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-Aliasing.ExpectNotAliased<__Il2CppFullySharedGenericStructType>
	*/
}
