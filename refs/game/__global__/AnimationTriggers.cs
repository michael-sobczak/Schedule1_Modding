public class AnimationTriggers // TypeDefIndex: 16369
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[SerializeField]
	[FormerlySerializedAs("normalTrigger")]
	private string m_NormalTrigger; // 0x10
	[SerializeField]
	[FormerlySerializedAs("highlightedTrigger")]
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_normalTrigger() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_normalTrigger(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_highlightedTrigger() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_pressedTrigger() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_pressedTrigger(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_selectedTrigger() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_selectedTrigger(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_disabledTrigger() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_disabledTrigger(string value) { }

	// RVA: 0x2D8D6D0 Offset: 0x2D8C0D0 VA: 0x182D8D6D0
	public void .ctor() { }
}
