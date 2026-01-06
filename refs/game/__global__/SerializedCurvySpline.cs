public class SerializedCurvySpline // TypeDefIndex: 10575
{
	// Fields
	public string Name; // 0x10
	public Vector3 Position; // 0x18
	public Vector3 Rotation; // 0x24
	public CurvyInterpolation Interpolation; // 0x30
	public bool RestrictTo2D; // 0x34
	public bool Closed; // 0x35
	public bool AutoEndTangents; // 0x36
	public CurvyOrientation Orientation; // 0x38
	public float AutoHandleDistance; // 0x3C
	public int CacheDensity; // 0x40
	public float MaxPointsPerUnit; // 0x44
	public bool UsePooling; // 0x48
	public bool UseThreading; // 0x49
	public bool CheckTransform; // 0x4A
	public CurvyUpdateMethod UpdateIn; // 0x4C
	public bool IsBSplineClamped; // 0x50
	public int BSplineDegree; // 0x54
	public SerializedCurvySplineSegment[] ControlPoints; // 0x58

	// Methods

	// RVA: 0x4D2B60 Offset: 0x4D1560 VA: 0x1804D2B60
	public void .ctor() { }

	// RVA: 0x4D27D0 Offset: 0x4D11D0 VA: 0x1804D27D0
	public void .ctor(CurvySpline spline, CurvySerializationSpace space) { }

	// RVA: 0x4D24C0 Offset: 0x4D0EC0 VA: 0x1804D24C0
	public void WriteIntoSpline(CurvySpline deserializedSpline, CurvySerializationSpace space) { }
}
