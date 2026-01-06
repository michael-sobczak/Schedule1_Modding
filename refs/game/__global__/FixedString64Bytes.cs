public struct FixedString64Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15823
{
	// Fields
	internal const ushort utf8MaxLengthInBytes = 61;
	[SerializeField]
	internal ushort utf8LengthInBytes; // 0x0
	[SerializeField]
	internal FixedBytes62 bytes; // 0x2

	// Properties
	public static int UTF8MaxLengthInBytes { get; }
	[CreateProperty]
	[EditorBrowsable(1)]
	[NotBurstCompatible]
	public string Value { get; }
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0x1FBDA70 Offset: 0x1FBC470 VA: 0x181FBDA70
	public static int get_UTF8MaxLengthInBytes() { }

	// RVA: 0x2726690 Offset: 0x2725090 VA: 0x182726690
	public string get_Value() { }

	// RVA: 0x271FAF0 Offset: 0x271E4F0 VA: 0x18271FAF0 Slot: 14
	public byte* GetUnsafePtr() { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	public int get_Length() { }

	// RVA: 0x2720880 Offset: 0x271F280 VA: 0x182720880 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x1FBDA70 Offset: 0x1FBC470 VA: 0x181FBDA70 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x27266D0 Offset: 0x27250D0 VA: 0x1827266D0 Slot: 15
	public bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	// RVA: 0x27202C0 Offset: 0x271ECC0 VA: 0x1827202C0 Slot: 13
	public bool get_IsEmpty() { }

	// RVA: 0x27202D0 Offset: 0x271ECD0 VA: 0x1827202D0 Slot: 7
	public byte get_Item(int index) { }

	// RVA: 0x2720870 Offset: 0x271F270 VA: 0x182720870 Slot: 8
	public void set_Item(int index, byte value) { }

	// RVA: 0x271F460 Offset: 0x271DE60 VA: 0x18271F460 Slot: 12
	public ref byte ElementAt(int index) { }

	// RVA: 0x271F260 Offset: 0x271DC60 VA: 0x18271F260 Slot: 9
	public void Clear() { }

	// RVA: 0x271EDB0 Offset: 0x271D7B0 VA: 0x18271EDB0
	public void Add(in byte value) { }

	// RVA: 0x2726160 Offset: 0x2724B60 VA: 0x182726160
	public FixedString64Bytes.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x2725A90 Offset: 0x2724490 VA: 0x182725A90 Slot: 16
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x2726080 Offset: 0x2724A80 VA: 0x182726080 Slot: 17
	public bool Equals(string other) { }

	// RVA: 0x2725510 Offset: 0x2723F10 VA: 0x182725510
	public ref FixedList64Bytes<byte> AsFixedList() { }

	[NotBurstCompatible]
	// RVA: 0x27267F0 Offset: 0x27251F0 VA: 0x1827267F0
	public void .ctor(string source) { }

	[NotBurstCompatible]
	// RVA: 0x2726300 Offset: 0x2724D00 VA: 0x182726300
	internal int Initialize(string source) { }

	// RVA: 0x2726880 Offset: 0x2725280 VA: 0x182726880
	public void .ctor(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2726290 Offset: 0x2724C90 VA: 0x182726290
	internal int Initialize(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2725AF0 Offset: 0x27244F0 VA: 0x182725AF0 Slot: 18
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x27267B0 Offset: 0x27251B0 VA: 0x1827267B0
	public void .ctor(in FixedString32Bytes other) { }

	// RVA: 0x2726450 Offset: 0x2724E50 VA: 0x182726450
	internal int Initialize(in FixedString32Bytes other) { }

	// RVA: 0x2726A40 Offset: 0x2725440 VA: 0x182726A40
	public static bool op_Equality(in FixedString64Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2726EA0 Offset: 0x27258A0 VA: 0x182726EA0
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2726020 Offset: 0x2724A20 VA: 0x182726020 Slot: 19
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x2725B40 Offset: 0x2724540 VA: 0x182725B40 Slot: 20
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x2726750 Offset: 0x2725150 VA: 0x182726750
	public void .ctor(in FixedString64Bytes other) { }

	// RVA: 0x27265D0 Offset: 0x2724FD0 VA: 0x1827265D0
	internal int Initialize(in FixedString64Bytes other) { }

	// RVA: 0x2726AE0 Offset: 0x27254E0 VA: 0x182726AE0
	public static bool op_Equality(in FixedString64Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2726E80 Offset: 0x2725880 VA: 0x182726E80
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2726060 Offset: 0x2724A60 VA: 0x182726060 Slot: 21
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x27259F0 Offset: 0x27243F0 VA: 0x1827259F0 Slot: 22
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2726770 Offset: 0x2725170 VA: 0x182726770
	public void .ctor(in FixedString128Bytes other) { }

	// RVA: 0x2726390 Offset: 0x2724D90 VA: 0x182726390
	internal int Initialize(in FixedString128Bytes other) { }

	// RVA: 0x27269A0 Offset: 0x27253A0 VA: 0x1827269A0
	public static bool op_Equality(in FixedString64Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2726E40 Offset: 0x2725840 VA: 0x182726E40
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2726040 Offset: 0x2724A40 VA: 0x182726040 Slot: 23
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2726DE0 Offset: 0x27257E0 VA: 0x182726DE0
	public static FixedString128Bytes op_Implicit(in FixedString64Bytes fs) { }

	// RVA: 0x27259A0 Offset: 0x27243A0 VA: 0x1827259A0 Slot: 24
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2726790 Offset: 0x2725190 VA: 0x182726790
	public void .ctor(in FixedString512Bytes other) { }

	// RVA: 0x27261D0 Offset: 0x2724BD0 VA: 0x1827261D0
	internal int Initialize(in FixedString512Bytes other) { }

	// RVA: 0x2726900 Offset: 0x2725300 VA: 0x182726900
	public static bool op_Equality(in FixedString64Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2726E20 Offset: 0x2725820 VA: 0x182726E20
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2726120 Offset: 0x2724B20 VA: 0x182726120 Slot: 25
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2726DA0 Offset: 0x27257A0 VA: 0x182726DA0
	public static FixedString512Bytes op_Implicit(in FixedString64Bytes fs) { }

	// RVA: 0x2725A40 Offset: 0x2724440 VA: 0x182725A40 Slot: 26
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x27267D0 Offset: 0x27251D0 VA: 0x1827267D0
	public void .ctor(in FixedString4096Bytes other) { }

	// RVA: 0x2726510 Offset: 0x2724F10 VA: 0x182726510
	internal int Initialize(in FixedString4096Bytes other) { }

	// RVA: 0x2726B80 Offset: 0x2725580 VA: 0x182726B80
	public static bool op_Equality(in FixedString64Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2726E60 Offset: 0x2725860 VA: 0x182726E60
	public static bool op_Inequality(in FixedString64Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2726140 Offset: 0x2724B40 VA: 0x182726140 Slot: 27
	public bool Equals(FixedString4096Bytes other) { }

	// RVA: 0x2726C20 Offset: 0x2725620 VA: 0x182726C20
	public static FixedString4096Bytes op_Implicit(in FixedString64Bytes fs) { }

	[NotBurstCompatible]
	// RVA: 0x2726D10 Offset: 0x2725710 VA: 0x182726D10
	public static FixedString64Bytes op_Implicit(string b) { }

	[NotBurstCompatible]
	// RVA: 0x2726690 Offset: 0x2725090 VA: 0x182726690 Slot: 3
	public override string ToString() { }

	// RVA: 0x2726190 Offset: 0x2724B90 VA: 0x182726190 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x2725B90 Offset: 0x2724590 VA: 0x182725B90 Slot: 0
	public override bool Equals(object obj) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2725710 Offset: 0x2724110 VA: 0x182725710
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2725860 Offset: 0x2724260 VA: 0x182725860
	private void CheckLengthInRange(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2725540 Offset: 0x2723F40 VA: 0x182725540
	private void CheckCapacityInRange(int capacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2725610 Offset: 0x2724010 VA: 0x182725610
	private static void CheckCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27256B0 Offset: 0x27240B0 VA: 0x1827256B0
	private static void CheckFormatError(FormatError error) { }
}
