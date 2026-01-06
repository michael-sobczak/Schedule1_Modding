public struct UnsafeStream : INativeDisposable, IDisposable // TypeDefIndex: 16014
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeStreamBlockData* m_Block; // 0x0
	internal AllocatorManager.AllocatorHandle m_Allocator; // 0x8

	// Properties
	public bool IsCreated { get; }
	public int ForEachCount { get; }

	// Methods

	// RVA: 0x27378B0 Offset: 0x27362B0 VA: 0x1827378B0
	public void .ctor(int bufferCount, AllocatorManager.AllocatorHandle allocator) { }

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public static JobHandle ScheduleConstruct<T>(out UnsafeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C2B0 Offset: 0xF6ACB0 VA: 0x180F6C2B0
	|-UnsafeStream.ScheduleConstruct<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	// RVA: 0x2742A00 Offset: 0x2741400 VA: 0x182742A00
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeArray<int> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x27425E0 Offset: 0x2740FE0 VA: 0x1827425E0
	internal static void AllocateBlock(out UnsafeStream stream, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2742710 Offset: 0x2741110 VA: 0x182742710
	internal void AllocateForEach(int forEachCount) { }

	// RVA: 0x27429A0 Offset: 0x27413A0 VA: 0x1827429A0
	public bool IsEmpty() { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x27378F0 Offset: 0x27362F0 VA: 0x1827378F0
	public int get_ForEachCount() { }

	// RVA: 0x2742840 Offset: 0x2741240 VA: 0x182742840
	public UnsafeStream.Reader AsReader() { }

	// RVA: 0x2742860 Offset: 0x2741260 VA: 0x182742860
	public UnsafeStream.Writer AsWriter() { }

	// RVA: 0x27376A0 Offset: 0x27360A0 VA: 0x1827376A0
	public int Count() { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray<T>(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C3A0 Offset: 0xF6ADA0 VA: 0x180F6C3A0
	|-UnsafeStream.ToNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2742890 Offset: 0x2741290 VA: 0x182742890
	private void Deallocate() { }

	// RVA: 0x2733140 Offset: 0x2731B40 VA: 0x182733140 Slot: 5
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x2737700 Offset: 0x2736100 VA: 0x182737700 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
}
