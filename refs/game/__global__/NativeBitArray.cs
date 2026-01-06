public struct NativeBitArray : INativeDisposable, IDisposable // TypeDefIndex: 15850
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeBitArray m_BitArray; // 0x0

	// Properties
	public bool IsCreated { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x27369B0 Offset: 0x27353B0 VA: 0x1827369B0
	public void .ctor(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	// RVA: 0x27369B0 Offset: 0x27353B0 VA: 0x1827369B0
	private void .ctor(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options, int disposeSentinelStackDepth) { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x2736850 Offset: 0x2735250 VA: 0x182736850 Slot: 5
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x2736810 Offset: 0x2735210 VA: 0x182736810 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x12D98B0 Offset: 0x12D82B0 VA: 0x1812D98B0
	public int get_Length() { }

	// RVA: 0x2736780 Offset: 0x2735180 VA: 0x182736780
	public void Clear() { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public NativeArray<T> AsNativeArray<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF098F0 Offset: 0xF082F0 VA: 0x180F098F0
	|-NativeBitArray.AsNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2736900 Offset: 0x2735300 VA: 0x182736900
	public void Set(int pos, bool value) { }

	// RVA: 0x27368E0 Offset: 0x27352E0 VA: 0x1827368E0
	public void SetBits(int pos, bool value, int numBits) { }

	// RVA: 0x27368F0 Offset: 0x27352F0 VA: 0x1827368F0
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	// RVA: 0x27368B0 Offset: 0x27352B0 VA: 0x1827368B0
	public ulong GetBits(int pos, int numBits = 1) { }

	// RVA: 0x27368C0 Offset: 0x27352C0 VA: 0x1827368C0
	public bool IsSet(int pos) { }

	// RVA: 0x27367D0 Offset: 0x27351D0 VA: 0x1827367D0
	public void Copy(int dstPos, int srcPos, int numBits) { }

	// RVA: 0x27367C0 Offset: 0x27351C0 VA: 0x1827367C0
	public void Copy(int dstPos, ref NativeBitArray srcBitArray, int srcPos, int numBits) { }

	// RVA: 0x2736860 Offset: 0x2735260 VA: 0x182736860
	public int Find(int pos, int numBits) { }

	// RVA: 0x2736890 Offset: 0x2735290 VA: 0x182736890
	public int Find(int pos, int count, int numBits) { }

	// RVA: 0x27369A0 Offset: 0x27353A0 VA: 0x1827369A0
	public bool TestNone(int pos, int numBits = 1) { }

	// RVA: 0x2736990 Offset: 0x2735390 VA: 0x182736990
	public bool TestAny(int pos, int numBits = 1) { }

	// RVA: 0x2736980 Offset: 0x2735380 VA: 0x182736980
	public bool TestAll(int pos, int numBits = 1) { }

	// RVA: 0x2736800 Offset: 0x2735200 VA: 0x182736800
	public int CountBits(int pos, int numBits = 1) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckRead() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckReadBounds<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09970 Offset: 0xF08370 VA: 0x180F09970
	|-NativeBitArray.CheckReadBounds<__Il2CppFullySharedGenericStructType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckWrite() { }
}
