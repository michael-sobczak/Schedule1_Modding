public struct CGSpot : IEquatable<CGSpot> // TypeDefIndex: 10656
{
	// Fields
	[SerializeField]
	[Label("Index", "")]
	private int m_Index; // 0x0
	[SerializeField]
	[VectorEx("Position", "", Options = 1, Precision = 4)]
	private Vector3 m_Position; // 0x4
	[SerializeField]
	[VectorEx("Rotation", "", Options = 1, Precision = 4)]
	private Quaternion m_Rotation; // 0x10
	[VectorEx("Scale", "", Options = 1, Precision = 4)]
	[SerializeField]
	private Vector3 m_Scale; // 0x20

	// Properties
	public int Index { get; }
	public Vector3 Position { get; set; }
	public Quaternion Rotation { get; set; }
	public Vector3 Scale { get; set; }
	public Matrix4x4 Matrix { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Index() { }

	// RVA: 0x4FB270 Offset: 0x4F9C70 VA: 0x1804FB270
	public Vector3 get_Position() { }

	// RVA: 0x4FB310 Offset: 0x4F9D10 VA: 0x1804FB310
	public void set_Position(Vector3 value) { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Quaternion get_Rotation() { }

	// RVA: 0x49CD50 Offset: 0x49B750 VA: 0x18049CD50
	public void set_Rotation(Quaternion value) { }

	// RVA: 0x4DA100 Offset: 0x4D8B00 VA: 0x1804DA100
	public Vector3 get_Scale() { }

	// RVA: 0x4DA200 Offset: 0x4D8C00 VA: 0x1804DA200
	public void set_Scale(Vector3 value) { }

	// RVA: 0x4FB1E0 Offset: 0x4F9BE0 VA: 0x1804FB1E0
	public Matrix4x4 get_Matrix() { }

	// RVA: 0x4FB0C0 Offset: 0x4F9AC0 VA: 0x1804FB0C0
	public void .ctor(int index) { }

	// RVA: 0x4FB1B0 Offset: 0x4F9BB0 VA: 0x1804FB1B0
	public void .ctor(int index, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x4FB030 Offset: 0x4F9A30 VA: 0x1804FB030
	public void ToTransform(Transform transform) { }

	// RVA: 0x4FADE0 Offset: 0x4F97E0 VA: 0x1804FADE0 Slot: 4
	public bool Equals(CGSpot other) { }

	// RVA: 0x4FAD30 Offset: 0x4F9730 VA: 0x1804FAD30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4FAF20 Offset: 0x4F9920 VA: 0x1804FAF20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4FB290 Offset: 0x4F9C90 VA: 0x1804FB290
	public static bool op_Equality(CGSpot left, CGSpot right) { }

	// RVA: 0x4FB2D0 Offset: 0x4F9CD0 VA: 0x1804FB2D0
	public static bool op_Inequality(CGSpot left, CGSpot right) { }
}
