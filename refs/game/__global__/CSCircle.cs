public class CSCircle : CurvyShape2D // TypeDefIndex: 10553
{
	// Fields
	private const int MinCount = 2;
	[Positive(MinValue = 2, Tooltip = "Number of Control Points")]
	[SerializeField]
	private int m_Count; // 0x48
	[SerializeField]
	[Positive]
	private float m_Radius; // 0x4C

	// Properties
	public int Count { get; set; }
	public float Radius { get; set; }

	// Methods

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Count() { }

	// RVA: 0x4C2EF0 Offset: 0x4C18F0 VA: 0x1804C2EF0
	public void set_Count(int value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_Radius() { }

	// RVA: 0x4C2F10 Offset: 0x4C1910 VA: 0x1804C2F10
	public void set_Radius(float value) { }

	// RVA: 0x4C2D50 Offset: 0x4C1750 VA: 0x1804C2D50 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C2ED0 Offset: 0x4C18D0 VA: 0x1804C2ED0
	public void .ctor() { }
}
