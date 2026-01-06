public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 18681
{
	// Fields
	[NativeName("x")]
	[SerializeField]
	private int m_X; // 0x0
	[NativeName("y")]
	[SerializeField]
	private int m_Y; // 0x4
	[NativeName("width")]
	[SerializeField]
	private int m_Width; // 0x8
	[SerializeField]
	[NativeName("height")]
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_x() { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public int get_y() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_width() { }

	// RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	public int get_height() { }

	// RVA: 0x2D4AD10 Offset: 0x2D49710 VA: 0x182D4AD10
	public static GlyphRect get_zero() { }

	// RVA: 0x1E0BAA0 Offset: 0x1E0A4A0 VA: 0x181E0BAA0
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x2D4AC80 Offset: 0x2D49680 VA: 0x182D4AC80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D4AC20 Offset: 0x2D49620 VA: 0x182D4AC20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D4ABA0 Offset: 0x2D495A0 VA: 0x182D4ABA0 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x2D4ACD0 Offset: 0x2D496D0 VA: 0x182D4ACD0
	private static void .cctor() { }
}
