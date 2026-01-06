public class PourableSoil : Pourable // TypeDefIndex: 3306
{
	// Fields
	public const float TEAR_ANGLE = 10;
	public const float HIGHLIGHT_CYCLE_TIME = 5;
	public bool IsOpen; // 0x140
	public SoilDefinition SoilDefinition; // 0x148
	[Header("References")]
	public Transform SoilBag; // 0x150
	public Transform[] Bones; // 0x158
	public List<Collider> TopColliders; // 0x160
	public MeshRenderer[] Highlights; // 0x168
	public Transform TopParent; // 0x170
	public AudioSourceController SnipSound; // 0x178
	public SkinnedMeshRenderer TopMesh; // 0x180
	[CompilerGenerated]
	private int <currentCut>k__BackingField; // 0x188
	public UnityEvent onOpened; // 0x190
	private Vector3 highlightScale; // 0x198
	private float timeSinceStart; // 0x1A4

	// Properties
	public int currentCut { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9E1B10 Offset: 0x9E0510 VA: 0x1809E1B10
	public int get_currentCut() { }

	[CompilerGenerated]
	// RVA: 0xA55270 Offset: 0xA53C70 VA: 0x180A55270
	protected void set_currentCut(int value) { }

	// RVA: 0xA546C0 Offset: 0xA530C0 VA: 0x180A546C0 Slot: 8
	protected override void Awake() { }

	// RVA: 0xA551C0 Offset: 0xA53BC0 VA: 0x180A551C0 Slot: 10
	protected override void Update() { }

	// RVA: 0xA54F70 Offset: 0xA53970 VA: 0x180A54F70
	private void UpdateHighlights() { }

	// RVA: 0xA54E00 Offset: 0xA53800 VA: 0x180A54E00 Slot: 16
	protected override void PourAmount(float amount) { }

	// RVA: 0xA54740 Offset: 0xA53140 VA: 0x180A54740 Slot: 17
	protected override bool CanPour() { }

	// RVA: 0xA54760 Offset: 0xA53160 VA: 0x180A54760
	public void Cut() { }

	// RVA: 0xA54860 Offset: 0xA53260 VA: 0x180A54860
	private void FinishCut() { }

	// RVA: 0xA54B20 Offset: 0xA53520 VA: 0x180A54B20
	private void LerpCut(int cutIndex) { }

	// RVA: 0xA55210 Offset: 0xA53C10 VA: 0x180A55210
	public void .ctor() { }
}
