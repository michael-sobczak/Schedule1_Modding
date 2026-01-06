public class CurvyControlPointEventArgs : CurvySplineEventArgs // TypeDefIndex: 10526
{
	// Fields
	public readonly CurvyControlPointEventArgs.ModeEnum Mode; // 0x28
	public readonly CurvySplineSegment ControlPoint; // 0x30

	// Methods

	// RVA: 0x4A36A0 Offset: 0x4A20A0 VA: 0x1804A36A0
	public void .ctor(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, CurvyControlPointEventArgs.ModeEnum mode = 0, object data) { }
}
