public class Equippable_SprayBottle : Equippable_Viewmodel // TypeDefIndex: 2545
{
	// Fields
	private const float InteractionRange = 2.5;
	[CompilerGenerated]
	private string <InteractionLabel>k__BackingField; // 0x60
	[SerializeField]
	private GameObject _sprayablePrefab; // 0x68
	private WaterContainerInstance _waterContainerInstance; // 0x70

	// Properties
	[SerializeField]
	private string InteractionLabel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	private string get_InteractionLabel() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_InteractionLabel(string value) { }

	// RVA: 0x8B3D80 Offset: 0x8B2780 VA: 0x1808B3D80 Slot: 6
	protected override void Update() { }

	// RVA: 0x8B3BA0 Offset: 0x8B25A0 VA: 0x1808B3BA0 Slot: 9
	protected virtual bool CanSpray(GrowContainer growContainer, out string reason) { }

	// RVA: 0x8B3D10 Offset: 0x8B2710 VA: 0x1808B3D10
	protected void StartSprayTask(MushroomBed growContainer) { }

	// RVA: 0x8B4150 Offset: 0x8B2B50 VA: 0x1808B4150
	public void .ctor() { }
}
