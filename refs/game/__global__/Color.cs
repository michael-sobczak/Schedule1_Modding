public struct Color : IEquatable<Color> // TypeDefIndex: 17108
{
	// Fields
	public static readonly Color Empty; // 0x0
	private readonly string name; // 0x0
	private readonly long value; // 0x8
	private readonly short knownColor; // 0x10
	private readonly short state; // 0x12

	// Properties
	public static Color Transparent { get; }
	public static Color Black { get; }
	public static Color Blue { get; }
	public static Color Gray { get; }
	public static Color SkyBlue { get; }
	public static Color Wheat { get; }
	public static Color White { get; }
	public byte R { get; }
	public byte G { get; }
	public byte B { get; }
	public byte A { get; }
	public bool IsKnownColor { get; }
	public bool IsEmpty { get; }
	public bool IsSystemColor { get; }
	public string Name { get; }
	private long Value { get; }

	// Methods

	// RVA: 0x21368B0 Offset: 0x21352B0 VA: 0x1821368B0
	public static Color get_Transparent() { }

	// RVA: 0x2136650 Offset: 0x2135050 VA: 0x182136650
	public static Color get_Black() { }

	// RVA: 0x2136690 Offset: 0x2135090 VA: 0x182136690
	public static Color get_Blue() { }

	// RVA: 0x21366F0 Offset: 0x21350F0 VA: 0x1821366F0
	public static Color get_Gray() { }

	// RVA: 0x2136870 Offset: 0x2135270 VA: 0x182136870
	public static Color get_SkyBlue() { }

	// RVA: 0x21369B0 Offset: 0x21353B0 VA: 0x1821369B0
	public static Color get_Wheat() { }

	// RVA: 0x21369F0 Offset: 0x21353F0 VA: 0x1821369F0
	public static Color get_White() { }

	// RVA: 0x21365F0 Offset: 0x2134FF0 VA: 0x1821365F0
	internal void .ctor(KnownColor knownColor) { }

	// RVA: 0x21365C0 Offset: 0x2134FC0 VA: 0x1821365C0
	private void .ctor(long value, short state, string name, KnownColor knownColor) { }

	// RVA: 0x2136850 Offset: 0x2135250 VA: 0x182136850
	public byte get_R() { }

	// RVA: 0x21366D0 Offset: 0x21350D0 VA: 0x1821366D0
	public byte get_G() { }

	// RVA: 0x2136330 Offset: 0x2134D30 VA: 0x182136330
	public byte get_B() { }

	// RVA: 0x2136630 Offset: 0x2135030 VA: 0x182136630
	public byte get_A() { }

	// RVA: 0x2136740 Offset: 0x2135140 VA: 0x182136740
	public bool get_IsKnownColor() { }

	// RVA: 0x2136730 Offset: 0x2135130 VA: 0x182136730
	public bool get_IsEmpty() { }

	// RVA: 0x2135800 Offset: 0x2134200 VA: 0x182135800
	public bool get_IsSystemColor() { }

	// RVA: 0x2136750 Offset: 0x2135150 VA: 0x182136750
	public string get_Name() { }

	// RVA: 0x21368F0 Offset: 0x21352F0 VA: 0x1821368F0
	private long get_Value() { }

	// RVA: 0x2135820 Offset: 0x2134220 VA: 0x182135820
	private static void CheckByte(int value, string name) { }

	// RVA: 0x2136300 Offset: 0x2134D00 VA: 0x182136300
	private static long MakeArgb(byte alpha, byte red, byte green, byte blue) { }

	// RVA: 0x2135B50 Offset: 0x2134550 VA: 0x182135B50
	public static Color FromArgb(int argb) { }

	// RVA: 0x2135B90 Offset: 0x2134590 VA: 0x182135B90
	public static Color FromArgb(int alpha, int red, int green, int blue) { }

	// RVA: 0x2135CB0 Offset: 0x21346B0 VA: 0x182135CB0
	public static Color FromArgb(int red, int green, int blue) { }

	// RVA: 0x2135DD0 Offset: 0x21347D0 VA: 0x182135DD0
	public static Color FromKnownColor(KnownColor color) { }

	// RVA: 0x2135FD0 Offset: 0x21349D0 VA: 0x182135FD0
	public static Color FromName(string name) { }

	// RVA: 0x2136160 Offset: 0x2134B60 VA: 0x182136160
	public float GetBrightness() { }

	// RVA: 0x2136330 Offset: 0x2134D30 VA: 0x182136330
	public int ToArgb() { }

	// RVA: 0x2136340 Offset: 0x2134D40 VA: 0x182136340
	public KnownColor ToKnownColor() { }

	// RVA: 0x2136350 Offset: 0x2134D50 VA: 0x182136350 Slot: 3
	public override string ToString() { }

	// RVA: 0x2136A30 Offset: 0x2135430 VA: 0x182136A30
	public static bool op_Equality(Color left, Color right) { }

	// RVA: 0x2136AB0 Offset: 0x21354B0 VA: 0x182136AB0
	public static bool op_Inequality(Color left, Color right) { }

	// RVA: 0x21359B0 Offset: 0x21343B0 VA: 0x1821359B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2135AB0 Offset: 0x21344B0 VA: 0x182135AB0 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x2136220 Offset: 0x2134C20 VA: 0x182136220 Slot: 2
	public override int GetHashCode() { }
}
