public static class Vector // TypeDefIndex: 4789
{
	// Properties
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF75170 Offset: 0xF73B70 VA: 0x180F75170
	|-Vector.Equals<ushort>
	|
	|-RVA: 0xF750C0 Offset: 0xF73AC0 VA: 0x180F750C0
	|-Vector.Equals<__Il2CppFullySharedGenericStructType>
	*/

	[Intrinsic]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_IsHardwareAccelerated() { }

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF75030 Offset: 0xF73A30 VA: 0x180F75030
	|-Vector.AsVectorUInt64<ushort>
	|
	|-RVA: 0xF74FA0 Offset: 0xF739A0 VA: 0x180F74FA0
	|-Vector.AsVectorUInt64<__Il2CppFullySharedGenericStructType>
	*/
}
