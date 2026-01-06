public static class CameraCaptureBridge // TypeDefIndex: 13847
{
	// Fields
	private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x0
	private static bool _enabled; // 0x8

	// Properties
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x2A384F0 Offset: 0x2A36EF0 VA: 0x182A384F0
	public static bool get_enabled() { }

	// RVA: 0x2A38540 Offset: 0x2A36F40 VA: 0x182A38540
	public static void set_enabled(bool value) { }

	// RVA: 0x2A38270 Offset: 0x2A36C70 VA: 0x182A38270
	public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) { }

	// RVA: 0x2A38110 Offset: 0x2A36B10 VA: 0x182A38110
	public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	// RVA: 0x2A38370 Offset: 0x2A36D70 VA: 0x182A38370
	public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	// RVA: 0x2A38460 Offset: 0x2A36E60 VA: 0x182A38460
	private static void .cctor() { }
}
