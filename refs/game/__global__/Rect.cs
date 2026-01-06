public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 11629
{
	// Fields
	[NativeName("x")]
	private float m_XMin; // 0x0
	[NativeName("y")]
	private float m_YMin; // 0x4
	[NativeName("width")]
	private float m_Width; // 0x8
	[NativeName("height")]
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x214CB60 Offset: 0x214B560 VA: 0x18214CB60
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x22D2A70 Offset: 0x22D1470 VA: 0x1822D2A70
	public void .ctor(Rect source) { }

	// RVA: 0x2C9CD80 Offset: 0x2C9B780 VA: 0x182C9CD80
	public static Rect get_zero() { }

	// RVA: 0x2C9C940 Offset: 0x2C9B340 VA: 0x182C9C940
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void Set(float x, float y, float width, float height) { }

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_x() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_x(float value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_y() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_y(float value) { }

	// RVA: 0x2C9B630 Offset: 0x2C9A030 VA: 0x182C9B630
	public Vector2 get_position() { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void set_position(Vector2 value) { }

	// RVA: 0x2C9CCF0 Offset: 0x2C9B6F0 VA: 0x182C9CCF0
	public Vector2 get_center() { }

	// RVA: 0x2C9CE20 Offset: 0x2C9B820 VA: 0x182C9CE20
	public void set_center(Vector2 value) { }

	// RVA: 0x2C9CD40 Offset: 0x2C9B740 VA: 0x182C9CD40
	public Vector2 get_min() { }

	// RVA: 0x2C9CE90 Offset: 0x2C9B890 VA: 0x182C9CE90
	public void set_min(Vector2 value) { }

	// RVA: 0x2C9CD20 Offset: 0x2C9B720 VA: 0x182C9CD20
	public Vector2 get_max() { }

	// RVA: 0x2C9CE60 Offset: 0x2C9B860 VA: 0x182C9CE60
	public void set_max(Vector2 value) { }

	// RVA: 0x454BA0 Offset: 0x4535A0 VA: 0x180454BA0
	public float get_width() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_width(float value) { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_height() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_height(float value) { }

	// RVA: 0x2C9B610 Offset: 0x2C9A010 VA: 0x182C9B610
	public Vector2 get_size() { }

	// RVA: 0x214CC60 Offset: 0x214B660 VA: 0x18214CC60
	public void set_size(Vector2 value) { }

	// RVA: 0x454BB0 Offset: 0x4535B0 VA: 0x180454BB0
	public float get_xMin() { }

	// RVA: 0x2C9CEE0 Offset: 0x2C9B8E0 VA: 0x182C9CEE0
	public void set_xMin(float value) { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_yMin() { }

	// RVA: 0x2C9CF10 Offset: 0x2C9B910 VA: 0x182C9CF10
	public void set_yMin(float value) { }

	// RVA: 0x2C9CD60 Offset: 0x2C9B760 VA: 0x182C9CD60
	public float get_xMax() { }

	// RVA: 0x2C9CED0 Offset: 0x2C9B8D0 VA: 0x182C9CED0
	public void set_xMax(float value) { }

	// RVA: 0x2C9CD70 Offset: 0x2C9B770 VA: 0x182C9CD70
	public float get_yMax() { }

	// RVA: 0x2C9CF00 Offset: 0x2C9B900 VA: 0x182C9CF00
	public void set_yMax(float value) { }

	// RVA: 0x454B50 Offset: 0x453550 VA: 0x180454B50
	public bool Contains(Vector2 point) { }

	// RVA: 0x2C9C680 Offset: 0x2C9B080 VA: 0x182C9C680
	public bool Contains(Vector3 point) { }

	// RVA: 0x2C9C980 Offset: 0x2C9B380 VA: 0x182C9C980
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x2C9C9F0 Offset: 0x2C9B3F0 VA: 0x182C9C9F0
	public bool Overlaps(Rect other) { }

	// RVA: 0x2BC0A70 Offset: 0x2BBF470 VA: 0x182BC0A70
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x2C9CDD0 Offset: 0x2C9B7D0 VA: 0x182C9CDD0
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x2C9CD90 Offset: 0x2C9B790 VA: 0x182C9CD90
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x2C9C8A0 Offset: 0x2C9B2A0 VA: 0x182C9C8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C9C6C0 Offset: 0x2C9B0C0 VA: 0x182C9C6C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2C9C7F0 Offset: 0x2C9B1F0 VA: 0x182C9C7F0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x2C9CA40 Offset: 0x2C9B440 VA: 0x182C9CA40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C9CA50 Offset: 0x2C9B450 VA: 0x182C9CA50 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
