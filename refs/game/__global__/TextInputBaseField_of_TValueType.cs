public abstract class TextInputBaseField<TValueType> : BaseField<TValueType> // TypeDefIndex: 6332
{
	// Fields
	private static CustomStyleProperty<Color> s_SelectionColorProperty; // 0x0
	private static CustomStyleProperty<Color> s_CursorColorProperty; // 0x0
	private int m_VisualInputTabIndex; // 0x0
	private TextInputBaseField.TextInputBase<TValueType> m_TextInputBase; // 0x0
	internal bool m_UpdateTextFromValue; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	internal static readonly string multilineContainerClassName; // 0x0
	public static readonly string singleLineInputUssClassName; // 0x0
	public static readonly string multilineInputUssClassName; // 0x0
	internal static readonly string multilineInputWithScrollViewUssClassName; // 0x0
	public static readonly string textInputUssName; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> onIsReadOnlyChanged; // 0x0

	// Properties
	protected internal TextInputBaseField.TextInputBase<TValueType> textInputBase { get; }
	public string text { get; set; }
	public bool isReadOnly { get; set; }
	public bool isPasswordField { set; }
	public bool autoCorrection { set; }
	public bool hideMobileInput { set; }
	public TouchScreenKeyboardType keyboardType { set; }
	public ITextEdition textEdition { get; }
	public int maxLength { set; }
	public bool isDelayed { get; set; }
	public char maskChar { set; }
	internal override bool canSwitchToMixedValue { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected internal TextInputBaseField.TextInputBase<TValueType> get_textInputBase() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243710 Offset: 0x1242110 VA: 0x181243710
	|-TextInputBaseField<double>.get_textInputBase
	|-TextInputBaseField<int>.get_textInputBase
	|-TextInputBaseField<long>.get_textInputBase
	|-TextInputBaseField<object>.get_textInputBase
	|-TextInputBaseField<float>.get_textInputBase
	|-TextInputBaseField<uint>.get_textInputBase
	|-TextInputBaseField<ulong>.get_textInputBase
	|
	|-RVA: 0x1243720 Offset: 0x1242120 VA: 0x181243720
	|-TextInputBaseField<Hash128>.get_textInputBase
	|
	|-RVA: 0x125FF20 Offset: 0x125E920 VA: 0x18125FF20
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_textInputBase
	*/

	// RVA: -1 Offset: -1
	public string get_text() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243730 Offset: 0x1242130 VA: 0x181243730
	|-TextInputBaseField<double>.get_text
	|-TextInputBaseField<int>.get_text
	|-TextInputBaseField<float>.get_text
	|-TextInputBaseField<uint>.get_text
	|-TextInputBaseField<ulong>.get_text
	|
	|-RVA: 0x1243760 Offset: 0x1242160 VA: 0x181243760
	|-TextInputBaseField<Hash128>.get_text
	|
	|-RVA: 0x1243790 Offset: 0x1242190 VA: 0x181243790
	|-TextInputBaseField<long>.get_text
	|-TextInputBaseField<object>.get_text
	|
	|-RVA: 0x125FF50 Offset: 0x125E950 VA: 0x18125FF50
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_text
	*/

	// RVA: -1 Offset: -1
	protected internal void set_text(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244F80 Offset: 0x1243980 VA: 0x181244F80
	|-TextInputBaseField<double>.set_text
	|-TextInputBaseField<int>.set_text
	|-TextInputBaseField<float>.set_text
	|-TextInputBaseField<uint>.set_text
	|-TextInputBaseField<ulong>.set_text
	|
	|-RVA: 0x1244F50 Offset: 0x1243950 VA: 0x181244F50
	|-TextInputBaseField<Hash128>.set_text
	|
	|-RVA: 0x1244ED0 Offset: 0x12438D0 VA: 0x181244ED0
	|-TextInputBaseField<long>.set_text
	|-TextInputBaseField<object>.set_text
	|
	|-RVA: 0x12612D0 Offset: 0x125FCD0 VA: 0x1812612D0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_text
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void add_onIsReadOnlyChanged(Action<bool> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1242F50 Offset: 0x1241950 VA: 0x181242F50
	|-TextInputBaseField<double>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x1243010 Offset: 0x1241A10 VA: 0x181243010
	|-TextInputBaseField<Hash128>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x1242D10 Offset: 0x1241710 VA: 0x181242D10
	|-TextInputBaseField<int>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x1242DD0 Offset: 0x12417D0 VA: 0x181242DD0
	|-TextInputBaseField<long>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x1242E90 Offset: 0x1241890 VA: 0x181242E90
	|-TextInputBaseField<object>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x125F940 Offset: 0x125E340 VA: 0x18125F940
	|-TextInputBaseField<float>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x125F6B0 Offset: 0x125E0B0 VA: 0x18125F6B0
	|-TextInputBaseField<uint>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x125F880 Offset: 0x125E280 VA: 0x18125F880
	|-TextInputBaseField<ulong>.add_onIsReadOnlyChanged
	|
	|-RVA: 0x125F770 Offset: 0x125E170 VA: 0x18125F770
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.add_onIsReadOnlyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void remove_onIsReadOnlyChanged(Action<bool> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243950 Offset: 0x1242350 VA: 0x181243950
	|-TextInputBaseField<double>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x12437D0 Offset: 0x12421D0 VA: 0x1812437D0
	|-TextInputBaseField<Hash128>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1243A10 Offset: 0x1242410 VA: 0x181243A10
	|-TextInputBaseField<int>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1243890 Offset: 0x1242290 VA: 0x181243890
	|-TextInputBaseField<long>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1243AD0 Offset: 0x12424D0 VA: 0x181243AD0
	|-TextInputBaseField<object>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x125FFB0 Offset: 0x125E9B0 VA: 0x18125FFB0
	|-TextInputBaseField<float>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1260240 Offset: 0x125EC40 VA: 0x181260240
	|-TextInputBaseField<uint>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1260180 Offset: 0x125EB80 VA: 0x181260180
	|-TextInputBaseField<ulong>.remove_onIsReadOnlyChanged
	|
	|-RVA: 0x1260070 Offset: 0x125EA70 VA: 0x181260070
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.remove_onIsReadOnlyChanged
	*/

	// RVA: -1 Offset: -1
	public bool get_isReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12434F0 Offset: 0x1241EF0 VA: 0x1812434F0
	|-TextInputBaseField<double>.get_isReadOnly
	|
	|-RVA: 0x1243640 Offset: 0x1242040 VA: 0x181243640
	|-TextInputBaseField<Hash128>.get_isReadOnly
	|
	|-RVA: 0x1243560 Offset: 0x1241F60 VA: 0x181243560
	|-TextInputBaseField<int>.get_isReadOnly
	|
	|-RVA: 0x1243480 Offset: 0x1241E80 VA: 0x181243480
	|-TextInputBaseField<long>.get_isReadOnly
	|
	|-RVA: 0x12435D0 Offset: 0x1241FD0 VA: 0x1812435D0
	|-TextInputBaseField<object>.get_isReadOnly
	|
	|-RVA: 0x125FE40 Offset: 0x125E840 VA: 0x18125FE40
	|-TextInputBaseField<float>.get_isReadOnly
	|
	|-RVA: 0x125FCF0 Offset: 0x125E6F0 VA: 0x18125FCF0
	|-TextInputBaseField<uint>.get_isReadOnly
	|
	|-RVA: 0x125FDD0 Offset: 0x125E7D0 VA: 0x18125FDD0
	|-TextInputBaseField<ulong>.get_isReadOnly
	|
	|-RVA: 0x125FD60 Offset: 0x125E760 VA: 0x18125FD60
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isReadOnly
	*/

	// RVA: -1 Offset: -1
	public void set_isReadOnly(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244610 Offset: 0x1243010 VA: 0x181244610
	|-TextInputBaseField<double>.set_isReadOnly
	|
	|-RVA: 0x1244430 Offset: 0x1242E30 VA: 0x181244430
	|-TextInputBaseField<Hash128>.set_isReadOnly
	|
	|-RVA: 0x12446B0 Offset: 0x12430B0 VA: 0x1812446B0
	|-TextInputBaseField<int>.set_isReadOnly
	|
	|-RVA: 0x1244570 Offset: 0x1242F70 VA: 0x181244570
	|-TextInputBaseField<long>.set_isReadOnly
	|
	|-RVA: 0x12444D0 Offset: 0x1242ED0 VA: 0x1812444D0
	|-TextInputBaseField<object>.set_isReadOnly
	|
	|-RVA: 0x1260C20 Offset: 0x125F620 VA: 0x181260C20
	|-TextInputBaseField<float>.set_isReadOnly
	|
	|-RVA: 0x1260B80 Offset: 0x125F580 VA: 0x181260B80
	|-TextInputBaseField<uint>.set_isReadOnly
	|
	|-RVA: 0x1260A20 Offset: 0x125F420 VA: 0x181260A20
	|-TextInputBaseField<ulong>.set_isReadOnly
	|
	|-RVA: 0x1260AC0 Offset: 0x125F4C0 VA: 0x181260AC0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isReadOnly
	*/

	// RVA: -1 Offset: -1
	public void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244310 Offset: 0x1242D10 VA: 0x181244310
	|-TextInputBaseField<double>.set_isPasswordField
	|-TextInputBaseField<int>.set_isPasswordField
	|-TextInputBaseField<long>.set_isPasswordField
	|-TextInputBaseField<object>.set_isPasswordField
	|-TextInputBaseField<float>.set_isPasswordField
	|-TextInputBaseField<uint>.set_isPasswordField
	|-TextInputBaseField<ulong>.set_isPasswordField
	|
	|-RVA: 0x12443A0 Offset: 0x1242DA0 VA: 0x1812443A0
	|-TextInputBaseField<Hash128>.set_isPasswordField
	|
	|-RVA: 0x1260930 Offset: 0x125F330 VA: 0x181260930
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	// RVA: -1 Offset: -1
	public void set_autoCorrection(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243C10 Offset: 0x1242610 VA: 0x181243C10
	|-TextInputBaseField<double>.set_autoCorrection
	|
	|-RVA: 0x1243D90 Offset: 0x1242790 VA: 0x181243D90
	|-TextInputBaseField<Hash128>.set_autoCorrection
	|
	|-RVA: 0x1243D10 Offset: 0x1242710 VA: 0x181243D10
	|-TextInputBaseField<int>.set_autoCorrection
	|
	|-RVA: 0x1243C90 Offset: 0x1242690 VA: 0x181243C90
	|-TextInputBaseField<long>.set_autoCorrection
	|
	|-RVA: 0x1243B90 Offset: 0x1242590 VA: 0x181243B90
	|-TextInputBaseField<object>.set_autoCorrection
	|
	|-RVA: 0x1260490 Offset: 0x125EE90 VA: 0x181260490
	|-TextInputBaseField<float>.set_autoCorrection
	|
	|-RVA: 0x1260300 Offset: 0x125ED00 VA: 0x181260300
	|-TextInputBaseField<uint>.set_autoCorrection
	|
	|-RVA: 0x1260410 Offset: 0x125EE10 VA: 0x181260410
	|-TextInputBaseField<ulong>.set_autoCorrection
	|
	|-RVA: 0x1260380 Offset: 0x125ED80 VA: 0x181260380
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_autoCorrection
	*/

	// RVA: -1 Offset: -1
	public void set_hideMobileInput(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243E90 Offset: 0x1242890 VA: 0x181243E90
	|-TextInputBaseField<double>.set_hideMobileInput
	|
	|-RVA: 0x1243F10 Offset: 0x1242910 VA: 0x181243F10
	|-TextInputBaseField<Hash128>.set_hideMobileInput
	|
	|-RVA: 0x1243F90 Offset: 0x1242990 VA: 0x181243F90
	|-TextInputBaseField<int>.set_hideMobileInput
	|
	|-RVA: 0x1244010 Offset: 0x1242A10 VA: 0x181244010
	|-TextInputBaseField<long>.set_hideMobileInput
	|
	|-RVA: 0x1243E10 Offset: 0x1242810 VA: 0x181243E10
	|-TextInputBaseField<object>.set_hideMobileInput
	|
	|-RVA: 0x1260620 Offset: 0x125F020 VA: 0x181260620
	|-TextInputBaseField<float>.set_hideMobileInput
	|
	|-RVA: 0x12605A0 Offset: 0x125EFA0 VA: 0x1812605A0
	|-TextInputBaseField<uint>.set_hideMobileInput
	|
	|-RVA: 0x12606A0 Offset: 0x125F0A0 VA: 0x1812606A0
	|-TextInputBaseField<ulong>.set_hideMobileInput
	|
	|-RVA: 0x1260510 Offset: 0x125EF10 VA: 0x181260510
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_hideMobileInput
	*/

	// RVA: -1 Offset: -1
	public void set_keyboardType(TouchScreenKeyboardType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244950 Offset: 0x1243350 VA: 0x181244950
	|-TextInputBaseField<double>.set_keyboardType
	|
	|-RVA: 0x1244850 Offset: 0x1243250 VA: 0x181244850
	|-TextInputBaseField<Hash128>.set_keyboardType
	|
	|-RVA: 0x1244750 Offset: 0x1243150 VA: 0x181244750
	|-TextInputBaseField<int>.set_keyboardType
	|
	|-RVA: 0x12448D0 Offset: 0x12432D0 VA: 0x1812448D0
	|-TextInputBaseField<long>.set_keyboardType
	|
	|-RVA: 0x12447D0 Offset: 0x12431D0 VA: 0x1812447D0
	|-TextInputBaseField<object>.set_keyboardType
	|
	|-RVA: 0x1260E40 Offset: 0x125F840 VA: 0x181260E40
	|-TextInputBaseField<float>.set_keyboardType
	|
	|-RVA: 0x1260D40 Offset: 0x125F740 VA: 0x181260D40
	|-TextInputBaseField<uint>.set_keyboardType
	|
	|-RVA: 0x1260CC0 Offset: 0x125F6C0 VA: 0x181260CC0
	|-TextInputBaseField<ulong>.set_keyboardType
	|
	|-RVA: 0x1260DC0 Offset: 0x125F7C0 VA: 0x181260DC0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_keyboardType
	*/

	// RVA: -1 Offset: -1
	public ITextEdition get_textEdition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12436B0 Offset: 0x12420B0 VA: 0x1812436B0
	|-TextInputBaseField<double>.get_textEdition
	|-TextInputBaseField<int>.get_textEdition
	|-TextInputBaseField<long>.get_textEdition
	|-TextInputBaseField<object>.get_textEdition
	|-TextInputBaseField<float>.get_textEdition
	|-TextInputBaseField<uint>.get_textEdition
	|-TextInputBaseField<ulong>.get_textEdition
	|
	|-RVA: 0x12436E0 Offset: 0x12420E0 VA: 0x1812436E0
	|-TextInputBaseField<Hash128>.get_textEdition
	|
	|-RVA: 0x125FEB0 Offset: 0x125E8B0 VA: 0x18125FEB0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_textEdition
	*/

	// RVA: -1 Offset: -1
	public void set_maxLength(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244CD0 Offset: 0x12436D0 VA: 0x181244CD0
	|-TextInputBaseField<double>.set_maxLength
	|
	|-RVA: 0x1244C50 Offset: 0x1243650 VA: 0x181244C50
	|-TextInputBaseField<Hash128>.set_maxLength
	|
	|-RVA: 0x1244E50 Offset: 0x1243850 VA: 0x181244E50
	|-TextInputBaseField<int>.set_maxLength
	|
	|-RVA: 0x1244DD0 Offset: 0x12437D0 VA: 0x181244DD0
	|-TextInputBaseField<long>.set_maxLength
	|
	|-RVA: 0x1244D50 Offset: 0x1243750 VA: 0x181244D50
	|-TextInputBaseField<object>.set_maxLength
	|
	|-RVA: 0x12611D0 Offset: 0x125FBD0 VA: 0x1812611D0
	|-TextInputBaseField<float>.set_maxLength
	|
	|-RVA: 0x1261150 Offset: 0x125FB50 VA: 0x181261150
	|-TextInputBaseField<uint>.set_maxLength
	|
	|-RVA: 0x1261250 Offset: 0x125FC50 VA: 0x181261250
	|-TextInputBaseField<ulong>.set_maxLength
	|
	|-RVA: 0x12610D0 Offset: 0x125FAD0 VA: 0x1812610D0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_maxLength
	*/

	// RVA: -1 Offset: -1
	public bool get_isDelayed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1243410 Offset: 0x1241E10 VA: 0x181243410
	|-TextInputBaseField<double>.get_isDelayed
	|
	|-RVA: 0x12432C0 Offset: 0x1241CC0 VA: 0x1812432C0
	|-TextInputBaseField<Hash128>.get_isDelayed
	|
	|-RVA: 0x1243250 Offset: 0x1241C50 VA: 0x181243250
	|-TextInputBaseField<int>.get_isDelayed
	|
	|-RVA: 0x12433A0 Offset: 0x1241DA0 VA: 0x1812433A0
	|-TextInputBaseField<long>.get_isDelayed
	|
	|-RVA: 0x1243330 Offset: 0x1241D30 VA: 0x181243330
	|-TextInputBaseField<object>.get_isDelayed
	|
	|-RVA: 0x125FB30 Offset: 0x125E530 VA: 0x18125FB30
	|-TextInputBaseField<float>.get_isDelayed
	|
	|-RVA: 0x125FBA0 Offset: 0x125E5A0 VA: 0x18125FBA0
	|-TextInputBaseField<uint>.get_isDelayed
	|
	|-RVA: 0x125FC10 Offset: 0x125E610 VA: 0x18125FC10
	|-TextInputBaseField<ulong>.get_isDelayed
	|
	|-RVA: 0x125FC80 Offset: 0x125E680 VA: 0x18125FC80
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_isDelayed
	*/

	// RVA: -1 Offset: -1
	public void set_isDelayed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244110 Offset: 0x1242B10 VA: 0x181244110
	|-TextInputBaseField<double>.set_isDelayed
	|
	|-RVA: 0x1244190 Offset: 0x1242B90 VA: 0x181244190
	|-TextInputBaseField<Hash128>.set_isDelayed
	|
	|-RVA: 0x1244210 Offset: 0x1242C10 VA: 0x181244210
	|-TextInputBaseField<int>.set_isDelayed
	|
	|-RVA: 0x1244290 Offset: 0x1242C90 VA: 0x181244290
	|-TextInputBaseField<long>.set_isDelayed
	|
	|-RVA: 0x1244090 Offset: 0x1242A90 VA: 0x181244090
	|-TextInputBaseField<object>.set_isDelayed
	|
	|-RVA: 0x1260720 Offset: 0x125F120 VA: 0x181260720
	|-TextInputBaseField<float>.set_isDelayed
	|
	|-RVA: 0x12608B0 Offset: 0x125F2B0 VA: 0x1812608B0
	|-TextInputBaseField<uint>.set_isDelayed
	|
	|-RVA: 0x1260830 Offset: 0x125F230 VA: 0x181260830
	|-TextInputBaseField<ulong>.set_isDelayed
	|
	|-RVA: 0x12607A0 Offset: 0x125F1A0 VA: 0x1812607A0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_isDelayed
	*/

	// RVA: -1 Offset: -1
	public void set_maskChar(char value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1244AD0 Offset: 0x12434D0 VA: 0x181244AD0
	|-TextInputBaseField<double>.set_maskChar
	|
	|-RVA: 0x1244B50 Offset: 0x1243550 VA: 0x181244B50
	|-TextInputBaseField<Hash128>.set_maskChar
	|
	|-RVA: 0x1244BD0 Offset: 0x12435D0 VA: 0x181244BD0
	|-TextInputBaseField<int>.set_maskChar
	|
	|-RVA: 0x12449D0 Offset: 0x12433D0 VA: 0x1812449D0
	|-TextInputBaseField<long>.set_maskChar
	|
	|-RVA: 0x1244A50 Offset: 0x1243450 VA: 0x181244A50
	|-TextInputBaseField<object>.set_maskChar
	|
	|-RVA: 0x1260EC0 Offset: 0x125F8C0 VA: 0x181260EC0
	|-TextInputBaseField<float>.set_maskChar
	|
	|-RVA: 0x1260FC0 Offset: 0x125F9C0 VA: 0x181260FC0
	|-TextInputBaseField<uint>.set_maskChar
	|
	|-RVA: 0x1260F40 Offset: 0x125F940 VA: 0x181260F40
	|-TextInputBaseField<ulong>.set_maskChar
	|
	|-RVA: 0x1261040 Offset: 0x125FA40 VA: 0x181261040
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.set_maskChar
	*/

	// RVA: -1 Offset: -1 Slot: 113
	internal override bool get_canSwitchToMixedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12430D0 Offset: 0x1241AD0 VA: 0x1812430D0
	|-TextInputBaseField<double>.get_canSwitchToMixedValue
	|-TextInputBaseField<int>.get_canSwitchToMixedValue
	|-TextInputBaseField<long>.get_canSwitchToMixedValue
	|-TextInputBaseField<object>.get_canSwitchToMixedValue
	|-TextInputBaseField<float>.get_canSwitchToMixedValue
	|-TextInputBaseField<uint>.get_canSwitchToMixedValue
	|-TextInputBaseField<ulong>.get_canSwitchToMixedValue
	|
	|-RVA: 0x1243190 Offset: 0x1241B90 VA: 0x181243190
	|-TextInputBaseField<Hash128>.get_canSwitchToMixedValue
	|
	|-RVA: 0x125FA00 Offset: 0x125E400 VA: 0x18125FA00
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.get_canSwitchToMixedValue
	*/

	// RVA: -1 Offset: -1 Slot: 119
	protected abstract string ValueToString(TValueType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.ValueToString
	*/

	// RVA: -1 Offset: -1 Slot: 120
	protected abstract TValueType StringToValue(string str);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.StringToValue
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string label, int maxLength, char maskChar, TextInputBaseField.TextInputBase<TValueType> textInputBase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1241CE0 Offset: 0x12406E0 VA: 0x181241CE0
	|-TextInputBaseField<double>..ctor
	|
	|-RVA: 0x1241FF0 Offset: 0x12409F0 VA: 0x181241FF0
	|-TextInputBaseField<Hash128>..ctor
	|
	|-RVA: 0x1242680 Offset: 0x1241080 VA: 0x181242680
	|-TextInputBaseField<int>..ctor
	|
	|-RVA: 0x1242990 Offset: 0x1241390 VA: 0x181242990
	|-TextInputBaseField<long>..ctor
	|
	|-RVA: 0x1242300 Offset: 0x1240D00 VA: 0x181242300
	|-TextInputBaseField<object>..ctor
	|
	|-RVA: 0x125ECA0 Offset: 0x125D6A0 VA: 0x18125ECA0
	|-TextInputBaseField<float>..ctor
	|
	|-RVA: 0x125EFB0 Offset: 0x125D9B0 VA: 0x18125EFB0
	|-TextInputBaseField<uint>..ctor
	|
	|-RVA: 0x125E990 Offset: 0x125D390 VA: 0x18125E990
	|-TextInputBaseField<ulong>..ctor
	|
	|-RVA: 0x125F2C0 Offset: 0x125DCC0 VA: 0x18125F2C0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123E2E0 Offset: 0x123CCE0 VA: 0x18123E2E0
	|-TextInputBaseField<double>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x123E3A0 Offset: 0x123CDA0 VA: 0x18123E3A0
	|-TextInputBaseField<Hash128>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x123E320 Offset: 0x123CD20 VA: 0x18123E320
	|-TextInputBaseField<int>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x123E360 Offset: 0x123CD60 VA: 0x18123E360
	|-TextInputBaseField<long>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x123E3E0 Offset: 0x123CDE0 VA: 0x18123E3E0
	|-TextInputBaseField<object>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x125BBA0 Offset: 0x125A5A0 VA: 0x18125BBA0
	|-TextInputBaseField<float>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x125BB60 Offset: 0x125A560 VA: 0x18125BB60
	|-TextInputBaseField<uint>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x125BB20 Offset: 0x125A520 VA: 0x18125BB20
	|-TextInputBaseField<ulong>.OnFieldCustomStyleResolved
	|
	|-RVA: 0x125BAB0 Offset: 0x125A4B0 VA: 0x18125BAB0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.OnFieldCustomStyleResolved
	*/

	[EventInterest(new[] { typeof(NavigationSubmitEvent), typeof(FocusInEvent), typeof(FocusEvent), typeof(BlurEvent) })]
	// RVA: -1 Offset: -1 Slot: 11
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123DB80 Offset: 0x123C580 VA: 0x18123DB80
	|-TextInputBaseField<double>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x123DF30 Offset: 0x123C930 VA: 0x18123DF30
	|-TextInputBaseField<Hash128>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x123D7D0 Offset: 0x123C1D0 VA: 0x18123D7D0
	|-TextInputBaseField<int>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x123D070 Offset: 0x123BA70 VA: 0x18123D070
	|-TextInputBaseField<long>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x123D420 Offset: 0x123BE20 VA: 0x18123D420
	|-TextInputBaseField<object>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x125B700 Offset: 0x125A100 VA: 0x18125B700
	|-TextInputBaseField<float>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x125B350 Offset: 0x1259D50 VA: 0x18125B350
	|-TextInputBaseField<uint>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x125AFA0 Offset: 0x12599A0 VA: 0x18125AFA0
	|-TextInputBaseField<ulong>.ExecuteDefaultActionAtTarget
	|
	|-RVA: 0x125AA60 Offset: 0x1259460 VA: 0x18125AA60
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.ExecuteDefaultActionAtTarget
	*/

	// RVA: -1 Offset: -1 Slot: 117
	protected override void UpdateMixedValueContent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F020 Offset: 0x123DA20 VA: 0x18123F020
	|-TextInputBaseField<double>.UpdateMixedValueContent
	|
	|-RVA: 0x123ED20 Offset: 0x123D720 VA: 0x18123ED20
	|-TextInputBaseField<Hash128>.UpdateMixedValueContent
	|
	|-RVA: 0x123EA20 Offset: 0x123D420 VA: 0x18123EA20
	|-TextInputBaseField<int>.UpdateMixedValueContent
	|
	|-RVA: 0x123E720 Offset: 0x123D120 VA: 0x18123E720
	|-TextInputBaseField<long>.UpdateMixedValueContent
	|
	|-RVA: 0x123E420 Offset: 0x123CE20 VA: 0x18123E420
	|-TextInputBaseField<object>.UpdateMixedValueContent
	|
	|-RVA: 0x125BEE0 Offset: 0x125A8E0 VA: 0x18125BEE0
	|-TextInputBaseField<float>.UpdateMixedValueContent
	|
	|-RVA: 0x125C1E0 Offset: 0x125ABE0 VA: 0x18125C1E0
	|-TextInputBaseField<uint>.UpdateMixedValueContent
	|
	|-RVA: 0x125BBE0 Offset: 0x125A5E0 VA: 0x18125BBE0
	|-TextInputBaseField<ulong>.UpdateMixedValueContent
	|
	|-RVA: 0x125C4E0 Offset: 0x125AEE0 VA: 0x18125C4E0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.UpdateMixedValueContent
	*/

	// RVA: -1 Offset: -1 Slot: 121
	internal virtual void UpdateValueFromText() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123F420 Offset: 0x123DE20 VA: 0x18123F420
	|-TextInputBaseField<double>.UpdateValueFromText
	|-TextInputBaseField<float>.UpdateValueFromText
	|
	|-RVA: 0x123F4A0 Offset: 0x123DEA0 VA: 0x18123F4A0
	|-TextInputBaseField<Hash128>.UpdateValueFromText
	|
	|-RVA: 0x123F320 Offset: 0x123DD20 VA: 0x18123F320
	|-TextInputBaseField<int>.UpdateValueFromText
	|-TextInputBaseField<uint>.UpdateValueFromText
	|
	|-RVA: 0x123F3A0 Offset: 0x123DDA0 VA: 0x18123F3A0
	|-TextInputBaseField<long>.UpdateValueFromText
	|-TextInputBaseField<object>.UpdateValueFromText
	|
	|-RVA: 0x125C950 Offset: 0x125B350 VA: 0x18125C950
	|-TextInputBaseField<ulong>.UpdateValueFromText
	|
	|-RVA: 0x125C850 Offset: 0x125B250 VA: 0x18125C850
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.UpdateValueFromText
	*/

	// RVA: -1 Offset: -1 Slot: 122
	internal virtual void UpdateTextFromValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-TextInputBaseField<double>.UpdateTextFromValue
	|-TextInputBaseField<Hash128>.UpdateTextFromValue
	|-TextInputBaseField<int>.UpdateTextFromValue
	|-TextInputBaseField<long>.UpdateTextFromValue
	|-TextInputBaseField<object>.UpdateTextFromValue
	|-TextInputBaseField<float>.UpdateTextFromValue
	|-TextInputBaseField<uint>.UpdateTextFromValue
	|-TextInputBaseField<ulong>.UpdateTextFromValue
	|-TextInputBaseField<__Il2CppFullySharedGenericType>.UpdateTextFromValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1240D00 Offset: 0x123F700 VA: 0x181240D00
	|-TextInputBaseField<double>..cctor
	|
	|-RVA: 0x1240510 Offset: 0x123EF10 VA: 0x181240510
	|-TextInputBaseField<Hash128>..cctor
	|
	|-RVA: 0x12414F0 Offset: 0x123FEF0 VA: 0x1812414F0
	|-TextInputBaseField<int>..cctor
	|
	|-RVA: 0x123FD20 Offset: 0x123E720 VA: 0x18123FD20
	|-TextInputBaseField<long>..cctor
	|
	|-RVA: 0x123F530 Offset: 0x123DF30 VA: 0x18123F530
	|-TextInputBaseField<object>..cctor
	|
	|-RVA: 0x125D1C0 Offset: 0x125BBC0 VA: 0x18125D1C0
	|-TextInputBaseField<float>..cctor
	|
	|-RVA: 0x125D9B0 Offset: 0x125C3B0 VA: 0x18125D9B0
	|-TextInputBaseField<uint>..cctor
	|
	|-RVA: 0x125C9D0 Offset: 0x125B3D0 VA: 0x18125C9D0
	|-TextInputBaseField<ulong>..cctor
	|
	|-RVA: 0x125E1A0 Offset: 0x125CBA0 VA: 0x18125E1A0
	|-TextInputBaseField<__Il2CppFullySharedGenericType>..cctor
	*/
}
