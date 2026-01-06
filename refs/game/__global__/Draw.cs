public class Draw // TypeDefIndex: 13384
{
	// Fields
	public static readonly Draw Debug; // 0x0
	public static readonly Draw Gizmos; // 0x8
	private bool gizmos; // 0x10
	private Matrix4x4 matrix; // 0x14

	// Methods

	// RVA: 0xBA2620 Offset: 0xBA1020 VA: 0x180BA2620
	private void SetColor(Color color) { }

	// RVA: 0xBA2490 Offset: 0xBA0E90 VA: 0x180BA2490
	public void Polyline(List<Vector3> points, Color color, bool cycle = False) { }

	// RVA: 0xBA2280 Offset: 0xBA0C80 VA: 0x180BA2280
	public void Line(Vector3 a, Vector3 b, Color color) { }

	// RVA: 0xBA1930 Offset: 0xBA0330 VA: 0x180BA1930
	public void CircleXZ(Vector3 center, float radius, Color color, float startAngle = 0, float endAngle = 6.2831855) { }

	// RVA: 0xBA1E80 Offset: 0xBA0880 VA: 0x180BA1E80
	public void Cylinder(Vector3 position, Vector3 up, float height, float radius, Color color) { }

	// RVA: 0xBA1BC0 Offset: 0xBA05C0 VA: 0x180BA1BC0
	public void CrossXZ(Vector3 position, Color color, float size = 1) { }

	// RVA: 0xBA1560 Offset: 0xB9FF60 VA: 0x180BA1560
	public void Bezier(Vector3 a, Vector3 b, Color color) { }

	// RVA: 0xBA2820 Offset: 0xBA1220 VA: 0x180BA2820
	public void .ctor() { }

	// RVA: 0xBA26D0 Offset: 0xBA10D0 VA: 0x180BA26D0
	private static void .cctor() { }
}
