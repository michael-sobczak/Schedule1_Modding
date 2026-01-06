public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 14991
{
	// Fields
	[TextArea(5, 10)]
	[SerializeField]
	protected string m_text; // 0xE0
	private bool m_IsTextBackingStringDirty; // 0xE8
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; // 0xF0
	[SerializeField]
	protected bool m_isRightToLeft; // 0xF8
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; // 0x100
	protected TMP_FontAsset m_currentFontAsset; // 0x108
	protected bool m_isSDFShader; // 0x110
	[SerializeField]
	protected Material m_sharedMaterial; // 0x118
	protected Material m_currentMaterial; // 0x120
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x128
	[SerializeField]
	protected Material[] m_fontSharedMaterials; // 0x130
	[SerializeField]
	protected Material m_fontMaterial; // 0x138
	[SerializeField]
	protected Material[] m_fontMaterials; // 0x140
	protected bool m_isMaterialDirty; // 0x148
	[SerializeField]
	protected Color32 m_fontColor32; // 0x14C
	[SerializeField]
	protected Color m_fontColor; // 0x150
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x160
	protected Color32 m_strikethroughColor; // 0x164
	internal HighlightState m_HighlightState; // 0x168
	internal bool m_ConvertToLinearSpace; // 0x17C
	[SerializeField]
	protected bool m_enableVertexGradient; // 0x17D
	[SerializeField]
	protected ColorMode m_colorMode; // 0x180
	[SerializeField]
	protected VertexGradient m_fontColorGradient; // 0x184
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1C8
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; // 0x1D0
	[SerializeField]
	protected bool m_tintAllSprites; // 0x1D8
	protected bool m_tintSprite; // 0x1D9
	protected Color32 m_spriteColor; // 0x1DC
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; // 0x1E0
	internal TMP_Style m_TextStyle; // 0x1E8
	[SerializeField]
	protected int m_TextStyleHashCode; // 0x1F0
	[SerializeField]
	protected bool m_overrideHtmlColors; // 0x1F4
	[SerializeField]
	protected Color32 m_faceColor; // 0x1F8
	protected Color32 m_outlineColor; // 0x1FC
	protected float m_outlineWidth; // 0x200
	[SerializeField]
	protected float m_fontSize; // 0x204
	protected float m_currentFontSize; // 0x208
	[SerializeField]
	protected float m_fontSizeBase; // 0x20C
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x210
	[SerializeField]
	protected FontWeight m_fontWeight; // 0x230
	protected FontWeight m_FontWeightInternal; // 0x234
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x238
	[SerializeField]
	protected bool m_enableAutoSizing; // 0x258
	protected float m_maxFontSize; // 0x25C
	protected float m_minFontSize; // 0x260
	protected int m_AutoSizeIterationCount; // 0x264
	protected int m_AutoSizeMaxIterationCount; // 0x268
	protected bool m_IsAutoSizePointSizeSet; // 0x26C
	[SerializeField]
	protected float m_fontSizeMin; // 0x270
	[SerializeField]
	protected float m_fontSizeMax; // 0x274
	[SerializeField]
	protected FontStyles m_fontStyle; // 0x278
	protected FontStyles m_FontStyleInternal; // 0x27C
	protected TMP_FontStyleStack m_fontStyleStack; // 0x280
	protected bool m_isUsingBold; // 0x28A
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x28C
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x290
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	protected TextAlignmentOptions m_textAlignment; // 0x294
	protected HorizontalAlignmentOptions m_lineJustification; // 0x298
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2A0
	protected Vector3[] m_textContainerLocalCorners; // 0x2C0
	[SerializeField]
	protected float m_characterSpacing; // 0x2C8
	protected float m_cSpacing; // 0x2CC
	protected float m_monoSpacing; // 0x2D0
	protected bool m_duoSpace; // 0x2D4
	[SerializeField]
	protected float m_wordSpacing; // 0x2D8
	[SerializeField]
	protected float m_lineSpacing; // 0x2DC
	protected float m_lineSpacingDelta; // 0x2E0
	protected float m_lineHeight; // 0x2E4
	protected bool m_IsDrivenLineSpacing; // 0x2E8
	[SerializeField]
	protected float m_lineSpacingMax; // 0x2EC
	[SerializeField]
	protected float m_paragraphSpacing; // 0x2F0
	[SerializeField]
	protected float m_charWidthMaxAdj; // 0x2F4
	protected float m_charWidthAdjDelta; // 0x2F8
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	protected TextWrappingModes m_TextWrappingMode; // 0x2FC
	protected bool m_isCharacterWrappingEnabled; // 0x300
	protected bool m_isNonBreakingSpace; // 0x301
	protected bool m_isIgnoringAlignment; // 0x302
	[SerializeField]
	protected float m_wordWrappingRatios; // 0x304
	[SerializeField]
	protected TextOverflowModes m_overflowMode; // 0x308
	protected int m_firstOverflowCharacterIndex; // 0x30C
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; // 0x310
	[SerializeField]
	internal TMP_Text parentLinkedComponent; // 0x318
	protected bool m_isTextTruncated; // 0x320
	[SerializeField]
	protected bool m_enableKerning; // 0x321
	protected int m_LastBaseGlyphIndex; // 0x324
	[SerializeField]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x328
	[SerializeField]
	protected bool m_enableExtraPadding; // 0x330
	[SerializeField]
	protected bool checkPaddingRequired; // 0x331
	[SerializeField]
	protected bool m_isRichText; // 0x332
	[SerializeField]
	private bool m_EmojiFallbackSupport; // 0x333
	[SerializeField]
	protected bool m_parseCtrlCharacters; // 0x334
	protected bool m_isOverlay; // 0x335
	[SerializeField]
	protected bool m_isOrthographic; // 0x336
	[SerializeField]
	protected bool m_isCullingEnabled; // 0x337
	protected bool m_isMaskingEnabled; // 0x338
	protected bool isMaskUpdateRequired; // 0x339
	protected bool m_ignoreCulling; // 0x33A
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; // 0x33C
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; // 0x340
	[SerializeField]
	protected float m_uvLineOffset; // 0x344
	protected TextRenderFlags m_renderMode; // 0x348
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; // 0x34C
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; // 0x350
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x351
	protected int m_firstVisibleCharacter; // 0x354
	protected int m_maxVisibleCharacters; // 0x358
	protected int m_maxVisibleWords; // 0x35C
	protected int m_maxVisibleLines; // 0x360
	[SerializeField]
	protected bool m_useMaxVisibleDescender; // 0x364
	[SerializeField]
	protected int m_pageToDisplay; // 0x368
	protected bool m_isNewPage; // 0x36C
	[SerializeField]
	protected Vector4 m_margin; // 0x370
	protected float m_marginLeft; // 0x380
	protected float m_marginRight; // 0x384
	protected float m_marginWidth; // 0x388
	protected float m_marginHeight; // 0x38C
	protected float m_width; // 0x390
	protected TMP_TextInfo m_textInfo; // 0x398
	protected bool m_havePropertiesChanged; // 0x3A0
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; // 0x3A1
	protected Transform m_transform; // 0x3A8
	protected RectTransform m_rectTransform; // 0x3B0
	protected Vector2 m_PreviousRectTransformSize; // 0x3B8
	protected Vector2 m_PreviousPivotPosition; // 0x3C0
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; // 0x3C8
	protected bool m_autoSizeTextContainer; // 0x3C9
	protected Mesh m_mesh; // 0x3D0
	[SerializeField]
	protected bool m_isVolumetricText; // 0x3D8
	[CompilerGenerated]
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGenerated]
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGenerated]
	private static TMP_Text.MissingCharacterEventCallback OnMissingCharacter; // 0x80
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3E0
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3E8
	protected float m_flexibleHeight; // 0x3F0
	protected float m_flexibleWidth; // 0x3F4
	protected float m_minWidth; // 0x3F8
	protected float m_minHeight; // 0x3FC
	protected float m_maxWidth; // 0x400
	protected float m_maxHeight; // 0x404
	protected LayoutElement m_LayoutElement; // 0x408
	protected float m_preferredWidth; // 0x410
	protected float m_RenderedWidth; // 0x414
	protected bool m_isPreferredWidthDirty; // 0x418
	protected float m_preferredHeight; // 0x41C
	protected float m_RenderedHeight; // 0x420
	protected bool m_isPreferredHeightDirty; // 0x424
	protected bool m_isCalculatingPreferredValues; // 0x425
	protected int m_layoutPriority; // 0x428
	protected bool m_isLayoutDirty; // 0x42C
	protected bool m_isAwake; // 0x42D
	internal bool m_isWaitingOnResourceLoad; // 0x42E
	internal TMP_Text.TextInputSources m_inputSource; // 0x430
	protected float m_fontScaleMultiplier; // 0x434
	private static char[] m_htmlTag; // 0x88
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x90
	private static float[] m_attributeParameterValues; // 0x98
	protected float tag_LineIndent; // 0x438
	protected float tag_Indent; // 0x43C
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x440
	protected bool tag_NoParsing; // 0x460
	protected bool m_isTextLayoutPhase; // 0x461
	protected Quaternion m_FXRotation; // 0x464
	protected Vector3 m_FXScale; // 0x474
	internal TMP_Text.TextProcessingElement[] m_TextProcessingArray; // 0x480
	internal int m_InternalTextProcessingArraySize; // 0x488
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x490
	protected int m_totalCharacterCount; // 0x498
	internal static WordWrapState m_SavedWordWrapState; // 0xA0
	internal static WordWrapState m_SavedLineState; // 0x458
	internal static WordWrapState m_SavedEllipsisState; // 0x810
	internal static WordWrapState m_SavedLastValidState; // 0xBC8
	internal static WordWrapState m_SavedSoftLineBreakState; // 0xF80
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1338
	protected int m_characterCount; // 0x49C
	protected int m_firstCharacterOfLine; // 0x4A0
	protected int m_firstVisibleCharacterOfLine; // 0x4A4
	protected int m_lastCharacterOfLine; // 0x4A8
	protected int m_lastVisibleCharacterOfLine; // 0x4AC
	protected int m_lineNumber; // 0x4B0
	protected int m_lineVisibleCharacterCount; // 0x4B4
	protected int m_lineVisibleSpaceCount; // 0x4B8
	protected int m_pageNumber; // 0x4BC
	protected float m_PageAscender; // 0x4C0
	protected float m_maxTextAscender; // 0x4C4
	protected float m_maxCapHeight; // 0x4C8
	protected float m_ElementAscender; // 0x4CC
	protected float m_ElementDescender; // 0x4D0
	protected float m_maxLineAscender; // 0x4D4
	protected float m_maxLineDescender; // 0x4D8
	protected float m_startOfLineAscender; // 0x4DC
	protected float m_startOfLineDescender; // 0x4E0
	protected float m_lineOffset; // 0x4E4
	protected Extents m_meshExtents; // 0x4E8
	protected Color32 m_htmlColor; // 0x4F8
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x500
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x520
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x540
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x560
	protected TMP_ColorGradient m_colorGradientPreset; // 0x590
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x598
	protected bool m_colorGradientPresetIsTinted; // 0x5C0
	protected float m_tabSpacing; // 0x5C4
	protected float m_spacing; // 0x5C8
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5D0
	protected int m_TextStyleStackDepth; // 0x5D8
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5E0
	protected int m_ItalicAngle; // 0x600
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x608
	protected float m_padding; // 0x628
	protected float m_baselineOffset; // 0x62C
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x630
	protected float m_xAdvance; // 0x650
	protected TMP_TextElementType m_textElementType; // 0x654
	protected TMP_TextElement m_cached_TextElement; // 0x658
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x660
	protected TMP_Text.SpecialCharacter m_Underline; // 0x680
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x6A0
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x6A8
	protected int m_spriteCount; // 0x6B0
	protected int m_spriteIndex; // 0x6B4
	protected int m_spriteAnimationID; // 0x6B8
	private static ProfilerMarker k_ParseTextMarker; // 0x1710
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1718
	protected bool m_ignoreActiveState; // 0x6BC
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6C0
	private readonly Decimal[] k_Power; // 0x6D0
	protected static Vector2 k_LargePositiveVector2; // 0x1720
	protected static Vector2 k_LargeNegativeVector2; // 0x1728
	protected static float k_LargePositiveFloat; // 0x1730
	protected static float k_LargeNegativeFloat; // 0x1734
	protected static int k_LargePositiveInt; // 0x1738
	protected static int k_LargeNegativeInt; // 0x173C

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public TextWrappingModes textWrappingMode { get; set; }
	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled on the text component.")]
	public bool enableKerning { get; set; }
	public List<OTL_FeatureTag> fontFeatures { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool emojiFallbackSupport { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x2C1A9B0 Offset: 0x2C193B0 VA: 0x182C1A9B0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x2C1C5F0 Offset: 0x2C1AFF0 VA: 0x182C1C5F0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_isRightToLeftText() { }

	// RVA: 0x2C1BCA0 Offset: 0x2C1A6A0 VA: 0x182C1BCA0
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public TMP_FontAsset get_font() { }

	// RVA: 0x2C1BA60 Offset: 0x2C1A460 VA: 0x182C1BA60
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x2C1B7B0 Offset: 0x2C1A1B0 VA: 0x182C1B7B0 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x2C1A030 Offset: 0x2C18A30 VA: 0x182C1A030 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x2C1B750 Offset: 0x2C1A150 VA: 0x182C1B750 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x2C19FF0 Offset: 0x2C189F0 VA: 0x182C19FF0
	public Material get_fontMaterial() { }

	// RVA: 0x2C1B640 Offset: 0x2C1A040 VA: 0x182C1B640
	public void set_fontMaterial(Material value) { }

	// RVA: 0x2C1A010 Offset: 0x2C18A10 VA: 0x182C1A010 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x2C1B750 Offset: 0x2C1A150 VA: 0x182C1B750 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x9E1B00 Offset: 0x9E0500 VA: 0x1809E1B00 Slot: 22
	public override Color get_color() { }

	// RVA: 0x2C1B170 Offset: 0x2C19B70 VA: 0x182C1B170 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x2C19CF0 Offset: 0x2C186F0 VA: 0x182C19CF0
	public float get_alpha() { }

	// RVA: 0x2C1AFD0 Offset: 0x2C199D0 VA: 0x182C1AFD0
	public void set_alpha(float value) { }

	// RVA: 0x726420 Offset: 0x724E20 VA: 0x180726420
	public bool get_enableVertexGradient() { }

	// RVA: 0x2C1B440 Offset: 0x2C19E40 VA: 0x182C1B440
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x2C19E00 Offset: 0x2C18800 VA: 0x182C19E00
	public VertexGradient get_colorGradient() { }

	// RVA: 0x2C1B120 Offset: 0x2C19B20 VA: 0x182C1B120
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x2C1B0E0 Offset: 0x2C19AE0 VA: 0x182C1B0E0
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x2C1C460 Offset: 0x2C1AE60 VA: 0x182C1C460
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x222B030 Offset: 0x2229A30 VA: 0x18222B030
	public bool get_tintAllSprites() { }

	// RVA: 0x2C1C6A0 Offset: 0x2C1B0A0 VA: 0x182C1C6A0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x2C1C4C0 Offset: 0x2C1AEC0 VA: 0x182C1C4C0
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x2C1A930 Offset: 0x2C19330 VA: 0x182C1A930
	public TMP_Style get_textStyle() { }

	// RVA: 0x2C1C520 Offset: 0x2C1AF20 VA: 0x182C1C520
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x2C1A400 Offset: 0x2C18E00 VA: 0x182C1A400
	public bool get_overrideColorTags() { }

	// RVA: 0x2C1C2C0 Offset: 0x2C1ACC0 VA: 0x182C1C2C0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x2C19ED0 Offset: 0x2C188D0 VA: 0x182C19ED0
	public Color32 get_faceColor() { }

	// RVA: 0x2C1B530 Offset: 0x2C19F30 VA: 0x182C1B530
	public void set_faceColor(Color32 value) { }

	// RVA: 0x2C1A240 Offset: 0x2C18C40 VA: 0x182C1A240
	public Color32 get_outlineColor() { }

	// RVA: 0x2C1C180 Offset: 0x2C1AB80 VA: 0x182C1C180
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x2C1A330 Offset: 0x2C18D30 VA: 0x182C1A330
	public float get_outlineWidth() { }

	// RVA: 0x2C1C1F0 Offset: 0x2C1ABF0 VA: 0x182C1C1F0
	public void set_outlineWidth(float value) { }

	// RVA: 0x284E2C0 Offset: 0x284CCC0 VA: 0x18284E2C0
	public float get_fontSize() { }

	// RVA: 0x2C1B930 Offset: 0x2C1A330 VA: 0x182C1B930
	public void set_fontSize(float value) { }

	// RVA: 0x21C8B30 Offset: 0x21C7530 VA: 0x1821C8B30
	public FontWeight get_fontWeight() { }

	// RVA: 0x2C1BA00 Offset: 0x2C1A400 VA: 0x182C1BA00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x2C1A440 Offset: 0x2C18E40 VA: 0x182C1A440
	public float get_pixelsPerUnit() { }

	// RVA: 0x81F1F0 Offset: 0x81DBF0 VA: 0x18081F1F0
	public bool get_enableAutoSizing() { }

	// RVA: 0x2C1B260 Offset: 0x2C19C60 VA: 0x182C1B260
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x6411F0 Offset: 0x63FBF0 VA: 0x1806411F0
	public float get_fontSizeMin() { }

	// RVA: 0x2C1B8D0 Offset: 0x2C1A2D0 VA: 0x182C1B8D0
	public void set_fontSizeMin(float value) { }

	// RVA: 0x2C1A050 Offset: 0x2C18A50 VA: 0x182C1A050
	public float get_fontSizeMax() { }

	// RVA: 0x2C1B870 Offset: 0x2C1A270 VA: 0x182C1B870
	public void set_fontSizeMax(float value) { }

	// RVA: 0x2233AD0 Offset: 0x22324D0 VA: 0x182233AD0
	public FontStyles get_fontStyle() { }

	// RVA: 0x2C1B9A0 Offset: 0x2C1A3A0 VA: 0x182C1B9A0
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x81F1B0 Offset: 0x81DBB0 VA: 0x18081F1B0
	public bool get_isUsingBold() { }

	// RVA: 0x22688D0 Offset: 0x22672D0 VA: 0x1822688D0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x2C1BB90 Offset: 0x2C1A590 VA: 0x182C1BB90
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x2C1AB70 Offset: 0x2C19570 VA: 0x182C1AB70
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x2C1C730 Offset: 0x2C1B130 VA: 0x182C1C730
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x2C19CE0 Offset: 0x2C186E0 VA: 0x182C19CE0
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x2C1AF80 Offset: 0x2C19980 VA: 0x182C1AF80
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x2C19DE0 Offset: 0x2C187E0 VA: 0x182C19DE0
	public float get_characterSpacing() { }

	// RVA: 0x2C1B020 Offset: 0x2C19A20 VA: 0x182C1B020
	public void set_characterSpacing(float value) { }

	// RVA: 0x9E18F0 Offset: 0x9E02F0 VA: 0x1809E18F0
	public float get_wordSpacing() { }

	// RVA: 0x2C1C790 Offset: 0x2C1B190 VA: 0x182C1C790
	public void set_wordSpacing(float value) { }

	// RVA: 0x9E1940 Offset: 0x9E0340 VA: 0x1809E1940
	public float get_lineSpacing() { }

	// RVA: 0x2C1BE70 Offset: 0x2C1A870 VA: 0x182C1BE70
	public void set_lineSpacing(float value) { }

	// RVA: 0x2C1A1C0 Offset: 0x2C18BC0 VA: 0x182C1A1C0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x2C1BE10 Offset: 0x2C1A810 VA: 0x182C1BE10
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x2C1A420 Offset: 0x2C18E20 VA: 0x182C1A420
	public float get_paragraphSpacing() { }

	// RVA: 0x2C1C320 Offset: 0x2C1AD20 VA: 0x182C1C320
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x2C19DF0 Offset: 0x2C187F0 VA: 0x182C19DF0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x2C1B080 Offset: 0x2C19A80 VA: 0x182C1B080
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x7447E0 Offset: 0x7431E0 VA: 0x1807447E0
	public TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x2C1C590 Offset: 0x2C1AF90 VA: 0x182C1C590
	public void set_textWrappingMode(TextWrappingModes value) { }

	// RVA: 0x2C19EA0 Offset: 0x2C188A0 VA: 0x182C19EA0
	public bool get_enableWordWrapping() { }

	// RVA: 0x2C1B470 Offset: 0x2C19E70 VA: 0x182C1B470
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x2C1AB90 Offset: 0x2C19590 VA: 0x182C1AB90
	public float get_wordWrappingRatios() { }

	// RVA: 0x2C1C7F0 Offset: 0x2C1B1F0 VA: 0x182C1C7F0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x6C86F0 Offset: 0x6C70F0 VA: 0x1806C86F0
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x2C1C260 Offset: 0x2C1AC60 VA: 0x182C1C260
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x2C1A0D0 Offset: 0x2C18AD0 VA: 0x182C1A0D0
	public bool get_isTextOverflowing() { }

	// RVA: 0x6C8710 Offset: 0x6C7110 VA: 0x1806C8710
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x9CAED0 Offset: 0x9C98D0 VA: 0x1809CAED0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x2C1BED0 Offset: 0x2C1A8D0 VA: 0x182C1BED0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x2C1A0E0 Offset: 0x2C18AE0 VA: 0x182C1A0E0
	public bool get_isTextTruncated() { }

	// RVA: 0x2C19E50 Offset: 0x2C18850 VA: 0x182C19E50
	public bool get_enableKerning() { }

	// RVA: 0x2C1B2F0 Offset: 0x2C19CF0 VA: 0x182C1B2F0
	public void set_enableKerning(bool value) { }

	// RVA: 0x9E17F0 Offset: 0x9E01F0 VA: 0x1809E17F0
	public List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x2C1B5E0 Offset: 0x2C19FE0 VA: 0x182C1B5E0
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	// RVA: 0x2C19EC0 Offset: 0x2C188C0 VA: 0x182C19EC0
	public bool get_extraPadding() { }

	// RVA: 0x2C1B4D0 Offset: 0x2C19ED0 VA: 0x182C1B4D0
	public void set_extraPadding(bool value) { }

	// RVA: 0x2C1A730 Offset: 0x2C19130 VA: 0x182C1A730
	public bool get_richText() { }

	// RVA: 0x2C1C400 Offset: 0x2C1AE00 VA: 0x182C1C400
	public void set_richText(bool value) { }

	// RVA: 0x2C19E30 Offset: 0x2C18830 VA: 0x182C19E30
	public bool get_emojiFallbackSupport() { }

	// RVA: 0x2C1B200 Offset: 0x2C19C00 VA: 0x182C1B200
	public void set_emojiFallbackSupport(bool value) { }

	// RVA: 0x2C1A430 Offset: 0x2C18E30 VA: 0x182C1A430
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x2C1C380 Offset: 0x2C1AD80 VA: 0x182C1C380
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x2C1A0B0 Offset: 0x2C18AB0 VA: 0x182C1A0B0
	public bool get_isOverlay() { }

	// RVA: 0x2C1BC40 Offset: 0x2C1A640 VA: 0x182C1BC40
	public void set_isOverlay(bool value) { }

	// RVA: 0x2C1A0A0 Offset: 0x2C18AA0 VA: 0x182C1A0A0
	public bool get_isOrthographic() { }

	// RVA: 0x2C1BC10 Offset: 0x2C1A610 VA: 0x182C1BC10
	public void set_isOrthographic(bool value) { }

	// RVA: 0x2C19E40 Offset: 0x2C18840 VA: 0x182C19E40
	public bool get_enableCulling() { }

	// RVA: 0x2C1B2B0 Offset: 0x2C19CB0 VA: 0x182C1B2B0
	public void set_enableCulling(bool value) { }

	// RVA: 0x2C1A090 Offset: 0x2C18A90 VA: 0x182C1A090
	public bool get_ignoreVisibility() { }

	// RVA: 0x2C1BBF0 Offset: 0x2C1A5F0 VA: 0x182C1BBF0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x2C1A080 Offset: 0x2C18A80 VA: 0x182C1A080
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x2C1BBC0 Offset: 0x2C1A5C0 VA: 0x182C1BBC0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x2C1AB80 Offset: 0x2C19580 VA: 0x182C1AB80
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x2C1C760 Offset: 0x2C1B160 VA: 0x182C1C760
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x2C1A1D0 Offset: 0x2C18BD0 VA: 0x182C1A1D0
	public float get_mappingUvLineOffset() { }

	// RVA: 0x2C1BFF0 Offset: 0x2C1A9F0 VA: 0x182C1BFF0
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x2C1A720 Offset: 0x2C19120 VA: 0x182C1A720
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x2C1C3E0 Offset: 0x2C1ADE0 VA: 0x182C1C3E0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x2C1A060 Offset: 0x2C18A60 VA: 0x182C1A060
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x2C1BB30 Offset: 0x2C1A530 VA: 0x182C1BB30
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x2C1A0C0 Offset: 0x2C18AC0 VA: 0x182C1A0C0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x2C1BD00 Offset: 0x2C1A700 VA: 0x182C1BD00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x2C1AB60 Offset: 0x2C19560 VA: 0x182C1AB60
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x2C1C700 Offset: 0x2C1B100 VA: 0x182C1C700
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x2C19FC0 Offset: 0x2C189C0 VA: 0x182C19FC0
	public int get_firstVisibleCharacter() { }

	// RVA: 0x2C1B5B0 Offset: 0x2C19FB0 VA: 0x182C1B5B0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x6C8780 Offset: 0x6C7180 VA: 0x1806C8780
	public int get_maxVisibleCharacters() { }

	// RVA: 0x2C1C0F0 Offset: 0x2C1AAF0 VA: 0x182C1C0F0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x2C1A200 Offset: 0x2C18C00 VA: 0x182C1A200
	public int get_maxVisibleWords() { }

	// RVA: 0x2C1C150 Offset: 0x2C1AB50 VA: 0x182C1C150
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x6E6210 Offset: 0x6E4C10 VA: 0x1806E6210
	public int get_maxVisibleLines() { }

	// RVA: 0x2C1C120 Offset: 0x2C1AB20 VA: 0x182C1C120
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x2C1AB50 Offset: 0x2C19550 VA: 0x182C1AB50
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x2C1C6D0 Offset: 0x2C1B0D0 VA: 0x182C1C6D0
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x2C1A410 Offset: 0x2C18E10 VA: 0x182C1A410
	public int get_pageToDisplay() { }

	// RVA: 0x2C1C2F0 Offset: 0x2C1ACF0 VA: 0x182C1C2F0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x2C1A1E0 Offset: 0x2C18BE0 VA: 0x182C1A1E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x2C1C030 Offset: 0x2C1AA30 VA: 0x182C1C030 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x2C1A8B0 Offset: 0x2C192B0 VA: 0x182C1A8B0
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x2C1A070 Offset: 0x2C18A70 VA: 0x182C1A070
	public bool get_havePropertiesChanged() { }

	// RVA: 0x2C1BB60 Offset: 0x2C1A560 VA: 0x182C1BB60
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x2C1A0F0 Offset: 0x2C18AF0 VA: 0x182C1A0F0
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x2C1BD90 Offset: 0x2C1A790 VA: 0x182C1BD90
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x2C1AAB0 Offset: 0x2C194B0 VA: 0x182C1AAB0
	public Transform get_transform() { }

	// RVA: 0x2C1A680 Offset: 0x2C19080 VA: 0x182C1A680
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x2C19D00 Offset: 0x2C18700 VA: 0x182C19D00 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGenerated]
	// RVA: 0x2C1B010 Offset: 0x2C19A10 VA: 0x182C1B010 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x67A240 Offset: 0x678C40 VA: 0x18067A240 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x2C1A100 Offset: 0x2C18B00 VA: 0x182C1A100
	public bool get_isVolumetricText() { }

	// RVA: 0x2C1BDA0 Offset: 0x2C1A7A0 VA: 0x182C1BDA0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x2C19D10 Offset: 0x2C18710 VA: 0x182C19D10
	public Bounds get_bounds() { }

	// RVA: 0x2C1A850 Offset: 0x2C19250 VA: 0x182C1A850
	public Bounds get_textBounds() { }

	[CompilerGenerated]
	// RVA: 0x2C19900 Offset: 0x2C18300 VA: 0x182C19900
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x2C1ABA0 Offset: 0x2C195A0 VA: 0x182C1ABA0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x2C19BD0 Offset: 0x2C185D0 VA: 0x182C19BD0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x2C1AE70 Offset: 0x2C19870 VA: 0x182C1AE70
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x2C19A10 Offset: 0x2C18410 VA: 0x182C19A10
	public static void add_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2C1ACB0 Offset: 0x2C196B0 VA: 0x182C1ACB0
	public static void remove_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x2C19B10 Offset: 0x2C18510 VA: 0x182C19B10 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x2C1ADB0 Offset: 0x2C197B0 VA: 0x182C1ADB0 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x2C1A740 Offset: 0x2C19140 VA: 0x182C1A740
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x2C19FD0 Offset: 0x2C189D0 VA: 0x182C19FD0 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x2C19FE0 Offset: 0x2C189E0 VA: 0x182C19FE0 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x2C1A230 Offset: 0x2C18C30 VA: 0x182C1A230 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x2C1A220 Offset: 0x2C18C20 VA: 0x182C1A220 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x2C1A210 Offset: 0x2C18C10 VA: 0x182C1A210
	public float get_maxWidth() { }

	// RVA: 0x2C1A1F0 Offset: 0x2C18BF0 VA: 0x182C1A1F0
	public float get_maxHeight() { }

	// RVA: 0x2C1A110 Offset: 0x2C18B10 VA: 0x182C1A110
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x2C1A660 Offset: 0x2C19060 VA: 0x182C1A660 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x2C1A640 Offset: 0x2C19040 VA: 0x182C1A640 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x2C08ED0 Offset: 0x2C078D0 VA: 0x182C08ED0 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x2C08DF0 Offset: 0x2C077F0 VA: 0x182C08DF0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x2C1A1B0 Offset: 0x2C18BB0 VA: 0x182C1A1B0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x2C03E40 Offset: 0x2C02840 VA: 0x182C03E40 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x2C11910 Offset: 0x2C10310 VA: 0x182C11910
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x2C08010 Offset: 0x2C06A10 VA: 0x182C08010 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x2C08160 Offset: 0x2C06B60 VA: 0x182C08160 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x2C03F70 Offset: 0x2C02970 VA: 0x182C03F70 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x2C03F00 Offset: 0x2C02900 VA: 0x182C03F00 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x2C0C6E0 Offset: 0x2C0B0E0 VA: 0x182C0C6E0
	protected void ParseInputText() { }

	// RVA: 0x2C0CBF0 Offset: 0x2C0B5F0 VA: 0x182C0CBF0
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x2C0C9D0 Offset: 0x2C0B3D0 VA: 0x182C0C9D0
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x2C0C8C0 Offset: 0x2C0B2C0 VA: 0x182C0C8C0
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x2C0CAD0 Offset: 0x2C0B4D0 VA: 0x182C0CAD0
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x2C0CCC0 Offset: 0x2C0B6C0 VA: 0x182C0CCC0
	private void PopulateTextProcessingArray() { }

	// RVA: 0x2C11010 Offset: 0x2C0FA10 VA: 0x182C11010
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x2C11450 Offset: 0x2C0FE50 VA: 0x182C11450
	public void SetText(string sourceText) { }

	[Obsolete("Use the SetText(string) function instead.")]
	// RVA: 0x2C11450 Offset: 0x2C0FE50 VA: 0x182C11450
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x2C11750 Offset: 0x2C10150 VA: 0x182C11750
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x2C11110 Offset: 0x2C0FB10 VA: 0x182C11110
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x2C116B0 Offset: 0x2C100B0 VA: 0x182C116B0
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x2C11700 Offset: 0x2C10100 VA: 0x182C11700
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x2C11650 Offset: 0x2C10050 VA: 0x182C11650
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x2C11580 Offset: 0x2C0FF80 VA: 0x182C11580
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x2C115E0 Offset: 0x2C0FFE0 VA: 0x182C115E0
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x2C111A0 Offset: 0x2C0FBA0 VA: 0x182C111A0
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x2C11150 Offset: 0x2C0FB50 VA: 0x182C11150
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x2C117A0 Offset: 0x2C101A0 VA: 0x182C117A0
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x2C10FE0 Offset: 0x2C0F9E0 VA: 0x182C10FE0
	public void SetText(char[] sourceText) { }

	// RVA: 0x2C11790 Offset: 0x2C10190 VA: 0x182C11790
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x2C10FE0 Offset: 0x2C0F9E0 VA: 0x182C10FE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x2C10E60 Offset: 0x2C0F860 VA: 0x182C10E60
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x2C09110 Offset: 0x2C07B10 VA: 0x182C09110
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x2C0B9E0 Offset: 0x2C0A3E0 VA: 0x182C0B9E0
	private void InsertOpeningTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0AEE0 Offset: 0x2C098E0 VA: 0x182C0AEE0
	private void InsertClosingTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0BAA0 Offset: 0x2C0A4A0 VA: 0x182C0BAA0
	private void InsertTextStyleInTextProcessingArray(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition) { }

	// RVA: 0x2C0DEA0 Offset: 0x2C0C8A0 VA: 0x182C0DEA0
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0DCF0 Offset: 0x2C0C6F0 VA: 0x182C0DCF0
	private bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0DC30 Offset: 0x2C0C630 VA: 0x182C0DC30
	private void ReplaceClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0B930 Offset: 0x2C0A330 VA: 0x182C0B930
	private void InsertOpeningStyleTag(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C0AE30 Offset: 0x2C09830 VA: 0x182C0AE30
	private void InsertClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x2C07E60 Offset: 0x2C06860 VA: 0x182C07E60
	private int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x2C07F50 Offset: 0x2C06950 VA: 0x182C07F50
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x2C09020 Offset: 0x2C07A20 VA: 0x182C09020
	private int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x2C08F30 Offset: 0x2C07930 VA: 0x182C08F30
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C160 Offset: 0xF5AB60 VA: 0x180F5C160
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF5C220 Offset: 0xF5AC20 VA: 0x180F5C220
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5C100 Offset: 0xF5AB00 VA: 0x180F5C100
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF5C1C0 Offset: 0xF5ABC0 VA: 0x180F5C1C0
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: 0x2BFF960 Offset: 0x2BFE360 VA: 0x182BFF960
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x2BFFE00 Offset: 0x2BFE800 VA: 0x182BFFE00
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x2C0BED0 Offset: 0x2C0A8D0 VA: 0x182C0BED0
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 114
	internal virtual int SetArraySizes(TMP_Text.TextProcessingElement[] unicodeChars) { }

	// RVA: 0x2C08A70 Offset: 0x2C07470 VA: 0x182C08A70
	public Vector2 GetPreferredValues() { }

	// RVA: 0x2C08640 Offset: 0x2C07040 VA: 0x182C08640
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x2C086B0 Offset: 0x2C070B0 VA: 0x182C086B0
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x2C08860 Offset: 0x2C07260 VA: 0x182C08860
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x2C08AD0 Offset: 0x2C074D0 VA: 0x182C08AD0
	protected float GetPreferredWidth() { }

	// RVA: 0x2C08C90 Offset: 0x2C07690 VA: 0x182C08C90
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x2C08D30 Offset: 0x2C07730 VA: 0x182C08D30
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	// RVA: 0x2C08430 Offset: 0x2C06E30 VA: 0x182C08430
	protected float GetPreferredHeight() { }

	// RVA: 0x2C08370 Offset: 0x2C06D70 VA: 0x182C08370
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x2C08E60 Offset: 0x2C07860 VA: 0x182C08E60
	public Vector2 GetRenderedValues() { }

	// RVA: 0x2C08E20 Offset: 0x2C07820 VA: 0x182C08E20
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x2C08ED0 Offset: 0x2C078D0 VA: 0x182C08ED0
	private float GetRenderedWidth() { }

	// RVA: 0x2C08EA0 Offset: 0x2C078A0 VA: 0x182C08EA0
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x2C08DF0 Offset: 0x2C077F0 VA: 0x182C08DF0
	private float GetRenderedHeight() { }

	// RVA: 0x2C08DC0 Offset: 0x2C077C0 VA: 0x182C08DC0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x2C003B0 Offset: 0x2BFEDB0 VA: 0x182C003B0 Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	// RVA: 0xFD3B50 Offset: 0xFD2550 VA: 0x180FD3B50 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x2C07A70 Offset: 0x2C06470 VA: 0x182C07A70 Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x2C09580 Offset: 0x2C07F80 VA: 0x182C09580
	protected Bounds GetTextBounds() { }

	// RVA: 0x2C09240 Offset: 0x2C07C40 VA: 0x182C09240
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x2BFFF60 Offset: 0x2BFE960 VA: 0x182BFFF60
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x2C0E0A0 Offset: 0x2C0CAA0 VA: 0x182C0E0A0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x2C0AFA0 Offset: 0x2C099A0 VA: 0x182C0AFA0
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x2C10880 Offset: 0x2C0F280 VA: 0x182C10880
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x2C0E2F0 Offset: 0x2C0CCF0 VA: 0x182C0E2F0
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x2C0E910 Offset: 0x2C0D310 VA: 0x182C0E910 Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x2C0FE80 Offset: 0x2C0E880 VA: 0x182C0FE80 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x2C065D0 Offset: 0x2C04FD0 VA: 0x182C065D0 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i) { }

	// RVA: 0x2C057E0 Offset: 0x2C041E0 VA: 0x182C057E0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	// RVA: 0x2C06F10 Offset: 0x2C05910 VA: 0x182C06F10 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i) { }

	// RVA: 0x2C04710 Offset: 0x2C03110 VA: 0x182C04710 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x2C040C0 Offset: 0x2C02AC0 VA: 0x182C040C0 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x2C0C1B0 Offset: 0x2C0ABB0 VA: 0x182C0C1B0
	protected void LoadDefaultSettings() { }

	// RVA: 0x2C08F00 Offset: 0x2C07900 VA: 0x182C08F00
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x2C07AA0 Offset: 0x2C064A0 VA: 0x182C07AA0
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x2C0A300 Offset: 0x2C08D00 VA: 0x182C0A300
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x2C0E040 Offset: 0x2C0CA40 VA: 0x182C0E040
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x2C07DD0 Offset: 0x2C067D0 VA: 0x182C07DD0
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x2C09880 Offset: 0x2C08280 VA: 0x182C09880
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x2C08280 Offset: 0x2C06C80 VA: 0x182C08280 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x2C0BFC0 Offset: 0x2C0A9C0 VA: 0x182C0BFC0
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x2C0DAF0 Offset: 0x2C0C4F0 VA: 0x182C0DAF0
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x2C04010 Offset: 0x2C02A10 VA: 0x182C04010
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	// RVA: 0x2C0C6A0 Offset: 0x2C0B0A0 VA: 0x182C0C6A0
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x2C0C660 Offset: 0x2C0B060 VA: 0x182C0C660
	protected float PackUV(float x, float y) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x2C0AD10 Offset: 0x2C09710 VA: 0x182C0AD10
	protected uint HexToInt(char hex) { }

	// RVA: 0x2C0C0B0 Offset: 0x2C0AAB0 VA: 0x182C0C0B0
	private bool IsValidUTF16(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x2C09E80 Offset: 0x2C08880 VA: 0x182C09E80
	private uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x2C09F50 Offset: 0x2C08950 VA: 0x182C09F50
	private uint GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x2C0C130 Offset: 0x2C0AB30 VA: 0x182C0C130
	private bool IsValidUTF32(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x2C0A020 Offset: 0x2C08A20 VA: 0x182C0A020
	private uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x2C0A1A0 Offset: 0x2C08BA0 VA: 0x182C0A1A0
	private uint GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x2C0A6A0 Offset: 0x2C090A0 VA: 0x182C0A6A0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x2C0A3D0 Offset: 0x2C08DD0 VA: 0x182C0A3D0
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x2C07850 Offset: 0x2C06250 VA: 0x182C07850
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x2C03E10 Offset: 0x2C02810 VA: 0x182C03E10
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x2C03C60 Offset: 0x2C02660 VA: 0x182C03C60
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x2C03B80 Offset: 0x2C02580 VA: 0x182C03B80
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x2C119C0 Offset: 0x2C103C0 VA: 0x182C119C0
	internal bool ValidateHtmlTag(TMP_Text.TextProcessingElement[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x2C18B70 Offset: 0x2C17570 VA: 0x182C18B70
	protected void .ctor() { }

	// RVA: 0x2C18570 Offset: 0x2C16F70 VA: 0x182C18570
	private static void .cctor() { }
}
