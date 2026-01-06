public struct FixedString512Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15831
{
	// Fields
	internal const ushort utf8MaxLengthInBytes = 509;
	[SerializeField]
	internal ushort utf8LengthInBytes; // 0x0
	[SerializeField]
	internal FixedBytes510 bytes; // 0x2

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

	// RVA: 0x2724FD0 Offset: 0x27239D0 VA: 0x182724FD0
	public static int get_UTF8MaxLengthInBytes() { }

	// RVA: 0x2724CD0 Offset: 0x27236D0 VA: 0x182724CD0
	public string get_Value() { }

	// RVA: 0x271FAF0 Offset: 0x271E4F0 VA: 0x18271FAF0 Slot: 14
	public byte* GetUnsafePtr() { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	public int get_Length() { }

	// RVA: 0x2720880 Offset: 0x271F280 VA: 0x182720880 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x2724FD0 Offset: 0x27239D0 VA: 0x182724FD0 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x2724D10 Offset: 0x2723710 VA: 0x182724D10 Slot: 15
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

	// RVA: 0x2724740 Offset: 0x2723140 VA: 0x182724740
	public FixedString512Bytes.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x27240C0 Offset: 0x2722AC0 VA: 0x1827240C0 Slot: 16
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x27246A0 Offset: 0x27230A0 VA: 0x1827246A0 Slot: 17
	public bool Equals(string other) { }

	// RVA: 0x2723B00 Offset: 0x2722500 VA: 0x182723B00
	public ref FixedList512Bytes<byte> AsFixedList() { }

	[NotBurstCompatible]
	// RVA: 0x2724DD0 Offset: 0x27237D0 VA: 0x182724DD0
	public void .ctor(string source) { }

	[NotBurstCompatible]
	// RVA: 0x27249D0 Offset: 0x27233D0 VA: 0x1827249D0
	internal int Initialize(string source) { }

	// RVA: 0x2724F50 Offset: 0x2723950 VA: 0x182724F50
	public void .ctor(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2724B00 Offset: 0x2723500 VA: 0x182724B00
	internal int Initialize(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2724120 Offset: 0x2722B20 VA: 0x182724120 Slot: 18
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2724ED0 Offset: 0x27238D0 VA: 0x182724ED0
	public void .ctor(in FixedString32Bytes other) { }

	// RVA: 0x2724B70 Offset: 0x2723570 VA: 0x182724B70
	internal int Initialize(in FixedString32Bytes other) { }

	// RVA: 0x2725260 Offset: 0x2723C60 VA: 0x182725260
	public static bool op_Equality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x27254B0 Offset: 0x2723EB0 VA: 0x1827254B0
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2724190 Offset: 0x2722B90 VA: 0x182724190 Slot: 19
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x2724020 Offset: 0x2722A20 VA: 0x182724020 Slot: 20
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x2724D90 Offset: 0x2723790 VA: 0x182724D90
	public void .ctor(in FixedString64Bytes other) { }

	// RVA: 0x2724920 Offset: 0x2723320 VA: 0x182724920
	internal int Initialize(in FixedString64Bytes other) { }

	// RVA: 0x27251C0 Offset: 0x2723BC0 VA: 0x1827251C0
	public static bool op_Equality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2725490 Offset: 0x2723E90 VA: 0x182725490
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2724170 Offset: 0x2722B70 VA: 0x182724170 Slot: 21
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x2723FD0 Offset: 0x27229D0 VA: 0x182723FD0 Slot: 22
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2724F10 Offset: 0x2723910 VA: 0x182724F10
	public void .ctor(in FixedString128Bytes other) { }

	// RVA: 0x2724A50 Offset: 0x2723450 VA: 0x182724A50
	internal int Initialize(in FixedString128Bytes other) { }

	// RVA: 0x2725080 Offset: 0x2723A80 VA: 0x182725080
	public static bool op_Equality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2725470 Offset: 0x2723E70 VA: 0x182725470
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2724660 Offset: 0x2723060 VA: 0x182724660 Slot: 23
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2723F80 Offset: 0x2722980 VA: 0x182723F80 Slot: 24
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2724E90 Offset: 0x2723890 VA: 0x182724E90
	public void .ctor(in FixedString512Bytes other) { }

	// RVA: 0x2724870 Offset: 0x2723270 VA: 0x182724870
	internal int Initialize(in FixedString512Bytes other) { }

	// RVA: 0x2724FE0 Offset: 0x27239E0 VA: 0x182724FE0
	public static bool op_Equality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x27254F0 Offset: 0x2723EF0 VA: 0x1827254F0
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2724640 Offset: 0x2723040 VA: 0x182724640 Slot: 25
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2724070 Offset: 0x2722A70 VA: 0x182724070 Slot: 26
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x2724E50 Offset: 0x2723850 VA: 0x182724E50
	public void .ctor(in FixedString4096Bytes other) { }

	// RVA: 0x2724C20 Offset: 0x2723620 VA: 0x182724C20
	internal int Initialize(in FixedString4096Bytes other) { }

	// RVA: 0x2725120 Offset: 0x2723B20 VA: 0x182725120
	public static bool op_Equality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x27254D0 Offset: 0x2723ED0 VA: 0x1827254D0
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2724680 Offset: 0x2723080 VA: 0x182724680 Slot: 27
	public bool Equals(FixedString4096Bytes other) { }

	// RVA: 0x2725300 Offset: 0x2723D00 VA: 0x182725300
	public static FixedString4096Bytes op_Implicit(in FixedString512Bytes fs) { }

	[NotBurstCompatible]
	// RVA: 0x27253F0 Offset: 0x2723DF0 VA: 0x1827253F0
	public static FixedString512Bytes op_Implicit(string b) { }

	[NotBurstCompatible]
	// RVA: 0x2724CD0 Offset: 0x27236D0 VA: 0x182724CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2724830 Offset: 0x2723230 VA: 0x182724830 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x27241B0 Offset: 0x2722BB0 VA: 0x1827241B0 Slot: 0
	public override bool Equals(object obj) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2723CF0 Offset: 0x27226F0 VA: 0x182723CF0
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2723E40 Offset: 0x2722840 VA: 0x182723E40
	private void CheckLengthInRange(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2723B30 Offset: 0x2722530 VA: 0x182723B30
	private void CheckCapacityInRange(int capacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2723BF0 Offset: 0x27225F0 VA: 0x182723BF0
	private static void CheckCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2723C90 Offset: 0x2722690 VA: 0x182723C90
	private static void CheckFormatError(FormatError error) { }
}
