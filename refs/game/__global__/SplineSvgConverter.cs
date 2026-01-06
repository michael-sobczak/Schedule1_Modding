public static class SplineSvgConverter // TypeDefIndex: 10579
{
	// Methods

	// RVA: 0x4EF3B0 Offset: 0x4EDDB0 VA: 0x1804EF3B0
	public static CurvySpline[] SvgToSplines(string svg, CurvySerializationSpace coordinatesSpace = 0) { }

	// RVA: 0x4EF240 Offset: 0x4EDC40 VA: 0x1804EF240
	public static CurvySpline SvgToSpline(string svg, CurvySerializationSpace coordinatesSpace = 0) { }

	// RVA: 0x4EEDD0 Offset: 0x4ED7D0 VA: 0x1804EEDD0
	public static List<SerializedCurvySpline> SvgToSerializedSplines(string svg, bool invertY = True) { }

	// RVA: 0x4EE4B0 Offset: 0x4ECEB0 VA: 0x1804EE4B0
	private static void DrawNode(SceneNode node, Matrix2D rootTransform, List<SerializedCurvySpline> splines) { }
}
