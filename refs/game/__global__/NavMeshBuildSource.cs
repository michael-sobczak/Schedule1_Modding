public struct NavMeshBuildSource // TypeDefIndex: 18876
{
	// Fields
	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58
	private int m_GenerateLinks; // 0x5C

	// Properties
	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; }
	public Component component { get; }

	// Methods

	// RVA: 0x2C62DC0 Offset: 0x2C617C0 VA: 0x182C62DC0
	public Matrix4x4 get_transform() { }

	// RVA: 0x2C62DF0 Offset: 0x2C617F0 VA: 0x182C62DF0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x2C62D60 Offset: 0x2C61760 VA: 0x182C62D60
	public Vector3 get_size() { }

	// RVA: 0x79EE50 Offset: 0x79D850 VA: 0x18079EE50
	public void set_size(Vector3 value) { }

	// RVA: 0x2C62D50 Offset: 0x2C61750 VA: 0x182C62D50
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_area(int value) { }

	// RVA: 0x2C62D80 Offset: 0x2C61780 VA: 0x182C62D80
	public Object get_sourceObject() { }

	// RVA: 0x2C62D10 Offset: 0x2C61710 VA: 0x182C62D10
	public Component get_component() { }

	[StaticAccessor("NavMeshBuildSource", 2)]
	// RVA: 0x2C62C90 Offset: 0x2C61690 VA: 0x182C62C90
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessor("NavMeshBuildSource", 2)]
	// RVA: 0x2C62CD0 Offset: 0x2C616D0 VA: 0x182C62CD0
	private static Object InternalGetObject(int instanceID) { }
}
