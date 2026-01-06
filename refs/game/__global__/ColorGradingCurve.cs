public sealed class ColorGradingCurve // TypeDefIndex: 219
{
	// Fields
	public AnimationCurve curve; // 0x10
	[SerializeField]
	private bool m_Loop; // 0x18
	[SerializeField]
	private float m_ZeroValue; // 0x1C
	[SerializeField]
	private float m_Range; // 0x20
	private AnimationCurve m_InternalLoopingCurve; // 0x28

	// Methods

	// RVA: 0x695BC0 Offset: 0x6945C0 VA: 0x180695BC0
	public void .ctor(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) { }

	// RVA: 0x695940 Offset: 0x694340 VA: 0x180695940
	public void Cache() { }

	// RVA: 0x695B40 Offset: 0x694540 VA: 0x180695B40
	public float Evaluate(float t) { }
}
