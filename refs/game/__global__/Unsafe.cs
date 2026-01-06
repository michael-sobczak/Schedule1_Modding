internal static class Unsafe // TypeDefIndex: 19385
{
	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D350 Offset: 0xF6BD50 VA: 0x180F6D350
	|-Unsafe.Read<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D350 Offset: 0xF6BD50 VA: 0x180F6D350
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D350 Offset: 0xF6BD50 VA: 0x180F6D350
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void Write<T>(void* destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D5A0 Offset: 0xF6BFA0 VA: 0x180F6D5A0
	|-Unsafe.Write<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(void* destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D5A0 Offset: 0xF6BFA0 VA: 0x180F6D5A0
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D5A0 Offset: 0xF6BFA0 VA: 0x180F6D5A0
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void Copy<T>(void* destination, ref T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D270 Offset: 0xF6BC70 VA: 0x180F6D270
	|-Unsafe.Copy<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void Copy<T>(ref T destination, void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D270 Offset: 0xF6BC70 VA: 0x180F6D270
	|-Unsafe.Copy<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Unsafe.AsPointer<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D3F0 Offset: 0xF6BDF0 VA: 0x180F6D3F0
	|-Unsafe.SizeOf<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: 0x2701BD0 Offset: 0x27005D0 VA: 0x182701BD0
	public static void CopyBlock(void* destination, void* source, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x2701BD0 Offset: 0x27005D0 VA: 0x182701BD0
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x2701BD0 Offset: 0x27005D0 VA: 0x182701BD0
	public static void CopyBlockUnaligned(void* destination, void* source, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x2701BD0 Offset: 0x27005D0 VA: 0x182701BD0
	public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x1B76C10 Offset: 0x1B75610 VA: 0x181B76C10
	public static void InitBlock(void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x1B76C10 Offset: 0x1B75610 VA: 0x181B76C10
	public static void InitBlock(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x1B76C10 Offset: 0x1B75610 VA: 0x181B76C10
	public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: 0x1B76C10 Offset: 0x1B75610 VA: 0x181B76C10
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Unsafe.As<object>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Unsafe.AsRef<AllocatorManager.Array32768<AllocatorManager.TableEntry>>
	|-Unsafe.AsRef<int>
	|-Unsafe.AsRef<IntPtr>
	|-Unsafe.AsRef<Long1024>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(ref T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Unbox<T>(object box) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D530 Offset: 0xF6BF30 VA: 0x180F6D530
	|-Unsafe.Unbox<__Il2CppFullySharedGenericStructType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D190 Offset: 0xF6BB90 VA: 0x180F6D190
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void* Add<T>(void* source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D0F0 Offset: 0xF6BAF0 VA: 0x180F6D0F0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D140 Offset: 0xF6BB40 VA: 0x180F6D140
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6CF60 Offset: 0xF6B960 VA: 0x180F6CF60
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Subtract<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D4E0 Offset: 0xF6BEE0 VA: 0x180F6D4E0
	|-Unsafe.Subtract<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static void* Subtract<T>(void* source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D490 Offset: 0xF6BE90 VA: 0x180F6D490
	|-Unsafe.Subtract<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Subtract<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D440 Offset: 0xF6BE40 VA: 0x180F6D440
	|-Unsafe.Subtract<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T SubtractByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D430 Offset: 0xF6BE30 VA: 0x180F6D430
	|-Unsafe.SubtractByteOffset<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static IntPtr ByteOffset<T>(ref T origin, ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D260 Offset: 0xF6BC60 VA: 0x180F6D260
	|-Unsafe.ByteOffset<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	|-Unsafe.AreSame<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static bool IsAddressGreaterThan<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D330 Offset: 0xF6BD30 VA: 0x180F6D330
	|-Unsafe.IsAddressGreaterThan<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static bool IsAddressLessThan<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6D340 Offset: 0xF6BD40 VA: 0x180F6D340
	|-Unsafe.IsAddressLessThan<__Il2CppFullySharedGenericType>
	*/
}
