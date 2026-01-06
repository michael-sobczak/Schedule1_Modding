public class LabOvenDoor : MonoBehaviour // TypeDefIndex: 3258
{
	// Fields
	public const float HIT_OFFSET_MAX = 0.24;
	public const float HIT_OFFSET_MIN = -0.25;
	public const float DOOR_ANGLE_CLOSED = 90;
	public const float DOOR_ANGLE_OPEN = 10;
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <TargetPosition>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <ActualPosition>k__BackingField; // 0x28
	[Header("References")]
	public Clickable HandleClickable; // 0x30
	public Transform Door; // 0x38
	public Transform PlaneNormal; // 0x40
	public AnimationCurve HitMapCurve; // 0x48
	[Header("Sounds")]
	public AudioSourceController OpenSound; // 0x50
	public AudioSourceController CloseSound; // 0x58
	public AudioSourceController ShutSound; // 0x60
	[Header("Settings")]
	public float DoorMoveSpeed; // 0x68
	private Vector3 clickOffset; // 0x6C
	private bool isMoving; // 0x78

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

	// RVA: 0xA17180 Offset: 0xA15B80 VA: 0x180A17180
	private void Start() { }

	// RVA: 0xA16D30 Offset: 0xA15730 VA: 0x180A16D30
	private void LateUpdate() { }

	// RVA: 0xA16F80 Offset: 0xA15980 VA: 0x180A16F80
	private void Move() { }

	// RVA: 0xA15A50 Offset: 0xA14450 VA: 0x180A15A50
	public void SetInteractable(bool interactable) { }

	// RVA: 0xA170F0 Offset: 0xA15AF0 VA: 0x180A170F0
	public void SetPosition(float newPosition) { }

	// RVA: 0xA169E0 Offset: 0xA153E0 VA: 0x180A169E0
	public void ClickStart(RaycastHit hit) { }

	// RVA: 0xA16A80 Offset: 0xA15480 VA: 0x180A16A80
	private Vector3 GetPlaneHit() { }

	// RVA: 0xA169D0 Offset: 0xA153D0 VA: 0x180A169D0
	public void ClickEnd() { }

	// RVA: 0xA172B0 Offset: 0xA15CB0 VA: 0x180A172B0
	public void .ctor() { }
}
