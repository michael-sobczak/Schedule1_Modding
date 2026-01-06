public struct Int3 : IEquatable<Int3> // TypeDefIndex: 13175
{
	// Fields
	public int x; // 0x0
	public int y; // 0x4
	public int z; // 0x8
	public const int Precision = 1000;
	public const float FloatPrecision = 1000;
	public const float PrecisionFactor = 0.001;

	// Properties
	public static Int3 zero { get; }
	public int Item { get; set; }
	public float magnitude { get; }
	public int costMagnitude { get; }
	public float sqrMagnitude { get; }
	public long sqrMagnitudeLong { get; }

	// Methods

	// RVA: 0xB1BE50 Offset: 0xB1A850 VA: 0x180B1BE50
	public static Int3 get_zero() { }

	// RVA: 0xB1BC00 Offset: 0xB1A600 VA: 0x180B1BC00
	public void .ctor(Vector3 position) { }

	// RVA: 0x527620 Offset: 0x526020 VA: 0x180527620
	public void .ctor(int _x, int _y, int _z) { }

	// RVA: 0x5275E0 Offset: 0x525FE0 VA: 0x1805275E0
	public static bool op_Equality(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1C060 Offset: 0xB1AA60 VA: 0x180B1C060
	public static bool op_Inequality(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1BF50 Offset: 0xB1A950 VA: 0x180B1BF50
	public static Int3 op_Explicit(Vector3 ob) { }

	// RVA: 0xB1C010 Offset: 0xB1AA10 VA: 0x180B1C010
	public static Vector3 op_Explicit(Int3 ob) { }

	// RVA: 0xB1C220 Offset: 0xB1AC20 VA: 0x180B1C220
	public static Int3 op_Subtraction(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1C250 Offset: 0xB1AC50 VA: 0x180B1C250
	public static Int3 op_UnaryNegation(Int3 lhs) { }

	// RVA: 0xB1BE60 Offset: 0xB1A860 VA: 0x180B1BE60
	public static Int3 op_Addition(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1C140 Offset: 0xB1AB40 VA: 0x180B1C140
	public static Int3 op_Multiply(Int3 lhs, int rhs) { }

	// RVA: 0xB1C080 Offset: 0xB1AA80 VA: 0x180B1C080
	public static Int3 op_Multiply(Int3 lhs, float rhs) { }

	// RVA: 0xB1C170 Offset: 0xB1AB70 VA: 0x180B1C170
	public static Int3 op_Multiply(Int3 lhs, double rhs) { }

	// RVA: 0xB1BE90 Offset: 0xB1A890 VA: 0x180B1BE90
	public static Int3 op_Division(Int3 lhs, float rhs) { }

	// RVA: 0xB1BCB0 Offset: 0xB1A6B0 VA: 0x180B1BCB0
	public int get_Item(int i) { }

	// RVA: 0xB1C280 Offset: 0xB1AC80 VA: 0x180B1C280
	public void set_Item(int i, int value) { }

	// RVA: 0xB1B850 Offset: 0xB1A250 VA: 0x180B1B850
	public static float Angle(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1B9A0 Offset: 0xB1A3A0 VA: 0x180B1B9A0
	public static int Dot(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1B970 Offset: 0xB1A370 VA: 0x180B1B970
	public static long DotLong(Int3 lhs, Int3 rhs) { }

	// RVA: 0xB1BA80 Offset: 0xB1A480 VA: 0x180B1BA80
	public Int3 Normal2D() { }

	// RVA: 0xB1BD40 Offset: 0xB1A740 VA: 0x180B1BD40
	public float get_magnitude() { }

	// RVA: 0xB1BCD0 Offset: 0xB1A6D0 VA: 0x180B1BCD0
	public int get_costMagnitude() { }

	// RVA: 0xB1BE20 Offset: 0xB1A820 VA: 0x180B1BE20
	public float get_sqrMagnitude() { }

	// RVA: 0xB1BE00 Offset: 0xB1A800 VA: 0x180B1BE00
	public long get_sqrMagnitudeLong() { }

	// RVA: 0xB1C050 Offset: 0xB1AA50 VA: 0x180B1C050
	public static string op_Implicit(Int3 obj) { }

	// RVA: 0xB1BAA0 Offset: 0xB1A4A0 VA: 0x180B1BAA0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB1B9C0 Offset: 0xB1A3C0 VA: 0x180B1B9C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5275E0 Offset: 0x525FE0 VA: 0x1805275E0 Slot: 4
	public bool Equals(Int3 other) { }

	// RVA: 0xB1BA60 Offset: 0xB1A460 VA: 0x180B1BA60 Slot: 2
	public override int GetHashCode() { }
}
