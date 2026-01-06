public struct uint3x2 : IEquatable<uint3x2>, IFormattable // TypeDefIndex: 10949
{
	// Fields
	public uint3 c0; // 0x0
	public uint3 c1; // 0xC
	public static readonly uint3x2 zero; // 0x0

	// Properties
	public uint3 Item { get; }

	// Methods

	// RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	public void .ctor(uint3 c0, uint3 c1) { }

	// RVA: 0x295DE50 Offset: 0x295C850 VA: 0x18295DE50
	public void .ctor(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) { }

	// RVA: 0x295DF60 Offset: 0x295C960 VA: 0x18295DF60
	public void .ctor(uint v) { }

	// RVA: 0x2884620 Offset: 0x2883020 VA: 0x182884620
	public void .ctor(bool v) { }

	// RVA: 0x295DDB0 Offset: 0x295C7B0 VA: 0x18295DDB0
	public void .ctor(bool3x2 v) { }

	// RVA: 0x295DF60 Offset: 0x295C960 VA: 0x18295DF60
	public void .ctor(int v) { }

	// RVA: 0x295DEE0 Offset: 0x295C8E0 VA: 0x18295DEE0
	public void .ctor(int3x2 v) { }

	// RVA: 0x2887D90 Offset: 0x2886790 VA: 0x182887D90
	public void .ctor(float v) { }

	// RVA: 0x2887E30 Offset: 0x2886830 VA: 0x182887E30
	public void .ctor(float3x2 v) { }

	// RVA: 0x2887F00 Offset: 0x2886900 VA: 0x182887F00
	public void .ctor(double v) { }

	// RVA: 0x2887FA0 Offset: 0x28869A0 VA: 0x182887FA0
	public void .ctor(double3x2 v) { }

	// RVA: 0x28A8370 Offset: 0x28A6D70 VA: 0x1828A8370
	public static uint3x2 op_Implicit(uint v) { }

	// RVA: 0x28A83B0 Offset: 0x28A6DB0 VA: 0x1828A83B0
	public static uint3x2 op_Explicit(bool v) { }

	// RVA: 0x28A8420 Offset: 0x28A6E20 VA: 0x1828A8420
	public static uint3x2 op_Explicit(bool3x2 v) { }

	// RVA: 0x28A8370 Offset: 0x28A6D70 VA: 0x1828A8370
	public static uint3x2 op_Explicit(int v) { }

	// RVA: 0x28A8220 Offset: 0x28A6C20 VA: 0x1828A8220
	public static uint3x2 op_Explicit(int3x2 v) { }

	// RVA: 0x2990F70 Offset: 0x298F970 VA: 0x182990F70
	public static uint3x2 op_Explicit(float v) { }

	// RVA: 0x2991020 Offset: 0x298FA20 VA: 0x182991020
	public static uint3x2 op_Explicit(float3x2 v) { }

	// RVA: 0x2990FA0 Offset: 0x298F9A0 VA: 0x182990FA0
	public static uint3x2 op_Explicit(double v) { }

	// RVA: 0x2990FD0 Offset: 0x298F9D0 VA: 0x182990FD0
	public static uint3x2 op_Explicit(double3x2 v) { }

	// RVA: 0x295FB70 Offset: 0x295E570 VA: 0x18295FB70
	public static uint3x2 op_Multiply(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295FD00 Offset: 0x295E700 VA: 0x18295FD00
	public static uint3x2 op_Multiply(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295FC60 Offset: 0x295E660 VA: 0x18295FC60
	public static uint3x2 op_Multiply(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295E0E0 Offset: 0x295CAE0 VA: 0x18295E0E0
	public static uint3x2 op_Addition(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295E050 Offset: 0x295CA50 VA: 0x18295E050
	public static uint3x2 op_Addition(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295E1D0 Offset: 0x295CBD0 VA: 0x18295E1D0
	public static uint3x2 op_Addition(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295FF70 Offset: 0x295E970 VA: 0x18295FF70
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x2960060 Offset: 0x295EA60 VA: 0x182960060
	public static uint3x2 op_Subtraction(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295FED0 Offset: 0x295E8D0 VA: 0x18295FED0
	public static uint3x2 op_Subtraction(uint lhs, uint3x2 rhs) { }

	// RVA: 0x2990E70 Offset: 0x298F870 VA: 0x182990E70
	public static uint3x2 op_Division(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x2990DC0 Offset: 0x298F7C0 VA: 0x182990DC0
	public static uint3x2 op_Division(uint3x2 lhs, uint rhs) { }

	// RVA: 0x2990D10 Offset: 0x298F710 VA: 0x182990D10
	public static uint3x2 op_Division(uint lhs, uint3x2 rhs) { }

	// RVA: 0x2991860 Offset: 0x2990260 VA: 0x182991860
	public static uint3x2 op_Modulus(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x2991960 Offset: 0x2990360 VA: 0x182991960
	public static uint3x2 op_Modulus(uint3x2 lhs, uint rhs) { }

	// RVA: 0x2991A10 Offset: 0x2990410 VA: 0x182991A10
	public static uint3x2 op_Modulus(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295F1E0 Offset: 0x295DBE0 VA: 0x18295F1E0
	public static uint3x2 op_Increment(uint3x2 val) { }

	// RVA: 0x295E6D0 Offset: 0x295D0D0 VA: 0x18295E6D0
	public static uint3x2 op_Decrement(uint3x2 val) { }

	// RVA: 0x29916F0 Offset: 0x29900F0 VA: 0x1829916F0
	public static bool3x2 op_LessThan(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x2991660 Offset: 0x2990060 VA: 0x182991660
	public static bool3x2 op_LessThan(uint3x2 lhs, uint rhs) { }

	// RVA: 0x29917D0 Offset: 0x29901D0 VA: 0x1829917D0
	public static bool3x2 op_LessThan(uint lhs, uint3x2 rhs) { }

	// RVA: 0x2991580 Offset: 0x298FF80 VA: 0x182991580
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x29914F0 Offset: 0x298FEF0 VA: 0x1829914F0
	public static bool3x2 op_LessThanOrEqual(uint3x2 lhs, uint rhs) { }

	// RVA: 0x2991460 Offset: 0x298FE60 VA: 0x182991460
	public static bool3x2 op_LessThanOrEqual(uint lhs, uint3x2 rhs) { }

	// RVA: 0x2991260 Offset: 0x298FC60 VA: 0x182991260
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x2991340 Offset: 0x298FD40 VA: 0x182991340
	public static bool3x2 op_GreaterThan(uint3x2 lhs, uint rhs) { }

	// RVA: 0x29913D0 Offset: 0x298FDD0 VA: 0x1829913D0
	public static bool3x2 op_GreaterThan(uint lhs, uint3x2 rhs) { }

	// RVA: 0x29910F0 Offset: 0x298FAF0 VA: 0x1829910F0
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x29911D0 Offset: 0x298FBD0 VA: 0x1829911D0
	public static bool3x2 op_GreaterThanOrEqual(uint3x2 lhs, uint rhs) { }

	// RVA: 0x2991060 Offset: 0x298FA60 VA: 0x182991060
	public static bool3x2 op_GreaterThanOrEqual(uint lhs, uint3x2 rhs) { }

	// RVA: 0x2960100 Offset: 0x295EB00 VA: 0x182960100
	public static uint3x2 op_UnaryNegation(uint3x2 val) { }

	// RVA: 0x2960190 Offset: 0x295EB90 VA: 0x182960190
	public static uint3x2 op_UnaryPlus(uint3x2 val) { }

	// RVA: 0x295F470 Offset: 0x295DE70 VA: 0x18295F470
	public static uint3x2 op_LeftShift(uint3x2 x, int n) { }

	// RVA: 0x2991AC0 Offset: 0x29904C0 VA: 0x182991AC0
	public static uint3x2 op_RightShift(uint3x2 x, int n) { }

	// RVA: 0x295E9B0 Offset: 0x295D3B0 VA: 0x18295E9B0
	public static bool3x2 op_Equality(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295EA90 Offset: 0x295D490 VA: 0x18295EA90
	public static bool3x2 op_Equality(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295EB20 Offset: 0x295D520 VA: 0x18295EB20
	public static bool3x2 op_Equality(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295F270 Offset: 0x295DC70 VA: 0x18295F270
	public static bool3x2 op_Inequality(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295F350 Offset: 0x295DD50 VA: 0x18295F350
	public static bool3x2 op_Inequality(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295F3E0 Offset: 0x295DDE0 VA: 0x18295F3E0
	public static bool3x2 op_Inequality(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295FDA0 Offset: 0x295E7A0 VA: 0x18295FDA0
	public static uint3x2 op_OnesComplement(uint3x2 val) { }

	// RVA: 0x295E270 Offset: 0x295CC70 VA: 0x18295E270
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295E400 Offset: 0x295CE00 VA: 0x18295E400
	public static uint3x2 op_BitwiseAnd(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295E360 Offset: 0x295CD60 VA: 0x18295E360
	public static uint3x2 op_BitwiseAnd(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295E540 Offset: 0x295CF40 VA: 0x18295E540
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295E4A0 Offset: 0x295CEA0 VA: 0x18295E4A0
	public static uint3x2 op_BitwiseOr(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295E630 Offset: 0x295D030 VA: 0x18295E630
	public static uint3x2 op_BitwiseOr(uint lhs, uint3x2 rhs) { }

	// RVA: 0x295EC50 Offset: 0x295D650 VA: 0x18295EC50
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint3x2 rhs) { }

	// RVA: 0x295EBB0 Offset: 0x295D5B0 VA: 0x18295EBB0
	public static uint3x2 op_ExclusiveOr(uint3x2 lhs, uint rhs) { }

	// RVA: 0x295ED40 Offset: 0x295D740 VA: 0x18295ED40
	public static uint3x2 op_ExclusiveOr(uint lhs, uint3x2 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref uint3 get_Item(int index) { }

	// RVA: 0x295D5A0 Offset: 0x295BFA0 VA: 0x18295D5A0 Slot: 4
	public bool Equals(uint3x2 rhs) { }

	// RVA: 0x2990600 Offset: 0x298F000 VA: 0x182990600 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29906F0 Offset: 0x298F0F0 VA: 0x1829906F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2990A40 Offset: 0x298F440 VA: 0x182990A40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2990770 Offset: 0x298F170 VA: 0x182990770 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
