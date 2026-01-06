public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 14933
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	protected RectTransform m_RectTransform; // 0x108
	[SerializeField]
	protected RectTransform m_TextViewport; // 0x110
	protected RectMask2D m_TextComponentRectMask; // 0x118
	protected RectMask2D m_TextViewportRectMask; // 0x120
	[SerializeField]
	protected TMP_Text m_TextComponent; // 0x128
	protected RectTransform m_TextComponentRectTransform; // 0x130
	[SerializeField]
	protected Graphic m_Placeholder; // 0x138
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; // 0x140
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x148
	private bool m_IsDrivenByLayoutComponents; // 0x150
	[SerializeField]
	private LayoutGroup m_LayoutGroup; // 0x158
	private IScrollHandler m_IScrollHandlerParent; // 0x160
	private float m_ScrollPosition; // 0x168
	[SerializeField]
	protected float m_ScrollSensitivity; // 0x16C
	[SerializeField]
	private TMP_InputField.ContentType m_ContentType; // 0x170
	[SerializeField]
	private TMP_InputField.InputType m_InputType; // 0x174
	[SerializeField]
	private char m_AsteriskChar; // 0x178
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x17C
	[SerializeField]
	private TMP_InputField.LineType m_LineType; // 0x180
	[SerializeField]
	private bool m_HideMobileInput; // 0x184
	[SerializeField]
	private bool m_HideSoftKeyboard; // 0x185
	[SerializeField]
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x188
	[SerializeField]
	private string m_RegexValue; // 0x190
	[SerializeField]
	private float m_GlobalPointSize; // 0x198
	[SerializeField]
	private int m_CharacterLimit; // 0x19C
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1A0
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1A8
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1B0
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1B8
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1C0
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1C8
	[SerializeField]
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1D0
	[SerializeField]
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1D8
	[SerializeField]
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1E0
	[SerializeField]
	private Color m_CaretColor; // 0x1E8
	[SerializeField]
	private bool m_CustomCaretColor; // 0x1F8
	[SerializeField]
	private Color m_SelectionColor; // 0x1FC
	[TextArea(5, 10)]
	[SerializeField]
	protected string m_Text; // 0x210
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x218
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x21C
	[SerializeField]
	private bool m_ReadOnly; // 0x220
	[SerializeField]
	private bool m_RichText; // 0x221
	protected int m_StringPosition; // 0x224
	protected int m_StringSelectPosition; // 0x228
	protected int m_CaretPosition; // 0x22C
	protected int m_CaretSelectPosition; // 0x230
	private RectTransform caretRectTrans; // 0x238
	protected UIVertex[] m_CursorVerts; // 0x240
	private CanvasRenderer m_CachedInputRenderer; // 0x248
	private Vector2 m_LastPosition; // 0x250
	protected Mesh m_Mesh; // 0x258
	private bool m_AllowInput; // 0x260
	private bool m_ShouldActivateNextUpdate; // 0x261
	private bool m_UpdateDrag; // 0x262
	private bool m_DragPositionOutOfBounds; // 0x263
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x264
	private Coroutine m_BlinkCoroutine; // 0x268
	private float m_BlinkStartTime; // 0x270
	private Coroutine m_DragCoroutine; // 0x278
	private string m_OriginalText; // 0x280
	private bool m_WasCanceled; // 0x288
	private bool m_HasDoneFocusTransition; // 0x289
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x290
	private bool m_PreventCallback; // 0x298
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x299
	private bool m_IsTextComponentUpdateRequired; // 0x29A
	private bool m_isLastKeyBackspace; // 0x29B
	private float m_PointerDownClickStartTime; // 0x29C
	private float m_KeyDownStartTime; // 0x2A0
	private float m_DoubleClickDelay; // 0x2A4
	private bool m_IsApplePlatform; // 0x2A8
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private bool m_IsCompositionActive; // 0x2A9
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2AA
	private int m_PreviousIMEInsertionLine; // 0x2AC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2B0
	[SerializeField]
	protected bool m_OnFocusSelectAll; // 0x2B8
	protected bool m_isSelectAll; // 0x2B9
	[SerializeField]
	protected bool m_ResetOnDeActivation; // 0x2BA
	private bool m_SelectionStillActive; // 0x2BB
	private bool m_ReleaseSelection; // 0x2BC
	private KeyCode m_LastKeyCode; // 0x2C0
	private GameObject m_PreviouslySelectedObject; // 0x2C8
	[SerializeField]
	private bool m_KeepTextSelectionVisible; // 0x2D0
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; // 0x2D1
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; // 0x2D2
	[SerializeField]
	protected int m_LineLimit; // 0x2D4
	public bool isAlert; // 0x2D8
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; // 0x2E0
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x2E8
	private bool m_isSelected; // 0x2E9
	private bool m_IsStringPositionDirty; // 0x2EA
	private bool m_IsCaretPositionDirty; // 0x2EB
	private bool m_forceRectTransformAdjustment; // 0x2EC
	private bool m_IsKeyboardBeingClosedInHoloLens; // 0x2ED
	private Event m_ProcessingEvent; // 0x2F0

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool keepTextSelectionVisible { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x2BFD540 Offset: 0x2BFBF40 VA: 0x182BFD540
	private BaseInput get_inputSystem() { }

	// RVA: 0x2BFD400 Offset: 0x2BFBE00 VA: 0x182BFD400
	private string get_compositionString() { }

	// RVA: 0x2BFD3D0 Offset: 0x2BFBDD0 VA: 0x182BFD3D0
	private int get_compositionLength() { }

	// RVA: 0x2BFCF40 Offset: 0x2BFB940 VA: 0x182BFCF40
	protected void .ctor() { }

	// RVA: 0x2BFD670 Offset: 0x2BFC070 VA: 0x182BFD670
	protected Mesh get_mesh() { }

	// RVA: 0x2BFF0D0 Offset: 0x2BFDAD0 VA: 0x182BFF0D0 Slot: 61
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x2BFDAE0 Offset: 0x2BFC4E0 VA: 0x182BFDAE0 Slot: 62
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x2BFDB40 Offset: 0x2BFC540 VA: 0x182BFDB40
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x2BFF0E0 Offset: 0x2BFDAE0 VA: 0x182BFF0E0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x2BFDBB0 Offset: 0x2BFC5B0 VA: 0x182BFDBB0
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x2BFF180 Offset: 0x2BFDB80 VA: 0x182BFF180
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x2BFDC50 Offset: 0x2BFC650 VA: 0x182BFDC50
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x2BFDD40 Offset: 0x2BFC740 VA: 0x182BFDD40
	private bool isUWP() { }

	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public string get_text() { }

	// RVA: 0x2BFF4E0 Offset: 0x2BFDEE0 VA: 0x182BFF4E0
	public void set_text(string value) { }

	// RVA: 0x2BFB670 Offset: 0x2BFA070 VA: 0x182BFB670
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x2BFB680 Offset: 0x2BFA080 VA: 0x182BFB680
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x2BFD640 Offset: 0x2BFC040 VA: 0x182BFD640
	public bool get_isFocused() { }

	// RVA: 0x9E1A80 Offset: 0x9E0480 VA: 0x1809E1A80
	public float get_caretBlinkRate() { }

	// RVA: 0x2BFDE30 Offset: 0x2BFC830 VA: 0x182BFDE30
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x203EB30 Offset: 0x203D530 VA: 0x18203EB30
	public int get_caretWidth() { }

	// RVA: 0x2BFDFF0 Offset: 0x2BFC9F0 VA: 0x182BFDFF0
	public void set_caretWidth(int value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public RectTransform get_textViewport() { }

	// RVA: 0x2BFF490 Offset: 0x2BFDE90 VA: 0x182BFF490
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public TMP_Text get_textComponent() { }

	// RVA: 0x2BFF430 Offset: 0x2BFDE30 VA: 0x182BFF430
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public Graphic get_placeholder() { }

	// RVA: 0x2BFEB70 Offset: 0x2BFD570 VA: 0x182BFEB70
	public void set_placeholder(Graphic value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x2BFF4F0 Offset: 0x2BFDEF0 VA: 0x182BFF4F0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x653860 Offset: 0x652260 VA: 0x180653860
	public float get_scrollSensitivity() { }

	// RVA: 0x2BFEDF0 Offset: 0x2BFD7F0 VA: 0x182BFEDF0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x2BFD2A0 Offset: 0x2BFBCA0 VA: 0x182BFD2A0
	public Color get_caretColor() { }

	// RVA: 0x2BFDEA0 Offset: 0x2BFC8A0 VA: 0x182BFDEA0
	public void set_caretColor(Color value) { }

	// RVA: 0x6BFCD0 Offset: 0x6BE6D0 VA: 0x1806BFCD0
	public bool get_customCaretColor() { }

	// RVA: 0x2BFE430 Offset: 0x2BFCE30 VA: 0x182BFE430
	public void set_customCaretColor(bool value) { }

	// RVA: 0x2BFDA50 Offset: 0x2BFC450 VA: 0x182BFDA50
	public Color get_selectionColor() { }

	// RVA: 0x2BFEEE0 Offset: 0x2BFD8E0 VA: 0x182BFEEE0
	public void set_selectionColor(Color value) { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x2BFE8E0 Offset: 0x2BFD2E0 VA: 0x182BFE8E0
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x2BFE9E0 Offset: 0x2BFD3E0 VA: 0x182BFE9E0
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x2BFE990 Offset: 0x2BFD390 VA: 0x182BFE990
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x2BFE890 Offset: 0x2BFD290 VA: 0x182BFE890
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x2BFEA30 Offset: 0x2BFD430 VA: 0x182BFEA30
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x2BFE930 Offset: 0x2BFD330 VA: 0x182BFE930
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x2BFEB20 Offset: 0x2BFD520 VA: 0x182BFEB20
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x2BFEA80 Offset: 0x2BFD480 VA: 0x182BFEA80
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x2BFEAD0 Offset: 0x2BFD4D0 VA: 0x182BFEAD0
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x2BFD380 Offset: 0x2BFBD80 VA: 0x182BFD380
	public int get_characterLimit() { }

	// RVA: 0x2BFE080 Offset: 0x2BFCA80 VA: 0x182BFE080
	public void set_characterLimit(int value) { }

	// RVA: 0x8D1F80 Offset: 0x8D0980 VA: 0x1808D1F80
	public float get_pointSize() { }

	// RVA: 0x2BFEBC0 Offset: 0x2BFD5C0 VA: 0x182BFEBC0
	public void set_pointSize(float value) { }

	// RVA: 0x860A20 Offset: 0x85F420 VA: 0x180860A20
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x2BFE490 Offset: 0x2BFCE90 VA: 0x182BFE490
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x2BFD740 Offset: 0x2BFC140 VA: 0x182BFD740
	public bool get_onFocusSelectAll() { }

	// RVA: 0x2BFE980 Offset: 0x2BFD380 VA: 0x182BFE980
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x2BFDA30 Offset: 0x2BFC430 VA: 0x182BFDA30
	public bool get_resetOnDeActivation() { }

	// RVA: 0x2BFED40 Offset: 0x2BFD740 VA: 0x182BFED40
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x2246890 Offset: 0x2245290 VA: 0x182246890
	public bool get_keepTextSelectionVisible() { }

	// RVA: 0x2BFE6C0 Offset: 0x2BFD0C0 VA: 0x182BFE6C0
	public void set_keepTextSelectionVisible(bool value) { }

	// RVA: 0x2BFDA40 Offset: 0x2BFC440 VA: 0x182BFDA40
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x2BFED50 Offset: 0x2BFD750 VA: 0x182BFED50
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x2BFD650 Offset: 0x2BFC050 VA: 0x182BFD650
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x2BFE6B0 Offset: 0x2BFD0B0 VA: 0x182BFE6B0
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x2BFE1F0 Offset: 0x2BFCBF0 VA: 0x182BFE1F0
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x8DFE50 Offset: 0x8DE850 VA: 0x1808DFE50
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x2BFE7B0 Offset: 0x2BFD1B0 VA: 0x182BFE7B0
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x2BFD660 Offset: 0x2BFC060 VA: 0x182BFD660
	public int get_lineLimit() { }

	// RVA: 0x2BFE740 Offset: 0x2BFD140 VA: 0x182BFE740
	public void set_lineLimit(int value) { }

	// RVA: 0x7E22C0 Offset: 0x7E0CC0 VA: 0x1807E22C0
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x2BFE5D0 Offset: 0x2BFCFD0 VA: 0x182BFE5D0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x77BCD0 Offset: 0x77A6D0 VA: 0x18077BCD0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x2BFE6D0 Offset: 0x2BFD0D0 VA: 0x182BFE6D0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x9E1B10 Offset: 0x9E0510 VA: 0x1809E1B10
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x2BFE130 Offset: 0x2BFCB30 VA: 0x182BFE130
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x640F20 Offset: 0x63F920 VA: 0x180640F20
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x2BFE640 Offset: 0x2BFD040 VA: 0x182BFE640
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0xA472E0 Offset: 0xA45CE0 VA: 0x180A472E0
	public bool get_readOnly() { }

	// RVA: 0x2BFED30 Offset: 0x2BFD730 VA: 0x182BFED30
	public void set_readOnly(bool value) { }

	// RVA: 0xA472D0 Offset: 0xA45CD0 VA: 0x180A472D0
	public bool get_richText() { }

	// RVA: 0x2BFED60 Offset: 0x2BFD760 VA: 0x182BFED60
	public void set_richText(bool value) { }

	// RVA: 0x2BFD720 Offset: 0x2BFC120 VA: 0x182BFD720
	public bool get_multiLine() { }

	// RVA: 0x2BFD290 Offset: 0x2BFBC90 VA: 0x182BFD290
	public char get_asteriskChar() { }

	// RVA: 0x2BFDDD0 Offset: 0x2BFC7D0 VA: 0x182BFDDD0
	public void set_asteriskChar(char value) { }

	// RVA: 0x2BFDC40 Offset: 0x2BFC640 VA: 0x182BFDC40
	public bool get_wasCanceled() { }

	// RVA: 0x2BF0FF0 Offset: 0x2BEF9F0 VA: 0x182BF0FF0
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x2BF0F70 Offset: 0x2BEF970 VA: 0x182BF0F70
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x2BF0F60 Offset: 0x2BEF960 VA: 0x182BF0F60
	private int ClampArrayIndex(int index) { }

	// RVA: 0x2BFD300 Offset: 0x2BFBD00 VA: 0x182BFD300
	protected int get_caretPositionInternal() { }

	// RVA: 0x2BFDF10 Offset: 0x2BFC910 VA: 0x182BFDF10
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x2BFDA60 Offset: 0x2BFC460 VA: 0x182BFDA60
	protected int get_stringPositionInternal() { }

	// RVA: 0x2BFF2B0 Offset: 0x2BFDCB0 VA: 0x182BFF2B0
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x2BFD340 Offset: 0x2BFBD40 VA: 0x182BFD340
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x2BFDFD0 Offset: 0x2BFC9D0 VA: 0x182BFDFD0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x2BFDAA0 Offset: 0x2BFC4A0 VA: 0x182BFDAA0
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x2BFF3E0 Offset: 0x2BFDDE0 VA: 0x182BFF3E0
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x2BFD4B0 Offset: 0x2BFBEB0 VA: 0x182BFD4B0
	private bool get_hasSelection() { }

	// RVA: 0x2BFD340 Offset: 0x2BFBD40 VA: 0x182BFD340
	public int get_caretPosition() { }

	// RVA: 0x2BFDF30 Offset: 0x2BFC930 VA: 0x182BFDF30
	public void set_caretPosition(int value) { }

	// RVA: 0x2BFD300 Offset: 0x2BFBD00 VA: 0x182BFD300
	public int get_selectionAnchorPosition() { }

	// RVA: 0x2BFEE80 Offset: 0x2BFD880 VA: 0x182BFEE80
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x2BFD340 Offset: 0x2BFBD40 VA: 0x182BFD340
	public int get_selectionFocusPosition() { }

	// RVA: 0x2BFEF50 Offset: 0x2BFD950 VA: 0x182BFEF50
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x2BFDAA0 Offset: 0x2BFC4A0 VA: 0x182BFDAA0
	public int get_stringPosition() { }

	// RVA: 0x2BFF300 Offset: 0x2BFDD00 VA: 0x182BFF300
	public void set_stringPosition(int value) { }

	// RVA: 0x2BFDA60 Offset: 0x2BFC460 VA: 0x182BFDA60
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x2BFEFB0 Offset: 0x2BFD9B0 VA: 0x182BFEFB0
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x2BFDAA0 Offset: 0x2BFC4A0 VA: 0x182BFDAA0
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x2BFF040 Offset: 0x2BFDA40 VA: 0x182BFF040
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x2BF8870 Offset: 0x2BF7270 VA: 0x182BF8870 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2BF8030 Offset: 0x2BF6A30 VA: 0x182BF8030 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2BF7CF0 Offset: 0x2BF66F0 VA: 0x182BF7CF0
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachine(typeof(TMP_InputField.<CaretBlink>d__293))]
	// RVA: 0x2BF0EF0 Offset: 0x2BEF8F0 VA: 0x182BF0EF0
	private IEnumerator CaretBlink() { }

	// RVA: 0x2BFB310 Offset: 0x2BF9D10 VA: 0x182BFB310
	private void SetCaretVisible() { }

	// RVA: 0x2BFB240 Offset: 0x2BF9C40 VA: 0x182BFB240
	private void SetCaretActive() { }

	// RVA: 0x2BF9430 Offset: 0x2BF7E30 VA: 0x182BF9430
	protected void OnFocus() { }

	// RVA: 0x2BFAD00 Offset: 0x2BF9700 VA: 0x182BFAD00
	protected void SelectAll() { }

	// RVA: 0x2BF7180 Offset: 0x2BF5B80 VA: 0x182BF7180
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x2BF7370 Offset: 0x2BF5D70 VA: 0x182BF7370
	public void MoveTextStart(bool shift) { }

	// RVA: 0x2BF74D0 Offset: 0x2BF5ED0 VA: 0x182BF74D0
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x2BF7760 Offset: 0x2BF6160 VA: 0x182BF7760
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x2BFD390 Offset: 0x2BFBD90 VA: 0x182BFD390
	private static string get_clipboard() { }

	// RVA: 0x2BFE1A0 Offset: 0x2BFCBA0 VA: 0x182BFE1A0
	private static void set_clipboard(string value) { }

	// RVA: 0x2BF3D60 Offset: 0x2BF2760 VA: 0x182BF3D60
	private bool InPlaceEditing() { }

	// RVA: 0x2BF3CE0 Offset: 0x2BF26E0 VA: 0x182BF3CE0
	private bool InPlaceEditingChanged() { }

	// RVA: 0x2BFB890 Offset: 0x2BFA290 VA: 0x182BFB890
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x2BFBAC0 Offset: 0x2BFA4C0 VA: 0x182BFBAC0
	private void UpdateKeyboardStringPosition() { }

	// RVA: 0x2BFC400 Offset: 0x2BFAE00 VA: 0x182BFC400
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x2BF4470 Offset: 0x2BF2E70 VA: 0x182BF4470 Slot: 63
	protected virtual void LateUpdate() { }

	// RVA: 0x2BF54B0 Offset: 0x2BF3EB0 VA: 0x182BF54B0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2BF7EE0 Offset: 0x2BF68E0 VA: 0x182BF7EE0 Slot: 64
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2BF83A0 Offset: 0x2BF6DA0 VA: 0x182BF83A0 Slot: 65
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(TMP_InputField.<MouseDragOutsideRect>d__314))]
	// RVA: 0x2BF55A0 Offset: 0x2BF3FA0 VA: 0x182BF55A0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x2BF9130 Offset: 0x2BF7B30 VA: 0x182BF9130 Slot: 66
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2BF94A0 Offset: 0x2BF7EA0 VA: 0x182BF94A0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2BF3FA0 Offset: 0x2BF29A0 VA: 0x182BF3FA0
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x2BF3F80 Offset: 0x2BF2980 VA: 0x182BF3F80 Slot: 67
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x2BFAB60 Offset: 0x2BF9560 VA: 0x182BFAB60
	public void ProcessEvent(Event e) { }

	// RVA: 0x2BFA1F0 Offset: 0x2BF8BF0 VA: 0x182BFA1F0 Slot: 68
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2BF9E30 Offset: 0x2BF8830 VA: 0x182BF9E30 Slot: 69
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2BF39A0 Offset: 0x2BF23A0 VA: 0x182BF39A0
	private float GetScrollPositionRelativeToViewport() { }

	// RVA: 0x2BF3B50 Offset: 0x2BF2550 VA: 0x182BF3B50
	private string GetSelectedString() { }

	// RVA: 0x2BF1E40 Offset: 0x2BF0840 VA: 0x182BF1E40
	private int FindNextWordBegin() { }

	// RVA: 0x2BF68F0 Offset: 0x2BF52F0 VA: 0x182BF68F0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x2BF1F60 Offset: 0x2BF0960 VA: 0x182BF1F60
	private int FindPrevWordBegin() { }

	// RVA: 0x2BF5900 Offset: 0x2BF4300 VA: 0x182BF5900
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x2BF51B0 Offset: 0x2BF3BB0 VA: 0x182BF51B0
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x2BF4EC0 Offset: 0x2BF38C0 VA: 0x182BF4EC0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x2BFA7D0 Offset: 0x2BF91D0 VA: 0x182BFA7D0
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x2BFA3D0 Offset: 0x2BF8DD0 VA: 0x182BFA3D0
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x2BF58F0 Offset: 0x2BF42F0 VA: 0x182BF58F0
	private void MoveDown(bool shift) { }

	// RVA: 0x2BF5630 Offset: 0x2BF4030 VA: 0x182BF5630
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x2BF7A40 Offset: 0x2BF6440 VA: 0x182BF7A40
	private void MoveUp(bool shift) { }

	// RVA: 0x2BF7A50 Offset: 0x2BF6450 VA: 0x182BF7A50
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x2BF68E0 Offset: 0x2BF52E0 VA: 0x182BF68E0
	private void MovePageUp(bool shift) { }

	// RVA: 0x2BF64C0 Offset: 0x2BF4EC0 VA: 0x182BF64C0
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x2BF64B0 Offset: 0x2BF4EB0 VA: 0x182BF64B0
	private void MovePageDown(bool shift) { }

	// RVA: 0x2BF6080 Offset: 0x2BF4A80 VA: 0x182BF6080
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x2BF1850 Offset: 0x2BF0250 VA: 0x182BF1850
	private void Delete() { }

	// RVA: 0x2BF1460 Offset: 0x2BEFE60 VA: 0x182BF1460
	private void DeleteKey() { }

	// RVA: 0x2BF0A40 Offset: 0x2BEF440 VA: 0x182BF0A40
	private void Backspace() { }

	// RVA: 0x2BEFBF0 Offset: 0x2BEE5F0 VA: 0x182BEFBF0 Slot: 70
	protected virtual void Append(string input) { }

	// RVA: 0x2BEFCA0 Offset: 0x2BEE6A0 VA: 0x182BEFCA0 Slot: 71
	protected virtual void Append(char input) { }

	// RVA: 0x2BF3DE0 Offset: 0x2BF27E0 VA: 0x182BF3DE0
	private void Insert(char c) { }

	// RVA: 0x2BFC5F0 Offset: 0x2BFAFF0 VA: 0x182BFC5F0
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x2BFB110 Offset: 0x2BF9B10 VA: 0x182BFB110
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x2BFB170 Offset: 0x2BF9B70 VA: 0x182BFB170
	private void SendOnValueChanged() { }

	// RVA: 0x2BFAD80 Offset: 0x2BF9780 VA: 0x182BFAD80
	protected void SendOnEndEdit() { }

	// RVA: 0x2BFAFB0 Offset: 0x2BF99B0 VA: 0x182BFAFB0
	protected void SendOnSubmit() { }

	// RVA: 0x2BFAF50 Offset: 0x2BF9950 VA: 0x182BFAF50
	protected void SendOnFocus() { }

	// RVA: 0x2BFAEF0 Offset: 0x2BF98F0 VA: 0x182BFAEF0
	protected void SendOnFocusLost() { }

	// RVA: 0x2BFB010 Offset: 0x2BF9A10 VA: 0x182BFB010
	protected void SendOnTextSelection() { }

	// RVA: 0x2BFADE0 Offset: 0x2BF97E0 VA: 0x182BFADE0
	protected void SendOnEndTextSelection() { }

	// RVA: 0x2BFB1D0 Offset: 0x2BF9BD0 VA: 0x182BFB1D0
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x2BFBC90 Offset: 0x2BFA690 VA: 0x182BFBC90
	protected void UpdateLabel() { }

	// RVA: 0x2BFC230 Offset: 0x2BFAC30 VA: 0x182BFC230
	private void UpdateScrollbar() { }

	// RVA: 0x2BFA060 Offset: 0x2BF8A60 VA: 0x182BFA060
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpdateMaskRegions() { }

	// RVA: 0x2BEF9B0 Offset: 0x2BEE3B0 VA: 0x182BEF9B0
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x2BF37D0 Offset: 0x2BF21D0 VA: 0x182BF37D0
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x2BF3890 Offset: 0x2BF2290 VA: 0x182BF3890
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x2BF37D0 Offset: 0x2BF21D0 VA: 0x182BF37D0
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x2BF3C30 Offset: 0x2BF2630 VA: 0x182BF3C30
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x2BFC330 Offset: 0x2BFAD30 VA: 0x182BFC330
	private void UpdateStringIndexFromCaretPosition() { }

	// RVA: 0x2BFB930 Offset: 0x2BFA330 VA: 0x182BFB930
	private void UpdateCaretPositionFromStringIndex() { }

	// RVA: 0x2BF2070 Offset: 0x2BF0A70 VA: 0x182BF2070
	public void ForceLabelUpdate() { }

	// RVA: 0x2BF5460 Offset: 0x2BF3E60 VA: 0x182BF5460
	private void MarkGeometryAsDirty() { }

	// RVA: 0x2BFAB70 Offset: 0x2BF9570 VA: 0x182BFAB70 Slot: 72
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 73
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 74
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2BFBA00 Offset: 0x2BFA400 VA: 0x182BFBA00
	private void UpdateGeometry() { }

	// RVA: 0x2BF02C0 Offset: 0x2BEECC0 VA: 0x182BF02C0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x2BF9160 Offset: 0x2BF7B60 VA: 0x182BF9160
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x2BF2080 Offset: 0x2BF0A80 VA: 0x182BF2080
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x2BF1030 Offset: 0x2BEFA30 VA: 0x182BF1030
	private void CreateCursorVerts() { }

	// RVA: 0x2BF2DB0 Offset: 0x2BF17B0 VA: 0x182BF2DB0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x2BEF220 Offset: 0x2BEDC20 VA: 0x182BEF220
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x2BFC640 Offset: 0x2BFB040 VA: 0x182BFC640
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x2BEF0E0 Offset: 0x2BEDAE0 VA: 0x182BEF0E0
	public void ActivateInputField() { }

	// RVA: 0x2BEEBF0 Offset: 0x2BED5F0 VA: 0x182BEEBF0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x2BFA0A0 Offset: 0x2BF8AA0 VA: 0x182BFA0A0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2BF9470 Offset: 0x2BF7E70 VA: 0x182BF9470 Slot: 75
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void OnControlClick() { }

	// RVA: 0x2BFAC40 Offset: 0x2BF9640 VA: 0x182BFAC40
	public void ReleaseSelection() { }

	// RVA: 0x2BF11F0 Offset: 0x2BEFBF0 VA: 0x182BF11F0
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x2BF7FB0 Offset: 0x2BF69B0 VA: 0x182BF7FB0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2BFA120 Offset: 0x2BF8B20 VA: 0x182BFA120 Slot: 76
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2BF7F10 Offset: 0x2BF6910 VA: 0x182BF7F10 Slot: 77
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2BF9450 Offset: 0x2BF7E50 VA: 0x182BF9450 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x2BF1C40 Offset: 0x2BF0640 VA: 0x182BF1C40
	private void EnforceContentType() { }

	// RVA: 0x2BFB5C0 Offset: 0x2BF9FC0 VA: 0x182BFB5C0
	private void SetTextComponentWrapMode() { }

	// RVA: 0x2BFB530 Offset: 0x2BF9F30 VA: 0x182BFB530
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x2BFB800 Offset: 0x2BFA200 VA: 0x182BFB800
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x2BFB870 Offset: 0x2BFA270 VA: 0x182BFB870
	private void SetToCustom() { }

	// RVA: 0x2BFB870 Offset: 0x2BFA270 VA: 0x182BFB870
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x2BF1C10 Offset: 0x2BF0610 VA: 0x182BF1C10 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 78
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 79
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 80
	public virtual float get_minWidth() { }

	// RVA: 0x2BFD8C0 Offset: 0x2BFC2C0 VA: 0x182BFD8C0 Slot: 81
	public virtual float get_preferredWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 82
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 83
	public virtual float get_minHeight() { }

	// RVA: 0x2BFD750 Offset: 0x2BFC150 VA: 0x182BFD750 Slot: 84
	public virtual float get_preferredHeight() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 85
	public virtual float get_flexibleHeight() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 86
	public virtual int get_layoutPriority() { }

	// RVA: 0x2BFB440 Offset: 0x2BF9E40 VA: 0x182BFB440
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x2BFB350 Offset: 0x2BF9D50 VA: 0x182BFB350
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x2BFCEA0 Offset: 0x2BFB8A0 VA: 0x182BFCEA0
	private static void .cctor() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 47
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
