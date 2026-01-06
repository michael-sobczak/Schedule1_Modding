public sealed class GUIStyle // TypeDefIndex: 17607
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { set; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; set; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; set; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_FontSize", False, 1)]
	public int fontSize { get; set; }
	[NativeProperty("m_FontStyle", False, 1)]
	public FontStyle fontStyle { set; }
	[NativeProperty("m_RichText", False, 1)]
	public bool richText { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset border { set; }
	public RectOffset margin { get; set; }
	public RectOffset padding { get; set; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x2D109F0 Offset: 0x2D0F3F0 VA: 0x182D109F0
	internal string get_rawName() { }

	// RVA: 0x2D10E20 Offset: 0x2D0F820 VA: 0x182D10E20
	internal void set_rawName(string value) { }

	// RVA: 0x2D10CC0 Offset: 0x2D0F6C0 VA: 0x182D10CC0
	public void set_font(Font value) { }

	// RVA: 0x2D105D0 Offset: 0x2D0EFD0 VA: 0x182D105D0
	public ImagePosition get_imagePosition() { }

	// RVA: 0x2D10AB0 Offset: 0x2D0F4B0 VA: 0x182D10AB0
	public bool get_wordWrap() { }

	// RVA: 0x2D10F60 Offset: 0x2D0F960 VA: 0x182D10F60
	public void set_wordWrap(bool value) { }

	// RVA: 0x2D10550 Offset: 0x2D0EF50 VA: 0x182D10550
	public float get_fixedWidth() { }

	// RVA: 0x2D10510 Offset: 0x2D0EF10 VA: 0x182D10510
	public float get_fixedHeight() { }

	// RVA: 0x2D10A70 Offset: 0x2D0F470 VA: 0x182D10A70
	public bool get_stretchWidth() { }

	// RVA: 0x2D10F10 Offset: 0x2D0F910 VA: 0x182D10F10
	public void set_stretchWidth(bool value) { }

	// RVA: 0x2D10A30 Offset: 0x2D0F430 VA: 0x182D10A30
	public bool get_stretchHeight() { }

	// RVA: 0x2D10EC0 Offset: 0x2D0F8C0 VA: 0x182D10EC0
	public void set_stretchHeight(bool value) { }

	// RVA: 0x2D10590 Offset: 0x2D0EF90 VA: 0x182D10590
	public int get_fontSize() { }

	// RVA: 0x2D10C40 Offset: 0x2D0F640 VA: 0x182D10C40
	public void set_fontSize(int value) { }

	// RVA: 0x2D10C80 Offset: 0x2D0F680 VA: 0x182D10C80
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2D10E70 Offset: 0x2D0F870 VA: 0x182D10E70
	public void set_richText(bool value) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x2D0FEB0 Offset: 0x2D0E8B0 VA: 0x182D0FEB0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	// RVA: 0x2D0FE60 Offset: 0x2D0E860 VA: 0x182D0FE60
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x2D0FEF0 Offset: 0x2D0E8F0 VA: 0x182D0FEF0
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2D0FC90 Offset: 0x2D0E690 VA: 0x182D0FC90
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x2D0FC50 Offset: 0x2D0E650 VA: 0x182D0FC50
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = True)]
	// RVA: 0x2D0F460 Offset: 0x2D0DE60 VA: 0x182D0F460
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	// RVA: 0x2D100A0 Offset: 0x2D0EAA0 VA: 0x182D100A0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	// RVA: 0x2D0FFA0 Offset: 0x2D0E9A0 VA: 0x182D0FFA0
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	// RVA: 0x2D0F5F0 Offset: 0x2D0DFF0 VA: 0x182D0F5F0
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	// RVA: 0x2D0F590 Offset: 0x2D0DF90 VA: 0x182D0F590
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	// RVA: 0x2D0F4B0 Offset: 0x2D0DEB0 VA: 0x182D0F4B0
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	// RVA: 0x2D0FD30 Offset: 0x2D0E730 VA: 0x182D0FD30
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	// RVA: 0x2D10200 Offset: 0x2D0EC00 VA: 0x182D10200
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	// RVA: 0x2D10130 Offset: 0x2D0EB30 VA: 0x182D10130
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x2D10170 Offset: 0x2D0EB70 VA: 0x182D10170
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x2D10490 Offset: 0x2D0EE90 VA: 0x182D10490
	public void .ctor() { }

	// RVA: 0x2D103C0 Offset: 0x2D0EDC0 VA: 0x182D103C0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x2D0FB80 Offset: 0x2D0E580 VA: 0x182D0FB80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D10760 Offset: 0x2D0F160 VA: 0x182D10760
	public string get_name() { }

	// RVA: 0x2D10D70 Offset: 0x2D0F770 VA: 0x182D10D70
	public void set_name(string value) { }

	// RVA: 0x2D10880 Offset: 0x2D0F280 VA: 0x182D10880
	public GUIStyleState get_normal() { }

	// RVA: 0x2D10BE0 Offset: 0x2D0F5E0 VA: 0x182D10BE0
	public void set_border(RectOffset value) { }

	// RVA: 0x2D106B0 Offset: 0x2D0F0B0 VA: 0x182D106B0
	public RectOffset get_margin() { }

	// RVA: 0x2D10D10 Offset: 0x2D0F710 VA: 0x182D10D10
	public void set_margin(RectOffset value) { }

	// RVA: 0x2D10940 Offset: 0x2D0F340 VA: 0x182D10940
	public RectOffset get_padding() { }

	// RVA: 0x2D10DC0 Offset: 0x2D0F7C0 VA: 0x182D10DC0
	public void set_padding(RectOffset value) { }

	// RVA: 0x2D0F7C0 Offset: 0x2D0E1C0 VA: 0x182D0F7C0
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D0F730 Offset: 0x2D0E130 VA: 0x182D0F730
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D0F8A0 Offset: 0x2D0E2A0 VA: 0x182D0F8A0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x2D0F960 Offset: 0x2D0E360 VA: 0x182D0F960
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x2D0F650 Offset: 0x2D0E050 VA: 0x182D0F650
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D10AF0 Offset: 0x2D0F4F0 VA: 0x182D10AF0
	public static GUIStyle op_Implicit(string str) { }

	// RVA: 0x2D107C0 Offset: 0x2D0F1C0 VA: 0x182D107C0
	public static GUIStyle get_none() { }

	// RVA: 0x2D0F5F0 Offset: 0x2D0DFF0 VA: 0x182D0F5F0
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x2D0F590 Offset: 0x2D0DF90 VA: 0x182D0F590
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x2D0F4B0 Offset: 0x2D0DEB0 VA: 0x182D0F4B0
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x2D10610 Offset: 0x2D0F010 VA: 0x182D10610
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x2D0F510 Offset: 0x2D0DF10 VA: 0x182D0F510
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x2D10280 Offset: 0x2D0EC80 VA: 0x182D10280 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D10380 Offset: 0x2D0ED80 VA: 0x182D10380
	private static void .cctor() { }

	// RVA: 0x2D10010 Offset: 0x2D0EA10 VA: 0x182D10010
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x2D0FF30 Offset: 0x2D0E930 VA: 0x182D0FF30
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x2D0FE00 Offset: 0x2D0E800 VA: 0x182D0FE00
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x2D0FD90 Offset: 0x2D0E790 VA: 0x182D0FD90
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x2D0FCD0 Offset: 0x2D0E6D0 VA: 0x182D0FCD0
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x2D101B0 Offset: 0x2D0EBB0 VA: 0x182D101B0
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}
