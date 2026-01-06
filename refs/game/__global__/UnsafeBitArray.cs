public struct UnsafeBitArray : INativeDisposable, IDisposable // TypeDefIndex: 15962
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public ulong* Ptr; // 0x0
	public int Length; // 0x8
	public AllocatorManager.AllocatorHandle Allocator; // 0xC

	// Properties
	public bool IsCreated { get; }

	// Methods

	// RVA: 0x273FE10 Offset: 0x273E810 VA: 0x18273FE10
	public void .ctor(void* ptr, int sizeInBytes, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x273FE30 Offset: 0x273E830 VA: 0x18273FE30
	public void .ctor(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x273F720 Offset: 0x273E120 VA: 0x18273F720 Slot: 5
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x273F7B0 Offset: 0x273E1B0 VA: 0x18273F7B0 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x2736780 Offset: 0x2735180 VA: 0x182736780
	public void Clear() { }

	// RVA: 0x2736900 Offset: 0x2735300 VA: 0x182736900
	public void Set(int pos, bool value) { }

	// RVA: 0x273FAB0 Offset: 0x273E4B0 VA: 0x18273FAB0
	public void SetBits(int pos, bool value, int numBits) { }

	// RVA: 0x273F9A0 Offset: 0x273E3A0 VA: 0x18273F9A0
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	// RVA: 0x273F8B0 Offset: 0x273E2B0 VA: 0x18273F8B0
	public ulong GetBits(int pos, int numBits = 1) { }

	// RVA: 0x27368C0 Offset: 0x27352C0 VA: 0x1827368C0
	public bool IsSet(int pos) { }

	// RVA: 0x273F270 Offset: 0x273DC70 VA: 0x18273F270
	internal void CopyUlong(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	// RVA: 0x27367D0 Offset: 0x27351D0 VA: 0x1827367D0
	public void Copy(int dstPos, int srcPos, int numBits) { }

	// RVA: 0x273F2C0 Offset: 0x273DCC0 VA: 0x18273F2C0
	public void Copy(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	// RVA: 0x2736860 Offset: 0x2735260 VA: 0x182736860
	public int Find(int pos, int numBits) { }

	// RVA: 0x2736890 Offset: 0x2735290 VA: 0x182736890
	public int Find(int pos, int count, int numBits) { }

	// RVA: 0x273FD50 Offset: 0x273E750 VA: 0x18273FD50
	public bool TestNone(int pos, int numBits = 1) { }

	// RVA: 0x273FC90 Offset: 0x273E690 VA: 0x18273FC90
	public bool TestAny(int pos, int numBits = 1) { }

	// RVA: 0x273FBC0 Offset: 0x273E5C0 VA: 0x18273FBC0
	public bool TestAll(int pos, int numBits = 1) { }

	// RVA: 0x273F550 Offset: 0x273DF50 VA: 0x18273F550
	public int CountBits(int pos, int numBits = 1) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273F1B0 Offset: 0x273DBB0 VA: 0x18273F1B0
	private static void CheckSizeMultipleOf8(int sizeInBytes) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273F0A0 Offset: 0x273DAA0 VA: 0x18273F0A0
	private void CheckArgs(int pos, int numBits) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273ED00 Offset: 0x273D700 VA: 0x18273ED00
	private void CheckArgsPosCount(int begin, int count, int numBits) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273EF10 Offset: 0x273D910 VA: 0x18273EF10
	private void CheckArgsUlong(int pos, int numBits) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x273EB20 Offset: 0x273D520 VA: 0x18273EB20
	private static void CheckArgsCopy(ref UnsafeBitArray dstBitArray, int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }
}
