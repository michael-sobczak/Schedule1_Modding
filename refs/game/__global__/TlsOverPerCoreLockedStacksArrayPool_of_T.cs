internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T> // TypeDefIndex: 5033
{
	// Fields
	private readonly int[] _bucketArraySizes; // 0x0
	private readonly TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T>[] _buckets; // 0x0
	[ThreadStatic]
	private static T[][] t_tlsBuckets; // 0xFFFFFFFF
	private int _callbackCreated; // 0x0
	private static readonly bool s_trimBuffers; // 0x0
	private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12734E0 Offset: 0x1271EE0 VA: 0x1812734E0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..ctor
	|
	|-RVA: 0x12733C0 Offset: 0x1271DC0 VA: 0x1812733C0
	|-TlsOverPerCoreLockedStacksArrayPool<char>..ctor
	|
	|-RVA: 0x12764B0 Offset: 0x1274EB0 VA: 0x1812764B0
	|-TlsOverPerCoreLockedStacksArrayPool<int>..ctor
	|
	|-RVA: 0x1276390 Offset: 0x1274D90 VA: 0x181276390
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270770 Offset: 0x126F170 VA: 0x181270770
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x1270820 Offset: 0x126F220 VA: 0x181270820
	|-TlsOverPerCoreLockedStacksArrayPool<char>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x1273900 Offset: 0x1272300 VA: 0x181273900
	|-TlsOverPerCoreLockedStacksArrayPool<int>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x1273850 Offset: 0x1272250 VA: 0x181273850
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.CreatePerCoreLockedStacks
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273600 Offset: 0x1272000 VA: 0x181273600
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<char>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<int>.get_Id
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270C90 Offset: 0x126F690 VA: 0x181270C90
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Rent
	|
	|-RVA: 0x12711F0 Offset: 0x126FBF0 VA: 0x1812711F0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Rent
	|
	|-RVA: 0x1273DA0 Offset: 0x12727A0 VA: 0x181273DA0
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Rent
	|
	|-RVA: 0x1274300 Offset: 0x1272D00 VA: 0x181274300
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1271750 Offset: 0x1270150 VA: 0x181271750
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Return
	|
	|-RVA: 0x1271CA0 Offset: 0x12706A0 VA: 0x181271CA0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Return
	|
	|-RVA: 0x1274C10 Offset: 0x1273610 VA: 0x181274C10
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Return
	|
	|-RVA: 0x12746D0 Offset: 0x12730D0 VA: 0x1812746D0
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public bool Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12721F0 Offset: 0x1270BF0 VA: 0x1812721F0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Trim
	|
	|-RVA: 0x1272A10 Offset: 0x1271410 VA: 0x181272A10
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Trim
	|
	|-RVA: 0x1275160 Offset: 0x1273B60 VA: 0x181275160
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Trim
	|
	|-RVA: 0x1275980 Offset: 0x1274380 VA: 0x181275980
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	private static bool Gen2GcCallbackFunc(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12708D0 Offset: 0x126F2D0 VA: 0x1812708D0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Gen2GcCallbackFunc
	|
	|-RVA: 0x12709E0 Offset: 0x126F3E0 VA: 0x1812709E0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Gen2GcCallbackFunc
	|
	|-RVA: 0x12739B0 Offset: 0x12723B0 VA: 0x1812739B0
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Gen2GcCallbackFunc
	|
	|-RVA: 0x1273AC0 Offset: 0x12724C0 VA: 0x181273AC0
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Gen2GcCallbackFunc
	*/

	// RVA: -1 Offset: -1
	private static TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> GetMemoryPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270BC0 Offset: 0x126F5C0 VA: 0x181270BC0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetMemoryPressure
	|
	|-RVA: 0x1270AF0 Offset: 0x126F4F0 VA: 0x181270AF0
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetMemoryPressure
	|
	|-RVA: 0x1273CD0 Offset: 0x12726D0 VA: 0x181273CD0
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetMemoryPressure
	|
	|-RVA: 0x1273C00 Offset: 0x1272600 VA: 0x181273C00
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetMemoryPressure
	*/

	// RVA: -1 Offset: -1
	private static bool GetTrimBuffers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetTrimBuffers
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetTrimBuffers
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1273230 Offset: 0x1271C30 VA: 0x181273230
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..cctor
	|-TlsOverPerCoreLockedStacksArrayPool<char>..cctor
	|-TlsOverPerCoreLockedStacksArrayPool<int>..cctor
	|
	|-RVA: 0x1276190 Offset: 0x1274B90 VA: 0x181276190
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}
