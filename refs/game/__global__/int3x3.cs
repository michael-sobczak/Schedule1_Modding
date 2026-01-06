public struct int3x3 : IEquatable<int3x3>, IFormattable // TypeDefIndex: 10929
{
	// Fields
	public int3 c0; // 0x0
	public int3 c1; // 0xC
	public int3 c2; // 0x18
	public static readonly int3x3 identity; // 0x0
	public static readonly int3x3 zero; // 0x24

	// Properties
	public int3 Item { get; }

	// Methods

	// RVA: 0x2933DF0 Offset: 0x29327F0 VA: 0x182933DF0
	public void .ctor(int3 c0, int3 c1, int3 c2) { }

	// RVA: 0x2960F10 Offset: 0x295F910 VA: 0x182960F10
	public void .ctor(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) { }

	// RVA: 0x2960E50 Offset: 0x295F850 VA: 0x182960E50
	public void .ctor(int v) { }

	// RVA: 0x2884690 Offset: 0x2883090 VA: 0x182884690
	public void .ctor(bool v) { }

	// RVA: 0x2960CE0 Offset: 0x295F6E0 VA: 0x182960CE0
	public void .ctor(bool3x3 v) { }

	// RVA: 0x2960E50 Offset: 0x295F850 VA: 0x182960E50
	public void .ctor(uint v) { }

	// RVA: 0x2960F70 Offset: 0x295F970 VA: 0x182960F70
	public void .ctor(uint3x3 v) { }

	// RVA: 0x29610D0 Offset: 0x295FAD0 VA: 0x1829610D0
	public void .ctor(float v) { }

	// RVA: 0x2960DB0 Offset: 0x295F7B0 VA: 0x182960DB0
	public void .ctor(float3x3 v) { }

	// RVA: 0x2960EA0 Offset: 0x295F8A0 VA: 0x182960EA0
	public void .ctor(double v) { }

	// RVA: 0x2961020 Offset: 0x295FA20 VA: 0x182961020
	public void .ctor(double3x3 v) { }

	// RVA: 0x28A8560 Offset: 0x28A6F60 VA: 0x1828A8560
	public static int3x3 op_Implicit(int v) { }

	// RVA: 0x2962540 Offset: 0x2960F40 VA: 0x182962540
	public static int3x3 op_Explicit(bool v) { }

	// RVA: 0x28A8900 Offset: 0x28A7300 VA: 0x1828A8900
	public static int3x3 op_Explicit(bool3x3 v) { }

	// RVA: 0x28A8560 Offset: 0x28A6F60 VA: 0x1828A8560
	public static int3x3 op_Explicit(uint v) { }

	// RVA: 0x28A8620 Offset: 0x28A7020 VA: 0x1828A8620
	public static int3x3 op_Explicit(uint3x3 v) { }

	// RVA: 0x28A85B0 Offset: 0x28A6FB0 VA: 0x1828A85B0
	public static int3x3 op_Explicit(float v) { }

	// RVA: 0x28A8780 Offset: 0x28A7180 VA: 0x1828A8780
	public static int3x3 op_Explicit(float3x3 v) { }

	// RVA: 0x28A8890 Offset: 0x28A7290 VA: 0x1828A8890
	public static int3x3 op_Explicit(double v) { }

	// RVA: 0x28A86D0 Offset: 0x28A70D0 VA: 0x1828A86D0
	public static int3x3 op_Explicit(double3x3 v) { }

	// RVA: 0x2963AF0 Offset: 0x29624F0 VA: 0x182963AF0
	public static int3x3 op_Multiply(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2963D50 Offset: 0x2962750 VA: 0x182963D50
	public static int3x3 op_Multiply(int3x3 lhs, int rhs) { }

	// RVA: 0x2963C70 Offset: 0x2962670 VA: 0x182963C70
	public static int3x3 op_Multiply(int lhs, int3x3 rhs) { }

	// RVA: 0x2961140 Offset: 0x295FB40 VA: 0x182961140
	public static int3x3 op_Addition(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x29612C0 Offset: 0x295FCC0 VA: 0x1829612C0
	public static int3x3 op_Addition(int3x3 lhs, int rhs) { }

	// RVA: 0x29613A0 Offset: 0x295FDA0 VA: 0x1829613A0
	public static int3x3 op_Addition(int lhs, int3x3 rhs) { }

	// RVA: 0x2964190 Offset: 0x2962B90 VA: 0x182964190
	public static int3x3 op_Subtraction(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2963FE0 Offset: 0x29629E0 VA: 0x182963FE0
	public static int3x3 op_Subtraction(int3x3 lhs, int rhs) { }

	// RVA: 0x29640B0 Offset: 0x2962AB0 VA: 0x1829640B0
	public static int3x3 op_Subtraction(int lhs, int3x3 rhs) { }

	// RVA: 0x2961B80 Offset: 0x2960580 VA: 0x182961B80
	public static int3x3 op_Division(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2961E00 Offset: 0x2960800 VA: 0x182961E00
	public static int3x3 op_Division(int3x3 lhs, int rhs) { }

	// RVA: 0x2961D00 Offset: 0x2960700 VA: 0x182961D00
	public static int3x3 op_Division(int lhs, int3x3 rhs) { }

	// RVA: 0x2963780 Offset: 0x2962180 VA: 0x182963780
	public static int3x3 op_Modulus(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2963A00 Offset: 0x2962400 VA: 0x182963A00
	public static int3x3 op_Modulus(int3x3 lhs, int rhs) { }

	// RVA: 0x2963900 Offset: 0x2962300 VA: 0x182963900
	public static int3x3 op_Modulus(int lhs, int3x3 rhs) { }

	// RVA: 0x2962BF0 Offset: 0x29615F0 VA: 0x182962BF0
	public static int3x3 op_Increment(int3x3 val) { }

	// RVA: 0x2961A90 Offset: 0x2960490 VA: 0x182961A90
	public static int3x3 op_Decrement(int3x3 val) { }

	// RVA: 0x2963440 Offset: 0x2961E40 VA: 0x182963440
	public static bool3x3 op_LessThan(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x29636A0 Offset: 0x29620A0 VA: 0x1829636A0
	public static bool3x3 op_LessThan(int3x3 lhs, int rhs) { }

	// RVA: 0x29635C0 Offset: 0x2961FC0 VA: 0x1829635C0
	public static bool3x3 op_LessThan(int lhs, int3x3 rhs) { }

	// RVA: 0x2963100 Offset: 0x2961B00 VA: 0x182963100
	public static bool3x3 op_LessThanOrEqual(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2963280 Offset: 0x2961C80 VA: 0x182963280
	public static bool3x3 op_LessThanOrEqual(int3x3 lhs, int rhs) { }

	// RVA: 0x2963360 Offset: 0x2961D60 VA: 0x182963360
	public static bool3x3 op_LessThanOrEqual(int lhs, int3x3 rhs) { }

	// RVA: 0x2962A70 Offset: 0x2961470 VA: 0x182962A70
	public static bool3x3 op_GreaterThan(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2962990 Offset: 0x2961390 VA: 0x182962990
	public static bool3x3 op_GreaterThan(int3x3 lhs, int rhs) { }

	// RVA: 0x29628B0 Offset: 0x29612B0 VA: 0x1829628B0
	public static bool3x3 op_GreaterThan(int lhs, int3x3 rhs) { }

	// RVA: 0x2962650 Offset: 0x2961050 VA: 0x182962650
	public static bool3x3 op_GreaterThanOrEqual(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2962570 Offset: 0x2960F70 VA: 0x182962570
	public static bool3x3 op_GreaterThanOrEqual(int3x3 lhs, int rhs) { }

	// RVA: 0x29627D0 Offset: 0x29611D0 VA: 0x1829627D0
	public static bool3x3 op_GreaterThanOrEqual(int lhs, int3x3 rhs) { }

	// RVA: 0x29642F0 Offset: 0x2962CF0 VA: 0x1829642F0
	public static int3x3 op_UnaryNegation(int3x3 val) { }

	// RVA: 0x29643C0 Offset: 0x2962DC0 VA: 0x1829643C0
	public static int3x3 op_UnaryPlus(int3x3 val) { }

	// RVA: 0x2963020 Offset: 0x2961A20 VA: 0x182963020
	public static int3x3 op_LeftShift(int3x3 x, int n) { }

	// RVA: 0x2963F00 Offset: 0x2962900 VA: 0x182963F00
	public static int3x3 op_RightShift(int3x3 x, int n) { }

	// RVA: 0x29620B0 Offset: 0x2960AB0 VA: 0x1829620B0
	public static bool3x3 op_Equality(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2961FD0 Offset: 0x29609D0 VA: 0x182961FD0
	public static bool3x3 op_Equality(int3x3 lhs, int rhs) { }

	// RVA: 0x2961EF0 Offset: 0x29608F0 VA: 0x182961EF0
	public static bool3x3 op_Equality(int lhs, int3x3 rhs) { }

	// RVA: 0x2962EA0 Offset: 0x29618A0 VA: 0x182962EA0
	public static bool3x3 op_Inequality(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2962CE0 Offset: 0x29616E0 VA: 0x182962CE0
	public static bool3x3 op_Inequality(int3x3 lhs, int rhs) { }

	// RVA: 0x2962DC0 Offset: 0x29617C0 VA: 0x182962DC0
	public static bool3x3 op_Inequality(int lhs, int3x3 rhs) { }

	// RVA: 0x2963E30 Offset: 0x2962830 VA: 0x182963E30
	public static int3x3 op_OnesComplement(int3x3 val) { }

	// RVA: 0x2961470 Offset: 0x295FE70 VA: 0x182961470
	public static int3x3 op_BitwiseAnd(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x29616B0 Offset: 0x29600B0 VA: 0x1829616B0
	public static int3x3 op_BitwiseAnd(int3x3 lhs, int rhs) { }

	// RVA: 0x29615E0 Offset: 0x295FFE0 VA: 0x1829615E0
	public static int3x3 op_BitwiseAnd(int lhs, int3x3 rhs) { }

	// RVA: 0x2961850 Offset: 0x2960250 VA: 0x182961850
	public static int3x3 op_BitwiseOr(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x2961780 Offset: 0x2960180 VA: 0x182961780
	public static int3x3 op_BitwiseOr(int3x3 lhs, int rhs) { }

	// RVA: 0x29619C0 Offset: 0x29603C0 VA: 0x1829619C0
	public static int3x3 op_BitwiseOr(int lhs, int3x3 rhs) { }

	// RVA: 0x2962230 Offset: 0x2960C30 VA: 0x182962230
	public static int3x3 op_ExclusiveOr(int3x3 lhs, int3x3 rhs) { }

	// RVA: 0x29623A0 Offset: 0x2960DA0 VA: 0x1829623A0
	public static int3x3 op_ExclusiveOr(int3x3 lhs, int rhs) { }

	// RVA: 0x2962470 Offset: 0x2960E70 VA: 0x182962470
	public static int3x3 op_ExclusiveOr(int lhs, int3x3 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref int3 get_Item(int index) { }

	// RVA: 0x2960340 Offset: 0x295ED40 VA: 0x182960340 Slot: 4
	public bool Equals(int3x3 rhs) { }

	// RVA: 0x2960220 Offset: 0x295EC20 VA: 0x182960220 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29603F0 Offset: 0x295EDF0 VA: 0x1829603F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2960890 Offset: 0x295F290 VA: 0x182960890 Slot: 3
	public override string ToString() { }

	// RVA: 0x29604B0 Offset: 0x295EEB0 VA: 0x1829604B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2960C90 Offset: 0x295F690 VA: 0x182960C90
	private static void .cctor() { }
}
