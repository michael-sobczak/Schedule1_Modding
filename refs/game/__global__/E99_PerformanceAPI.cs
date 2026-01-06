public class E99_PerformanceAPI : MonoBehaviour // TypeDefIndex: 10778
{
	// Fields
	private const int LOOPS = 20;
	private readonly List<string> mTests; // 0x20
	private readonly List<string> mTestResults; // 0x28
	private CurvyInterpolation mInterpolation; // 0x30
	private CurvyOrientation mOrientation; // 0x34
	private int mCacheSize; // 0x38
	private int mControlPointCount; // 0x3C
	private int mTotalSplineLength; // 0x40
	private bool mUseCache; // 0x44
	private bool mUseMultiThreads; // 0x45
	private int mCurrentTest; // 0x48
	private bool mExecuting; // 0x4C
	private readonly TimeMeasure Timer; // 0x50
	private MethodInfo mGUIMethod; // 0x58
	private MethodInfo mRunMethod; // 0x60
	private bool mInterpolate_UseDistance; // 0x68
	private int mRefresh_Mode; // 0x6C

	// Methods

	[UsedImplicitly]
	// RVA: 0x52DD10 Offset: 0x52C710 VA: 0x18052DD10
	private void Awake() { }

	[UsedImplicitly]
	// RVA: 0x52E040 Offset: 0x52CA40 VA: 0x18052E040
	private void OnGUI() { }

	[UsedImplicitly]
	// RVA: 0x52DE40 Offset: 0x52C840 VA: 0x18052DE40
	private void GUI_Interpolate() { }

	[UsedImplicitly]
	// RVA: 0x52ECD0 Offset: 0x52D6D0 VA: 0x18052ECD0
	private void Test_Interpolate() { }

	[UsedImplicitly]
	// RVA: 0x52DEE0 Offset: 0x52C8E0 VA: 0x18052DEE0
	private void GUI_Refresh() { }

	[UsedImplicitly]
	// RVA: 0x52F0E0 Offset: 0x52DAE0 VA: 0x18052F0E0
	private void Test_Refresh() { }

	// RVA: 0x52F520 Offset: 0x52DF20 VA: 0x18052F520
	private CurvySpline getSpline() { }

	// RVA: 0x52DB20 Offset: 0x52C520 VA: 0x18052DB20
	private void AddCPs(ref CurvySpline spline, int count, int totalLength) { }

	// RVA: 0x52F590 Offset: 0x52DF90 VA: 0x18052F590
	private void runTest() { }

	// RVA: 0x52F410 Offset: 0x52DE10 VA: 0x18052F410
	public void .ctor() { }
}
