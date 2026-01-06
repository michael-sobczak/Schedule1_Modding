public class InteractionCanvas : Singleton<InteractionCanvas> // TypeDefIndex: 2627
{
	// Fields
	public const float DISPLAY_SIZE_MULTIPLIER = 0.75;
	[CompilerGenerated]
	private float <displayScale>k__BackingField; // 0x28
	[Header("Settings")]
	public Color DefaultMessageColor; // 0x2C
	public Color DefaultIconColor; // 0x3C
	public Color DefaultKeyColor; // 0x4C
	public Color InvalidMessageColor; // 0x5C
	public Color InvalidIconColor; // 0x6C
	public Sprite KeyIcon; // 0x80
	public Sprite LeftMouseIcon; // 0x88
	public Sprite CrossIcon; // 0x90
	[Header("References")]
	public Canvas Canvas; // 0x98
	public RectTransform Container; // 0xA0
	public Image Icon; // 0xA8
	public Text IconText; // 0xB0
	public Text MessageText; // 0xB8
	public RectTransform WSLabelContainer; // 0xC0
	public RectTransform BackgroundImage; // 0xC8
	[Header("Prefabs")]
	public GameObject WSLabelPrefab; // 0xD0
	private bool _interactionDisplayEnabledThisFrame; // 0xD8
	private Coroutine _displayScaleLerpRoutine; // 0xE0
	[HideInInspector]
	public List<WorldSpaceLabel> ActiveWSlabels; // 0xE8

	// Properties
	public float displayScale { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_displayScale() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void set_displayScale(float value) { }

	// RVA: 0x8E9C00 Offset: 0x8E8600 VA: 0x1808E9C00 Slot: 7
	protected virtual void LateUpdate() { }

	// RVA: 0x8E9700 Offset: 0x8E8100 VA: 0x1808E9700
	public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor) { }

	// RVA: 0x8E9DB0 Offset: 0x8E87B0 VA: 0x1808E9DB0
	public void LerpDisplayScale(float endScale) { }

	// RVA: 0x8E9F10 Offset: 0x8E8910 VA: 0x1808E9F10
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(InteractionCanvas.<<LerpDisplayScale>g__ILerpDisplayScale|26_0>d))]
	// RVA: 0x8E9E80 Offset: 0x8E8880 VA: 0x1808E9E80
	private IEnumerator <LerpDisplayScale>g__ILerpDisplayScale|26_0(float startScale, float endScale) { }
}
