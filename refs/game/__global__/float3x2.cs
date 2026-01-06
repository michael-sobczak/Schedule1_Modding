public struct float3x2 : IEquatable<float3x2>, IFormattable // TypeDefIndex: 10906
{
	// Fields
	public float3 c0; // 0x0
	public float3 c1; // 0xC
	public static readonly float3x2 zero; // 0x0

	// Properties
	public float3 Item { get; }

	// Methods

	// RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	public void .ctor(float3 c0, float3 c1) { }

	// RVA: 0x29306F0 Offset: 0x292F0F0 VA: 0x1829306F0
	public void .ctor(float m00, float m01, float m10, float m11, float m20, float m21) { }

	// RVA: 0x2930670 Offset: 0x292F070 VA: 0x182930670
	public void .ctor(float v) { }

	// RVA: 0x2930790 Offset: 0x292F190 VA: 0x182930790
	public void .ctor(bool v) { }

	// RVA: 0x2930840 Offset: 0x292F240 VA: 0x182930840
	public void .ctor(bool3x2 v) { }

	// RVA: 0x2930620 Offset: 0x292F020 VA: 0x182930620
	public void .ctor(int v) { }

	// RVA: 0x2930990 Offset: 0x292F390 VA: 0x182930990
	public void .ctor(int3x2 v) { }

	// RVA: 0x2930720 Offset: 0x292F120 VA: 0x182930720
	public void .ctor(uint v) { }

	// RVA: 0x29308D0 Offset: 0x292F2D0 VA: 0x1829308D0
	public void .ctor(uint3x2 v) { }

	// RVA: 0x29307F0 Offset: 0x292F1F0 VA: 0x1829307F0
	public void .ctor(double v) { }

	// RVA: 0x2930690 Offset: 0x292F090 VA: 0x182930690
	public void .ctor(double3x2 v) { }

	// RVA: 0x289A960 Offset: 0x2899360 VA: 0x18289A960
	public static float3x2 op_Implicit(float v) { }

	// RVA: 0x289A640 Offset: 0x2899040 VA: 0x18289A640
	public static float3x2 op_Explicit(bool v) { }

	// RVA: 0x289A8D0 Offset: 0x28992D0 VA: 0x18289A8D0
	public static float3x2 op_Explicit(bool3x2 v) { }

	// RVA: 0x289A6A0 Offset: 0x28990A0 VA: 0x18289A6A0
	public static float3x2 op_Implicit(int v) { }

	// RVA: 0x289A740 Offset: 0x2899140 VA: 0x18289A740
	public static float3x2 op_Implicit(int3x2 v) { }

	// RVA: 0x289A850 Offset: 0x2899250 VA: 0x18289A850
	public static float3x2 op_Implicit(uint v) { }

	// RVA: 0x289A580 Offset: 0x2898F80 VA: 0x18289A580
	public static float3x2 op_Implicit(uint3x2 v) { }

	// RVA: 0x289A6F0 Offset: 0x28990F0 VA: 0x18289A6F0
	public static float3x2 op_Explicit(double v) { }

	// RVA: 0x289A520 Offset: 0x2898F20 VA: 0x18289A520
	public static float3x2 op_Explicit(double3x2 v) { }

	// RVA: 0x2931C30 Offset: 0x2930630 VA: 0x182931C30
	public static float3x2 op_Multiply(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2931D40 Offset: 0x2930740 VA: 0x182931D40
	public static float3x2 op_Multiply(float3x2 lhs, float rhs) { }

	// RVA: 0x2931CC0 Offset: 0x29306C0 VA: 0x182931CC0
	public static float3x2 op_Multiply(float lhs, float3x2 rhs) { }

	// RVA: 0x2930AA0 Offset: 0x292F4A0 VA: 0x182930AA0
	public static float3x2 op_Addition(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2930B30 Offset: 0x292F530 VA: 0x182930B30
	public static float3x2 op_Addition(float3x2 lhs, float rhs) { }

	// RVA: 0x2930A20 Offset: 0x292F420 VA: 0x182930A20
	public static float3x2 op_Addition(float lhs, float3x2 rhs) { }

	// RVA: 0x2931DC0 Offset: 0x29307C0 VA: 0x182931DC0
	public static float3x2 op_Subtraction(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2931E50 Offset: 0x2930850 VA: 0x182931E50
	public static float3x2 op_Subtraction(float3x2 lhs, float rhs) { }

	// RVA: 0x2931ED0 Offset: 0x29308D0 VA: 0x182931ED0
	public static float3x2 op_Subtraction(float lhs, float3x2 rhs) { }

	// RVA: 0x2930CA0 Offset: 0x292F6A0 VA: 0x182930CA0
	public static float3x2 op_Division(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2930C20 Offset: 0x292F620 VA: 0x182930C20
	public static float3x2 op_Division(float3x2 lhs, float rhs) { }

	// RVA: 0x2930D30 Offset: 0x292F730 VA: 0x182930D30
	public static float3x2 op_Division(float lhs, float3x2 rhs) { }

	// RVA: 0x2931940 Offset: 0x2930340 VA: 0x182931940
	public static float3x2 op_Modulus(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2931B40 Offset: 0x2930540 VA: 0x182931B40
	public static float3x2 op_Modulus(float3x2 lhs, float rhs) { }

	// RVA: 0x2931A50 Offset: 0x2930450 VA: 0x182931A50
	public static float3x2 op_Modulus(float lhs, float3x2 rhs) { }

	// RVA: 0x2931350 Offset: 0x292FD50 VA: 0x182931350
	public static float3x2 op_Increment(float3x2 val) { }

	// RVA: 0x2930BB0 Offset: 0x292F5B0 VA: 0x182930BB0
	public static float3x2 op_Decrement(float3x2 val) { }

	// RVA: 0x2931830 Offset: 0x2930230 VA: 0x182931830
	public static bool3x2 op_LessThan(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x29318D0 Offset: 0x29302D0 VA: 0x1829318D0
	public static bool3x2 op_LessThan(float3x2 lhs, float rhs) { }

	// RVA: 0x29317B0 Offset: 0x29301B0 VA: 0x1829317B0
	public static bool3x2 op_LessThan(float lhs, float3x2 rhs) { }

	// RVA: 0x2931710 Offset: 0x2930110 VA: 0x182931710
	public static bool3x2 op_LessThanOrEqual(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x29316A0 Offset: 0x29300A0 VA: 0x1829316A0
	public static bool3x2 op_LessThanOrEqual(float3x2 lhs, float rhs) { }

	// RVA: 0x2931620 Offset: 0x2930020 VA: 0x182931620
	public static bool3x2 op_LessThanOrEqual(float lhs, float3x2 rhs) { }

	// RVA: 0x2931230 Offset: 0x292FC30 VA: 0x182931230
	public static bool3x2 op_GreaterThan(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x29311B0 Offset: 0x292FBB0 VA: 0x1829311B0
	public static bool3x2 op_GreaterThan(float3x2 lhs, float rhs) { }

	// RVA: 0x29312D0 Offset: 0x292FCD0 VA: 0x1829312D0
	public static bool3x2 op_GreaterThan(float lhs, float3x2 rhs) { }

	// RVA: 0x2931110 Offset: 0x292FB10 VA: 0x182931110
	public static bool3x2 op_GreaterThanOrEqual(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2931010 Offset: 0x292FA10 VA: 0x182931010
	public static bool3x2 op_GreaterThanOrEqual(float3x2 lhs, float rhs) { }

	// RVA: 0x2931090 Offset: 0x292FA90 VA: 0x182931090
	public static bool3x2 op_GreaterThanOrEqual(float lhs, float3x2 rhs) { }

	// RVA: 0x2931F50 Offset: 0x2930950 VA: 0x182931F50
	public static float3x2 op_UnaryNegation(float3x2 val) { }

	// RVA: 0x2931FC0 Offset: 0x29309C0 VA: 0x182931FC0
	public static float3x2 op_UnaryPlus(float3x2 val) { }

	// RVA: 0x2930F20 Offset: 0x292F920 VA: 0x182930F20
	public static bool3x2 op_Equality(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x2930DB0 Offset: 0x292F7B0 VA: 0x182930DB0
	public static bool3x2 op_Equality(float3x2 lhs, float rhs) { }

	// RVA: 0x2930E70 Offset: 0x292F870 VA: 0x182930E70
	public static bool3x2 op_Equality(float lhs, float3x2 rhs) { }

	// RVA: 0x2931530 Offset: 0x292FF30 VA: 0x182931530
	public static bool3x2 op_Inequality(float3x2 lhs, float3x2 rhs) { }

	// RVA: 0x29313C0 Offset: 0x292FDC0 VA: 0x1829313C0
	public static bool3x2 op_Inequality(float3x2 lhs, float rhs) { }

	// RVA: 0x2931480 Offset: 0x292FE80 VA: 0x182931480
	public static bool3x2 op_Inequality(float lhs, float3x2 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref float3 get_Item(int index) { }

	// RVA: 0x28FA170 Offset: 0x28F8B70 VA: 0x1828FA170 Slot: 4
	public bool Equals(float3x2 rhs) { }

	// RVA: 0x292FEE0 Offset: 0x292E8E0 VA: 0x18292FEE0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x292FFE0 Offset: 0x292E9E0 VA: 0x18292FFE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2930330 Offset: 0x292ED30 VA: 0x182930330 Slot: 3
	public override string ToString() { }

	// RVA: 0x2930060 Offset: 0x292EA60 VA: 0x182930060 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
