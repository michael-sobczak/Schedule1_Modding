public sealed class Spline // TypeDefIndex: 17075
{
	// Fields
	public const int k_Precision = 128;
	public const float k_Step = 0.0078125;
	public AnimationCurve curve; // 0x10
	[SerializeField]
	private bool m_Loop; // 0x18
	[SerializeField]
	private float m_ZeroValue; // 0x1C
	[SerializeField]
	private float m_Range; // 0x20
	private AnimationCurve m_InternalLoopingCurve; // 0x28
	private int frameCount; // 0x30
	public float[] cachedData; // 0x38

	// Methods

	// RVA: 0x29C3C30 Offset: 0x29C2630 VA: 0x1829C3C30
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x29C3890 Offset: 0x29C2290 VA: 0x1829C3890
	public void Cache(int frame) { }

	// RVA: 0x29C3BC0 Offset: 0x29C25C0 VA: 0x1829C3BC0
	public float Evaluate(float t, int length) { }

	// RVA: 0x29C3B50 Offset: 0x29C2550 VA: 0x1829C3B50
	public float Evaluate(float t) { }

	// RVA: 0x29C3C00 Offset: 0x29C2600 VA: 0x1829C3C00 Slot: 2
	public override int GetHashCode() { }
}
