internal static class JitHelpers // TypeDefIndex: 4643
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4EA0 Offset: 0xEE38A0 VA: 0x180EE4EA0
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4F80 Offset: 0xEE3980 VA: 0x180EE4F80
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|
	|-RVA: 0xEE5060 Offset: 0xEE3A60 VA: 0x180EE5060
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	|-JitHelpers.UnsafeEnumCast<UInt32Enum>
	|
	|-RVA: 0xEE4FC0 Offset: 0xEE39C0 VA: 0x180EE4FC0
	|-JitHelpers.UnsafeEnumCast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4EE0 Offset: 0xEE38E0 VA: 0x180EE4EE0
	|-JitHelpers.UnsafeEnumCastLong<__Il2CppFullySharedGenericStructType>
	*/
}
