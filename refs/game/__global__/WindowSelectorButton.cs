public class WindowSelectorButton : MonoBehaviour // TypeDefIndex: 2848
{
	// Fields
	public const float SELECTION_INDICATOR_SCALE = 1.1;
	public const float INDICATOR_LERP_TIME = 0.075;
	public UnityEvent OnSelected; // 0x20
	public EDealWindow WindowType; // 0x28
	[Header("References")]
	public Button Button; // 0x30
	public GameObject InactiveOverlay; // 0x38
	public RectTransform HoverIndicator; // 0x40
	private Coroutine hoverRoutine; // 0x48

	// Methods

	// RVA: 0x957A90 Offset: 0x956490 VA: 0x180957A90
	private void Awake() { }

	// RVA: 0x957D70 Offset: 0x956770 VA: 0x180957D70
	public void SetInteractable(bool interactable) { }

	// RVA: 0x957BE0 Offset: 0x9565E0 VA: 0x180957BE0
	public void HoverStart() { }

	// RVA: 0x957BB0 Offset: 0x9565B0 VA: 0x180957BB0
	public void HoverEnd() { }

	// RVA: 0x5A5EB0 Offset: 0x5A48B0 VA: 0x1805A5EB0
	public void Clicked() { }

	// RVA: 0x957C10 Offset: 0x956610 VA: 0x180957C10
	public void SetHoverIndicator(bool shown) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
