public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 11758
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public float magnitude { get; }
	public static Vector2Int zero { get; }
	public static Vector2Int one { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_x() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_x(int value) { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public int get_y() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_y(int value) { }

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int x, int y) { }

	// RVA: 0x2CD1C80 Offset: 0x2CD0680 VA: 0x182CD1C80
	public float get_magnitude() { }

	// RVA: 0x2CD19A0 Offset: 0x2CD03A0 VA: 0x182CD19A0
	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x2CD1D50 Offset: 0x2CD0750 VA: 0x182CD1D50
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x2CD1890 Offset: 0x2CD0290 VA: 0x182CD1890
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x2CD1D90 Offset: 0x2CD0790 VA: 0x182CD1D90
	public static Vector2Int op_Multiply(Vector2Int a, int b) { }

	// RVA: 0x2CD1D30 Offset: 0x2CD0730 VA: 0x182CD1D30
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x2CD1D70 Offset: 0x2CD0770 VA: 0x182CD1D70
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x2CD17E0 Offset: 0x2CD01E0 VA: 0x182CD17E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CD17C0 Offset: 0x2CD01C0 VA: 0x182CD17C0 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x2CD1950 Offset: 0x2CD0350 VA: 0x182CD1950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CD1B80 Offset: 0x2CD0580 VA: 0x182CD1B80 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CD19D0 Offset: 0x2CD03D0 VA: 0x182CD19D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CD1CF0 Offset: 0x2CD06F0 VA: 0x182CD1CF0
	public static Vector2Int get_zero() { }

	// RVA: 0x2CD1CB0 Offset: 0x2CD06B0 VA: 0x182CD1CB0
	public static Vector2Int get_one() { }

	// RVA: 0x2CD1B90 Offset: 0x2CD0590 VA: 0x182CD1B90
	private static void .cctor() { }
}
