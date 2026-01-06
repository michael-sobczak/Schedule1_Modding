public class GraphUpdateShape // TypeDefIndex: 13154
{
	// Fields
	private Vector3[] _points; // 0x10
	private Vector3[] _convexPoints; // 0x18
	private bool _convex; // 0x20
	private Vector3 right; // 0x24
	private Vector3 forward; // 0x30
	private Vector3 up; // 0x3C
	private Vector3 origin; // 0x48
	public float minimumHeight; // 0x54

	// Properties
	public Vector3[] points { get; set; }
	public bool convex { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Vector3[] get_points() { }

	// RVA: 0xB0E880 Offset: 0xB0D280 VA: 0x180B0E880
	public void set_points(Vector3[] value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_convex() { }

	// RVA: 0xB0E830 Offset: 0xB0D230 VA: 0x180B0E830
	public void set_convex(bool value) { }

	// RVA: 0xB0E410 Offset: 0xB0CE10 VA: 0x180B0E410
	public void .ctor() { }

	// RVA: 0xB0E4E0 Offset: 0xB0CEE0 VA: 0x180B0E4E0
	public void .ctor(Vector3[] points, bool convex, Matrix4x4 matrix, float minimumHeight) { }

	// RVA: 0xB0D870 Offset: 0xB0C270 VA: 0x180B0D870
	private void CalculateConvexHull() { }

	// RVA: 0xB0DC40 Offset: 0xB0C640 VA: 0x180B0DC40
	public Bounds GetBounds() { }

	// RVA: 0xB0DD10 Offset: 0xB0C710 VA: 0x180B0DD10
	public static Bounds GetBounds(Vector3[] points, Matrix4x4 matrix, float minimumHeight) { }

	// RVA: 0xB0E010 Offset: 0xB0CA10 VA: 0x180B0E010
	private static Bounds GetBounds(Vector3[] points, Vector3 right, Vector3 up, Vector3 forward, Vector3 origin, float minimumHeight) { }

	// RVA: 0xB0DBE0 Offset: 0xB0C5E0 VA: 0x180B0DBE0
	public bool Contains(GraphNode node) { }

	// RVA: 0xB0D8F0 Offset: 0xB0C2F0 VA: 0x180B0D8F0
	public bool Contains(Vector3 point) { }
}
