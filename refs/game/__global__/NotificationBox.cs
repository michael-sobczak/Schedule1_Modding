internal class NotificationBox // TypeDefIndex: 18236
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsSceneView>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <MarginBottom>k__BackingField; // 0x14
	private readonly GUIContent _title; // 0x18
	private readonly GUIContent _text; // 0x20
	private readonly GUIContent _buttonContent; // 0x28
	private readonly string _buttonUrl; // 0x30
	private bool _stylesLoaded; // 0x38
	private GUIStyle _backgroundStyle; // 0x40
	private GUIStyle _textStyle; // 0x48
	private GUIStyle _titleStyle; // 0x50
	private GUIStyle _buttonStyle; // 0x58

	// Properties
	public bool IsSceneView { get; set; }
	public float MarginBottom { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsSceneView() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	public void set_IsSceneView(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_MarginBottom() { }

	[CompilerGenerated]
	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	public void set_MarginBottom(float value) { }

	// RVA: 0x2F676F0 Offset: 0x2F660F0 VA: 0x182F676F0
	public void .ctor(string title, string text) { }

	// RVA: 0x2F677B0 Offset: 0x2F661B0 VA: 0x182F677B0
	public void .ctor(string title, string text, string button, string url) { }

	// RVA: 0x2F671A0 Offset: 0x2F65BA0 VA: 0x182F671A0
	private void LoadStyles() { }

	// RVA: 0x2F66890 Offset: 0x2F65290 VA: 0x182F66890
	public void Draw() { }
}
