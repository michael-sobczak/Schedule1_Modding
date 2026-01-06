public struct NativeStream : IDisposable // TypeDefIndex: 15899
{
	// Fields
	private UnsafeStream m_Stream; // 0x0

	// Properties
	public bool IsCreated { get; }
	public int ForEachCount { get; }

	// Methods

	// RVA: 0x27378B0 Offset: 0x27362B0 VA: 0x1827378B0
	public void .ctor(int bufferCount, AllocatorManager.AllocatorHandle allocator) { }

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleConstruct<T>(out NativeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E1D0 Offset: 0xF0CBD0 VA: 0x180F0E1D0
	|-NativeStream.ScheduleConstruct<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	// RVA: 0x27377F0 Offset: 0x27361F0 VA: 0x1827377F0
	public static JobHandle ScheduleConstruct(out NativeStream stream, NativeArray<int> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2737790 Offset: 0x2736190 VA: 0x182737790
	public bool IsEmpty() { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x27378F0 Offset: 0x27362F0 VA: 0x1827378F0
	public int get_ForEachCount() { }

	// RVA: 0x2737570 Offset: 0x2735F70 VA: 0x182737570
	public NativeStream.Reader AsReader() { }

	// RVA: 0x27375C0 Offset: 0x2735FC0 VA: 0x1827375C0
	public NativeStream.Writer AsWriter() { }

	// RVA: 0x27376A0 Offset: 0x27360A0 VA: 0x1827376A0
	public int Count() { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray<T>(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E2C0 Offset: 0xF0CCC0 VA: 0x180F0E2C0
	|-NativeStream.ToNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2733140 Offset: 0x2731B40 VA: 0x182733140 Slot: 4
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x2737700 Offset: 0x2736100 VA: 0x182737700
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x2737550 Offset: 0x2735F50 VA: 0x182737550
	private static void AllocateBlock(out NativeStream stream, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2737560 Offset: 0x2735F60 VA: 0x182737560
	private void AllocateForEach(int forEachCount) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2737620 Offset: 0x2736020 VA: 0x182737620
	private static void CheckForEachCountGreaterThanZero(int forEachCount) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckReadAccess() { }
}
