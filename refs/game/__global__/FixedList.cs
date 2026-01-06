internal struct FixedList // TypeDefIndex: 15758
{
	// Methods

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static int PaddingBytes<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA1AA0 Offset: 0xEA04A0 VA: 0x180EA1AA0
	|-FixedList.PaddingBytes<byte>
	|
	|-RVA: 0xEA1BB0 Offset: 0xEA05B0 VA: 0x180EA1BB0
	|-FixedList.PaddingBytes<int>
	|-FixedList.PaddingBytes<float>
	|
	|-RVA: 0xEA1B10 Offset: 0xEA0510 VA: 0x180EA1B10
	|-FixedList.PaddingBytes<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static int StorageBytes<BUFFER, T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA1C20 Offset: 0xEA0620 VA: 0x180EA1C20
	|-FixedList.StorageBytes<FixedBytes126, byte>
	|
	|-RVA: 0xEA1C60 Offset: 0xEA0660 VA: 0x180EA1C60
	|-FixedList.StorageBytes<FixedBytes126, int>
	|-FixedList.StorageBytes<FixedBytes126, float>
	|
	|-RVA: 0xEA1CA0 Offset: 0xEA06A0 VA: 0x180EA1CA0
	|-FixedList.StorageBytes<FixedBytes30, byte>
	|
	|-RVA: 0xEA1CE0 Offset: 0xEA06E0 VA: 0x180EA1CE0
	|-FixedList.StorageBytes<FixedBytes30, int>
	|-FixedList.StorageBytes<FixedBytes30, float>
	|
	|-RVA: 0xEA1D20 Offset: 0xEA0720 VA: 0x180EA1D20
	|-FixedList.StorageBytes<FixedBytes4094, byte>
	|
	|-RVA: 0xEA1D60 Offset: 0xEA0760 VA: 0x180EA1D60
	|-FixedList.StorageBytes<FixedBytes4094, int>
	|-FixedList.StorageBytes<FixedBytes4094, float>
	|
	|-RVA: 0xEA1DA0 Offset: 0xEA07A0 VA: 0x180EA1DA0
	|-FixedList.StorageBytes<FixedBytes510, byte>
	|
	|-RVA: 0xEA1DE0 Offset: 0xEA07E0 VA: 0x180EA1DE0
	|-FixedList.StorageBytes<FixedBytes510, int>
	|-FixedList.StorageBytes<FixedBytes510, float>
	|
	|-RVA: 0xEA1E20 Offset: 0xEA0820 VA: 0x180EA1E20
	|-FixedList.StorageBytes<FixedBytes62, byte>
	|
	|-RVA: 0xEA1E60 Offset: 0xEA0860 VA: 0x180EA1E60
	|-FixedList.StorageBytes<FixedBytes62, int>
	|-FixedList.StorageBytes<FixedBytes62, float>
	|
	|-RVA: 0xEA1EA0 Offset: 0xEA08A0 VA: 0x180EA1EA0
	|-FixedList.StorageBytes<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static int Capacity<BUFFER, T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA1650 Offset: 0xEA0050 VA: 0x180EA1650
	|-FixedList.Capacity<FixedBytes126, byte>
	|
	|-RVA: 0xEA16A0 Offset: 0xEA00A0 VA: 0x180EA16A0
	|-FixedList.Capacity<FixedBytes126, int>
	|-FixedList.Capacity<FixedBytes126, float>
	|
	|-RVA: 0xEA16F0 Offset: 0xEA00F0 VA: 0x180EA16F0
	|-FixedList.Capacity<FixedBytes30, byte>
	|
	|-RVA: 0xEA1740 Offset: 0xEA0140 VA: 0x180EA1740
	|-FixedList.Capacity<FixedBytes30, int>
	|-FixedList.Capacity<FixedBytes30, float>
	|
	|-RVA: 0xEA1790 Offset: 0xEA0190 VA: 0x180EA1790
	|-FixedList.Capacity<FixedBytes4094, byte>
	|
	|-RVA: 0xEA17E0 Offset: 0xEA01E0 VA: 0x180EA17E0
	|-FixedList.Capacity<FixedBytes4094, int>
	|-FixedList.Capacity<FixedBytes4094, float>
	|
	|-RVA: 0xEA1830 Offset: 0xEA0230 VA: 0x180EA1830
	|-FixedList.Capacity<FixedBytes510, byte>
	|
	|-RVA: 0xEA1880 Offset: 0xEA0280 VA: 0x180EA1880
	|-FixedList.Capacity<FixedBytes510, int>
	|-FixedList.Capacity<FixedBytes510, float>
	|
	|-RVA: 0xEA18D0 Offset: 0xEA02D0 VA: 0x180EA18D0
	|-FixedList.Capacity<FixedBytes62, byte>
	|
	|-RVA: 0xEA1920 Offset: 0xEA0320 VA: 0x180EA1920
	|-FixedList.Capacity<FixedBytes62, int>
	|-FixedList.Capacity<FixedBytes62, float>
	|
	|-RVA: 0xEA1970 Offset: 0xEA0370 VA: 0x180EA1970
	|-FixedList.Capacity<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Conditional("UNITY_DOTS_DEBUG")]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	internal static void CheckResize<BUFFER, T>(int newLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA19C0 Offset: 0xEA03C0 VA: 0x180EA19C0
	|-FixedList.CheckResize<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
