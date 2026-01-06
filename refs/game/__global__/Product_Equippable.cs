public class Product_Equippable : Equippable_Viewmodel // TypeDefIndex: 2488
{
	// Fields
	[Header("References")]
	public ProductVisualsSetter Visuals; // 0x60
	public Transform ModelContainer; // 0x68
	private ProductConsumeAnimation consumeAnimation; // 0x70
	private bool isConsumable; // 0x78
	private float consumeTime; // 0x7C
	private bool consumingInProgress; // 0x80
	private Vector3 defaultModelPosition; // 0x84
	private Coroutine consumeRoutine; // 0x90
	private bool mouseUp; // 0x98

	// Properties
	public string ConsumeDescription { get; }
	public float PrepareDuration { get; }
	public float EffectsApplyDelay { get; }

	// Methods

	// RVA: 0x8B9850 Offset: 0x8B8250 VA: 0x1808B9850
	public string get_ConsumeDescription() { }

	// RVA: 0x8B9890 Offset: 0x8B8290 VA: 0x1808B9890
	public float get_PrepareDuration() { }

	// RVA: 0x8B9870 Offset: 0x8B8270 VA: 0x1808B9870
	public float get_EffectsApplyDelay() { }

	// RVA: 0x8B8BA0 Offset: 0x8B75A0 VA: 0x1808B8BA0 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0x8B8A10 Offset: 0x8B7410 VA: 0x1808B8A10 Slot: 9
	protected virtual void ApplyProductVisuals(ProductItemInstance product) { }

	// RVA: 0x8B92C0 Offset: 0x8B7CC0 VA: 0x1808B92C0 Slot: 5
	public override void Unequip() { }

	// RVA: 0x8B9390 Offset: 0x8B7D90 VA: 0x1808B9390 Slot: 6
	protected override void Update() { }

	// RVA: 0x8B91D0 Offset: 0x8B7BD0 VA: 0x1808B91D0 Slot: 10
	protected virtual void StartPrepare() { }

	// RVA: 0x8B8A30 Offset: 0x8B7430 VA: 0x1808B8A30 Slot: 11
	protected virtual void CancelPrepare() { }

	// RVA: 0x8B8AB0 Offset: 0x8B74B0 VA: 0x1808B8AB0 Slot: 12
	protected virtual void Consume() { }

	// RVA: 0x8B8950 Offset: 0x8B7350 VA: 0x1808B8950 Slot: 13
	protected virtual void ApplyEffects() { }

	// RVA: 0x8B97B0 Offset: 0x8B81B0 VA: 0x1808B97B0
	public void .ctor() { }

	[IteratorStateMachine(typeof(Product_Equippable.<<Consume>g__ConsumeRoutine|21_0>d))]
	[CompilerGenerated]
	// RVA: 0x8B9250 Offset: 0x8B7C50 VA: 0x1808B9250
	private IEnumerator <Consume>g__ConsumeRoutine|21_0() { }
}
