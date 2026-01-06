public class Tile : TileBase // TypeDefIndex: 19038
{
	// Fields
	[SerializeField]
	private Sprite m_Sprite; // 0x18
	[SerializeField]
	private Color m_Color; // 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField]
	private TileFlags m_Flags; // 0x78
	[SerializeField]
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public Sprite get_sprite() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_sprite(Sprite value) { }

	// RVA: 0x2D8D0D0 Offset: 0x2D8BAD0 VA: 0x182D8D0D0
	public Color get_color() { }

	// RVA: 0x4976E0 Offset: 0x4960E0 VA: 0x1804976E0
	public void set_color(Color value) { }

	// RVA: 0x2D8D0E0 Offset: 0x2D8BAE0 VA: 0x182D8D0E0
	public Matrix4x4 get_transform() { }

	// RVA: 0x2D8D110 Offset: 0x2D8BB10 VA: 0x182D8D110
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x2D0E260 Offset: 0x2D0CC60 VA: 0x182D0E260
	public GameObject get_gameObject() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x2D00330 Offset: 0x2CFED30 VA: 0x182D00330
	public TileFlags get_flags() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	public void set_flags(TileFlags value) { }

	// RVA: 0x2D8D0C0 Offset: 0x2D8BAC0 VA: 0x182D8D0C0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0xD9EBC0 Offset: 0xD9D5C0 VA: 0x180D9EBC0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x2D8CEE0 Offset: 0x2D8B8E0 VA: 0x182D8CEE0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2D8D040 Offset: 0x2D8BA40 VA: 0x182D8D040
	public void .ctor() { }
}
