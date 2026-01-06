public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 11630
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public int xMin { get; }
	public int yMin { get; }
	public int xMax { get; }
	public int yMax { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_x() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_x(int value) { }

	// RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	public int get_y() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_y(int value) { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_width() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_width(int value) { }

	// RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	public int get_height() { }

	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_height(int value) { }

	// RVA: 0x2C9BBE0 Offset: 0x2C9A5E0 VA: 0x182C9BBE0
	public int get_xMin() { }

	// RVA: 0x2C9BCC0 Offset: 0x2C9A6C0 VA: 0x182C9BCC0
	public int get_yMin() { }

	// RVA: 0x2C9BB70 Offset: 0x2C9A570 VA: 0x182C9BB70
	public int get_xMax() { }

	// RVA: 0x2C9BC50 Offset: 0x2C9A650 VA: 0x182C9BC50
	public int get_yMax() { }

	// RVA: 0x1E0BAA0 Offset: 0x1E0A4A0 VA: 0x181E0BAA0
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x2C7D2C0 Offset: 0x2C7BCC0 VA: 0x182C7D2C0
	public bool Overlaps(RectInt other) { }

	// RVA: 0x2C9BB60 Offset: 0x2C9A560 VA: 0x182C9BB60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C9B8F0 Offset: 0x2C9A2F0 VA: 0x182C9B8F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2C9B8C0 Offset: 0x2C9A2C0 VA: 0x182C9B8C0 Slot: 4
	public bool Equals(RectInt other) { }
}
