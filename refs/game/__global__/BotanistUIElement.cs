public class BotanistUIElement : WorldspaceUIElement // TypeDefIndex: 2911
{
	// Fields
	[Header("References")]
	public Image SupplyIcon; // 0x50
	public GameObject NoSupply; // 0x58
	public TextMeshProUGUI SupplyLabel; // 0x60
	public RectTransform[] PotRects; // 0x68
	[CompilerGenerated]
	private Botanist <AssignedBotanist>k__BackingField; // 0x70

	// Properties
	public Botanist AssignedBotanist { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Botanist get_AssignedBotanist() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	protected void set_AssignedBotanist(Botanist value) { }

	// RVA: 0x957DD0 Offset: 0x9567D0 VA: 0x180957DD0
	public void Initialize(Botanist bot) { }

	// RVA: 0x957F00 Offset: 0x956900 VA: 0x180957F00 Slot: 10
	protected virtual void RefreshUI() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
