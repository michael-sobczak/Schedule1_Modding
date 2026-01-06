public class MouseTooltip : Singleton<MouseTooltip> // TypeDefIndex: 2639
{
	// Fields
	[Header("References")]
	public RectTransform IconRect; // 0x28
	public Image IconImg; // 0x30
	public RectTransform TooltipRect; // 0x38
	public TextMeshProUGUI TooltipLabel; // 0x40
	[Header("Settings")]
	public Vector3 TooltipOffset_NoIcon; // 0x48
	public Vector3 TooltipOffset_WithIcon; // 0x54
	public Vector3 IconOffset; // 0x60
	[Header("Colors")]
	public Color Color_Invalid; // 0x6C
	[Header("Sprites")]
	public Sprite Sprite_Cross; // 0x80
	private bool tooltipShownThisFrame; // 0x88
	private bool iconShownThisFrame; // 0x89

	// Methods

	// RVA: 0x8F70F0 Offset: 0x8F5AF0 VA: 0x1808F70F0
	public void ShowTooltip(string text, Color col) { }

	// RVA: 0x8F7080 Offset: 0x8F5A80 VA: 0x1808F7080
	public void ShowIcon(Sprite sprite, Color col) { }

	// RVA: 0x8F6EE0 Offset: 0x8F58E0 VA: 0x1808F6EE0
	private void LateUpdate() { }

	// RVA: 0x8F7160 Offset: 0x8F5B60 VA: 0x1808F7160
	public void .ctor() { }
}
