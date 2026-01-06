public class TrashGenerator : MonoBehaviour, IGUIDRegisterable, ISaveable // TypeDefIndex: 2247
{
	// Fields
	public const float TRASH_GENERATION_FRACTION = 0.2;
	public const float DEFAULT_TRASH_PER_M2 = 0.015;
	public static List<TrashGenerator> AllGenerators; // 0x0
	[SerializeField]
	[Range(1, 200)]
	private int MaxTrashCount; // 0x20
	[SerializeField]
	private int TrashCountMultiplier; // 0x24
	[SerializeField]
	private List<TrashItem> generatedTrash; // 0x28
	[Header("Settings")]
	public LayerMask GroundCheckMask; // 0x30
	private BoxCollider boxCollider; // 0x38
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x40
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x50
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x54
	public string StaticGUID; // 0x68

	// Properties
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public Guid GUID { get; set; }

	// Methods

	// RVA: 0x84CC70 Offset: 0x84B670 VA: 0x18084CC70 Slot: 7
	public string get_SaveFolderName() { }

	// RVA: 0x84CC00 Offset: 0x84B600 VA: 0x18084CC00 Slot: 8
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 11
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0 Slot: 12
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 13
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 14
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0 Slot: 15
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0 Slot: 16
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x84CBF0 Offset: 0x84B5F0 VA: 0x18084CBF0 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x84CCE0 Offset: 0x84B6E0 VA: 0x18084CCE0
	protected void set_GUID(Guid value) { }

	// RVA: 0x84C660 Offset: 0x84B060 VA: 0x18084C660 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x84B6F0 Offset: 0x84A0F0 VA: 0x18084B6F0
	private void Awake() { }

	// RVA: 0x84C7F0 Offset: 0x84B1F0 VA: 0x18084C7F0
	private void Start() { }

	// RVA: 0x84C1B0 Offset: 0x84ABB0 VA: 0x18084C1B0 Slot: 30
	public virtual void InitializeSaveable() { }

	// RVA: 0x84C4D0 Offset: 0x84AED0 VA: 0x18084C4D0
	private void OnValidate() { }

	// RVA: 0x84C240 Offset: 0x84AC40 VA: 0x18084C240
	private void OnDestroy() { }

	// RVA: 0x84C2C0 Offset: 0x84ACC0 VA: 0x18084C2C0
	private void OnDrawGizmos() { }

	// RVA: 0x84B430 Offset: 0x849E30 VA: 0x18084B430
	public void AddGeneratedTrash(TrashItem item) { }

	// RVA: 0x84C530 Offset: 0x84AF30 VA: 0x18084C530
	public void RemoveGeneratedTrash(TrashItem item) { }

	[Button]
	// RVA: 0x6D1360 Offset: 0x6CFD60 VA: 0x1806D1360
	private void RegenerateGUID() { }

	[Button]
	// RVA: 0x84B590 Offset: 0x849F90 VA: 0x18084B590
	private void AutoCalculateTrashCount() { }

	[Button]
	// RVA: 0x84B7C0 Offset: 0x84A1C0 VA: 0x18084B7C0
	private void GenerateMaxTrash() { }

	// RVA: 0x84C710 Offset: 0x84B110 VA: 0x18084C710
	private void SleepStart() { }

	// RVA: 0x84B810 Offset: 0x84A210 VA: 0x18084B810
	private void GenerateTrash(int count) { }

	// RVA: 0x84C6C0 Offset: 0x84B0C0 VA: 0x18084C6C0
	public bool ShouldSave() { }

	// RVA: 0x84BFD0 Offset: 0x84A9D0 VA: 0x18084BFD0 Slot: 31
	public virtual TrashGeneratorData GetSaveData() { }

	// RVA: 0x84C170 Offset: 0x84AB70 VA: 0x18084C170 Slot: 18
	public string GetSaveString() { }

	// RVA: 0x84CAC0 Offset: 0x84B4C0 VA: 0x18084CAC0
	public void .ctor() { }

	// RVA: 0x84CA30 Offset: 0x84B430 VA: 0x18084CA30
	private static void .cctor() { }
}
