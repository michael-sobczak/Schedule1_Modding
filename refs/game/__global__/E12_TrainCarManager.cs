public class E12_TrainCarManager : MonoBehaviour // TypeDefIndex: 10760
{
	// Fields
	public SplineController Waggon; // 0x20
	public SplineController FrontAxis; // 0x28
	public SplineController BackAxis; // 0x30
	private E12_TrainManager mTrain; // 0x38

	// Properties
	public float Position { get; set; }

	// Methods

	// RVA: 0x529AD0 Offset: 0x5284D0 VA: 0x180529AD0
	public float get_Position() { }

	// RVA: 0x529BD0 Offset: 0x5285D0 VA: 0x180529BD0
	public void set_Position(float value) { }

	[UsedImplicitly]
	// RVA: 0x529830 Offset: 0x528230 VA: 0x180529830
	private void LateUpdate() { }

	// RVA: 0x529C80 Offset: 0x528680 VA: 0x180529C80
	public void setup() { }

	// RVA: 0x529AF0 Offset: 0x5284F0 VA: 0x180529AF0
	private void setController(SplineController c, CurvySpline spline, float speed) { }

	// RVA: 0x529A20 Offset: 0x528420 VA: 0x180529A20
	public void OnCPReached(CurvySplineMoveEventArgs e) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
