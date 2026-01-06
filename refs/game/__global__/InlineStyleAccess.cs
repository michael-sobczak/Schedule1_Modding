internal class InlineStyleAccess : StyleValueCollection, IStyle // TypeDefIndex: 6780
{
	// Fields
	private static StylePropertyReader s_StylePropertyReader; // 0x0
	private List<StyleValueManaged> m_ValuesManaged; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <ve>k__BackingField; // 0x20
	private bool m_HasInlineCursor; // 0x28
	private StyleCursor m_InlineCursor; // 0x30
	private bool m_HasInlineTextShadow; // 0x50
	private StyleTextShadow m_InlineTextShadow; // 0x54
	private bool m_HasInlineTransformOrigin; // 0x74
	private StyleTransformOrigin m_InlineTransformOrigin; // 0x78
	private bool m_HasInlineTranslate; // 0x90
	private StyleTranslate m_InlineTranslateOperation; // 0x94
	private bool m_HasInlineRotate; // 0xB0
	private StyleRotate m_InlineRotateOperation; // 0xB4
	private bool m_HasInlineScale; // 0xD0
	private StyleScale m_InlineScale; // 0xD4
	private bool m_HasInlineBackgroundSize; // 0xE8
	public StyleBackgroundSize m_InlineBackgroundSize; // 0xEC
	private InlineStyleAccess.InlineRule m_InlineRule; // 0x108

	// Properties
	private StyleColor UnityEngine.UIElements.IStyle.backgroundColor { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderBottomColor { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderLeftColor { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderRightColor { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderTopColor { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth { set; }
	private StyleLength UnityEngine.UIElements.IStyle.bottom { set; }
	private StyleColor UnityEngine.UIElements.IStyle.color { set; }
	private StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display { get; set; }
	private StyleLength UnityEngine.UIElements.IStyle.flexBasis { set; }
	private StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.flexGrow { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.flexShrink { set; }
	private StyleLength UnityEngine.UIElements.IStyle.fontSize { set; }
	private StyleLength UnityEngine.UIElements.IStyle.height { set; }
	private StyleLength UnityEngine.UIElements.IStyle.left { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginBottom { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginLeft { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginRight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginTop { set; }
	private StyleLength UnityEngine.UIElements.IStyle.maxHeight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.maxWidth { set; }
	private StyleLength UnityEngine.UIElements.IStyle.minWidth { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.opacity { set; }
	private StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingBottom { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingLeft { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingRight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingTop { get; set; }
	private StyleEnum<Position> UnityEngine.UIElements.IStyle.position { set; }
	private StyleLength UnityEngine.UIElements.IStyle.right { set; }
	private StyleLength UnityEngine.UIElements.IStyle.top { set; }
	private StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor { set; }
	private StyleFont UnityEngine.UIElements.IStyle.unityFont { set; }
	private StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition { set; }
	private StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility { set; }
	private StyleLength UnityEngine.UIElements.IStyle.width { get; set; }
	private VisualElement ve { get; set; }
	private StyleCursor UnityEngine.UIElements.IStyle.cursor { get; }
	private StyleTextShadow UnityEngine.UIElements.IStyle.textShadow { get; }
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize { get; }
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin { get; }
	private StyleTranslate UnityEngine.UIElements.IStyle.translate { get; set; }
	private StyleRotate UnityEngine.UIElements.IStyle.rotate { get; }
	private StyleScale UnityEngine.UIElements.IStyle.scale { get; }

	// Methods

	// RVA: 0x2EDAC30 Offset: 0x2ED9630 VA: 0x182EDAC30 Slot: 4
	private void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	// RVA: 0x2EDAC90 Offset: 0x2ED9690 VA: 0x182EDAC90 Slot: 6
	private void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	// RVA: 0x2EDACF0 Offset: 0x2ED96F0 VA: 0x182EDACF0 Slot: 7
	private void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: 0x2EDAD50 Offset: 0x2ED9750 VA: 0x182EDAD50 Slot: 8
	private void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	// RVA: 0x2EDADB0 Offset: 0x2ED97B0 VA: 0x182EDADB0 Slot: 9
	private void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	// RVA: 0x2EDAE30 Offset: 0x2ED9830 VA: 0x182EDAE30 Slot: 10
	private void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	// RVA: 0x2EDAE90 Offset: 0x2ED9890 VA: 0x182EDAE90 Slot: 11
	private void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	// RVA: 0x2EDAF10 Offset: 0x2ED9910 VA: 0x182EDAF10 Slot: 12
	private void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	// RVA: 0x2EDAF70 Offset: 0x2ED9970 VA: 0x182EDAF70 Slot: 13
	private void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	// RVA: 0x2EDAFF0 Offset: 0x2ED99F0 VA: 0x182EDAFF0 Slot: 14
	private void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	// RVA: 0x2EDB050 Offset: 0x2ED9A50 VA: 0x182EDB050 Slot: 15
	private void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	// RVA: 0x2EDB0B0 Offset: 0x2ED9AB0 VA: 0x182EDB0B0 Slot: 16
	private void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	// RVA: 0x2EDB110 Offset: 0x2ED9B10 VA: 0x182EDB110 Slot: 17
	private void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	// RVA: 0x2EDB190 Offset: 0x2ED9B90 VA: 0x182EDB190 Slot: 18
	private void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	// RVA: 0x2EDB230 Offset: 0x2ED9C30 VA: 0x182EDB230 Slot: 19
	private void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	// RVA: 0x2EDA900 Offset: 0x2ED9300 VA: 0x182EDA900 Slot: 21
	private StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	// RVA: 0x2EDB290 Offset: 0x2ED9C90 VA: 0x182EDB290 Slot: 22
	private void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	// RVA: 0x2EDB340 Offset: 0x2ED9D40 VA: 0x182EDB340 Slot: 23
	private void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	// RVA: 0x2EDB3E0 Offset: 0x2ED9DE0 VA: 0x182EDB3E0 Slot: 24
	private void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	// RVA: 0x2EDB490 Offset: 0x2ED9E90 VA: 0x182EDB490 Slot: 25
	private void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	// RVA: 0x2EDB510 Offset: 0x2ED9F10 VA: 0x182EDB510 Slot: 26
	private void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	// RVA: 0x2EDB590 Offset: 0x2ED9F90 VA: 0x182EDB590 Slot: 27
	private void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	// RVA: 0x2EDB5F0 Offset: 0x2ED9FF0 VA: 0x182EDB5F0 Slot: 28
	private void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	// RVA: 0x2EDB690 Offset: 0x2EDA090 VA: 0x182EDB690 Slot: 29
	private void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	// RVA: 0x2EDB730 Offset: 0x2EDA130 VA: 0x182EDB730 Slot: 30
	private void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	// RVA: 0x2EDB7D0 Offset: 0x2EDA1D0 VA: 0x182EDB7D0 Slot: 31
	private void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	// RVA: 0x2EDB870 Offset: 0x2EDA270 VA: 0x182EDB870 Slot: 32
	private void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	// RVA: 0x2EDB910 Offset: 0x2EDA310 VA: 0x182EDB910 Slot: 33
	private void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	// RVA: 0x2EDB9B0 Offset: 0x2EDA3B0 VA: 0x182EDB9B0 Slot: 34
	private void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	// RVA: 0x2EDBA50 Offset: 0x2EDA450 VA: 0x182EDBA50 Slot: 35
	private void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	// RVA: 0x2EDBAF0 Offset: 0x2EDA4F0 VA: 0x182EDBAF0 Slot: 36
	private void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	// RVA: 0x2EDBB90 Offset: 0x2EDA590 VA: 0x182EDBB90 Slot: 37
	private void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	// RVA: 0x2EDBBE0 Offset: 0x2EDA5E0 VA: 0x182EDBBE0 Slot: 38
	private void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	// RVA: 0x2EDBCF0 Offset: 0x2EDA6F0 VA: 0x182EDBCF0 Slot: 39
	private void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	// RVA: 0x2EDBD90 Offset: 0x2EDA790 VA: 0x182EDBD90 Slot: 40
	private void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	// RVA: 0x2EDBE30 Offset: 0x2EDA830 VA: 0x182EDBE30 Slot: 41
	private void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	// RVA: 0x2EDA980 Offset: 0x2ED9380 VA: 0x182EDA980 Slot: 42
	private StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	// RVA: 0x2EDBED0 Offset: 0x2EDA8D0 VA: 0x182EDBED0 Slot: 43
	private void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	// RVA: 0x2EDBF70 Offset: 0x2EDA970 VA: 0x182EDBF70 Slot: 44
	private void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	// RVA: 0x2EDC020 Offset: 0x2EDAA20 VA: 0x182EDC020 Slot: 45
	private void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	// RVA: 0x2EDC0C0 Offset: 0x2EDAAC0 VA: 0x182EDC0C0 Slot: 49
	private void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	// RVA: 0x2EDC310 Offset: 0x2EDAD10 VA: 0x182EDC310 Slot: 53
	private void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: 0x2EDC3D0 Offset: 0x2EDADD0 VA: 0x182EDC3D0 Slot: 54
	private void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	// RVA: 0x2EDC370 Offset: 0x2EDAD70 VA: 0x182EDC370 Slot: 55
	private void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: 0x2EDC420 Offset: 0x2EDAE20 VA: 0x182EDC420 Slot: 56
	private void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	// RVA: 0x2EDABF0 Offset: 0x2ED95F0 VA: 0x182EDABF0 Slot: 57
	private StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	// RVA: 0x2EDC490 Offset: 0x2EDAE90 VA: 0x182EDC490 Slot: 58
	private void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	private VisualElement get_ve() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ve(VisualElement value) { }

	// RVA: 0x2EDC5B0 Offset: 0x2EDAFB0 VA: 0x182EDC5B0
	public void .ctor(VisualElement ve) { }

	// RVA: 0x2ED9590 Offset: 0x2ED7F90 VA: 0x182ED9590 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED9A50 Offset: 0x2ED8450 VA: 0x182ED9A50
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x2ED9660 Offset: 0x2ED8060 VA: 0x182ED9660
	public bool IsValueSet(StylePropertyId id) { }

	// RVA: 0x2ED82E0 Offset: 0x2ED6CE0 VA: 0x182ED82E0
	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	// RVA: 0x2EDA870 Offset: 0x2ED9270 VA: 0x182EDA870 Slot: 20
	private StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	// RVA: 0x2EDAAA0 Offset: 0x2ED94A0 VA: 0x182EDAAA0 Slot: 48
	private StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	// RVA: 0x2EDA800 Offset: 0x2ED9200 VA: 0x182EDA800 Slot: 5
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	// RVA: 0x2EDAB00 Offset: 0x2ED9500 VA: 0x182EDAB00 Slot: 50
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	// RVA: 0x2EDAB70 Offset: 0x2ED9570 VA: 0x182EDAB70 Slot: 51
	private StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	// RVA: 0x2EDC160 Offset: 0x2EDAB60 VA: 0x182EDC160 Slot: 52
	private void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	// RVA: 0x2EDA9C0 Offset: 0x2ED93C0 VA: 0x182EDA9C0 Slot: 46
	private StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	// RVA: 0x2EDAA40 Offset: 0x2ED9440 VA: 0x182EDAA40 Slot: 47
	private StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	// RVA: 0x2ED9CF0 Offset: 0x2ED86F0 VA: 0x182ED9CF0
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	// RVA: 0x2EDA580 Offset: 0x2ED8F80 VA: 0x182EDA580
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	// RVA: 0x2EDA190 Offset: 0x2ED8B90 VA: 0x182EDA190
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	// RVA: -1 Offset: -1
	private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECAF00 Offset: 0xEC9900 VA: 0x180ECAF00
	|-InlineStyleAccess.SetStyleValue<Int32Enum>
	|
	|-RVA: 0xECACF0 Offset: 0xEC96F0 VA: 0x180ECACF0
	|-InlineStyleAccess.SetStyleValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2ED9E50 Offset: 0x2ED8850 VA: 0x182ED9E50
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	// RVA: 0x2EDA350 Offset: 0x2ED8D50 VA: 0x182EDA350
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	// RVA: 0x2ED9B20 Offset: 0x2ED8520 VA: 0x182ED9B20
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	// RVA: 0x2ED9020 Offset: 0x2ED7A20 VA: 0x182ED9020
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	// RVA: 0x2ED9270 Offset: 0x2ED7C70 VA: 0x182ED9270
	private void ApplyStyleValue(StyleValue value) { }

	// RVA: 0x2ED9940 Offset: 0x2ED8340 VA: 0x182ED9940
	private bool RemoveInlineStyle(StylePropertyId id) { }

	// RVA: 0x2ED80B0 Offset: 0x2ED6AB0 VA: 0x182ED80B0
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	// RVA: 0x2EDA6F0 Offset: 0x2ED90F0 VA: 0x182EDA6F0
	public bool TryGetInlineCursor(ref StyleCursor value) { }

	// RVA: 0x2EDA790 Offset: 0x2ED9190 VA: 0x182EDA790
	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	// RVA: 0x2EDA7B0 Offset: 0x2ED91B0 VA: 0x182EDA7B0
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	// RVA: 0x2EDA7D0 Offset: 0x2ED91D0 VA: 0x182EDA7D0
	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	// RVA: 0x2EDA730 Offset: 0x2ED9130 VA: 0x182EDA730
	public bool TryGetInlineRotate(ref StyleRotate value) { }

	// RVA: 0x2EDA760 Offset: 0x2ED9160 VA: 0x182EDA760
	public bool TryGetInlineScale(ref StyleScale value) { }

	// RVA: 0x2EDA6C0 Offset: 0x2ED90C0 VA: 0x182EDA6C0
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	// RVA: 0x2EDC530 Offset: 0x2EDAF30 VA: 0x182EDC530
	private static void .cctor() { }
}
