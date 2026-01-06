public class CartEntry : MonoBehaviour // TypeDefIndex: 2995
{
	// Fields
	[Header("References")]
	public TextMeshProUGUI NameLabel; // 0x20
	public TextMeshProUGUI PriceLabel; // 0x28
	public Button IncrementButton; // 0x30
	public Button DecrementButton; // 0x38
	public Button RemoveButton; // 0x40
	[CompilerGenerated]
	private int <Quantity>k__BackingField; // 0x48
	[CompilerGenerated]
	private Cart <Cart>k__BackingField; // 0x50
	[CompilerGenerated]
	private ShopListing <Listing>k__BackingField; // 0x58

	// Properties
	public int Quantity { get; set; }
	public Cart Cart { get; set; }
	public ShopListing Listing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Quantity() { }

	[CompilerGenerated]
	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	protected void set_Quantity(int value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Cart get_Cart() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_Cart(Cart value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public ShopListing get_Listing() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_Listing(ShopListing value) { }

	// RVA: 0x9743C0 Offset: 0x972DC0 VA: 0x1809743C0
	public void Initialize(Cart cart, ShopListing listing, int quantity) { }

	// RVA: 0x974570 Offset: 0x972F70 VA: 0x180974570
	public void SetQuantity(int quantity) { }

	// RVA: 0x9746B0 Offset: 0x9730B0 VA: 0x1809746B0 Slot: 4
	protected virtual void UpdateTitle() { }

	// RVA: 0x974630 Offset: 0x973030 VA: 0x180974630
	private void UpdatePrice() { }

	// RVA: 0x974110 Offset: 0x972B10 VA: 0x180974110
	private void ChangeAmount(int change) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x9745A0 Offset: 0x972FA0 VA: 0x1809745A0
	private void <Initialize>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0x9745D0 Offset: 0x972FD0 VA: 0x1809745D0
	private void <Initialize>b__17_1() { }

	[CompilerGenerated]
	// RVA: 0x974600 Offset: 0x973000 VA: 0x180974600
	private void <Initialize>b__17_2() { }
}
