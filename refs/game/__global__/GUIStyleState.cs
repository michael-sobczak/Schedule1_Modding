public sealed class GUIStyleState // TypeDefIndex: 17606
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("Background", False, 0)]
	public Texture2D background { set; }
	[NativeProperty("textColor", False, 1)]
	public Color textColor { set; }

	// Methods

	// RVA: 0x2D0F370 Offset: 0x2D0DD70 VA: 0x182D0F370
	public void set_background(Texture2D value) { }

	// RVA: 0x2D0F410 Offset: 0x2D0DE10 VA: 0x182D0F410
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x2D0F300 Offset: 0x2D0DD00 VA: 0x182D0F300
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2D0F1B0 Offset: 0x2D0DBB0 VA: 0x182D0F1B0
	private void Cleanup() { }

	// RVA: 0x2D0F330 Offset: 0x2D0DD30 VA: 0x182D0F330
	public void .ctor() { }

	// RVA: 0x2C9C270 Offset: 0x2C9AC70 VA: 0x182C9C270
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x2D0F280 Offset: 0x2D0DC80 VA: 0x182D0F280
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x2D0F1F0 Offset: 0x2D0DBF0 VA: 0x182D0F1F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D0F3C0 Offset: 0x2D0DDC0 VA: 0x182D0F3C0
	private void set_textColor_Injected(ref Color value) { }
}
