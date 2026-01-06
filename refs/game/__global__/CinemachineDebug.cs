public class CinemachineDebug // TypeDefIndex: 16257
{
	// Fields
	private static HashSet<Object> mClients; // 0x0
	public static CinemachineDebug.OnGUIDelegate OnGUIHandlers; // 0x8
	private static List<StringBuilder> mAvailableStringBuilders; // 0x10

	// Methods

	// RVA: 0xC423C0 Offset: 0xC40DC0 VA: 0x180C423C0
	public static void ReleaseScreenPos(Object client) { }

	// RVA: 0xC42040 Offset: 0xC40A40 VA: 0x180C42040
	public static Rect GetScreenPos(Object client, string text, GUIStyle style) { }

	// RVA: 0xC425A0 Offset: 0xC40FA0 VA: 0x180C425A0
	public static StringBuilder SBFromPool() { }

	// RVA: 0xC42460 Offset: 0xC40E60 VA: 0x180C42460
	public static void ReturnToPool(StringBuilder sb) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
