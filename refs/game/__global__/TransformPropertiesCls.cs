public class TransformPropertiesCls : IResettable // TypeDefIndex: 12591
{
	// Fields
	public Vector3 Position; // 0x10
	public Quaternion Rotation; // 0x1C
	public Vector3 LocalScale; // 0x2C

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xD3EB00 Offset: 0xD3D500 VA: 0x180D3EB00
	public void .ctor(Vector3 position, Quaternion rotation, Vector3 localScale) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void InitializeState() { }

	// RVA: 0xD3E890 Offset: 0xD3D290 VA: 0x180D3E890 Slot: 4
	public void ResetState() { }

	// RVA: 0xD3EA40 Offset: 0xD3D440 VA: 0x180D3EA40
	public void Update(Transform t) { }

	// RVA: 0xD3EA00 Offset: 0xD3D400 VA: 0x180D3EA00
	public void Update(TransformPropertiesCls tp) { }

	// RVA: 0xD3E9A0 Offset: 0xD3D3A0 VA: 0x180D3E9A0
	public void Update(TransformProperties tp) { }

	// RVA: 0xD3EAE0 Offset: 0xD3D4E0 VA: 0x180D3EAE0
	public void Update(Vector3 position, Quaternion rotation) { }

	// RVA: 0xD3E9D0 Offset: 0xD3D3D0 VA: 0x180D3E9D0
	public void Update(Vector3 position, Quaternion rotation, Vector3 localScale) { }

	// RVA: 0xD3E970 Offset: 0xD3D370 VA: 0x180D3E970
	public TransformProperties ToStruct() { }
}
