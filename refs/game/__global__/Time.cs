public class Time // TypeDefIndex: 11876
{
	// Properties
	[NativeProperty("CurTime")]
	public static float time { get; }
	[NativeProperty("TimeSinceSceneLoad")]
	public static float timeSinceLevelLoad { get; }
	public static float deltaTime { get; }
	public static float unscaledTime { get; }
	public static float fixedUnscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; set; }
	public static float maximumDeltaTime { get; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount { get; }
	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup { get; }
	[NativeProperty("Realtime")]
	public static double realtimeSinceStartupAsDouble { get; }

	// Methods

	// RVA: 0x2CCAEF0 Offset: 0x2CC98F0 VA: 0x182CCAEF0
	public static float get_time() { }

	// RVA: 0x2CCAEC0 Offset: 0x2CC98C0 VA: 0x182CCAEC0
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x2CCACE0 Offset: 0x2CC96E0 VA: 0x182CCACE0
	public static float get_deltaTime() { }

	// RVA: 0x2CCAF50 Offset: 0x2CC9950 VA: 0x182CCAF50
	public static float get_unscaledTime() { }

	// RVA: 0x2CCAD40 Offset: 0x2CC9740 VA: 0x182CCAD40
	public static float get_fixedUnscaledTime() { }

	// RVA: 0x2CCAF20 Offset: 0x2CC9920 VA: 0x182CCAF20
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x2CCAD10 Offset: 0x2CC9710 VA: 0x182CCAD10
	public static float get_fixedDeltaTime() { }

	// RVA: 0x2CCAF80 Offset: 0x2CC9980 VA: 0x182CCAF80
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x2CCADA0 Offset: 0x2CC97A0 VA: 0x182CCADA0
	public static float get_maximumDeltaTime() { }

	// RVA: 0x2CCAE60 Offset: 0x2CC9860 VA: 0x182CCAE60
	public static float get_smoothDeltaTime() { }

	// RVA: 0x2CCAE90 Offset: 0x2CC9890 VA: 0x182CCAE90
	public static float get_timeScale() { }

	// RVA: 0x2CCAFC0 Offset: 0x2CC99C0 VA: 0x182CCAFC0
	public static void set_timeScale(float value) { }

	// RVA: 0x2CCAD70 Offset: 0x2CC9770 VA: 0x182CCAD70
	public static int get_frameCount() { }

	// RVA: 0x2CCAE30 Offset: 0x2CC9830 VA: 0x182CCAE30
	public static int get_renderedFrameCount() { }

	// RVA: 0x2CCAE00 Offset: 0x2CC9800 VA: 0x182CCAE00
	public static float get_realtimeSinceStartup() { }

	// RVA: 0x2CCADD0 Offset: 0x2CC97D0 VA: 0x182CCADD0
	public static double get_realtimeSinceStartupAsDouble() { }
}
