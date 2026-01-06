public class E99_PerformanceDynamicSpline : MonoBehaviour // TypeDefIndex: 10779
{
	// Fields
	private CurvySpline mSpline; // 0x20
	public CurvyGenerator Generator; // 0x28
	[Positive]
	public int UpdateInterval; // 0x30
	[RangeEx(2, 2000, "", "")]
	public int CPCount; // 0x34
	[Positive]
	public float Radius; // 0x38
	public bool AlwaysClear; // 0x3C
	public bool UpdateCG; // 0x3D
	private float mAngleStep; // 0x40
	private float mCurrentAngle; // 0x44
	private float mLastUpdateTime; // 0x48
	private readonly TimeMeasure ExecTimes; // 0x50

	// Methods

	[UsedImplicitly]
	// RVA: 0x52F5C0 Offset: 0x52DFC0 VA: 0x18052F5C0
	private void Awake() { }

	[UsedImplicitly]
	// RVA: 0x52FB50 Offset: 0x52E550 VA: 0x18052FB50
	private void Start() { }

	[UsedImplicitly]
	// RVA: 0x52FD50 Offset: 0x52E750 VA: 0x18052FD50
	private void Update() { }

	// RVA: 0x52FF40 Offset: 0x52E940 VA: 0x18052FF40
	private void addCP() { }

	[UsedImplicitly]
	// RVA: 0x52F610 Offset: 0x52E010 VA: 0x18052F610
	private void OnGUI() { }

	// RVA: 0x52FEB0 Offset: 0x52E8B0 VA: 0x18052FEB0
	public void .ctor() { }
}
