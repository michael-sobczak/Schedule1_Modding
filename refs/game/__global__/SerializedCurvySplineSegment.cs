public class SerializedCurvySplineSegment // TypeDefIndex: 10576
{
	// Fields
	public Vector3 Position; // 0x10
	public Vector3 Rotation; // 0x1C
	public bool AutoBakeOrientation; // 0x28
	public bool OrientationAnchor; // 0x29
	public CurvyOrientationSwirl Swirl; // 0x2C
	public float SwirlTurns; // 0x30
	public bool AutoHandles; // 0x34
	public bool SynchronizeTCB; // 0x35
	public float AutoHandleDistance; // 0x38
	public Vector3 HandleOut; // 0x3C
	public Vector3 HandleIn; // 0x48

	// Methods

	// RVA: 0x4D2250 Offset: 0x4D0C50 VA: 0x1804D2250
	public void .ctor() { }

	// RVA: 0x4D22F0 Offset: 0x4D0CF0 VA: 0x1804D22F0
	public void .ctor(CurvySplineSegment segment, CurvySerializationSpace space) { }

	// RVA: 0x4D1E40 Offset: 0x4D0840 VA: 0x1804D1E40
	public void WriteIntoControlPoint(CurvySplineSegment controlPoint, CurvySerializationSpace space) { }
}
