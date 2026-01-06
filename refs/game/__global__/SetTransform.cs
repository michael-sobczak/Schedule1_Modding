public class SetTransform : MonoBehaviour // TypeDefIndex: 1935
{
	// Fields
	[Header("Frequency Settings")]
	public bool SetOnAwake; // 0x20
	public bool SetOnUpdate; // 0x21
	public bool SetOnLateUpdate; // 0x22
	[Header("Transform Settings")]
	public bool SetPosition; // 0x23
	public Vector3 LocalPosition; // 0x24
	public bool SetRotation; // 0x30
	public Vector3 LocalRotation; // 0x34
	public bool SetScale; // 0x40
	public Vector3 LocalScale; // 0x44

	// Methods

	// RVA: 0x7A4840 Offset: 0x7A3240 VA: 0x1807A4840
	private void Awake() { }

	// RVA: 0x7A49E0 Offset: 0x7A33E0 VA: 0x1807A49E0
	private void Update() { }

	// RVA: 0x7A4850 Offset: 0x7A3250 VA: 0x1807A4850
	private void LateUpdate() { }

	// RVA: 0x7A4860 Offset: 0x7A3260 VA: 0x1807A4860
	private void Set() { }

	// RVA: 0x7A49F0 Offset: 0x7A33F0 VA: 0x1807A49F0
	public void .ctor() { }
}
