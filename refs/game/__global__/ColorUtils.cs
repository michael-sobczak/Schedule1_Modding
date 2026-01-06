public static class ColorUtils // TypeDefIndex: 13849
{
	// Fields
	public static float s_LightMeterCalibrationConstant; // 0x0
	public static float s_LensAttenuation; // 0x4

	// Properties
	public static float lensImperfectionExposureScale { get; }

	// Methods

	// RVA: 0x2A39540 Offset: 0x2A37F40 VA: 0x182A39540
	public static float get_lensImperfectionExposureScale() { }

	// RVA: 0x29AA080 Offset: 0x29A8A80 VA: 0x1829AA080
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x29A9C80 Offset: 0x29A8680 VA: 0x1829A9C80
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x2A38900 Offset: 0x2A37300 VA: 0x182A38900
	public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) { }

	// RVA: 0x2A39160 Offset: 0x2A37B60 VA: 0x182A39160
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights) { }

	// RVA: 0x2A38E00 Offset: 0x2A37800 VA: 0x182A38E00
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain) { }

	// RVA: 0x2A39410 Offset: 0x2A37E10 VA: 0x182A39410
	public static ValueTuple<Vector4, Vector4> PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance) { }

	// RVA: 0x2A38DD0 Offset: 0x2A377D0 VA: 0x182A38DD0
	public static float Luminance(in Color color) { }

	// RVA: 0x2A38B30 Offset: 0x2A37530 VA: 0x182A38B30
	public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) { }

	// RVA: 0x2A38C00 Offset: 0x2A37600 VA: 0x182A38C00
	public static float ConvertEV100ToExposure(float EV100) { }

	// RVA: 0x2A38CD0 Offset: 0x2A376D0 VA: 0x182A38CD0
	public static float ConvertExposureToEV100(float exposure) { }

	// RVA: 0x2A38A80 Offset: 0x2A37480 VA: 0x182A38A80
	public static float ComputeEV100FromAvgLuminance(float avgLuminance) { }

	// RVA: 0x2A38BB0 Offset: 0x2A375B0 VA: 0x182A38BB0
	public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) { }

	// RVA: 0x29AA0B0 Offset: 0x29A8AB0 VA: 0x1829AA0B0
	public static uint ToHex(Color c) { }

	// RVA: 0x29AA130 Offset: 0x29A8B30 VA: 0x1829AA130
	public static Color ToRGBA(uint hex) { }

	// RVA: 0x2A394F0 Offset: 0x2A37EF0 VA: 0x182A394F0
	private static void .cctor() { }
}
