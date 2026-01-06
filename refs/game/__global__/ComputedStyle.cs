internal struct ComputedStyle // TypeDefIndex: 6770
{
	// Fields
	public StyleDataRef<InheritedData> inheritedData; // 0x0
	public StyleDataRef<LayoutData> layoutData; // 0x8
	public StyleDataRef<RareData> rareData; // 0x10
	public StyleDataRef<TransformData> transformData; // 0x18
	public StyleDataRef<TransitionData> transitionData; // 0x20
	public StyleDataRef<VisualData> visualData; // 0x28
	public YogaNode yogaNode; // 0x30
	public Dictionary<string, StylePropertyValue> customProperties; // 0x38
	public long matchingRulesHash; // 0x40
	public float dpiScaling; // 0x48
	public ComputedTransitionProperty[] computedTransitions; // 0x50

	// Properties
	public int customPropertiesCount { get; }
	public bool hasTransition { get; }
	public Align alignContent { get; }
	public Align alignItems { get; }
	public Align alignSelf { get; }
	public Color backgroundColor { get; }
	public Background backgroundImage { get; }
	public BackgroundPosition backgroundPositionX { get; }
	public BackgroundPosition backgroundPositionY { get; }
	public BackgroundRepeat backgroundRepeat { get; }
	public BackgroundSize backgroundSize { get; }
	public Color borderBottomColor { get; }
	public Length borderBottomLeftRadius { get; }
	public Length borderBottomRightRadius { get; }
	public float borderBottomWidth { get; }
	public Color borderLeftColor { get; }
	public float borderLeftWidth { get; }
	public Color borderRightColor { get; }
	public float borderRightWidth { get; }
	public Color borderTopColor { get; }
	public Length borderTopLeftRadius { get; }
	public Length borderTopRightRadius { get; }
	public float borderTopWidth { get; }
	public Length bottom { get; }
	public Color color { get; }
	public Cursor cursor { get; }
	public DisplayStyle display { get; }
	public Length flexBasis { get; }
	public FlexDirection flexDirection { get; }
	public float flexGrow { get; }
	public float flexShrink { get; }
	public Wrap flexWrap { get; }
	public Length fontSize { get; }
	public Length height { get; }
	public Justify justifyContent { get; }
	public Length left { get; }
	public Length letterSpacing { get; }
	public Length marginBottom { get; }
	public Length marginLeft { get; }
	public Length marginRight { get; }
	public Length marginTop { get; }
	public Length maxHeight { get; }
	public Length maxWidth { get; }
	public Length minHeight { get; }
	public Length minWidth { get; }
	public float opacity { get; }
	public OverflowInternal overflow { get; }
	public Length paddingBottom { get; }
	public Length paddingLeft { get; }
	public Length paddingRight { get; }
	public Length paddingTop { get; }
	public Position position { get; }
	public Length right { get; }
	public Rotate rotate { get; }
	public Scale scale { get; }
	public TextOverflow textOverflow { get; }
	public TextShadow textShadow { get; }
	public Length top { get; }
	public TransformOrigin transformOrigin { get; }
	public List<TimeValue> transitionDelay { get; }
	public List<TimeValue> transitionDuration { get; }
	public List<StylePropertyName> transitionProperty { get; }
	public List<EasingFunction> transitionTimingFunction { get; }
	public Translate translate { get; }
	public Color unityBackgroundImageTintColor { get; }
	public Font unityFont { get; }
	public FontDefinition unityFontDefinition { get; }
	public FontStyle unityFontStyleAndWeight { get; }
	public OverflowClipBox unityOverflowClipBox { get; }
	public Length unityParagraphSpacing { get; }
	public int unitySliceBottom { get; }
	public int unitySliceLeft { get; }
	public int unitySliceRight { get; }
	public float unitySliceScale { get; }
	public int unitySliceTop { get; }
	public TextAnchor unityTextAlign { get; }
	public Color unityTextOutlineColor { get; }
	public float unityTextOutlineWidth { get; }
	public TextOverflowPosition unityTextOverflowPosition { get; }
	public Visibility visibility { get; }
	public WhiteSpace whiteSpace { get; }
	public Length width { get; }
	public Length wordSpacing { get; }

	// Methods

	// RVA: 0x2ED02F0 Offset: 0x2ECECF0 VA: 0x182ED02F0
	public int get_customPropertiesCount() { }

	// RVA: 0x2ED0500 Offset: 0x2ECEF00 VA: 0x182ED0500
	public bool get_hasTransition() { }

	// RVA: 0x2EC5170 Offset: 0x2EC3B70 VA: 0x182EC5170
	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	// RVA: 0x2ECF2A0 Offset: 0x2ECDCA0 VA: 0x182ECF2A0
	public void SyncWithLayout(YogaNode targetNode) { }

	// RVA: 0x2EBB1E0 Offset: 0x2EB9BE0 VA: 0x182EBB1E0
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EBB2A0 Offset: 0x2EB9CA0 VA: 0x182EBB2A0
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC53D0 Offset: 0x2EC3DD0 VA: 0x182EC53D0
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x2EB99A0 Offset: 0x2EB83A0 VA: 0x182EB99A0
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x2EB9940 Offset: 0x2EB8340 VA: 0x182EB9940
	private void ApplyAllPropertyInitial() { }

	// RVA: 0xCF2020 Offset: 0xCF0A20 VA: 0x180CF2020
	private void ResetComputedTransitions() { }

	// RVA: 0x2EC7FB0 Offset: 0x2EC69B0 VA: 0x182EC7FB0
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2ECFB90 Offset: 0x2ECE590 VA: 0x182ECFB90
	public Align get_alignContent() { }

	// RVA: 0x2ECFBD0 Offset: 0x2ECE5D0 VA: 0x182ECFBD0
	public Align get_alignItems() { }

	// RVA: 0x2ECFC10 Offset: 0x2ECE610 VA: 0x182ECFC10
	public Align get_alignSelf() { }

	// RVA: 0x2ECFC50 Offset: 0x2ECE650 VA: 0x182ECFC50
	public Color get_backgroundColor() { }

	// RVA: 0x2ECFCA0 Offset: 0x2ECE6A0 VA: 0x182ECFCA0
	public Background get_backgroundImage() { }

	// RVA: 0x2ECFD00 Offset: 0x2ECE700 VA: 0x182ECFD00
	public BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x2ECFD60 Offset: 0x2ECE760 VA: 0x182ECFD60
	public BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x2ECFDC0 Offset: 0x2ECE7C0 VA: 0x182ECFDC0
	public BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x2ECFE00 Offset: 0x2ECE800 VA: 0x182ECFE00
	public BackgroundSize get_backgroundSize() { }

	// RVA: 0x2ECFE60 Offset: 0x2ECE860 VA: 0x182ECFE60
	public Color get_borderBottomColor() { }

	// RVA: 0x2ECFEC0 Offset: 0x2ECE8C0 VA: 0x182ECFEC0
	public Length get_borderBottomLeftRadius() { }

	// RVA: 0x2ECFF00 Offset: 0x2ECE900 VA: 0x182ECFF00
	public Length get_borderBottomRightRadius() { }

	// RVA: 0x2ECFF40 Offset: 0x2ECE940 VA: 0x182ECFF40
	public float get_borderBottomWidth() { }

	// RVA: 0x2ECFF80 Offset: 0x2ECE980 VA: 0x182ECFF80
	public Color get_borderLeftColor() { }

	// RVA: 0x2ECFFE0 Offset: 0x2ECE9E0 VA: 0x182ECFFE0
	public float get_borderLeftWidth() { }

	// RVA: 0x2ED0020 Offset: 0x2ECEA20 VA: 0x182ED0020
	public Color get_borderRightColor() { }

	// RVA: 0x2ED0080 Offset: 0x2ECEA80 VA: 0x182ED0080
	public float get_borderRightWidth() { }

	// RVA: 0x2ED00C0 Offset: 0x2ECEAC0 VA: 0x182ED00C0
	public Color get_borderTopColor() { }

	// RVA: 0x2ED0120 Offset: 0x2ECEB20 VA: 0x182ED0120
	public Length get_borderTopLeftRadius() { }

	// RVA: 0x2ED0170 Offset: 0x2ECEB70 VA: 0x182ED0170
	public Length get_borderTopRightRadius() { }

	// RVA: 0x2ED01C0 Offset: 0x2ECEBC0 VA: 0x182ED01C0
	public float get_borderTopWidth() { }

	// RVA: 0x2ED0200 Offset: 0x2ECEC00 VA: 0x182ED0200
	public Length get_bottom() { }

	// RVA: 0x2ED0240 Offset: 0x2ECEC40 VA: 0x182ED0240
	public Color get_color() { }

	// RVA: 0x2ED0290 Offset: 0x2ECEC90 VA: 0x182ED0290
	public Cursor get_cursor() { }

	// RVA: 0x2ED0340 Offset: 0x2ECED40 VA: 0x182ED0340
	public DisplayStyle get_display() { }

	// RVA: 0x2ED0380 Offset: 0x2ECED80 VA: 0x182ED0380
	public Length get_flexBasis() { }

	// RVA: 0x2ED03C0 Offset: 0x2ECEDC0 VA: 0x182ED03C0
	public FlexDirection get_flexDirection() { }

	// RVA: 0x2ED0400 Offset: 0x2ECEE00 VA: 0x182ED0400
	public float get_flexGrow() { }

	// RVA: 0x2ED0440 Offset: 0x2ECEE40 VA: 0x182ED0440
	public float get_flexShrink() { }

	// RVA: 0x2ED0480 Offset: 0x2ECEE80 VA: 0x182ED0480
	public Wrap get_flexWrap() { }

	// RVA: 0x2ED04C0 Offset: 0x2ECEEC0 VA: 0x182ED04C0
	public Length get_fontSize() { }

	// RVA: 0x2ED0520 Offset: 0x2ECEF20 VA: 0x182ED0520
	public Length get_height() { }

	// RVA: 0x2ED0560 Offset: 0x2ECEF60 VA: 0x182ED0560
	public Justify get_justifyContent() { }

	// RVA: 0x2ED05A0 Offset: 0x2ECEFA0 VA: 0x182ED05A0
	public Length get_left() { }

	// RVA: 0x2ED05E0 Offset: 0x2ECEFE0 VA: 0x182ED05E0
	public Length get_letterSpacing() { }

	// RVA: 0x2ED0620 Offset: 0x2ECF020 VA: 0x182ED0620
	public Length get_marginBottom() { }

	// RVA: 0x2ED0660 Offset: 0x2ECF060 VA: 0x182ED0660
	public Length get_marginLeft() { }

	// RVA: 0x2ED06A0 Offset: 0x2ECF0A0 VA: 0x182ED06A0
	public Length get_marginRight() { }

	// RVA: 0x2ED06E0 Offset: 0x2ECF0E0 VA: 0x182ED06E0
	public Length get_marginTop() { }

	// RVA: 0x2ED0720 Offset: 0x2ECF120 VA: 0x182ED0720
	public Length get_maxHeight() { }

	// RVA: 0x2ED0760 Offset: 0x2ECF160 VA: 0x182ED0760
	public Length get_maxWidth() { }

	// RVA: 0x2ED07A0 Offset: 0x2ECF1A0 VA: 0x182ED07A0
	public Length get_minHeight() { }

	// RVA: 0x2ED07F0 Offset: 0x2ECF1F0 VA: 0x182ED07F0
	public Length get_minWidth() { }

	// RVA: 0x2ED0840 Offset: 0x2ECF240 VA: 0x182ED0840
	public float get_opacity() { }

	// RVA: 0x2ED0890 Offset: 0x2ECF290 VA: 0x182ED0890
	public OverflowInternal get_overflow() { }

	// RVA: 0x2ED08E0 Offset: 0x2ECF2E0 VA: 0x182ED08E0
	public Length get_paddingBottom() { }

	// RVA: 0x2ED0930 Offset: 0x2ECF330 VA: 0x182ED0930
	public Length get_paddingLeft() { }

	// RVA: 0x2ED0980 Offset: 0x2ECF380 VA: 0x182ED0980
	public Length get_paddingRight() { }

	// RVA: 0x2ED09D0 Offset: 0x2ECF3D0 VA: 0x182ED09D0
	public Length get_paddingTop() { }

	// RVA: 0x2ED0A20 Offset: 0x2ECF420 VA: 0x182ED0A20
	public Position get_position() { }

	// RVA: 0x2ED0A70 Offset: 0x2ECF470 VA: 0x182ED0A70
	public Length get_right() { }

	// RVA: 0x2ED0AC0 Offset: 0x2ECF4C0 VA: 0x182ED0AC0
	public Rotate get_rotate() { }

	// RVA: 0x2ED0B20 Offset: 0x2ECF520 VA: 0x182ED0B20
	public Scale get_scale() { }

	// RVA: 0x2ED0B80 Offset: 0x2ECF580 VA: 0x182ED0B80
	public TextOverflow get_textOverflow() { }

	// RVA: 0x2ED0BC0 Offset: 0x2ECF5C0 VA: 0x182ED0BC0
	public TextShadow get_textShadow() { }

	// RVA: 0x2ED0C20 Offset: 0x2ECF620 VA: 0x182ED0C20
	public Length get_top() { }

	// RVA: 0x2ED0C70 Offset: 0x2ECF670 VA: 0x182ED0C70
	public TransformOrigin get_transformOrigin() { }

	// RVA: 0x2ED0CD0 Offset: 0x2ECF6D0 VA: 0x182ED0CD0
	public List<TimeValue> get_transitionDelay() { }

	// RVA: 0x2ED0D10 Offset: 0x2ECF710 VA: 0x182ED0D10
	public List<TimeValue> get_transitionDuration() { }

	// RVA: 0x2ED0D50 Offset: 0x2ECF750 VA: 0x182ED0D50
	public List<StylePropertyName> get_transitionProperty() { }

	// RVA: 0x2ED0D90 Offset: 0x2ECF790 VA: 0x182ED0D90
	public List<EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x2ED0DD0 Offset: 0x2ECF7D0 VA: 0x182ED0DD0
	public Translate get_translate() { }

	// RVA: 0x2ED0E30 Offset: 0x2ECF830 VA: 0x182ED0E30
	public Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x2ED0F20 Offset: 0x2ECF920 VA: 0x182ED0F20
	public Font get_unityFont() { }

	// RVA: 0x2ED0E90 Offset: 0x2ECF890 VA: 0x182ED0E90
	public FontDefinition get_unityFontDefinition() { }

	// RVA: 0x2ED0EE0 Offset: 0x2ECF8E0 VA: 0x182ED0EE0
	public FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x2ED0F60 Offset: 0x2ECF960 VA: 0x182ED0F60
	public OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x2ED0FA0 Offset: 0x2ECF9A0 VA: 0x182ED0FA0
	public Length get_unityParagraphSpacing() { }

	// RVA: 0x2ED0FE0 Offset: 0x2ECF9E0 VA: 0x182ED0FE0
	public int get_unitySliceBottom() { }

	// RVA: 0x2ED1020 Offset: 0x2ECFA20 VA: 0x182ED1020
	public int get_unitySliceLeft() { }

	// RVA: 0x2ED1060 Offset: 0x2ECFA60 VA: 0x182ED1060
	public int get_unitySliceRight() { }

	// RVA: 0x2ED10A0 Offset: 0x2ECFAA0 VA: 0x182ED10A0
	public float get_unitySliceScale() { }

	// RVA: 0x2ED10E0 Offset: 0x2ECFAE0 VA: 0x182ED10E0
	public int get_unitySliceTop() { }

	// RVA: 0x2ED1120 Offset: 0x2ECFB20 VA: 0x182ED1120
	public TextAnchor get_unityTextAlign() { }

	// RVA: 0x2ED1160 Offset: 0x2ECFB60 VA: 0x182ED1160
	public Color get_unityTextOutlineColor() { }

	// RVA: 0x2ED11B0 Offset: 0x2ECFBB0 VA: 0x182ED11B0
	public float get_unityTextOutlineWidth() { }

	// RVA: 0x2ED11F0 Offset: 0x2ECFBF0 VA: 0x182ED11F0
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x2ED1230 Offset: 0x2ECFC30 VA: 0x182ED1230
	public Visibility get_visibility() { }

	// RVA: 0x2ED1270 Offset: 0x2ECFC70 VA: 0x182ED1270
	public WhiteSpace get_whiteSpace() { }

	// RVA: 0x2ED12B0 Offset: 0x2ECFCB0 VA: 0x182ED12B0
	public Length get_width() { }

	// RVA: 0x2ED1300 Offset: 0x2ECFD00 VA: 0x182ED1300
	public Length get_wordSpacing() { }

	// RVA: 0x2EC4F70 Offset: 0x2EC3970 VA: 0x182EC4F70
	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC4DC0 Offset: 0x2EC37C0 VA: 0x182EC4DC0
	public static ComputedStyle CreateInitial() { }

	// RVA: 0x2EB9810 Offset: 0x2EB8210 VA: 0x182EB9810
	public ComputedStyle Acquire() { }

	// RVA: 0x2EC5300 Offset: 0x2EC3D00 VA: 0x182EC5300
	public void Release() { }

	// RVA: 0x2EC4C90 Offset: 0x2EC3690 VA: 0x182EC4C90
	public void CopyFrom(ref ComputedStyle other) { }

	// RVA: 0x2EBD3B0 Offset: 0x2EBBDB0 VA: 0x182EBD3B0
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC1B20 Offset: 0x2EC0520 VA: 0x182EC1B20
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC15D0 Offset: 0x2EBFFD0 VA: 0x182EC15D0
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC13A0 Offset: 0x2EBFDA0 VA: 0x182EC13A0
	public void ApplyStyleCursor(Cursor cursor) { }

	// RVA: 0x2EC14B0 Offset: 0x2EBFEB0 VA: 0x182EC14B0
	public void ApplyStyleTextShadow(TextShadow st) { }

	// RVA: 0x2EB9AB0 Offset: 0x2EB84B0 VA: 0x182EB9AB0
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	// RVA: 0x2EBF250 Offset: 0x2EBDC50 VA: 0x182EBF250
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	// RVA: 0x2EBED60 Offset: 0x2EBD760 VA: 0x182EBED60
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	// RVA: 0x2EBFCC0 Offset: 0x2EBE6C0 VA: 0x182EBFCC0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	// RVA: 0x2EC0B90 Offset: 0x2EBF590 VA: 0x182EC0B90
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	// RVA: 0x2EC0720 Offset: 0x2EBF120 VA: 0x182EC0720
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	// RVA: 0x2EBF100 Offset: 0x2EBDB00 VA: 0x182EBF100
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	// RVA: 0x2EC1090 Offset: 0x2EBFA90 VA: 0x182EC1090
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	// RVA: 0x2EC09E0 Offset: 0x2EBF3E0 VA: 0x182EC09E0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	// RVA: 0x2EBFB20 Offset: 0x2EBE520 VA: 0x182EBFB20
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	// RVA: 0x2EC0DB0 Offset: 0x2EBF7B0 VA: 0x182EC0DB0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	// RVA: 0x2EC0F40 Offset: 0x2EBF940 VA: 0x182EC0F40
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	// RVA: 0x2EC0490 Offset: 0x2EBEE90 VA: 0x182EC0490
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	// RVA: 0x2EC0890 Offset: 0x2EBF290 VA: 0x182EC0890
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	// RVA: 0x2EBEC10 Offset: 0x2EBD610 VA: 0x182EBEC10
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	// RVA: 0x2EC05E0 Offset: 0x2EBEFE0 VA: 0x182EC05E0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	// RVA: 0x2ECB4F0 Offset: 0x2EC9EF0 VA: 0x182ECB4F0
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EC5470 Offset: 0x2EC3E70 VA: 0x182EC5470
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EC81E0 Offset: 0x2EC6BE0 VA: 0x182EC81E0
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EC1510 Offset: 0x2EBFF10 VA: 0x182EC1510
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	// RVA: 0x2EC1570 Offset: 0x2EBFF70 VA: 0x182EC1570
	public void ApplyStyleTranslate(Translate translateValue) { }

	// RVA: 0x2EC1400 Offset: 0x2EBFE00 VA: 0x182EC1400
	public void ApplyStyleRotate(Rotate rotateValue) { }

	// RVA: 0x2EC1460 Offset: 0x2EBFE60 VA: 0x182EC1460
	public void ApplyStyleScale(Scale scaleValue) { }

	// RVA: 0x2EC1340 Offset: 0x2EBFD40 VA: 0x182EC1340
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	// RVA: 0x2EBB2C0 Offset: 0x2EB9CC0 VA: 0x182EBB2C0
	public void ApplyInitialValue(StylePropertyReader reader) { }

	// RVA: 0x2EBB3E0 Offset: 0x2EB9DE0 VA: 0x182EBB3E0
	public void ApplyInitialValue(StylePropertyId id) { }

	// RVA: 0x2EC2BE0 Offset: 0x2EC15E0 VA: 0x182EC2BE0
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC2CA0 Offset: 0x2EC16A0 VA: 0x182EC2CA0
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	// RVA: 0x2EC30B0 Offset: 0x2EC1AB0 VA: 0x182EC30B0
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }
}
