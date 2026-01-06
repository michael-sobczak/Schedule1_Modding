public sealed class NavMeshObstacle : Behaviour // TypeDefIndex: 18860
{
	// Properties
	public float height { set; }
	public float radius { set; }
	public bool carving { get; set; }
	public bool carveOnlyStationary { set; }
	public NavMeshObstacleShape shape { set; }
	public Vector3 center { set; }
	public Vector3 size { set; }

	// Methods

	// RVA: 0x2C64030 Offset: 0x2C62A30 VA: 0x182C64030
	public void set_height(float value) { }

	// RVA: 0x2C64080 Offset: 0x2C62A80 VA: 0x182C64080
	public void set_radius(float value) { }

	// RVA: 0x2C63EB0 Offset: 0x2C628B0 VA: 0x182C63EB0
	public bool get_carving() { }

	// RVA: 0x2C63F40 Offset: 0x2C62940 VA: 0x182C63F40
	public void set_carving(bool value) { }

	// RVA: 0x2C63EF0 Offset: 0x2C628F0 VA: 0x182C63EF0
	public void set_carveOnlyStationary(bool value) { }

	// RVA: 0x2C640D0 Offset: 0x2C62AD0 VA: 0x182C640D0
	public void set_shape(NavMeshObstacleShape value) { }

	// RVA: 0x2C63FE0 Offset: 0x2C629E0 VA: 0x182C63FE0
	public void set_center(Vector3 value) { }

	[FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = True)]
	// RVA: 0x2C64160 Offset: 0x2C62B60 VA: 0x182C64160
	public void set_size(Vector3 value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C63F90 Offset: 0x2C62990 VA: 0x182C63F90
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x2C64110 Offset: 0x2C62B10 VA: 0x182C64110
	private void set_size_Injected(ref Vector3 value) { }
}
