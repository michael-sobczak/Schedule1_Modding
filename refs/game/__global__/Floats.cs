public static class Floats // TypeDefIndex: 18160
{
	// Fields
	private static Random _random; // 0x0

	// Methods

	[Extension]
	// RVA: 0xDA5BA0 Offset: 0xDA45A0 VA: 0x180DA5BA0
	public static float SetIfOverTolerance(float source, float tolerance, float value) { }

	[Extension]
	// RVA: 0xDA5BB0 Offset: 0xDA45B0 VA: 0x180DA5BB0
	public static float SetIfUnderTolerance(float source, float tolerance, float value) { }

	[Extension]
	// RVA: 0xDA5F90 Offset: 0xDA4990 VA: 0x180DA5F90
	public static float TimeRemainingValue(float endTime) { }

	[Extension]
	// RVA: 0xDA5FE0 Offset: 0xDA49E0 VA: 0x180DA5FE0
	public static int TimeRemainingValue(float endTime, bool useFloor = True) { }

	[Extension]
	// RVA: 0xDA5BC0 Offset: 0xDA45C0 VA: 0x180DA5BC0
	public static string TimeRemainingText(float value, byte segments, bool emptyOnZero = False) { }

	// RVA: 0xDA5A50 Offset: 0xDA4450 VA: 0x180DA5A50
	public static float RandomInclusiveRange(float minimum, float maximum) { }

	// RVA: 0xDA5A00 Offset: 0xDA4400 VA: 0x180DA5A00
	public static float Random01() { }

	[Extension]
	// RVA: 0xDA59B0 Offset: 0xDA43B0 VA: 0x180DA59B0
	public static bool Near(float a, float b, float tolerance = 0.01) { }

	// RVA: 0xDA5970 Offset: 0xDA4370 VA: 0x180DA5970
	public static float Clamp(float value, float min, float max, ref bool clamped) { }

	[Extension]
	// RVA: 0xDA60D0 Offset: 0xDA4AD0 VA: 0x180DA60D0
	public static float Variance(float source, float variance) { }

	[Extension]
	// RVA: 0xDA6150 Offset: 0xDA4B50 VA: 0x180DA6150
	public static void Variance(float source, float variance, ref float result) { }

	// RVA: 0xDA59D0 Offset: 0xDA43D0 VA: 0x180DA59D0
	public static float PreciseSign(float value) { }

	[Extension]
	// RVA: 0xDA59A0 Offset: 0xDA43A0 VA: 0x180DA59A0
	public static bool InRange(float source, float rangeMin, float rangeMax) { }

	[Extension]
	// RVA: 0xDA5B30 Offset: 0xDA4530 VA: 0x180DA5B30
	public static float RandomlyFlip(float value) { }

	// RVA: 0xDA61D0 Offset: 0xDA4BD0 VA: 0x180DA61D0
	private static void .cctor() { }
}
