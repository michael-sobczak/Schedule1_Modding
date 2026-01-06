public class SplinePolyLine // TypeDefIndex: 10572
{
	// Fields
	public ContourOrientation Orientation; // 0x10
	public CurvySpline Spline; // 0x18
	public SplinePolyLine.VertexCalculation VertexMode; // 0x20
	public float Angle; // 0x24
	public float Distance; // 0x28
	public Space Space; // 0x2C

	// Properties
	public bool IsClosed { get; }

	// Methods

	// RVA: 0x4D4FD0 Offset: 0x4D39D0 VA: 0x1804D4FD0
	public void .ctor(CurvySpline spline) { }

	// RVA: 0x4D4EF0 Offset: 0x4D38F0 VA: 0x1804D4EF0
	public void .ctor(CurvySpline spline, float angle, float distance) { }

	// RVA: 0x4D4F60 Offset: 0x4D3960 VA: 0x1804D4F60
	private void .ctor(CurvySpline spline, SplinePolyLine.VertexCalculation vertexMode, float angle, float distance, Space space = 0) { }

	// RVA: 0x4D5010 Offset: 0x4D3A10 VA: 0x1804D5010
	public bool get_IsClosed() { }

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	[UsedImplicitly]
	// RVA: 0x4D4DA0 Offset: 0x4D37A0 VA: 0x1804D4DA0
	public Vector3[] GetVertices() { }

	// RVA: 0x4D4BA0 Offset: 0x4D35A0 VA: 0x1804D4BA0
	public SubArray<Vector3> GetVertexList() { }

	// RVA: 0x4D44D0 Offset: 0x4D2ED0 VA: 0x1804D44D0
	private static SubArrayList<Vector3> GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, bool includeEndPoint = True, float stepSize = 0.01) { }
}
