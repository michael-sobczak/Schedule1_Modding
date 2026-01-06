public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 16481
{
	// Fields
	[SerializeField]
	private FontData m_FontData; // 0xE0
	[SerializeField]
	[TextArea(3, 10)]
	protected string m_Text; // 0xE8
	private TextGenerator m_TextCache; // 0xF0
	private TextGenerator m_TextCacheForLayout; // 0xF8
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0x100
	private readonly UIVertex[] m_TempVerts; // 0x108

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x2F3FEE0 Offset: 0x2F3E8E0 VA: 0x182F3FEE0
	protected void .ctor() { }

	// RVA: 0x2F40050 Offset: 0x2F3EA50 VA: 0x182F40050
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x2F3FFD0 Offset: 0x2F3E9D0 VA: 0x182F3FFD0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2F401A0 Offset: 0x2F3EBA0 VA: 0x182F401A0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2F3F150 Offset: 0x2F3DB50 VA: 0x182F3F150
	public void FontTextureChanged() { }

	// RVA: 0x2F40140 Offset: 0x2F3EB40 VA: 0x182F40140
	public Font get_font() { }

	// RVA: 0x2F40940 Offset: 0x2F3F340 VA: 0x182F40940
	public void set_font(Font value) { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x2F40CB0 Offset: 0x2F3F6B0 VA: 0x182F40CB0 Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x2F407A0 Offset: 0x2F3F1A0 VA: 0x182F407A0
	public bool get_supportRichText() { }

	// RVA: 0x2F40C50 Offset: 0x2F3F650 VA: 0x182F40C50
	public void set_supportRichText(bool value) { }

	// RVA: 0x2F40740 Offset: 0x2F3F140 VA: 0x182F40740
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2F40B30 Offset: 0x2F3F530 VA: 0x182F40B30
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x2F40780 Offset: 0x2F3F180 VA: 0x182F40780
	public int get_resizeTextMinSize() { }

	// RVA: 0x2F40BF0 Offset: 0x2F3F5F0 VA: 0x182F40BF0
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x2F40760 Offset: 0x2F3F160 VA: 0x182F40760
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2F40B90 Offset: 0x2F3F590 VA: 0x182F40B90
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2F3FFB0 Offset: 0x2F3E9B0 VA: 0x182F3FFB0
	public TextAnchor get_alignment() { }

	// RVA: 0x2F40820 Offset: 0x2F3F220 VA: 0x182F40820
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2F3FF90 Offset: 0x2F3E990 VA: 0x182F3FF90
	public bool get_alignByGeometry() { }

	// RVA: 0x2F407E0 Offset: 0x2F3F1E0 VA: 0x182F407E0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x2F40100 Offset: 0x2F3EB00 VA: 0x182F40100
	public int get_fontSize() { }

	// RVA: 0x2F40880 Offset: 0x2F3F280 VA: 0x182F40880
	public void set_fontSize(int value) { }

	// RVA: 0x2F40160 Offset: 0x2F3EB60 VA: 0x182F40160
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2F40A60 Offset: 0x2F3F460 VA: 0x182F40A60
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2F407C0 Offset: 0x2F3F1C0 VA: 0x182F407C0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x2F40DA0 Offset: 0x2F3F7A0 VA: 0x182F40DA0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2F40180 Offset: 0x2F3EB80 VA: 0x182F40180
	public float get_lineSpacing() { }

	// RVA: 0x2F40AC0 Offset: 0x2F3F4C0 VA: 0x182F40AC0
	public void set_lineSpacing(float value) { }

	// RVA: 0x2F40120 Offset: 0x2F3EB20 VA: 0x182F40120
	public FontStyle get_fontStyle() { }

	// RVA: 0x2F408E0 Offset: 0x2F3F2E0 VA: 0x182F408E0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2F403A0 Offset: 0x2F3EDA0 VA: 0x182F403A0
	public float get_pixelsPerUnit() { }

	// RVA: 0x2F3F690 Offset: 0x2F3E090 VA: 0x182F3F690 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F3F630 Offset: 0x2F3E030 VA: 0x182F3F630 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F3FE60 Offset: 0x2F3E860 VA: 0x182F3FE60 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2F3F0F0 Offset: 0x2F3DAF0 VA: 0x182F3F0F0
	internal void AssignDefaultFont() { }

	// RVA: 0x2F3F040 Offset: 0x2F3DA40 VA: 0x182F3F040
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x2F3F270 Offset: 0x2F3DC70 VA: 0x182F3F270
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x2F3F4C0 Offset: 0x2F3DEC0 VA: 0x182F3F4C0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2F3F710 Offset: 0x2F3E110 VA: 0x182F3F710 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x2F40620 Offset: 0x2F3F020 VA: 0x182F40620 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x2F40510 Offset: 0x2F3EF10 VA: 0x182F40510 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 84
	public virtual int get_layoutPriority() { }
}
