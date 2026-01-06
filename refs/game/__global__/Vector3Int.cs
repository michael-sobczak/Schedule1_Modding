public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 11759
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }
	public static Vector3Int zero { get; }
	public static Vector3Int one { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_x() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_x(int value) { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public int get_y() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_y(int value) { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_z() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_z(int value) { }

	// RVA: 0x527620 Offset: 0x526020 VA: 0x180527620
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x2CD2FB0 Offset: 0x2CD19B0 VA: 0x182CD2FB0
	public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x2CD2F50 Offset: 0x2CD1950 VA: 0x182CD2F50
	public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x2CD34C0 Offset: 0x2CD1EC0 VA: 0x182CD34C0
	public static Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x2CD3420 Offset: 0x2CD1E20 VA: 0x182CD3420
	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	// RVA: 0x2CD3580 Offset: 0x2CD1F80 VA: 0x182CD3580
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	// RVA: 0x2CD3540 Offset: 0x2CD1F40 VA: 0x182CD3540
	public static Vector3Int op_Multiply(Vector3Int a, int b) { }

	// RVA: 0x2CD3460 Offset: 0x2CD1E60 VA: 0x182CD3460
	public static Vector3Int op_Division(Vector3Int a, int b) { }

	// RVA: 0x2CD34A0 Offset: 0x2CD1EA0 VA: 0x182CD34A0
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x2CD34F0 Offset: 0x2CD1EF0 VA: 0x182CD34F0
	public static bool op_Inequality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x2CD2E30 Offset: 0x2CD1830 VA: 0x182CD2E30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CD2F00 Offset: 0x2CD1900 VA: 0x182CD2F00 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x10DE440 Offset: 0x10DCE40 VA: 0x1810DE440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CD3010 Offset: 0x2CD1A10 VA: 0x182CD3010 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CD3020 Offset: 0x2CD1A20 VA: 0x182CD3020 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CD33D0 Offset: 0x2CD1DD0 VA: 0x182CD33D0
	public static Vector3Int get_zero() { }

	// RVA: 0x2CD3380 Offset: 0x2CD1D80 VA: 0x182CD3380
	public static Vector3Int get_one() { }

	// RVA: 0x2CD3230 Offset: 0x2CD1C30 VA: 0x182CD3230
	private static void .cctor() { }
}
