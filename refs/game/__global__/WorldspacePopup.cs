public class WorldspacePopup : MonoBehaviour // TypeDefIndex: 2730
{
	// Fields
	public static List<WorldspacePopup> ActivePopups; // 0x0
	[Range(0, 1)]
	public float CurrentFillLevel; // 0x20
	[Header("Settings")]
	public WorldspacePopupUI UIPrefab; // 0x28
	public bool DisplayOnHUD; // 0x30
	public bool ScaleWithDistance; // 0x31
	public Vector3 WorldspaceOffset; // 0x34
	public float Range; // 0x40
	public float SizeMultiplier; // 0x44
	[HideInInspector]
	public WorldspacePopupUI WorldspaceUI; // 0x48
	[HideInInspector]
	public RectTransform HUDUI; // 0x50
	[HideInInspector]
	public WorldspacePopupUI HUDUIIcon; // 0x58
	[HideInInspector]
	public CanvasGroup HUDUICanvasGroup; // 0x60
	private List<WorldspacePopupUI> UIs; // 0x68
	private Coroutine popupCoroutine; // 0x70

	// Methods

	// RVA: 0x923C80 Offset: 0x922680 VA: 0x180923C80
	private void OnEnable() { }

	// RVA: 0x923BD0 Offset: 0x9225D0 VA: 0x180923BD0
	private void OnDisable() { }

	// RVA: 0x9238B0 Offset: 0x9222B0 VA: 0x1809238B0
	public WorldspacePopupUI CreateUI(RectTransform parent) { }

	// RVA: 0x923AB0 Offset: 0x9224B0 VA: 0x180923AB0
	private void LateUpdate() { }

	// RVA: 0x923D80 Offset: 0x922780 VA: 0x180923D80
	public void Popup() { }

	// RVA: 0x923F20 Offset: 0x922920 VA: 0x180923F20
	public void .ctor() { }

	// RVA: 0x923E90 Offset: 0x922890 VA: 0x180923E90
	private static void .cctor() { }

	[IteratorStateMachine(typeof(WorldspacePopup.<<Popup>g__PopupCoroutine|18_0>d))]
	[CompilerGenerated]
	// RVA: 0x923E20 Offset: 0x922820 VA: 0x180923E20
	private IEnumerator <Popup>g__PopupCoroutine|18_0() { }
}
