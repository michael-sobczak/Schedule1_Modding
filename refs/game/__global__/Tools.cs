public static class Tools // TypeDefIndex: 9214
{
	// Fields
	public static Color ColorBlack; // 0x0
	private static Mesh _fullScreenMesh; // 0x10

	// Properties
	public static Mesh fullscreenMesh { get; }

	// Methods

	// RVA: 0x2A98150 Offset: 0x2A96B50 VA: 0x182A98150
	public static void CheckCamera(ref Camera cam) { }

	// RVA: 0x2A982B0 Offset: 0x2A96CB0 VA: 0x182A982B0
	public static VolumetricFogManager CheckMainManager() { }

	// RVA: -1 Offset: -1
	public static void CheckManager<T>(ref T manager) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61640 Offset: 0xF60040 VA: 0x180F61640
	|-Tools.CheckManager<object>
	*/

	// RVA: 0x2A983E0 Offset: 0x2A96DE0 VA: 0x182A983E0
	public static Mesh get_fullscreenMesh() { }

	// RVA: 0x2A983A0 Offset: 0x2A96DA0 VA: 0x182A983A0
	private static void .cctor() { }
}
