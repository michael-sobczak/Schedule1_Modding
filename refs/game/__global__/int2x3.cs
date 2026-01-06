public struct int2x3 : IEquatable<int2x3>, IFormattable // TypeDefIndex: 10924
{
	// Fields
	public int2 c0; // 0x0
	public int2 c1; // 0x8
	public int2 c2; // 0x10
	public static readonly int2x3 zero; // 0x0

	// Properties
	public int2 Item { get; }

	// Methods

	// RVA: 0x1BA9540 Offset: 0x1BA7F40 VA: 0x181BA9540
	public void .ctor(int2 c0, int2 c1, int2 c2) { }

	// RVA: 0x2955FE0 Offset: 0x29549E0 VA: 0x182955FE0
	public void .ctor(int m00, int m01, int m02, int m10, int m11, int m12) { }

	// RVA: 0x2955F50 Offset: 0x2954950 VA: 0x182955F50
	public void .ctor(int v) { }

	// RVA: 0x28843C0 Offset: 0x2882DC0 VA: 0x1828843C0
	public void .ctor(bool v) { }

	// RVA: 0x28842D0 Offset: 0x2882CD0 VA: 0x1828842D0
	public void .ctor(bool2x3 v) { }

	// RVA: 0x2955F50 Offset: 0x2954950 VA: 0x182955F50
	public void .ctor(uint v) { }

	// RVA: 0x2955F90 Offset: 0x2954990 VA: 0x182955F90
	public void .ctor(uint2x3 v) { }

	// RVA: 0x2955EA0 Offset: 0x29548A0 VA: 0x182955EA0
	public void .ctor(float v) { }

	// RVA: 0x2955EF0 Offset: 0x29548F0 VA: 0x182955EF0
	public void .ctor(float2x3 v) { }

	// RVA: 0x2955DF0 Offset: 0x29547F0 VA: 0x182955DF0
	public void .ctor(double v) { }

	// RVA: 0x2955E40 Offset: 0x2954840 VA: 0x182955E40
	public void .ctor(double2x3 v) { }

	// RVA: 0x28A78D0 Offset: 0x28A62D0 VA: 0x1828A78D0
	public static int2x3 op_Implicit(int v) { }

	// RVA: 0x29569A0 Offset: 0x29553A0 VA: 0x1829569A0
	public static int2x3 op_Explicit(bool v) { }

	// RVA: 0x29569D0 Offset: 0x29553D0 VA: 0x1829569D0
	public static int2x3 op_Explicit(bool2x3 v) { }

	// RVA: 0x28A78D0 Offset: 0x28A62D0 VA: 0x1828A78D0
	public static int2x3 op_Explicit(uint v) { }

	// RVA: 0x28A7840 Offset: 0x28A6240 VA: 0x1828A7840
	public static int2x3 op_Explicit(uint2x3 v) { }

	// RVA: 0x28A77A0 Offset: 0x28A61A0 VA: 0x1828A77A0
	public static int2x3 op_Explicit(float v) { }

	// RVA: 0x28A7B70 Offset: 0x28A6570 VA: 0x1828A7B70
	public static int2x3 op_Explicit(float2x3 v) { }

	// RVA: 0x28A7910 Offset: 0x28A6310 VA: 0x1828A7910
	public static int2x3 op_Explicit(double v) { }

	// RVA: 0x28A7A80 Offset: 0x28A6480 VA: 0x1828A7A80
	public static int2x3 op_Explicit(double2x3 v) { }

	// RVA: 0x2957450 Offset: 0x2955E50 VA: 0x182957450
	public static int2x3 op_Multiply(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2957350 Offset: 0x2955D50 VA: 0x182957350
	public static int2x3 op_Multiply(int2x3 lhs, int rhs) { }

	// RVA: 0x29573D0 Offset: 0x2955DD0 VA: 0x1829573D0
	public static int2x3 op_Multiply(int lhs, int2x3 rhs) { }

	// RVA: 0x29560A0 Offset: 0x2954AA0 VA: 0x1829560A0
	public static int2x3 op_Addition(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956130 Offset: 0x2954B30 VA: 0x182956130
	public static int2x3 op_Addition(int2x3 lhs, int rhs) { }

	// RVA: 0x2956030 Offset: 0x2954A30 VA: 0x182956030
	public static int2x3 op_Addition(int lhs, int2x3 rhs) { }

	// RVA: 0x2957660 Offset: 0x2956060 VA: 0x182957660
	public static int2x3 op_Subtraction(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x29576F0 Offset: 0x29560F0 VA: 0x1829576F0
	public static int2x3 op_Subtraction(int2x3 lhs, int rhs) { }

	// RVA: 0x29575E0 Offset: 0x2955FE0 VA: 0x1829575E0
	public static int2x3 op_Subtraction(int lhs, int2x3 rhs) { }

	// RVA: 0x2956510 Offset: 0x2954F10 VA: 0x182956510
	public static int2x3 op_Division(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956640 Offset: 0x2955040 VA: 0x182956640
	public static int2x3 op_Division(int2x3 lhs, int rhs) { }

	// RVA: 0x29565B0 Offset: 0x2954FB0 VA: 0x1829565B0
	public static int2x3 op_Division(int lhs, int2x3 rhs) { }

	// RVA: 0x2957220 Offset: 0x2955C20 VA: 0x182957220
	public static int2x3 op_Modulus(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x29572C0 Offset: 0x2955CC0 VA: 0x1829572C0
	public static int2x3 op_Modulus(int2x3 lhs, int rhs) { }

	// RVA: 0x2957190 Offset: 0x2955B90 VA: 0x182957190
	public static int2x3 op_Modulus(int lhs, int2x3 rhs) { }

	// RVA: 0x2956CB0 Offset: 0x29556B0 VA: 0x182956CB0
	public static int2x3 op_Increment(int2x3 val) { }

	// RVA: 0x29564A0 Offset: 0x2954EA0 VA: 0x1829564A0
	public static int2x3 op_Decrement(int2x3 val) { }

	// RVA: 0x2957110 Offset: 0x2955B10 VA: 0x182957110
	public static bool2x3 op_LessThan(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2957040 Offset: 0x2955A40 VA: 0x182957040
	public static bool2x3 op_LessThan(int2x3 lhs, int rhs) { }

	// RVA: 0x29570B0 Offset: 0x2955AB0 VA: 0x1829570B0
	public static bool2x3 op_LessThan(int lhs, int2x3 rhs) { }

	// RVA: 0x2956F60 Offset: 0x2955960 VA: 0x182956F60
	public static bool2x3 op_LessThanOrEqual(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956EF0 Offset: 0x29558F0 VA: 0x182956EF0
	public static bool2x3 op_LessThanOrEqual(int2x3 lhs, int rhs) { }

	// RVA: 0x2956FE0 Offset: 0x29559E0 VA: 0x182956FE0
	public static bool2x3 op_LessThanOrEqual(int lhs, int2x3 rhs) { }

	// RVA: 0x2956B60 Offset: 0x2955560 VA: 0x182956B60
	public static bool2x3 op_GreaterThan(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956BE0 Offset: 0x29555E0 VA: 0x182956BE0
	public static bool2x3 op_GreaterThan(int2x3 lhs, int rhs) { }

	// RVA: 0x2956C50 Offset: 0x2955650 VA: 0x182956C50
	public static bool2x3 op_GreaterThan(int lhs, int2x3 rhs) { }

	// RVA: 0x2956AE0 Offset: 0x29554E0 VA: 0x182956AE0
	public static bool2x3 op_GreaterThanOrEqual(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956A10 Offset: 0x2955410 VA: 0x182956A10
	public static bool2x3 op_GreaterThanOrEqual(int2x3 lhs, int rhs) { }

	// RVA: 0x2956A80 Offset: 0x2955480 VA: 0x182956A80
	public static bool2x3 op_GreaterThanOrEqual(int lhs, int2x3 rhs) { }

	// RVA: 0x2957770 Offset: 0x2956170 VA: 0x182957770
	public static int2x3 op_UnaryNegation(int2x3 val) { }

	// RVA: 0x29577E0 Offset: 0x29561E0 VA: 0x1829577E0
	public static int2x3 op_UnaryPlus(int2x3 val) { }

	// RVA: 0x2956E70 Offset: 0x2955870 VA: 0x182956E70
	public static int2x3 op_LeftShift(int2x3 x, int n) { }

	// RVA: 0x2957560 Offset: 0x2955F60 VA: 0x182957560
	public static int2x3 op_RightShift(int2x3 x, int n) { }

	// RVA: 0x29566D0 Offset: 0x29550D0 VA: 0x1829566D0
	public static bool2x3 op_Equality(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956750 Offset: 0x2955150 VA: 0x182956750
	public static bool2x3 op_Equality(int2x3 lhs, int rhs) { }

	// RVA: 0x29567C0 Offset: 0x29551C0 VA: 0x1829567C0
	public static bool2x3 op_Equality(int lhs, int2x3 rhs) { }

	// RVA: 0x2956D20 Offset: 0x2955720 VA: 0x182956D20
	public static bool2x3 op_Inequality(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956DA0 Offset: 0x29557A0 VA: 0x182956DA0
	public static bool2x3 op_Inequality(int2x3 lhs, int rhs) { }

	// RVA: 0x2956E10 Offset: 0x2955810 VA: 0x182956E10
	public static bool2x3 op_Inequality(int lhs, int2x3 rhs) { }

	// RVA: 0x29574F0 Offset: 0x2955EF0 VA: 0x1829574F0
	public static int2x3 op_OnesComplement(int2x3 val) { }

	// RVA: 0x29561A0 Offset: 0x2954BA0 VA: 0x1829561A0
	public static int2x3 op_BitwiseAnd(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956230 Offset: 0x2954C30 VA: 0x182956230
	public static int2x3 op_BitwiseAnd(int2x3 lhs, int rhs) { }

	// RVA: 0x29562B0 Offset: 0x2954CB0 VA: 0x1829562B0
	public static int2x3 op_BitwiseAnd(int lhs, int2x3 rhs) { }

	// RVA: 0x2956390 Offset: 0x2954D90 VA: 0x182956390
	public static int2x3 op_BitwiseOr(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956420 Offset: 0x2954E20 VA: 0x182956420
	public static int2x3 op_BitwiseOr(int2x3 lhs, int rhs) { }

	// RVA: 0x2956320 Offset: 0x2954D20 VA: 0x182956320
	public static int2x3 op_BitwiseOr(int lhs, int2x3 rhs) { }

	// RVA: 0x2956910 Offset: 0x2955310 VA: 0x182956910
	public static int2x3 op_ExclusiveOr(int2x3 lhs, int2x3 rhs) { }

	// RVA: 0x2956890 Offset: 0x2955290 VA: 0x182956890
	public static int2x3 op_ExclusiveOr(int2x3 lhs, int rhs) { }

	// RVA: 0x2956820 Offset: 0x2955220 VA: 0x182956820
	public static int2x3 op_ExclusiveOr(int lhs, int2x3 rhs) { }

	// RVA: 0xF6CFF0 Offset: 0xF6B9F0 VA: 0x180F6CFF0
	public ref int2 get_Item(int index) { }

	// RVA: 0x29556B0 Offset: 0x29540B0 VA: 0x1829556B0 Slot: 4
	public bool Equals(int2x3 rhs) { }

	// RVA: 0x2955720 Offset: 0x2954120 VA: 0x182955720 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2955820 Offset: 0x2954220 VA: 0x182955820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2955850 Offset: 0x2954250 VA: 0x182955850 Slot: 3
	public override string ToString() { }

	// RVA: 0x2955B20 Offset: 0x2954520 VA: 0x182955B20 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
