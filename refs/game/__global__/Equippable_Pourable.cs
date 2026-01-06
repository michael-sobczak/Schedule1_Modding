public class Equippable_Pourable : Equippable_Viewmodel // TypeDefIndex: 2537
{
	// Fields
	private const float InteractionRange = 2.5;
	[SerializeField]
	[CompilerGenerated]
	private string <InteractionLabel>k__BackingField; // 0x60
	[SerializeField]
	public Pourable PourablePrefab; // 0x68

	// Properties
	public string InteractionLabel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_InteractionLabel() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_InteractionLabel(string value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void Awake() { }

	// RVA: 0x8AFEF0 Offset: 0x8AE8F0 VA: 0x1808AFEF0 Slot: 6
	protected override void Update() { }

	// RVA: 0x8AFE80 Offset: 0x8AE880 VA: 0x1808AFE80 Slot: 10
	protected virtual void StartPourTask(GrowContainer growContainer) { }

	// RVA: 0x8AFE30 Offset: 0x8AE830 VA: 0x1808AFE30 Slot: 11
	protected virtual bool CanPour(GrowContainer growContainer, out string reason) { }

	// RVA: 0x8B0290 Offset: 0x8AEC90 VA: 0x1808B0290
	public void .ctor() { }
}
