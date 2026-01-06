public class E04_PaintSpline : MonoBehaviour // TypeDefIndex: 10751
{
	// Fields
	public float StepDistance; // 0x20
	public SplineController Controller; // 0x28
	public Text InfoText; // 0x30
	private CurvySpline mSpline; // 0x38
	private Vector2 mLastControlPointPos; // 0x40
	private bool mResetSpline; // 0x48

	// Methods

	[UsedImplicitly]
	// RVA: 0x528290 Offset: 0x526C90 VA: 0x180528290
	private void Awake() { }

	[UsedImplicitly]
	// RVA: 0x5282E0 Offset: 0x526CE0 VA: 0x1805282E0
	private void OnGUI() { }

	// RVA: 0x528580 Offset: 0x526F80 VA: 0x180528580
	private CurvySplineSegment addCP(Vector3 mousePos) { }

	// RVA: 0x528560 Offset: 0x526F60 VA: 0x180528560
	public void .ctor() { }
}
