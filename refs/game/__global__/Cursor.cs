public class Cursor // TypeDefIndex: 11740
{
	// Properties
	public static bool visible { get; set; }
	public static CursorLockMode lockState { get; set; }

	// Methods

	// RVA: 0x2CA5660 Offset: 0x2CA4060 VA: 0x182CA5660
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x2CA56E0 Offset: 0x2CA40E0 VA: 0x182CA56E0
	public static bool get_visible() { }

	// RVA: 0x2CA5750 Offset: 0x2CA4150 VA: 0x182CA5750
	public static void set_visible(bool value) { }

	// RVA: 0x2CA56B0 Offset: 0x2CA40B0 VA: 0x182CA56B0
	public static CursorLockMode get_lockState() { }

	// RVA: 0x2CA5710 Offset: 0x2CA4110 VA: 0x182CA5710
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x2CA5600 Offset: 0x2CA4000 VA: 0x182CA5600
	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }
}
