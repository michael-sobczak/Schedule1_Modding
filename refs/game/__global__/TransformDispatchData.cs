internal struct TransformDispatchData : IDisposable // TypeDefIndex: 11762
{
	// Fields
	public NativeArray<int> transformedID; // 0x0
	public NativeArray<int> parentID; // 0x10
	public NativeArray<Matrix4x4> localToWorldMatrices; // 0x20
	public NativeArray<Vector3> positions; // 0x30
	public NativeArray<Quaternion> rotations; // 0x40
	public NativeArray<Vector3> scales; // 0x50

	// Methods

	// RVA: 0x2CCC4F0 Offset: 0x2CCAEF0 VA: 0x182CCC4F0 Slot: 4
	public void Dispose() { }
}
