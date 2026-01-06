public class MushroomBedUIElement : WorldspaceUIElement // TypeDefIndex: 2920
{
	// Fields
	[Header("References")]
	public Image SpawnIcon; // 0x50
	public GameObject NoSpawn; // 0x58
	public Image Additive1Icon; // 0x60
	public Image Additive2Icon; // 0x68
	public Image Additive3Icon; // 0x70
	[CompilerGenerated]
	private MushroomBed <AssignedMustroomBed>k__BackingField; // 0x78

	// Properties
	public MushroomBed AssignedMustroomBed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public MushroomBed get_AssignedMustroomBed() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	protected void set_AssignedMustroomBed(MushroomBed value) { }

	// RVA: 0x965E20 Offset: 0x964820 VA: 0x180965E20
	public void Initialize(MushroomBed bed) { }

	// RVA: 0x965F00 Offset: 0x964900 VA: 0x180965F00 Slot: 10
	protected virtual void RefreshUI() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
