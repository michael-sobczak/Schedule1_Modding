public class TooltipManager : Singleton<TooltipManager> // TypeDefIndex: 2735
{
	// Fields
	[Header("References")]
	public Canvas Canvas; // 0x28
	[SerializeField]
	private RectTransform anchor; // 0x30
	[SerializeField]
	private TextMeshProUGUI tooltipLabel; // 0x38
	[Header("Canvas")]
	public List<Canvas> canvases; // 0x40
	private List<Canvas> sortedCanvases; // 0x48
	private List<GraphicRaycaster> raycasters; // 0x50
	private EventSystem eventSystem; // 0x58
	private bool tooltipShownThisFrame; // 0x60
	private PointerEventData pointerEventData; // 0x68
	private List<RaycastResult> rayResults; // 0x70

	// Methods

	// RVA: 0x91B320 Offset: 0x919D20 VA: 0x18091B320 Slot: 5
	protected override void Awake() { }

	// RVA: 0x91C0D0 Offset: 0x91AAD0 VA: 0x18091C0D0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x91BAD0 Offset: 0x91A4D0 VA: 0x18091BAD0 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x91AE70 Offset: 0x919870 VA: 0x18091AE70
	public void AddCanvas(Canvas canvas) { }

	// RVA: 0x91B7B0 Offset: 0x91A1B0 VA: 0x18091B7B0
	private void CheckForTooltipHover() { }

	// RVA: 0x91BB20 Offset: 0x91A520 VA: 0x18091BB20
	public void ShowTooltip(string text, Vector2 position, bool worldspace) { }

	// RVA: 0x91C0E0 Offset: 0x91AAE0 VA: 0x18091C0E0
	public void .ctor() { }
}
