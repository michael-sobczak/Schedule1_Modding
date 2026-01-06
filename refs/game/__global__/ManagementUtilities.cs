public class ManagementUtilities : Singleton<ManagementUtilities> // TypeDefIndex: 1242
{
	// Fields
	public List<SeedDefinition> Seeds; // 0x28
	public List<ShroomSpawnDefinition> MushroomSpawns; // 0x30
	[CompilerGenerated]
	[SerializeField]
	private Sprite <StorageTypeIcon>k__BackingField; // 0x38
	[CompilerGenerated]
	[SerializeField]
	private StorageUIElement <StorageUIElementPrefab>k__BackingField; // 0x40

	// Properties
	public Sprite StorageTypeIcon { get; set; }
	public StorageUIElement StorageUIElementPrefab { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Sprite get_StorageTypeIcon() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_StorageTypeIcon(Sprite value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public StorageUIElement get_StorageUIElementPrefab() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_StorageUIElementPrefab(StorageUIElement value) { }

	// RVA: 0x61ACB0 Offset: 0x6196B0 VA: 0x18061ACB0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x61ACF0 Offset: 0x6196F0 VA: 0x18061ACF0
	public void .ctor() { }
}
