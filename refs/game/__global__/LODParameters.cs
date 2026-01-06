public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 12250
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private Vector3 m_CameraPosition; // 0x4
	private float m_FieldOfView; // 0x10
	private float m_OrthoSize; // 0x14
	private int m_CameraPixelHeight; // 0x18

	// Methods

	// RVA: 0x2CE1270 Offset: 0x2CDFC70 VA: 0x182CE1270 Slot: 4
	public bool Equals(LODParameters other) { }

	// RVA: 0x2CE1310 Offset: 0x2CDFD10 VA: 0x182CE1310 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CE13C0 Offset: 0x2CDFDC0 VA: 0x182CE13C0 Slot: 2
	public override int GetHashCode() { }
}
