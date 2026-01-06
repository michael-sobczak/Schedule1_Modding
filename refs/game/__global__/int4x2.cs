public struct int4x2 : IEquatable<int4x2>, IFormattable // TypeDefIndex: 10933
{
	// Fields
	public int4 c0; // 0x0
	public int4 c1; // 0x10
	public static readonly int4x2 zero; // 0x0

	// Properties
	public int4 Item { get; }

	// Methods

	// RVA: 0x1330B70 Offset: 0x132F570 VA: 0x181330B70
	public void .ctor(int4 c0, int4 c1) { }

	// RVA: 0x28EE310 Offset: 0x28ECD10 VA: 0x1828EE310
	public void .ctor(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) { }

	// RVA: 0x28EE260 Offset: 0x28ECC60 VA: 0x1828EE260
	public void .ctor(int v) { }

	// RVA: 0x296AC70 Offset: 0x2969670 VA: 0x18296AC70
	public void .ctor(bool v) { }

	// RVA: 0x28EE360 Offset: 0x28ECD60 VA: 0x1828EE360
	public void .ctor(bool4x2 v) { }

	// RVA: 0x28EE260 Offset: 0x28ECC60 VA: 0x1828EE260
	public void .ctor(uint v) { }

	// RVA: 0x28EE2A0 Offset: 0x28ECCA0 VA: 0x1828EE2A0
	public void .ctor(uint4x2 v) { }

	// RVA: 0x296AC50 Offset: 0x2969650 VA: 0x18296AC50
	public void .ctor(float v) { }

	// RVA: 0x296AD80 Offset: 0x2969780 VA: 0x18296AD80
	public void .ctor(float4x2 v) { }

	// RVA: 0x296AD20 Offset: 0x2969720 VA: 0x18296AD20
	public void .ctor(double v) { }

	// RVA: 0x296ACA0 Offset: 0x29696A0 VA: 0x18296ACA0
	public void .ctor(double4x2 v) { }

	// RVA: 0x28A93D0 Offset: 0x28A7DD0 VA: 0x1828A93D0
	public static int4x2 op_Implicit(int v) { }

	// RVA: 0x28A94A0 Offset: 0x28A7EA0 VA: 0x1828A94A0
	public static int4x2 op_Explicit(bool v) { }

	// RVA: 0x28A9560 Offset: 0x28A7F60 VA: 0x1828A9560
	public static int4x2 op_Explicit(bool4x2 v) { }

	// RVA: 0x28A93D0 Offset: 0x28A7DD0 VA: 0x1828A93D0
	public static int4x2 op_Explicit(uint v) { }

	// RVA: 0x28A9410 Offset: 0x28A7E10 VA: 0x1828A9410
	public static int4x2 op_Explicit(uint4x2 v) { }

	// RVA: 0x28A9470 Offset: 0x28A7E70 VA: 0x1828A9470
	public static int4x2 op_Explicit(float v) { }

	// RVA: 0x28A94D0 Offset: 0x28A7ED0 VA: 0x1828A94D0
	public static int4x2 op_Explicit(float4x2 v) { }

	// RVA: 0x28A92F0 Offset: 0x28A7CF0 VA: 0x1828A92F0
	public static int4x2 op_Explicit(double v) { }

	// RVA: 0x28A9350 Offset: 0x28A7D50 VA: 0x1828A9350
	public static int4x2 op_Explicit(double4x2 v) { }

	// RVA: 0x28F0220 Offset: 0x28EEC20 VA: 0x1828F0220
	public static int4x2 op_Multiply(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28F0100 Offset: 0x28EEB00 VA: 0x1828F0100
	public static int4x2 op_Multiply(int4x2 lhs, int rhs) { }

	// RVA: 0x28F0190 Offset: 0x28EEB90 VA: 0x1828F0190
	public static int4x2 op_Multiply(int lhs, int4x2 rhs) { }

	// RVA: 0x28EE400 Offset: 0x28ECE00 VA: 0x1828EE400
	public static int4x2 op_Addition(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EE540 Offset: 0x28ECF40 VA: 0x1828EE540
	public static int4x2 op_Addition(int4x2 lhs, int rhs) { }

	// RVA: 0x28EE4C0 Offset: 0x28ECEC0 VA: 0x1828EE4C0
	public static int4x2 op_Addition(int lhs, int4x2 rhs) { }

	// RVA: 0x28F0500 Offset: 0x28EEF00 VA: 0x1828F0500
	public static int4x2 op_Subtraction(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28F03F0 Offset: 0x28EEDF0 VA: 0x1828F03F0
	public static int4x2 op_Subtraction(int4x2 lhs, int rhs) { }

	// RVA: 0x28F0470 Offset: 0x28EEE70 VA: 0x1828F0470
	public static int4x2 op_Subtraction(int lhs, int4x2 rhs) { }

	// RVA: 0x296AF40 Offset: 0x2969940 VA: 0x18296AF40
	public static int4x2 op_Division(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296AE10 Offset: 0x2969810 VA: 0x18296AE10
	public static int4x2 op_Division(int4x2 lhs, int rhs) { }

	// RVA: 0x296AEA0 Offset: 0x29698A0 VA: 0x18296AEA0
	public static int4x2 op_Division(int lhs, int4x2 rhs) { }

	// RVA: 0x296BC40 Offset: 0x296A640 VA: 0x18296BC40
	public static int4x2 op_Modulus(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296BB10 Offset: 0x296A510 VA: 0x18296BB10
	public static int4x2 op_Modulus(int4x2 lhs, int rhs) { }

	// RVA: 0x296BBA0 Offset: 0x296A5A0 VA: 0x18296BBA0
	public static int4x2 op_Modulus(int lhs, int4x2 rhs) { }

	// RVA: 0x28EF590 Offset: 0x28EDF90 VA: 0x1828EF590
	public static int4x2 op_Increment(int4x2 val) { }

	// RVA: 0x28EE890 Offset: 0x28ED290 VA: 0x1828EE890
	public static int4x2 op_Decrement(int4x2 val) { }

	// RVA: 0x296B930 Offset: 0x296A330 VA: 0x18296B930
	public static bool4x2 op_LessThan(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296BA50 Offset: 0x296A450 VA: 0x18296BA50
	public static bool4x2 op_LessThan(int4x2 lhs, int rhs) { }

	// RVA: 0x296B850 Offset: 0x296A250 VA: 0x18296B850
	public static bool4x2 op_LessThan(int lhs, int4x2 rhs) { }

	// RVA: 0x296B650 Offset: 0x296A050 VA: 0x18296B650
	public static bool4x2 op_LessThanOrEqual(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296B590 Offset: 0x2969F90 VA: 0x18296B590
	public static bool4x2 op_LessThanOrEqual(int4x2 lhs, int rhs) { }

	// RVA: 0x296B770 Offset: 0x296A170 VA: 0x18296B770
	public static bool4x2 op_LessThanOrEqual(int lhs, int4x2 rhs) { }

	// RVA: 0x296B3B0 Offset: 0x2969DB0 VA: 0x18296B3B0
	public static bool4x2 op_GreaterThan(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296B4D0 Offset: 0x2969ED0 VA: 0x18296B4D0
	public static bool4x2 op_GreaterThan(int4x2 lhs, int rhs) { }

	// RVA: 0x296B2D0 Offset: 0x2969CD0 VA: 0x18296B2D0
	public static bool4x2 op_GreaterThan(int lhs, int4x2 rhs) { }

	// RVA: 0x296B0D0 Offset: 0x2969AD0 VA: 0x18296B0D0
	public static bool4x2 op_GreaterThanOrEqual(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x296B010 Offset: 0x2969A10 VA: 0x18296B010
	public static bool4x2 op_GreaterThanOrEqual(int4x2 lhs, int rhs) { }

	// RVA: 0x296B1F0 Offset: 0x2969BF0 VA: 0x18296B1F0
	public static bool4x2 op_GreaterThanOrEqual(int lhs, int4x2 rhs) { }

	// RVA: 0x28F05C0 Offset: 0x28EEFC0 VA: 0x1828F05C0
	public static int4x2 op_UnaryNegation(int4x2 val) { }

	// RVA: 0x28F0640 Offset: 0x28EF040 VA: 0x1828F0640
	public static int4x2 op_UnaryPlus(int4x2 val) { }

	// RVA: 0x28EF8D0 Offset: 0x28EE2D0 VA: 0x1828EF8D0
	public static int4x2 op_LeftShift(int4x2 x, int n) { }

	// RVA: 0x296BD10 Offset: 0x296A710 VA: 0x18296BD10
	public static int4x2 op_RightShift(int4x2 x, int n) { }

	// RVA: 0x28EECD0 Offset: 0x28ED6D0 VA: 0x1828EECD0
	public static bool4x2 op_Equality(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EEC10 Offset: 0x28ED610 VA: 0x1828EEC10
	public static bool4x2 op_Equality(int4x2 lhs, int rhs) { }

	// RVA: 0x28EEB30 Offset: 0x28ED530 VA: 0x1828EEB30
	public static bool4x2 op_Equality(int lhs, int4x2 rhs) { }

	// RVA: 0x28EF6F0 Offset: 0x28EE0F0 VA: 0x1828EF6F0
	public static bool4x2 op_Inequality(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EF810 Offset: 0x28EE210 VA: 0x1828EF810
	public static bool4x2 op_Inequality(int4x2 lhs, int rhs) { }

	// RVA: 0x28EF610 Offset: 0x28EE010 VA: 0x1828EF610
	public static bool4x2 op_Inequality(int lhs, int4x2 rhs) { }

	// RVA: 0x28F02E0 Offset: 0x28EECE0 VA: 0x1828F02E0
	public static int4x2 op_OnesComplement(int4x2 val) { }

	// RVA: 0x28EE6D0 Offset: 0x28ED0D0 VA: 0x1828EE6D0
	public static int4x2 op_BitwiseAnd(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EE5D0 Offset: 0x28ECFD0 VA: 0x1828EE5D0
	public static int4x2 op_BitwiseAnd(int4x2 lhs, int rhs) { }

	// RVA: 0x28EE650 Offset: 0x28ED050 VA: 0x1828EE650
	public static int4x2 op_BitwiseAnd(int lhs, int4x2 rhs) { }

	// RVA: 0x270BB30 Offset: 0x270A530 VA: 0x18270BB30
	public static int4x2 op_BitwiseOr(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EE810 Offset: 0x28ED210 VA: 0x1828EE810
	public static int4x2 op_BitwiseOr(int4x2 lhs, int rhs) { }

	// RVA: 0x28EE790 Offset: 0x28ED190 VA: 0x1828EE790
	public static int4x2 op_BitwiseOr(int lhs, int4x2 rhs) { }

	// RVA: 0x270D1E0 Offset: 0x270BBE0 VA: 0x18270D1E0
	public static int4x2 op_ExclusiveOr(int4x2 lhs, int4x2 rhs) { }

	// RVA: 0x28EEE70 Offset: 0x28ED870 VA: 0x1828EEE70
	public static int4x2 op_ExclusiveOr(int4x2 lhs, int rhs) { }

	// RVA: 0x28EEDF0 Offset: 0x28ED7F0 VA: 0x1828EEDF0
	public static int4x2 op_ExclusiveOr(int lhs, int4x2 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref int4 get_Item(int index) { }

	// RVA: 0x28EDA30 Offset: 0x28EC430 VA: 0x1828EDA30 Slot: 4
	public bool Equals(int4x2 rhs) { }

	// RVA: 0x296A3B0 Offset: 0x2968DB0 VA: 0x18296A3B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x296A4A0 Offset: 0x2968EA0 VA: 0x18296A4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x296A530 Offset: 0x2968F30 VA: 0x18296A530 Slot: 3
	public override string ToString() { }

	// RVA: 0x296A8D0 Offset: 0x29692D0 VA: 0x18296A8D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
