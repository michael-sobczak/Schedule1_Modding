public struct TileData // TypeDefIndex: 19046
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
	internal static readonly TileData Default; // 0x0

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x2D8CE30 Offset: 0x2D8B830 VA: 0x182D8CE30
	public void set_sprite(Sprite value) { }

	// RVA: 0x2BEE8E0 Offset: 0x2BED2E0 VA: 0x182BEE8E0
	public void set_color(Color value) { }

	// RVA: 0x2D8CEC0 Offset: 0x2D8B8C0 VA: 0x182D8CEC0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x2D8CDA0 Offset: 0x2D8B7A0 VA: 0x182D8CDA0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_flags(TileFlags value) { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x2D8CB30 Offset: 0x2D8B530 VA: 0x182D8CB30
	private static TileData CreateDefault() { }

	// RVA: 0x2D8CC60 Offset: 0x2D8B660 VA: 0x182D8CC60
	private static void .cctor() { }
}
