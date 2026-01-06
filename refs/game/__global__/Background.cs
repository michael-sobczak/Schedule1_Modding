public struct Background : IEquatable<Background> // TypeDefIndex: 6769
{
	// Fields
	private Texture2D m_Texture; // 0x0
	private Sprite m_Sprite; // 0x8
	private RenderTexture m_RenderTexture; // 0x10
	private VectorImage m_VectorImage; // 0x18

	// Properties
	public Texture2D texture { get; set; }
	public Sprite sprite { get; set; }
	public RenderTexture renderTexture { get; set; }
	public VectorImage vectorImage { get; set; }

	// Methods

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public Texture2D get_texture() { }

	// RVA: 0x2ED2F40 Offset: 0x2ED1940 VA: 0x182ED2F40
	public void set_texture(Texture2D value) { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public Sprite get_sprite() { }

	// RVA: 0x2ED2E90 Offset: 0x2ED1890 VA: 0x182ED2E90
	public void set_sprite(Sprite value) { }

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public RenderTexture get_renderTexture() { }

	// RVA: 0x2ED2DE0 Offset: 0x2ED17E0 VA: 0x182ED2DE0
	public void set_renderTexture(RenderTexture value) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public VectorImage get_vectorImage() { }

	// RVA: 0x2ED2FF0 Offset: 0x2ED19F0 VA: 0x182ED2FF0
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x2ED2840 Offset: 0x2ED1240 VA: 0x182ED2840
	public static Background FromTexture2D(Texture2D t) { }

	// RVA: 0x2ED2680 Offset: 0x2ED1080 VA: 0x182ED2680
	public static Background FromRenderTexture(RenderTexture rt) { }

	// RVA: 0x2ED2760 Offset: 0x2ED1160 VA: 0x182ED2760
	public static Background FromSprite(Sprite s) { }

	// RVA: 0x2ED2920 Offset: 0x2ED1320 VA: 0x182ED2920
	public static Background FromVectorImage(VectorImage vi) { }

	// RVA: 0x2ED2240 Offset: 0x2ED0C40 VA: 0x182ED2240
	internal static Background FromObject(object obj) { }

	// RVA: 0x2ED2C00 Offset: 0x2ED1600 VA: 0x182ED2C00
	public static bool op_Equality(Background lhs, Background rhs) { }

	// RVA: 0x2ED2CF0 Offset: 0x2ED16F0 VA: 0x182ED2CF0
	public static bool op_Inequality(Background lhs, Background rhs) { }

	// RVA: 0x2ED2140 Offset: 0x2ED0B40 VA: 0x182ED2140 Slot: 4
	public bool Equals(Background other) { }

	// RVA: 0x2ED1FA0 Offset: 0x2ED09A0 VA: 0x182ED1FA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2ED2A00 Offset: 0x2ED1400 VA: 0x182ED2A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2ED2AD0 Offset: 0x2ED14D0 VA: 0x182ED2AD0 Slot: 3
	public override string ToString() { }
}
