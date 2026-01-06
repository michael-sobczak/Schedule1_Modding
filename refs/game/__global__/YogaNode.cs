internal class YogaNode : IEnumerable<YogaNode>, IEnumerable // TypeDefIndex: 6155
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private YogaConfig _config; // 0x18
	private WeakReference _parent; // 0x20
	private List<YogaNode> _children; // 0x28
	private MeasureFunction _measureFunction; // 0x30
	private BaselineFunction _baselineFunction; // 0x38
	private object _data; // 0x40

	// Properties
	internal YogaConfig Config { set; }
	public bool IsDirty { get; }
	public bool HasNewLayout { get; }
	public bool IsMeasureDefined { get; }
	public bool IsBaselineDefined { get; }
	public YogaFlexDirection FlexDirection { set; }
	public YogaJustify JustifyContent { set; }
	public YogaDisplay Display { set; }
	public YogaAlign AlignItems { set; }
	public YogaAlign AlignSelf { set; }
	public YogaAlign AlignContent { set; }
	public YogaPositionType PositionType { set; }
	public YogaWrap Wrap { set; }
	public float Flex { set; }
	public float FlexGrow { set; }
	public float FlexShrink { set; }
	public YogaValue FlexBasis { set; }
	public YogaValue Width { set; }
	public YogaValue Height { set; }
	public YogaValue MaxWidth { set; }
	public YogaValue MaxHeight { set; }
	public YogaValue MinWidth { set; }
	public YogaValue MinHeight { set; }
	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutRight { get; }
	public float LayoutBottom { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }
	public YogaOverflow Overflow { set; }
	public int Count { get; }
	public YogaValue Left { set; }
	public YogaValue Top { set; }
	public YogaValue Right { set; }
	public YogaValue Bottom { set; }
	public YogaValue MarginLeft { set; }
	public YogaValue MarginTop { set; }
	public YogaValue MarginRight { set; }
	public YogaValue MarginBottom { set; }
	public YogaValue PaddingLeft { set; }
	public YogaValue PaddingTop { set; }
	public YogaValue PaddingRight { set; }
	public YogaValue PaddingBottom { set; }
	public float BorderLeftWidth { set; }
	public float BorderTopWidth { set; }
	public float BorderRightWidth { set; }
	public float BorderBottomWidth { set; }
	public float LayoutMarginLeft { get; }
	public float LayoutMarginTop { get; }
	public float LayoutMarginRight { get; }
	public float LayoutMarginBottom { get; }
	public float LayoutPaddingLeft { get; }
	public float LayoutPaddingTop { get; }
	public float LayoutPaddingRight { get; }
	public float LayoutPaddingBottom { get; }
	public float LayoutBorderLeft { get; }
	public float LayoutBorderTop { get; }
	public float LayoutBorderRight { get; }
	public float LayoutBorderBottom { get; }

	// Methods

	// RVA: 0x2DBF6D0 Offset: 0x2DBE0D0 VA: 0x182DBF6D0
	public void .ctor(YogaConfig config) { }

	// RVA: 0x2DBEF80 Offset: 0x2DBD980 VA: 0x182DBEF80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2DC0000 Offset: 0x2DBEA00 VA: 0x182DC0000
	internal void set_Config(YogaConfig value) { }

	// RVA: 0x2DBF890 Offset: 0x2DBE290 VA: 0x182DBF890
	public bool get_IsDirty() { }

	// RVA: 0x2DBF1C0 Offset: 0x2DBDBC0 VA: 0x182DBF1C0 Slot: 6
	public virtual void MarkDirty() { }

	// RVA: 0x2DBF840 Offset: 0x2DBE240 VA: 0x182DBF840
	public bool get_HasNewLayout() { }

	// RVA: 0x2DBF8D0 Offset: 0x2DBE2D0 VA: 0x182DBF8D0
	public bool get_IsMeasureDefined() { }

	// RVA: 0x2DBF880 Offset: 0x2DBE280 VA: 0x182DBF880
	public bool get_IsBaselineDefined() { }

	// RVA: 0x2DBEF30 Offset: 0x2DBD930 VA: 0x182DBEF30
	public void CopyStyle(YogaNode srcNode) { }

	// RVA: 0x2DC01D0 Offset: 0x2DBEBD0 VA: 0x182DC01D0
	public void set_FlexDirection(YogaFlexDirection value) { }

	// RVA: 0x2DC03C0 Offset: 0x2DBEDC0 VA: 0x182DC03C0
	public void set_JustifyContent(YogaJustify value) { }

	// RVA: 0x2DC00D0 Offset: 0x2DBEAD0 VA: 0x182DC00D0
	public void set_Display(YogaDisplay value) { }

	// RVA: 0x2DBFDB0 Offset: 0x2DBE7B0 VA: 0x182DBFDB0
	public void set_AlignItems(YogaAlign value) { }

	// RVA: 0x2DBFE00 Offset: 0x2DBE800 VA: 0x182DBFE00
	public void set_AlignSelf(YogaAlign value) { }

	// RVA: 0x2DBFD60 Offset: 0x2DBE760 VA: 0x182DBFD60
	public void set_AlignContent(YogaAlign value) { }

	// RVA: 0x2DC08F0 Offset: 0x2DBF2F0 VA: 0x182DC08F0
	public void set_PositionType(YogaPositionType value) { }

	// RVA: 0x2DC0AD0 Offset: 0x2DBF4D0 VA: 0x182DC0AD0
	public void set_Wrap(YogaWrap value) { }

	// RVA: 0x2DC02C0 Offset: 0x2DBECC0 VA: 0x182DC02C0
	public void set_Flex(float value) { }

	// RVA: 0x2DC0220 Offset: 0x2DBEC20 VA: 0x182DC0220
	public void set_FlexGrow(float value) { }

	// RVA: 0x2DC0270 Offset: 0x2DBEC70 VA: 0x182DC0270
	public void set_FlexShrink(float value) { }

	// RVA: 0x2DC0120 Offset: 0x2DBEB20 VA: 0x182DC0120
	public void set_FlexBasis(YogaValue value) { }

	// RVA: 0x2DC0A20 Offset: 0x2DBF420 VA: 0x182DC0A20
	public void set_Width(YogaValue value) { }

	// RVA: 0x2DC0310 Offset: 0x2DBED10 VA: 0x182DC0310
	public void set_Height(YogaValue value) { }

	// RVA: 0x2DC0550 Offset: 0x2DBEF50 VA: 0x182DC0550
	public void set_MaxWidth(YogaValue value) { }

	// RVA: 0x2DC04D0 Offset: 0x2DBEED0 VA: 0x182DC04D0
	public void set_MaxHeight(YogaValue value) { }

	// RVA: 0x2DC0650 Offset: 0x2DBF050 VA: 0x182DC0650
	public void set_MinWidth(YogaValue value) { }

	// RVA: 0x2DC05D0 Offset: 0x2DBEFD0 VA: 0x182DC05D0
	public void set_MinHeight(YogaValue value) { }

	// RVA: 0x2DBFCE0 Offset: 0x2DBE6E0 VA: 0x182DBFCE0
	public float get_LayoutX() { }

	// RVA: 0x2DBFD20 Offset: 0x2DBE720 VA: 0x182DBFD20
	public float get_LayoutY() { }

	// RVA: 0x2DBFC60 Offset: 0x2DBE660 VA: 0x182DBFC60
	public float get_LayoutRight() { }

	// RVA: 0x2DBF9E0 Offset: 0x2DBE3E0 VA: 0x182DBF9E0
	public float get_LayoutBottom() { }

	// RVA: 0x2DBFCA0 Offset: 0x2DBE6A0 VA: 0x182DBFCA0
	public float get_LayoutWidth() { }

	// RVA: 0x2DBFA20 Offset: 0x2DBE420 VA: 0x182DBFA20
	public float get_LayoutHeight() { }

	// RVA: 0x2DC06D0 Offset: 0x2DBF0D0 VA: 0x182DC06D0
	public void set_Overflow(YogaOverflow value) { }

	// RVA: 0x2DBF7F0 Offset: 0x2DBE1F0 VA: 0x182DBF7F0
	public int get_Count() { }

	// RVA: 0x2DBF200 Offset: 0x2DBDC00 VA: 0x182DBF200
	public void MarkLayoutSeen() { }

	// RVA: 0x2DBF080 Offset: 0x2DBDA80 VA: 0x182DBF080
	public void Insert(int index, YogaNode node) { }

	// RVA: 0x2DBF2E0 Offset: 0x2DBDCE0 VA: 0x182DBF2E0
	public void RemoveAt(int index) { }

	// RVA: 0x2DBEE00 Offset: 0x2DBD800 VA: 0x182DBEE00
	public void Clear() { }

	// RVA: 0x2DBF3B0 Offset: 0x2DBDDB0 VA: 0x182DBF3B0
	public void SetMeasureFunction(MeasureFunction measureFunction) { }

	// RVA: 0x2DBED70 Offset: 0x2DBD770 VA: 0x182DBED70
	public void CalculateLayout(float width = NaN, float height = NaN) { }

	// RVA: 0x2DBF240 Offset: 0x2DBDC40 VA: 0x182DBF240
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x2DBECE0 Offset: 0x2DBD6E0 VA: 0x182DBECE0
	public static float BaselineInternal(YogaNode node, float width, float height) { }

	// RVA: 0x2DBF010 Offset: 0x2DBDA10 VA: 0x182DBF010 Slot: 4
	public IEnumerator<YogaNode> GetEnumerator() { }

	// RVA: 0x2DBF660 Offset: 0x2DBE060 VA: 0x182DBF660 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2DC0410 Offset: 0x2DBEE10 VA: 0x182DC0410
	public void set_Left(YogaValue value) { }

	// RVA: 0x2DC09B0 Offset: 0x2DBF3B0 VA: 0x182DC09B0
	public void set_Top(YogaValue value) { }

	// RVA: 0x2DC0940 Offset: 0x2DBF340 VA: 0x182DC0940
	public void set_Right(YogaValue value) { }

	// RVA: 0x2DBFF90 Offset: 0x2DBE990 VA: 0x182DBFF90
	public void set_Bottom(YogaValue value) { }

	// RVA: 0x2DBF5E0 Offset: 0x2DBDFE0 VA: 0x182DBF5E0
	private void SetStylePosition(YogaEdge edge, YogaValue value) { }

	// RVA: 0x2DC04A0 Offset: 0x2DBEEA0 VA: 0x182DC04A0
	public void set_MarginLeft(YogaValue value) { }

	// RVA: 0x2DC04C0 Offset: 0x2DBEEC0 VA: 0x182DC04C0
	public void set_MarginTop(YogaValue value) { }

	// RVA: 0x2DC04B0 Offset: 0x2DBEEB0 VA: 0x182DC04B0
	public void set_MarginRight(YogaValue value) { }

	// RVA: 0x2DC0490 Offset: 0x2DBEE90 VA: 0x182DC0490
	public void set_MarginBottom(YogaValue value) { }

	// RVA: 0x2DBF4A0 Offset: 0x2DBDEA0 VA: 0x182DBF4A0
	private void SetStyleMargin(YogaEdge edge, YogaValue value) { }

	// RVA: 0x2DC0790 Offset: 0x2DBF190 VA: 0x182DC0790
	public void set_PaddingLeft(YogaValue value) { }

	// RVA: 0x2DC0880 Offset: 0x2DBF280 VA: 0x182DC0880
	public void set_PaddingTop(YogaValue value) { }

	// RVA: 0x2DC0810 Offset: 0x2DBF210 VA: 0x182DC0810
	public void set_PaddingRight(YogaValue value) { }

	// RVA: 0x2DC0720 Offset: 0x2DBF120 VA: 0x182DC0720
	public void set_PaddingBottom(YogaValue value) { }

	// RVA: 0x2DBF560 Offset: 0x2DBDF60 VA: 0x182DBF560
	private void SetStylePadding(YogaEdge edge, YogaValue value) { }

	// RVA: 0x2DBFEA0 Offset: 0x2DBE8A0 VA: 0x182DBFEA0
	public void set_BorderLeftWidth(float value) { }

	// RVA: 0x2DBFF40 Offset: 0x2DBE940 VA: 0x182DBFF40
	public void set_BorderTopWidth(float value) { }

	// RVA: 0x2DBFEF0 Offset: 0x2DBE8F0 VA: 0x182DBFEF0
	public void set_BorderRightWidth(float value) { }

	// RVA: 0x2DBFE50 Offset: 0x2DBE850 VA: 0x182DBFE50
	public void set_BorderBottomWidth(float value) { }

	// RVA: 0x2DBFAA0 Offset: 0x2DBE4A0 VA: 0x182DBFAA0
	public float get_LayoutMarginLeft() { }

	// RVA: 0x2DBFB20 Offset: 0x2DBE520 VA: 0x182DBFB20
	public float get_LayoutMarginTop() { }

	// RVA: 0x2DBFAE0 Offset: 0x2DBE4E0 VA: 0x182DBFAE0
	public float get_LayoutMarginRight() { }

	// RVA: 0x2DBFA60 Offset: 0x2DBE460 VA: 0x182DBFA60
	public float get_LayoutMarginBottom() { }

	// RVA: 0x2DBFBA0 Offset: 0x2DBE5A0 VA: 0x182DBFBA0
	public float get_LayoutPaddingLeft() { }

	// RVA: 0x2DBFC20 Offset: 0x2DBE620 VA: 0x182DBFC20
	public float get_LayoutPaddingTop() { }

	// RVA: 0x2DBFBE0 Offset: 0x2DBE5E0 VA: 0x182DBFBE0
	public float get_LayoutPaddingRight() { }

	// RVA: 0x2DBFB60 Offset: 0x2DBE560 VA: 0x182DBFB60
	public float get_LayoutPaddingBottom() { }

	// RVA: 0x2DBF920 Offset: 0x2DBE320 VA: 0x182DBF920
	public float get_LayoutBorderLeft() { }

	// RVA: 0x2DBF9A0 Offset: 0x2DBE3A0 VA: 0x182DBF9A0
	public float get_LayoutBorderTop() { }

	// RVA: 0x2DBF960 Offset: 0x2DBE360 VA: 0x182DBF960
	public float get_LayoutBorderRight() { }

	// RVA: 0x2DBF8E0 Offset: 0x2DBE2E0 VA: 0x182DBF8E0
	public float get_LayoutBorderBottom() { }
}
