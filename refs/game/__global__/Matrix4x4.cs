public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 11753
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Vector3 lossyScale { get; }
	public bool isIdentity { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public Matrix4x4 transpose { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 zero { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafe]
	// RVA: 0x2CA8A80 Offset: 0x2CA7480 VA: 0x182CA8A80
	private Vector3 GetLossyScale() { }

	[ThreadSafe]
	// RVA: 0x2CA8D10 Offset: 0x2CA7710 VA: 0x182CA8D10
	private bool IsIdentity() { }

	[ThreadSafe]
	// RVA: 0x2CA8330 Offset: 0x2CA6D30 VA: 0x182CA8330
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x2CAA3B0 Offset: 0x2CA8DB0 VA: 0x182CAA3B0
	public Vector3 get_lossyScale() { }

	// RVA: 0x2CA8D10 Offset: 0x2CA7710 VA: 0x182CA8D10
	public bool get_isIdentity() { }

	// RVA: 0x2CAA230 Offset: 0x2CA8C30 VA: 0x182CAA230
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x2CA9660 Offset: 0x2CA8060 VA: 0x182CA9660
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	// RVA: 0x2CA8C10 Offset: 0x2CA7610 VA: 0x182CA8C10
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	// RVA: 0x2CA8CB0 Offset: 0x2CA76B0 VA: 0x182CA8CB0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x2CAA300 Offset: 0x2CA8D00 VA: 0x182CAA300
	public Matrix4x4 get_inverse() { }

	[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = True)]
	// RVA: 0x2CA9ED0 Offset: 0x2CA88D0 VA: 0x182CA9ED0
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x2CAA420 Offset: 0x2CA8E20 VA: 0x182CAA420
	public Matrix4x4 get_transpose() { }

	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	// RVA: 0x2CA90F0 Offset: 0x2CA7AF0 VA: 0x182CA90F0
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = True)]
	// RVA: 0x2CA9220 Offset: 0x2CA7C20 VA: 0x182CA9220
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = True)]
	// RVA: 0x2CA8DC0 Offset: 0x2CA77C0 VA: 0x182CA8DC0
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	// RVA: 0x2CA8700 Offset: 0x2CA7100 VA: 0x182CA8700
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x2CA85D0 Offset: 0x2CA6FD0 VA: 0x182CA85D0
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x2CAA050 Offset: 0x2CA8A50 VA: 0x182CAA050
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x2CAA220 Offset: 0x2CA8C20 VA: 0x182CAA220
	public float get_Item(int row, int column) { }

	// RVA: 0x2CAAEA0 Offset: 0x2CA98A0 VA: 0x182CAAEA0
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x2CAA0C0 Offset: 0x2CA8AC0 VA: 0x182CAA0C0
	public float get_Item(int index) { }

	// RVA: 0x2CAAD40 Offset: 0x2CA9740 VA: 0x182CAAD40
	public void set_Item(int index, float value) { }

	// RVA: 0x2CA8880 Offset: 0x2CA7280 VA: 0x182CA8880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CA8390 Offset: 0x2CA6D90 VA: 0x182CA8390 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CA8440 Offset: 0x2CA6E40 VA: 0x182CA8440 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x2CAA800 Offset: 0x2CA9200 VA: 0x182CAA800
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x2CAA6E0 Offset: 0x2CA90E0 VA: 0x182CAA6E0
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x2CAA530 Offset: 0x2CA8F30 VA: 0x182CAA530
	public static bool op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x2CAA670 Offset: 0x2CA9070 VA: 0x182CAA670
	public static bool op_Inequality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x2CA87B0 Offset: 0x2CA71B0 VA: 0x182CA87B0
	public Vector4 GetColumn(int index) { }

	// RVA: 0x2CA8AD0 Offset: 0x2CA74D0 VA: 0x182CA8AD0
	public Vector4 GetRow(int index) { }

	// RVA: 0x2CA9500 Offset: 0x2CA7F00 VA: 0x182CA9500
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x2CA9580 Offset: 0x2CA7F80 VA: 0x182CA9580
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x2CA8EE0 Offset: 0x2CA78E0 VA: 0x182CA8EE0
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x2CA8E40 Offset: 0x2CA7840 VA: 0x182CA8E40
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x2CA8FE0 Offset: 0x2CA79E0 VA: 0x182CA8FE0
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x2CA9460 Offset: 0x2CA7E60 VA: 0x182CA9460
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x2CA9DE0 Offset: 0x2CA87E0 VA: 0x182CA9DE0
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x2CA92B0 Offset: 0x2CA7CB0 VA: 0x182CA92B0
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x2CAA4D0 Offset: 0x2CA8ED0 VA: 0x182CAA4D0
	public static Matrix4x4 get_zero() { }

	// RVA: 0x2CAA2A0 Offset: 0x2CA8CA0 VA: 0x182CAA2A0
	public static Matrix4x4 get_identity() { }

	// RVA: 0x2CA96E0 Offset: 0x2CA80E0 VA: 0x182CA96E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CA96F0 Offset: 0x2CA80F0 VA: 0x182CA96F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2CA9F30 Offset: 0x2CA8930 VA: 0x182CA9F30
	private static void .cctor() { }

	// RVA: 0x2CA8A30 Offset: 0x2CA7430 VA: 0x182CA8A30
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x2CA8D10 Offset: 0x2CA7710 VA: 0x182CA8D10
	private static bool IsIdentity_Injected(ref Matrix4x4 _unity_self) { }

	// RVA: 0x2CA82E0 Offset: 0x2CA6CE0 VA: 0x182CA82E0
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x2CA95F0 Offset: 0x2CA7FF0 VA: 0x182CA95F0
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x2CA8BC0 Offset: 0x2CA75C0 VA: 0x182CA8BC0
	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x2CA8C60 Offset: 0x2CA7660 VA: 0x182CA8C60
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x2CA9E80 Offset: 0x2CA8880 VA: 0x182CA9E80
	private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x2CA9070 Offset: 0x2CA7A70 VA: 0x182CA9070
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x2CA91A0 Offset: 0x2CA7BA0 VA: 0x182CA91A0
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x2CA8D50 Offset: 0x2CA7750 VA: 0x182CA8D50
	private static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret) { }

	// RVA: 0x2CA8550 Offset: 0x2CA6F50 VA: 0x182CA8550
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }
}
