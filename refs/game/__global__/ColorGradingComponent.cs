public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel> // TypeDefIndex: 124
{
	// Fields
	private const int k_InternalLogLutSize = 32;
	private const int k_CurvePrecision = 128;
	private const float k_CurveStep = 0.0078125;
	private Texture2D m_GradingCurves; // 0x20
	private Color[] m_pixels; // 0x28

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x5708F0 Offset: 0x56F2F0 VA: 0x1805708F0 Slot: 5
	public override bool get_active() { }

	// RVA: 0x570850 Offset: 0x56F250 VA: 0x180570850
	private float StandardIlluminantY(float x) { }

	// RVA: 0x56E200 Offset: 0x56CC00 VA: 0x18056E200
	private Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x56E290 Offset: 0x56CC90 VA: 0x18056E290
	private Vector3 CalculateColorBalance(float temperature, float tint) { }

	// RVA: 0x570210 Offset: 0x56EC10 VA: 0x180570210
	private static Color NormalizeColor(Color c) { }

	// RVA: 0x56E620 Offset: 0x56D020 VA: 0x18056E620
	private static Vector3 ClampVector(Vector3 v, float min, float max) { }

	// RVA: 0x56FBB0 Offset: 0x56E5B0 VA: 0x18056FBB0
	public static Vector3 GetLiftValue(Color lift) { }

	// RVA: 0x56F980 Offset: 0x56E380 VA: 0x18056F980
	public static Vector3 GetGammaValue(Color gamma) { }

	// RVA: 0x56F7B0 Offset: 0x56E1B0 VA: 0x18056F7B0
	public static Vector3 GetGainValue(Color gain) { }

	// RVA: 0x56E3B0 Offset: 0x56CDB0 VA: 0x18056E3B0
	public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain) { }

	// RVA: 0x570010 Offset: 0x56EA10 VA: 0x180570010
	public static Vector3 GetSlopeValue(Color slope) { }

	// RVA: 0x56FE80 Offset: 0x56E880 VA: 0x18056FE80
	public static Vector3 GetPowerValue(Color power) { }

	// RVA: 0x56FD20 Offset: 0x56E720 VA: 0x18056FD20
	public static Vector3 GetOffsetValue(Color offset) { }

	// RVA: 0x56E570 Offset: 0x56CF70 VA: 0x18056E570
	public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset) { }

	// RVA: 0x56F320 Offset: 0x56DD20 VA: 0x18056F320
	private TextureFormat GetCurveFormat() { }

	// RVA: 0x56F350 Offset: 0x56DD50 VA: 0x18056F350
	private Texture2D GetCurveTexture() { }

	// RVA: 0x570180 Offset: 0x56EB80 VA: 0x180570180
	private bool IsLogLutValid(RenderTexture lut) { }

	// RVA: 0x56FD00 Offset: 0x56E700 VA: 0x18056FD00
	private RenderTextureFormat GetLutFormat() { }

	// RVA: 0x56E690 Offset: 0x56D090 VA: 0x18056E690
	private void GenerateLut() { }

	// RVA: 0x5704B0 Offset: 0x56EEB0 VA: 0x1805704B0 Slot: 10
	public override void Prepare(Material uberMaterial) { }

	// RVA: 0x570370 Offset: 0x56ED70 VA: 0x180570370
	public void OnGUI() { }

	// RVA: 0x5702E0 Offset: 0x56ECE0 VA: 0x1805702E0 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x570880 Offset: 0x56F280 VA: 0x180570880
	public void .ctor() { }
}
