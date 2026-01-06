public struct float3x3 : IEquatable<float3x3>, IFormattable // TypeDefIndex: 10907
{
	// Fields
	public float3 c0; // 0x0
	public float3 c1; // 0xC
	public float3 c2; // 0x18
	public static readonly float3x3 identity; // 0x0
	public static readonly float3x3 zero; // 0x24

	// Properties
	public float3 Item { get; }

	// Methods

	// RVA: 0x2933DF0 Offset: 0x29327F0 VA: 0x182933DF0
	public void .ctor(float3 c0, float3 c1, float3 c2) { }

	// RVA: 0x2933C80 Offset: 0x2932680 VA: 0x182933C80
	public void .ctor(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	// RVA: 0x2933E30 Offset: 0x2932830 VA: 0x182933E30
	public void .ctor(float v) { }

	// RVA: 0x2882750 Offset: 0x2881150 VA: 0x182882750
	public void .ctor(bool v) { }

	// RVA: 0x28828E0 Offset: 0x28812E0 VA: 0x1828828E0
	public void .ctor(bool3x3 v) { }

	// RVA: 0x2933B80 Offset: 0x2932580 VA: 0x182933B80
	public void .ctor(int v) { }

	// RVA: 0x2933AB0 Offset: 0x29324B0 VA: 0x182933AB0
	public void .ctor(int3x3 v) { }

	// RVA: 0x2933D40 Offset: 0x2932740 VA: 0x182933D40
	public void .ctor(uint v) { }

	// RVA: 0x28827D0 Offset: 0x28811D0 VA: 0x1828827D0
	public void .ctor(uint3x3 v) { }

	// RVA: 0x2933E60 Offset: 0x2932860 VA: 0x182933E60
	public void .ctor(double v) { }

	// RVA: 0x2933BF0 Offset: 0x29325F0 VA: 0x182933BF0
	public void .ctor(double3x3 v) { }

	// RVA: 0x289AA10 Offset: 0x2899410 VA: 0x18289AA10
	public static float3x3 op_Implicit(float v) { }

	// RVA: 0x2934C10 Offset: 0x2933610 VA: 0x182934C10
	public static float3x3 op_Explicit(bool v) { }

	// RVA: 0x2934BD0 Offset: 0x29335D0 VA: 0x182934BD0
	public static float3x3 op_Explicit(bool3x3 v) { }

	// RVA: 0x289AC70 Offset: 0x2899670 VA: 0x18289AC70
	public static float3x3 op_Implicit(int v) { }

	// RVA: 0x289AAE0 Offset: 0x28994E0 VA: 0x18289AAE0
	public static float3x3 op_Implicit(int3x3 v) { }

	// RVA: 0x289AE20 Offset: 0x2899820 VA: 0x18289AE20
	public static float3x3 op_Implicit(uint v) { }

	// RVA: 0x29350C0 Offset: 0x2933AC0 VA: 0x1829350C0
	public static float3x3 op_Implicit(uint3x3 v) { }

	// RVA: 0x289AF10 Offset: 0x2899910 VA: 0x18289AF10
	public static float3x3 op_Explicit(double v) { }

	// RVA: 0x289AA50 Offset: 0x2899450 VA: 0x18289AA50
	public static float3x3 op_Explicit(double3x3 v) { }

	// RVA: 0x2935E60 Offset: 0x2934860 VA: 0x182935E60
	public static float3x3 op_Multiply(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2936040 Offset: 0x2934A40 VA: 0x182936040
	public static float3x3 op_Multiply(float3x3 lhs, float rhs) { }

	// RVA: 0x2935F60 Offset: 0x2934960 VA: 0x182935F60
	public static float3x3 op_Multiply(float lhs, float3x3 rhs) { }

	// RVA: 0x2934250 Offset: 0x2932C50 VA: 0x182934250
	public static float3x3 op_Addition(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2934170 Offset: 0x2932B70 VA: 0x182934170
	public static float3x3 op_Addition(float3x3 lhs, float rhs) { }

	// RVA: 0x2934350 Offset: 0x2932D50 VA: 0x182934350
	public static float3x3 op_Addition(float lhs, float3x3 rhs) { }

	// RVA: 0x2936120 Offset: 0x2934B20 VA: 0x182936120
	public static float3x3 op_Subtraction(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2936220 Offset: 0x2934C20 VA: 0x182936220
	public static float3x3 op_Subtraction(float3x3 lhs, float rhs) { }

	// RVA: 0x2936300 Offset: 0x2934D00 VA: 0x182936300
	public static float3x3 op_Subtraction(float lhs, float3x3 rhs) { }

	// RVA: 0x2934510 Offset: 0x2932F10 VA: 0x182934510
	public static float3x3 op_Division(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2934700 Offset: 0x2933100 VA: 0x182934700
	public static float3x3 op_Division(float3x3 lhs, float rhs) { }

	// RVA: 0x2934610 Offset: 0x2933010 VA: 0x182934610
	public static float3x3 op_Division(float lhs, float3x3 rhs) { }

	// RVA: 0x2935B80 Offset: 0x2934580 VA: 0x182935B80
	public static float3x3 op_Modulus(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2935D00 Offset: 0x2934700 VA: 0x182935D00
	public static float3x3 op_Modulus(float3x3 lhs, float rhs) { }

	// RVA: 0x2935A10 Offset: 0x2934410 VA: 0x182935A10
	public static float3x3 op_Modulus(float lhs, float3x3 rhs) { }

	// RVA: 0x2935110 Offset: 0x2933B10 VA: 0x182935110
	public static float3x3 op_Increment(float3x3 val) { }

	// RVA: 0x2934430 Offset: 0x2932E30 VA: 0x182934430
	public static float3x3 op_Decrement(float3x3 val) { }

	// RVA: 0x2935930 Offset: 0x2934330 VA: 0x182935930
	public static bool3x3 op_LessThan(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x29357C0 Offset: 0x29341C0 VA: 0x1829357C0
	public static bool3x3 op_LessThan(float3x3 lhs, float rhs) { }

	// RVA: 0x2935870 Offset: 0x2934270 VA: 0x182935870
	public static bool3x3 op_LessThan(float lhs, float3x3 rhs) { }

	// RVA: 0x2935630 Offset: 0x2934030 VA: 0x182935630
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2935710 Offset: 0x2934110 VA: 0x182935710
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float rhs) { }

	// RVA: 0x2935570 Offset: 0x2933F70 VA: 0x182935570
	public static bool3x3 op_LessThanOrEqual(float lhs, float3x3 rhs) { }

	// RVA: 0x2934F30 Offset: 0x2933930 VA: 0x182934F30
	public static bool3x3 op_GreaterThan(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2934E80 Offset: 0x2933880 VA: 0x182934E80
	public static bool3x3 op_GreaterThan(float3x3 lhs, float rhs) { }

	// RVA: 0x2935010 Offset: 0x2933A10 VA: 0x182935010
	public static bool3x3 op_GreaterThan(float lhs, float3x3 rhs) { }

	// RVA: 0x2934CF0 Offset: 0x29336F0 VA: 0x182934CF0
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2934C40 Offset: 0x2933640 VA: 0x182934C40
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float rhs) { }

	// RVA: 0x2934DD0 Offset: 0x29337D0 VA: 0x182934DD0
	public static bool3x3 op_GreaterThanOrEqual(float lhs, float3x3 rhs) { }

	// RVA: 0x29363F0 Offset: 0x2934DF0 VA: 0x1829363F0
	public static float3x3 op_UnaryNegation(float3x3 val) { }

	// RVA: 0x29364D0 Offset: 0x2934ED0 VA: 0x1829364D0
	public static float3x3 op_UnaryPlus(float3x3 val) { }

	// RVA: 0x2934A10 Offset: 0x2933410 VA: 0x182934A10
	public static bool3x3 op_Equality(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x29348F0 Offset: 0x29332F0 VA: 0x1829348F0
	public static bool3x3 op_Equality(float3x3 lhs, float rhs) { }

	// RVA: 0x29347E0 Offset: 0x29331E0 VA: 0x1829347E0
	public static bool3x3 op_Equality(float lhs, float3x3 rhs) { }

	// RVA: 0x2935420 Offset: 0x2933E20 VA: 0x182935420
	public static bool3x3 op_Inequality(float3x3 lhs, float3x3 rhs) { }

	// RVA: 0x2935300 Offset: 0x2933D00 VA: 0x182935300
	public static bool3x3 op_Inequality(float3x3 lhs, float rhs) { }

	// RVA: 0x29351F0 Offset: 0x2933BF0 VA: 0x1829351F0
	public static bool3x3 op_Inequality(float lhs, float3x3 rhs) { }

	// RVA: 0xF6D040 Offset: 0xF6BA40 VA: 0x180F6D040
	public ref float3 get_Item(int index) { }

	// RVA: 0x29268D0 Offset: 0x29252D0 VA: 0x1829268D0 Slot: 4
	public bool Equals(float3x3 rhs) { }

	// RVA: 0x29322B0 Offset: 0x2930CB0 VA: 0x1829322B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29328A0 Offset: 0x29312A0 VA: 0x1829328A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2933260 Offset: 0x2931C60 VA: 0x182933260 Slot: 3
	public override string ToString() { }

	// RVA: 0x2933680 Offset: 0x2932080 VA: 0x182933680 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2933CE0 Offset: 0x29326E0 VA: 0x182933CE0
	public void .ctor(float4x4 f4x4) { }

	// RVA: 0x2933ED0 Offset: 0x29328D0 VA: 0x182933ED0
	public void .ctor(quaternion q) { }

	// RVA: 0x2932010 Offset: 0x2930A10 VA: 0x182932010
	public static float3x3 AxisAngle(float3 axis, float angle) { }

	// RVA: 0x2926980 Offset: 0x2925380 VA: 0x182926980
	public static float3x3 EulerXYZ(float3 xyz) { }

	// RVA: 0x2926B30 Offset: 0x2925530 VA: 0x182926B30
	public static float3x3 EulerXZY(float3 xyz) { }

	// RVA: 0x2926CE0 Offset: 0x29256E0 VA: 0x182926CE0
	public static float3x3 EulerYXZ(float3 xyz) { }

	// RVA: 0x2926E90 Offset: 0x2925890 VA: 0x182926E90
	public static float3x3 EulerYZX(float3 xyz) { }

	// RVA: 0x2927040 Offset: 0x2925A40 VA: 0x182927040
	public static float3x3 EulerZXY(float3 xyz) { }

	// RVA: 0x29271D0 Offset: 0x2925BD0 VA: 0x1829271D0
	public static float3x3 EulerZYX(float3 xyz) { }

	// RVA: 0x2932360 Offset: 0x2930D60 VA: 0x182932360
	public static float3x3 EulerXYZ(float x, float y, float z) { }

	// RVA: 0x29323B0 Offset: 0x2930DB0 VA: 0x1829323B0
	public static float3x3 EulerXZY(float x, float y, float z) { }

	// RVA: 0x2932400 Offset: 0x2930E00 VA: 0x182932400
	public static float3x3 EulerYXZ(float x, float y, float z) { }

	// RVA: 0x2932450 Offset: 0x2930E50 VA: 0x182932450
	public static float3x3 EulerYZX(float x, float y, float z) { }

	// RVA: 0x29324A0 Offset: 0x2930EA0 VA: 0x1829324A0
	public static float3x3 EulerZXY(float x, float y, float z) { }

	// RVA: 0x29324F0 Offset: 0x2930EF0 VA: 0x1829324F0
	public static float3x3 EulerZYX(float x, float y, float z) { }

	// RVA: 0x2932720 Offset: 0x2931120 VA: 0x182932720
	public static float3x3 Euler(float3 xyz, math.RotationOrder order = 4) { }

	// RVA: 0x2932540 Offset: 0x2930F40 VA: 0x182932540
	public static float3x3 Euler(float x, float y, float z, math.RotationOrder order = 4) { }

	// RVA: 0x2932E40 Offset: 0x2931840 VA: 0x182932E40
	public static float3x3 RotateX(float angle) { }

	// RVA: 0x2932F40 Offset: 0x2931940 VA: 0x182932F40
	public static float3x3 RotateY(float angle) { }

	// RVA: 0x2933050 Offset: 0x2931A50 VA: 0x182933050
	public static float3x3 RotateZ(float angle) { }

	// RVA: 0x2933210 Offset: 0x2931C10 VA: 0x182933210
	public static float3x3 Scale(float s) { }

	// RVA: 0x2933160 Offset: 0x2931B60 VA: 0x182933160
	public static float3x3 Scale(float x, float y, float z) { }

	// RVA: 0x29331B0 Offset: 0x2931BB0 VA: 0x1829331B0
	public static float3x3 Scale(float3 v) { }

	// RVA: 0x2932CC0 Offset: 0x29316C0 VA: 0x182932CC0
	public static float3x3 LookRotation(float3 forward, float3 up) { }

	// RVA: 0x2932980 Offset: 0x2931380 VA: 0x182932980
	public static float3x3 LookRotationSafe(float3 forward, float3 up) { }

	// RVA: 0x2934B60 Offset: 0x2933560 VA: 0x182934B60
	public static float3x3 op_Explicit(float4x4 f4x4) { }

	// RVA: 0x2933A60 Offset: 0x2932460 VA: 0x182933A60
	private static void .cctor() { }
}
