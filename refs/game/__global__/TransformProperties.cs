public struct TransformProperties // TypeDefIndex: 12592
{
	// Fields
	public Vector3 Position; // 0x0
	public Quaternion Rotation; // 0xC
	public Vector3 LocalScale; // 0x1C

	// Methods

	// RVA: 0xAAE1F0 Offset: 0xAACBF0 VA: 0x180AAE1F0
	public void .ctor(Vector3 position, Quaternion rotation, Vector3 localScale) { }

	// RVA: 0xD3EB70 Offset: 0xD3D570 VA: 0x180D3EB70
	public void Reset() { }

	// RVA: 0xD3ECA0 Offset: 0xD3D6A0 VA: 0x180D3ECA0
	public void Update(Transform t) { }

	// RVA: 0xD3EC50 Offset: 0xD3D650 VA: 0x180D3EC50
	public void Update(TransformProperties tp) { }

	// RVA: 0xD3EC80 Offset: 0xD3D680 VA: 0x180D3EC80
	public void Update(Vector3 position, Quaternion rotation) { }

	// RVA: 0xAAE1F0 Offset: 0xAACBF0 VA: 0x180AAE1F0
	public void Update(Vector3 position, Quaternion rotation, Vector3 localScale) { }
}
