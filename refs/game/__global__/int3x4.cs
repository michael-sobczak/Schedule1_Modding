public struct int3x4 : IEquatable<int3x4>, IFormattable // TypeDefIndex: 10930
{
	// Fields
	public int3 c0; // 0x0
	public int3 c1; // 0xC
	public int3 c2; // 0x18
	public int3 c3; // 0x24
	public static readonly int3x4 zero; // 0x0

	// Properties
	public int3 Item { get; }

	// Methods

	// RVA: 0x28E5460 Offset: 0x28E3E60 VA: 0x1828E5460
	public void .ctor(int3 c0, int3 c1, int3 c2, int3 c3) { }

	// RVA: 0x28E52F0 Offset: 0x28E3CF0 VA: 0x1828E52F0
	public void .ctor(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) { }

	// RVA: 0x28E5290 Offset: 0x28E3C90 VA: 0x1828E5290
	public void .ctor(int v) { }

	// RVA: 0x2884730 Offset: 0x2883130 VA: 0x182884730
	public void .ctor(bool v) { }

	// RVA: 0x28847F0 Offset: 0x28831F0 VA: 0x1828847F0
	public void .ctor(bool3x4 v) { }

	// RVA: 0x28E5290 Offset: 0x28E3C90 VA: 0x1828E5290
	public void .ctor(uint v) { }

	// RVA: 0x28E5380 Offset: 0x28E3D80 VA: 0x1828E5380
	public void .ctor(uint3x4 v) { }

	// RVA: 0x29650F0 Offset: 0x2963AF0 VA: 0x1829650F0
	public void .ctor(float v) { }

	// RVA: 0x2965030 Offset: 0x2963A30 VA: 0x182965030
	public void .ctor(float3x4 v) { }

	// RVA: 0x2965180 Offset: 0x2963B80 VA: 0x182965180
	public void .ctor(double v) { }

	// RVA: 0x2965210 Offset: 0x2963C10 VA: 0x182965210
	public void .ctor(double3x4 v) { }

	// RVA: 0x28A8D10 Offset: 0x28A7710 VA: 0x1828A8D10
	public static int3x4 op_Implicit(int v) { }

	// RVA: 0x28E6FF0 Offset: 0x28E59F0 VA: 0x1828E6FF0
	public static int3x4 op_Explicit(bool v) { }

	// RVA: 0x28E6FB0 Offset: 0x28E59B0 VA: 0x1828E6FB0
	public static int3x4 op_Explicit(bool3x4 v) { }

	// RVA: 0x28A8D10 Offset: 0x28A7710 VA: 0x1828A8D10
	public static int3x4 op_Explicit(uint v) { }

	// RVA: 0x28A8FF0 Offset: 0x28A79F0 VA: 0x1828A8FF0
	public static int3x4 op_Explicit(uint3x4 v) { }

	// RVA: 0x28A8ED0 Offset: 0x28A78D0 VA: 0x1828A8ED0
	public static int3x4 op_Explicit(float v) { }

	// RVA: 0x28A8D70 Offset: 0x28A7770 VA: 0x1828A8D70
	public static int3x4 op_Explicit(float3x4 v) { }

	// RVA: 0x28A8E40 Offset: 0x28A7840 VA: 0x1828A8E40
	public static int3x4 op_Explicit(double v) { }

	// RVA: 0x28A8B40 Offset: 0x28A7540 VA: 0x1828A8B40
	public static int3x4 op_Explicit(double3x4 v) { }

	// RVA: 0x28E8DE0 Offset: 0x28E77E0 VA: 0x1828E8DE0
	public static int3x4 op_Multiply(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E8FE0 Offset: 0x28E79E0 VA: 0x1828E8FE0
	public static int3x4 op_Multiply(int3x4 lhs, int rhs) { }

	// RVA: 0x28E8CA0 Offset: 0x28E76A0 VA: 0x1828E8CA0
	public static int3x4 op_Multiply(int lhs, int3x4 rhs) { }

	// RVA: 0x28E54B0 Offset: 0x28E3EB0 VA: 0x1828E54B0
	public static int3x4 op_Addition(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E56B0 Offset: 0x28E40B0 VA: 0x1828E56B0
	public static int3x4 op_Addition(int3x4 lhs, int rhs) { }

	// RVA: 0x28E57D0 Offset: 0x28E41D0 VA: 0x1828E57D0
	public static int3x4 op_Addition(int lhs, int3x4 rhs) { }

	// RVA: 0x28E95A0 Offset: 0x28E7FA0 VA: 0x1828E95A0
	public static int3x4 op_Subtraction(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E9350 Offset: 0x28E7D50 VA: 0x1828E9350
	public static int3x4 op_Subtraction(int3x4 lhs, int rhs) { }

	// RVA: 0x28E9470 Offset: 0x28E7E70 VA: 0x1828E9470
	public static int3x4 op_Subtraction(int lhs, int3x4 rhs) { }

	// RVA: 0x29652F0 Offset: 0x2963CF0 VA: 0x1829652F0
	public static int3x4 op_Division(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2965500 Offset: 0x2963F00 VA: 0x182965500
	public static int3x4 op_Division(int3x4 lhs, int rhs) { }

	// RVA: 0x2965640 Offset: 0x2964040 VA: 0x182965640
	public static int3x4 op_Division(int lhs, int3x4 rhs) { }

	// RVA: 0x29669D0 Offset: 0x29653D0 VA: 0x1829669D0
	public static int3x4 op_Modulus(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2966890 Offset: 0x2965290 VA: 0x182966890
	public static int3x4 op_Modulus(int3x4 lhs, int rhs) { }

	// RVA: 0x2966BE0 Offset: 0x29655E0 VA: 0x182966BE0
	public static int3x4 op_Modulus(int lhs, int3x4 rhs) { }

	// RVA: 0x28E78D0 Offset: 0x28E62D0 VA: 0x1828E78D0
	public static int3x4 op_Increment(int3x4 val) { }

	// RVA: 0x28E6130 Offset: 0x28E4B30 VA: 0x1828E6130
	public static int3x4 op_Decrement(int3x4 val) { }

	// RVA: 0x2966570 Offset: 0x2964F70 VA: 0x182966570
	public static bool3x4 op_LessThan(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2966770 Offset: 0x2965170 VA: 0x182966770
	public static bool3x4 op_LessThan(int3x4 lhs, int rhs) { }

	// RVA: 0x2966450 Offset: 0x2964E50 VA: 0x182966450
	public static bool3x4 op_LessThan(int lhs, int3x4 rhs) { }

	// RVA: 0x2966250 Offset: 0x2964C50 VA: 0x182966250
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2966130 Offset: 0x2964B30 VA: 0x182966130
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int rhs) { }

	// RVA: 0x2966010 Offset: 0x2964A10 VA: 0x182966010
	public static bool3x4 op_LessThanOrEqual(int lhs, int3x4 rhs) { }

	// RVA: 0x2965E10 Offset: 0x2964810 VA: 0x182965E10
	public static bool3x4 op_GreaterThan(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2965BD0 Offset: 0x29645D0 VA: 0x182965BD0
	public static bool3x4 op_GreaterThan(int3x4 lhs, int rhs) { }

	// RVA: 0x2965CF0 Offset: 0x29646F0 VA: 0x182965CF0
	public static bool3x4 op_GreaterThan(int lhs, int3x4 rhs) { }

	// RVA: 0x29658B0 Offset: 0x29642B0 VA: 0x1829658B0
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x2965790 Offset: 0x2964190 VA: 0x182965790
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int rhs) { }

	// RVA: 0x2965AB0 Offset: 0x29644B0 VA: 0x182965AB0
	public static bool3x4 op_GreaterThanOrEqual(int lhs, int3x4 rhs) { }

	// RVA: 0x28E9780 Offset: 0x28E8180 VA: 0x1828E9780
	public static int3x4 op_UnaryNegation(int3x4 val) { }

	// RVA: 0x28E98A0 Offset: 0x28E82A0 VA: 0x1828E98A0
	public static int3x4 op_UnaryPlus(int3x4 val) { }

	// RVA: 0x28E7E50 Offset: 0x28E6850 VA: 0x1828E7E50
	public static int3x4 op_LeftShift(int3x4 x, int n) { }

	// RVA: 0x2966D30 Offset: 0x2965730 VA: 0x182966D30
	public static int3x4 op_RightShift(int3x4 x, int n) { }

	// RVA: 0x28E6840 Offset: 0x28E5240 VA: 0x1828E6840
	public static bool3x4 op_Equality(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E6720 Offset: 0x28E5120 VA: 0x1828E6720
	public static bool3x4 op_Equality(int3x4 lhs, int rhs) { }

	// RVA: 0x28E6A40 Offset: 0x28E5440 VA: 0x1828E6A40
	public static bool3x4 op_Equality(int lhs, int3x4 rhs) { }

	// RVA: 0x28E7A10 Offset: 0x28E6410 VA: 0x1828E7A10
	public static bool3x4 op_Inequality(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E7D30 Offset: 0x28E6730 VA: 0x1828E7D30
	public static bool3x4 op_Inequality(int3x4 lhs, int rhs) { }

	// RVA: 0x28E7C10 Offset: 0x28E6610 VA: 0x1828E7C10
	public static bool3x4 op_Inequality(int lhs, int3x4 rhs) { }

	// RVA: 0x28E9110 Offset: 0x28E7B10 VA: 0x1828E9110
	public static int3x4 op_OnesComplement(int3x4 val) { }

	// RVA: 0x28E5B30 Offset: 0x28E4530 VA: 0x1828E5B30
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E58F0 Offset: 0x28E42F0 VA: 0x1828E58F0
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int rhs) { }

	// RVA: 0x28E5A10 Offset: 0x28E4410 VA: 0x1828E5A10
	public static int3x4 op_BitwiseAnd(int lhs, int3x4 rhs) { }

	// RVA: 0x28E5F50 Offset: 0x28E4950 VA: 0x1828E5F50
	public static int3x4 op_BitwiseOr(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E5D10 Offset: 0x28E4710 VA: 0x1828E5D10
	public static int3x4 op_BitwiseOr(int3x4 lhs, int rhs) { }

	// RVA: 0x28E5E30 Offset: 0x28E4830 VA: 0x1828E5E30
	public static int3x4 op_BitwiseOr(int lhs, int3x4 rhs) { }

	// RVA: 0x28E6DA0 Offset: 0x28E57A0 VA: 0x1828E6DA0
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int3x4 rhs) { }

	// RVA: 0x28E6B60 Offset: 0x28E5560 VA: 0x1828E6B60
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int rhs) { }

	// RVA: 0x28E6C80 Offset: 0x28E5680 VA: 0x1828E6C80
	public static int3x4 op_ExclusiveOr(int lhs, int3x4 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref int3 get_Item(int index) { }

	// RVA: 0x28E1950 Offset: 0x28E0350 VA: 0x1828E1950 Slot: 4
	public bool Equals(int3x4 rhs) { }

	// RVA: 0x2964480 Offset: 0x2962E80 VA: 0x182964480 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2964530 Offset: 0x2962F30 VA: 0x182964530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2964630 Offset: 0x2963030 VA: 0x182964630 Slot: 3
	public override string ToString() { }

	// RVA: 0x2964B40 Offset: 0x2963540 VA: 0x182964B40 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
