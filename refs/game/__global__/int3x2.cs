public struct int3x2 : IEquatable<int3x2>, IFormattable // TypeDefIndex: 10928
{
	// Fields
	public int3 c0; // 0x0
	public int3 c1; // 0xC
	public static readonly int3x2 zero; // 0x0

	// Properties
	public int3 Item { get; }

	// Methods

	// RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	public void .ctor(int3 c0, int3 c1) { }

	// RVA: 0x295DE50 Offset: 0x295C850 VA: 0x18295DE50
	public void .ctor(int m00, int m01, int m10, int m11, int m20, int m21) { }

	// RVA: 0x295DF60 Offset: 0x295C960 VA: 0x18295DF60
	public void .ctor(int v) { }

	// RVA: 0x2884620 Offset: 0x2883020 VA: 0x182884620
	public void .ctor(bool v) { }

	// RVA: 0x295DDB0 Offset: 0x295C7B0 VA: 0x18295DDB0
	public void .ctor(bool3x2 v) { }

	// RVA: 0x295DF60 Offset: 0x295C960 VA: 0x18295DF60
	public void .ctor(uint v) { }

	// RVA: 0x295DEE0 Offset: 0x295C8E0 VA: 0x18295DEE0
	public void .ctor(uint3x2 v) { }

	// RVA: 0x295DE90 Offset: 0x295C890 VA: 0x18295DE90
	public void .ctor(float v) { }

	// RVA: 0x295DF90 Offset: 0x295C990 VA: 0x18295DF90
	public void .ctor(float3x2 v) { }

	// RVA: 0x295E000 Offset: 0x295CA00 VA: 0x18295E000
	public void .ctor(double v) { }

	// RVA: 0x295DD30 Offset: 0x295C730 VA: 0x18295DD30
	public void .ctor(double3x2 v) { }

	// RVA: 0x28A8370 Offset: 0x28A6D70 VA: 0x1828A8370
	public static int3x2 op_Implicit(int v) { }

	// RVA: 0x28A83B0 Offset: 0x28A6DB0 VA: 0x1828A83B0
	public static int3x2 op_Explicit(bool v) { }

	// RVA: 0x28A8420 Offset: 0x28A6E20 VA: 0x1828A8420
	public static int3x2 op_Explicit(bool3x2 v) { }

	// RVA: 0x28A8370 Offset: 0x28A6D70 VA: 0x1828A8370
	public static int3x2 op_Explicit(uint v) { }

	// RVA: 0x28A8220 Offset: 0x28A6C20 VA: 0x1828A8220
	public static int3x2 op_Explicit(uint3x2 v) { }

	// RVA: 0x28A84C0 Offset: 0x28A6EC0 VA: 0x1828A84C0
	public static int3x2 op_Explicit(float v) { }

	// RVA: 0x28A82A0 Offset: 0x28A6CA0 VA: 0x1828A82A0
	public static int3x2 op_Explicit(float3x2 v) { }

	// RVA: 0x28A8510 Offset: 0x28A6F10 VA: 0x1828A8510
	public static int3x2 op_Explicit(double v) { }

	// RVA: 0x28A81C0 Offset: 0x28A6BC0 VA: 0x1828A81C0
	public static int3x2 op_Explicit(double3x2 v) { }

	// RVA: 0x295FB70 Offset: 0x295E570 VA: 0x18295FB70
	public static int3x2 op_Multiply(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295FD00 Offset: 0x295E700 VA: 0x18295FD00
	public static int3x2 op_Multiply(int3x2 lhs, int rhs) { }

	// RVA: 0x295FC60 Offset: 0x295E660 VA: 0x18295FC60
	public static int3x2 op_Multiply(int lhs, int3x2 rhs) { }

	// RVA: 0x295E0E0 Offset: 0x295CAE0 VA: 0x18295E0E0
	public static int3x2 op_Addition(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295E050 Offset: 0x295CA50 VA: 0x18295E050
	public static int3x2 op_Addition(int3x2 lhs, int rhs) { }

	// RVA: 0x295E1D0 Offset: 0x295CBD0 VA: 0x18295E1D0
	public static int3x2 op_Addition(int lhs, int3x2 rhs) { }

	// RVA: 0x295FF70 Offset: 0x295E970 VA: 0x18295FF70
	public static int3x2 op_Subtraction(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x2960060 Offset: 0x295EA60 VA: 0x182960060
	public static int3x2 op_Subtraction(int3x2 lhs, int rhs) { }

	// RVA: 0x295FED0 Offset: 0x295E8D0 VA: 0x18295FED0
	public static int3x2 op_Subtraction(int lhs, int3x2 rhs) { }

	// RVA: 0x295E800 Offset: 0x295D200 VA: 0x18295E800
	public static int3x2 op_Division(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295E760 Offset: 0x295D160 VA: 0x18295E760
	public static int3x2 op_Division(int3x2 lhs, int rhs) { }

	// RVA: 0x295E900 Offset: 0x295D300 VA: 0x18295E900
	public static int3x2 op_Division(int lhs, int3x2 rhs) { }

	// RVA: 0x295F910 Offset: 0x295E310 VA: 0x18295F910
	public static int3x2 op_Modulus(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295FAC0 Offset: 0x295E4C0 VA: 0x18295FAC0
	public static int3x2 op_Modulus(int3x2 lhs, int rhs) { }

	// RVA: 0x295FA10 Offset: 0x295E410 VA: 0x18295FA10
	public static int3x2 op_Modulus(int lhs, int3x2 rhs) { }

	// RVA: 0x295F1E0 Offset: 0x295DBE0 VA: 0x18295F1E0
	public static int3x2 op_Increment(int3x2 val) { }

	// RVA: 0x295E6D0 Offset: 0x295D0D0 VA: 0x18295E6D0
	public static int3x2 op_Decrement(int3x2 val) { }

	// RVA: 0x295F7A0 Offset: 0x295E1A0 VA: 0x18295F7A0
	public static bool3x2 op_LessThan(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295F880 Offset: 0x295E280 VA: 0x18295F880
	public static bool3x2 op_LessThan(int3x2 lhs, int rhs) { }

	// RVA: 0x295F710 Offset: 0x295E110 VA: 0x18295F710
	public static bool3x2 op_LessThan(int lhs, int3x2 rhs) { }

	// RVA: 0x295F630 Offset: 0x295E030 VA: 0x18295F630
	public static bool3x2 op_LessThanOrEqual(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295F5A0 Offset: 0x295DFA0 VA: 0x18295F5A0
	public static bool3x2 op_LessThanOrEqual(int3x2 lhs, int rhs) { }

	// RVA: 0x295F510 Offset: 0x295DF10 VA: 0x18295F510
	public static bool3x2 op_LessThanOrEqual(int lhs, int3x2 rhs) { }

	// RVA: 0x295EFE0 Offset: 0x295D9E0 VA: 0x18295EFE0
	public static bool3x2 op_GreaterThan(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295F0C0 Offset: 0x295DAC0 VA: 0x18295F0C0
	public static bool3x2 op_GreaterThan(int3x2 lhs, int rhs) { }

	// RVA: 0x295F150 Offset: 0x295DB50 VA: 0x18295F150
	public static bool3x2 op_GreaterThan(int lhs, int3x2 rhs) { }

	// RVA: 0x295EE70 Offset: 0x295D870 VA: 0x18295EE70
	public static bool3x2 op_GreaterThanOrEqual(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295EF50 Offset: 0x295D950 VA: 0x18295EF50
	public static bool3x2 op_GreaterThanOrEqual(int3x2 lhs, int rhs) { }

	// RVA: 0x295EDE0 Offset: 0x295D7E0 VA: 0x18295EDE0
	public static bool3x2 op_GreaterThanOrEqual(int lhs, int3x2 rhs) { }

	// RVA: 0x2960100 Offset: 0x295EB00 VA: 0x182960100
	public static int3x2 op_UnaryNegation(int3x2 val) { }

	// RVA: 0x2960190 Offset: 0x295EB90 VA: 0x182960190
	public static int3x2 op_UnaryPlus(int3x2 val) { }

	// RVA: 0x295F470 Offset: 0x295DE70 VA: 0x18295F470
	public static int3x2 op_LeftShift(int3x2 x, int n) { }

	// RVA: 0x295FE30 Offset: 0x295E830 VA: 0x18295FE30
	public static int3x2 op_RightShift(int3x2 x, int n) { }

	// RVA: 0x295E9B0 Offset: 0x295D3B0 VA: 0x18295E9B0
	public static bool3x2 op_Equality(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295EA90 Offset: 0x295D490 VA: 0x18295EA90
	public static bool3x2 op_Equality(int3x2 lhs, int rhs) { }

	// RVA: 0x295EB20 Offset: 0x295D520 VA: 0x18295EB20
	public static bool3x2 op_Equality(int lhs, int3x2 rhs) { }

	// RVA: 0x295F270 Offset: 0x295DC70 VA: 0x18295F270
	public static bool3x2 op_Inequality(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295F350 Offset: 0x295DD50 VA: 0x18295F350
	public static bool3x2 op_Inequality(int3x2 lhs, int rhs) { }

	// RVA: 0x295F3E0 Offset: 0x295DDE0 VA: 0x18295F3E0
	public static bool3x2 op_Inequality(int lhs, int3x2 rhs) { }

	// RVA: 0x295FDA0 Offset: 0x295E7A0 VA: 0x18295FDA0
	public static int3x2 op_OnesComplement(int3x2 val) { }

	// RVA: 0x295E270 Offset: 0x295CC70 VA: 0x18295E270
	public static int3x2 op_BitwiseAnd(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295E400 Offset: 0x295CE00 VA: 0x18295E400
	public static int3x2 op_BitwiseAnd(int3x2 lhs, int rhs) { }

	// RVA: 0x295E360 Offset: 0x295CD60 VA: 0x18295E360
	public static int3x2 op_BitwiseAnd(int lhs, int3x2 rhs) { }

	// RVA: 0x295E540 Offset: 0x295CF40 VA: 0x18295E540
	public static int3x2 op_BitwiseOr(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295E4A0 Offset: 0x295CEA0 VA: 0x18295E4A0
	public static int3x2 op_BitwiseOr(int3x2 lhs, int rhs) { }

	// RVA: 0x295E630 Offset: 0x295D030 VA: 0x18295E630
	public static int3x2 op_BitwiseOr(int lhs, int3x2 rhs) { }

	// RVA: 0x295EC50 Offset: 0x295D650 VA: 0x18295EC50
	public static int3x2 op_ExclusiveOr(int3x2 lhs, int3x2 rhs) { }

	// RVA: 0x295EBB0 Offset: 0x295D5B0 VA: 0x18295EBB0
	public static int3x2 op_ExclusiveOr(int3x2 lhs, int rhs) { }

	// RVA: 0x295ED40 Offset: 0x295D740 VA: 0x18295ED40
	public static int3x2 op_ExclusiveOr(int lhs, int3x2 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref int3 get_Item(int index) { }

	// RVA: 0x295D5A0 Offset: 0x295BFA0 VA: 0x18295D5A0 Slot: 4
	public bool Equals(int3x2 rhs) { }

	// RVA: 0x295D620 Offset: 0x295C020 VA: 0x18295D620 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x295D710 Offset: 0x295C110 VA: 0x18295D710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x295DA60 Offset: 0x295C460 VA: 0x18295DA60 Slot: 3
	public override string ToString() { }

	// RVA: 0x295D790 Offset: 0x295C190 VA: 0x18295D790 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
