public static class Vectors // TypeDefIndex: 18181
{
	// Fields
	private static readonly Vector3 VECTOR3_ZERO; // 0x0
	private const float FLOAT_EPSILON = 1E-05;

	// Methods

	[Extension]
	// RVA: 0xDABDB0 Offset: 0xDAA7B0 VA: 0x180DABDB0
	public static float GetRate(Vector3 a, Vector3 goal, float duration, out float distance, uint interval = 1) { }

	[Extension]
	// RVA: 0xDABA60 Offset: 0xDAA460 VA: 0x180DABA60
	public static Vector3 Add(Vector3 v3, Vector2 v2) { }

	[Extension]
	// RVA: 0xDAC7A0 Offset: 0xDAB1A0 VA: 0x180DAC7A0
	public static Vector3 Subtract(Vector3 v3, Vector2 v2) { }

	// RVA: 0xDABED0 Offset: 0xDAA8D0 VA: 0x180DABED0
	public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value) { }

	[Extension]
	// RVA: 0xDAC6A0 Offset: 0xDAB0A0 VA: 0x180DAC6A0
	public static bool Near(Vector3 a, Vector3 b, float tolerance = 0.01) { }

	[Extension]
	// RVA: 0xC4E150 Offset: 0xC4CB50 VA: 0x180C4E150
	public static bool IsNan(Vector3 source) { }

	// RVA: 0xDAC2B0 Offset: 0xDAACB0 VA: 0x180DAC2B0
	public static Vector3 Lerp3(Vector3 a, Vector3 b, Vector3 c, float percent) { }

	// RVA: 0xDAC440 Offset: 0xDAAE40 VA: 0x180DAC440
	public static Vector3 Lerp3(Vector3[] vectors, float percent) { }

	[Extension]
	// RVA: 0xDAC620 Offset: 0xDAB020 VA: 0x180DAC620
	public static Vector3 Multiply(Vector3 src, Vector3 multiplier) { }

	// RVA: 0xDABAA0 Offset: 0xDAA4A0 VA: 0x180DABAA0
	public static float FastDistance(Vector3 a, Vector3 b) { }

	// RVA: 0xDABCA0 Offset: 0xDAA6A0 VA: 0x180DABCA0
	public static float FastSqrMagnitude(Vector3 vector) { }

	// RVA: 0xDABB70 Offset: 0xDAA570 VA: 0x180DABB70
	public static Vector3 FastNormalize(Vector3 value) { }

	[Extension]
	// RVA: 0xDABCD0 Offset: 0xDAA6D0 VA: 0x180DABCD0
	public static float GetRate(Vector2 a, Vector2 goal, float duration, out float distance, uint interval = 1) { }

	// RVA: 0xDAC1C0 Offset: 0xDAABC0 VA: 0x180DAC1C0
	public static Vector2 Lerp3(Vector2 a, Vector2 b, Vector2 c, float percent) { }

	// RVA: 0xDABF80 Offset: 0xDAA980 VA: 0x180DABF80
	public static Vector2 Lerp2(Vector2[] vectors, float percent) { }

	[Extension]
	// RVA: 0xDAC660 Offset: 0xDAB060 VA: 0x180DAC660
	public static Vector2 Multiply(Vector2 src, Vector2 multiplier) { }

	// RVA: 0xDAC7E0 Offset: 0xDAB1E0 VA: 0x180DAC7E0
	private static void .cctor() { }
}
