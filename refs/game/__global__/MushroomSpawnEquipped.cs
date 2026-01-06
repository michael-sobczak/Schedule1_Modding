public class MushroomSpawnEquipped : Equippable_Viewmodel // TypeDefIndex: 2548
{
	// Fields
	private const float InteractionRange = 2.5;
	[CompilerGenerated]
	private string <InteractionLabel>k__BackingField; // 0x60
	[SerializeField]
	private GameObject _taskPrefab; // 0x68

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

	// RVA: 0x8B69C0 Offset: 0x8B53C0 VA: 0x1808B69C0 Slot: 6
	protected override void Update() { }

	// RVA: 0x8B6790 Offset: 0x8B5190 VA: 0x1808B6790 Slot: 9
	protected virtual bool CanApplyToMushroomBed(MushroomBed bed, out string reason) { }

	// RVA: 0x8B6900 Offset: 0x8B5300 VA: 0x1808B6900
	protected void StartTask(MushroomBed growContainer) { }

	// RVA: 0x8B6D60 Offset: 0x8B5760 VA: 0x1808B6D60
	public void .ctor() { }
}
