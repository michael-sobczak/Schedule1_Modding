public class ItemInfoContent : MonoBehaviour // TypeDefIndex: 3031
{
	// Fields
	[Header("Settings")]
	public float Height; // 0x20
	[Header("References")]
	public TextMeshProUGUI NameLabel; // 0x28
	public TextMeshProUGUI DescriptionLabel; // 0x30

	// Methods

	// RVA: 0x996C90 Offset: 0x995690 VA: 0x180996C90 Slot: 4
	public virtual void Initialize(ItemInstance instance) { }

	// RVA: 0x996D40 Offset: 0x995740 VA: 0x180996D40 Slot: 5
	public virtual void Initialize(ItemDefinition definition) { }

	// RVA: 0x996DB0 Offset: 0x9957B0 VA: 0x180996DB0
	public void .ctor() { }
}
