public class BrickPressHandle : MonoBehaviour // TypeDefIndex: 3228
{
	// Fields
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <CurrentPosition>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <TargetPosition>k__BackingField; // 0x28
	private float lastClickPosition; // 0x2C
	[Header("Settings")]
	public float MoveSpeed; // 0x30
	public bool Locked; // 0x34
	[Header("References")]
	public Transform PlaneNormal; // 0x38
	public Transform RaisedTransform; // 0x40
	public Transform LoweredTransform; // 0x48
	public Clickable HandleClickable; // 0x50
	public AudioSourceController ClickSound; // 0x58
	private Vector3 clickOffset; // 0x60
	private bool isMoving; // 0x6C

	// Properties
	public bool Interactable { get; set; }
	public float CurrentPosition { get; set; }
	public float TargetPosition { get; set; }

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

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_TargetPosition(float value) { }

	// RVA: 0x9F92C0 Offset: 0x9F7CC0 VA: 0x1809F92C0
	private void Start() { }

	// RVA: 0x9F8F40 Offset: 0x9F7940 VA: 0x1809F8F40
	private void LateUpdate() { }

	// RVA: 0x9F90E0 Offset: 0x9F7AE0 VA: 0x1809F90E0
	private void Move() { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	private void UpdateSound(float difference) { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void SetPosition(float position) { }

	// RVA: 0x9F92A0 Offset: 0x9F7CA0 VA: 0x1809F92A0
	public void SetInteractable(bool e) { }

	// RVA: 0x9F8BF0 Offset: 0x9F75F0 VA: 0x1809F8BF0
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0x9F8BE0 Offset: 0x9F75E0 VA: 0x1809F8BE0
	public void ClickEnd() { }

	// RVA: 0x9F8C90 Offset: 0x9F7690 VA: 0x1809F8C90
	private Vector3 GetPlaneHit() { }

	// RVA: 0x9F93F0 Offset: 0x9F7DF0 VA: 0x1809F93F0
	public void .ctor() { }
}
