public struct UnsafeAppendBuffer : INativeDisposable, IDisposable // TypeDefIndex: 15959
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public byte* Ptr; // 0x0
	public int Length; // 0x8
	public int Capacity; // 0xC
	public AllocatorManager.AllocatorHandle Allocator; // 0x10
	public readonly int Alignment; // 0x14

	// Properties
	public bool IsEmpty { get; }
	public bool IsCreated { get; }

	// Methods

	// RVA: 0x273E6E0 Offset: 0x273D0E0 VA: 0x18273E6E0
	public void .ctor(int initialCapacity, int alignment, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x273E650 Offset: 0x273D050 VA: 0x18273E650
	public void .ctor(void* ptr, int length) { }

	// RVA: 0x11A0B10 Offset: 0x119F510 VA: 0x1811A0B10
	public bool get_IsEmpty() { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x273E360 Offset: 0x273CD60 VA: 0x18273E360 Slot: 5
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x273E3F0 Offset: 0x273CDF0 VA: 0x18273E3F0 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x12D8CE0 Offset: 0x12D76E0 VA: 0x1812D8CE0
	public void Reset() { }

	// RVA: 0x273E560 Offset: 0x273CF60 VA: 0x18273E560
	public void SetCapacity(int capacity) { }

	// RVA: 0x273E530 Offset: 0x273CF30 VA: 0x18273E530
	public void ResizeUninitialized(int length) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF686A0 Offset: 0xF670A0 VA: 0x180F686A0
	|-UnsafeAppendBuffer.Add<int>
	|
	|-RVA: 0xF685D0 Offset: 0xF66FD0 VA: 0x180F685D0
	|-UnsafeAppendBuffer.Add<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x273E230 Offset: 0x273CC30 VA: 0x18273E230
	public void Add(void* ptr, int structSize) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void AddArray<T>(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68460 Offset: 0xF66E60 VA: 0x180F68460
	|-UnsafeAppendBuffer.AddArray<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void Add<T>(NativeArray<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF684F0 Offset: 0xF66EF0 VA: 0x180F684F0
	|-UnsafeAppendBuffer.Add<__Il2CppFullySharedGenericStructType>
	*/

	[Obsolete("Please use `AddNBC` from `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", False)]
	[NotBurstCompatible]
	// RVA: 0x273E280 Offset: 0x273CC80 VA: 0x18273E280
	public void Add(string value) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public T Pop<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF68750 Offset: 0xF67150 VA: 0x180F68750
	|-UnsafeAppendBuffer.Pop<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x273E4F0 Offset: 0x273CEF0 VA: 0x18273E4F0
	public void Pop(void* ptr, int structSize) { }

	[NotBurstCompatible]
	[Obsolete("Please use `ToBytesNBC` from `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", False)]
	// RVA: 0x273E640 Offset: 0x273D040 VA: 0x18273E640
	public byte[] ToBytes() { }

	// RVA: 0x273E290 Offset: 0x273CC90 VA: 0x18273E290
	public UnsafeAppendBuffer.Reader AsReader() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273E2B0 Offset: 0x273CCB0 VA: 0x18273E2B0
	private static void CheckAlignment(int alignment) { }
}
