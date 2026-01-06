public class ClothingShopInterface : ShopInterface // TypeDefIndex: 2998
{
	// Fields
	public ShopColorPicker ColorPicker; // 0x118
	private ShopListing _selectedListing; // 0x120

	// Methods

	// RVA: 0x97B800 Offset: 0x97A200 VA: 0x18097B800 Slot: 28
	protected override void Start() { }

	// RVA: 0x97B5C0 Offset: 0x979FC0 VA: 0x18097B5C0 Slot: 33
	public override void ListingClicked(ListingUI listingUI) { }

	// RVA: 0x97AE70 Offset: 0x979870 VA: 0x18097AE70 Slot: 32
	protected override void Exit(ExitAction action) { }

	// RVA: 0x97AD10 Offset: 0x979710 VA: 0x18097AD10
	private void ColorPicked(EClothingColor color) { }

	// RVA: 0x97AF90 Offset: 0x979990 VA: 0x18097AF90 Slot: 34
	public override bool HandoverItems() { }

	// RVA: 0x97B8C0 Offset: 0x97A2C0 VA: 0x18097B8C0
	public void .ctor() { }
}
