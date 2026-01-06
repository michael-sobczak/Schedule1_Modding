public static class EnumExt // TypeDefIndex: 10474
{
	// Methods

	[Extension]
	// RVA: 0x4931A0 Offset: 0x491BA0 VA: 0x1804931A0
	public static bool HasFlag(Enum variable, Enum[] flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool HasFlag<T>(T value, T flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82DF0 Offset: 0xE817F0 VA: 0x180E82DF0
	|-EnumExt.HasFlag<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T Set<T>(Enum value, T append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE831A0 Offset: 0xE81BA0 VA: 0x180E831A0
	|-EnumExt.Set<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T Set<T>(Enum value, T append, bool OnOff) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82F20 Offset: 0xE81920 VA: 0x180E82F20
	|-EnumExt.Set<__Il2CppFullySharedGenericType>
	*/
}
