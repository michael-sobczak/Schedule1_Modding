public class TouchScreenKeyboard // TypeDefIndex: 11879
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static bool isSupported { get; }
	internal static bool disableInPlaceEditing { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	// RVA: 0x2CCB1D0 Offset: 0x2CC9BD0 VA: 0x182CCB1D0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2CCB000 Offset: 0x2CC9A00 VA: 0x182CCB000
	private void Destroy() { }

	// RVA: 0x2CCB0A0 Offset: 0x2CC9AA0 VA: 0x182CCB0A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2CCB590 Offset: 0x2CC9F90 VA: 0x182CCB590
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	// RVA: 0x2CCB530 Offset: 0x2CC9F30 VA: 0x182CCB530
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x2CCB7F0 Offset: 0x2CCA1F0 VA: 0x182CCB7F0
	public static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x2CCB780 Offset: 0x2CCA180 VA: 0x182CCB780
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x2CCB7C0 Offset: 0x2CCA1C0 VA: 0x182CCB7C0
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x2CCB210 Offset: 0x2CC9C10 VA: 0x182CCB210
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocs]
	// RVA: 0x2CCB370 Offset: 0x2CC9D70 VA: 0x182CCB370
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeName("GetText")]
	// RVA: 0x2CCB940 Offset: 0x2CCA340 VA: 0x182CCB940
	public string get_text() { }

	[NativeName("SetText")]
	// RVA: 0x2CCBB50 Offset: 0x2CCA550 VA: 0x182CCBB50
	public void set_text(string value) { }

	[NativeName("SetInputHidden")]
	// RVA: 0x2CCBA10 Offset: 0x2CCA410 VA: 0x182CCBA10
	public static void set_hideInput(bool value) { }

	[NativeName("IsActive")]
	// RVA: 0x2CCB6C0 Offset: 0x2CCA0C0 VA: 0x182CCB6C0
	public bool get_active() { }

	[NativeName("SetActive")]
	// RVA: 0x2CCB980 Offset: 0x2CCA380 VA: 0x182CCB980
	public void set_active(bool value) { }

	[NativeName("GetKeyboardStatus")]
	// RVA: 0x2CCB900 Offset: 0x2CCA300 VA: 0x182CCB900
	public TouchScreenKeyboard.Status get_status() { }

	[NativeName("SetCharacterLimit")]
	// RVA: 0x2CCB9D0 Offset: 0x2CCA3D0 VA: 0x182CCB9D0
	public void set_characterLimit(int value) { }

	[NativeName("CanGetSelection")]
	// RVA: 0x2CCB700 Offset: 0x2CCA100 VA: 0x182CCB700
	public bool get_canGetSelection() { }

	[NativeName("CanSetSelection")]
	// RVA: 0x2CCB740 Offset: 0x2CCA140 VA: 0x182CCB740
	public bool get_canSetSelection() { }

	// RVA: 0x2CCB8B0 Offset: 0x2CCA2B0 VA: 0x182CCB8B0
	public RangeInt get_selection() { }

	// RVA: 0x2CCBA50 Offset: 0x2CCA450 VA: 0x182CCBA50
	public void set_selection(RangeInt value) { }

	// RVA: 0x2CCB180 Offset: 0x2CC9B80 VA: 0x182CCB180
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x2CCB4F0 Offset: 0x2CC9EF0 VA: 0x182CCB4F0
	private static void SetSelection(int start, int length) { }
}
