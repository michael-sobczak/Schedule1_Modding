public sealed class GUISkin : ScriptableObject // TypeDefIndex: 17604
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x2D0DF30 Offset: 0x2D0C930 VA: 0x182D0DF30
	public void .ctor() { }

	// RVA: 0x2D0C460 Offset: 0x2D0AE60 VA: 0x182D0C460
	internal void OnEnable() { }

	// RVA: 0x2D0D9C0 Offset: 0x2D0C3C0 VA: 0x182D0D9C0
	internal static void CleanupRoots() { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public Font get_font() { }

	// RVA: 0x2D0E400 Offset: 0x2D0CE00 VA: 0x182D0E400
	public void set_font(Font value) { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public GUIStyle get_box() { }

	// RVA: 0x2D0E280 Offset: 0x2D0CC80 VA: 0x182D0E280
	public void set_box(GUIStyle value) { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public GUIStyle get_label() { }

	// RVA: 0x2D0E8C0 Offset: 0x2D0D2C0 VA: 0x182D0E8C0
	public void set_label(GUIStyle value) { }

	// RVA: 0x2D06A80 Offset: 0x2D05480 VA: 0x182D06A80
	public GUIStyle get_textField() { }

	// RVA: 0x2D0EAC0 Offset: 0x2D0D4C0 VA: 0x182D0EAC0
	public void set_textField(GUIStyle value) { }

	// RVA: 0x2D0E1F0 Offset: 0x2D0CBF0 VA: 0x182D0E1F0
	public GUIStyle get_textArea() { }

	// RVA: 0x2D0EA40 Offset: 0x2D0D440 VA: 0x182D0EA40
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x1E0E080 Offset: 0x1E0CA80 VA: 0x181E0E080
	public GUIStyle get_button() { }

	// RVA: 0x2D0E300 Offset: 0x2D0CD00 VA: 0x182D0E300
	public void set_button(GUIStyle value) { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	public GUIStyle get_toggle() { }

	// RVA: 0x2D0EB40 Offset: 0x2D0D540 VA: 0x182D0EB40
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x2D0E270 Offset: 0x2D0CC70 VA: 0x182D0E270
	public GUIStyle get_window() { }

	// RVA: 0x2D0EF40 Offset: 0x2D0D940 VA: 0x182D0EF40
	public void set_window(GUIStyle value) { }

	// RVA: 0x2D0E1A0 Offset: 0x2D0CBA0 VA: 0x182D0E1A0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x2D0E840 Offset: 0x2D0D240 VA: 0x182D0E840
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x2D0E190 Offset: 0x2D0CB90 VA: 0x182D0E190
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x2D0E7C0 Offset: 0x2D0D1C0 VA: 0x182D0E7C0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x2D0E180 Offset: 0x2D0CB80 VA: 0x182D0E180
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x2D0E740 Offset: 0x2D0D140 VA: 0x182D0E740
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x2D0E1E0 Offset: 0x2D0CBE0 VA: 0x182D0E1E0
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x2D0E9C0 Offset: 0x2D0D3C0 VA: 0x182D0E9C0
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x2D0E260 Offset: 0x2D0CC60 VA: 0x182D0E260
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x2D0EEC0 Offset: 0x2D0D8C0 VA: 0x182D0EEC0
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x2D0E250 Offset: 0x2D0CC50 VA: 0x182D0E250
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x2D0EE40 Offset: 0x2D0D840 VA: 0x182D0EE40
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x2D0E240 Offset: 0x2D0CC40 VA: 0x182D0E240
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x2D0EDC0 Offset: 0x2D0D7C0 VA: 0x182D0EDC0
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x2D0E170 Offset: 0x2D0CB70 VA: 0x182D0E170
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x2D0E6C0 Offset: 0x2D0D0C0 VA: 0x182D0E6C0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x2D0E160 Offset: 0x2D0CB60 VA: 0x182D0E160
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x2D0E640 Offset: 0x2D0D040 VA: 0x182D0E640
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x2D0E140 Offset: 0x2D0CB40 VA: 0x182D0E140
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x2D0E540 Offset: 0x2D0CF40 VA: 0x182D0E540
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x2D0E150 Offset: 0x2D0CB50 VA: 0x182D0E150
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x2D0E5C0 Offset: 0x2D0CFC0 VA: 0x182D0E5C0
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x2D0E230 Offset: 0x2D0CC30 VA: 0x182D0E230
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x2D0ED40 Offset: 0x2D0D740 VA: 0x182D0ED40
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x2D0E210 Offset: 0x2D0CC10 VA: 0x182D0E210
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x2D0EC40 Offset: 0x2D0D640 VA: 0x182D0EC40
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x2D0E220 Offset: 0x2D0CC20 VA: 0x182D0E220
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x2D0ECC0 Offset: 0x2D0D6C0 VA: 0x182D0ECC0
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x2D0E200 Offset: 0x2D0CC00 VA: 0x182D0E200
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x2D0EBC0 Offset: 0x2D0D5C0 VA: 0x182D0EBC0
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x2D0E1C0 Offset: 0x2D0CBC0 VA: 0x182D0E1C0
	public GUIStyle get_scrollView() { }

	// RVA: 0x2D0E940 Offset: 0x2D0D340 VA: 0x182D0E940
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x2D0E010 Offset: 0x2D0CA10 VA: 0x182D0E010
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x2D0E380 Offset: 0x2D0CD80 VA: 0x182D0E380
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x2D0E1D0 Offset: 0x2D0CBD0 VA: 0x182D0E1D0
	public GUISettings get_settings() { }

	// RVA: 0x2D0E020 Offset: 0x2D0CA20 VA: 0x182D0E020
	internal static GUIStyle get_error() { }

	// RVA: 0x2D0C460 Offset: 0x2D0AE60 VA: 0x182D0C460
	internal void Apply() { }

	// RVA: 0x2D0C4D0 Offset: 0x2D0AED0 VA: 0x182D0C4D0
	private void BuildStyleCache() { }

	// RVA: 0x2D0DB90 Offset: 0x2D0C590 VA: 0x182D0DB90
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x2D0DA40 Offset: 0x2D0C440 VA: 0x182D0DA40
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x2D0DE60 Offset: 0x2D0C860 VA: 0x182D0DE60
	internal void MakeCurrent() { }

	// RVA: 0x2D0DAD0 Offset: 0x2D0C4D0 VA: 0x182D0DAD0
	public IEnumerator GetEnumerator() { }
}
