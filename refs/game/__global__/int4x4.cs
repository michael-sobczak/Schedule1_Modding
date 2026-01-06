public struct int4x4 : IEquatable<int4x4>, IFormattable // TypeDefIndex: 10935
{
	// Fields
	public int4 c0; // 0x0
	public int4 c1; // 0x10
	public int4 c2; // 0x20
	public int4 c3; // 0x30
	public static readonly int4x4 identity; // 0x0
	public static readonly int4x4 zero; // 0x40

	// Properties
	public int4 Item { get; }

	// Methods

	// RVA: 0x28F5170 Offset: 0x28F3B70 VA: 0x1828F5170
	public void .ctor(int4 c0, int4 c1, int4 c2, int4 c3) { }

	// RVA: 0x28F5280 Offset: 0x28F3C80 VA: 0x1828F5280
	public void .ctor(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) { }

	// RVA: 0x28F5110 Offset: 0x28F3B10 VA: 0x1828F5110
	public void .ctor(int v) { }

	// RVA: 0x296EBE0 Offset: 0x296D5E0 VA: 0x18296EBE0
	public void .ctor(bool v) { }

	// RVA: 0x28849F0 Offset: 0x28833F0 VA: 0x1828849F0
	public void .ctor(bool4x4 v) { }

	// RVA: 0x28F5110 Offset: 0x28F3B10 VA: 0x1828F5110
	public void .ctor(uint v) { }

	// RVA: 0x28F51A0 Offset: 0x28F3BA0 VA: 0x1828F51A0
	public void .ctor(uint4x4 v) { }

	// RVA: 0x296EC20 Offset: 0x296D620 VA: 0x18296EC20
	public void .ctor(float v) { }

	// RVA: 0x2884B30 Offset: 0x2883530 VA: 0x182884B30
	public void .ctor(float4x4 v) { }

	// RVA: 0x296EB30 Offset: 0x296D530 VA: 0x18296EB30
	public void .ctor(double v) { }

	// RVA: 0x296EC60 Offset: 0x296D660 VA: 0x18296EC60
	public void .ctor(double4x4 v) { }

	// RVA: 0x28A9C90 Offset: 0x28A8690 VA: 0x1828A9C90
	public static int4x4 op_Implicit(int v) { }

	// RVA: 0x28A9B40 Offset: 0x28A8540 VA: 0x1828A9B40
	public static int4x4 op_Explicit(bool v) { }

	// RVA: 0x28F6D40 Offset: 0x28F5740 VA: 0x1828F6D40
	public static int4x4 op_Explicit(bool4x4 v) { }

	// RVA: 0x28A9C90 Offset: 0x28A8690 VA: 0x1828A9C90
	public static int4x4 op_Explicit(uint v) { }

	// RVA: 0x28A9E90 Offset: 0x28A8890 VA: 0x1828A9E90
	public static int4x4 op_Explicit(uint4x4 v) { }

	// RVA: 0x28A9CF0 Offset: 0x28A86F0 VA: 0x1828A9CF0
	public static int4x4 op_Explicit(float v) { }

	// RVA: 0x296F1F0 Offset: 0x296DBF0 VA: 0x18296F1F0
	public static int4x4 op_Explicit(float4x4 v) { }

	// RVA: 0x28AA020 Offset: 0x28A8A20 VA: 0x1828AA020
	public static int4x4 op_Explicit(double v) { }

	// RVA: 0x28A9F30 Offset: 0x28A8930 VA: 0x1828A9F30
	public static int4x4 op_Explicit(double4x4 v) { }

	// RVA: 0x28F8660 Offset: 0x28F7060 VA: 0x1828F8660
	public static int4x4 op_Multiply(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F8510 Offset: 0x28F6F10 VA: 0x1828F8510
	public static int4x4 op_Multiply(int4x4 lhs, int rhs) { }

	// RVA: 0x28F8820 Offset: 0x28F7220 VA: 0x1828F8820
	public static int4x4 op_Multiply(int lhs, int4x4 rhs) { }

	// RVA: 0x28F55B0 Offset: 0x28F3FB0 VA: 0x1828F55B0
	public static int4x4 op_Addition(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F5470 Offset: 0x28F3E70 VA: 0x1828F5470
	public static int4x4 op_Addition(int4x4 lhs, int rhs) { }

	// RVA: 0x28F5330 Offset: 0x28F3D30 VA: 0x1828F5330
	public static int4x4 op_Addition(int lhs, int4x4 rhs) { }

	// RVA: 0x28F8D10 Offset: 0x28F7710 VA: 0x1828F8D10
	public static int4x4 op_Subtraction(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F8BD0 Offset: 0x28F75D0 VA: 0x1828F8BD0
	public static int4x4 op_Subtraction(int4x4 lhs, int rhs) { }

	// RVA: 0x28F8EC0 Offset: 0x28F78C0 VA: 0x1828F8EC0
	public static int4x4 op_Subtraction(int lhs, int4x4 rhs) { }

	// RVA: 0x296F020 Offset: 0x296DA20 VA: 0x18296F020
	public static int4x4 op_Division(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296EEC0 Offset: 0x296D8C0 VA: 0x18296EEC0
	public static int4x4 op_Division(int4x4 lhs, int rhs) { }

	// RVA: 0x296ED50 Offset: 0x296D750 VA: 0x18296ED50
	public static int4x4 op_Division(int lhs, int4x4 rhs) { }

	// RVA: 0x29700B0 Offset: 0x296EAB0 VA: 0x1829700B0
	public static int4x4 op_Modulus(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296FF50 Offset: 0x296E950 VA: 0x18296FF50
	public static int4x4 op_Modulus(int4x4 lhs, int rhs) { }

	// RVA: 0x2970280 Offset: 0x296EC80 VA: 0x182970280
	public static int4x4 op_Modulus(int lhs, int4x4 rhs) { }

	// RVA: 0x28F7400 Offset: 0x28F5E00 VA: 0x1828F7400
	public static int4x4 op_Increment(int4x4 val) { }

	// RVA: 0x28F5FA0 Offset: 0x28F49A0 VA: 0x1828F5FA0
	public static int4x4 op_Decrement(int4x4 val) { }

	// RVA: 0x296FDF0 Offset: 0x296E7F0 VA: 0x18296FDF0
	public static bool4x4 op_LessThan(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296FD00 Offset: 0x296E700 VA: 0x18296FD00
	public static bool4x4 op_LessThan(int4x4 lhs, int rhs) { }

	// RVA: 0x296FC10 Offset: 0x296E610 VA: 0x18296FC10
	public static bool4x4 op_LessThan(int lhs, int4x4 rhs) { }

	// RVA: 0x296F9C0 Offset: 0x296E3C0 VA: 0x18296F9C0
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296F8D0 Offset: 0x296E2D0 VA: 0x18296F8D0
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int rhs) { }

	// RVA: 0x296FB20 Offset: 0x296E520 VA: 0x18296FB20
	public static bool4x4 op_LessThanOrEqual(int lhs, int4x4 rhs) { }

	// RVA: 0x296F590 Offset: 0x296DF90 VA: 0x18296F590
	public static bool4x4 op_GreaterThan(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296F6F0 Offset: 0x296E0F0 VA: 0x18296F6F0
	public static bool4x4 op_GreaterThan(int4x4 lhs, int rhs) { }

	// RVA: 0x296F7E0 Offset: 0x296E1E0 VA: 0x18296F7E0
	public static bool4x4 op_GreaterThan(int lhs, int4x4 rhs) { }

	// RVA: 0x296F340 Offset: 0x296DD40 VA: 0x18296F340
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x296F250 Offset: 0x296DC50 VA: 0x18296F250
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int rhs) { }

	// RVA: 0x296F4A0 Offset: 0x296DEA0 VA: 0x18296F4A0
	public static bool4x4 op_GreaterThanOrEqual(int lhs, int4x4 rhs) { }

	// RVA: 0x28F9020 Offset: 0x28F7A20 VA: 0x1828F9020
	public static int4x4 op_UnaryNegation(int4x4 val) { }

	// RVA: 0x28F9150 Offset: 0x28F7B50 VA: 0x1828F9150
	public static int4x4 op_UnaryPlus(int4x4 val) { }

	// RVA: 0x28F7880 Offset: 0x28F6280 VA: 0x1828F7880
	public static int4x4 op_LeftShift(int4x4 x, int n) { }

	// RVA: 0x29703F0 Offset: 0x296EDF0 VA: 0x1829703F0
	public static int4x4 op_RightShift(int4x4 x, int n) { }

	// RVA: 0x28F65B0 Offset: 0x28F4FB0 VA: 0x1828F65B0
	public static bool4x4 op_Equality(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F6800 Offset: 0x28F5200 VA: 0x1828F6800
	public static bool4x4 op_Equality(int4x4 lhs, int rhs) { }

	// RVA: 0x28F6710 Offset: 0x28F5110 VA: 0x1828F6710
	public static bool4x4 op_Equality(int lhs, int4x4 rhs) { }

	// RVA: 0x28F7720 Offset: 0x28F6120 VA: 0x1828F7720
	public static bool4x4 op_Inequality(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F7630 Offset: 0x28F6030 VA: 0x1828F7630
	public static bool4x4 op_Inequality(int4x4 lhs, int rhs) { }

	// RVA: 0x28F7540 Offset: 0x28F5F40 VA: 0x1828F7540
	public static bool4x4 op_Inequality(int lhs, int4x4 rhs) { }

	// RVA: 0x28F8960 Offset: 0x28F7360 VA: 0x1828F8960
	public static int4x4 op_OnesComplement(int4x4 val) { }

	// RVA: 0x28F5760 Offset: 0x28F4160 VA: 0x1828F5760
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F5A40 Offset: 0x28F4440 VA: 0x1828F5A40
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int rhs) { }

	// RVA: 0x28F5910 Offset: 0x28F4310 VA: 0x1828F5910
	public static int4x4 op_BitwiseAnd(int lhs, int4x4 rhs) { }

	// RVA: 0x28F5B80 Offset: 0x28F4580 VA: 0x1828F5B80
	public static int4x4 op_BitwiseOr(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F5D30 Offset: 0x28F4730 VA: 0x1828F5D30
	public static int4x4 op_BitwiseOr(int4x4 lhs, int rhs) { }

	// RVA: 0x28F5E70 Offset: 0x28F4870 VA: 0x1828F5E70
	public static int4x4 op_BitwiseOr(int lhs, int4x4 rhs) { }

	// RVA: 0x28F6B60 Offset: 0x28F5560 VA: 0x1828F6B60
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int4x4 rhs) { }

	// RVA: 0x28F68F0 Offset: 0x28F52F0 VA: 0x1828F68F0
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int rhs) { }

	// RVA: 0x28F6A30 Offset: 0x28F5430 VA: 0x1828F6A30
	public static int4x4 op_ExclusiveOr(int lhs, int4x4 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref int4 get_Item(int index) { }

	// RVA: 0x28E3960 Offset: 0x28E2360 VA: 0x1828E3960 Slot: 4
	public bool Equals(int4x4 rhs) { }

	// RVA: 0x296DCA0 Offset: 0x296C6A0 VA: 0x18296DCA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x296DD50 Offset: 0x296C750 VA: 0x18296DD50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x296E410 Offset: 0x296CE10 VA: 0x18296E410 Slot: 3
	public override string ToString() { }

	// RVA: 0x296DD90 Offset: 0x296C790 VA: 0x18296DD90 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x296EAC0 Offset: 0x296D4C0 VA: 0x18296EAC0
	private static void .cctor() { }
}
