public class GraphTransform : IMovementPlane, ITransform // TypeDefIndex: 13394
{
	// Fields
	public readonly bool identity; // 0x10
	public readonly bool onlyTranslational; // 0x11
	private readonly bool isXY; // 0x12
	private readonly bool isXZ; // 0x13
	private readonly Matrix4x4 matrix; // 0x14
	private readonly Matrix4x4 inverseMatrix; // 0x54
	private readonly Vector3 up; // 0x94
	private readonly Vector3 translation; // 0xA0
	private readonly Int3 i3translation; // 0xAC
	private readonly Quaternion rotation; // 0xB8
	private readonly Quaternion inverseRotation; // 0xC8
	public static readonly GraphTransform identityTransform; // 0x0

	// Methods

	// RVA: 0xBA5480 Offset: 0xBA3E80 VA: 0x180BA5480
	public void .ctor(Matrix4x4 matrix) { }

	// RVA: 0xBA5370 Offset: 0xBA3D70 VA: 0x180BA5370
	public Vector3 WorldUpAtGraphPosition(Vector3 point) { }

	// RVA: 0xBA41B0 Offset: 0xBA2BB0 VA: 0x180BA41B0
	private static bool MatrixIsTranslational(Matrix4x4 matrix) { }

	// RVA: 0xBA4F40 Offset: 0xBA3940 VA: 0x180BA4F40 Slot: 7
	public Vector3 Transform(Vector3 point) { }

	// RVA: 0xBA44C0 Offset: 0xBA2EC0 VA: 0x180BA44C0
	public Vector3 TransformVector(Vector3 point) { }

	// RVA: 0xBA5010 Offset: 0xBA3A10 VA: 0x180BA5010
	public void Transform(Int3[] arr) { }

	// RVA: 0xBA51E0 Offset: 0xBA3BE0 VA: 0x180BA51E0
	public void Transform(Vector3[] arr) { }

	// RVA: 0xBA3580 Offset: 0xBA1F80 VA: 0x180BA3580 Slot: 8
	public Vector3 InverseTransform(Vector3 point) { }

	// RVA: 0xBA3460 Offset: 0xBA1E60 VA: 0x180BA3460
	public Int3 InverseTransform(Int3 point) { }

	// RVA: 0xBA4040 Offset: 0xBA2A40 VA: 0x180BA4040
	public void InverseTransform(Int3[] arr) { }

	// RVA: 0xBA5910 Offset: 0xBA4310 VA: 0x180BA5910
	public static GraphTransform op_Multiply(GraphTransform lhs, Matrix4x4 rhs) { }

	// RVA: 0xBA5A50 Offset: 0xBA4450 VA: 0x180BA5A50
	public static GraphTransform op_Multiply(Matrix4x4 lhs, GraphTransform rhs) { }

	// RVA: 0xBA4560 Offset: 0xBA2F60 VA: 0x180BA4560
	public Bounds Transform(Bounds bounds) { }

	// RVA: 0xBA3650 Offset: 0xBA2050 VA: 0x180BA3650
	public Bounds InverseTransform(Bounds bounds) { }

	// RVA: 0xBA4340 Offset: 0xBA2D40 VA: 0x180BA4340 Slot: 4
	private Vector2 Pathfinding.Util.IMovementPlane.ToPlane(Vector3 point) { }

	// RVA: 0xBA43D0 Offset: 0xBA2DD0 VA: 0x180BA43D0 Slot: 5
	private Vector2 Pathfinding.Util.IMovementPlane.ToPlane(Vector3 point, out float elevation) { }

	// RVA: 0xBA4450 Offset: 0xBA2E50 VA: 0x180BA4450 Slot: 6
	private Vector3 Pathfinding.Util.IMovementPlane.ToWorld(Vector2 point, float elevation) { }

	// RVA: 0xBA5390 Offset: 0xBA3D90 VA: 0x180BA5390
	private static void .cctor() { }
}
