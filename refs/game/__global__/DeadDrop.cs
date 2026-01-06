public class DeadDrop : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 1505
{
	// Fields
	public static List<DeadDrop> DeadDrops; // 0x0
	public string DeadDropName; // 0x20
	public string DeadDropDescription; // 0x28
	public EMapRegion Region; // 0x30
	public WorldStorageEntity Storage; // 0x38
	public POI PoI; // 0x40
	public OptimizedLight Light; // 0x48
	public string ItemCountVariable; // 0x50
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x58
	[SerializeField]
	protected string BakedGUID; // 0x68

	// Properties
	public Guid GUID { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x6D1920 Offset: 0x6D0320 VA: 0x1806D1920
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x6D1360 Offset: 0x6CFD60 VA: 0x1806D1360
	public void RegenerateGUID() { }

	// RVA: 0x6D0EE0 Offset: 0x6CF8E0 VA: 0x1806D0EE0 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x6D1330 Offset: 0x6CFD30 VA: 0x1806D1330
	private void OnValidate() { }

	// RVA: 0x6D1410 Offset: 0x6CFE10 VA: 0x1806D1410 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x6D13B0 Offset: 0x6CFDB0 VA: 0x1806D13B0 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x6D12B0 Offset: 0x6CFCB0 VA: 0x1806D12B0
	public void OnDestroy() { }

	// RVA: 0x6D1000 Offset: 0x6CFA00 VA: 0x1806D1000
	public static DeadDrop GetRandomEmptyDrop(Vector3 origin) { }

	// RVA: 0x6D16D0 Offset: 0x6D00D0 VA: 0x1806D16D0
	private void UpdateDeadDrop() { }

	// RVA: 0x6D18B0 Offset: 0x6D02B0 VA: 0x1806D18B0
	public void .ctor() { }

	// RVA: 0x6D1820 Offset: 0x6D0220 VA: 0x1806D1820
	private static void .cctor() { }
}
