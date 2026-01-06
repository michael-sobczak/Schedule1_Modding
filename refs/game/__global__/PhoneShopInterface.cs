public class PhoneShopInterface : MonoBehaviour // TypeDefIndex: 2794
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	public RectTransform EntryPrefab; // 0x28
	public Color ValidAmountColor; // 0x30
	public Color InvalidAmountColor; // 0x40
	[Header("References")]
	public GameObject Container; // 0x50
	public Text TitleLabel; // 0x58
	public Text SubtitleLabel; // 0x60
	public RectTransform EntryContainer; // 0x68
	public Text OrderTotalLabel; // 0x70
	public Text OrderLimitLabel; // 0x78
	public Text DebtLabel; // 0x80
	public Button ConfirmButton; // 0x88
	public GameObject ItemLimitContainer; // 0x90
	public Text ItemLimitLabel; // 0x98
	private List<RectTransform> _entries; // 0xA0
	private List<PhoneShopInterface.Listing> _items; // 0xA8
	private List<PhoneShopInterface.CartEntry> _cart; // 0xB0
	private float orderLimit; // 0xB8
	private Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback; // 0xC0
	private MSGConversation conversation; // 0xC8

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x9334D0 Offset: 0x931ED0 VA: 0x1809334D0
	private void Start() { }

	// RVA: 0x932B20 Offset: 0x931520 VA: 0x180932B20
	public void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback) { }

	// RVA: 0x9325D0 Offset: 0x930FD0 VA: 0x1809325D0
	public void Close() { }

	// RVA: 0x932950 Offset: 0x931350 VA: 0x180932950
	public void Exit(ExitAction action) { }

	// RVA: 0x932310 Offset: 0x930D10 VA: 0x180932310
	private void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change) { }

	// RVA: 0x932130 Offset: 0x930B30 VA: 0x180932130
	private void CartChanged() { }

	// RVA: 0x9328E0 Offset: 0x9312E0 VA: 0x1809328E0
	private void ConfirmOrderPressed() { }

	// RVA: 0x9320E0 Offset: 0x930AE0 VA: 0x1809320E0
	private bool CanConfirmOrder() { }

	// RVA: 0x933610 Offset: 0x932010 VA: 0x180933610
	private void UpdateOrderTotal() { }

	// RVA: 0x9329A0 Offset: 0x9313A0 VA: 0x1809329A0
	private float GetOrderTotal(out int itemCount) { }

	// RVA: 0x933790 Offset: 0x932190 VA: 0x180933790
	public void .ctor() { }
}
