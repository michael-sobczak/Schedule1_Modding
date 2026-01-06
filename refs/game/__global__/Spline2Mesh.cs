public class Spline2Mesh // TypeDefIndex: 10569
{
	// Fields
	public List<SplinePolyLine> Lines; // 0x10
	public WindingRule Winding; // 0x18
	public Vector2 UVTiling; // 0x1C
	public Vector2 UVOffset; // 0x24
	public bool SuppressUVMapping; // 0x2C
	public bool UV2; // 0x2D
	public string MeshName; // 0x30
	public bool VertexLineOnly; // 0x38
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x40
	private Tess mTess; // 0x48
	private Mesh mMesh; // 0x50

	// Properties
	public string Error { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_Error(string value) { }

	// RVA: 0x4D2C30 Offset: 0x4D1630 VA: 0x1804D2C30
	public bool Apply(out Mesh result) { }

	// RVA: 0x4D36B0 Offset: 0x4D20B0 VA: 0x1804D36B0
	private bool triangulate() { }

	// RVA: 0x4D3660 Offset: 0x4D2060 VA: 0x1804D3660
	private static bool polyLineIsValid(SplinePolyLine pl) { }

	// RVA: 0x4D3540 Offset: 0x4D1F40 VA: 0x1804D3540
	public void .ctor() { }
}
