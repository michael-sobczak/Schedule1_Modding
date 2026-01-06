public class SupplierStash : MonoBehaviour // TypeDefIndex: 1530
{
	// Fields
	public string locationDescription; // 0x20
	[Header("References")]
	public Supplier Supplier; // 0x28
	public StorageEntity Storage; // 0x30
	public InteractableObject IntObj; // 0x38
	public OptimizedLight Light; // 0x40
	public POI StashPoI; // 0x48
	[CompilerGenerated]
	private float <CashAmount>k__BackingField; // 0x50

	// Properties
	public float CashAmount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_CashAmount() { }

	[CompilerGenerated]
	// RVA: 0x6FF440 Offset: 0x6FDE40 VA: 0x1806FF440
	private void set_CashAmount(float value) { }

	// RVA: 0x6FE730 Offset: 0x6FD130 VA: 0x1806FE730 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x6FF1D0 Offset: 0x6FDBD0 VA: 0x1806FF1D0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x6FF370 Offset: 0x6FDD70 VA: 0x1806FF370
	private void SupplierUnlocked() { }

	// RVA: 0x6FED40 Offset: 0x6FD740 VA: 0x1806FED40
	private void RecalculateCash() { }

	// RVA: 0x6FEBD0 Offset: 0x6FD5D0 VA: 0x1806FEBD0
	private void Interacted() { }

	// RVA: 0x6FEF70 Offset: 0x6FD970 VA: 0x1806FEF70
	public void RemoveCash(float amount) { }

	// RVA: 0x6FF3B0 Offset: 0x6FDDB0 VA: 0x1806FF3B0
	private void UpdateDeadDrop() { }

	// RVA: 0x6FF3F0 Offset: 0x6FDDF0 VA: 0x1806FF3F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6FF370 Offset: 0x6FDD70 VA: 0x1806FF370
	private void <Awake>b__10_0(NPCRelationData.EUnlockType type, bool b) { }
}
