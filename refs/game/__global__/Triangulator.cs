public class Triangulator // TypeDefIndex: 18798
{
	// Fields
	private List<Vector2> m_points; // 0x10

	// Properties
	public List<Vector2> Points { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<Vector2> get_Points() { }

	// RVA: 0x453210 Offset: 0x451C10 VA: 0x180453210
	public void .ctor(Vector2[] points) { }

	// RVA: 0x4532E0 Offset: 0x451CE0 VA: 0x1804532E0
	public void .ctor(Vector2[] points, bool invertY = True) { }

	// RVA: 0x452E00 Offset: 0x451800 VA: 0x180452E00
	public int[] Triangulate() { }

	// RVA: 0x452950 Offset: 0x451350 VA: 0x180452950
	private float Area() { }

	// RVA: 0x452B50 Offset: 0x451550 VA: 0x180452B50
	private bool Snip(int u, int v, int w, int n, int[] V) { }

	// RVA: 0x452A40 Offset: 0x451440 VA: 0x180452A40
	private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3) { }
}
