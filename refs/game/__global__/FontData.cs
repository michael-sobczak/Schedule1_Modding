public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 16393
{
	// Fields
	[FormerlySerializedAs("font")]
	[SerializeField]
	private Font m_Font; // 0x10
	[FormerlySerializedAs("fontSize")]
	[SerializeField]
	private int m_FontSize; // 0x18
	[SerializeField]
	[FormerlySerializedAs("fontStyle")]
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField]
	private bool m_BestFit; // 0x20
	[SerializeField]
	private int m_MinSize; // 0x24
	[SerializeField]
	private int m_MaxSize; // 0x28
	[FormerlySerializedAs("alignment")]
	[SerializeField]
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; // 0x30
	[SerializeField]
	[FormerlySerializedAs("richText")]
	private bool m_RichText; // 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField]
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x2D99470 Offset: 0x2D97E70 VA: 0x182D99470
	public static FontData get_defaultFontData() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Font get_font() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_font(Font value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_fontSize() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_fontSize(int value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public FontStyle get_fontStyle() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_bestFit() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_bestFit(bool value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_minSize() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_minSize(int value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_maxSize() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_maxSize(int value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public TextAnchor get_alignment() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_alignByGeometry() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_richText() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	public void set_richText(bool value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_lineSpacing() { }

	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	public void set_lineSpacing(float value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2D99420 Offset: 0x2D97E20 VA: 0x182D99420 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
