internal struct VoxelPolygonClipper // TypeDefIndex: 13361
{
	// Fields
	public float[] x; // 0x0
	public float[] y; // 0x8
	public float[] z; // 0x10
	public int n; // 0x18

	// Properties
	public int Item { set; }

	// Methods

	// RVA: 0xBB7CC0 Offset: 0xBB66C0 VA: 0x180BB7CC0
	public void .ctor(int capacity) { }

	// RVA: 0xBB7D60 Offset: 0xBB6760 VA: 0x180BB7D60
	public void set_Item(int i, Vector3 value) { }

	// RVA: 0xBB7690 Offset: 0xBB6090 VA: 0x180BB7690
	public void ClipPolygonAlongX(ref VoxelPolygonClipper result, float multi, float offset) { }

	// RVA: 0xBB7910 Offset: 0xBB6310 VA: 0x180BB7910
	public void ClipPolygonAlongZWithYZ(ref VoxelPolygonClipper result, float multi, float offset) { }

	// RVA: 0xBB7B20 Offset: 0xBB6520 VA: 0x180BB7B20
	public void ClipPolygonAlongZWithY(ref VoxelPolygonClipper result, float multi, float offset) { }
}
