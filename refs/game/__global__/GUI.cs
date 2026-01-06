public class GUI // TypeDefIndex: 17588
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { get; set; }
	public static Color contentColor { get; set; }
	public static bool changed { get; set; }
	public static bool enabled { get; set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x2D1BF80 Offset: 0x2D1A980 VA: 0x182D1BF80
	public static Color get_color() { }

	// RVA: 0x2D1C490 Offset: 0x2D1AE90 VA: 0x182D1C490
	public static void set_color(Color value) { }

	// RVA: 0x2D1BE40 Offset: 0x2D1A840 VA: 0x182D1BE40
	public static Color get_backgroundColor() { }

	// RVA: 0x2D1C3A0 Offset: 0x2D1ADA0 VA: 0x182D1C3A0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x2D1C030 Offset: 0x2D1AA30 VA: 0x182D1C030
	public static Color get_contentColor() { }

	// RVA: 0x2D1C540 Offset: 0x2D1AF40 VA: 0x182D1C540
	public static void set_contentColor(Color value) { }

	// RVA: 0x2D1BF10 Offset: 0x2D1A910 VA: 0x182D1BF10
	public static bool get_changed() { }

	// RVA: 0x2D1C410 Offset: 0x2D1AE10 VA: 0x182D1C410
	public static void set_changed(bool value) { }

	// RVA: 0x2D1C0A0 Offset: 0x2D1AAA0 VA: 0x182D1C0A0
	public static bool get_enabled() { }

	// RVA: 0x2D1C5B0 Offset: 0x2D1AFB0 VA: 0x182D1C5B0
	public static void set_enabled(bool value) { }

	// RVA: 0x2D1C330 Offset: 0x2D1AD30 VA: 0x182D1C330
	internal static bool get_usePageScrollbars() { }

	[FreeFunction("GetGUIBlendMaterial")]
	// RVA: 0x2D1BEB0 Offset: 0x2D1A8B0 VA: 0x182D1BEB0
	internal static Material get_blendMaterial() { }

	[FreeFunction("GetGUIBlitMaterial")]
	// RVA: 0x2D1BEE0 Offset: 0x2D1A8E0 VA: 0x182D1BEE0
	internal static Material get_blitMaterial() { }

	[FreeFunction("GetGUIRoundedRectMaterial")]
	// RVA: 0x2D1C1B0 Offset: 0x2D1ABB0 VA: 0x182D1C1B0
	internal static Material get_roundedRectMaterial() { }

	[FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")]
	// RVA: 0x2D1C1E0 Offset: 0x2D1ABE0 VA: 0x182D1C1E0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x2D19FA0 Offset: 0x2D189A0 VA: 0x182D19FA0
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x2D19FE0 Offset: 0x2D189E0 VA: 0x182D19FE0
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x2D1A7A0 Offset: 0x2D191A0 VA: 0x182D1A7A0
	internal static void ReleaseMouseControl() { }

	[FreeFunction("GetGUIState().SetNameOfNextControl")]
	// RVA: 0x2D1B370 Offset: 0x2D19D70 VA: 0x182D1B370
	public static void SetNextControlName(string name) { }

	// RVA: 0x2D1A4B0 Offset: 0x2D18EB0 VA: 0x182D1A4B0
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x2D1BAF0 Offset: 0x2D1A4F0 VA: 0x182D1BAF0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2D1C210 Offset: 0x2D1AC10 VA: 0x182D1C210
	internal static int get_scrollTroughSide() { }

	[CompilerGenerated]
	// RVA: 0x2D1C6B0 Offset: 0x2D1B0B0 VA: 0x182D1C6B0
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGenerated]
	// RVA: 0x2D1C160 Offset: 0x2D1AB60 VA: 0x182D1C160
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGenerated]
	// RVA: 0x2D1C650 Offset: 0x2D1B050 VA: 0x182D1C650
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x2D1C710 Offset: 0x2D1B110 VA: 0x182D1C710
	public static void set_skin(GUISkin value) { }

	// RVA: 0x2D1C2B0 Offset: 0x2D1ACB0 VA: 0x182D1C2B0
	public static GUISkin get_skin() { }

	// RVA: 0x2D176E0 Offset: 0x2D160E0 VA: 0x182D176E0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x2D1C0D0 Offset: 0x2D1AAD0 VA: 0x182D1C0D0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x2D1C5F0 Offset: 0x2D1AFF0 VA: 0x182D1C5F0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x2D1A5E0 Offset: 0x2D18FE0 VA: 0x182D1A5E0
	public static void Label(Rect position, string text) { }

	// RVA: 0x2D1A4E0 Offset: 0x2D18EE0 VA: 0x182D1A4E0
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x2D1A700 Offset: 0x2D19100 VA: 0x182D1A700
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D18DB0 Offset: 0x2D177B0 VA: 0x182D18DB0
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x2D18C40 Offset: 0x2D17640 VA: 0x182D18C40
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x2D17A50 Offset: 0x2D16450 VA: 0x182D17A50
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x2D187F0 Offset: 0x2D171F0 VA: 0x182D187F0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x2D18910 Offset: 0x2D17310 VA: 0x182D18910
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x2D17BA0 Offset: 0x2D165A0 VA: 0x182D17BA0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x2D18670 Offset: 0x2D17070 VA: 0x182D18670
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x2D18520 Offset: 0x2D16F20 VA: 0x182D18520
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x2D17DF0 Offset: 0x2D167F0 VA: 0x182D17DF0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x2D15570 Offset: 0x2D13F70 VA: 0x182D15570
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x2D14A10 Offset: 0x2D13410 VA: 0x182D14A10
	public static void Box(Rect position, string text) { }

	// RVA: 0x2D14960 Offset: 0x2D13360 VA: 0x182D14960
	public static void Box(Rect position, string text, GUIStyle style) { }

	// RVA: 0x2D14760 Offset: 0x2D13160 VA: 0x182D14760
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D14AD0 Offset: 0x2D134D0 VA: 0x182D14AD0
	public static bool Button(Rect position, string text) { }

	// RVA: 0x2D14B90 Offset: 0x2D13590 VA: 0x182D14B90
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D14E10 Offset: 0x2D13810 VA: 0x182D14E10
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D171D0 Offset: 0x2D15BD0 VA: 0x182D171D0
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x2D1B590 Offset: 0x2D19F90 VA: 0x182D1B590
	public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D1B280 Offset: 0x2D19C80 VA: 0x182D1B280
	public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { }

	// RVA: 0x2D153D0 Offset: 0x2D13DD0 VA: 0x182D153D0
	internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle) { }

	// RVA: 0x2D16970 Offset: 0x2D15370 VA: 0x182D16970
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D16DE0 Offset: 0x2D157E0 VA: 0x182D16DE0
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D17900 Offset: 0x2D16300 VA: 0x182D17900
	internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D16830 Offset: 0x2D15230 VA: 0x182D16830
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D15A00 Offset: 0x2D14400 VA: 0x182D15A00
	private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int itemsPerRow, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled) { }

	// RVA: 0x2D15010 Offset: 0x2D13A10 VA: 0x182D15010
	private static Rect[] CalcGridRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize) { }

	// RVA: 0x2D1A390 Offset: 0x2D18D90 VA: 0x182D1A390
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { }

	// RVA: 0x2D1A2C0 Offset: 0x2D18CC0 VA: 0x182D1A2C0
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x2D1B3B0 Offset: 0x2D19DB0 VA: 0x182D1B3B0
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x2D1A020 Offset: 0x2D18A20 VA: 0x182D1A020
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x2D1A7D0 Offset: 0x2D191D0 VA: 0x182D1A7D0
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x2D1B850 Offset: 0x2D1A250 VA: 0x182D1B850
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x2D1AAF0 Offset: 0x2D194F0 VA: 0x182D1AAF0
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x2D13790 Offset: 0x2D12190 VA: 0x182D13790
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x2D13400 Offset: 0x2D11E00 VA: 0x182D13400
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x2D18F40 Offset: 0x2D17940 VA: 0x182D18F40
	public static void EndGroup() { }

	[CompilerGenerated]
	// RVA: 0x2D1C260 Offset: 0x2D1AC60 VA: 0x182D1C260
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x2D13860 Offset: 0x2D12260 VA: 0x182D13860
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x2D18FB0 Offset: 0x2D179B0 VA: 0x182D18FB0
	public static void EndScrollView(bool handleScrollWheel) { }

	[RequiredByNativeCode]
	// RVA: 0x2D15720 Offset: 0x2D14120 VA: 0x182D15720
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x2D1BF40 Offset: 0x2D1A940 VA: 0x182D1BF40
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x2D1C450 Offset: 0x2D1AE50 VA: 0x182D1C450
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x2D1BE00 Offset: 0x2D1A800 VA: 0x182D1BE00
	private static void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2D1C360 Offset: 0x2D1AD60 VA: 0x182D1C360
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2D1BFF0 Offset: 0x2D1A9F0 VA: 0x182D1BFF0
	private static void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x2D1C500 Offset: 0x2D1AF00 VA: 0x182D1C500
	private static void set_contentColor_Injected(ref Color value) { }
}
