public static class Random // TypeDefIndex: 11786
{
	// Properties
	[StaticAccessor("GetScriptingRand()", 0)]
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }

	// Methods

	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", 0)]
	// RVA: 0x2CC41D0 Offset: 0x2CC2BD0 VA: 0x182CC41D0
	public static void InitState(int seed) { }

	// RVA: 0x2CC44A0 Offset: 0x2CC2EA0 VA: 0x182CC44A0
	public static Random.State get_state() { }

	// RVA: 0x2CC4550 Offset: 0x2CC2F50 VA: 0x182CC4550
	public static void set_state(Random.State value) { }

	[FreeFunction]
	// RVA: 0x2CC4250 Offset: 0x2CC2C50 VA: 0x182CC4250
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x2CC4210 Offset: 0x2CC2C10 VA: 0x182CC4210
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2CC4210 Offset: 0x2CC2C10 VA: 0x182CC4210
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x2CC44E0 Offset: 0x2CC2EE0 VA: 0x182CC44E0
	public static float get_value() { }

	[FreeFunction]
	// RVA: 0x2CC4320 Offset: 0x2CC2D20 VA: 0x182CC4320
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunction]
	// RVA: 0x2CC4190 Offset: 0x2CC2B90 VA: 0x182CC4190
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x2CC42A0 Offset: 0x2CC2CA0 VA: 0x182CC42A0
	public static Vector2 get_insideUnitCircle() { }

	[FreeFunction]
	// RVA: 0x2CC43A0 Offset: 0x2CC2DA0 VA: 0x182CC43A0
	public static Vector3 get_onUnitSphere() { }

	[FreeFunction]
	// RVA: 0x2CC4420 Offset: 0x2CC2E20 VA: 0x182CC4420
	public static Quaternion get_rotation() { }

	// RVA: 0x2CC4130 Offset: 0x2CC2B30 VA: 0x182CC4130
	public static Color ColorHSV() { }

	// RVA: 0x2CC3F50 Offset: 0x2CC2950 VA: 0x182CC3F50
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x2CC4460 Offset: 0x2CC2E60 VA: 0x182CC4460
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x2CC4510 Offset: 0x2CC2F10 VA: 0x182CC4510
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x2CC42E0 Offset: 0x2CC2CE0 VA: 0x182CC42E0
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x2CC4360 Offset: 0x2CC2D60 VA: 0x182CC4360
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x2CC43E0 Offset: 0x2CC2DE0 VA: 0x182CC43E0
	private static void get_rotation_Injected(out Quaternion ret) { }
}
