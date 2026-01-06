public class LabOvenWireTray : MonoBehaviour // TypeDefIndex: 3260
{
	// Fields
	public const float HIT_OFFSET_MAX = 0.24;
	public const float HIT_OFFSET_MIN = -0.25;
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <TargetPosition>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <ActualPosition>k__BackingField; // 0x28
	[Header("References")]
	public Transform Tray; // 0x30
	public Transform PlaneNormal; // 0x38
	public Transform ClosedPosition; // 0x40
	public Transform OpenPosition; // 0x48
	public LabOvenDoor OvenDoor; // 0x50
	[Header("Settings")]
	public float MoveSpeed; // 0x58
	public AnimationCurve DoorClampCurve; // 0x60
	private Vector3 clickOffset; // 0x68
	private bool isMoving; // 0x74

	// Properties
	public bool Interactable { get; set; }
	public float TargetPosition { get; set; }
	public float ActualPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_Interactable() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_Interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_TargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	private void set_TargetPosition(float value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_ActualPosition() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	private void set_ActualPosition(float value) { }

	// RVA: 0xA17CE0 Offset: 0xA166E0 VA: 0x180A17CE0
	private void Start() { }

	// RVA: 0xA17950 Offset: 0xA16350 VA: 0x180A17950
	private void LateUpdate() { }

	// RVA: 0xA17AE0 Offset: 0xA164E0 VA: 0x180A17AE0
	private void Move() { }

	// RVA: 0xA17540 Offset: 0xA15F40 VA: 0x180A17540
	private void ClampAngle() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void SetInteractable(bool interactable) { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void SetPosition(float position) { }

	// RVA: 0xA17690 Offset: 0xA16090 VA: 0x180A17690
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0xA176A0 Offset: 0xA160A0 VA: 0x180A176A0
	private Vector3 GetPlaneHit() { }

	// RVA: 0xA17680 Offset: 0xA16080 VA: 0x180A17680
	public void ClickEnd() { }

	// RVA: 0xA17CF0 Offset: 0xA166F0 VA: 0x180A17CF0
	public void .ctor() { }
}
