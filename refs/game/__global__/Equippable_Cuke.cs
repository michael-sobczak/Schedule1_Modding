public class Equippable_Cuke : Equippable_Viewmodel // TypeDefIndex: 2524
{
	// Fields
	[CompilerGenerated]
	private bool <IsDrinking>k__BackingField; // 0x60
	[Header("Settings")]
	public float BaseEnergyGain; // 0x64
	public float MinEnergyGain; // 0x68
	public float ConsecutiveReduction; // 0x6C
	public float HealthGain; // 0x70
	public float AnimationDuration; // 0x74
	public bool ClearDrugEffects; // 0x78
	public ProductDefinition PseudoProduct; // 0x80
	[Header("References")]
	public Animation OpenAnim; // 0x88
	public Animation DrinkAnim; // 0x90
	public AudioSourceController OpenSound; // 0x98
	public AudioSourceController SlurpSound; // 0xA0
	public TrashItem TrashPrefab; // 0xA8

	// Properties
	public bool IsDrinking { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_IsDrinking() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	protected void set_IsDrinking(bool value) { }

	// RVA: 0x8AE550 Offset: 0x8ACF50 VA: 0x1808AE550 Slot: 6
	protected override void Update() { }

	// RVA: 0x8AE460 Offset: 0x8ACE60 VA: 0x1808AE460
	public void Drink() { }

	// RVA: 0x8AE030 Offset: 0x8ACA30 VA: 0x1808AE030
	public void ApplyEffects() { }

	// RVA: 0x8AE680 Offset: 0x8AD080 VA: 0x1808AE680
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Equippable_Cuke.<<Drink>g__DrinkRoutine|17_0>d))]
	// RVA: 0x8AE4E0 Offset: 0x8ACEE0 VA: 0x1808AE4E0
	private IEnumerator <Drink>g__DrinkRoutine|17_0() { }
}
