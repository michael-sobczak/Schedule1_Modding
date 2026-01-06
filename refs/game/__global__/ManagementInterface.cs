public class ManagementInterface : Singleton<ManagementInterface> // TypeDefIndex: 1239
{
	// Fields
	public const float PANEL_SLIDE_TIME = 0;
	[CompilerGenerated]
	private ManagementClipboard_Equippable <EquippedClipboard>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public TextMeshProUGUI NothingSelectedLabel; // 0x38
	public TextMeshProUGUI DifferentTypesSelectedLabel; // 0x40
	public RectTransform PanelContainer; // 0x48
	public ClipboardScreen MainScreen; // 0x50
	public ItemSelector ItemSelectorScreen; // 0x58
	public NPCSelector NPCSelector; // 0x60
	public ObjectSelector ObjectSelector; // 0x68
	public RecipeSelector RecipeSelectorScreen; // 0x70
	public TransitEntitySelector TransitEntitySelector; // 0x78
	public StringSetter StringSetterScreen; // 0x80
	public Button RenameButton; // 0x88
	[SerializeField]
	protected ManagementInterface.ConfigurableTypePanel[] ConfigPanelPrefabs; // 0x90
	public List<IConfigurable> Configurables; // 0x98
	private bool areConfigurablesUniform; // 0xA0
	private ConfigPanel loadedPanel; // 0xA8

	// Properties
	public ManagementClipboard_Equippable EquippedClipboard { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ManagementClipboard_Equippable get_EquippedClipboard() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_EquippedClipboard(ManagementClipboard_Equippable value) { }

	// RVA: 0x619940 Offset: 0x618340 VA: 0x180619940 Slot: 4
	protected override void Start() { }

	// RVA: 0x6192E0 Offset: 0x617CE0 VA: 0x1806192E0
	public void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard) { }

	// RVA: 0x618C40 Offset: 0x617640 VA: 0x180618C40
	public void Close(bool preserveState = False) { }

	// RVA: 0x619C60 Offset: 0x618660 VA: 0x180619C60
	private void UpdateMainLabels() { }

	// RVA: 0x618F50 Offset: 0x617950 VA: 0x180618F50
	private void InitializeConfigPanel() { }

	// RVA: 0x618DB0 Offset: 0x6177B0 VA: 0x180618DB0
	private void DestroyConfigPanel() { }

	// RVA: 0x618E70 Offset: 0x617870 VA: 0x180618E70
	public ConfigPanel GetConfigPanelPrefab(EConfigurableType type) { }

	// RVA: 0x619650 Offset: 0x618050 VA: 0x180619650
	public void RenameButtonClicked() { }

	// RVA: 0x619CF0 Offset: 0x6186F0 VA: 0x180619CF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6199E0 Offset: 0x6183E0 VA: 0x1806199E0
	private void <RenameButtonClicked>g__CompleteRename|29_0(string newName) { }
}
