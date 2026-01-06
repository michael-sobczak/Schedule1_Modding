public class Keyboard : InputDevice, ITextInputReceiver, IEventPreProcessor // TypeDefIndex: 7375
{
	// Fields
	public const int KeyCount = 110;
	internal const int ExtendedKeyCount = 123;
	[CompilerGenerated]
	private AnyKeyControl <anyKey>k__BackingField; // 0x190
	[CompilerGenerated]
	private ButtonControl <shiftKey>k__BackingField; // 0x198
	[CompilerGenerated]
	private ButtonControl <ctrlKey>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private ButtonControl <altKey>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private ButtonControl <imeSelected>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private static Keyboard <current>k__BackingField; // 0x0
	private InlinedArray<Action<char>> m_TextInputListeners; // 0x1B8
	private string m_KeyboardLayoutName; // 0x1D0
	private KeyControl[] m_Keys; // 0x1D8
	private InlinedArray<Action<IMECompositionString>> m_ImeCompositionListeners; // 0x1E0

	// Properties
	public string keyboardLayout { get; set; }
	public AnyKeyControl anyKey { get; set; }
	public KeyControl spaceKey { get; }
	public KeyControl enterKey { get; }
	public KeyControl tabKey { get; }
	public KeyControl backquoteKey { get; }
	public KeyControl quoteKey { get; }
	public KeyControl semicolonKey { get; }
	public KeyControl commaKey { get; }
	public KeyControl periodKey { get; }
	public KeyControl slashKey { get; }
	public KeyControl backslashKey { get; }
	public KeyControl leftBracketKey { get; }
	public KeyControl rightBracketKey { get; }
	public KeyControl minusKey { get; }
	public KeyControl equalsKey { get; }
	public KeyControl aKey { get; }
	public KeyControl bKey { get; }
	public KeyControl cKey { get; }
	public KeyControl dKey { get; }
	public KeyControl eKey { get; }
	public KeyControl fKey { get; }
	public KeyControl gKey { get; }
	public KeyControl hKey { get; }
	public KeyControl iKey { get; }
	public KeyControl jKey { get; }
	public KeyControl kKey { get; }
	public KeyControl lKey { get; }
	public KeyControl mKey { get; }
	public KeyControl nKey { get; }
	public KeyControl oKey { get; }
	public KeyControl pKey { get; }
	public KeyControl qKey { get; }
	public KeyControl rKey { get; }
	public KeyControl sKey { get; }
	public KeyControl tKey { get; }
	public KeyControl uKey { get; }
	public KeyControl vKey { get; }
	public KeyControl wKey { get; }
	public KeyControl xKey { get; }
	public KeyControl yKey { get; }
	public KeyControl zKey { get; }
	public KeyControl digit1Key { get; }
	public KeyControl digit2Key { get; }
	public KeyControl digit3Key { get; }
	public KeyControl digit4Key { get; }
	public KeyControl digit5Key { get; }
	public KeyControl digit6Key { get; }
	public KeyControl digit7Key { get; }
	public KeyControl digit8Key { get; }
	public KeyControl digit9Key { get; }
	public KeyControl digit0Key { get; }
	public KeyControl leftShiftKey { get; }
	public KeyControl rightShiftKey { get; }
	public KeyControl leftAltKey { get; }
	public KeyControl rightAltKey { get; }
	public KeyControl leftCtrlKey { get; }
	public KeyControl rightCtrlKey { get; }
	public KeyControl leftMetaKey { get; }
	public KeyControl rightMetaKey { get; }
	public KeyControl leftWindowsKey { get; }
	public KeyControl rightWindowsKey { get; }
	public KeyControl leftAppleKey { get; }
	public KeyControl rightAppleKey { get; }
	public KeyControl leftCommandKey { get; }
	public KeyControl rightCommandKey { get; }
	public KeyControl contextMenuKey { get; }
	public KeyControl escapeKey { get; }
	public KeyControl leftArrowKey { get; }
	public KeyControl rightArrowKey { get; }
	public KeyControl upArrowKey { get; }
	public KeyControl downArrowKey { get; }
	public KeyControl backspaceKey { get; }
	public KeyControl pageDownKey { get; }
	public KeyControl pageUpKey { get; }
	public KeyControl homeKey { get; }
	public KeyControl endKey { get; }
	public KeyControl insertKey { get; }
	public KeyControl deleteKey { get; }
	public KeyControl capsLockKey { get; }
	public KeyControl scrollLockKey { get; }
	public KeyControl numLockKey { get; }
	public KeyControl printScreenKey { get; }
	public KeyControl pauseKey { get; }
	public KeyControl numpadEnterKey { get; }
	public KeyControl numpadDivideKey { get; }
	public KeyControl numpadMultiplyKey { get; }
	public KeyControl numpadMinusKey { get; }
	public KeyControl numpadPlusKey { get; }
	public KeyControl numpadPeriodKey { get; }
	public KeyControl numpadEqualsKey { get; }
	public KeyControl numpad0Key { get; }
	public KeyControl numpad1Key { get; }
	public KeyControl numpad2Key { get; }
	public KeyControl numpad3Key { get; }
	public KeyControl numpad4Key { get; }
	public KeyControl numpad5Key { get; }
	public KeyControl numpad6Key { get; }
	public KeyControl numpad7Key { get; }
	public KeyControl numpad8Key { get; }
	public KeyControl numpad9Key { get; }
	public KeyControl f1Key { get; }
	public KeyControl f2Key { get; }
	public KeyControl f3Key { get; }
	public KeyControl f4Key { get; }
	public KeyControl f5Key { get; }
	public KeyControl f6Key { get; }
	public KeyControl f7Key { get; }
	public KeyControl f8Key { get; }
	public KeyControl f9Key { get; }
	public KeyControl f10Key { get; }
	public KeyControl f11Key { get; }
	public KeyControl f12Key { get; }
	public KeyControl oem1Key { get; }
	public KeyControl oem2Key { get; }
	public KeyControl oem3Key { get; }
	public KeyControl oem4Key { get; }
	public KeyControl oem5Key { get; }
	public KeyControl f13Key { get; }
	public KeyControl f14Key { get; }
	public KeyControl f15Key { get; }
	public KeyControl f16Key { get; }
	public KeyControl f17Key { get; }
	public KeyControl f18Key { get; }
	public KeyControl f19Key { get; }
	public KeyControl f20Key { get; }
	public KeyControl f21Key { get; }
	public KeyControl f22Key { get; }
	public KeyControl f23Key { get; }
	public KeyControl f24Key { get; }
	public ButtonControl shiftKey { get; set; }
	public ButtonControl ctrlKey { get; set; }
	public ButtonControl altKey { get; set; }
	public ButtonControl imeSelected { get; set; }
	public KeyControl Item { get; }
	public ReadOnlyArray<KeyControl> allKeys { get; }
	public static Keyboard current { get; set; }
	protected KeyControl[] keys { get; set; }

	// Methods

	// RVA: 0x27CA7E0 Offset: 0x27C91E0 VA: 0x1827CA7E0
	public void add_onTextInput(Action<char> value) { }

	// RVA: 0x27CB210 Offset: 0x27C9C10 VA: 0x1827CB210
	public void remove_onTextInput(Action<char> value) { }

	// RVA: 0x27CA700 Offset: 0x27C9100 VA: 0x1827CA700
	public void add_onIMECompositionChange(Action<IMECompositionString> value) { }

	// RVA: 0x27CB1C0 Offset: 0x27C9BC0 VA: 0x1827CB1C0
	public void remove_onIMECompositionChange(Action<IMECompositionString> value) { }

	// RVA: 0x27CA5E0 Offset: 0x27C8FE0 VA: 0x1827CA5E0
	public void SetIMEEnabled(bool enabled) { }

	// RVA: 0x27CA570 Offset: 0x27C8F70 VA: 0x1827CA570
	public void SetIMECursorPosition(Vector2 position) { }

	// RVA: 0x27CADB0 Offset: 0x27C97B0 VA: 0x1827CADB0
	public string get_keyboardLayout() { }

	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_keyboardLayout(string value) { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AnyKeyControl get_anyKey() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_anyKey(AnyKeyControl value) { }

	// RVA: 0x27CB120 Offset: 0x27C9B20 VA: 0x1827CB120
	public KeyControl get_spaceKey() { }

	// RVA: 0x27CAB80 Offset: 0x27C9580 VA: 0x1827CAB80
	public KeyControl get_enterKey() { }

	// RVA: 0x27CB140 Offset: 0x27C9B40 VA: 0x1827CB140
	public KeyControl get_tabKey() { }

	// RVA: 0x27CA9E0 Offset: 0x27C93E0 VA: 0x1827CA9E0
	public KeyControl get_backquoteKey() { }

	// RVA: 0x27CB060 Offset: 0x27C9A60 VA: 0x1827CB060
	public KeyControl get_quoteKey() { }

	// RVA: 0x27CB100 Offset: 0x27C9B00 VA: 0x1827CB100
	public KeyControl get_semicolonKey() { }

	// RVA: 0x27CAA30 Offset: 0x27C9430 VA: 0x1827CAA30
	public KeyControl get_commaKey() { }

	// RVA: 0x27CB030 Offset: 0x27C9A30 VA: 0x1827CB030
	public KeyControl get_periodKey() { }

	// RVA: 0x27CB110 Offset: 0x27C9B10 VA: 0x1827CB110
	public KeyControl get_slashKey() { }

	// RVA: 0x27CA9F0 Offset: 0x27C93F0 VA: 0x1827CA9F0
	public KeyControl get_backslashKey() { }

	// RVA: 0x27CAE10 Offset: 0x27C9810 VA: 0x1827CAE10
	public KeyControl get_leftBracketKey() { }

	// RVA: 0x27CB0B0 Offset: 0x27C9AB0 VA: 0x1827CB0B0
	public KeyControl get_rightBracketKey() { }

	// RVA: 0x27CAE50 Offset: 0x27C9850 VA: 0x1827CAE50
	public KeyControl get_minusKey() { }

	// RVA: 0x27CAB90 Offset: 0x27C9590 VA: 0x1827CAB90
	public KeyControl get_equalsKey() { }

	// RVA: 0x27CA960 Offset: 0x27C9360 VA: 0x1827CA960
	public KeyControl get_aKey() { }

	// RVA: 0x27CA9D0 Offset: 0x27C93D0 VA: 0x1827CA9D0
	public KeyControl get_bKey() { }

	// RVA: 0x27CAA10 Offset: 0x27C9410 VA: 0x1827CAA10
	public KeyControl get_cKey() { }

	// RVA: 0x27CAA90 Offset: 0x27C9490 VA: 0x1827CAA90
	public KeyControl get_dKey() { }

	// RVA: 0x27CAB60 Offset: 0x27C9560 VA: 0x1827CAB60
	public KeyControl get_eKey() { }

	// RVA: 0x27CAD30 Offset: 0x27C9730 VA: 0x1827CAD30
	public KeyControl get_fKey() { }

	// RVA: 0x27CAD40 Offset: 0x27C9740 VA: 0x1827CAD40
	public KeyControl get_gKey() { }

	// RVA: 0x27CAD50 Offset: 0x27C9750 VA: 0x1827CAD50
	public KeyControl get_hKey() { }

	// RVA: 0x27CAD70 Offset: 0x27C9770 VA: 0x1827CAD70
	public KeyControl get_iKey() { }

	// RVA: 0x27CAD90 Offset: 0x27C9790 VA: 0x1827CAD90
	public KeyControl get_jKey() { }

	// RVA: 0x27CADA0 Offset: 0x27C97A0 VA: 0x1827CADA0
	public KeyControl get_kKey() { }

	// RVA: 0x27CADD0 Offset: 0x27C97D0 VA: 0x1827CADD0
	public KeyControl get_lKey() { }

	// RVA: 0x27CAE40 Offset: 0x27C9840 VA: 0x1827CAE40
	public KeyControl get_mKey() { }

	// RVA: 0x27CAE60 Offset: 0x27C9860 VA: 0x1827CAE60
	public KeyControl get_nKey() { }

	// RVA: 0x27CAF90 Offset: 0x27C9990 VA: 0x1827CAF90
	public KeyControl get_oKey() { }

	// RVA: 0x27CAFF0 Offset: 0x27C99F0 VA: 0x1827CAFF0
	public KeyControl get_pKey() { }

	// RVA: 0x27CB050 Offset: 0x27C9A50 VA: 0x1827CB050
	public KeyControl get_qKey() { }

	// RVA: 0x27CB070 Offset: 0x27C9A70 VA: 0x1827CB070
	public KeyControl get_rKey() { }

	// RVA: 0x27CB0E0 Offset: 0x27C9AE0 VA: 0x1827CB0E0
	public KeyControl get_sKey() { }

	// RVA: 0x27CB130 Offset: 0x27C9B30 VA: 0x1827CB130
	public KeyControl get_tKey() { }

	// RVA: 0x27CB150 Offset: 0x27C9B50 VA: 0x1827CB150
	public KeyControl get_uKey() { }

	// RVA: 0x27CB170 Offset: 0x27C9B70 VA: 0x1827CB170
	public KeyControl get_vKey() { }

	// RVA: 0x27CB180 Offset: 0x27C9B80 VA: 0x1827CB180
	public KeyControl get_wKey() { }

	// RVA: 0x27CB190 Offset: 0x27C9B90 VA: 0x1827CB190
	public KeyControl get_xKey() { }

	// RVA: 0x27CB1A0 Offset: 0x27C9BA0 VA: 0x1827CB1A0
	public KeyControl get_yKey() { }

	// RVA: 0x27CB1B0 Offset: 0x27C9BB0 VA: 0x1827CB1B0
	public KeyControl get_zKey() { }

	// RVA: 0x27CAAC0 Offset: 0x27C94C0 VA: 0x1827CAAC0
	public KeyControl get_digit1Key() { }

	// RVA: 0x27CAAD0 Offset: 0x27C94D0 VA: 0x1827CAAD0
	public KeyControl get_digit2Key() { }

	// RVA: 0x27CAAE0 Offset: 0x27C94E0 VA: 0x1827CAAE0
	public KeyControl get_digit3Key() { }

	// RVA: 0x27CAAF0 Offset: 0x27C94F0 VA: 0x1827CAAF0
	public KeyControl get_digit4Key() { }

	// RVA: 0x27CAB00 Offset: 0x27C9500 VA: 0x1827CAB00
	public KeyControl get_digit5Key() { }

	// RVA: 0x27CAB10 Offset: 0x27C9510 VA: 0x1827CAB10
	public KeyControl get_digit6Key() { }

	// RVA: 0x27CAB20 Offset: 0x27C9520 VA: 0x1827CAB20
	public KeyControl get_digit7Key() { }

	// RVA: 0x27CAB30 Offset: 0x27C9530 VA: 0x1827CAB30
	public KeyControl get_digit8Key() { }

	// RVA: 0x27CAB40 Offset: 0x27C9540 VA: 0x1827CAB40
	public KeyControl get_digit9Key() { }

	// RVA: 0x27CAAB0 Offset: 0x27C94B0 VA: 0x1827CAAB0
	public KeyControl get_digit0Key() { }

	// RVA: 0x27CAE30 Offset: 0x27C9830 VA: 0x1827CAE30
	public KeyControl get_leftShiftKey() { }

	// RVA: 0x27CB0D0 Offset: 0x27C9AD0 VA: 0x1827CB0D0
	public KeyControl get_rightShiftKey() { }

	// RVA: 0x27CADE0 Offset: 0x27C97E0 VA: 0x1827CADE0
	public KeyControl get_leftAltKey() { }

	// RVA: 0x27CB080 Offset: 0x27C9A80 VA: 0x1827CB080
	public KeyControl get_rightAltKey() { }

	// RVA: 0x27CAE20 Offset: 0x27C9820 VA: 0x1827CAE20
	public KeyControl get_leftCtrlKey() { }

	// RVA: 0x27CB0C0 Offset: 0x27C9AC0 VA: 0x1827CB0C0
	public KeyControl get_rightCtrlKey() { }

	// RVA: 0x27CADF0 Offset: 0x27C97F0 VA: 0x1827CADF0
	public KeyControl get_leftMetaKey() { }

	// RVA: 0x27CB090 Offset: 0x27C9A90 VA: 0x1827CB090
	public KeyControl get_rightMetaKey() { }

	// RVA: 0x27CADF0 Offset: 0x27C97F0 VA: 0x1827CADF0
	public KeyControl get_leftWindowsKey() { }

	// RVA: 0x27CB090 Offset: 0x27C9A90 VA: 0x1827CB090
	public KeyControl get_rightWindowsKey() { }

	// RVA: 0x27CADF0 Offset: 0x27C97F0 VA: 0x1827CADF0
	public KeyControl get_leftAppleKey() { }

	// RVA: 0x27CB090 Offset: 0x27C9A90 VA: 0x1827CB090
	public KeyControl get_rightAppleKey() { }

	// RVA: 0x27CADF0 Offset: 0x27C97F0 VA: 0x1827CADF0
	public KeyControl get_leftCommandKey() { }

	// RVA: 0x27CB090 Offset: 0x27C9A90 VA: 0x1827CB090
	public KeyControl get_rightCommandKey() { }

	// RVA: 0x27CAA40 Offset: 0x27C9440 VA: 0x1827CAA40
	public KeyControl get_contextMenuKey() { }

	// RVA: 0x27CABA0 Offset: 0x27C95A0 VA: 0x1827CABA0
	public KeyControl get_escapeKey() { }

	// RVA: 0x27CAE00 Offset: 0x27C9800 VA: 0x1827CAE00
	public KeyControl get_leftArrowKey() { }

	// RVA: 0x27CB0A0 Offset: 0x27C9AA0 VA: 0x1827CB0A0
	public KeyControl get_rightArrowKey() { }

	// RVA: 0x27CB160 Offset: 0x27C9B60 VA: 0x1827CB160
	public KeyControl get_upArrowKey() { }

	// RVA: 0x27CAB50 Offset: 0x27C9550 VA: 0x1827CAB50
	public KeyControl get_downArrowKey() { }

	// RVA: 0x27CAA00 Offset: 0x27C9400 VA: 0x1827CAA00
	public KeyControl get_backspaceKey() { }

	// RVA: 0x27CB000 Offset: 0x27C9A00 VA: 0x1827CB000
	public KeyControl get_pageDownKey() { }

	// RVA: 0x27CB010 Offset: 0x27C9A10 VA: 0x1827CB010
	public KeyControl get_pageUpKey() { }

	// RVA: 0x27CAD60 Offset: 0x27C9760 VA: 0x1827CAD60
	public KeyControl get_homeKey() { }

	// RVA: 0x27CAB70 Offset: 0x27C9570 VA: 0x1827CAB70
	public KeyControl get_endKey() { }

	// RVA: 0x27CAD80 Offset: 0x27C9780 VA: 0x1827CAD80
	public KeyControl get_insertKey() { }

	// RVA: 0x27CAAA0 Offset: 0x27C94A0 VA: 0x1827CAAA0
	public KeyControl get_deleteKey() { }

	// RVA: 0x27CAA20 Offset: 0x27C9420 VA: 0x1827CAA20
	public KeyControl get_capsLockKey() { }

	// RVA: 0x27CB0F0 Offset: 0x27C9AF0 VA: 0x1827CB0F0
	public KeyControl get_scrollLockKey() { }

	// RVA: 0x27CAE70 Offset: 0x27C9870 VA: 0x1827CAE70
	public KeyControl get_numLockKey() { }

	// RVA: 0x27CB040 Offset: 0x27C9A40 VA: 0x1827CB040
	public KeyControl get_printScreenKey() { }

	// RVA: 0x27CB020 Offset: 0x27C9A20 VA: 0x1827CB020
	public KeyControl get_pauseKey() { }

	// RVA: 0x27CAF30 Offset: 0x27C9930 VA: 0x1827CAF30
	public KeyControl get_numpadEnterKey() { }

	// RVA: 0x27CAF20 Offset: 0x27C9920 VA: 0x1827CAF20
	public KeyControl get_numpadDivideKey() { }

	// RVA: 0x27CAF60 Offset: 0x27C9960 VA: 0x1827CAF60
	public KeyControl get_numpadMultiplyKey() { }

	// RVA: 0x27CAF50 Offset: 0x27C9950 VA: 0x1827CAF50
	public KeyControl get_numpadMinusKey() { }

	// RVA: 0x27CAF80 Offset: 0x27C9980 VA: 0x1827CAF80
	public KeyControl get_numpadPlusKey() { }

	// RVA: 0x27CAF70 Offset: 0x27C9970 VA: 0x1827CAF70
	public KeyControl get_numpadPeriodKey() { }

	// RVA: 0x27CAF40 Offset: 0x27C9940 VA: 0x1827CAF40
	public KeyControl get_numpadEqualsKey() { }

	// RVA: 0x27CAE80 Offset: 0x27C9880 VA: 0x1827CAE80
	public KeyControl get_numpad0Key() { }

	// RVA: 0x27CAE90 Offset: 0x27C9890 VA: 0x1827CAE90
	public KeyControl get_numpad1Key() { }

	// RVA: 0x27CAEA0 Offset: 0x27C98A0 VA: 0x1827CAEA0
	public KeyControl get_numpad2Key() { }

	// RVA: 0x27CAEB0 Offset: 0x27C98B0 VA: 0x1827CAEB0
	public KeyControl get_numpad3Key() { }

	// RVA: 0x27CAEC0 Offset: 0x27C98C0 VA: 0x1827CAEC0
	public KeyControl get_numpad4Key() { }

	// RVA: 0x27CAED0 Offset: 0x27C98D0 VA: 0x1827CAED0
	public KeyControl get_numpad5Key() { }

	// RVA: 0x27CAEE0 Offset: 0x27C98E0 VA: 0x1827CAEE0
	public KeyControl get_numpad6Key() { }

	// RVA: 0x27CAEF0 Offset: 0x27C98F0 VA: 0x1827CAEF0
	public KeyControl get_numpad7Key() { }

	// RVA: 0x27CAF00 Offset: 0x27C9900 VA: 0x1827CAF00
	public KeyControl get_numpad8Key() { }

	// RVA: 0x27CAF10 Offset: 0x27C9910 VA: 0x1827CAF10
	public KeyControl get_numpad9Key() { }

	// RVA: 0x27CAC50 Offset: 0x27C9650 VA: 0x1827CAC50
	public KeyControl get_f1Key() { }

	// RVA: 0x27CACB0 Offset: 0x27C96B0 VA: 0x1827CACB0
	public KeyControl get_f2Key() { }

	// RVA: 0x27CACC0 Offset: 0x27C96C0 VA: 0x1827CACC0
	public KeyControl get_f3Key() { }

	// RVA: 0x27CACD0 Offset: 0x27C96D0 VA: 0x1827CACD0
	public KeyControl get_f4Key() { }

	// RVA: 0x27CACE0 Offset: 0x27C96E0 VA: 0x1827CACE0
	public KeyControl get_f5Key() { }

	// RVA: 0x27CACF0 Offset: 0x27C96F0 VA: 0x1827CACF0
	public KeyControl get_f6Key() { }

	// RVA: 0x27CAD00 Offset: 0x27C9700 VA: 0x1827CAD00
	public KeyControl get_f7Key() { }

	// RVA: 0x27CAD10 Offset: 0x27C9710 VA: 0x1827CAD10
	public KeyControl get_f8Key() { }

	// RVA: 0x27CAD20 Offset: 0x27C9720 VA: 0x1827CAD20
	public KeyControl get_f9Key() { }

	// RVA: 0x27CABB0 Offset: 0x27C95B0 VA: 0x1827CABB0
	public KeyControl get_f10Key() { }

	// RVA: 0x27CABC0 Offset: 0x27C95C0 VA: 0x1827CABC0
	public KeyControl get_f11Key() { }

	// RVA: 0x27CABD0 Offset: 0x27C95D0 VA: 0x1827CABD0
	public KeyControl get_f12Key() { }

	// RVA: 0x27CAFA0 Offset: 0x27C99A0 VA: 0x1827CAFA0
	public KeyControl get_oem1Key() { }

	// RVA: 0x27CAFB0 Offset: 0x27C99B0 VA: 0x1827CAFB0
	public KeyControl get_oem2Key() { }

	// RVA: 0x27CAFC0 Offset: 0x27C99C0 VA: 0x1827CAFC0
	public KeyControl get_oem3Key() { }

	// RVA: 0x27CAFD0 Offset: 0x27C99D0 VA: 0x1827CAFD0
	public KeyControl get_oem4Key() { }

	// RVA: 0x27CAFE0 Offset: 0x27C99E0 VA: 0x1827CAFE0
	public KeyControl get_oem5Key() { }

	// RVA: 0x27CABE0 Offset: 0x27C95E0 VA: 0x1827CABE0
	public KeyControl get_f13Key() { }

	// RVA: 0x27CABF0 Offset: 0x27C95F0 VA: 0x1827CABF0
	public KeyControl get_f14Key() { }

	// RVA: 0x27CAC00 Offset: 0x27C9600 VA: 0x1827CAC00
	public KeyControl get_f15Key() { }

	// RVA: 0x27CAC10 Offset: 0x27C9610 VA: 0x1827CAC10
	public KeyControl get_f16Key() { }

	// RVA: 0x27CAC20 Offset: 0x27C9620 VA: 0x1827CAC20
	public KeyControl get_f17Key() { }

	// RVA: 0x27CAC30 Offset: 0x27C9630 VA: 0x1827CAC30
	public KeyControl get_f18Key() { }

	// RVA: 0x27CAC40 Offset: 0x27C9640 VA: 0x1827CAC40
	public KeyControl get_f19Key() { }

	// RVA: 0x27CAC60 Offset: 0x27C9660 VA: 0x1827CAC60
	public KeyControl get_f20Key() { }

	// RVA: 0x27CAC70 Offset: 0x27C9670 VA: 0x1827CAC70
	public KeyControl get_f21Key() { }

	// RVA: 0x27CAC80 Offset: 0x27C9680 VA: 0x1827CAC80
	public KeyControl get_f22Key() { }

	// RVA: 0x27CAC90 Offset: 0x27C9690 VA: 0x1827CAC90
	public KeyControl get_f23Key() { }

	// RVA: 0x27CACA0 Offset: 0x27C96A0 VA: 0x1827CACA0
	public KeyControl get_f24Key() { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_shiftKey() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_shiftKey(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public ButtonControl get_ctrlKey() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_ctrlKey(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public ButtonControl get_altKey() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	protected void set_altKey(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public ButtonControl get_imeSelected() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_imeSelected(ButtonControl value) { }

	// RVA: 0x27CA8C0 Offset: 0x27C92C0 VA: 0x1827CA8C0
	public KeyControl get_Item(Key key) { }

	// RVA: 0x27CA970 Offset: 0x27C9370 VA: 0x1827CA970
	public ReadOnlyArray<KeyControl> get_allKeys() { }

	[CompilerGenerated]
	// RVA: 0x27CAA50 Offset: 0x27C9450 VA: 0x1827CAA50
	public static Keyboard get_current() { }

	[CompilerGenerated]
	// RVA: 0x27CB260 Offset: 0x27C9C60 VA: 0x1827CB260
	private static void set_current(Keyboard value) { }

	// RVA: 0x27CA1D0 Offset: 0x27C8BD0 VA: 0x1827CA1D0 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x27CA340 Offset: 0x27C8D40 VA: 0x1827CA340 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x27C8840 Offset: 0x27C7240 VA: 0x1827C8840 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x27CA460 Offset: 0x27C8E60 VA: 0x1827CA460 Slot: 14
	protected override void RefreshConfiguration() { }

	// RVA: 0x27CA3D0 Offset: 0x27C8DD0 VA: 0x1827CA3D0 Slot: 22
	public void OnTextInput(char character) { }

	// RVA: 0x27C8720 Offset: 0x27C7120 VA: 0x1827C8720
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	// RVA: 0x27CA230 Offset: 0x27C8C30 VA: 0x1827CA230 Slot: 23
	public void OnIMECompositionChanged(IMECompositionString compositionString) { }

	// RVA: 0x27CA660 Offset: 0x27C9060 VA: 0x1827CA660 Slot: 24
	private bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) { }

	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	protected KeyControl[] get_keys() { }

	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_keys(KeyControl[] value) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
