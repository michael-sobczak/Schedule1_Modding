public struct float4x4 : IEquatable<float4x4>, IFormattable // TypeDefIndex: 10913
{
	// Fields
	public float4 c0; // 0x0
	public float4 c1; // 0x10
	public float4 c2; // 0x20
	public float4 c3; // 0x30
	public static readonly float4x4 identity; // 0x0
	public static readonly float4x4 zero; // 0x40

	// Properties
	public float4 Item { get; }

	// Methods

	// RVA: 0x28F5170 Offset: 0x28F3B70 VA: 0x1828F5170
	public void .ctor(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0x2948270 Offset: 0x2946C70 VA: 0x182948270
	public void .ctor(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	// RVA: 0x29483F0 Offset: 0x2946DF0 VA: 0x1829483F0
	public void .ctor(float v) { }

	// RVA: 0x29483B0 Offset: 0x2946DB0 VA: 0x1829483B0
	public void .ctor(bool v) { }

	// RVA: 0x28839F0 Offset: 0x28823F0 VA: 0x1828839F0
	public void .ctor(bool4x4 v) { }

	// RVA: 0x2948370 Offset: 0x2946D70 VA: 0x182948370
	public void .ctor(int v) { }

	// RVA: 0x28840F0 Offset: 0x2882AF0 VA: 0x1828840F0
	public void .ctor(int4x4 v) { }

	// RVA: 0x2883DD0 Offset: 0x28827D0 VA: 0x182883DD0
	public void .ctor(uint v) { }

	// RVA: 0x2883F40 Offset: 0x2882940 VA: 0x182883F40
	public void .ctor(uint4x4 v) { }

	// RVA: 0x2883B90 Offset: 0x2882590 VA: 0x182883B90
	public void .ctor(double v) { }

	// RVA: 0x2883C90 Offset: 0x2882690 VA: 0x182883C90
	public void .ctor(double4x4 v) { }

	// RVA: 0x289CF30 Offset: 0x289B930 VA: 0x18289CF30
	public static float4x4 op_Implicit(float v) { }

	// RVA: 0x289D210 Offset: 0x289BC10 VA: 0x18289D210
	public static float4x4 op_Explicit(bool v) { }

	// RVA: 0x289D310 Offset: 0x289BD10 VA: 0x18289D310
	public static float4x4 op_Explicit(bool4x4 v) { }

	// RVA: 0x289D260 Offset: 0x289BC60 VA: 0x18289D260
	public static float4x4 op_Implicit(int v) { }

	// RVA: 0x294A040 Offset: 0x2948A40 VA: 0x18294A040
	public static float4x4 op_Implicit(int4x4 v) { }

	// RVA: 0x294A010 Offset: 0x2948A10 VA: 0x18294A010
	public static float4x4 op_Implicit(uint v) { }

	// RVA: 0x289D140 Offset: 0x289BB40 VA: 0x18289D140
	public static float4x4 op_Implicit(uint4x4 v) { }

	// RVA: 0x2949900 Offset: 0x2948300 VA: 0x182949900
	public static float4x4 op_Explicit(double v) { }

	// RVA: 0x2949880 Offset: 0x2948280 VA: 0x182949880
	public static float4x4 op_Explicit(double4x4 v) { }

	// RVA: 0x294BFB0 Offset: 0x294A9B0 VA: 0x18294BFB0
	public static float4x4 op_Multiply(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294BDC0 Offset: 0x294A7C0 VA: 0x18294BDC0
	public static float4x4 op_Multiply(float4x4 lhs, float rhs) { }

	// RVA: 0x294BBD0 Offset: 0x294A5D0 VA: 0x18294BBD0
	public static float4x4 op_Multiply(float lhs, float4x4 rhs) { }

	// RVA: 0x2948800 Offset: 0x2947200 VA: 0x182948800
	public static float4x4 op_Addition(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x2948610 Offset: 0x2947010 VA: 0x182948610
	public static float4x4 op_Addition(float4x4 lhs, float rhs) { }

	// RVA: 0x2948420 Offset: 0x2946E20 VA: 0x182948420
	public static float4x4 op_Addition(float lhs, float4x4 rhs) { }

	// RVA: 0x294C600 Offset: 0x294B000 VA: 0x18294C600
	public static float4x4 op_Subtraction(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294C410 Offset: 0x294AE10 VA: 0x18294C410
	public static float4x4 op_Subtraction(float4x4 lhs, float rhs) { }

	// RVA: 0x294C1F0 Offset: 0x294ABF0 VA: 0x18294C1F0
	public static float4x4 op_Subtraction(float lhs, float4x4 rhs) { }

	// RVA: 0x29490A0 Offset: 0x2947AA0 VA: 0x1829490A0
	public static float4x4 op_Division(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x2948EB0 Offset: 0x29478B0 VA: 0x182948EB0
	public static float4x4 op_Division(float4x4 lhs, float rhs) { }

	// RVA: 0x2948C90 Offset: 0x2947690 VA: 0x182948C90
	public static float4x4 op_Division(float lhs, float4x4 rhs) { }

	// RVA: 0x294B620 Offset: 0x294A020 VA: 0x18294B620
	public static float4x4 op_Modulus(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294B920 Offset: 0x294A320 VA: 0x18294B920
	public static float4x4 op_Modulus(float4x4 lhs, float rhs) { }

	// RVA: 0x294B360 Offset: 0x2949D60 VA: 0x18294B360
	public static float4x4 op_Modulus(float lhs, float4x4 rhs) { }

	// RVA: 0x294A490 Offset: 0x2948E90 VA: 0x18294A490
	public static float4x4 op_Increment(float4x4 val) { }

	// RVA: 0x2948A40 Offset: 0x2947440 VA: 0x182948A40
	public static float4x4 op_Decrement(float4x4 val) { }

	// RVA: 0x294B200 Offset: 0x2949C00 VA: 0x18294B200
	public static bool4x4 op_LessThan(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294B100 Offset: 0x2949B00 VA: 0x18294B100
	public static bool4x4 op_LessThan(float4x4 lhs, float rhs) { }

	// RVA: 0x294AFF0 Offset: 0x29499F0 VA: 0x18294AFF0
	public static bool4x4 op_LessThan(float lhs, float4x4 rhs) { }

	// RVA: 0x294AE90 Offset: 0x2949890 VA: 0x18294AE90
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294AD90 Offset: 0x2949790 VA: 0x18294AD90
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float rhs) { }

	// RVA: 0x294AC80 Offset: 0x2949680 VA: 0x18294AC80
	public static bool4x4 op_LessThanOrEqual(float lhs, float4x4 rhs) { }

	// RVA: 0x2949CA0 Offset: 0x29486A0 VA: 0x182949CA0
	public static bool4x4 op_GreaterThan(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x2949F10 Offset: 0x2948910 VA: 0x182949F10
	public static bool4x4 op_GreaterThan(float4x4 lhs, float rhs) { }

	// RVA: 0x2949E00 Offset: 0x2948800 VA: 0x182949E00
	public static bool4x4 op_GreaterThan(float lhs, float4x4 rhs) { }

	// RVA: 0x2949A30 Offset: 0x2948430 VA: 0x182949A30
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x2949930 Offset: 0x2948330 VA: 0x182949930
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float rhs) { }

	// RVA: 0x2949B90 Offset: 0x2948590 VA: 0x182949B90
	public static bool4x4 op_GreaterThanOrEqual(float lhs, float4x4 rhs) { }

	// RVA: 0x294C840 Offset: 0x294B240 VA: 0x18294C840
	public static float4x4 op_UnaryNegation(float4x4 val) { }

	// RVA: 0x294CA20 Offset: 0x294B420 VA: 0x18294CA20
	public static float4x4 op_UnaryPlus(float4x4 val) { }

	// RVA: 0x29494A0 Offset: 0x2947EA0 VA: 0x1829494A0
	public static bool4x4 op_Equality(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x29492E0 Offset: 0x2947CE0 VA: 0x1829492E0
	public static bool4x4 op_Equality(float4x4 lhs, float rhs) { }

	// RVA: 0x29496C0 Offset: 0x29480C0 VA: 0x1829496C0
	public static bool4x4 op_Equality(float lhs, float4x4 rhs) { }

	// RVA: 0x294A8A0 Offset: 0x29492A0 VA: 0x18294A8A0
	public static bool4x4 op_Inequality(float4x4 lhs, float4x4 rhs) { }

	// RVA: 0x294AAC0 Offset: 0x29494C0 VA: 0x18294AAC0
	public static bool4x4 op_Inequality(float4x4 lhs, float rhs) { }

	// RVA: 0x294A6E0 Offset: 0x29490E0 VA: 0x18294A6E0
	public static bool4x4 op_Inequality(float lhs, float4x4 rhs) { }

	// RVA: 0xF6D000 Offset: 0xF6BA00 VA: 0x180F6D000
	public ref float4 get_Item(int index) { }

	// RVA: 0x293BBF0 Offset: 0x293A5F0 VA: 0x18293BBF0 Slot: 4
	public bool Equals(float4x4 rhs) { }

	// RVA: 0x2945B00 Offset: 0x2944500 VA: 0x182945B00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x29461A0 Offset: 0x2944BA0 VA: 0x1829461A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2947080 Offset: 0x2945A80 VA: 0x182947080 Slot: 3
	public override string ToString() { }

	// RVA: 0x2947770 Offset: 0x2946170 VA: 0x182947770 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x294A290 Offset: 0x2948C90 VA: 0x18294A290
	public static float4x4 op_Implicit(Matrix4x4 m) { }

	// RVA: 0x294A0A0 Offset: 0x2948AA0 VA: 0x18294A0A0
	public static Matrix4x4 op_Implicit(float4x4 m) { }

	// RVA: 0x2947ED0 Offset: 0x29468D0 VA: 0x182947ED0
	public void .ctor(float3x3 rotation, float3 translation) { }

	// RVA: 0x2947FE0 Offset: 0x29469E0 VA: 0x182947FE0
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x2948120 Offset: 0x2946B20 VA: 0x182948120
	public void .ctor(RigidTransform transform) { }

	// RVA: 0x29457D0 Offset: 0x29441D0 VA: 0x1829457D0
	public static float4x4 AxisAngle(float3 axis, float angle) { }

	// RVA: 0x293BD60 Offset: 0x293A760 VA: 0x18293BD60
	public static float4x4 EulerXYZ(float3 xyz) { }

	// RVA: 0x293BF70 Offset: 0x293A970 VA: 0x18293BF70
	public static float4x4 EulerXZY(float3 xyz) { }

	// RVA: 0x293C170 Offset: 0x293AB70 VA: 0x18293C170
	public static float4x4 EulerYXZ(float3 xyz) { }

	// RVA: 0x293C370 Offset: 0x293AD70 VA: 0x18293C370
	public static float4x4 EulerYZX(float3 xyz) { }

	// RVA: 0x293C570 Offset: 0x293AF70 VA: 0x18293C570
	public static float4x4 EulerZXY(float3 xyz) { }

	// RVA: 0x293C750 Offset: 0x293B150 VA: 0x18293C750
	public static float4x4 EulerZYX(float3 xyz) { }

	// RVA: 0x2945BB0 Offset: 0x29445B0 VA: 0x182945BB0
	public static float4x4 EulerXYZ(float x, float y, float z) { }

	// RVA: 0x2945C10 Offset: 0x2944610 VA: 0x182945C10
	public static float4x4 EulerXZY(float x, float y, float z) { }

	// RVA: 0x2945C70 Offset: 0x2944670 VA: 0x182945C70
	public static float4x4 EulerYXZ(float x, float y, float z) { }

	// RVA: 0x2945CD0 Offset: 0x29446D0 VA: 0x182945CD0
	public static float4x4 EulerYZX(float x, float y, float z) { }

	// RVA: 0x2945D30 Offset: 0x2944730 VA: 0x182945D30
	public static float4x4 EulerZXY(float x, float y, float z) { }

	// RVA: 0x2945D90 Offset: 0x2944790 VA: 0x182945D90
	public static float4x4 EulerZYX(float x, float y, float z) { }

	// RVA: 0x2946000 Offset: 0x2944A00 VA: 0x182946000
	public static float4x4 Euler(float3 xyz, math.RotationOrder order = 4) { }

	// RVA: 0x2945DF0 Offset: 0x29447F0 VA: 0x182945DF0
	public static float4x4 Euler(float x, float y, float z, math.RotationOrder order = 4) { }

	// RVA: 0x2946980 Offset: 0x2945380 VA: 0x182946980
	public static float4x4 RotateX(float angle) { }

	// RVA: 0x2946AB0 Offset: 0x29454B0 VA: 0x182946AB0
	public static float4x4 RotateY(float angle) { }

	// RVA: 0x2946BF0 Offset: 0x29455F0 VA: 0x182946BF0
	public static float4x4 RotateZ(float angle) { }

	// RVA: 0x2946DA0 Offset: 0x29457A0 VA: 0x182946DA0
	public static float4x4 Scale(float s) { }

	// RVA: 0x2946D30 Offset: 0x2945730 VA: 0x182946D30
	public static float4x4 Scale(float x, float y, float z) { }

	// RVA: 0x2946E10 Offset: 0x2945810 VA: 0x182946E10
	public static float4x4 Scale(float3 scales) { }

	// RVA: 0x2947DF0 Offset: 0x29467F0 VA: 0x182947DF0
	public static float4x4 Translate(float3 vector) { }

	// RVA: 0x29461E0 Offset: 0x2944BE0 VA: 0x1829461E0
	public static float4x4 LookAt(float3 eye, float3 target, float3 up) { }

	// RVA: 0x29465D0 Offset: 0x2944FD0 VA: 0x1829465D0
	public static float4x4 Ortho(float width, float height, float near, float far) { }

	// RVA: 0x2946450 Offset: 0x2944E50 VA: 0x182946450
	public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	// RVA: 0x29466C0 Offset: 0x29450C0 VA: 0x1829466C0
	public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far) { }

	// RVA: 0x2946810 Offset: 0x2945210 VA: 0x182946810
	public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	// RVA: 0x2946E90 Offset: 0x2945890 VA: 0x182946E90
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

	// RVA: 0x2947E60 Offset: 0x2946860 VA: 0x182947E60
	private static void .cctor() { }
}
