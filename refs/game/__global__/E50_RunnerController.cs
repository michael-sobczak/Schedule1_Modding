public class E50_RunnerController : SplineController // TypeDefIndex: 10772
{
	// Fields
	[Section("Jump", True, False, 100)]
	public float JumpHeight; // 0x108
	public float JumpSpeed; // 0x10C
	public AnimationCurve JumpCurve; // 0x110
	public float Gravity; // 0x118
	private E50_RunnerController.GuideMode mMode; // 0x11C
	private float jumpHeight; // 0x120
	private float fallingSpeed; // 0x124
	private E50_SplineRefMetadata mPossibleSwitchTarget; // 0x128
	private int mSwitchInProgress; // 0x130

	// Methods

	// RVA: 0x52BED0 Offset: 0x52A8D0 VA: 0x18052BED0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x52B5A0 Offset: 0x529FA0 VA: 0x18052B5A0 Slot: 20
	protected override void InitializedApplyDeltaTime(float deltaTime) { }

	// RVA: 0x52BEF0 Offset: 0x52A8F0 VA: 0x18052BEF0
	private void Switch(int dir) { }

	[IteratorStateMachine(typeof(E50_RunnerController.<Jump>d__13))]
	// RVA: 0x52BD60 Offset: 0x52A760 VA: 0x18052BD60
	private IEnumerator Jump() { }

	// RVA: 0x52BDD0 Offset: 0x52A7D0 VA: 0x18052BDD0
	public void OnCPReached(CurvySplineMoveEventArgs e) { }

	// RVA: 0x52C140 Offset: 0x52AB40 VA: 0x18052C140
	public void UseFollowUpOrFall(CurvySplineMoveEventArgs e) { }

	// RVA: 0x52C3C0 Offset: 0x52ADC0 VA: 0x18052C3C0
	public void .ctor() { }
}
