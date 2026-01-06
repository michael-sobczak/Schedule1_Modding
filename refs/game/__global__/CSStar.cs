public class CSStar : CurvyShape2D // TypeDefIndex: 10559
{
	// Fields
	private const int MinSides = 2;
	[SerializeField]
	[Positive(Tooltip = "Number of Sides", MinValue = 2)]
	private int m_Sides; // 0x48
	[Positive]
	[SerializeField]
	private float m_OuterRadius; // 0x4C
	[RangeEx(0, 1, "", "")]
	[SerializeField]
	private float m_OuterRoundness; // 0x50
	[SerializeField]
	[Positive]
	private float m_InnerRadius; // 0x54
	[RangeEx(0, 1, "", "")]
	[SerializeField]
	private float m_InnerRoundness; // 0x58

	// Properties
	public int Sides { get; set; }
	public float OuterRadius { get; set; }
	public float OuterRoundness { get; set; }
	public float InnerRadius { get; set; }
	public float InnerRoundness { get; set; }

	// Methods

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Sides() { }

	// RVA: 0x4C2EF0 Offset: 0x4C18F0 VA: 0x1804C2EF0
	public void set_Sides(int value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_OuterRadius() { }

	// RVA: 0x4C50C0 Offset: 0x4C3AC0 VA: 0x1804C50C0
	public void set_OuterRadius(float value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_OuterRoundness() { }

	// RVA: 0x4C3B90 Offset: 0x4C2590 VA: 0x1804C3B90
	public void set_OuterRoundness(float value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_InnerRadius() { }

	// RVA: 0x4C5060 Offset: 0x4C3A60 VA: 0x1804C5060
	public void set_InnerRadius(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_InnerRoundness() { }

	// RVA: 0x4C5080 Offset: 0x4C3A80 VA: 0x1804C5080
	public void set_InnerRoundness(float value) { }

	// RVA: 0x4C5000 Offset: 0x4C3A00 VA: 0x1804C5000 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4C4CA0 Offset: 0x4C36A0 VA: 0x1804C4CA0 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C5040 Offset: 0x4C3A40 VA: 0x1804C5040
	public void .ctor() { }
}
