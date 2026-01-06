public class InputPrompt : MonoBehaviour // TypeDefIndex: 2952
{
	// Fields
	public static float Spacing; // 0x0
	[Header("Settings")]
	public List<InputActionReference> Actions; // 0x20
	public string Label; // 0x28
	public InputPrompt.EInputPromptAlignment Alignment; // 0x30
	[Header("References")]
	public RectTransform Container; // 0x38
	public RectTransform ImagesContainer; // 0x40
	public TextMeshProUGUI LabelComponent; // 0x48
	public RectTransform Shade; // 0x50
	[Header("Settings")]
	public bool OverridePromptImageColor; // 0x58
	public Color PromptImageColor; // 0x5C
	[SerializeField]
	private List<PromptImage> promptImages; // 0x70
	private List<InputActionReference> displayedActions; // 0x78
	private InputPrompt.EInputPromptAlignment AppliedAlignment; // 0x80

	// Properties
	private InputPromptsManager manager { get; }

	// Methods

	// RVA: 0x95F5D0 Offset: 0x95DFD0 VA: 0x18095F5D0
	private InputPromptsManager get_manager() { }

	// RVA: 0x95E9B0 Offset: 0x95D3B0 VA: 0x18095E9B0
	private void OnEnable() { }

	// RVA: 0x85A6B0 Offset: 0x8590B0 VA: 0x18085A6B0
	private void OnDisable() { }

	// RVA: 0x95F450 Offset: 0x95DE50 VA: 0x18095F450
	private void Update() { }

	// RVA: 0x95E9F0 Offset: 0x95D3F0 VA: 0x18095E9F0
	private void RefreshPromptImages() { }

	// RVA: 0x95F310 Offset: 0x95DD10 VA: 0x18095F310
	public void SetLabel(string label) { }

	// RVA: 0x95F360 Offset: 0x95DD60 VA: 0x18095F360
	private void UpdateShade() { }

	// RVA: 0x95F4D0 Offset: 0x95DED0 VA: 0x18095F4D0
	public void .ctor() { }

	// RVA: 0x95F490 Offset: 0x95DE90 VA: 0x18095F490
	private static void .cctor() { }
}
