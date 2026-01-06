public class PotUIElement : WorldspaceUIElement // TypeDefIndex: 2923
{
	// Fields
	[Header("References")]
	public Image SeedIcon; // 0x50
	public GameObject NoSeed; // 0x58
	public Image Additive1Icon; // 0x60
	public Image Additive2Icon; // 0x68
	public Image Additive3Icon; // 0x70
	[CompilerGenerated]
	private Pot <AssignedPot>k__BackingField; // 0x78

	// Properties
	public Pot AssignedPot { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Pot get_AssignedPot() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_AssignedPot(Pot value) { }

	// RVA: 0x969860 Offset: 0x968260 VA: 0x180969860
	public void Initialize(Pot pot) { }

	// RVA: 0x969940 Offset: 0x968340 VA: 0x180969940 Slot: 10
	protected virtual void RefreshUI() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
