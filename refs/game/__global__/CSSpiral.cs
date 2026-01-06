public class CSSpiral : CurvyShape2D // TypeDefIndex: 10558
{
	// Fields
	[Positive(Tooltip = "Number of Control Points per full Circle")]
	[SerializeField]
	private int m_Count; // 0x48
	[Positive(Tooltip = "Number of Full Circles")]
	[SerializeField]
	private float m_Circles; // 0x4C
	[SerializeField]
	[Positive(Tooltip = "Base Radius")]
	private float m_Radius; // 0x50
	[SerializeField]
	[Label(Tooltip = "Radius Multiplicator")]
	private AnimationCurve m_RadiusFactor; // 0x58
	[SerializeField]
	private AnimationCurve m_Z; // 0x60

	// Properties
	public int Count { get; set; }
	public float Circles { get; set; }
	public float Radius { get; set; }
	public AnimationCurve RadiusFactor { get; set; }
	public AnimationCurve Z { get; set; }

	// Methods

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Count() { }

	// RVA: 0x4C4C00 Offset: 0x4C3600 VA: 0x1804C4C00
	public void set_Count(int value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_Circles() { }

	// RVA: 0x4C2F10 Offset: 0x4C1910 VA: 0x1804C2F10
	public void set_Circles(float value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_Radius() { }

	// RVA: 0x4C4C50 Offset: 0x4C3650 VA: 0x1804C4C50
	public void set_Radius(float value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public AnimationCurve get_RadiusFactor() { }

	// RVA: 0x4C4C20 Offset: 0x4C3620 VA: 0x1804C4C20
	public void set_RadiusFactor(AnimationCurve value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public AnimationCurve get_Z() { }

	// RVA: 0x4C4C70 Offset: 0x4C3670 VA: 0x1804C4C70
	public void set_Z(AnimationCurve value) { }

	// RVA: 0x4C4960 Offset: 0x4C3360 VA: 0x1804C4960 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C4B50 Offset: 0x4C3550 VA: 0x1804C4B50
	public void .ctor() { }
}
