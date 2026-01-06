public struct FixedString32Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15819
{
	// Fields
	internal const ushort utf8MaxLengthInBytes = 29;
	[SerializeField]
	internal ushort utf8LengthInBytes; // 0x0
	[SerializeField]
	internal FixedBytes30 bytes; // 0x2

	// Properties
	public static int UTF8MaxLengthInBytes { get; }
	[NotBurstCompatible]
	[EditorBrowsable(1)]
	[CreateProperty]
	public string Value { get; }
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0xF72990 Offset: 0xF71390 VA: 0x180F72990
	public static int get_UTF8MaxLengthInBytes() { }

	// RVA: 0x27219A0 Offset: 0x27203A0 VA: 0x1827219A0
	public string get_Value() { }

	// RVA: 0x271FAF0 Offset: 0x271E4F0 VA: 0x18271FAF0 Slot: 14
	public byte* GetUnsafePtr() { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	public int get_Length() { }

	// RVA: 0x2720880 Offset: 0x271F280 VA: 0x182720880 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0xF72990 Offset: 0xF71390 VA: 0x180F72990 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x27219E0 Offset: 0x27203E0 VA: 0x1827219E0 Slot: 15
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

	// RVA: 0x27214E0 Offset: 0x271FEE0 VA: 0x1827214E0
	public FixedString32Bytes.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x2720DC0 Offset: 0x271F7C0 VA: 0x182720DC0 Slot: 16
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x2720F10 Offset: 0x271F910 VA: 0x182720F10 Slot: 17
	public bool Equals(string other) { }

	// RVA: 0x2720890 Offset: 0x271F290 VA: 0x182720890
	public ref FixedList32Bytes<byte> AsFixedList() { }

	[NotBurstCompatible]
	// RVA: 0x2721A60 Offset: 0x2720460 VA: 0x182721A60
	public void .ctor(string source) { }

	[NotBurstCompatible]
	// RVA: 0x27215F0 Offset: 0x271FFF0 VA: 0x1827215F0
	internal int Initialize(string source) { }

	// RVA: 0x2721B40 Offset: 0x2720540 VA: 0x182721B40
	public void .ctor(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2721730 Offset: 0x2720130 VA: 0x182721730
	internal int Initialize(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2720E70 Offset: 0x271F870 VA: 0x182720E70 Slot: 18
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2721B20 Offset: 0x2720520 VA: 0x182721B20
	public void .ctor(in FixedString32Bytes other) { }

	// RVA: 0x27218F0 Offset: 0x27202F0 VA: 0x1827218F0
	internal int Initialize(in FixedString32Bytes other) { }

	// RVA: 0x2721C90 Offset: 0x2720690 VA: 0x182721C90
	public static bool op_Equality(in FixedString32Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2722180 Offset: 0x2720B80 VA: 0x182722180
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2720FF0 Offset: 0x271F9F0 VA: 0x182720FF0 Slot: 19
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x2720EC0 Offset: 0x271F8C0 VA: 0x182720EC0 Slot: 20
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x2721AE0 Offset: 0x27204E0 VA: 0x182721AE0
	public void .ctor(in FixedString64Bytes other) { }

	// RVA: 0x2721540 Offset: 0x271FF40 VA: 0x182721540
	internal int Initialize(in FixedString64Bytes other) { }

	// RVA: 0x2721BF0 Offset: 0x27205F0 VA: 0x182721BF0
	public static bool op_Equality(in FixedString32Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x27221C0 Offset: 0x2720BC0 VA: 0x1827221C0
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2720FD0 Offset: 0x271F9D0 VA: 0x182720FD0 Slot: 21
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x2721F50 Offset: 0x2720950 VA: 0x182721F50
	public static FixedString64Bytes op_Implicit(in FixedString32Bytes fs) { }

	// RVA: 0x2720D70 Offset: 0x271F770 VA: 0x182720D70 Slot: 22
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2721BD0 Offset: 0x27205D0 VA: 0x182721BD0
	public void .ctor(in FixedString128Bytes other) { }

	// RVA: 0x2721790 Offset: 0x2720190 VA: 0x182721790
	internal int Initialize(in FixedString128Bytes other) { }

	// RVA: 0x2721DD0 Offset: 0x27207D0 VA: 0x182721DD0
	public static bool op_Equality(in FixedString32Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2722160 Offset: 0x2720B60 VA: 0x182722160
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2721010 Offset: 0x271FA10 VA: 0x182721010 Slot: 23
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2722100 Offset: 0x2720B00 VA: 0x182722100
	public static FixedString128Bytes op_Implicit(in FixedString32Bytes fs) { }

	// RVA: 0x2720D20 Offset: 0x271F720 VA: 0x182720D20 Slot: 24
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2721BB0 Offset: 0x27205B0 VA: 0x182721BB0
	public void .ctor(in FixedString512Bytes other) { }

	// RVA: 0x2721840 Offset: 0x2720240 VA: 0x182721840
	internal int Initialize(in FixedString512Bytes other) { }

	// RVA: 0x2721D30 Offset: 0x2720730 VA: 0x182721D30
	public static bool op_Equality(in FixedString32Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x27221A0 Offset: 0x2720BA0 VA: 0x1827221A0
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2720FB0 Offset: 0x271F9B0 VA: 0x182720FB0 Slot: 25
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2721F10 Offset: 0x2720910 VA: 0x182721F10
	public static FixedString512Bytes op_Implicit(in FixedString32Bytes fs) { }

	// RVA: 0x2720E20 Offset: 0x271F820 VA: 0x182720E20 Slot: 26
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x2721B00 Offset: 0x2720500 VA: 0x182721B00
	public void .ctor(in FixedString4096Bytes other) { }

	// RVA: 0x2721680 Offset: 0x2720080 VA: 0x182721680
	internal int Initialize(in FixedString4096Bytes other) { }

	// RVA: 0x2721E70 Offset: 0x2720870 VA: 0x182721E70
	public static bool op_Equality(in FixedString32Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2722140 Offset: 0x2720B40 VA: 0x182722140
	public static bool op_Inequality(in FixedString32Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x27214C0 Offset: 0x271FEC0 VA: 0x1827214C0 Slot: 27
	public bool Equals(FixedString4096Bytes other) { }

	// RVA: 0x2721F80 Offset: 0x2720980 VA: 0x182721F80
	public static FixedString4096Bytes op_Implicit(in FixedString32Bytes fs) { }

	[NotBurstCompatible]
	// RVA: 0x2722070 Offset: 0x2720A70 VA: 0x182722070
	public static FixedString32Bytes op_Implicit(string b) { }

	[NotBurstCompatible]
	// RVA: 0x27219A0 Offset: 0x27203A0 VA: 0x1827219A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2721500 Offset: 0x271FF00 VA: 0x182721500 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x2721030 Offset: 0x271FA30 VA: 0x182721030 Slot: 0
	public override bool Equals(object obj) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2720A90 Offset: 0x271F490 VA: 0x182720A90
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2720BE0 Offset: 0x271F5E0 VA: 0x182720BE0
	private void CheckLengthInRange(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27208C0 Offset: 0x271F2C0 VA: 0x1827208C0
	private void CheckCapacityInRange(int capacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2720990 Offset: 0x271F390 VA: 0x182720990
	private static void CheckCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2720A30 Offset: 0x271F430 VA: 0x182720A30
	private static void CheckFormatError(FormatError error) { }
}
