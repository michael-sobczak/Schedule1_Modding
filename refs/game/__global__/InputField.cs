public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 16422
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	[FormerlySerializedAs("text")]
	[SerializeField]
	protected Text m_TextComponent; // 0x108
	[SerializeField]
	protected Graphic m_Placeholder; // 0x110
	[SerializeField]
	private InputField.ContentType m_ContentType; // 0x118
	[SerializeField]
	[FormerlySerializedAs("inputType")]
	private InputField.InputType m_InputType; // 0x11C
	[SerializeField]
	[FormerlySerializedAs("asteriskChar")]
	private char m_AsteriskChar; // 0x120
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	[SerializeField]
	private InputField.LineType m_LineType; // 0x128
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput; // 0x12C
	[SerializeField]
	[FormerlySerializedAs("validation")]
	private InputField.CharacterValidation m_CharacterValidation; // 0x130
	[SerializeField]
	[FormerlySerializedAs("characterLimit")]
	private int m_CharacterLimit; // 0x134
	[FormerlySerializedAs("m_EndEdit")]
	[SerializeField]
	[FormerlySerializedAs("m_OnEndEdit")]
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	private InputField.SubmitEvent m_OnSubmit; // 0x138
	[SerializeField]
	private InputField.EndEditEvent m_OnDidEndEdit; // 0x140
	[FormerlySerializedAs("onValueChange")]
	[SerializeField]
	[FormerlySerializedAs("m_OnValueChange")]
	private InputField.OnChangeEvent m_OnValueChanged; // 0x148
	[SerializeField]
	[FormerlySerializedAs("onValidateInput")]
	private InputField.OnValidateInput m_OnValidateInput; // 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; // 0x158
	[SerializeField]
	private bool m_CustomCaretColor; // 0x168
	[SerializeField]
	private Color m_SelectionColor; // 0x16C
	[Multiline]
	[FormerlySerializedAs("mValue")]
	[SerializeField]
	protected string m_Text; // 0x180
	[Range(0, 4)]
	[SerializeField]
	private float m_CaretBlinkRate; // 0x188
	[Range(1, 5)]
	[SerializeField]
	private int m_CaretWidth; // 0x18C
	[SerializeField]
	private bool m_ReadOnly; // 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.EndEditEvent onEndEdit { get; set; }
	public InputField.SubmitEvent onSubmit { get; set; }
	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x2F24E50 Offset: 0x2F23850 VA: 0x182F24E50
	private BaseInput get_input() { }

	// RVA: 0x2F24D40 Offset: 0x2F23740 VA: 0x182F24D40
	private string get_compositionString() { }

	// RVA: 0x2F24960 Offset: 0x2F23360 VA: 0x182F24960
	protected void .ctor() { }

	// RVA: 0x2F24F50 Offset: 0x2F23950 VA: 0x182F24F50
	protected Mesh get_mesh() { }

	// RVA: 0x2F24BC0 Offset: 0x2F235C0 VA: 0x182F24BC0
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x2F260B0 Offset: 0x2F24AB0 VA: 0x182F260B0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x2F25460 Offset: 0x2F23E60 VA: 0x182F25460
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x2F260A0 Offset: 0x2F24AA0 VA: 0x182F260A0 Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x2F25400 Offset: 0x2F23E00 VA: 0x182F25400 Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public string get_text() { }

	// RVA: 0x2F263A0 Offset: 0x2F24DA0 VA: 0x182F263A0
	public void set_text(string value) { }

	// RVA: 0x2F22E80 Offset: 0x2F21880 VA: 0x182F22E80
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x2F22E90 Offset: 0x2F21890 VA: 0x182F22E90
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xAADD90 Offset: 0xAAC790 VA: 0x180AADD90
	public bool get_isFocused() { }

	// RVA: 0x726450 Offset: 0x724E50 VA: 0x180726450
	public float get_caretBlinkRate() { }

	// RVA: 0x2F25520 Offset: 0x2F23F20 VA: 0x182F25520
	public void set_caretBlinkRate(float value) { }

	// RVA: 0xA59CA0 Offset: 0xA586A0 VA: 0x180A59CA0
	public int get_caretWidth() { }

	// RVA: 0x2F25760 Offset: 0x2F24160 VA: 0x182F25760
	public void set_caretWidth(int value) { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public Text get_textComponent() { }

	// RVA: 0x2F26100 Offset: 0x2F24B00 VA: 0x182F26100
	public void set_textComponent(Text value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public Graphic get_placeholder() { }

	// RVA: 0x2F25F00 Offset: 0x2F24900 VA: 0x182F25F00
	public void set_placeholder(Graphic value) { }

	// RVA: 0x2F24C40 Offset: 0x2F23640 VA: 0x182F24C40
	public Color get_caretColor() { }

	// RVA: 0x2F25590 Offset: 0x2F23F90 VA: 0x182F25590
	public void set_caretColor(Color value) { }

	// RVA: 0x617FF0 Offset: 0x6169F0 VA: 0x180617FF0
	public bool get_customCaretColor() { }

	// RVA: 0x2F25BA0 Offset: 0x2F245A0 VA: 0x182F25BA0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x2F253F0 Offset: 0x2F23DF0 VA: 0x182F253F0
	public Color get_selectionColor() { }

	// RVA: 0x2F25FC0 Offset: 0x2F249C0 VA: 0x182F25FC0
	public void set_selectionColor(Color value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public InputField.EndEditEvent get_onEndEdit() { }

	// RVA: 0x2F25DC0 Offset: 0x2F247C0 VA: 0x182F25DC0
	public void set_onEndEdit(InputField.EndEditEvent value) { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x2F25E10 Offset: 0x2F24810 VA: 0x182F25E10
	public void set_onSubmit(InputField.SubmitEvent value) { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x2F25EB0 Offset: 0x2F248B0 VA: 0x182F25EB0
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x2F25EB0 Offset: 0x2F248B0 VA: 0x182F25EB0
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x2F25E60 Offset: 0x2F24860 VA: 0x182F25E60
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x512ED0 Offset: 0x5118D0 VA: 0x180512ED0
	public int get_characterLimit() { }

	// RVA: 0x2F257F0 Offset: 0x2F241F0 VA: 0x182F257F0
	public void set_characterLimit(int value) { }

	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public InputField.ContentType get_contentType() { }

	// RVA: 0x2F25960 Offset: 0x2F24360 VA: 0x182F25960
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x51D950 Offset: 0x51C350 VA: 0x18051D950
	public InputField.LineType get_lineType() { }

	// RVA: 0x2F25CE0 Offset: 0x2F246E0 VA: 0x182F25CE0
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public InputField.InputType get_inputType() { }

	// RVA: 0x2F25C00 Offset: 0x2F24600 VA: 0x182F25C00
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x704910 Offset: 0x703310 VA: 0x180704910
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x2F25C70 Offset: 0x2F24670 VA: 0x182F25C70
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x2F258A0 Offset: 0x2F242A0 VA: 0x182F258A0
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x25B8100 Offset: 0x25B6B00 VA: 0x1825B8100
	public bool get_readOnly() { }

	// RVA: 0x25B8C30 Offset: 0x25B7630 VA: 0x1825B8C30
	public void set_readOnly(bool value) { }

	// RVA: 0x2F25010 Offset: 0x2F23A10 VA: 0x182F25010
	public bool get_multiLine() { }

	// RVA: 0x2F24BB0 Offset: 0x2F235B0 VA: 0x182F24BB0
	public char get_asteriskChar() { }

	// RVA: 0x2F254C0 Offset: 0x2F23EC0 VA: 0x182F254C0
	public void set_asteriskChar(char value) { }

	// RVA: 0x7262A0 Offset: 0x724CA0 VA: 0x1807262A0
	public bool get_wasCanceled() { }

	// RVA: 0x2F1C260 Offset: 0x2F1AC60 VA: 0x182F1C260
	protected void ClampPos(ref int pos) { }

	// RVA: 0x2F24CA0 Offset: 0x2F236A0 VA: 0x182F24CA0
	protected int get_caretPositionInternal() { }

	// RVA: 0x2F25600 Offset: 0x2F24000 VA: 0x182F25600
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x2F24CD0 Offset: 0x2F236D0 VA: 0x182F24CD0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x2F25710 Offset: 0x2F24110 VA: 0x182F25710
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x2F24DF0 Offset: 0x2F237F0 VA: 0x182F24DF0
	private bool get_hasSelection() { }

	// RVA: 0x2F24CD0 Offset: 0x2F236D0 VA: 0x182F24CD0
	public int get_caretPosition() { }

	// RVA: 0x2F25650 Offset: 0x2F24050 VA: 0x182F25650
	public void set_caretPosition(int value) { }

	// RVA: 0x2F24CA0 Offset: 0x2F236A0 VA: 0x182F24CA0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x2F25F50 Offset: 0x2F24950 VA: 0x182F25F50
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x2F24CD0 Offset: 0x2F236D0 VA: 0x182F24CD0
	public int get_selectionFocusPosition() { }

	// RVA: 0x2F26030 Offset: 0x2F24A30 VA: 0x182F26030
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x2F213D0 Offset: 0x2F1FDD0 VA: 0x182F213D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F20E70 Offset: 0x2F1F870 VA: 0x182F20E70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F20E10 Offset: 0x2F1F810 VA: 0x182F20E10 Slot: 8
	protected override void OnDestroy() { }

	[IteratorStateMachine(typeof(InputField.<CaretBlink>d__170))]
	// RVA: 0x2F1C1F0 Offset: 0x2F1ABF0 VA: 0x182F1C1F0
	private IEnumerator CaretBlink() { }

	// RVA: 0x2F225E0 Offset: 0x2F20FE0 VA: 0x182F225E0
	private void SetCaretVisible() { }

	// RVA: 0x2F22520 Offset: 0x2F20F20 VA: 0x182F22520
	private void SetCaretActive() { }

	// RVA: 0x2F23570 Offset: 0x2F21F70 VA: 0x182F23570
	private void UpdateCaretMaterial() { }

	// RVA: 0x2F21880 Offset: 0x2F20280 VA: 0x182F21880
	protected void OnFocus() { }

	// RVA: 0x2F222F0 Offset: 0x2F20CF0 VA: 0x182F222F0
	protected void SelectAll() { }

	// RVA: 0x2F209B0 Offset: 0x2F1F3B0 VA: 0x182F209B0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x2F20AD0 Offset: 0x2F1F4D0 VA: 0x182F20AD0
	public void MoveTextStart(bool shift) { }

	// RVA: 0x2F24D00 Offset: 0x2F23700 VA: 0x182F24D00
	private static string get_clipboard() { }

	// RVA: 0x2F25910 Offset: 0x2F24310 VA: 0x182F25910
	private static void set_clipboard(string value) { }

	// RVA: 0x2F23390 Offset: 0x2F21D90 VA: 0x182F23390
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x2F1EC80 Offset: 0x2F1D680 VA: 0x182F1EC80
	private bool InPlaceEditing() { }

	// RVA: 0x2F1EC00 Offset: 0x2F1D600 VA: 0x182F1EC00
	private bool InPlaceEditingChanged() { }

	// RVA: 0x2F1E5A0 Offset: 0x2F1CFA0 VA: 0x182F1E5A0
	private RangeInt GetInternalSelection() { }

	// RVA: 0x2F23B60 Offset: 0x2F22560 VA: 0x182F23B60
	private void UpdateKeyboardCaret() { }

	// RVA: 0x2F23440 Offset: 0x2F21E40 VA: 0x182F23440
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x2F1F4C0 Offset: 0x2F1DEC0 VA: 0x182F1F4C0 Slot: 61
	protected virtual void LateUpdate() { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	// RVA: 0x2F21DF0 Offset: 0x2F207F0 VA: 0x182F21DF0
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x2F1E980 Offset: 0x2F1D380 VA: 0x182F1E980
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x2F1E350 Offset: 0x2F1CD50 VA: 0x182F1E350
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x2F200D0 Offset: 0x2F1EAD0 VA: 0x182F200D0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2F20DB0 Offset: 0x2F1F7B0 VA: 0x182F20DB0 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2F210F0 Offset: 0x2F1FAF0 VA: 0x182F210F0 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(InputField.<MouseDragOutsideRect>d__194))]
	// RVA: 0x2F201C0 Offset: 0x2F1EBC0 VA: 0x182F201C0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x2F21650 Offset: 0x2F20050 VA: 0x182F21650 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2F218C0 Offset: 0x2F202C0 VA: 0x182F218C0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F1EFA0 Offset: 0x2F1D9A0 VA: 0x182F1EFA0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x2F1EF40 Offset: 0x2F1D940 VA: 0x182F1EF40
	private bool IsValidChar(char c) { }

	// RVA: 0x2F21DD0 Offset: 0x2F207D0 VA: 0x182F21DD0
	public void ProcessEvent(Event e) { }

	// RVA: 0x2F21C00 Offset: 0x2F20600 VA: 0x182F21C00 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2F1E880 Offset: 0x2F1D280 VA: 0x182F1E880
	private string GetSelectedString() { }

	// RVA: 0x2F1CDE0 Offset: 0x2F1B7E0 VA: 0x182F1CDE0
	private int FindtNextWordBegin() { }

	// RVA: 0x2F20700 Offset: 0x2F1F100 VA: 0x182F20700
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x2F1CEE0 Offset: 0x2F1B8E0 VA: 0x182F1CEE0
	private int FindtPrevWordBegin() { }

	// RVA: 0x2F20480 Offset: 0x2F1EE80 VA: 0x182F20480
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x2F1C9E0 Offset: 0x2F1B3E0 VA: 0x182F1C9E0
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x2F1FE60 Offset: 0x2F1E860 VA: 0x182F1FE60
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x2F1FBB0 Offset: 0x2F1E5B0 VA: 0x182F1FBB0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x2F20470 Offset: 0x2F1EE70 VA: 0x182F20470
	private void MoveDown(bool shift) { }

	// RVA: 0x2F20250 Offset: 0x2F1EC50 VA: 0x182F20250
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x2F20BC0 Offset: 0x2F1F5C0 VA: 0x182F20BC0
	private void MoveUp(bool shift) { }

	// RVA: 0x2F20BD0 Offset: 0x2F1F5D0 VA: 0x182F20BD0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x2F1C6B0 Offset: 0x2F1B0B0 VA: 0x182F1C6B0
	private void Delete() { }

	// RVA: 0x2F1CFE0 Offset: 0x2F1B9E0 VA: 0x182F1CFE0
	private void ForwardSpace() { }

	// RVA: 0x2F1C030 Offset: 0x2F1AA30 VA: 0x182F1C030
	private void Backspace() { }

	// RVA: 0x2F1ECB0 Offset: 0x2F1D6B0 VA: 0x182F1ECB0
	private void Insert(char c) { }

	// RVA: 0x2F24130 Offset: 0x2F22B30 VA: 0x182F24130
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x2F22480 Offset: 0x2F20E80 VA: 0x182F22480
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x2F224A0 Offset: 0x2F20EA0 VA: 0x182F224A0
	private void SendOnValueChanged() { }

	// RVA: 0x2F22380 Offset: 0x2F20D80 VA: 0x182F22380
	protected void SendOnEndEdit() { }

	// RVA: 0x2F22400 Offset: 0x2F20E00 VA: 0x182F22400
	protected void SendOnSubmit() { }

	// RVA: 0x2F1B800 Offset: 0x2F1A200 VA: 0x182F1B800 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x2F1B480 Offset: 0x2F19E80 VA: 0x182F1B480 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x2F23C30 Offset: 0x2F22630 VA: 0x182F23C30
	protected void UpdateLabel() { }

	// RVA: 0x2F1EE70 Offset: 0x2F1D870 VA: 0x182F1EE70
	private bool IsSelectionVisible() { }

	// RVA: 0x2F1E760 Offset: 0x2F1D160 VA: 0x182F1E760
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x2F1E6A0 Offset: 0x2F1D0A0 VA: 0x182F1E6A0
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x2F22620 Offset: 0x2F21020 VA: 0x182F22620
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x2F1CFD0 Offset: 0x2F1B9D0 VA: 0x182F1CFD0
	public void ForceLabelUpdate() { }

	// RVA: 0x2F20080 Offset: 0x2F1EA80 VA: 0x182F20080
	private void MarkGeometryAsDirty() { }

	// RVA: 0x2F21DE0 Offset: 0x2F207E0 VA: 0x182F21DE0 Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2F23680 Offset: 0x2F22080 VA: 0x182F23680
	private void UpdateGeometry() { }

	// RVA: 0x2F1B8B0 Offset: 0x2F1A2B0 VA: 0x182F1B8B0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x2F21680 Offset: 0x2F20080 VA: 0x182F21680
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x2F1D140 Offset: 0x2F1BB40 VA: 0x182F1D140
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x2F1C2A0 Offset: 0x2F1ACA0 VA: 0x182F1C2A0
	private void CreateCursorVerts() { }

	// RVA: 0x2F1DC00 Offset: 0x2F1C600 VA: 0x182F1DC00
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x2F24190 Offset: 0x2F22B90 VA: 0x182F24190
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x2F1B340 Offset: 0x2F19D40 VA: 0x182F1B340
	public void ActivateInputField() { }

	// RVA: 0x2F1AEE0 Offset: 0x2F198E0 VA: 0x182F1AEE0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x2F21B70 Offset: 0x2F20570 VA: 0x182F21B70 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2F21890 Offset: 0x2F20290 VA: 0x182F21890 Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2F1C460 Offset: 0x2F1AE60 VA: 0x182F1C460
	public void DeactivateInputField() { }

	// RVA: 0x2F20DE0 Offset: 0x2F1F7E0 VA: 0x182F20DE0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2F21BB0 Offset: 0x2F205B0 VA: 0x182F21BB0 Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2F1CB30 Offset: 0x2F1B530 VA: 0x182F1CB30
	private void EnforceContentType() { }

	// RVA: 0x2F1CD30 Offset: 0x2F1B730 VA: 0x182F1CD30
	private void EnforceTextHOverflow() { }

	// RVA: 0x2F23300 Offset: 0x2F21D00 VA: 0x182F23300
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x2F23370 Offset: 0x2F21D70 VA: 0x182F23370
	private void SetToCustom() { }

	// RVA: 0x2F1CB00 Offset: 0x2F1B500 VA: 0x182F1CB00 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x2F25000 Offset: 0x2F23A00 VA: 0x182F25000 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x2F25210 Offset: 0x2F23C10 VA: 0x182F25210 Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x2F25030 Offset: 0x2F23A30 VA: 0x182F25030 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x2F248C0 Offset: 0x2F232C0 VA: 0x182F248C0
	private static void .cctor() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
