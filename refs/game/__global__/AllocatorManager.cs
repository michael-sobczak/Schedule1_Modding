public static class AllocatorManager // TypeDefIndex: 15725
{
	// Fields
	public static readonly AllocatorManager.AllocatorHandle Invalid; // 0x0
	public static readonly AllocatorManager.AllocatorHandle None; // 0x4
	public static readonly AllocatorManager.AllocatorHandle Temp; // 0x8
	public static readonly AllocatorManager.AllocatorHandle TempJob; // 0xC
	public static readonly AllocatorManager.AllocatorHandle Persistent; // 0x10
	public static readonly AllocatorManager.AllocatorHandle AudioKernel; // 0x14
	public const int kErrorNone = 0;
	public const int kErrorBufferOverflow = -1;
	public const ushort FirstUserIndex = 64;

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static AllocatorManager.Block AllocateBlock<T>(ref T t, int sizeOf, int alignOf, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBD950 Offset: 0xDBC350 VA: 0x180DBD950
	|-AllocatorManager.AllocateBlock<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBD7C0 Offset: 0xDBC1C0 VA: 0x180DBD7C0
	|-AllocatorManager.AllocateBlock<AllocatorManager.AllocatorHandle>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static AllocatorManager.Block AllocateBlock<T, U>(ref T t, U u, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBD870 Offset: 0xDBC270 VA: 0x180DBD870
	|-AllocatorManager.AllocateBlock<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void* Allocate<T>(ref T t, int sizeOf, int alignOf, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBE070 Offset: 0xDBCA70 VA: 0x180DBE070
	|-AllocatorManager.Allocate<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBDE40 Offset: 0xDBC840 VA: 0x180DBDE40
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static U* Allocate<T, U>(ref T t, U u, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBDC40 Offset: 0xDBC640 VA: 0x180DBDC40
	|-AllocatorManager.Allocate<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBDD00 Offset: 0xDBC700 VA: 0x180DBDD00
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle, UnsafeList<byte>>
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle, UnsafeList<int>>
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle, UnsafeList<IntPtr>>
	|
	|-RVA: 0xDBDDA0 Offset: 0xDBC7A0 VA: 0x180DBDDA0
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle, UnsafeList>
	|-AllocatorManager.Allocate<AllocatorManager.AllocatorHandle, UnsafePtrList>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void* AllocateStruct<T, U>(ref T t, U u, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBDC40 Offset: 0xDBC640 VA: 0x180DBDC40
	|-AllocatorManager.AllocateStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBDB00 Offset: 0xDBC500 VA: 0x180DBDB00
	|-AllocatorManager.AllocateStruct<AllocatorManager.AllocatorHandle, byte>
	|
	|-RVA: 0xDBDBA0 Offset: 0xDBC5A0 VA: 0x180DBDBA0
	|-AllocatorManager.AllocateStruct<AllocatorManager.AllocatorHandle, int>
	|-AllocatorManager.AllocateStruct<AllocatorManager.AllocatorHandle, float>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void FreeBlock<T>(ref T t, ref AllocatorManager.Block block) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBE460 Offset: 0xDBCE60 VA: 0x180DBE460
	|-AllocatorManager.FreeBlock<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBE410 Offset: 0xDBCE10 VA: 0x180DBE410
	|-AllocatorManager.FreeBlock<AllocatorManager.AllocatorHandle>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void Free<T>(ref T t, void* pointer, int sizeOf, int alignOf, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBEB60 Offset: 0xDBD560 VA: 0x180DBEB60
	|-AllocatorManager.Free<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBE8A0 Offset: 0xDBD2A0 VA: 0x180DBE8A0
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void Free<T, U>(ref T t, U* pointer, int items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBEA20 Offset: 0xDBD420 VA: 0x180DBEA20
	|-AllocatorManager.Free<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBE740 Offset: 0xDBD140 VA: 0x180DBE740
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafeList<byte>>
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafeList<int>>
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafeList<IntPtr>>
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafeText>
	|
	|-RVA: 0xDBE530 Offset: 0xDBCF30 VA: 0x180DBE530
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, byte>
	|
	|-RVA: 0xDBE5E0 Offset: 0xDBCFE0 VA: 0x180DBE5E0
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, int>
	|
	|-RVA: 0xDBE690 Offset: 0xDBD090 VA: 0x180DBE690
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, IntPtr>
	|
	|-RVA: 0xDBE7F0 Offset: 0xDBD1F0 VA: 0x180DBE7F0
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafeList>
	|-AllocatorManager.Free<AllocatorManager.AllocatorHandle, UnsafePtrList>
	*/

	// RVA: 0x271A780 Offset: 0x2719180 VA: 0x18271A780
	public static void* Allocate(AllocatorManager.AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	// RVA: -1 Offset: -1
	public static T* Allocate<T>(AllocatorManager.AllocatorHandle handle, int items = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBE120 Offset: 0xDBCB20 VA: 0x180DBE120
	|-AllocatorManager.Allocate<UnsafeList<byte>>
	|-AllocatorManager.Allocate<UnsafeList<int>>
	|-AllocatorManager.Allocate<UnsafeList<IntPtr>>
	|
	|-RVA: 0xDBE1F0 Offset: 0xDBCBF0 VA: 0x180DBE1F0
	|-AllocatorManager.Allocate<UnsafeList>
	|-AllocatorManager.Allocate<UnsafePtrList>
	|
	|-RVA: 0xDBDF40 Offset: 0xDBC940 VA: 0x180DBDF40
	|-AllocatorManager.Allocate<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x271A8D0 Offset: 0x27192D0 VA: 0x18271A8D0
	public static void Free(AllocatorManager.AllocatorHandle handle, void* pointer, int itemSizeInBytes, int alignmentInBytes, int items = 1) { }

	// RVA: 0x271A960 Offset: 0x2719360 VA: 0x18271A960
	public static void Free(AllocatorManager.AllocatorHandle handle, void* pointer) { }

	// RVA: -1 Offset: -1
	public static void Free<T>(AllocatorManager.AllocatorHandle handle, T* pointer, int items = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBED30 Offset: 0xDBD730 VA: 0x180DBED30
	|-AllocatorManager.Free<UnsafeList<byte>>
	|-AllocatorManager.Free<UnsafeList<int>>
	|-AllocatorManager.Free<UnsafeList<IntPtr>>
	|-AllocatorManager.Free<UnsafeText>
	|
	|-RVA: 0xDBE9A0 Offset: 0xDBD3A0 VA: 0x180DBE9A0
	|-AllocatorManager.Free<byte>
	|
	|-RVA: 0xDBEC30 Offset: 0xDBD630 VA: 0x180DBEC30
	|-AllocatorManager.Free<int>
	|
	|-RVA: 0xDBECB0 Offset: 0xDBD6B0 VA: 0x180DBECB0
	|-AllocatorManager.Free<IntPtr>
	|
	|-RVA: 0xDBEE20 Offset: 0xDBD820 VA: 0x180DBEE20
	|-AllocatorManager.Free<UnsafeList>
	|-AllocatorManager.Free<UnsafePtrList>
	|
	|-RVA: 0xDBEAE0 Offset: 0xDBD4E0 VA: 0x180DBEAE0
	|-AllocatorManager.Free<__Il2CppFullySharedGenericStructType>
	*/

	[BurstDiscard]
	// RVA: 0x1439220 Offset: 0x1437C20 VA: 0x181439220
	private static void CheckDelegate(ref bool useDelegate) { }

	// RVA: 0x271B2D0 Offset: 0x2719CD0 VA: 0x18271B2D0
	private static bool UseDelegate() { }

	// RVA: 0x271B400 Offset: 0x2719E00 VA: 0x18271B400
	private static int allocate_block(ref AllocatorManager.Block block) { }

	[BurstDiscard]
	// RVA: 0x271B490 Offset: 0x2719E90 VA: 0x18271B490
	private static void forward_mono_allocate_block(ref AllocatorManager.Block block, ref int error) { }

	// RVA: 0x271ADD0 Offset: 0x27197D0 VA: 0x18271ADD0
	internal static Allocator LegacyOf(AllocatorManager.AllocatorHandle handle) { }

	// RVA: 0x271AF80 Offset: 0x2719980 VA: 0x18271AF80
	private static int TryLegacy(ref AllocatorManager.Block block) { }

	// RVA: 0x271B110 Offset: 0x2719B10 VA: 0x18271B110
	public static int Try(ref AllocatorManager.Block block) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void Initialize() { }

	// RVA: 0x271AA50 Offset: 0x2719450 VA: 0x18271AA50
	internal static void Install(AllocatorManager.AllocatorHandle handle, IntPtr allocatorState, FunctionPointer<AllocatorManager.TryFunction> functionPointer, AllocatorManager.TryFunction function) { }

	// RVA: 0x271ACF0 Offset: 0x27196F0 VA: 0x18271ACF0
	internal static void Install(AllocatorManager.AllocatorHandle handle, IntPtr allocatorState, AllocatorManager.TryFunction function) { }

	// RVA: 0x271ADE0 Offset: 0x27197E0 VA: 0x18271ADE0
	internal static AllocatorManager.AllocatorHandle Register(IntPtr allocatorState, FunctionPointer<AllocatorManager.TryFunction> functionPointer) { }

	[NotBurstCompatible]
	[Extension]
	// RVA: -1 Offset: -1
	public static void Register<T>(ref T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBEF10 Offset: 0xDBD910 VA: 0x180DBEF10
	|-AllocatorManager.Register<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void UnmanagedUnregister<T>(ref T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBF2D0 Offset: 0xDBDCD0 VA: 0x180DBF2D0
	|-AllocatorManager.UnmanagedUnregister<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	[Extension]
	// RVA: -1 Offset: -1
	public static void Unregister<T>(ref T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBF6C0 Offset: 0xDBE0C0 VA: 0x180DBF6C0
	|-AllocatorManager.Unregister<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xDBF560 Offset: 0xDBDF60 VA: 0x180DBF560
	|-AllocatorManager.Unregister<AllocatorManager.AllocatorHandle>
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	internal static ref T CreateAllocator<T>(AllocatorManager.AllocatorHandle backingAllocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBE2C0 Offset: 0xDBCCC0 VA: 0x180DBE2C0
	|-AllocatorManager.CreateAllocator<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	internal static void DestroyAllocator<T>(ref T t, AllocatorManager.AllocatorHandle backingAllocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBE380 Offset: 0xDBCD80 VA: 0x180DBE380
	|-AllocatorManager.DestroyAllocator<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void Shutdown() { }

	// RVA: 0x271ADC0 Offset: 0x27197C0 VA: 0x18271ADC0
	internal static bool IsCustomAllocator(AllocatorManager.AllocatorHandle allocator) { }

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	// RVA: 0x271A810 Offset: 0x2719210 VA: 0x18271A810
	internal static void CheckFailedToAllocate(int error) { }

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	// RVA: 0x271A870 Offset: 0x2719270 VA: 0x18271A870
	internal static void CheckFailedToFree(int error) { }

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void CheckValid(AllocatorManager.AllocatorHandle handle) { }

	// RVA: 0x271B310 Offset: 0x2719D10 VA: 0x18271B310
	private static void .cctor() { }

	// RVA: 0x271AA10 Offset: 0x2719410 VA: 0x18271AA10
	public static void Initialize$StackAllocator_Try_000000A2$BurstDirectCall() { }

	// RVA: 0x271A9D0 Offset: 0x27193D0 VA: 0x18271A9D0
	public static void Initialize$SlabAllocator_Try_000000B0$BurstDirectCall() { }
}
