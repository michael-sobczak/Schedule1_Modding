public class ListingEntry : MonoBehaviour // TypeDefIndex: 2828
{
	// Fields
	[CompilerGenerated]
	private ShopListing <MatchingListing>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SelectedQuantity>k__BackingField; // 0x28
	[Header("References")]
	public Image Icon; // 0x30
	public Text ItemNameLabel; // 0x38
	public Text ItemPriceLabel; // 0x40
	public InputField QuantityInput; // 0x48
	public Button IncrementButton; // 0x50
	public Button DecrementButton; // 0x58
	public RectTransform LockedContainer; // 0x60
	public UnityEvent onQuantityChanged; // 0x68

	// Properties
	public ShopListing MatchingListing { get; set; }
	public int SelectedQuantity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ShopListing get_MatchingListing() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_MatchingListing(ShopListing value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_SelectedQuantity() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_SelectedQuantity(int value) { }

	// RVA: 0x94AB00 Offset: 0x949500 VA: 0x18094AB00
	public void Initialize(ShopListing match) { }

	// RVA: 0x94AF20 Offset: 0x949920 VA: 0x18094AF20
	public void RefreshLocked() { }

	// RVA: 0x94AF90 Offset: 0x949990 VA: 0x18094AF90
	public void SetQuantity(int quant, bool notify = True) { }

	// RVA: 0x94AA60 Offset: 0x949460 VA: 0x18094AA60
	private void ChangeQuantity(int change) { }

	// RVA: 0x94AE20 Offset: 0x949820 VA: 0x18094AE20
	private void OnQuantityInputSubmitted(string value) { }

	// RVA: 0x94B180 Offset: 0x949B80 VA: 0x18094B180
	private void ValidateInput() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x94B040 Offset: 0x949A40 VA: 0x18094B040
	private void <Initialize>b__16_0(string value) { }

	[CompilerGenerated]
	// RVA: 0x94B160 Offset: 0x949B60 VA: 0x18094B160
	private void <Initialize>b__16_1() { }

	[CompilerGenerated]
	// RVA: 0x94B170 Offset: 0x949B70 VA: 0x18094B170
	private void <Initialize>b__16_2() { }
}
