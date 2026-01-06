public struct Mathf // TypeDefIndex: 11756
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7300 Offset: 0x2CA5D00 VA: 0x182CA7300
	public static int ClosestPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7780 Offset: 0x2CA6180 VA: 0x182CA7780
	public static bool IsPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7BA0 Offset: 0x2CA65A0 VA: 0x182CA7BA0
	public static int NextPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7680 Offset: 0x2CA6080 VA: 0x182CA7680
	public static float GammaToLinearSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7820 Offset: 0x2CA6220 VA: 0x182CA7820
	public static float LinearToGammaSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7390 Offset: 0x2CA5D90 VA: 0x182CA7390
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2CA7580 Offset: 0x2CA5F80 VA: 0x182CA7580
	public static ushort FloatToHalf(float val) { }

	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	// RVA: 0x2CA7BE0 Offset: 0x2CA65E0 VA: 0x182CA7BE0
	public static float PerlinNoise(float x, float y) { }

	// RVA: 0x2CA7E80 Offset: 0x2CA6880 VA: 0x182CA7E80
	public static float Sin(float f) { }

	// RVA: 0x2CA73E0 Offset: 0x2CA5DE0 VA: 0x182CA73E0
	public static float Cos(float f) { }

	// RVA: 0x2CA81C0 Offset: 0x2CA6BC0 VA: 0x182CA81C0
	public static float Tan(float f) { }

	// RVA: 0x2CA7030 Offset: 0x2CA5A30 VA: 0x182CA7030
	public static float Asin(float f) { }

	// RVA: 0x2CA6F40 Offset: 0x2CA5940 VA: 0x182CA6F40
	public static float Acos(float f) { }

	// RVA: 0x2CA7100 Offset: 0x2CA5B00 VA: 0x182CA7100
	public static float Atan(float f) { }

	// RVA: 0x2CA7090 Offset: 0x2CA5A90 VA: 0x182CA7090
	public static float Atan2(float y, float x) { }

	// RVA: 0x2CA8140 Offset: 0x2CA6B40 VA: 0x182CA8140
	public static float Sqrt(float f) { }

	// RVA: 0x2CA6E90 Offset: 0x2CA5890 VA: 0x182CA6E90
	public static float Abs(float f) { }

	// RVA: 0x2CA6EF0 Offset: 0x2CA58F0 VA: 0x182CA6EF0
	public static int Abs(int value) { }

	// RVA: 0x2CA7A20 Offset: 0x2CA6420 VA: 0x182CA7A20
	public static float Min(float a, float b) { }

	// RVA: 0x2CA7A30 Offset: 0x2CA6430 VA: 0x182CA7A30
	public static float Min(float[] values) { }

	// RVA: 0x4A0E20 Offset: 0x49F820 VA: 0x1804A0E20
	public static int Min(int a, int b) { }

	// RVA: 0x44CBD0 Offset: 0x44B5D0 VA: 0x18044CBD0
	public static int Min(int[] values) { }

	// RVA: 0x2CA7A10 Offset: 0x2CA6410 VA: 0x182CA7A10
	public static float Max(float a, float b) { }

	// RVA: 0x2CA7990 Offset: 0x2CA6390 VA: 0x182CA7990
	public static float Max(float[] values) { }

	// RVA: 0x2B1CCF0 Offset: 0x2B1B6F0 VA: 0x182B1CCF0
	public static int Max(int a, int b) { }

	// RVA: 0x2CA7C30 Offset: 0x2CA6630 VA: 0x182CA7C30
	public static float Pow(float f, float p) { }

	// RVA: 0x2CA7520 Offset: 0x2CA5F20 VA: 0x182CA7520
	public static float Exp(float power) { }

	// RVA: 0x2CA78C0 Offset: 0x2CA62C0 VA: 0x182CA78C0
	public static float Log(float f, float p) { }

	// RVA: 0x2CA7930 Offset: 0x2CA6330 VA: 0x182CA7930
	public static float Log(float f) { }

	// RVA: 0x2CA7860 Offset: 0x2CA6260 VA: 0x182CA7860
	public static float Log10(float f) { }

	// RVA: 0x2CA71C0 Offset: 0x2CA5BC0 VA: 0x182CA71C0
	public static float Ceil(float f) { }

	// RVA: 0x2CA7620 Offset: 0x2CA6020 VA: 0x182CA7620
	public static float Floor(float f) { }

	// RVA: 0x2CA7E00 Offset: 0x2CA6800 VA: 0x182CA7E00
	public static float Round(float f) { }

	// RVA: 0x2CA7160 Offset: 0x2CA5B60 VA: 0x182CA7160
	public static int CeilToInt(float f) { }

	// RVA: 0x2CA75C0 Offset: 0x2CA5FC0 VA: 0x182CA75C0
	public static int FloorToInt(float f) { }

	// RVA: 0x2CA7DA0 Offset: 0x2CA67A0 VA: 0x182CA7DA0
	public static int RoundToInt(float f) { }

	// RVA: 0x2CA7E60 Offset: 0x2CA6860 VA: 0x182CA7E60
	public static float Sign(float f) { }

	// RVA: 0x2CA72E0 Offset: 0x2CA5CE0 VA: 0x182CA72E0
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0xDA65F0 Offset: 0xDA4FF0 VA: 0x180DA65F0
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x2CA7220 Offset: 0x2CA5C20 VA: 0x182CA7220
	public static float Clamp01(float value) { }

	// RVA: 0x2CA77E0 Offset: 0x2CA61E0 VA: 0x182CA77E0
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x2CA77C0 Offset: 0x2CA61C0 VA: 0x182CA77C0
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x527AD0 Offset: 0x5264D0 VA: 0x180527AD0
	public static float LerpAngle(float a, float b, float t) { }

	// RVA: 0x57FD00 Offset: 0x57E700 VA: 0x18057FD00
	public static float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x2CA7AA0 Offset: 0x2CA64A0 VA: 0x182CA7AA0
	public static float MoveTowardsAngle(float current, float target, float maxDelta) { }

	// RVA: 0x2CA80E0 Offset: 0x2CA6AE0 VA: 0x182CA80E0
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x2CA6FA0 Offset: 0x2CA59A0 VA: 0x182CA6FA0
	public static bool Approximately(float a, float b) { }

	[ExcludeFromDocs]
	// RVA: 0x527B80 Offset: 0x526580 VA: 0x180527B80
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) { }

	// RVA: 0x2CA7FA0 Offset: 0x2CA69A0 VA: 0x182CA7FA0
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[ExcludeFromDocs]
	// RVA: 0x1F198C0 Offset: 0x1F182C0 VA: 0x181F198C0
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime) { }

	// RVA: 0x2CA7EE0 Offset: 0x2CA68E0 VA: 0x182CA7EE0
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x489250 Offset: 0x487C50 VA: 0x180489250
	public static float Repeat(float t, float length) { }

	// RVA: 0x4BEC70 Offset: 0x4BD670 VA: 0x1804BEC70
	public static float PingPong(float t, float length) { }

	// RVA: 0x2CA7740 Offset: 0x2CA6140 VA: 0x182CA7740
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0xB7B710 Offset: 0xB7A110 VA: 0x180B7B710
	public static float DeltaAngle(float current, float target) { }

	// RVA: 0x2CA7240 Offset: 0x2CA5C40 VA: 0x182CA7240
	internal static float ClampToFloat(double value) { }

	// RVA: 0x2CA72A0 Offset: 0x2CA5CA0 VA: 0x182CA72A0
	internal static int ClampToInt(long value) { }

	// RVA: 0x2CA72C0 Offset: 0x2CA5CC0 VA: 0x182CA72C0
	internal static uint ClampToUInt(long value) { }

	// RVA: 0x2CA76C0 Offset: 0x2CA60C0 VA: 0x182CA76C0
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	// RVA: 0x2CA7CA0 Offset: 0x2CA66A0 VA: 0x182CA7CA0
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	// RVA: 0x2CA7440 Offset: 0x2CA5E40 VA: 0x182CA7440
	internal static double DiscardLeastSignificantDecimal(double v) { }

	// RVA: 0x2CA8220 Offset: 0x2CA6C20 VA: 0x182CA8220
	private static void .cctor() { }

	// RVA: 0x2CA7340 Offset: 0x2CA5D40 VA: 0x182CA7340
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }
}
