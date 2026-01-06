public class WorldStorageEntity : StorageEntity, IGUIDRegisterable, ISaveable // TypeDefIndex: 2409
{
	// Fields
	public static List<WorldStorageEntity> All; // 0x0
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x170
	[SerializeField]
	protected string BakedGUID; // 0x180
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x188
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x190
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x198
	public GameDateTime LastContentChangeTime; // 0x19C
	private bool NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted; // 0x1A4
	private bool NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted; // 0x1A5

	// Properties
	public Guid GUID { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x88C110 Offset: 0x88AB10 VA: 0x18088C110 Slot: 44
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x88C230 Offset: 0x88AC30 VA: 0x18088C230
	protected void set_GUID(Guid value) { }

	[Button]
	// RVA: 0x88BDD0 Offset: 0x88A7D0 VA: 0x18088BDD0
	public void RegenerateGUID() { }

	// RVA: 0x88C1B0 Offset: 0x88ABB0 VA: 0x18088C1B0 Slot: 47
	public string get_SaveFolderName() { }

	// RVA: 0x88C130 Offset: 0x88AB30 VA: 0x18088C130 Slot: 48
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 49
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 50
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380 Slot: 51
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0 Slot: 52
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290 Slot: 53
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490 Slot: 54
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x88C120 Offset: 0x88AB20 VA: 0x18088C120 Slot: 55
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x88C240 Offset: 0x88AC40 VA: 0x18088C240 Slot: 56
	public void set_HasChanged(bool value) { }

	// RVA: 0x88BA10 Offset: 0x88A410 VA: 0x18088BA10 Slot: 30
	public override void Awake() { }

	// RVA: 0x88BD40 Offset: 0x88A740 VA: 0x18088BD40 Slot: 32
	protected override void OnDestroy() { }

	// RVA: 0x88BC10 Offset: 0x88A610 VA: 0x18088BC10 Slot: 70
	public virtual void InitializeSaveable() { }

	// RVA: 0x88BE20 Offset: 0x88A820 VA: 0x18088BE20 Slot: 46
	public void SetGUID(Guid guid) { }

	// RVA: 0x88BE90 Offset: 0x88A890 VA: 0x18088BE90 Slot: 71
	public virtual bool ShouldSave() { }

	// RVA: 0x88BB10 Offset: 0x88A510 VA: 0x18088BB10
	public WorldStorageEntityData GetSaveData() { }

	// RVA: 0x88BBD0 Offset: 0x88A5D0 VA: 0x18088BBD0 Slot: 72
	public virtual string GetSaveString() { }

	// RVA: 0x88BCA0 Offset: 0x88A6A0 VA: 0x18088BCA0 Slot: 73
	public virtual void Load(WorldStorageEntityData data) { }

	// RVA: 0x88BA60 Offset: 0x88A460 VA: 0x18088BA60 Slot: 33
	protected override void ContentsChanged() { }

	// RVA: 0x88BF70 Offset: 0x88A970 VA: 0x18088BF70
	public void .ctor() { }

	// RVA: 0x88BEE0 Offset: 0x88A8E0 VA: 0x18088BEE0
	private static void .cctor() { }

	// RVA: 0x88BD20 Offset: 0x88A720 VA: 0x18088BD20 Slot: 37
	public override void NetworkInitialize___Early() { }

	// RVA: 0x88BCF0 Offset: 0x88A6F0 VA: 0x18088BCF0 Slot: 38
	public override void NetworkInitialize__Late() { }

	// RVA: 0x870DC0 Offset: 0x86F7C0 VA: 0x180870DC0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x88B770 Offset: 0x88A170 VA: 0x18088B770 Slot: 74
	protected override void Awake_UserLogic_ScheduleOne.Storage.WorldStorageEntity_Assembly-CSharp.dll() { }
}
