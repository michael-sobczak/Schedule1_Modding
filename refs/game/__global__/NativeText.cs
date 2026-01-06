public struct NativeText : INativeList<byte>, IIndexable<byte>, INativeDisposable, IDisposable, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15902
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	private UnsafeText* m_Data; // 0x0

	// Properties
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public bool IsCreated { get; }
	public byte Item { get; set; }
	[EditorBrowsable(1)]
	[CreateProperty]
	[NotBurstCompatible]
	public string Value { get; }

	// Methods

	[NotBurstCompatible]
	// RVA: 0x27389B0 Offset: 0x27373B0 VA: 0x1827389B0
	public void .ctor(string source, Allocator allocator) { }

	[NotBurstCompatible]
	// RVA: 0x2738B90 Offset: 0x2737590 VA: 0x182738B90
	public void .ctor(string source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738CE0 Offset: 0x27376E0 VA: 0x182738CE0
	private void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) { }

	// RVA: 0x2738660 Offset: 0x2737060 VA: 0x182738660
	public void .ctor(int capacity, Allocator allocator) { }

	// RVA: 0x27389F0 Offset: 0x27373F0 VA: 0x1827389F0
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738620 Offset: 0x2737020 VA: 0x182738620
	public void .ctor(Allocator allocator) { }

	// RVA: 0x27386A0 Offset: 0x27370A0 VA: 0x1827386A0
	public void .ctor(AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x27386D0 Offset: 0x27370D0 VA: 0x1827386D0
	public void .ctor(in FixedString32Bytes source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738770 Offset: 0x2737170 VA: 0x182738770
	public void .ctor(in FixedString32Bytes source, Allocator allocator) { }

	// RVA: 0x2738A10 Offset: 0x2737410 VA: 0x182738A10
	public void .ctor(in FixedString64Bytes source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x27388D0 Offset: 0x27372D0 VA: 0x1827388D0
	public void .ctor(in FixedString64Bytes source, Allocator allocator) { }

	// RVA: 0x27387B0 Offset: 0x27371B0 VA: 0x1827387B0
	public void .ctor(in FixedString128Bytes source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738AB0 Offset: 0x27374B0 VA: 0x182738AB0
	public void .ctor(in FixedString128Bytes source, Allocator allocator) { }

	// RVA: 0x2738AF0 Offset: 0x27374F0 VA: 0x182738AF0
	public void .ctor(in FixedString512Bytes source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738850 Offset: 0x2737250 VA: 0x182738850
	public void .ctor(in FixedString512Bytes source, Allocator allocator) { }

	// RVA: 0x2738910 Offset: 0x2737310 VA: 0x182738910
	public void .ctor(in FixedString4096Bytes source, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2738890 Offset: 0x2737290 VA: 0x182738890
	public void .ctor(in FixedString4096Bytes source, Allocator allocator) { }

	// RVA: 0x2738E00 Offset: 0x2737800 VA: 0x182738E00 Slot: 10
	public int get_Length() { }

	// RVA: 0x27392A0 Offset: 0x2737CA0 VA: 0x1827392A0 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x2738DB0 Offset: 0x27377B0 VA: 0x182738DB0 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x2739270 Offset: 0x2737C70 VA: 0x182739270 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x2738600 Offset: 0x2737000 VA: 0x182738600 Slot: 17
	public bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	// RVA: 0x2738DC0 Offset: 0x27377C0 VA: 0x182738DC0 Slot: 15
	public bool get_IsEmpty() { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_IsCreated() { }

	// RVA: 0x2738500 Offset: 0x2736F00 VA: 0x182738500 Slot: 16
	public byte* GetUnsafePtr() { }

	// RVA: 0x2738DE0 Offset: 0x27377E0 VA: 0x182738DE0 Slot: 7
	public byte get_Item(int index) { }

	// RVA: 0x2739280 Offset: 0x2737C80 VA: 0x182739280 Slot: 8
	public void set_Item(int index, byte value) { }

	// RVA: 0x2737EC0 Offset: 0x27368C0 VA: 0x182737EC0 Slot: 12
	public ref byte ElementAt(int index) { }

	// RVA: 0x2737B30 Offset: 0x2736530 VA: 0x182737B30 Slot: 9
	public void Clear() { }

	// RVA: 0x2737910 Offset: 0x2736310 VA: 0x182737910
	public void Add(in byte value) { }

	// RVA: 0x2737D00 Offset: 0x2736700 VA: 0x182737D00 Slot: 20
	public int CompareTo(NativeText other) { }

	// RVA: 0x2737F20 Offset: 0x2736920 VA: 0x182737F20 Slot: 21
	public bool Equals(NativeText other) { }

	// RVA: 0x2737DA0 Offset: 0x27367A0 VA: 0x182737DA0
	public int CompareTo(NativeText.ReadOnly other) { }

	// RVA: 0x2737ED0 Offset: 0x27368D0 VA: 0x182737ED0
	public bool Equals(NativeText.ReadOnly other) { }

	// RVA: 0x2737E30 Offset: 0x2736830 VA: 0x182737E30 Slot: 14
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x2737DF0 Offset: 0x27367F0 VA: 0x182737DF0 Slot: 13
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x27385A0 Offset: 0x2736FA0 VA: 0x1827385A0
	public string get_Value() { }

	// RVA: 0x2710470 Offset: 0x270EE70 VA: 0x182710470
	public NativeText.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x2737B40 Offset: 0x2736540 VA: 0x182737B40 Slot: 18
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x27383E0 Offset: 0x2736DE0 VA: 0x1827383E0 Slot: 19
	public bool Equals(string other) { }

	// RVA: 0x2737BC0 Offset: 0x27365C0 VA: 0x182737BC0 Slot: 22
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2738E10 Offset: 0x2737810 VA: 0x182738E10
	public static bool op_Equality(in NativeText a, in FixedString32Bytes b) { }

	// RVA: 0x2739210 Offset: 0x2737C10 VA: 0x182739210
	public static bool op_Inequality(in NativeText a, in FixedString32Bytes b) { }

	// RVA: 0x2738460 Offset: 0x2736E60 VA: 0x182738460 Slot: 23
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x2737D50 Offset: 0x2736750 VA: 0x182737D50 Slot: 24
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x2739050 Offset: 0x2737A50 VA: 0x182739050
	public static bool op_Equality(in NativeText a, in FixedString64Bytes b) { }

	// RVA: 0x27391D0 Offset: 0x2737BD0 VA: 0x1827391D0
	public static bool op_Inequality(in NativeText a, in FixedString64Bytes b) { }

	// RVA: 0x27384A0 Offset: 0x2736EA0 VA: 0x1827384A0 Slot: 25
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x2737CB0 Offset: 0x27366B0 VA: 0x182737CB0 Slot: 26
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2738F90 Offset: 0x2737990 VA: 0x182738F90
	public static bool op_Equality(in NativeText a, in FixedString128Bytes b) { }

	// RVA: 0x2739250 Offset: 0x2737C50 VA: 0x182739250
	public static bool op_Inequality(in NativeText a, in FixedString128Bytes b) { }

	// RVA: 0x27383C0 Offset: 0x2736DC0 VA: 0x1827383C0 Slot: 27
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2737C10 Offset: 0x2736610 VA: 0x182737C10 Slot: 28
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2739110 Offset: 0x2737B10 VA: 0x182739110
	public static bool op_Equality(in NativeText a, in FixedString512Bytes b) { }

	// RVA: 0x2739230 Offset: 0x2737C30 VA: 0x182739230
	public static bool op_Inequality(in NativeText a, in FixedString512Bytes b) { }

	// RVA: 0x2738480 Offset: 0x2736E80 VA: 0x182738480 Slot: 29
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2737C60 Offset: 0x2736660 VA: 0x182737C60 Slot: 30
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x2738ED0 Offset: 0x27378D0 VA: 0x182738ED0
	public static bool op_Equality(in NativeText a, in FixedString4096Bytes b) { }

	// RVA: 0x27391F0 Offset: 0x2737BF0 VA: 0x1827391F0
	public static bool op_Inequality(in NativeText a, in FixedString4096Bytes b) { }

	// RVA: 0x27383A0 Offset: 0x2736DA0 VA: 0x1827383A0 Slot: 31
	public bool Equals(FixedString4096Bytes other) { }

	[NotBurstCompatible]
	// RVA: 0x27385A0 Offset: 0x2736FA0 VA: 0x1827385A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x27384C0 Offset: 0x2736EC0 VA: 0x1827384C0 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x2737F70 Offset: 0x2736970 VA: 0x182737F70 Slot: 0
	public override bool Equals(object other) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2737AD0 Offset: 0x27364D0 VA: 0x182737AD0
	internal static void CheckNull(void* dataPtr) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckRead() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckWrite() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void CheckWriteAndBumpSecondaryVersion() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2737970 Offset: 0x2736370 VA: 0x182737970
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2738510 Offset: 0x2736F10 VA: 0x182738510
	private void ThrowCopyError(CopyError error, string source) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public NativeText.ReadOnly AsReadOnly() { }
}
