public class GrowingMushroom : MonoBehaviour // TypeDefIndex: 2369
{
	// Fields
	private const float CapExpansionThreshold = 0.5;
	[HideInInspector]
	public float LateralScaleMultiplier; // 0x20
	[HideInInspector]
	public float VerticalScaleMultiplier; // 0x24
	[HideInInspector]
	public float MaxCapExpansion; // 0x28
	[SerializeField]
	private Transform _modelContainer; // 0x30
	[SerializeField]
	private SkinnedMeshRenderer[] _meshRenderers; // 0x38
	[SerializeField]
	private AudioSourceController _harvestSound; // 0x40
	private ShroomColony _parentColony; // 0x48
	private int _alignmentIndex; // 0x50

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x861270 Offset: 0x85FC70 VA: 0x180861270
	public void Initialize(ShroomColony parentColony, int alignmentIndex) { }

	// RVA: 0x8612A0 Offset: 0x85FCA0 VA: 0x1808612A0
	public void SetGrowthPercent(float percent) { }

	[Button]
	// RVA: 0x860E40 Offset: 0x85F840 VA: 0x180860E40
	public void Harvest() { }

	// RVA: 0x861460 Offset: 0x85FE60 VA: 0x180861460
	public void .ctor() { }
}
