public static class UnsafeUtilityExtensions // TypeDefIndex: 16017
{
	// Methods

	// RVA: 0x2747FB0 Offset: 0x27469B0 VA: 0x182747FB0
	internal static void MemSwap(void* ptr, void* otherPtr, long size) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static T ReadArrayElementBoundsChecked<T>(void* source, int index, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF72220 Offset: 0xF70C20 VA: 0x180F72220
	|-UnsafeUtilityExtensions.ReadArrayElementBoundsChecked<__Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void WriteArrayElementBoundsChecked<T>(void* destination, int index, T value, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF722F0 Offset: 0xF70CF0 VA: 0x180F722F0
	|-UnsafeUtilityExtensions.WriteArrayElementBoundsChecked<__Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF721F0 Offset: 0xF70BF0 VA: 0x180F721F0
	|-UnsafeUtilityExtensions.AddressOf<FixedBytes126>
	|-UnsafeUtilityExtensions.AddressOf<FixedBytes30>
	|-UnsafeUtilityExtensions.AddressOf<FixedBytes4094>
	|-UnsafeUtilityExtensions.AddressOf<FixedBytes510>
	|-UnsafeUtilityExtensions.AddressOf<FixedBytes62>
	|
	|-RVA: 0xF064A0 Offset: 0xF04EA0 VA: 0x180F064A0
	|-UnsafeUtilityExtensions.AddressOf<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF721F0 Offset: 0xF70BF0 VA: 0x180F721F0
	|-UnsafeUtilityExtensions.AsRef<FixedString128Bytes>
	|-UnsafeUtilityExtensions.AsRef<FixedString32Bytes>
	|-UnsafeUtilityExtensions.AsRef<FixedString4096Bytes>
	|-UnsafeUtilityExtensions.AsRef<FixedString512Bytes>
	|-UnsafeUtilityExtensions.AsRef<FixedString64Bytes>
	|-UnsafeUtilityExtensions.AsRef<HeapString>
	|-UnsafeUtilityExtensions.AsRef<NativeText>
	|-UnsafeUtilityExtensions.AsRef<UnsafeText>
	|-UnsafeUtilityExtensions.AsRef<NativeText.ReadOnly>
	|
	|-RVA: 0xF064A0 Offset: 0xF04EA0 VA: 0x180F064A0
	|-UnsafeUtilityExtensions.AsRef<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2747F40 Offset: 0x2746940 VA: 0x182747F40
	private static void CheckMemSwapOverlap(byte* dst, byte* src, long size) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2747E60 Offset: 0x2746860 VA: 0x182747E60
	private static void CheckIndexRange(int index, int capacity) { }
}
