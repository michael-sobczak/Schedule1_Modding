public class ShopColorPicker : MonoBehaviour // TypeDefIndex: 3004
{
	// Fields
	public Image AssetIconImage; // 0x20
	public TextMeshProUGUI ColorLabel; // 0x28
	public RectTransform ColorButtonParent; // 0x30
	public GameObject ColorButtonPrefab; // 0x38
	public UnityEvent<EClothingColor> onColorPicked; // 0x40

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x9828D0 Offset: 0x9812D0 VA: 0x1809828D0
	public bool get_IsOpen() { }

	// RVA: 0x982230 Offset: 0x980C30 VA: 0x180982230
	public void Start() { }

	// RVA: 0x982160 Offset: 0x980B60 VA: 0x180982160
	private void ColorPicked(EClothingColor color) { }

	// RVA: 0x9821D0 Offset: 0x980BD0 VA: 0x1809821D0
	public void Open(ItemDefinition item) { }

	// RVA: 0x6FE090 Offset: 0x6FCA90 VA: 0x1806FE090
	public void Close() { }

	// RVA: 0x9820D0 Offset: 0x980AD0 VA: 0x1809820D0
	private void ColorHovered(EClothingColor color) { }

	// RVA: 0x982850 Offset: 0x981250 VA: 0x180982850
	public void .ctor() { }
}
