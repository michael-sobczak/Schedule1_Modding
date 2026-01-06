protected internal abstract class TextInputBaseField.TextInputBase<TValueType> : VisualElement // TypeDefIndex: 6331
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextElement <textElement>k__BackingField; // 0x0
	internal ScrollView scrollView; // 0x0
	internal VisualElement multilineContainer; // 0x0
	public static readonly string innerComponentsModifierName; // 0x0
	public static readonly string innerTextElementUssClassName; // 0x0
	internal static readonly string innerTextElementWithScrollViewUssClassName; // 0x0
	public static readonly string horizontalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string verticalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string innerScrollviewUssClassName; // 0x0
	public static readonly string innerViewportUssClassName; // 0x0
	public static readonly string innerContentContainerUssClassName; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isDragging>k__BackingField; // 0x0
	internal Vector2 scrollOffset; // 0x0
	private bool m_ScrollViewWasClamped; // 0x0
	private Vector2 lastCursorPos; // 0x0
	private ScrollerVisibility m_VerticalScrollerVisibility; // 0x0

	// Properties
	internal TextElement textElement { get; set; }
	public ITextSelection textSelection { get; }
	public ITextEdition textEdition { get; }
	internal string originalText { get; }
	public bool isReadOnly { get; }
	public int maxLength { set; }
	public char maskChar { set; }
	public virtual bool isPasswordField { get; set; }
	internal bool isDragging { set; }
	public string text { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal TextElement get_textElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x681E30 Offset: 0x680830 VA: 0x180681E30
	|-TextInputBaseField.TextInputBase<double>.get_textElement
	|-TextInputBaseField.TextInputBase<Hash128>.get_textElement
	|-TextInputBaseField.TextInputBase<int>.get_textElement
	|-TextInputBaseField.TextInputBase<long>.get_textElement
	|-TextInputBaseField.TextInputBase<object>.get_textElement
	|-TextInputBaseField.TextInputBase<float>.get_textElement
	|-TextInputBaseField.TextInputBase<uint>.get_textElement
	|-TextInputBaseField.TextInputBase<ulong>.get_textElement
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_textElement
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_textElement(TextElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x681E50 Offset: 0x680850 VA: 0x180681E50
	|-TextInputBaseField.TextInputBase<double>.set_textElement
	|-TextInputBaseField.TextInputBase<Hash128>.set_textElement
	|-TextInputBaseField.TextInputBase<int>.set_textElement
	|-TextInputBaseField.TextInputBase<long>.set_textElement
	|-TextInputBaseField.TextInputBase<object>.set_textElement
	|-TextInputBaseField.TextInputBase<float>.set_textElement
	|-TextInputBaseField.TextInputBase<uint>.set_textElement
	|-TextInputBaseField.TextInputBase<ulong>.set_textElement
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_textElement
	*/

	// RVA: -1 Offset: -1
	public ITextSelection get_textSelection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CB90 Offset: 0x123B590 VA: 0x18123CB90
	|-TextInputBaseField.TextInputBase<double>.get_textSelection
	|-TextInputBaseField.TextInputBase<Hash128>.get_textSelection
	|-TextInputBaseField.TextInputBase<int>.get_textSelection
	|-TextInputBaseField.TextInputBase<long>.get_textSelection
	|-TextInputBaseField.TextInputBase<object>.get_textSelection
	|-TextInputBaseField.TextInputBase<float>.get_textSelection
	|-TextInputBaseField.TextInputBase<uint>.get_textSelection
	|-TextInputBaseField.TextInputBase<ulong>.get_textSelection
	|
	|-RVA: 0x1259A90 Offset: 0x1258490 VA: 0x181259A90
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_textSelection
	*/

	// RVA: -1 Offset: -1
	public ITextEdition get_textEdition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CB90 Offset: 0x123B590 VA: 0x18123CB90
	|-TextInputBaseField.TextInputBase<double>.get_textEdition
	|-TextInputBaseField.TextInputBase<Hash128>.get_textEdition
	|-TextInputBaseField.TextInputBase<int>.get_textEdition
	|-TextInputBaseField.TextInputBase<long>.get_textEdition
	|-TextInputBaseField.TextInputBase<object>.get_textEdition
	|-TextInputBaseField.TextInputBase<float>.get_textEdition
	|-TextInputBaseField.TextInputBase<uint>.get_textEdition
	|-TextInputBaseField.TextInputBase<ulong>.get_textEdition
	|
	|-RVA: 0x1259A90 Offset: 0x1258490 VA: 0x181259A90
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_textEdition
	*/

	// RVA: -1 Offset: -1
	public void SelectAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12358E0 Offset: 0x12342E0 VA: 0x1812358E0
	|-TextInputBaseField.TextInputBase<double>.SelectAll
	|
	|-RVA: 0x1235940 Offset: 0x1234340 VA: 0x181235940
	|-TextInputBaseField.TextInputBase<Hash128>.SelectAll
	|
	|-RVA: 0x1235880 Offset: 0x1234280 VA: 0x181235880
	|-TextInputBaseField.TextInputBase<int>.SelectAll
	|
	|-RVA: 0x124B680 Offset: 0x124A080 VA: 0x18124B680
	|-TextInputBaseField.TextInputBase<long>.SelectAll
	|
	|-RVA: 0x124B4F0 Offset: 0x1249EF0 VA: 0x18124B4F0
	|-TextInputBaseField.TextInputBase<object>.SelectAll
	|
	|-RVA: 0x124B5B0 Offset: 0x1249FB0 VA: 0x18124B5B0
	|-TextInputBaseField.TextInputBase<float>.SelectAll
	|
	|-RVA: 0x124B550 Offset: 0x1249F50 VA: 0x18124B550
	|-TextInputBaseField.TextInputBase<uint>.SelectAll
	|
	|-RVA: 0x124B490 Offset: 0x1249E90 VA: 0x18124B490
	|-TextInputBaseField.TextInputBase<ulong>.SelectAll
	|
	|-RVA: 0x124B610 Offset: 0x124A010 VA: 0x18124B610
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SelectAll
	*/

	// RVA: -1 Offset: -1
	internal void SelectNone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12359A0 Offset: 0x12343A0 VA: 0x1812359A0
	|-TextInputBaseField.TextInputBase<double>.SelectNone
	|
	|-RVA: 0x1235A60 Offset: 0x1234460 VA: 0x181235A60
	|-TextInputBaseField.TextInputBase<Hash128>.SelectNone
	|
	|-RVA: 0x1235A00 Offset: 0x1234400 VA: 0x181235A00
	|-TextInputBaseField.TextInputBase<int>.SelectNone
	|
	|-RVA: 0x124B8D0 Offset: 0x124A2D0 VA: 0x18124B8D0
	|-TextInputBaseField.TextInputBase<long>.SelectNone
	|
	|-RVA: 0x124B870 Offset: 0x124A270 VA: 0x18124B870
	|-TextInputBaseField.TextInputBase<object>.SelectNone
	|
	|-RVA: 0x124B810 Offset: 0x124A210 VA: 0x18124B810
	|-TextInputBaseField.TextInputBase<float>.SelectNone
	|
	|-RVA: 0x124B7B0 Offset: 0x124A1B0 VA: 0x18124B7B0
	|-TextInputBaseField.TextInputBase<uint>.SelectNone
	|
	|-RVA: 0x124B6E0 Offset: 0x124A0E0 VA: 0x18124B6E0
	|-TextInputBaseField.TextInputBase<ulong>.SelectNone
	|
	|-RVA: 0x124B740 Offset: 0x124A140 VA: 0x18124B740
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SelectNone
	*/

	// RVA: -1 Offset: -1
	internal string get_originalText() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CB60 Offset: 0x123B560 VA: 0x18123CB60
	|-TextInputBaseField.TextInputBase<double>.get_originalText
	|-TextInputBaseField.TextInputBase<Hash128>.get_originalText
	|-TextInputBaseField.TextInputBase<int>.get_originalText
	|-TextInputBaseField.TextInputBase<long>.get_originalText
	|-TextInputBaseField.TextInputBase<object>.get_originalText
	|-TextInputBaseField.TextInputBase<float>.get_originalText
	|-TextInputBaseField.TextInputBase<uint>.get_originalText
	|-TextInputBaseField.TextInputBase<ulong>.get_originalText
	|
	|-RVA: 0x1259A50 Offset: 0x1258450 VA: 0x181259A50
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_originalText
	*/

	// RVA: -1 Offset: -1 Slot: 100
	protected virtual TValueType StringToValue(string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF080 Offset: 0x11ADA80 VA: 0x1811AF080
	|-TextInputBaseField.TextInputBase<double>.StringToValue
	|-TextInputBaseField.TextInputBase<int>.StringToValue
	|-TextInputBaseField.TextInputBase<long>.StringToValue
	|-TextInputBaseField.TextInputBase<object>.StringToValue
	|-TextInputBaseField.TextInputBase<float>.StringToValue
	|-TextInputBaseField.TextInputBase<uint>.StringToValue
	|-TextInputBaseField.TextInputBase<ulong>.StringToValue
	|
	|-RVA: 0x11AF040 Offset: 0x11ADA40 VA: 0x1811AF040
	|-TextInputBaseField.TextInputBase<Hash128>.StringToValue
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.StringToValue
	*/

	// RVA: -1 Offset: -1
	internal void UpdateValueFromText() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12396D0 Offset: 0x12380D0 VA: 0x1812396D0
	|-TextInputBaseField.TextInputBase<double>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<Hash128>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<int>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<long>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<object>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<float>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<uint>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<ulong>.UpdateValueFromText
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.UpdateValueFromText
	*/

	// RVA: -1 Offset: -1
	internal void UpdateTextFromValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1239630 Offset: 0x1238030 VA: 0x181239630
	|-TextInputBaseField.TextInputBase<double>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<Hash128>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<int>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<long>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<object>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<float>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<uint>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<ulong>.UpdateTextFromValue
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.UpdateTextFromValue
	*/

	// RVA: -1 Offset: -1
	internal void MoveFocusToCompositeRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1233410 Offset: 0x1231E10 VA: 0x181233410
	|-TextInputBaseField.TextInputBase<double>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<Hash128>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<int>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<long>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<object>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<float>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<uint>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<ulong>.MoveFocusToCompositeRoot
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.MoveFocusToCompositeRoot
	*/

	// RVA: -1 Offset: -1
	public bool get_isReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CA40 Offset: 0x123B440 VA: 0x18123CA40
	|-TextInputBaseField.TextInputBase<double>.get_isReadOnly
	|
	|-RVA: 0x123CAA0 Offset: 0x123B4A0 VA: 0x18123CAA0
	|-TextInputBaseField.TextInputBase<Hash128>.get_isReadOnly
	|
	|-RVA: 0x123CB00 Offset: 0x123B500 VA: 0x18123CB00
	|-TextInputBaseField.TextInputBase<int>.get_isReadOnly
	|
	|-RVA: 0x1259990 Offset: 0x1258390 VA: 0x181259990
	|-TextInputBaseField.TextInputBase<long>.get_isReadOnly
	|
	|-RVA: 0x12599F0 Offset: 0x12583F0 VA: 0x1812599F0
	|-TextInputBaseField.TextInputBase<object>.get_isReadOnly
	|
	|-RVA: 0x12598D0 Offset: 0x12582D0 VA: 0x1812598D0
	|-TextInputBaseField.TextInputBase<float>.get_isReadOnly
	|
	|-RVA: 0x1259800 Offset: 0x1258200 VA: 0x181259800
	|-TextInputBaseField.TextInputBase<uint>.get_isReadOnly
	|
	|-RVA: 0x1259930 Offset: 0x1258330 VA: 0x181259930
	|-TextInputBaseField.TextInputBase<ulong>.get_isReadOnly
	|
	|-RVA: 0x1259860 Offset: 0x1258260 VA: 0x181259860
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_isReadOnly
	*/

	// RVA: -1 Offset: -1
	public void set_maxLength(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CF80 Offset: 0x123B980 VA: 0x18123CF80
	|-TextInputBaseField.TextInputBase<double>.set_maxLength
	|
	|-RVA: 0x123CF10 Offset: 0x123B910 VA: 0x18123CF10
	|-TextInputBaseField.TextInputBase<Hash128>.set_maxLength
	|
	|-RVA: 0x123CEA0 Offset: 0x123B8A0 VA: 0x18123CEA0
	|-TextInputBaseField.TextInputBase<int>.set_maxLength
	|
	|-RVA: 0x125A170 Offset: 0x1258B70 VA: 0x18125A170
	|-TextInputBaseField.TextInputBase<long>.set_maxLength
	|
	|-RVA: 0x125A090 Offset: 0x1258A90 VA: 0x18125A090
	|-TextInputBaseField.TextInputBase<object>.set_maxLength
	|
	|-RVA: 0x125A260 Offset: 0x1258C60 VA: 0x18125A260
	|-TextInputBaseField.TextInputBase<float>.set_maxLength
	|
	|-RVA: 0x125A2D0 Offset: 0x1258CD0 VA: 0x18125A2D0
	|-TextInputBaseField.TextInputBase<uint>.set_maxLength
	|
	|-RVA: 0x125A100 Offset: 0x1258B00 VA: 0x18125A100
	|-TextInputBaseField.TextInputBase<ulong>.set_maxLength
	|
	|-RVA: 0x125A1E0 Offset: 0x1258BE0 VA: 0x18125A1E0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_maxLength
	*/

	// RVA: -1 Offset: -1
	public void set_maskChar(char value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CDC0 Offset: 0x123B7C0 VA: 0x18123CDC0
	|-TextInputBaseField.TextInputBase<double>.set_maskChar
	|
	|-RVA: 0x123CE30 Offset: 0x123B830 VA: 0x18123CE30
	|-TextInputBaseField.TextInputBase<Hash128>.set_maskChar
	|
	|-RVA: 0x123CD50 Offset: 0x123B750 VA: 0x18123CD50
	|-TextInputBaseField.TextInputBase<int>.set_maskChar
	|
	|-RVA: 0x1259DD0 Offset: 0x12587D0 VA: 0x181259DD0
	|-TextInputBaseField.TextInputBase<long>.set_maskChar
	|
	|-RVA: 0x1259F40 Offset: 0x1258940 VA: 0x181259F40
	|-TextInputBaseField.TextInputBase<object>.set_maskChar
	|
	|-RVA: 0x125A020 Offset: 0x1258A20 VA: 0x18125A020
	|-TextInputBaseField.TextInputBase<float>.set_maskChar
	|
	|-RVA: 0x1259ED0 Offset: 0x12588D0 VA: 0x181259ED0
	|-TextInputBaseField.TextInputBase<uint>.set_maskChar
	|
	|-RVA: 0x1259FB0 Offset: 0x12589B0 VA: 0x181259FB0
	|-TextInputBaseField.TextInputBase<ulong>.set_maskChar
	|
	|-RVA: 0x1259E40 Offset: 0x1258840 VA: 0x181259E40
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_maskChar
	*/

	// RVA: -1 Offset: -1 Slot: 101
	public virtual bool get_isPasswordField() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123C9E0 Offset: 0x123B3E0 VA: 0x18123C9E0
	|-TextInputBaseField.TextInputBase<double>.get_isPasswordField
	|
	|-RVA: 0x123C920 Offset: 0x123B320 VA: 0x18123C920
	|-TextInputBaseField.TextInputBase<Hash128>.get_isPasswordField
	|
	|-RVA: 0x123C980 Offset: 0x123B380 VA: 0x18123C980
	|-TextInputBaseField.TextInputBase<int>.get_isPasswordField
	|
	|-RVA: 0x1259620 Offset: 0x1258020 VA: 0x181259620
	|-TextInputBaseField.TextInputBase<long>.get_isPasswordField
	|
	|-RVA: 0x1259680 Offset: 0x1258080 VA: 0x181259680
	|-TextInputBaseField.TextInputBase<object>.get_isPasswordField
	|
	|-RVA: 0x1259740 Offset: 0x1258140 VA: 0x181259740
	|-TextInputBaseField.TextInputBase<float>.get_isPasswordField
	|
	|-RVA: 0x12597A0 Offset: 0x12581A0 VA: 0x1812597A0
	|-TextInputBaseField.TextInputBase<uint>.get_isPasswordField
	|
	|-RVA: 0x12596E0 Offset: 0x12580E0 VA: 0x1812596E0
	|-TextInputBaseField.TextInputBase<ulong>.get_isPasswordField
	|
	|-RVA: 0x12595B0 Offset: 0x1257FB0 VA: 0x1812595B0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_isPasswordField
	*/

	// RVA: -1 Offset: -1 Slot: 102
	public virtual void set_isPasswordField(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CC70 Offset: 0x123B670 VA: 0x18123CC70
	|-TextInputBaseField.TextInputBase<double>.set_isPasswordField
	|
	|-RVA: 0x123CC00 Offset: 0x123B600 VA: 0x18123CC00
	|-TextInputBaseField.TextInputBase<Hash128>.set_isPasswordField
	|
	|-RVA: 0x123CCE0 Offset: 0x123B6E0 VA: 0x18123CCE0
	|-TextInputBaseField.TextInputBase<int>.set_isPasswordField
	|
	|-RVA: 0x1259BF0 Offset: 0x12585F0 VA: 0x181259BF0
	|-TextInputBaseField.TextInputBase<long>.set_isPasswordField
	|
	|-RVA: 0x1259B10 Offset: 0x1258510 VA: 0x181259B10
	|-TextInputBaseField.TextInputBase<object>.set_isPasswordField
	|
	|-RVA: 0x1259C60 Offset: 0x1258660 VA: 0x181259C60
	|-TextInputBaseField.TextInputBase<float>.set_isPasswordField
	|
	|-RVA: 0x1259B80 Offset: 0x1258580 VA: 0x181259B80
	|-TextInputBaseField.TextInputBase<uint>.set_isPasswordField
	|
	|-RVA: 0x1259D60 Offset: 0x1258760 VA: 0x181259D60
	|-TextInputBaseField.TextInputBase<ulong>.set_isPasswordField
	|
	|-RVA: 0x1259CD0 Offset: 0x12586D0 VA: 0x181259CD0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_isPasswordField
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_isDragging(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CBF0 Offset: 0x123B5F0 VA: 0x18123CBF0
	|-TextInputBaseField.TextInputBase<double>.set_isDragging
	|-TextInputBaseField.TextInputBase<Hash128>.set_isDragging
	|-TextInputBaseField.TextInputBase<int>.set_isDragging
	|-TextInputBaseField.TextInputBase<long>.set_isDragging
	|-TextInputBaseField.TextInputBase<object>.set_isDragging
	|-TextInputBaseField.TextInputBase<float>.set_isDragging
	|-TextInputBaseField.TextInputBase<uint>.set_isDragging
	|-TextInputBaseField.TextInputBase<ulong>.set_isDragging
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_isDragging
	*/

	// RVA: -1 Offset: -1
	public string get_text() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CBC0 Offset: 0x123B5C0 VA: 0x18123CBC0
	|-TextInputBaseField.TextInputBase<double>.get_text
	|-TextInputBaseField.TextInputBase<Hash128>.get_text
	|-TextInputBaseField.TextInputBase<int>.get_text
	|-TextInputBaseField.TextInputBase<long>.get_text
	|-TextInputBaseField.TextInputBase<object>.get_text
	|-TextInputBaseField.TextInputBase<float>.get_text
	|-TextInputBaseField.TextInputBase<uint>.get_text
	|-TextInputBaseField.TextInputBase<ulong>.get_text
	|
	|-RVA: 0x1259AD0 Offset: 0x12584D0 VA: 0x181259AD0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.get_text
	*/

	// RVA: -1 Offset: -1
	public void set_text(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123CFF0 Offset: 0x123B9F0 VA: 0x18123CFF0
	|-TextInputBaseField.TextInputBase<double>.set_text
	|-TextInputBaseField.TextInputBase<Hash128>.set_text
	|-TextInputBaseField.TextInputBase<int>.set_text
	|-TextInputBaseField.TextInputBase<long>.set_text
	|-TextInputBaseField.TextInputBase<object>.set_text
	|-TextInputBaseField.TextInputBase<float>.set_text
	|-TextInputBaseField.TextInputBase<uint>.set_text
	|-TextInputBaseField.TextInputBase<ulong>.set_text
	|
	|-RVA: 0x125A340 Offset: 0x1258D40 VA: 0x18125A340
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.set_text
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123C110 Offset: 0x123AB10 VA: 0x18123C110
	|-TextInputBaseField.TextInputBase<double>..ctor
	|
	|-RVA: 0x123B900 Offset: 0x123A300 VA: 0x18123B900
	|-TextInputBaseField.TextInputBase<Hash128>..ctor
	|
	|-RVA: 0x123B0F0 Offset: 0x1239AF0 VA: 0x18123B0F0
	|-TextInputBaseField.TextInputBase<int>..ctor
	|
	|-RVA: 0x1258590 Offset: 0x1256F90 VA: 0x181258590
	|-TextInputBaseField.TextInputBase<long>..ctor
	|
	|-RVA: 0x12564C0 Offset: 0x1254EC0 VA: 0x1812564C0
	|-TextInputBaseField.TextInputBase<object>..ctor
	|
	|-RVA: 0x1257D80 Offset: 0x1256780 VA: 0x181257D80
	|-TextInputBaseField.TextInputBase<float>..ctor
	|
	|-RVA: 0x1258DA0 Offset: 0x12577A0 VA: 0x181258DA0
	|-TextInputBaseField.TextInputBase<uint>..ctor
	|
	|-RVA: 0x1257570 Offset: 0x1255F70 VA: 0x181257570
	|-TextInputBaseField.TextInputBase<ulong>..ctor
	|
	|-RVA: 0x1256CD0 Offset: 0x12556D0 VA: 0x181256CD0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<float> evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12333F0 Offset: 0x1231DF0 VA: 0x1812333F0
	|-TextInputBaseField.TextInputBase<double>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<Hash128>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<int>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<long>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<object>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<float>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<uint>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<ulong>.MakeSureScrollViewDoesNotLeakEvents
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.MakeSureScrollViewDoesNotLeakEvents
	*/

	// RVA: -1 Offset: -1
	internal void SetSingleLine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1238380 Offset: 0x1236D80 VA: 0x181238380
	|-TextInputBaseField.TextInputBase<double>.SetSingleLine
	|
	|-RVA: 0x12380F0 Offset: 0x1236AF0 VA: 0x1812380F0
	|-TextInputBaseField.TextInputBase<Hash128>.SetSingleLine
	|
	|-RVA: 0x1237E60 Offset: 0x1236860 VA: 0x181237E60
	|-TextInputBaseField.TextInputBase<int>.SetSingleLine
	|
	|-RVA: 0x1250E90 Offset: 0x124F890 VA: 0x181250E90
	|-TextInputBaseField.TextInputBase<long>.SetSingleLine
	|
	|-RVA: 0x1250970 Offset: 0x124F370 VA: 0x181250970
	|-TextInputBaseField.TextInputBase<object>.SetSingleLine
	|
	|-RVA: 0x1250450 Offset: 0x124EE50 VA: 0x181250450
	|-TextInputBaseField.TextInputBase<float>.SetSingleLine
	|
	|-RVA: 0x1250C00 Offset: 0x124F600 VA: 0x181250C00
	|-TextInputBaseField.TextInputBase<uint>.SetSingleLine
	|
	|-RVA: 0x12506E0 Offset: 0x124F0E0 VA: 0x1812506E0
	|-TextInputBaseField.TextInputBase<ulong>.SetSingleLine
	|
	|-RVA: 0x1250190 Offset: 0x124EB90 VA: 0x181250190
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SetSingleLine
	*/

	// RVA: -1 Offset: -1
	internal void SetMultiline() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1236460 Offset: 0x1234E60 VA: 0x181236460
	|-TextInputBaseField.TextInputBase<double>.SetMultiline
	|
	|-RVA: 0x1235CD0 Offset: 0x12346D0 VA: 0x181235CD0
	|-TextInputBaseField.TextInputBase<Hash128>.SetMultiline
	|
	|-RVA: 0x1236BF0 Offset: 0x12355F0 VA: 0x181236BF0
	|-TextInputBaseField.TextInputBase<int>.SetMultiline
	|
	|-RVA: 0x124DC10 Offset: 0x124C610 VA: 0x18124DC10
	|-TextInputBaseField.TextInputBase<long>.SetMultiline
	|
	|-RVA: 0x124CCF0 Offset: 0x124B6F0 VA: 0x18124CCF0
	|-TextInputBaseField.TextInputBase<object>.SetMultiline
	|
	|-RVA: 0x124E3A0 Offset: 0x124CDA0 VA: 0x18124E3A0
	|-TextInputBaseField.TextInputBase<float>.SetMultiline
	|
	|-RVA: 0x124C560 Offset: 0x124AF60 VA: 0x18124C560
	|-TextInputBaseField.TextInputBase<uint>.SetMultiline
	|
	|-RVA: 0x124D480 Offset: 0x124BE80 VA: 0x18124D480
	|-TextInputBaseField.TextInputBase<ulong>.SetMultiline
	|
	|-RVA: 0x124BD50 Offset: 0x124A750 VA: 0x18124BD50
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SetMultiline
	*/

	// RVA: -1 Offset: -1
	private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1235760 Offset: 0x1234160 VA: 0x181235760
	|-TextInputBaseField.TextInputBase<double>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x12356D0 Offset: 0x12340D0 VA: 0x1812356D0
	|-TextInputBaseField.TextInputBase<Hash128>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x12357F0 Offset: 0x12341F0 VA: 0x1812357F0
	|-TextInputBaseField.TextInputBase<int>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B140 Offset: 0x1249B40 VA: 0x18124B140
	|-TextInputBaseField.TextInputBase<long>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B260 Offset: 0x1249C60 VA: 0x18124B260
	|-TextInputBaseField.TextInputBase<object>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B1D0 Offset: 0x1249BD0 VA: 0x18124B1D0
	|-TextInputBaseField.TextInputBase<float>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B400 Offset: 0x1249E00 VA: 0x18124B400
	|-TextInputBaseField.TextInputBase<uint>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B2F0 Offset: 0x1249CF0 VA: 0x18124B2F0
	|-TextInputBaseField.TextInputBase<ulong>.ScrollViewOnGeometryChangedEvent
	|
	|-RVA: 0x124B380 Offset: 0x1249D80 VA: 0x18124B380
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.ScrollViewOnGeometryChangedEvent
	*/

	// RVA: -1 Offset: -1
	private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1238720 Offset: 0x1237120 VA: 0x181238720
	|-TextInputBaseField.TextInputBase<double>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1238830 Offset: 0x1237230 VA: 0x181238830
	|-TextInputBaseField.TextInputBase<Hash128>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1238610 Offset: 0x1237010 VA: 0x181238610
	|-TextInputBaseField.TextInputBase<int>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251450 Offset: 0x124FE50 VA: 0x181251450
	|-TextInputBaseField.TextInputBase<long>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251670 Offset: 0x1250070 VA: 0x181251670
	|-TextInputBaseField.TextInputBase<object>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251560 Offset: 0x124FF60 VA: 0x181251560
	|-TextInputBaseField.TextInputBase<float>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251120 Offset: 0x124FB20 VA: 0x181251120
	|-TextInputBaseField.TextInputBase<uint>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251340 Offset: 0x124FD40 VA: 0x181251340
	|-TextInputBaseField.TextInputBase<ulong>.TextElementOnGeometryChangedEvent
	|
	|-RVA: 0x1251230 Offset: 0x124FC30 VA: 0x181251230
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.TextElementOnGeometryChangedEvent
	*/

	// RVA: -1 Offset: -1
	internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12338C0 Offset: 0x12322C0 VA: 0x1812338C0
	|-TextInputBaseField.TextInputBase<double>.OnInputCustomStyleResolved
	|
	|-RVA: 0x12334B0 Offset: 0x1231EB0 VA: 0x1812334B0
	|-TextInputBaseField.TextInputBase<Hash128>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1233CD0 Offset: 0x12326D0 VA: 0x181233CD0
	|-TextInputBaseField.TextInputBase<int>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1247850 Offset: 0x1246250 VA: 0x181247850
	|-TextInputBaseField.TextInputBase<long>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1247C60 Offset: 0x1246660 VA: 0x181247C60
	|-TextInputBaseField.TextInputBase<object>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1246C20 Offset: 0x1245620 VA: 0x181246C20
	|-TextInputBaseField.TextInputBase<float>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1247440 Offset: 0x1245E40 VA: 0x181247440
	|-TextInputBaseField.TextInputBase<uint>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1247030 Offset: 0x1245A30 VA: 0x181247030
	|-TextInputBaseField.TextInputBase<ulong>.OnInputCustomStyleResolved
	|
	|-RVA: 0x1248070 Offset: 0x1246A70 VA: 0x181248070
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.OnInputCustomStyleResolved
	*/

	// RVA: -1 Offset: -1 Slot: 103
	internal virtual bool AcceptCharacter(char c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12325B0 Offset: 0x1230FB0 VA: 0x1812325B0
	|-TextInputBaseField.TextInputBase<double>.AcceptCharacter
	|
	|-RVA: 0x1232630 Offset: 0x1231030 VA: 0x181232630
	|-TextInputBaseField.TextInputBase<Hash128>.AcceptCharacter
	|
	|-RVA: 0x12326B0 Offset: 0x12310B0 VA: 0x1812326B0
	|-TextInputBaseField.TextInputBase<int>.AcceptCharacter
	|
	|-RVA: 0x1244FB0 Offset: 0x12439B0 VA: 0x181244FB0
	|-TextInputBaseField.TextInputBase<long>.AcceptCharacter
	|
	|-RVA: 0x12450B0 Offset: 0x1243AB0 VA: 0x1812450B0
	|-TextInputBaseField.TextInputBase<object>.AcceptCharacter
	|
	|-RVA: 0x12451B0 Offset: 0x1243BB0 VA: 0x1812451B0
	|-TextInputBaseField.TextInputBase<float>.AcceptCharacter
	|
	|-RVA: 0x1245130 Offset: 0x1243B30 VA: 0x181245130
	|-TextInputBaseField.TextInputBase<uint>.AcceptCharacter
	|
	|-RVA: 0x1245030 Offset: 0x1243A30 VA: 0x181245030
	|-TextInputBaseField.TextInputBase<ulong>.AcceptCharacter
	|
	|-RVA: 0x1245230 Offset: 0x1243C30 VA: 0x181245230
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.AcceptCharacter
	*/

	// RVA: -1 Offset: -1
	internal void UpdateScrollOffset(bool isBackspace = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1238940 Offset: 0x1237340 VA: 0x181238940
	|-TextInputBaseField.TextInputBase<double>.UpdateScrollOffset
	|
	|-RVA: 0x1239610 Offset: 0x1238010 VA: 0x181239610
	|-TextInputBaseField.TextInputBase<Hash128>.UpdateScrollOffset
	|
	|-RVA: 0x1238960 Offset: 0x1237360 VA: 0x181238960
	|-TextInputBaseField.TextInputBase<int>.UpdateScrollOffset
	|
	|-RVA: 0x12528E0 Offset: 0x12512E0 VA: 0x1812528E0
	|-TextInputBaseField.TextInputBase<long>.UpdateScrollOffset
	|
	|-RVA: 0x1252D70 Offset: 0x1251770 VA: 0x181252D70
	|-TextInputBaseField.TextInputBase<object>.UpdateScrollOffset
	|
	|-RVA: 0x1252900 Offset: 0x1251300 VA: 0x181252900
	|-TextInputBaseField.TextInputBase<float>.UpdateScrollOffset
	|
	|-RVA: 0x1252470 Offset: 0x1250E70 VA: 0x181252470
	|-TextInputBaseField.TextInputBase<uint>.UpdateScrollOffset
	|
	|-RVA: 0x1252490 Offset: 0x1250E90 VA: 0x181252490
	|-TextInputBaseField.TextInputBase<ulong>.UpdateScrollOffset
	|
	|-RVA: 0x1252D50 Offset: 0x1251750 VA: 0x181252D50
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.UpdateScrollOffset
	*/

	// RVA: -1 Offset: -1
	internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1238980 Offset: 0x1237380 VA: 0x181238980
	|-TextInputBaseField.TextInputBase<double>.UpdateScrollOffset
	|
	|-RVA: 0x12391E0 Offset: 0x1237BE0 VA: 0x1812391E0
	|-TextInputBaseField.TextInputBase<Hash128>.UpdateScrollOffset
	|
	|-RVA: 0x1238DB0 Offset: 0x12377B0 VA: 0x181238DB0
	|-TextInputBaseField.TextInputBase<int>.UpdateScrollOffset
	|
	|-RVA: 0x12524B0 Offset: 0x1250EB0 VA: 0x1812524B0
	|-TextInputBaseField.TextInputBase<long>.UpdateScrollOffset
	|
	|-RVA: 0x1252920 Offset: 0x1251320 VA: 0x181252920
	|-TextInputBaseField.TextInputBase<object>.UpdateScrollOffset
	|
	|-RVA: 0x1251C10 Offset: 0x1250610 VA: 0x181251C10
	|-TextInputBaseField.TextInputBase<float>.UpdateScrollOffset
	|
	|-RVA: 0x1252040 Offset: 0x1250A40 VA: 0x181252040
	|-TextInputBaseField.TextInputBase<uint>.UpdateScrollOffset
	|
	|-RVA: 0x1252D90 Offset: 0x1251790 VA: 0x181252D90
	|-TextInputBaseField.TextInputBase<ulong>.UpdateScrollOffset
	|
	|-RVA: 0x1251780 Offset: 0x1250180 VA: 0x181251780
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.UpdateScrollOffset
	*/

	// RVA: -1 Offset: -1
	private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1232730 Offset: 0x1231130 VA: 0x181232730
	|-TextInputBaseField.TextInputBase<double>.GetScrollOffset
	|
	|-RVA: 0x1232B70 Offset: 0x1231570 VA: 0x181232B70
	|-TextInputBaseField.TextInputBase<Hash128>.GetScrollOffset
	|
	|-RVA: 0x1232FB0 Offset: 0x12319B0 VA: 0x181232FB0
	|-TextInputBaseField.TextInputBase<int>.GetScrollOffset
	|
	|-RVA: 0x12456C0 Offset: 0x12440C0 VA: 0x1812456C0
	|-TextInputBaseField.TextInputBase<long>.GetScrollOffset
	|
	|-RVA: 0x1245280 Offset: 0x1243C80 VA: 0x181245280
	|-TextInputBaseField.TextInputBase<object>.GetScrollOffset
	|
	|-RVA: 0x12467E0 Offset: 0x12451E0 VA: 0x1812467E0
	|-TextInputBaseField.TextInputBase<float>.GetScrollOffset
	|
	|-RVA: 0x1245B00 Offset: 0x1244500 VA: 0x181245B00
	|-TextInputBaseField.TextInputBase<uint>.GetScrollOffset
	|
	|-RVA: 0x12463A0 Offset: 0x1244DA0 VA: 0x1812463A0
	|-TextInputBaseField.TextInputBase<ulong>.GetScrollOffset
	|
	|-RVA: 0x1245F40 Offset: 0x1244940 VA: 0x181245F40
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.GetScrollOffset
	*/

	// RVA: -1 Offset: -1
	internal void SetScrollViewMode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1237AC0 Offset: 0x12364C0 VA: 0x181237AC0
	|-TextInputBaseField.TextInputBase<double>.SetScrollViewMode
	|
	|-RVA: 0x1237380 Offset: 0x1235D80 VA: 0x181237380
	|-TextInputBaseField.TextInputBase<Hash128>.SetScrollViewMode
	|
	|-RVA: 0x1237720 Offset: 0x1236120 VA: 0x181237720
	|-TextInputBaseField.TextInputBase<int>.SetScrollViewMode
	|
	|-RVA: 0x124FA50 Offset: 0x124E450 VA: 0x18124FA50
	|-TextInputBaseField.TextInputBase<long>.SetScrollViewMode
	|
	|-RVA: 0x124F6B0 Offset: 0x124E0B0 VA: 0x18124F6B0
	|-TextInputBaseField.TextInputBase<object>.SetScrollViewMode
	|
	|-RVA: 0x124EB30 Offset: 0x124D530 VA: 0x18124EB30
	|-TextInputBaseField.TextInputBase<float>.SetScrollViewMode
	|
	|-RVA: 0x124EED0 Offset: 0x124D8D0 VA: 0x18124EED0
	|-TextInputBaseField.TextInputBase<uint>.SetScrollViewMode
	|
	|-RVA: 0x124FDF0 Offset: 0x124E7F0 VA: 0x18124FDF0
	|-TextInputBaseField.TextInputBase<ulong>.SetScrollViewMode
	|
	|-RVA: 0x124F270 Offset: 0x124DC70 VA: 0x18124F270
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SetScrollViewMode
	*/

	// RVA: -1 Offset: -1
	private void SetMultilineContainerStyle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1235C20 Offset: 0x1234620 VA: 0x181235C20
	|-TextInputBaseField.TextInputBase<double>.SetMultilineContainerStyle
	|
	|-RVA: 0x1235B70 Offset: 0x1234570 VA: 0x181235B70
	|-TextInputBaseField.TextInputBase<Hash128>.SetMultilineContainerStyle
	|
	|-RVA: 0x1235AC0 Offset: 0x12344C0 VA: 0x181235AC0
	|-TextInputBaseField.TextInputBase<int>.SetMultilineContainerStyle
	|
	|-RVA: 0x124BB40 Offset: 0x124A540 VA: 0x18124BB40
	|-TextInputBaseField.TextInputBase<long>.SetMultilineContainerStyle
	|
	|-RVA: 0x124BBF0 Offset: 0x124A5F0 VA: 0x18124BBF0
	|-TextInputBaseField.TextInputBase<object>.SetMultilineContainerStyle
	|
	|-RVA: 0x124B930 Offset: 0x124A330 VA: 0x18124B930
	|-TextInputBaseField.TextInputBase<float>.SetMultilineContainerStyle
	|
	|-RVA: 0x124BA90 Offset: 0x124A490 VA: 0x18124BA90
	|-TextInputBaseField.TextInputBase<uint>.SetMultilineContainerStyle
	|
	|-RVA: 0x124B9E0 Offset: 0x124A3E0 VA: 0x18124B9E0
	|-TextInputBaseField.TextInputBase<ulong>.SetMultilineContainerStyle
	|
	|-RVA: 0x124BCA0 Offset: 0x124A6A0 VA: 0x18124BCA0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.SetMultilineContainerStyle
	*/

	// RVA: -1 Offset: -1
	private void RemoveSingleLineComponents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12351C0 Offset: 0x1233BC0 VA: 0x1812351C0
	|-TextInputBaseField.TextInputBase<double>.RemoveSingleLineComponents
	|
	|-RVA: 0x1235520 Offset: 0x1233F20 VA: 0x181235520
	|-TextInputBaseField.TextInputBase<Hash128>.RemoveSingleLineComponents
	|
	|-RVA: 0x1235370 Offset: 0x1233D70 VA: 0x181235370
	|-TextInputBaseField.TextInputBase<int>.RemoveSingleLineComponents
	|
	|-RVA: 0x124ABE0 Offset: 0x12495E0 VA: 0x18124ABE0
	|-TextInputBaseField.TextInputBase<long>.RemoveSingleLineComponents
	|
	|-RVA: 0x124AF90 Offset: 0x1249990 VA: 0x18124AF90
	|-TextInputBaseField.TextInputBase<object>.RemoveSingleLineComponents
	|
	|-RVA: 0x124AA30 Offset: 0x1249430 VA: 0x18124AA30
	|-TextInputBaseField.TextInputBase<float>.RemoveSingleLineComponents
	|
	|-RVA: 0x124A6D0 Offset: 0x12490D0 VA: 0x18124A6D0
	|-TextInputBaseField.TextInputBase<uint>.RemoveSingleLineComponents
	|
	|-RVA: 0x124A880 Offset: 0x1249280 VA: 0x18124A880
	|-TextInputBaseField.TextInputBase<ulong>.RemoveSingleLineComponents
	|
	|-RVA: 0x124AD90 Offset: 0x1249790 VA: 0x18124AD90
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.RemoveSingleLineComponents
	*/

	// RVA: -1 Offset: -1
	private void RemoveMultilineComponents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12340E0 Offset: 0x1232AE0 VA: 0x1812340E0
	|-TextInputBaseField.TextInputBase<double>.RemoveMultilineComponents
	|
	|-RVA: 0x1234680 Offset: 0x1233080 VA: 0x181234680
	|-TextInputBaseField.TextInputBase<Hash128>.RemoveMultilineComponents
	|
	|-RVA: 0x1234C20 Offset: 0x1233620 VA: 0x181234C20
	|-TextInputBaseField.TextInputBase<int>.RemoveMultilineComponents
	|
	|-RVA: 0x1249B90 Offset: 0x1248590 VA: 0x181249B90
	|-TextInputBaseField.TextInputBase<long>.RemoveMultilineComponents
	|
	|-RVA: 0x1248A20 Offset: 0x1247420 VA: 0x181248A20
	|-TextInputBaseField.TextInputBase<object>.RemoveMultilineComponents
	|
	|-RVA: 0x12495F0 Offset: 0x1247FF0 VA: 0x1812495F0
	|-TextInputBaseField.TextInputBase<float>.RemoveMultilineComponents
	|
	|-RVA: 0x1248480 Offset: 0x1246E80 VA: 0x181248480
	|-TextInputBaseField.TextInputBase<uint>.RemoveMultilineComponents
	|
	|-RVA: 0x124A130 Offset: 0x1248B30 VA: 0x18124A130
	|-TextInputBaseField.TextInputBase<ulong>.RemoveMultilineComponents
	|
	|-RVA: 0x1248FC0 Offset: 0x12479C0 VA: 0x181248FC0
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>.RemoveMultilineComponents
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x123A870 Offset: 0x1239270 VA: 0x18123A870
	|-TextInputBaseField.TextInputBase<double>..cctor
	|
	|-RVA: 0x1239770 Offset: 0x1238170 VA: 0x181239770
	|-TextInputBaseField.TextInputBase<Hash128>..cctor
	|
	|-RVA: 0x1239FF0 Offset: 0x12389F0 VA: 0x181239FF0
	|-TextInputBaseField.TextInputBase<int>..cctor
	|
	|-RVA: 0x12531C0 Offset: 0x1251BC0 VA: 0x1812531C0
	|-TextInputBaseField.TextInputBase<long>..cctor
	|
	|-RVA: 0x1253A40 Offset: 0x1252440 VA: 0x181253A40
	|-TextInputBaseField.TextInputBase<object>..cctor
	|
	|-RVA: 0x1254B40 Offset: 0x1253540 VA: 0x181254B40
	|-TextInputBaseField.TextInputBase<float>..cctor
	|
	|-RVA: 0x12542C0 Offset: 0x1252CC0 VA: 0x1812542C0
	|-TextInputBaseField.TextInputBase<uint>..cctor
	|
	|-RVA: 0x12553C0 Offset: 0x1253DC0 VA: 0x1812553C0
	|-TextInputBaseField.TextInputBase<ulong>..cctor
	|
	|-RVA: 0x1255C40 Offset: 0x1254640 VA: 0x181255C40
	|-TextInputBaseField.TextInputBase<__Il2CppFullySharedGenericType>..cctor
	*/
}
