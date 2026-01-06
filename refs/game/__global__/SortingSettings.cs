public struct SortingSettings : IEquatable<SortingSettings> // TypeDefIndex: 12274
{
	// Fields
	private Matrix4x4 m_WorldToCameraMatrix; // 0x0
	private Vector3 m_CameraPosition; // 0x40
	private Vector3 m_CustomAxis; // 0x4C
	private SortingCriteria m_Criteria; // 0x58
	private DistanceMetric m_DistanceMetric; // 0x5C

	// Properties
	public Vector3 customAxis { set; }
	public SortingCriteria criteria { get; set; }
	public DistanceMetric distanceMetric { set; }

	// Methods

	// RVA: 0x2CFDDC0 Offset: 0x2CFC7C0 VA: 0x182CFDDC0
	public void .ctor(Camera camera) { }

	// RVA: 0x4D6530 Offset: 0x4D4F30 VA: 0x1804D6530
	public void set_customAxis(Vector3 value) { }

	// RVA: 0x2CFDE40 Offset: 0x2CFC840 VA: 0x182CFDE40
	public SortingCriteria get_criteria() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_criteria(SortingCriteria value) { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	public void set_distanceMetric(DistanceMetric value) { }

	// RVA: 0x2CFDB20 Offset: 0x2CFC520 VA: 0x182CFDB20 Slot: 4
	public bool Equals(SortingSettings other) { }

	// RVA: 0x2CFDC10 Offset: 0x2CFC610 VA: 0x182CFDC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFDCF0 Offset: 0x2CFC6F0 VA: 0x182CFDCF0 Slot: 2
	public override int GetHashCode() { }
}
