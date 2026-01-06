public class LiquidContainer : MonoBehaviour // TypeDefIndex: 2425
{
	// Fields
	[CompilerGenerated]
	private float <CurrentLiquidLevel>k__BackingField; // 0x20
	[CompilerGenerated]
	private Color <LiquidColor>k__BackingField; // 0x24
	[Range(0, 1)]
	[Header("Settings")]
	public float Viscosity; // 0x34
	public bool AdjustMurkiness; // 0x38
	[Header("References")]
	public LiquidVolume LiquidVolume; // 0x40
	public LiquidVolumeCollider Collider; // 0x48
	public Transform ColliderTransform_Min; // 0x50
	public Transform ColliderTransform_Max; // 0x58
	[Header("Visuals Settings")]
	public float MaxLevel; // 0x60
	private MeshRenderer liquidMesh; // 0x68

	// Properties
	public float CurrentLiquidLevel { get; set; }
	public Color LiquidColor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_CurrentLiquidLevel() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	private void set_CurrentLiquidLevel(float value) { }

	[CompilerGenerated]
	// RVA: 0x83F4E0 Offset: 0x83DEE0 VA: 0x18083F4E0
	public Color get_LiquidColor() { }

	[CompilerGenerated]
	// RVA: 0x8735A0 Offset: 0x871FA0 VA: 0x1808735A0
	private void set_LiquidColor(Color value) { }

	// RVA: 0x872C70 Offset: 0x871670 VA: 0x180872C70
	private void Awake() { }

	// RVA: 0x8732A0 Offset: 0x871CA0 VA: 0x1808732A0
	private void Start() { }

	// RVA: 0x872D30 Offset: 0x871730 VA: 0x180872D30
	private void OnDestroy() { }

	// RVA: 0x872D20 Offset: 0x871720 VA: 0x180872D20
	private void MinPass() { }

	// RVA: 0x873410 Offset: 0x871E10 VA: 0x180873410
	private void UpdateLighting() { }

	// RVA: 0x872EE0 Offset: 0x8718E0 VA: 0x180872EE0
	public void SetLiquidLevel(float level, bool debug = False) { }

	// RVA: 0x872E50 Offset: 0x871850 VA: 0x180872E50
	public void SetLiquidColor(Color color, bool setColorVariable = True, bool updateLigting = True) { }

	// RVA: 0x873570 Offset: 0x871F70 VA: 0x180873570
	public void .ctor() { }
}
