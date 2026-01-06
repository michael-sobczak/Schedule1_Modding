public struct HeapString : INativeList<byte>, IIndexable<byte>, IDisposable, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<HeapString>, IEquatable<HeapString>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15842
{
	// Fields
	private NativeList<byte> m_Data; // 0x0

	// Properties
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public bool IsCreated { get; }
	public byte Item { get; set; }
	[CreateProperty]
	[EditorBrowsable(1)]
	[NotBurstCompatible]
	public string Value { get; }

	// Methods

	// RVA: 0x2735C00 Offset: 0x2734600 VA: 0x182735C00 Slot: 10
	public int get_Length() { }

	// RVA: 0x2736340 Offset: 0x2734D40 VA: 0x182736340 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x2735AF0 Offset: 0x27344F0 VA: 0x182735AF0 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x2736290 Offset: 0x2734C90 VA: 0x182736290 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x2735100 Offset: 0x2733B00 VA: 0x182735100 Slot: 16
	public bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	// RVA: 0x2735B70 Offset: 0x2734570 VA: 0x182735B70 Slot: 14
	public bool get_IsEmpty() { }

	// RVA: 0x2735B30 Offset: 0x2734530 VA: 0x182735B30
	public bool get_IsCreated() { }

	// RVA: 0x2734FA0 Offset: 0x27339A0 VA: 0x182734FA0 Slot: 15
	public byte* GetUnsafePtr() { }

	// RVA: 0x2735BB0 Offset: 0x27345B0 VA: 0x182735BB0 Slot: 7
	public byte get_Item(int index) { }

	// RVA: 0x27362E0 Offset: 0x2734CE0 VA: 0x1827362E0 Slot: 8
	public void set_Item(int index, byte value) { }

	// RVA: 0x27349C0 Offset: 0x27333C0 VA: 0x1827349C0 Slot: 12
	public ref byte ElementAt(int index) { }

	// RVA: 0x2734700 Offset: 0x2733100 VA: 0x182734700 Slot: 9
	public void Clear() { }

	// RVA: 0x27344A0 Offset: 0x2732EA0 VA: 0x1827344A0
	public void Add(in byte value) { }

	// RVA: 0x2734770 Offset: 0x2733170 VA: 0x182734770 Slot: 19
	public int CompareTo(HeapString other) { }

	// RVA: 0x2734A70 Offset: 0x2733470 VA: 0x182734A70 Slot: 20
	public bool Equals(HeapString other) { }

	// RVA: 0x2734980 Offset: 0x2733380 VA: 0x182734980 Slot: 13
	public void Dispose() { }

	// RVA: 0x2735C40 Offset: 0x2734640 VA: 0x182735C40
	public string get_Value() { }

	// RVA: 0x2734F40 Offset: 0x2733940 VA: 0x182734F40
	public HeapString.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x2734950 Offset: 0x2733350 VA: 0x182734950 Slot: 17
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x2734AE0 Offset: 0x27334E0 VA: 0x182734AE0 Slot: 18
	public bool Equals(string other) { }

	[NotBurstCompatible]
	// RVA: 0x2735700 Offset: 0x2734100 VA: 0x182735700
	public void .ctor(string source, Allocator allocator) { }

	// RVA: 0x27352A0 Offset: 0x2733CA0 VA: 0x1827352A0
	public void .ctor(int capacity, Allocator allocator) { }

	// RVA: 0x2735900 Offset: 0x2734300 VA: 0x182735900
	public void .ctor(Allocator allocator) { }

	// RVA: 0x27348B0 Offset: 0x27332B0 VA: 0x1827348B0 Slot: 21
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2735170 Offset: 0x2733B70 VA: 0x182735170
	public void .ctor(in FixedString32Bytes source, Allocator allocator) { }

	// RVA: 0x27360D0 Offset: 0x2734AD0 VA: 0x1827360D0
	public static bool op_Equality(in HeapString a, in FixedString32Bytes b) { }

	// RVA: 0x2736210 Offset: 0x2734C10 VA: 0x182736210
	public static bool op_Inequality(in HeapString a, in FixedString32Bytes b) { }

	// RVA: 0x2734AC0 Offset: 0x27334C0 VA: 0x182734AC0 Slot: 22
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x2734860 Offset: 0x2733260 VA: 0x182734860 Slot: 23
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x27359C0 Offset: 0x27343C0 VA: 0x1827359C0
	public void .ctor(in FixedString64Bytes source, Allocator allocator) { }

	// RVA: 0x2735D70 Offset: 0x2734770 VA: 0x182735D70
	public static bool op_Equality(in HeapString a, in FixedString64Bytes b) { }

	// RVA: 0x27361F0 Offset: 0x2734BF0 VA: 0x1827361F0
	public static bool op_Inequality(in HeapString a, in FixedString64Bytes b) { }

	// RVA: 0x2734A50 Offset: 0x2733450 VA: 0x182734A50 Slot: 24
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x27347C0 Offset: 0x27331C0 VA: 0x1827347C0 Slot: 25
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x27355D0 Offset: 0x2733FD0 VA: 0x1827355D0
	public void .ctor(in FixedString128Bytes source, Allocator allocator) { }

	// RVA: 0x2735C50 Offset: 0x2734650 VA: 0x182735C50
	public static bool op_Equality(in HeapString a, in FixedString128Bytes b) { }

	// RVA: 0x2736270 Offset: 0x2734C70 VA: 0x182736270
	public static bool op_Inequality(in HeapString a, in FixedString128Bytes b) { }

	// RVA: 0x2734A10 Offset: 0x2733410 VA: 0x182734A10 Slot: 26
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2734810 Offset: 0x2733210 VA: 0x182734810 Slot: 27
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2735370 Offset: 0x2733D70 VA: 0x182735370
	public void .ctor(in FixedString512Bytes source, Allocator allocator) { }

	// RVA: 0x2735FB0 Offset: 0x27349B0 VA: 0x182735FB0
	public static bool op_Equality(in HeapString a, in FixedString512Bytes b) { }

	// RVA: 0x2736250 Offset: 0x2734C50 VA: 0x182736250
	public static bool op_Inequality(in HeapString a, in FixedString512Bytes b) { }

	// RVA: 0x2734F20 Offset: 0x2733920 VA: 0x182734F20 Slot: 28
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2734900 Offset: 0x2733300 VA: 0x182734900 Slot: 29
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x27354A0 Offset: 0x2733EA0 VA: 0x1827354A0
	public void .ctor(in FixedString4096Bytes source, Allocator allocator) { }

	// RVA: 0x2735E90 Offset: 0x2734890 VA: 0x182735E90
	public static bool op_Equality(in HeapString a, in FixedString4096Bytes b) { }

	// RVA: 0x2736230 Offset: 0x2734C30 VA: 0x182736230
	public static bool op_Inequality(in HeapString a, in FixedString4096Bytes b) { }

	// RVA: 0x2734A30 Offset: 0x2733430 VA: 0x182734A30 Slot: 30
	public bool Equals(FixedString4096Bytes other) { }

	[NotBurstCompatible]
	// RVA: 0x2735080 Offset: 0x2733A80 VA: 0x182735080 Slot: 3
	public override string ToString() { }

	// RVA: 0x2734F60 Offset: 0x2733960 VA: 0x182734F60 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x2734B10 Offset: 0x2733510 VA: 0x182734B10 Slot: 0
	public override bool Equals(object other) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2734580 Offset: 0x2732F80 VA: 0x182734580
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2734FF0 Offset: 0x27339F0 VA: 0x182734FF0
	private void ThrowCopyError(CopyError error, string source) { }
}
