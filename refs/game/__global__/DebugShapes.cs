public class DebugShapes // TypeDefIndex: 13638
{
	// Fields
	private static DebugShapes s_Instance; // 0x0
	private Mesh m_sphereMesh; // 0x10
	private Mesh m_boxMesh; // 0x18
	private Mesh m_coneMesh; // 0x20
	private Mesh m_pyramidMesh; // 0x28

	// Properties
	public static DebugShapes instance { get; }

	// Methods

	// RVA: 0x29F1F10 Offset: 0x29F0910 VA: 0x1829F1F10
	public static DebugShapes get_instance() { }

	// RVA: 0x29F12D0 Offset: 0x29EFCD0 VA: 0x1829F12D0
	private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) { }

	// RVA: 0x29EF580 Offset: 0x29EDF80 VA: 0x1829EF580
	private void BuildBox(ref Mesh outputMesh, float length, float width, float height) { }

	// RVA: 0x29F0240 Offset: 0x29EEC40 VA: 0x1829F0240
	private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) { }

	// RVA: 0x29F0CD0 Offset: 0x29EF6D0 VA: 0x1829F0CD0
	private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) { }

	// RVA: 0x29F1150 Offset: 0x29EFB50 VA: 0x1829F1150
	private void BuildShapes() { }

	// RVA: 0x29F1C40 Offset: 0x29F0640 VA: 0x1829F1C40
	private void RebuildResources() { }

	// RVA: 0x29F1EF0 Offset: 0x29F08F0 VA: 0x1829F1EF0
	public Mesh RequestSphereMesh() { }

	// RVA: 0x29F1E90 Offset: 0x29F0890 VA: 0x1829F1E90
	public Mesh RequestBoxMesh() { }

	// RVA: 0x29F1EB0 Offset: 0x29F08B0 VA: 0x1829F1EB0
	public Mesh RequestConeMesh() { }

	// RVA: 0x29F1ED0 Offset: 0x29F08D0 VA: 0x1829F1ED0
	public Mesh RequestPyramidMesh() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
