public struct uint3x3 : IEquatable<uint3x3>, IFormattable // TypeDefIndex: 10950
{
	// Fields
	public uint3 c0; // 0x0
	public uint3 c1; // 0xC
	public uint3 c2; // 0x18
	public static readonly uint3x3 identity; // 0x0
	public static readonly uint3x3 zero; // 0x24

	// Properties
	public uint3 Item { get; }

	// Methods

	// RVA: 0x2933DF0 Offset: 0x29327F0 VA: 0x182933DF0
	public void .ctor(uint3 c0, uint3 c1, uint3 c2) { }

	// RVA: 0x2960F10 Offset: 0x295F910 VA: 0x182960F10
	public void .ctor(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) { }

	// RVA: 0x2960E50 Offset: 0x295F850 VA: 0x182960E50
	public void .ctor(uint v) { }

	// RVA: 0x2884690 Offset: 0x2883090 VA: 0x182884690
	public void .ctor(bool v) { }

	// RVA: 0x2960CE0 Offset: 0x295F6E0 VA: 0x182960CE0
	public void .ctor(bool3x3 v) { }

	// RVA: 0x2960E50 Offset: 0x295F850 VA: 0x182960E50
	public void .ctor(int v) { }

	// RVA: 0x2960F70 Offset: 0x295F970 VA: 0x182960F70
	public void .ctor(int3x3 v) { }

	// RVA: 0x2888150 Offset: 0x2886B50 VA: 0x182888150
	public void .ctor(float v) { }

	// RVA: 0x2888360 Offset: 0x2886D60 VA: 0x182888360
	public void .ctor(float3x3 v) { }

	// RVA: 0x2888080 Offset: 0x2886A80 VA: 0x182888080
	public void .ctor(double v) { }

	// RVA: 0x2888220 Offset: 0x2886C20 VA: 0x182888220
	public void .ctor(double3x3 v) { }

	// RVA: 0x28A8560 Offset: 0x28A6F60 VA: 0x1828A8560
	public static uint3x3 op_Implicit(uint v) { }

	// RVA: 0x2962540 Offset: 0x2960F40 VA: 0x182962540
	public static uint3x3 op_Explicit(bool v) { }

	// RVA: 0x28A8900 Offset: 0x28A7300 VA: 0x1828A8900
	public static uint3x3 op_Explicit(bool3x3 v) { }

	// RVA: 0x28A8560 Offset: 0x28A6F60 VA: 0x1828A8560
	public static uint3x3 op_Explicit(int v) { }

	// RVA: 0x28A8620 Offset: 0x28A7020 VA: 0x1828A8620
	public static uint3x3 op_Explicit(int3x3 v) { }

	// RVA: 0x29929C0 Offset: 0x29913C0 VA: 0x1829929C0
	public static uint3x3 op_Explicit(float v) { }

	// RVA: 0x2992970 Offset: 0x2991370 VA: 0x182992970
	public static uint3x3 op_Explicit(float3x3 v) { }

	// RVA: 0x29929F0 Offset: 0x29913F0 VA: 0x1829929F0
	public static uint3x3 op_Explicit(double v) { }

	// RVA: 0x2992910 Offset: 0x2991310 VA: 0x182992910
	public static uint3x3 op_Explicit(double3x3 v) { }

	// RVA: 0x2963AF0 Offset: 0x29624F0 VA: 0x182963AF0
	public static uint3x3 op_Multiply(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2963D50 Offset: 0x2962750 VA: 0x182963D50
	public static uint3x3 op_Multiply(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2963C70 Offset: 0x2962670 VA: 0x182963C70
	public static uint3x3 op_Multiply(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2961140 Offset: 0x295FB40 VA: 0x182961140
	public static uint3x3 op_Addition(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x29612C0 Offset: 0x295FCC0 VA: 0x1829612C0
	public static uint3x3 op_Addition(uint3x3 lhs, uint rhs) { }

	// RVA: 0x29613A0 Offset: 0x295FDA0 VA: 0x1829613A0
	public static uint3x3 op_Addition(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2964190 Offset: 0x2962B90 VA: 0x182964190
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2963FE0 Offset: 0x29629E0 VA: 0x182963FE0
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint rhs) { }

	// RVA: 0x29640B0 Offset: 0x2962AB0 VA: 0x1829640B0
	public static uint3x3 op_Subtraction(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2992680 Offset: 0x2991080 VA: 0x182992680
	public static uint3x3 op_Division(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2992590 Offset: 0x2990F90 VA: 0x182992590
	public static uint3x3 op_Division(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2992810 Offset: 0x2991210 VA: 0x182992810
	public static uint3x3 op_Division(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2993820 Offset: 0x2992220 VA: 0x182993820
	public static uint3x3 op_Modulus(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x29939B0 Offset: 0x29923B0 VA: 0x1829939B0
	public static uint3x3 op_Modulus(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2993720 Offset: 0x2992120 VA: 0x182993720
	public static uint3x3 op_Modulus(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2962BF0 Offset: 0x29615F0 VA: 0x182962BF0
	public static uint3x3 op_Increment(uint3x3 val) { }

	// RVA: 0x2961A90 Offset: 0x2960490 VA: 0x182961A90
	public static uint3x3 op_Decrement(uint3x3 val) { }

	// RVA: 0x29933E0 Offset: 0x2991DE0 VA: 0x1829933E0
	public static bool3x3 op_LessThan(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2993640 Offset: 0x2992040 VA: 0x182993640
	public static bool3x3 op_LessThan(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2993560 Offset: 0x2991F60 VA: 0x182993560
	public static bool3x3 op_LessThan(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2993260 Offset: 0x2991C60 VA: 0x182993260
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x29930A0 Offset: 0x2991AA0 VA: 0x1829930A0
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2993180 Offset: 0x2991B80 VA: 0x182993180
	public static bool3x3 op_LessThanOrEqual(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2992E40 Offset: 0x2991840 VA: 0x182992E40
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2992D60 Offset: 0x2991760 VA: 0x182992D60
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2992FC0 Offset: 0x29919C0 VA: 0x182992FC0
	public static bool3x3 op_GreaterThan(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2992A20 Offset: 0x2991420 VA: 0x182992A20
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2992BA0 Offset: 0x29915A0 VA: 0x182992BA0
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2992C80 Offset: 0x2991680 VA: 0x182992C80
	public static bool3x3 op_GreaterThanOrEqual(uint lhs, uint3x3 rhs) { }

	// RVA: 0x29642F0 Offset: 0x2962CF0 VA: 0x1829642F0
	public static uint3x3 op_UnaryNegation(uint3x3 val) { }

	// RVA: 0x29643C0 Offset: 0x2962DC0 VA: 0x1829643C0
	public static uint3x3 op_UnaryPlus(uint3x3 val) { }

	// RVA: 0x2963020 Offset: 0x2961A20 VA: 0x182963020
	public static uint3x3 op_LeftShift(uint3x3 x, int n) { }

	// RVA: 0x2993AA0 Offset: 0x29924A0 VA: 0x182993AA0
	public static uint3x3 op_RightShift(uint3x3 x, int n) { }

	// RVA: 0x29620B0 Offset: 0x2960AB0 VA: 0x1829620B0
	public static bool3x3 op_Equality(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2961FD0 Offset: 0x29609D0 VA: 0x182961FD0
	public static bool3x3 op_Equality(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2961EF0 Offset: 0x29608F0 VA: 0x182961EF0
	public static bool3x3 op_Equality(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2962EA0 Offset: 0x29618A0 VA: 0x182962EA0
	public static bool3x3 op_Inequality(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2962CE0 Offset: 0x29616E0 VA: 0x182962CE0
	public static bool3x3 op_Inequality(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2962DC0 Offset: 0x29617C0 VA: 0x182962DC0
	public static bool3x3 op_Inequality(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2963E30 Offset: 0x2962830 VA: 0x182963E30
	public static uint3x3 op_OnesComplement(uint3x3 val) { }

	// RVA: 0x2961470 Offset: 0x295FE70 VA: 0x182961470
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x29616B0 Offset: 0x29600B0 VA: 0x1829616B0
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint rhs) { }

	// RVA: 0x29615E0 Offset: 0x295FFE0 VA: 0x1829615E0
	public static uint3x3 op_BitwiseAnd(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2961850 Offset: 0x2960250 VA: 0x182961850
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x2961780 Offset: 0x2960180 VA: 0x182961780
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint rhs) { }

	// RVA: 0x29619C0 Offset: 0x29603C0 VA: 0x1829619C0
	public static uint3x3 op_BitwiseOr(uint lhs, uint3x3 rhs) { }

	// RVA: 0x2962230 Offset: 0x2960C30 VA: 0x182962230
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint3x3 rhs) { }

	// RVA: 0x29623A0 Offset: 0x2960DA0 VA: 0x1829623A0
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint rhs) { }

	// RVA: 0x2962470 Offset: 0x2960E70 VA: 0x182962470
	public static uint3x3 op_ExclusiveOr(uint lhs, uint3x3 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref uint3 get_Item(int index) { }

	// RVA: 0x2960340 Offset: 0x295ED40 VA: 0x182960340 Slot: 4
	public bool Equals(uint3x3 rhs) { }

	// RVA: 0x2991B60 Offset: 0x2990560 VA: 0x182991B60 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2991C80 Offset: 0x2990680 VA: 0x182991C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2991D40 Offset: 0x2990740 VA: 0x182991D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2992140 Offset: 0x2990B40 VA: 0x182992140 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2992520 Offset: 0x2990F20 VA: 0x182992520
	private static void .cctor() { }
}
