public struct Ray2D : IFormattable // TypeDefIndex: 11628
{
	// Fields
	private Vector2 m_Origin; // 0x0
	private Vector2 m_Direction; // 0x8

	// Properties
	public Vector2 origin { get; }
	public Vector2 direction { get; }

	// Methods

	// RVA: 0x2C9B5D0 Offset: 0x2C99FD0 VA: 0x182C9B5D0
	public void .ctor(Vector2 origin, Vector2 direction) { }

	// RVA: 0x2C9B630 Offset: 0x2C9A030 VA: 0x182C9B630
	public Vector2 get_origin() { }

	// RVA: 0x2C9B610 Offset: 0x2C9A010 VA: 0x182C9B610
	public Vector2 get_direction() { }

	// RVA: 0x2C9B400 Offset: 0x2C99E00 VA: 0x182C9B400 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C9B410 Offset: 0x2C99E10 VA: 0x182C9B410 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
