public struct CinemachineBlendDefinition // TypeDefIndex: 16130
{
	// Fields
	[Tooltip("Shape of the blend curve")]
	public CinemachineBlendDefinition.Style m_Style; // 0x0
	[Tooltip("Duration of the blend, in seconds")]
	public float m_Time; // 0x4
	public AnimationCurve m_CustomCurve; // 0x8
	private static AnimationCurve[] sStandardCurves; // 0x0

	// Properties
	public float BlendTime { get; }
	public AnimationCurve BlendCurve { get; }

	// Methods

	// RVA: 0xC15AD0 Offset: 0xC144D0 VA: 0x180C15AD0
	public float get_BlendTime() { }

	// RVA: 0xC159F0 Offset: 0xC143F0 VA: 0x180C159F0
	public void .ctor(CinemachineBlendDefinition.Style style, float time) { }

	// RVA: 0xC15360 Offset: 0xC13D60 VA: 0x180C15360
	private void CreateStandardCurves() { }

	// RVA: 0xC15A10 Offset: 0xC14410 VA: 0x180C15A10
	public AnimationCurve get_BlendCurve() { }
}
