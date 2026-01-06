public struct RigidbodyState // TypeDefIndex: 12692
{
	// Fields
	public uint LocalTick; // 0x0
	public Vector3 Position; // 0x4
	public Quaternion Rotation; // 0x10
	public bool IsKinematic; // 0x20
	public Vector3 Velocity; // 0x24
	public Vector3 AngularVelocity; // 0x30

	// Methods

	// RVA: 0xD56FE0 Offset: 0xD559E0 VA: 0x180D56FE0
	public void .ctor(Rigidbody rb, bool isKinematic, uint tick) { }

	// RVA: 0xD570D0 Offset: 0xD55AD0 VA: 0x180D570D0
	public void .ctor(Rigidbody rb, uint tick) { }
}
