public class StorageManager : NetworkSingleton<StorageManager>, IBaseSaveable, ISaveable // TypeDefIndex: 2400
{
	// Fields
	private StorageLoader loader; // 0x120
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x128
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x138
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x13C
	private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted; // 0x141

	// Properties
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x887A40 Offset: 0x886440 VA: 0x180887A40 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x887A10 Offset: 0x886410 VA: 0x180887A10 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x6BFF00 Offset: 0x6BE900 VA: 0x1806BFF00 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD80 Offset: 0x6BE780 VA: 0x1806BFD80 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x887540 Offset: 0x885F40 VA: 0x180887540 Slot: 20
	public override void Awake() { }

	// RVA: 0x8877D0 Offset: 0x8861D0 VA: 0x1808877D0 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x8875C0 Offset: 0x885FC0 VA: 0x1808875C0 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x887900 Offset: 0x886300 VA: 0x180887900
	public void .ctor() { }

	// RVA: 0x8878B0 Offset: 0x8862B0 VA: 0x1808878B0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x887860 Offset: 0x886260 VA: 0x180887860 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x8874F0 Offset: 0x885EF0 VA: 0x1808874F0 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Storage.StorageManager_Assembly-CSharp.dll() { }
}
