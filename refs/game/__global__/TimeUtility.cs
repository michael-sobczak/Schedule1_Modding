internal static class TimeUtility // TypeDefIndex: 17470
{
	// Fields
	public static readonly double kTimeEpsilon; // 0x0
	public static readonly double kFrameRateEpsilon; // 0x8
	public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
	public static readonly double kFrameRateRounding; // 0x18

	// Methods

	// RVA: 0x2C5EB00 Offset: 0x2C5D500 VA: 0x182C5EB00
	private static void ValidateFrameRate(double frameRate) { }

	// RVA: 0x2C5E690 Offset: 0x2C5D090 VA: 0x182C5E690
	public static int ToFrames(double time, double frameRate) { }

	// RVA: 0x2C5E440 Offset: 0x2C5CE40 VA: 0x182C5E440
	public static double ToExactFrames(double time, double frameRate) { }

	// RVA: 0x2C5C870 Offset: 0x2C5B270 VA: 0x182C5C870
	public static double FromFrames(int frames, double frameRate) { }

	// RVA: 0x2C5C8E0 Offset: 0x2C5B2E0 VA: 0x182C5C8E0
	public static double FromFrames(double frames, double frameRate) { }

	// RVA: 0x2C5CF50 Offset: 0x2C5B950 VA: 0x182C5CF50
	public static bool OnFrameBoundary(double time, double frameRate) { }

	// RVA: 0x2C5CBE0 Offset: 0x2C5B5E0 VA: 0x182C5CBE0
	public static double GetEpsilon(double time, double frameRate) { }

	// RVA: 0x2C5DBD0 Offset: 0x2C5C5D0 VA: 0x182C5DBD0
	public static int PreviousFrame(double time, double frameRate) { }

	// RVA: 0x2C5CD70 Offset: 0x2C5B770 VA: 0x182C5CD70
	public static int NextFrame(double time, double frameRate) { }

	// RVA: 0x2C5DAC0 Offset: 0x2C5C4C0 VA: 0x182C5DAC0
	public static double PreviousFrameTime(double time, double frameRate) { }

	// RVA: 0x2C5CC90 Offset: 0x2C5B690 VA: 0x182C5CC90
	public static double NextFrameTime(double time, double frameRate) { }

	// RVA: 0x2C5CDE0 Offset: 0x2C5B7E0 VA: 0x182C5CDE0
	public static bool OnFrameBoundary(double time, double frameRate, double epsilon) { }

	// RVA: 0x2C5DD70 Offset: 0x2C5C770 VA: 0x182C5DD70
	public static double RoundToFrame(double time, double frameRate) { }

	// RVA: 0x2C5DE60 Offset: 0x2C5C860 VA: 0x182C5DE60
	public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2") { }

	// RVA: 0x2C5DF80 Offset: 0x2C5C980 VA: 0x182C5DF80
	public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2") { }

	// RVA: 0x2C5D100 Offset: 0x2C5BB00 VA: 0x182C5D100
	public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue) { }

	// RVA: 0x2C5D6C0 Offset: 0x2C5C0C0 VA: 0x182C5D6C0
	public static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue) { }

	// RVA: 0x2C5C950 Offset: 0x2C5B350 VA: 0x182C5C950
	public static double GetAnimationClipLength(AnimationClip clip) { }

	// RVA: 0x2C5DC70 Offset: 0x2C5C670 VA: 0x182C5DC70
	private static string RemoveChar(string str, Func<char, bool> charToRemoveFunc) { }

	// RVA: 0x2C5CAE0 Offset: 0x2C5B4E0 VA: 0x182C5CAE0
	public static FrameRate GetClosestFrameRate(double frameRate) { }

	// RVA: 0x2C5E4B0 Offset: 0x2C5CEB0 VA: 0x182C5E4B0
	public static FrameRate ToFrameRate(StandardFrameRates enumValue) { }

	// RVA: 0x2C5E7D0 Offset: 0x2C5D1D0 VA: 0x182C5E7D0
	internal static bool ToStandardFrameRate(FrameRate rate, out StandardFrameRates standard) { }

	// RVA: 0x2C5EBC0 Offset: 0x2C5D5C0 VA: 0x182C5EBC0
	private static void .cctor() { }
}
