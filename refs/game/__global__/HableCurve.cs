public class HableCurve // TypeDefIndex: 17063
{
	// Fields
	[CompilerGenerated]
	private float <whitePoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <inverseWhitePoint>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <x0>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <x1>k__BackingField; // 0x1C
	private readonly HableCurve.Segment[] m_Segments; // 0x20
	public readonly HableCurve.Uniforms uniforms; // 0x28

	// Properties
	public float whitePoint { get; set; }
	public float inverseWhitePoint { get; set; }
	internal float x0 { get; set; }
	internal float x1 { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_whitePoint() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	private void set_whitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_inverseWhitePoint() { }

	[CompilerGenerated]
	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	private void set_inverseWhitePoint(float value) { }

	[CompilerGenerated]
	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70
	internal float get_x0() { }

	[CompilerGenerated]
	// RVA: 0x61B4E0 Offset: 0x619EE0 VA: 0x18061B4E0
	private void set_x0(float value) { }

	[CompilerGenerated]
	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	internal float get_x1() { }

	[CompilerGenerated]
	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	private void set_x1(float value) { }

	// RVA: 0x29AABB0 Offset: 0x29A95B0 VA: 0x1829AABB0
	public void .ctor() { }

	// RVA: 0x29AA320 Offset: 0x29A8D20 VA: 0x1829AA320
	public float Eval(float x) { }

	// RVA: 0x29AA900 Offset: 0x29A9300 VA: 0x1829AA900
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	// RVA: 0x29AA3C0 Offset: 0x29A8DC0 VA: 0x1829AA3C0
	private void InitSegments(HableCurve.DirectParams srcParams) { }

	// RVA: 0x29AAB40 Offset: 0x29A9540 VA: 0x1829AAB40
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

	// RVA: 0x29AA270 Offset: 0x29A8C70 VA: 0x1829AA270
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	// RVA: 0x29AA2D0 Offset: 0x29A8CD0 VA: 0x1829AA2D0
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }
}
