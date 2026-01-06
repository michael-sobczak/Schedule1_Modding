public sealed class Font : Object // TypeDefIndex: 19034
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2D89C90 Offset: 0x2D88690 VA: 0x182D89C90
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x2D89E30 Offset: 0x2D88830 VA: 0x182D89E30
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x2D89DF0 Offset: 0x2D887F0 VA: 0x182D89DF0
	public Material get_material() { }

	// RVA: 0x2D89D70 Offset: 0x2D88770 VA: 0x182D89D70
	public bool get_dynamic() { }

	// RVA: 0x2D89DB0 Offset: 0x2D887B0 VA: 0x182D89DB0
	public int get_fontSize() { }

	// RVA: 0x2D89C20 Offset: 0x2D88620 VA: 0x182D89C20
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2D89BA0 Offset: 0x2D885A0 VA: 0x182D89BA0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x2D89AC0 Offset: 0x2D884C0 VA: 0x182D89AC0
	public bool HasCharacter(char c) { }

	// RVA: 0x2D89B10 Offset: 0x2D88510 VA: 0x182D89B10
	private bool HasCharacter(int c) { }

	// RVA: 0x2D89A90 Offset: 0x2D88490 VA: 0x182D89A90
	public static string[] GetPathsToOSFonts() { }

	// RVA: 0x2D89B50 Offset: 0x2D88550 VA: 0x182D89B50
	private static void Internal_CreateFont(Font self, string name) { }
}
