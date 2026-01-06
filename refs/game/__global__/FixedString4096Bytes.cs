public struct FixedString4096Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 15835
{
	// Fields
	internal const ushort utf8MaxLengthInBytes = 4093;
	[SerializeField]
	internal ushort utf8LengthInBytes; // 0x0
	[SerializeField]
	internal FixedBytes4094 bytes; // 0x2

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

	// RVA: 0x2723670 Offset: 0x2722070 VA: 0x182723670
	public static int get_UTF8MaxLengthInBytes() { }

	// RVA: 0x2723370 Offset: 0x2721D70 VA: 0x182723370
	public string get_Value() { }

	// RVA: 0x271FAF0 Offset: 0x271E4F0 VA: 0x18271FAF0 Slot: 14
	public byte* GetUnsafePtr() { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50 Slot: 10
	public int get_Length() { }

	// RVA: 0x2720880 Offset: 0x271F280 VA: 0x182720880 Slot: 11
	public void set_Length(int value) { }

	// RVA: 0x2723670 Offset: 0x2722070 VA: 0x182723670 Slot: 4
	public int get_Capacity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Capacity(int value) { }

	// RVA: 0x27233B0 Offset: 0x2721DB0 VA: 0x1827233B0 Slot: 15
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

	// RVA: 0x2722E30 Offset: 0x2721830 VA: 0x182722E30
	public FixedString4096Bytes.Enumerator GetEnumerator() { }

	[NotBurstCompatible]
	// RVA: 0x27227F0 Offset: 0x27211F0 VA: 0x1827227F0 Slot: 16
	public int CompareTo(string other) { }

	[NotBurstCompatible]
	// RVA: 0x2722870 Offset: 0x2721270 VA: 0x182722870 Slot: 17
	public bool Equals(string other) { }

	// RVA: 0x27221E0 Offset: 0x2720BE0 VA: 0x1827221E0
	public ref FixedList4096Bytes<byte> AsFixedList() { }

	[NotBurstCompatible]
	// RVA: 0x27234B0 Offset: 0x2721EB0 VA: 0x1827234B0
	public void .ctor(string source) { }

	[NotBurstCompatible]
	// RVA: 0x27232F0 Offset: 0x2721CF0 VA: 0x1827232F0
	internal int Initialize(string source) { }

	// RVA: 0x2723530 Offset: 0x2721F30 VA: 0x182723530
	public void .ctor(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2723070 Offset: 0x2721A70 VA: 0x182723070
	internal int Initialize(Unicode.Rune rune, int count = 1) { }

	// RVA: 0x2722750 Offset: 0x2721150 VA: 0x182722750 Slot: 18
	public int CompareTo(FixedString32Bytes other) { }

	// RVA: 0x2723430 Offset: 0x2721E30 VA: 0x182723430
	public void .ctor(in FixedString32Bytes other) { }

	// RVA: 0x2723190 Offset: 0x2721B90 VA: 0x182723190
	internal int Initialize(in FixedString32Bytes other) { }

	// RVA: 0x27237C0 Offset: 0x27221C0 VA: 0x1827237C0
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2723A80 Offset: 0x2722480 VA: 0x182723A80
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString32Bytes b) { }

	// RVA: 0x2722DF0 Offset: 0x27217F0 VA: 0x182722DF0 Slot: 19
	public bool Equals(FixedString32Bytes other) { }

	// RVA: 0x27227A0 Offset: 0x27211A0 VA: 0x1827227A0 Slot: 20
	public int CompareTo(FixedString64Bytes other) { }

	// RVA: 0x27235B0 Offset: 0x2721FB0 VA: 0x1827235B0
	public void .ctor(in FixedString64Bytes other) { }

	// RVA: 0x27230E0 Offset: 0x2721AE0 VA: 0x1827230E0
	internal int Initialize(in FixedString64Bytes other) { }

	// RVA: 0x2723720 Offset: 0x2722120 VA: 0x182723720
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2723AC0 Offset: 0x27224C0 VA: 0x182723AC0
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString64Bytes b) { }

	// RVA: 0x2722E10 Offset: 0x2721810 VA: 0x182722E10 Slot: 21
	public bool Equals(FixedString64Bytes other) { }

	// RVA: 0x2722700 Offset: 0x2721100 VA: 0x182722700 Slot: 22
	public int CompareTo(FixedString128Bytes other) { }

	// RVA: 0x2723470 Offset: 0x2721E70 VA: 0x182723470
	public void .ctor(in FixedString128Bytes other) { }

	// RVA: 0x2722F10 Offset: 0x2721910 VA: 0x182722F10
	internal int Initialize(in FixedString128Bytes other) { }

	// RVA: 0x2723860 Offset: 0x2722260 VA: 0x182723860
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2723A60 Offset: 0x2722460 VA: 0x182723A60
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString128Bytes b) { }

	// RVA: 0x2722910 Offset: 0x2721310 VA: 0x182722910 Slot: 23
	public bool Equals(FixedString128Bytes other) { }

	// RVA: 0x2722660 Offset: 0x2721060 VA: 0x182722660 Slot: 24
	public int CompareTo(FixedString512Bytes other) { }

	// RVA: 0x2723630 Offset: 0x2722030 VA: 0x182723630
	public void .ctor(in FixedString512Bytes other) { }

	// RVA: 0x2722FC0 Offset: 0x27219C0 VA: 0x182722FC0
	internal int Initialize(in FixedString512Bytes other) { }

	// RVA: 0x2723900 Offset: 0x2722300 VA: 0x182723900
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2723AE0 Offset: 0x27224E0 VA: 0x182723AE0
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString512Bytes b) { }

	// RVA: 0x2722930 Offset: 0x2721330 VA: 0x182722930 Slot: 25
	public bool Equals(FixedString512Bytes other) { }

	// RVA: 0x27226B0 Offset: 0x27210B0 VA: 0x1827226B0 Slot: 26
	public int CompareTo(FixedString4096Bytes other) { }

	// RVA: 0x27235F0 Offset: 0x2721FF0 VA: 0x1827235F0
	public void .ctor(in FixedString4096Bytes other) { }

	// RVA: 0x2723240 Offset: 0x2721C40 VA: 0x182723240
	internal int Initialize(in FixedString4096Bytes other) { }

	// RVA: 0x2723680 Offset: 0x2722080 VA: 0x182723680
	public static bool op_Equality(in FixedString4096Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2723AA0 Offset: 0x27224A0 VA: 0x182723AA0
	public static bool op_Inequality(in FixedString4096Bytes a, in FixedString4096Bytes b) { }

	// RVA: 0x2722850 Offset: 0x2721250 VA: 0x182722850 Slot: 27
	public bool Equals(FixedString4096Bytes other) { }

	[NotBurstCompatible]
	// RVA: 0x27239A0 Offset: 0x27223A0 VA: 0x1827239A0
	public static FixedString4096Bytes op_Implicit(string b) { }

	[NotBurstCompatible]
	// RVA: 0x2723370 Offset: 0x2721D70 VA: 0x182723370 Slot: 3
	public override string ToString() { }

	// RVA: 0x2722ED0 Offset: 0x27218D0 VA: 0x182722ED0 Slot: 2
	public override int GetHashCode() { }

	[NotBurstCompatible]
	// RVA: 0x2722950 Offset: 0x2721350 VA: 0x182722950 Slot: 0
	public override bool Equals(object obj) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27223D0 Offset: 0x2720DD0 VA: 0x1827223D0
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2722520 Offset: 0x2720F20 VA: 0x182722520
	private void CheckLengthInRange(int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2722210 Offset: 0x2720C10 VA: 0x182722210
	private void CheckCapacityInRange(int capacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27222D0 Offset: 0x2720CD0 VA: 0x1827222D0
	private static void CheckCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2722370 Offset: 0x2720D70 VA: 0x182722370
	private static void CheckFormatError(FormatError error) { }
}
