public class ItemDefinition : ScriptableObject // TypeDefIndex: 3068
{
	// Fields
	public const int DEFAULT_STACK_LIMIT = 10;
	public string Name; // 0x18
	[TextArea(3, 10)]
	public string Description; // 0x20
	public string ID; // 0x28
	public Sprite Icon; // 0x30
	public EItemCategory Category; // 0x38
	public string[] Keywords; // 0x40
	public bool AvailableInDemo; // 0x48
	public bool UsableInFilters; // 0x49
	public Color LabelDisplayColor; // 0x4C
	public int StackLimit; // 0x5C
	public Equippable Equippable; // 0x60
	public ItemUI CustomItemUI; // 0x68
	public ItemInfoContent CustomInfoContent; // 0x70
	[Header("Legal Status")]
	public ELegalStatus legalStatus; // 0x78

	// Methods

	// RVA: 0x995F50 Offset: 0x994950 VA: 0x180995F50 Slot: 4
	public virtual ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x995FB0 Offset: 0x9949B0 VA: 0x180995FB0 Slot: 5
	public virtual void ValidateDefinition() { }

	// RVA: 0x996110 Offset: 0x994B10 VA: 0x180996110
	public void .ctor() { }
}
