public class BombPlantLocation : MonoBehaviour // TypeDefIndex: 2271
{
	// Fields
	public const float COUNTDOWN_TIME = 45;
	public const float BEEP_INTERVAL_MAX = 1;
	public const float BEEP_INTERVAL_MIN = 0.125;
	[CompilerGenerated]
	private bool <BombPlanted>k__BackingField; // 0x20
	[Header("References")]
	public InteractableObject IntObj; // 0x28
	public GameObject BombModel; // 0x30
	public UnityEvent onPlantBomb; // 0x38
	public UnityEvent onBeep; // 0x40
	public UnityEvent onDetonate; // 0x48

	// Properties
	public bool BombPlanted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_BombPlanted() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_BombPlanted(bool value) { }

	// RVA: 0x83E0D0 Offset: 0x83CAD0 VA: 0x18083E0D0
	private void Awake() { }

	// RVA: 0x83E290 Offset: 0x83CC90 VA: 0x18083E290
	private void Hovered() { }

	// RVA: 0x83E310 Offset: 0x83CD10 VA: 0x18083E310
	private void Interacted() { }

	// RVA: 0x83E340 Offset: 0x83CD40 VA: 0x18083E340
	public void PlantBomb() { }

	// RVA: 0x83E1E0 Offset: 0x83CBE0 VA: 0x18083E1E0
	private bool CanPlantBomb() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[IteratorStateMachine(typeof(BombPlantLocation.<<PlantBomb>g__Detonate|15_0>d))]
	[CompilerGenerated]
	// RVA: 0x83E4E0 Offset: 0x83CEE0 VA: 0x18083E4E0
	private IEnumerator <PlantBomb>g__Detonate|15_0() { }
}
