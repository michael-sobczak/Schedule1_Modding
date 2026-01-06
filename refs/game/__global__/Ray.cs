public struct Ray : IFormattable // TypeDefIndex: 11627
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x777A40 Offset: 0x776440 VA: 0x180777A40
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3 get_origin() { }

	// RVA: 0x281FE90 Offset: 0x281E890 VA: 0x18281FE90
	public void set_origin(Vector3 value) { }

	// RVA: 0x2C80B20 Offset: 0x2C7F520 VA: 0x182C80B20
	public Vector3 get_direction() { }

	// RVA: 0x2C9B870 Offset: 0x2C9A270 VA: 0x182C9B870
	public void set_direction(Vector3 value) { }

	// RVA: 0x2C9B650 Offset: 0x2C9A050 VA: 0x182C9B650
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x2C9B6A0 Offset: 0x2C9A0A0 VA: 0x182C9B6A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C9B6B0 Offset: 0x2C9A0B0 VA: 0x182C9B6B0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
