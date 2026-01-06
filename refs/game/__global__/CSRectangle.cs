public class CSRectangle : CurvyShape2D // TypeDefIndex: 10556
{
	// Fields
	[SerializeField]
	[Positive]
	private float m_Width; // 0x48
	[SerializeField]
	[Positive]
	private float m_Height; // 0x4C

	// Properties
	public float Width { get; set; }
	public float Height { get; set; }

	// Methods

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_Width() { }

	// RVA: 0x4C3DE0 Offset: 0x4C27E0 VA: 0x1804C3DE0
	public void set_Width(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_Height() { }

	// RVA: 0x4C2F10 Offset: 0x4C1910 VA: 0x1804C2F10
	public void set_Height(float value) { }

	// RVA: 0x4C3BD0 Offset: 0x4C25D0 VA: 0x1804C3BD0 Slot: 9
	protected override void ApplyShape() { }

	// RVA: 0x4C3DC0 Offset: 0x4C27C0 VA: 0x1804C3DC0
	public void .ctor() { }
}
