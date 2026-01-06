public static class Damper // TypeDefIndex: 16263
{
	// Fields
	private const float Epsilon = 0.0001;
	public const float kNegligibleResidual = 0.01;
	private const float kLogNegligibleResidual = -4.6051702;

	// Methods

	// RVA: 0xC49660 Offset: 0xC48060 VA: 0x180C49660
	private static float DecayConstant(float time, float residual) { }

	// RVA: 0xC49690 Offset: 0xC48090 VA: 0x180C49690
	private static float DecayedRemainder(float initial, float decayConstant, float deltaTime) { }

	// RVA: 0xC491E0 Offset: 0xC47BE0 VA: 0x180C491E0
	public static float Damp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0xC49260 Offset: 0xC47C60 VA: 0x180C49260
	public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0xC49460 Offset: 0xC47E60 VA: 0x180C49460
	public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) { }
}
