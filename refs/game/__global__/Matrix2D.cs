public struct Matrix2D // TypeDefIndex: 10279
{
	// Fields
	public float m00; // 0x0
	public float m10; // 0x4
	public float m01; // 0x8
	public float m11; // 0xC
	public float m02; // 0x10
	public float m12; // 0x14
	private static readonly Matrix2D zeroMatrix; // 0x0
	private static readonly Matrix2D identityMatrix; // 0x18

	// Properties
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix2D zero { get; }
	public static Matrix2D identity { get; }

	// Methods

	// RVA: 0x456250 Offset: 0x454C50 VA: 0x180456250
	public void .ctor(Vector2 column0, Vector2 column1, Vector2 column2) { }

	// RVA: 0x4562B0 Offset: 0x454CB0 VA: 0x1804562B0
	public float get_Item(int row, int column) { }

	// RVA: 0x4568F0 Offset: 0x4552F0 VA: 0x1804568F0
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x456320 Offset: 0x454D20 VA: 0x180456320
	public float get_Item(int index) { }

	// RVA: 0x456970 Offset: 0x455370 VA: 0x180456970
	public void set_Item(int index, float value) { }

	// RVA: 0x454F20 Offset: 0x453920 VA: 0x180454F20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x454D20 Offset: 0x453720 VA: 0x180454D20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x456800 Offset: 0x455200 VA: 0x180456800
	public static Matrix2D op_Multiply(Matrix2D lhs, Matrix2D rhs) { }

	// RVA: 0x456770 Offset: 0x455170 VA: 0x180456770
	public static Vector2 op_Multiply(Matrix2D lhs, Vector2 vector) { }

	// RVA: 0x4564D0 Offset: 0x454ED0 VA: 0x1804564D0
	public static bool op_Equality(Matrix2D lhs, Matrix2D rhs) { }

	// RVA: 0x4565E0 Offset: 0x454FE0 VA: 0x1804565E0
	public static bool op_Inequality(Matrix2D lhs, Matrix2D rhs) { }

	// RVA: 0x454E70 Offset: 0x453870 VA: 0x180454E70
	public Vector2 GetColumn(int index) { }

	// RVA: 0x455020 Offset: 0x453A20 VA: 0x180455020
	public Vector3 GetRow(int index) { }

	// RVA: 0x455930 Offset: 0x454330 VA: 0x180455930
	public void SetColumn(int index, Vector2 column) { }

	// RVA: 0x455A10 Offset: 0x454410 VA: 0x180455A10
	public void SetRow(int index, Vector3 row) { }

	// RVA: 0x455750 Offset: 0x454150 VA: 0x180455750
	public Vector2 MultiplyPoint(Vector2 point) { }

	// RVA: 0x4557A0 Offset: 0x4541A0 VA: 0x1804557A0
	public Vector2 MultiplyVector(Vector2 vector) { }

	// RVA: 0x4550C0 Offset: 0x453AC0 VA: 0x1804550C0
	public Matrix2D Inverse() { }

	// RVA: 0x455900 Offset: 0x454300 VA: 0x180455900
	public static Matrix2D Scale(Vector2 vector) { }

	// RVA: 0x456170 Offset: 0x454B70 VA: 0x180456170
	public static Matrix2D Translate(Vector2 vector) { }

	// RVA: 0x455840 Offset: 0x454240 VA: 0x180455840
	public static Matrix2D RotateRH(float angleRadians) { }

	// RVA: 0x4557E0 Offset: 0x4541E0 VA: 0x1804557E0
	public static Matrix2D RotateLH(float angleRadians) { }

	// RVA: 0x455B40 Offset: 0x454540 VA: 0x180455B40
	public static Matrix2D SkewX(float angleRadians) { }

	// RVA: 0x455B80 Offset: 0x454580 VA: 0x180455B80
	public static Matrix2D SkewY(float angleRadians) { }

	// RVA: 0x456460 Offset: 0x454E60 VA: 0x180456460
	public static Matrix2D get_zero() { }

	// RVA: 0x4563F0 Offset: 0x454DF0 VA: 0x1804563F0
	public static Matrix2D get_identity() { }

	// RVA: 0x455E80 Offset: 0x454880 VA: 0x180455E80 Slot: 3
	public override string ToString() { }

	// RVA: 0x455BD0 Offset: 0x4545D0 VA: 0x180455BD0
	public string ToString(string format) { }

	// RVA: 0x4561B0 Offset: 0x454BB0 VA: 0x1804561B0
	private static void .cctor() { }
}
