public class ItemPickup : MonoBehaviour // TypeDefIndex: 3073
{
	// Fields
	public ItemDefinition ItemToGive; // 0x20
	public bool DestroyOnPickup; // 0x28
	public bool ConditionallyActive; // 0x29
	public Condition ActiveCondition; // 0x30
	[Header("References")]
	public InteractableObject IntObj; // 0x38
	public UnityEvent onPickup; // 0x40

	// Methods

	// RVA: 0x997CE0 Offset: 0x9966E0 VA: 0x180997CE0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x9983E0 Offset: 0x996DE0 VA: 0x1809983E0
	private void Start() { }

	// RVA: 0x998080 Offset: 0x996A80 VA: 0x180998080
	private void Init() { }

	// RVA: 0x997FA0 Offset: 0x9969A0 VA: 0x180997FA0 Slot: 5
	protected virtual void Hovered() { }

	// RVA: 0x998270 Offset: 0x996C70 VA: 0x180998270
	private void Interacted() { }

	// RVA: 0x997E40 Offset: 0x996840 VA: 0x180997E40 Slot: 6
	protected virtual bool CanPickup() { }

	// RVA: 0x9982C0 Offset: 0x996CC0 VA: 0x1809982C0 Slot: 7
	protected virtual void Pickup() { }

	// RVA: 0x997F40 Offset: 0x996940 VA: 0x180997F40
	public void Destroy() { }

	// RVA: 0x83B4E0 Offset: 0x839EE0 VA: 0x18083B4E0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(ItemPickup.<<Init>g__Wait|8_0>d))]
	// RVA: 0x998590 Offset: 0x996F90 VA: 0x180998590
	private IEnumerator <Init>g__Wait|8_0() { }
}
