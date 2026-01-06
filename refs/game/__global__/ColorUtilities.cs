public static class ColorUtilities // TypeDefIndex: 17059
{
	// Fields
	private const float logC_cut = 0.011361;
	private const float logC_a = 5.555556;
	private const float logC_b = 0.047996;
	private const float logC_c = 0.244161;
	private const float logC_d = 0.386036;
	private const float logC_e = 5.301883;
	private const float logC_f = 0.092819;

	// Methods

	// RVA: 0x29AA080 Offset: 0x29A8A80 VA: 0x1829AA080
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x29A9C80 Offset: 0x29A8680 VA: 0x1829A9C80
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x29A9EB0 Offset: 0x29A88B0 VA: 0x1829A9EB0
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	// RVA: 0x29A9E40 Offset: 0x29A8840 VA: 0x1829A9E40
	public static Vector3 ColorToLift(Vector4 color) { }

	// RVA: 0x29A9D80 Offset: 0x29A8780 VA: 0x1829A9D80
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	// RVA: 0x29A9D10 Offset: 0x29A8710 VA: 0x1829A9D10
	public static Vector3 ColorToGain(Vector4 color) { }

	// RVA: 0x29AA020 Offset: 0x29A8A20 VA: 0x1829AA020
	public static float LogCToLinear(float x) { }

	// RVA: 0x29A9FD0 Offset: 0x29A89D0 VA: 0x1829A9FD0
	public static float LinearToLogC(float x) { }

	// RVA: 0x29AA0B0 Offset: 0x29A8AB0 VA: 0x1829AA0B0
	public static uint ToHex(Color c) { }

	// RVA: 0x29AA130 Offset: 0x29A8B30 VA: 0x1829AA130
	public static Color ToRGBA(uint hex) { }
}
