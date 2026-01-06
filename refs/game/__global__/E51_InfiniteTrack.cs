public class E51_InfiniteTrack : MonoBehaviour // TypeDefIndex: 10775
{
	// Fields
	public CurvySpline TrackSpline; // 0x20
	public CurvyController Controller; // 0x28
	public Material RoadMaterial; // 0x30
	public Text TxtStats; // 0x38
	[Positive]
	public float CurvationX; // 0x40
	[Positive]
	public float CurvationY; // 0x44
	[Positive]
	public float CPStepSize; // 0x48
	[Positive]
	public int HeadCP; // 0x4C
	[Positive]
	public int TailCP; // 0x50
	[Min(3, "", "")]
	public int Sections; // 0x54
	[Min(1, "", "")]
	public int SectionCPCount; // 0x58
	private int mInitState; // 0x5C
	private bool mUpdateSpline; // 0x60
	private int mUpdateIn; // 0x64
	private CurvyGenerator[] mGenerators; // 0x68
	private int mCurrentGen; // 0x70
	private float lastSectionEndV; // 0x74
	private Vector3 mDir; // 0x78
	private readonly TimeMeasure timeSpline; // 0x88
	private readonly TimeMeasure timeCG; // 0x90

	// Methods

	[UsedImplicitly]
	// RVA: 0x52C490 Offset: 0x52AE90 VA: 0x18052C490
	private void Start() { }

	[UsedImplicitly]
	// RVA: 0x52C430 Offset: 0x52AE30 VA: 0x18052C430
	private void FixedUpdate() { }

	[IteratorStateMachine(typeof(E51_InfiniteTrack.<setup>d__22))]
	// RVA: 0x52CFA0 Offset: 0x52B9A0 VA: 0x18052CFA0
	private IEnumerator setup() { }

	// RVA: 0x52CB40 Offset: 0x52B540 VA: 0x18052CB40
	private CurvyGenerator buildGenerator() { }

	// RVA: 0x52C950 Offset: 0x52B350 VA: 0x18052C950
	private void advanceTrack() { }

	// RVA: 0x52C8C0 Offset: 0x52B2C0 VA: 0x18052C8C0
	private void advanceSections() { }

	// RVA: 0x52D330 Offset: 0x52BD30 VA: 0x18052D330
	private void updateStats() { }

	// RVA: 0x52D010 Offset: 0x52BA10 VA: 0x18052D010
	private void updateSectionGenerator(CurvyGenerator gen, int startCP, int endCP) { }

	// RVA: 0x52C4A0 Offset: 0x52AEA0 VA: 0x18052C4A0
	public void Track_OnControlPointReached(CurvySplineMoveEventArgs e) { }

	// RVA: 0x52C5A0 Offset: 0x52AFA0 VA: 0x18052C5A0
	private void addTrackCP() { }

	// RVA: 0x52C4C0 Offset: 0x52AEC0 VA: 0x18052C4C0
	public void .ctor() { }
}
