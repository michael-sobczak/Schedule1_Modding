public abstract class Plant : MonoBehaviour // TypeDefIndex: 2372
{
	// Fields
	public const float BaseQualityLevel = 0.5;
	[CompilerGenerated]
	private Pot <Pot>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <NormalizedGrowthProgress>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <YieldMultiplier>k__BackingField; // 0x2C
	[CompilerGenerated]
	private float <QualityLevel>k__BackingField; // 0x30
	[Header("References")]
	public Transform VisualsContainer; // 0x38
	public PlantGrowthStage[] GrowthStages; // 0x40
	public Collider Collider; // 0x48
	public AudioSourceController SnipSound; // 0x50
	public AudioSourceController DestroySound; // 0x58
	public ParticleSystem FullyGrownParticles; // 0x60
	public Transform HarvestLabelPositionTransform; // 0x68
	[Header("Settings")]
	public SeedDefinition SeedDefinition; // 0x70
	public int GrowthTime; // 0x78
	public int BaseYieldQuantity; // 0x7C
	public string HarvestTarget; // 0x80
	[Header("Trash")]
	public TrashItem PlantScrapPrefab; // 0x88
	[HideInInspector]
	public List<int> ActiveHarvestables; // 0x90
	public Action onFullyHarvested; // 0x98

	// Properties
	public Pot Pot { get; set; }
	public float NormalizedGrowthProgress { get; set; }
	public bool IsFullyGrown { get; }
	public float YieldMultiplier { get; set; }
	public float QualityLevel { get; set; }
	public PlantGrowthStage FinalGrowthStage { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Pot get_Pot() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Pot(Pot value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_NormalizedGrowthProgress() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	protected void set_NormalizedGrowthProgress(float value) { }

	// RVA: 0x866270 Offset: 0x864C70 VA: 0x180866270
	public bool get_IsFullyGrown() { }

	[CompilerGenerated]
	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_YieldMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	private void set_YieldMultiplier(float value) { }

	[CompilerGenerated]
	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_QualityLevel() { }

	[CompilerGenerated]
	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	private void set_QualityLevel(float value) { }

	// RVA: 0x866230 Offset: 0x864C30 VA: 0x180866230
	public PlantGrowthStage get_FinalGrowthStage() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x8654F0 Offset: 0x863EF0 VA: 0x1808654F0 Slot: 4
	public virtual void Initialize(NetworkObject pot, float growthProgress) { }

	// RVA: 0x865700 Offset: 0x864100 VA: 0x180865700 Slot: 5
	public virtual void MinPass(int mins) { }

	// RVA: 0x864E50 Offset: 0x863850 VA: 0x180864E50
	public void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication) { }

	// RVA: 0x866070 Offset: 0x864A70 VA: 0x180866070 Slot: 6
	public virtual void SetNormalizedGrowthProgress(float progress) { }

	// RVA: 0x866130 Offset: 0x864B30 VA: 0x180866130 Slot: 7
	protected virtual void UpdateVisuals() { }

	// RVA: 0x865EE0 Offset: 0x8648E0 VA: 0x180865EE0 Slot: 8
	public virtual void SetHarvestableActive(int index, bool active) { }

	// RVA: 0x865A30 Offset: 0x864430 VA: 0x180865A30
	private void OnFullyHarvested() { }

	// RVA: 0x8656A0 Offset: 0x8640A0 VA: 0x1808656A0
	public bool IsHarvestableActive(int index) { }

	// RVA: 0x865250 Offset: 0x863C50 VA: 0x180865250
	private void GrowthDone() { }

	// RVA: 0x864EE0 Offset: 0x8638E0 VA: 0x180864EE0
	private List<int> GenerateUniqueIntegers(int min, int max, int count) { }

	// RVA: 0x8660F0 Offset: 0x864AF0 VA: 0x1808660F0
	public void SetVisible(bool vis) { }

	// RVA: 0x865130 Offset: 0x863B30 VA: 0x180865130 Slot: 9
	public virtual ItemInstance GetHarvestedProduct(int quantity = 1) { }

	// RVA: 0x865190 Offset: 0x863B90 VA: 0x180865190
	public PlantData GetPlantData() { }

	// RVA: 0x857BC0 Offset: 0x8565C0 VA: 0x180857BC0
	protected void .ctor() { }
}
