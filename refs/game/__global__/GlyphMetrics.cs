public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 18682
{
	// Fields
	[NativeName("width")]
	[SerializeField]
	private float m_Width; // 0x0
	[SerializeField]
	[NativeName("height")]
	private float m_Height; // 0x4
	[NativeName("horizontalBearingX")]
	[SerializeField]
	private float m_HorizontalBearingX; // 0x8
	[SerializeField]
	[NativeName("horizontalBearingY")]
	private float m_HorizontalBearingY; // 0xC
	[NativeName("horizontalAdvance")]
	[SerializeField]
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_width() { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_height() { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_horizontalBearingX() { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_horizontalBearingY() { }

	// RVA: 0x2C72C80 Offset: 0x2C71680 VA: 0x182C72C80
	public float get_horizontalAdvance() { }

	// RVA: 0x2D4A980 Offset: 0x2D49380 VA: 0x182D4A980
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x2D4A920 Offset: 0x2D49320 VA: 0x182D4A920 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D4A8B0 Offset: 0x2D492B0 VA: 0x182D4A8B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D4A820 Offset: 0x2D49220 VA: 0x182D4A820 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}
