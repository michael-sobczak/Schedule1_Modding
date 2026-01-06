public class GraffitiMenu : Singleton<GraffitiMenu> // TypeDefIndex: 2614
{
	// Fields
	[Header("References")]
	public Canvas Canvas; // 0x28
	public RectTransform ColorButtonContainer; // 0x30
	public Button ClearButton; // 0x38
	public Transform ConfirmPanel; // 0x40
	public Button ConfirmButton; // 0x48
	public Button CancelButton; // 0x50
	public RectTransform RemainigPaintContainer; // 0x58
	public Slider RemainingPaintSlider; // 0x60
	public Image[] RemainingPaintImages; // 0x68
	public TextMeshProUGUI RemainingPaintLabel; // 0x70
	[Header("Prefabs")]
	public GameObject ColorButtonPrefab; // 0x78
	public Action<ESprayColor> onColorSelected; // 0x80
	public Action onClearClicked; // 0x88
	public Action onConfirmClicked; // 0x90
	private List<Button> colorButtons; // 0x98
	private SpraySurface activeSurface; // 0xA0

	// Methods

	// RVA: 0x8E6ED0 Offset: 0x8E58D0 VA: 0x1808E6ED0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8E7340 Offset: 0x8E5D40 VA: 0x1808E7340
	public void Open() { }

	// RVA: 0x8E4C30 Offset: 0x8E3630 VA: 0x1808E4C30
	public void Close() { }

	// RVA: 0x8E7580 Offset: 0x8E5F80 VA: 0x1808E7580
	public void ShowConfirmPanel() { }

	// RVA: 0x8E73A0 Offset: 0x8E5DA0 VA: 0x1808E73A0
	private void SelectColor(ESprayColor color) { }

	// RVA: 0x8E75B0 Offset: 0x8E5FB0 VA: 0x1808E75B0
	public void UpdateRemainingPaintIndicator(float remainingPaint) { }

	// RVA: 0x8E72E0 Offset: 0x8E5CE0 VA: 0x1808E72E0
	private void ClearClicked() { }

	// RVA: 0x8E7310 Offset: 0x8E5D10 VA: 0x1808E7310
	private void ConfirmClicked() { }

	// RVA: 0x8E72B0 Offset: 0x8E5CB0 VA: 0x1808E72B0
	private void CancelClicked() { }

	// RVA: 0x8E7920 Offset: 0x8E6320 VA: 0x1808E7920
	public void .ctor() { }
}
