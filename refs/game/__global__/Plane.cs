public struct Plane : IFormattable // TypeDefIndex: 11626
{
	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3 get_normal() { }

	// RVA: 0x454B90 Offset: 0x453590 VA: 0x180454B90
	public float get_distance() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_distance(float value) { }

	// RVA: 0x580BE0 Offset: 0x57F5E0 VA: 0x180580BE0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x2C99950 Offset: 0x2C98350 VA: 0x182C99950
	public void .ctor(Vector3 inNormal, float d) { }

	// RVA: 0x2C999B0 Offset: 0x2C983B0 VA: 0x182C999B0
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x2C99730 Offset: 0x2C98130 VA: 0x182C99730
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x580AC0 Offset: 0x57F4C0 VA: 0x180580AC0
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x2C99940 Offset: 0x2C98340 VA: 0x182C99940 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C99780 Offset: 0x2C98180 VA: 0x182C99780 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
