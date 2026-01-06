internal class StylePropertyReader // TypeDefIndex: 7170
{
	// Fields
	internal static StylePropertyReader.GetCursorIdFunction getCursorIdFunc; // 0x0
	private List<StylePropertyValue> m_Values; // 0x10
	private List<int> m_ValueCount; // 0x18
	private StyleVariableResolver m_Resolver; // 0x20
	private StyleSheet m_Sheet; // 0x28
	private StyleProperty[] m_Properties; // 0x30
	private StylePropertyId[] m_PropertyIds; // 0x38
	private int m_CurrentValueIndex; // 0x40
	private int m_CurrentPropertyIndex; // 0x44
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleProperty <property>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StylePropertyId <propertyId>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <valueCount>k__BackingField; // 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <dpiScaling>k__BackingField; // 0x58

	// Properties
	public StyleProperty property { get; set; }
	public StylePropertyId propertyId { get; set; }
	public int valueCount { get; set; }
	public float dpiScaling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public StyleProperty get_property() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_property(StyleProperty value) { }

	[CompilerGenerated]
	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public StylePropertyId get_propertyId() { }

	[CompilerGenerated]
	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	private void set_propertyId(StylePropertyId value) { }

	[CompilerGenerated]
	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_valueCount() { }

	[CompilerGenerated]
	// RVA: 0xD80F50 Offset: 0xD7F950 VA: 0x180D80F50
	private void set_valueCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_dpiScaling() { }

	[CompilerGenerated]
	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	private void set_dpiScaling(float value) { }

	// RVA: 0x2E3ABD0 Offset: 0x2E395D0 VA: 0x182E3ABD0
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1) { }

	// RVA: 0x2E3ADA0 Offset: 0x2E397A0 VA: 0x182E3ADA0
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1) { }

	// RVA: 0x2E371C0 Offset: 0x2E35BC0 VA: 0x182E371C0
	public StylePropertyId MoveNextProperty() { }

	// RVA: 0x2E36C00 Offset: 0x2E35600 VA: 0x182E36C00
	public StylePropertyValue GetValue(int index) { }

	// RVA: 0x2E36B80 Offset: 0x2E35580 VA: 0x182E36B80
	public StyleValueType GetValueType(int index) { }

	// RVA: 0x2E36D20 Offset: 0x2E35720 VA: 0x182E36D20
	public bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x2E36C80 Offset: 0x2E35680 VA: 0x182E36C80
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x2E372F0 Offset: 0x2E35CF0 VA: 0x182E372F0
	public string ReadAsString(int index) { }

	// RVA: 0x2E38FE0 Offset: 0x2E379E0 VA: 0x182E38FE0
	public Length ReadLength(int index) { }

	// RVA: 0x2E3A1A0 Offset: 0x2E38BA0 VA: 0x182E3A1A0
	public TimeValue ReadTimeValue(int index) { }

	// RVA: 0x2E3A7A0 Offset: 0x2E391A0 VA: 0x182E3A7A0
	public Translate ReadTranslate(int index) { }

	// RVA: 0x2E3A3A0 Offset: 0x2E38DA0 VA: 0x182E3A3A0
	public TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x2E39810 Offset: 0x2E38210 VA: 0x182E39810
	public Rotate ReadRotate(int index) { }

	// RVA: 0x2E39CB0 Offset: 0x2E386B0 VA: 0x182E39CB0
	public Scale ReadScale(int index) { }

	// RVA: 0x2E386D0 Offset: 0x2E370D0 VA: 0x182E386D0
	public float ReadFloat(int index) { }

	// RVA: 0x2E38F60 Offset: 0x2E37960 VA: 0x182E38F60
	public int ReadInt(int index) { }

	// RVA: 0x2E38020 Offset: 0x2E36A20 VA: 0x182E38020
	public Color ReadColor(int index) { }

	// RVA: 0x2E385D0 Offset: 0x2E36FD0 VA: 0x182E385D0
	public int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x2E38750 Offset: 0x2E37150 VA: 0x182E38750
	public FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x2E38C60 Offset: 0x2E37660 VA: 0x182E38C60
	public Font ReadFont(int index) { }

	// RVA: 0x2E37DB0 Offset: 0x2E367B0 VA: 0x182E37DB0
	public Background ReadBackground(int index) { }

	// RVA: 0x2E38140 Offset: 0x2E36B40 VA: 0x182E38140
	public Cursor ReadCursor(int index) { }

	// RVA: 0x2E39E00 Offset: 0x2E38800 VA: 0x182E39E00
	public TextShadow ReadTextShadow(int index) { }

	// RVA: 0x2E37360 Offset: 0x2E35D60 VA: 0x182E37360
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x2E373A0 Offset: 0x2E35DA0 VA: 0x182E373A0
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x2E373E0 Offset: 0x2E35DE0 VA: 0x182E373E0
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x2E376E0 Offset: 0x2E360E0 VA: 0x182E376E0
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x2E37A70 Offset: 0x2E36470 VA: 0x182E37A70
	public BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x2E390E0 Offset: 0x2E37AE0 VA: 0x182E390E0
	public void ReadListEasingFunction(List<EasingFunction> list, int index) { }

	// RVA: 0x2E394C0 Offset: 0x2E37EC0 VA: 0x182E394C0
	public void ReadListTimeValue(List<TimeValue> list, int index) { }

	// RVA: 0x2E392E0 Offset: 0x2E37CE0 VA: 0x182E392E0
	public void ReadListStylePropertyName(List<StylePropertyName> list, int index) { }

	// RVA: 0x2E36DB0 Offset: 0x2E357B0 VA: 0x182E36DB0
	private void LoadProperties() { }

	// RVA: 0x2E3ACD0 Offset: 0x2E396D0 VA: 0x182E3ACD0
	private void SetCurrentProperty() { }

	// RVA: 0x2E3A500 Offset: 0x2E38F00 VA: 0x182E3A500
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x2E3A250 Offset: 0x2E38C50 VA: 0x182E3A250
	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	// RVA: 0x2E3A900 Offset: 0x2E39300 VA: 0x182E3A900
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x2E39AA0 Offset: 0x2E384A0 VA: 0x182E39AA0
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x2E39670 Offset: 0x2E38070 VA: 0x182E39670
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x2E3B690 Offset: 0x2E3A090 VA: 0x182E3B690
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

	// RVA: 0x2E38500 Offset: 0x2E36F00 VA: 0x182E38500
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x2E371F0 Offset: 0x2E35BF0 VA: 0x182E371F0
	public static Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x2E374F0 Offset: 0x2E35EF0 VA: 0x182E374F0
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x2E378D0 Offset: 0x2E362D0 VA: 0x182E378D0
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x2E37B60 Offset: 0x2E36560 VA: 0x182E37B60
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x2E3AE10 Offset: 0x2E39810 VA: 0x182E3AE10
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	// RVA: 0x2E3B760 Offset: 0x2E3A160 VA: 0x182E3B760
	public void .ctor() { }
}
