public class LabStand : MonoBehaviour // TypeDefIndex: 3244
{
	// Fields
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <CurrentPosition>k__BackingField; // 0x24
	[Header("Settings")]
	public float MoveSpeed; // 0x28
	public bool FunnelEnabled; // 0x2C
	public float FunnelThreshold; // 0x30
	[Header("References")]
	public Animation Anim; // 0x38
	public Transform GripTransform; // 0x40
	public Transform SpinnyThingy; // 0x48
	public Transform RaisedTransform; // 0x50
	public Transform LoweredTransform; // 0x58
	public Transform PlaneNormal; // 0x60
	public Clickable HandleClickable; // 0x68
	public Transform Funnel; // 0x70
	public GameObject Highlight; // 0x78
	public AudioSourceController LowerSound; // 0x80
	public AudioSourceController RaiseSound; // 0x88
	private Vector3 clickOffset; // 0x90
	private bool isMoving; // 0x9C

	// Properties
	public bool Interactable { get; set; }
	public float CurrentPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Interactable() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_CurrentPosition() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	private void set_CurrentPosition(float value) { }

	// RVA: 0xA14D30 Offset: 0xA13730 VA: 0x180A14D30
	private void Start() { }

	// RVA: 0xA147F0 Offset: 0xA131F0 VA: 0x180A147F0
	private void LateUpdate() { }

	// RVA: 0xA149A0 Offset: 0xA133A0 VA: 0x180A149A0
	private void Move() { }

	// RVA: 0xA14E70 Offset: 0xA13870 VA: 0x180A14E70
	private void UpdateSound(float difference) { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void SetPosition(float position) { }

	// RVA: 0xA14CF0 Offset: 0xA136F0 VA: 0x180A14CF0
	public void SetInteractable(bool e) { }

	// RVA: 0xA14490 Offset: 0xA12E90 VA: 0x180A14490
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0xA14540 Offset: 0xA12F40 VA: 0x180A14540
	private Vector3 GetPlaneHit() { }

	// RVA: 0xA14480 Offset: 0xA12E80 VA: 0x180A14480
	public void ClickEnd() { }

	// RVA: 0xA14FE0 Offset: 0xA139E0 VA: 0x180A14FE0
	public void .ctor() { }
}
