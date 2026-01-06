public class Constraints // TypeDefIndex: 14055
{
	// Fields
	public Transform transform; // 0x10
	public Transform target; // 0x18
	public Vector3 positionOffset; // 0x20
	public Vector3 position; // 0x2C
	[Range(0, 1)]
	public float positionWeight; // 0x38
	public Vector3 rotationOffset; // 0x3C
	public Vector3 rotation; // 0x48
	[Range(0, 1)]
	public float rotationWeight; // 0x54
	private Vector3 defaultLocalPosition; // 0x58
	private Quaternion defaultLocalRotation; // 0x64

	// Methods

	// RVA: 0x1EA4120 Offset: 0x1EA2B20 VA: 0x181EA4120
	public bool IsValid() { }

	// RVA: 0x1EA4070 Offset: 0x1EA2A70 VA: 0x181EA4070
	public void Initiate(Transform transform) { }

	// RVA: 0x1EA4010 Offset: 0x1EA2A10 VA: 0x181EA4010
	public void FixTransforms() { }

	// RVA: 0x1EA4170 Offset: 0x1EA2B70 VA: 0x181EA4170
	public void Update() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
