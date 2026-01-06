public class GUIContent // TypeDefIndex: 17591
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action OnTextChanged; // 0x28
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public string get_text() { }

	// RVA: 0x2D052F0 Offset: 0x2D03CF0 VA: 0x182D052F0
	public void set_text(string value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_image(Texture value) { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public string get_tooltip() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_tooltip(string value) { }

	// RVA: 0x2D05170 Offset: 0x2D03B70 VA: 0x182D05170
	public void .ctor() { }

	// RVA: 0x2D051E0 Offset: 0x2D03BE0 VA: 0x182D051E0
	public void .ctor(string text) { }

	// RVA: 0x2D04F80 Offset: 0x2D03980 VA: 0x182D04F80
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x2D05070 Offset: 0x2D03A70 VA: 0x182D05070
	public void .ctor(GUIContent src) { }

	// RVA: 0x2D04B50 Offset: 0x2D03550 VA: 0x182D04B50
	internal static GUIContent Temp(string t) { }

	// RVA: 0x2D049E0 Offset: 0x2D033E0 VA: 0x182D049E0
	internal static void ClearStaticCache() { }

	// RVA: 0x2D04C10 Offset: 0x2D03610 VA: 0x182D04C10
	internal static GUIContent[] Temp(string[] texts) { }

	// RVA: 0x2D04D50 Offset: 0x2D03750 VA: 0x182D04D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D04D80 Offset: 0x2D03780 VA: 0x182D04D80
	private static void .cctor() { }
}
