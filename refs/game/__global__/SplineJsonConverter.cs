public static class SplineJsonConverter // TypeDefIndex: 10578
{
	// Methods

	// RVA: 0x4D4380 Offset: 0x4D2D80 VA: 0x1804D4380
	public static string SplinesToJson(IEnumerable<CurvySpline> splines, CurvySerializationSpace coordinatesSpace = 0, bool prettify = True) { }

	// RVA: 0x4D41A0 Offset: 0x4D2BA0 VA: 0x1804D41A0
	public static string SplineToJson(CurvySpline spline, CurvySerializationSpace coordinatesSpace = 0, bool prettify = True) { }

	// RVA: 0x4D4060 Offset: 0x4D2A60 VA: 0x1804D4060
	public static CurvySpline[] JsonToSplines(string json, CurvySerializationSpace coordinatesSpace = 0) { }

	// RVA: 0x4D3EE0 Offset: 0x4D28E0 VA: 0x1804D3EE0
	public static CurvySpline JsonToSpline(string json, CurvySerializationSpace coordinatesSpace = 0) { }

	// RVA: 0x4D3AB0 Offset: 0x4D24B0 VA: 0x1804D3AB0
	public static SerializedCurvySpline[] JsonToSerializedSplines(string json) { }
}
