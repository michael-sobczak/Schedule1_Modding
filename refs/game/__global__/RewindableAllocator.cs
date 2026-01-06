public struct RewindableAllocator : AllocatorManager.IAllocator, IDisposable // TypeDefIndex: 15908
{
	// Fields
	private Spinner m_spinner; // 0x0
	private AllocatorManager.AllocatorHandle m_handle; // 0x4
	private UnmanagedArray<RewindableAllocator.MemoryBlock> m_block; // 0x8
	private int m_best; // 0x18
	private int m_last; // 0x1C
	private int m_used; // 0x20
	private bool m_enableBlockFree; // 0x24

	// Properties
	public bool EnableBlockFree { get; set; }
	public int BlocksAllocated { get; }
	public int InitialSizeInBytes { get; }
	[NotBurstCompatible]
	public AllocatorManager.TryFunction Function { get; }
	public AllocatorManager.AllocatorHandle Handle { get; set; }
	public Allocator ToAllocator { get; }
	public bool IsCustomAllocator { get; }

	// Methods

	// RVA: 0x273AA10 Offset: 0x2739410 VA: 0x18273AA10
	public void Initialize(int initialSizeInBytes, bool enableBlockFree = False) { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_EnableBlockFree() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_EnableBlockFree(bool value) { }

	// RVA: 0x1E45DF0 Offset: 0x1E447F0 VA: 0x181E45DF0
	public int get_BlocksAllocated() { }

	// RVA: 0x273B270 Offset: 0x2739C70 VA: 0x18273B270
	public int get_InitialSizeInBytes() { }

	// RVA: 0x273AB00 Offset: 0x2739500 VA: 0x18273AB00
	public void Rewind() { }

	// RVA: 0x273A8D0 Offset: 0x27392D0 VA: 0x18273A8D0 Slot: 10
	public void Dispose() { }

	// RVA: 0x273B210 Offset: 0x2739C10 VA: 0x18273B210 Slot: 4
	public AllocatorManager.TryFunction get_Function() { }

	// RVA: 0x273ACB0 Offset: 0x27396B0 VA: 0x18273ACB0 Slot: 5
	public int Try(ref AllocatorManager.Block block) { }

	[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
	[BurstCompile]
	// RVA: 0x273AFE0 Offset: 0x27399E0 VA: 0x18273AFE0
	internal static int Try(IntPtr state, ref AllocatorManager.Block block) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590 Slot: 6
	public AllocatorManager.AllocatorHandle get_Handle() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0 Slot: 7
	public void set_Handle(AllocatorManager.AllocatorHandle value) { }

	// RVA: 0x273B2C0 Offset: 0x2739CC0 VA: 0x18273B2C0 Slot: 8
	public Allocator get_ToAllocator() { }

	// RVA: 0x273B2B0 Offset: 0x2739CB0 VA: 0x18273B2B0 Slot: 9
	public bool get_IsCustomAllocator() { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public NativeArray<T> AllocateNativeArray<T>(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF328F0 Offset: 0xF312F0 VA: 0x180F328F0
	|-RewindableAllocator.AllocateNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public NativeList<T> AllocateNativeList<T>(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32A40 Offset: 0xF31440 VA: 0x180F32A40
	|-RewindableAllocator.AllocateNativeList<__Il2CppFullySharedGenericStructType>
	*/

	[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
	[BurstCompile]
	// RVA: 0x273AC80 Offset: 0x2739680 VA: 0x18273AC80
	public static int Try$BurstManaged(IntPtr state, ref AllocatorManager.Block block) { }
}
