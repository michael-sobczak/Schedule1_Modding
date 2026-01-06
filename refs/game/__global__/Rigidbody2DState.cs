public struct Rigidbody2DState // TypeDefIndex: 12693
{
	// Fields
	public uint LocalTick; // 0x0
	public Vector3 Position; // 0x4
	public Quaternion Rotation; // 0x10
	public Vector2 Velocity; // 0x20
	public float AngularVelocity; // 0x28
	public bool Simulated; // 0x2C
	public bool IsKinematic; // 0x2D

	// Methods

	// RVA: 0xD54AD0 Offset: 0xD534D0 VA: 0x180D54AD0
	public void .ctor(Rigidbody2D rb, bool simulated, uint tick) { }

	// RVA: 0xD54BC0 Offset: 0xD535C0 VA: 0x180D54BC0
	public void .ctor(Rigidbody2D rb, uint tick) { }
}
