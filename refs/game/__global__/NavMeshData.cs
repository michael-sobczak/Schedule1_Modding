public sealed class NavMeshData : Object // TypeDefIndex: 18865
{
	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x2C63AC0 Offset: 0x2C624C0 VA: 0x182C63AC0
	public void .ctor() { }

	// RVA: 0x2C63B30 Offset: 0x2C62530 VA: 0x182C63B30
	public void .ctor(int agentTypeID) { }

	[StaticAccessor("NavMeshDataBindings", 2)]
	// RVA: 0x2C63A80 Offset: 0x2C62480 VA: 0x182C63A80
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x2C63C00 Offset: 0x2C62600 VA: 0x182C63C00
	public void set_position(Vector3 value) { }

	// RVA: 0x2C63CA0 Offset: 0x2C626A0 VA: 0x182C63CA0
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2C63BB0 Offset: 0x2C625B0 VA: 0x182C63BB0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2C63C50 Offset: 0x2C62650 VA: 0x182C63C50
	private void set_rotation_Injected(ref Quaternion value) { }
}
