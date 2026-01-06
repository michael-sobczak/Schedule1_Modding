public struct FloatRange2D // TypeDefIndex: 18197
{
	// Fields
	public FloatRange X; // 0x0
	public FloatRange Y; // 0x8

	// Methods

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(FloatRange x, FloatRange y) { }

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float xMin, float xMax, float yMin, float yMax) { }

	// RVA: 0xDA4600 Offset: 0xDA3000 VA: 0x180DA4600
	public Vector2 Clamp(Vector2 original) { }

	// RVA: 0xDA4650 Offset: 0xDA3050 VA: 0x180DA4650
	public Vector3 Clamp(Vector3 original) { }

	// RVA: 0xDA45C0 Offset: 0xDA2FC0 VA: 0x180DA45C0
	public float ClampX(float original) { }

	// RVA: 0xDA45E0 Offset: 0xDA2FE0 VA: 0x180DA45E0
	public float ClampY(float original) { }
}
