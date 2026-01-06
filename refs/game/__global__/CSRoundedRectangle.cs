public class CSRoundedRectangle : CurvyShape2D // TypeDefIndex: 10557
{
	// Fields
	[SerializeField]
	[Positive]
	private float m_Width; // 0x48
	[SerializeField]
	[Positive]
	private float m_Height; // 0x4C
	[Range(0, 1)]
	[SerializeField]
	private float m_Roundness; // 0x50

	// Properties
	public float Width { get; set; }
	public float Height { get; set; }
	public float Roundness { get; set; }

	// Methods

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_Width() { }

	// RVA: 0x4C3DE0 Offset: 0x4C27E0 VA: 0x1804C3DE0
	public void set_Width(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_Height() { }

	// RVA: 0x4C2F10 Offset: 0x4C1910 VA: 0x1804C2F10
	public void set_Height(float value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_Roundness() { }

	// RVA: 0x4C3B90 Offset: 0x4C2590 VA: 0x1804C3B90
	public void set_Roundness(float value) { }

	// RVA: 0x4C3E00 Offset: 0x4C2800 VA: 0x1804C3E00 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C4940 Offset: 0x4C3340 VA: 0x1804C4940
	public void .ctor() { }
}
