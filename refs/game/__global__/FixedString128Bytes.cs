public struct FixedString128Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15827
{
	// Fields
	internal const ushort utf8MaxLengthInBytes = 125;
	[SerializeField]
	internal ushort utf8LengthInBytes; // 0x0
	[SerializeField]
	internal FixedBytes126 bytes; // 0x2

	// Properties
	public static int UTF8MaxLengthInBytes { get; }
	[EditorBrowsable(1)]
	[CreateProperty]
	[NotBurstCompatible]
	public string Value { get; }
	public int Length { get; set; }
	public int Capacity { get; set; }
	public bool IsEmpty { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0x27202B0 Offset: 0x271ECB0 VA: 0x1827202B0
	public static int get_UTF8MaxLengthInBytes() { }

	// RVA: 0x2720030 Offset: 0x271EA30 VA: 0x182720030
	public string get_Value() { }

	// RVA: 0x271FAF0 Offset: 0x271E4F0 VA: 0x18271FAF0 Slot: 14
	public byte* GetUnsafePtr() { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	public int get_Length() { }

	// RVA: 0x2720880 Offset: 0x271F280 VA: 0x182720880 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x27202B0 Offset: 0x271ECB0 VA: 0x1827202B0 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x2720070 Offset: 0x271EA70 VA: 0x182720070 Slot: 15
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

	// RVA: 0x271FA40 Offset: 0x271E440 VA: 0x18271FA40
	public FixedString128Bytes.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x271F360 Offset: 0x271DD60 VA: 0x18271F360 Slot: 16
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x271F4F0 Offset: 0x271DEF0 VA: 0x18271F4F0 Slot: 17
	public bool Equals(string other) { }

	// RVA: 0x271EDD0 Offset: 0x271D7D0 VA: 0x18271EDD0
	public ref FixedList128Bytes<byte> AsFixedList() { }

	[NotBurstCompatible]
	// RVA: 0x27201E0 Offset: 0x271EBE0 VA: 0x1827201E0
	public void .ctor(string source) { }

	[NotBurstCompatible]
	// RVA: 0x271FB00 Offset: 0x271E500 VA: 0x18271FB00
	internal int Initialize(string source) { }

	// RVA: 0x2720180 Offset: 0x271EB80 VA: 0x182720180
	public void .ctor(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x271FEE0 Offset: 0x271E8E0 VA: 0x18271FEE0
	internal int Initialize(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x271F410 Offset: 0x271DE10 VA: 0x18271F410 Slot: 18
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2720150 Offset: 0x271EB50 VA: 0x182720150
	public void .ctor(in FixedString32Bytes other) { }

	// RVA: 0x271FF60 Offset: 0x271E960 VA: 0x18271FF60
	internal int Initialize(in FixedString32Bytes other) { }

	// RVA: 0x2720380 Offset: 0x271ED80 VA: 0x182720380
	public static bool op_Equality(in FixedString128Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2720850 Offset: 0x271F250 VA: 0x182720850
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x271F4D0 Offset: 0x271DED0 VA: 0x18271F4D0 Slot: 19
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x271F3C0 Offset: 0x271DDC0 VA: 0x18271F3C0 Slot: 20
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x2720280 Offset: 0x271EC80 VA: 0x182720280
	public void .ctor(in FixedString64Bytes other) { }

	// RVA: 0x271FE10 Offset: 0x271E810 VA: 0x18271FE10
	internal int Initialize(in FixedString64Bytes other) { }

	// RVA: 0x27204C0 Offset: 0x271EEC0 VA: 0x1827204C0
	public static bool op_Equality(in FixedString128Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2720810 Offset: 0x271F210 VA: 0x182720810
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x271F590 Offset: 0x271DF90 VA: 0x18271F590 Slot: 21
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x271F2C0 Offset: 0x271DCC0 VA: 0x18271F2C0 Slot: 22
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2720120 Offset: 0x271EB20 VA: 0x182720120
	public void .ctor(in FixedString128Bytes other) { }

	// RVA: 0x271FBA0 Offset: 0x271E5A0 VA: 0x18271FBA0
	internal int Initialize(in FixedString128Bytes other) { }

	// RVA: 0x2720420 Offset: 0x271EE20 VA: 0x182720420
	public static bool op_Equality(in FixedString128Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x27207D0 Offset: 0x271F1D0 VA: 0x1827207D0
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x271F4B0 Offset: 0x271DEB0 VA: 0x18271F4B0 Slot: 23
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x271F310 Offset: 0x271DD10 VA: 0x18271F310 Slot: 24
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x27200F0 Offset: 0x271EAF0 VA: 0x1827200F0
	public void .ctor(in FixedString512Bytes other) { }

	// RVA: 0x271FC70 Offset: 0x271E670 VA: 0x18271FC70
	internal int Initialize(in FixedString512Bytes other) { }

	// RVA: 0x27202E0 Offset: 0x271ECE0 VA: 0x1827202E0
	public static bool op_Equality(in FixedString128Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2720830 Offset: 0x271F230 VA: 0x182720830
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x271F470 Offset: 0x271DE70 VA: 0x18271F470 Slot: 25
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x2720600 Offset: 0x271F000 VA: 0x182720600
	public static FixedString512Bytes op_Implicit(in FixedString128Bytes fs) { }

	// RVA: 0x271F270 Offset: 0x271DC70 VA: 0x18271F270 Slot: 26
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x27201B0 Offset: 0x271EBB0 VA: 0x1827201B0
	public void .ctor(in FixedString4096Bytes other) { }

	// RVA: 0x271FD40 Offset: 0x271E740 VA: 0x18271FD40
	internal int Initialize(in FixedString4096Bytes other) { }

	// RVA: 0x2720560 Offset: 0x271EF60 VA: 0x182720560
	public static bool op_Equality(in FixedString128Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x27207F0 Offset: 0x271F1F0 VA: 0x1827207F0
	public static bool op_Inequality(in FixedString128Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x271F490 Offset: 0x271DE90 VA: 0x18271F490 Slot: 27
	public bool Equals(FixedString4096Bytes other) { }

	// RVA: 0x2720640 Offset: 0x271F040 VA: 0x182720640
	public static FixedString4096Bytes op_Implicit(in FixedString128Bytes fs) { }

	[NotBurstCompatible]
	// RVA: 0x2720730 Offset: 0x271F130 VA: 0x182720730
	public static FixedString128Bytes op_Implicit(string b) { }

	[NotBurstCompatible]
	// RVA: 0x2720030 Offset: 0x271EA30 VA: 0x182720030 Slot: 3
	public override string ToString() { }

	// RVA: 0x271FAB0 Offset: 0x271E4B0 VA: 0x18271FAB0 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x271F5B0 Offset: 0x271DFB0 VA: 0x18271F5B0 Slot: 0
	public override bool Equals(object obj) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271EFD0 Offset: 0x271D9D0 VA: 0x18271EFD0
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271F120 Offset: 0x271DB20 VA: 0x18271F120
	private void CheckLengthInRange(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271EE00 Offset: 0x271D800 VA: 0x18271EE00
	private void CheckCapacityInRange(int capacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271EED0 Offset: 0x271D8D0 VA: 0x18271EED0
	private static void CheckCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271EF70 Offset: 0x271D970 VA: 0x18271EF70
	private static void CheckFormatError(FormatError error) { }
}
