public class Map : Singleton<Map> // TypeDefIndex: 3342
{
	// Fields
	public const EMapRegion FINAL_REGION = 5;
	public bool UNLOCK_ALL_REGIONS; // 0x28
	public MapRegionData[] Regions; // 0x30
	[Header("References")]
	public PoliceStation PoliceStation; // 0x38
	public MedicalCentre MedicalCentre; // 0x40
	public Transform TreeBounds; // 0x48

	// Methods

	// RVA: 0xA4E9F0 Offset: 0xA4D3F0 VA: 0x180A4E9F0 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA4F310 Offset: 0xA4DD10 VA: 0x180A4F310 Slot: 4
	protected override void Start() { }

	// RVA: 0xA4F190 Offset: 0xA4DB90 VA: 0x180A4F190
	private void OnRankUp(FullRank old, FullRank newRank) { }

	// RVA: 0xA4EE90 Offset: 0xA4D890 VA: 0x180A4EE90
	public MapRegionData GetRegionData(EMapRegion region) { }

	// RVA: 0xA4F0B0 Offset: 0xA4DAB0 VA: 0x180A4F0B0
	public List<EMapRegion> GetUnlockedRegions() { }

	// RVA: 0xA4EF60 Offset: 0xA4D960 VA: 0x180A4EF60
	public EMapRegion GetRegionFromPosition(Vector3 position) { }

	// RVA: 0xA4F510 Offset: 0xA4DF10 VA: 0x180A4F510
	public void .ctor() { }
}
