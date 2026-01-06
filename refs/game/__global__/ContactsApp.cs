public class ContactsApp : App<ContactsApp> // TypeDefIndex: 2858
{
	// Fields
	public EMapRegion SelectedRegion; // 0x68
	private Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict; // 0x70
	[Header("References")]
	public PinchableScrollRect ScrollRect; // 0x78
	public RectTransform CirclesContainer; // 0x80
	public RectTransform DemoCirclesContainer; // 0x88
	public RectTransform TutorialCirclesContainer; // 0x90
	public RectTransform ConnectionsContainer; // 0x98
	public RectTransform ContentRect; // 0xA0
	public RectTransform SelectionIndicator; // 0xA8
	public ContactsDetailPanel DetailPanel; // 0xB0
	public ContactsApp.RegionUI[] RegionUIs; // 0xB8
	public RectTransform RegionSelectionContainer; // 0xC0
	public RectTransform RegionSelectionIndicator; // 0xC8
	public RectTransform InfluenceContainer; // 0xD0
	public Slider InfluenceSlider; // 0xD8
	public Text InfluenceCountLabel; // 0xE0
	public RectTransform UnlockRegionSliderNotch; // 0xE8
	public Text InfluenceText; // 0xF0
	public RectTransform LowerContainer; // 0xF8
	public RectTransform HorizontalScrollbarRectTransform; // 0x100
	public RectTransform RegionLockedContainer; // 0x108
	public RectTransform RegionLocked_Rank; // 0x110
	public RectTransform RegionLocked_CartelInfluence; // 0x118
	public Text RegionLocked_CartelInfluence_Text; // 0x120
	public RectTransform RegionLocked_Unavailable; // 0x128
	[Header("Prefabs")]
	public GameObject ConnectionPrefab; // 0x130
	private List<RelationCircle> RelationCircles; // 0x138
	private Coroutine contentMoveRoutine; // 0x140
	private List<Tuple<NPC, NPC>> connections; // 0x148

	// Methods

	// RVA: 0x9412F0 Offset: 0x93FCF0 VA: 0x1809412F0 Slot: 5
	protected override void Start() { }

	// RVA: 0x942A10 Offset: 0x941410 VA: 0x180942A10 Slot: 8
	protected override void Update() { }

	// RVA: 0x9405F0 Offset: 0x93EFF0 VA: 0x1809405F0
	private RelationCircle GetRelationCircle(string npcID) { }

	// RVA: 0x940560 Offset: 0x93EF60 VA: 0x180940560
	private void CircleClicked(RelationCircle circ) { }

	// RVA: 0x940560 Offset: 0x93EF60 VA: 0x180940560
	private void Select(RelationCircle circ) { }

	// RVA: 0x940830 Offset: 0x93F230 VA: 0x180940830
	public void SetSelectedRegion(EMapRegion region, bool selectNPC) { }

	// RVA: 0x942C30 Offset: 0x941630 VA: 0x180942C30
	private void ZoomToRect(RectTransform rect) { }

	// RVA: 0x942970 Offset: 0x941370 VA: 0x180942970
	private void StopContentMove() { }

	// RVA: 0x9406D0 Offset: 0x93F0D0 VA: 0x1809406D0 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x942E20 Offset: 0x941820 VA: 0x180942E20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x942990 Offset: 0x941390 VA: 0x180942990
	private void <SetSelectedRegion>g__SetCartelInfluenceDisplayVisible|35_0(bool vis) { }
}
