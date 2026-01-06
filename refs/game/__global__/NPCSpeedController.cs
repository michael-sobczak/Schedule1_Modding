public class NPCSpeedController : MonoBehaviour // TypeDefIndex: 1664
{
	// Fields
	[Range(0, 1)]
	[Header("Settings")]
	public float DefaultWalkSpeed; // 0x20
	[FormerlySerializedAs("SpeedMultiplier")]
	[SerializeField]
	private float _SpeedMultiplier; // 0x24
	[Header("References")]
	public NPCMovement Movement; // 0x28
	protected List<NPCSpeedController.SpeedControl> speedControlStack; // 0x30
	public NPCSpeedController.SpeedControl ActiveSpeedControl; // 0x38

	// Properties
	public float SpeedMultiplier { get; set; }

	// Methods

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_SpeedMultiplier() { }

	// RVA: 0x72C9E0 Offset: 0x72B3E0 VA: 0x18072C9E0
	public void set_SpeedMultiplier(float value) { }

	// RVA: 0x72C520 Offset: 0x72AF20 VA: 0x18072C520
	private void Awake() { }

	// RVA: 0x72C2E0 Offset: 0x72ACE0 VA: 0x18072C2E0
	public void AddSpeedControl(NPCSpeedController.SpeedControl control) { }

	// RVA: 0x72C6B0 Offset: 0x72B0B0 VA: 0x18072C6B0
	public NPCSpeedController.SpeedControl GetSpeedControl(string id) { }

	// RVA: 0x72C5D0 Offset: 0x72AFD0 VA: 0x18072C5D0
	public bool DoesSpeedControlExist(string id) { }

	// RVA: 0x72C790 Offset: 0x72B190 VA: 0x18072C790
	public void RemoveSpeedControl(string id) { }

	// RVA: 0x72C8B0 Offset: 0x72B2B0 VA: 0x18072C8B0
	private void UpdateActiveSpeedControl() { }

	// RVA: 0x72C950 Offset: 0x72B350 VA: 0x18072C950
	public void .ctor() { }
}
