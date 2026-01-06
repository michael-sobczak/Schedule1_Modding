public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 16376
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("normalColor")]
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; // 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	public Color get_normalColor() { }

	// RVA: 0x4944D0 Offset: 0x492ED0 VA: 0x1804944D0
	public void set_normalColor(Color value) { }

	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Color get_highlightedColor() { }

	// RVA: 0x49CD50 Offset: 0x49B750 VA: 0x18049CD50
	public void set_highlightedColor(Color value) { }

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Color get_pressedColor() { }

	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	public void set_pressedColor(Color value) { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public Color get_selectedColor() { }

	// RVA: 0x6FC3B0 Offset: 0x6FADB0 VA: 0x1806FC3B0
	public void set_selectedColor(Color value) { }

	// RVA: 0xAB8F60 Offset: 0xAB7960 VA: 0x180AB8F60
	public Color get_disabledColor() { }

	// RVA: 0xAB8F70 Offset: 0xAB7970 VA: 0x180AB8F70
	public void set_disabledColor(Color value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_colorMultiplier() { }

	// RVA: 0x6FF440 Offset: 0x6FDE40 VA: 0x1806FF440
	public void set_colorMultiplier(float value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_fadeDuration() { }

	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	public void set_fadeDuration(float value) { }

	// RVA: 0x2D8FFF0 Offset: 0x2D8E9F0 VA: 0x182D8FFF0
	private static void .cctor() { }

	// RVA: 0x2D8FB70 Offset: 0x2D8E570 VA: 0x182D8FB70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D8FC60 Offset: 0x2D8E660 VA: 0x182D8FC60 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x2D90320 Offset: 0x2D8ED20 VA: 0x182D90320
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x2D903C0 Offset: 0x2D8EDC0 VA: 0x182D903C0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x2D8FF60 Offset: 0x2D8E960 VA: 0x182D8FF60 Slot: 2
	public override int GetHashCode() { }
}
