public class StorableItemDefinition : ItemDefinition // TypeDefIndex: 3090
{
	// Fields
	[Header("Purchasing")]
	public float BasePurchasePrice; // 0x80
	public List<ShopListing.CategoryInstance> ShopCategories; // 0x88
	[Header("Unlocking")]
	public bool RequiresLevelToPurchase; // 0x90
	public FullRank RequiredRank; // 0x94
	[Header("Reselling")]
	[Range(0, 1)]
	public float ResellMultiplier; // 0x9C
	[Header("Storable Item")]
	public StoredItem StoredItem; // 0xA0
	[Range(0.1, 5)]
	public float PickpocketDifficultyMultiplier; // 0xA8
	[Tooltip("Optional station item if this item can be used at a station.")]
	public StationItem StationItem; // 0xB0
	[Header("Other Settings")]
	[FormerlySerializedAs("CombatUtilityForNPCs")]
	[Range(0, 1)]
	public float CombatUtility; // 0xB8

	// Properties
	public bool IsUnlocked { get; }

	// Methods

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0
	public bool get_IsUnlocked() { }

	// RVA: 0x9A6300 Offset: 0x9A4D00 VA: 0x1809A6300 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x9A6370 Offset: 0x9A4D70 VA: 0x1809A6370 Slot: 6
	protected virtual bool GetIsUnlocked() { }

	// RVA: 0x9A6420 Offset: 0x9A4E20 VA: 0x1809A6420
	public void .ctor() { }
}
