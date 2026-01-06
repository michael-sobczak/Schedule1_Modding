internal struct Spacing // TypeDefIndex: 6765
{
	// Fields
	public float left; // 0x0
	public float top; // 0x4
	public float right; // 0x8
	public float bottom; // 0xC

	// Properties
	public float horizontal { get; }
	public float vertical { get; }

	// Methods

	// RVA: 0x2C9CD60 Offset: 0x2C9B760 VA: 0x182C9CD60
	public float get_horizontal() { }

	// RVA: 0x2C9CD70 Offset: 0x2C9B770 VA: 0x182C9CD70
	public float get_vertical() { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float left, float top, float right, float bottom) { }

	// RVA: 0x2EE1620 Offset: 0x2EE0020 VA: 0x182EE1620
	public static Rect op_Subtraction(Rect r, Spacing a) { }
}
