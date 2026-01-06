public class IKSolverLookAt : IKSolver // TypeDefIndex: 14124
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[Range(0, 1)]
	public float bodyWeight; // 0x78
	[Range(0, 1)]
	public float headWeight; // 0x7C
	[Range(0, 1)]
	public float eyesWeight; // 0x80
	[Range(0, 1)]
	public float clampWeight; // 0x84
	[Range(0, 1)]
	public float clampWeightHead; // 0x88
	[Range(0, 1)]
	public float clampWeightEyes; // 0x8C
	[Range(0, 2)]
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0
	private bool isDirty; // 0xC8

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x1EE5140 Offset: 0x1EE3B40 VA: 0x181EE5140
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x1EF1DB0 Offset: 0x1EF07B0 VA: 0x181EF1DB0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x1EF1EA0 Offset: 0x1EF08A0 VA: 0x181EF1EA0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x1EF1FE0 Offset: 0x1EF09E0 VA: 0x181EF1FE0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x1EF1DF0 Offset: 0x1EF07F0 VA: 0x181EF1DF0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1EF1F00 Offset: 0x1EF0900 VA: 0x181EF1F00
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x1EF2D70 Offset: 0x1EF1770 VA: 0x181EF2D70 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1EF1DA0 Offset: 0x1EF07A0 VA: 0x181EF1DA0
	public void SetDirty() { }

	// RVA: 0x1EF0A10 Offset: 0x1EEF410 VA: 0x181EF0A10 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EF1350 Offset: 0x1EEFD50 VA: 0x181EF1350 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EF1070 Offset: 0x1EEFA70 VA: 0x181EF1070 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EF0EF0 Offset: 0x1EEF8F0 VA: 0x181EF0EF0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x1EF1CD0 Offset: 0x1EF06D0 VA: 0x181EF1CD0
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x1EF1660 Offset: 0x1EF0060 VA: 0x181EF1660 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x1EF1A30 Offset: 0x1EF0430 VA: 0x181EF1A30 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EF32F0 Offset: 0x1EF1CF0 VA: 0x181EF32F0
	protected bool get_spineIsValid() { }

	// RVA: 0x1EF32D0 Offset: 0x1EF1CD0 VA: 0x181EF32D0
	protected bool get_spineIsEmpty() { }

	// RVA: 0x1EF2AB0 Offset: 0x1EF14B0 VA: 0x181EF2AB0
	protected void SolveSpine() { }

	// RVA: 0x1EF32C0 Offset: 0x1EF1CC0 VA: 0x181EF32C0
	protected bool get_headIsValid() { }

	// RVA: 0x1EF3260 Offset: 0x1EF1C60 VA: 0x181EF3260
	protected bool get_headIsEmpty() { }

	// RVA: 0x1EF2730 Offset: 0x1EF1130 VA: 0x181EF2730
	protected void SolveHead() { }

	// RVA: 0x1EF3180 Offset: 0x1EF1B80 VA: 0x181EF3180
	protected bool get_eyesIsValid() { }

	// RVA: 0x1EF3160 Offset: 0x1EF1B60 VA: 0x181EF3160
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x1EF2060 Offset: 0x1EF0A60 VA: 0x181EF2060
	protected void SolveEyes() { }

	// RVA: 0x1EF0BA0 Offset: 0x1EEF5A0 VA: 0x181EF0BA0
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x1EF1B10 Offset: 0x1EF0510 VA: 0x181EF1B10
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x1EF2ED0 Offset: 0x1EF18D0 VA: 0x181EF2ED0
	public void .ctor() { }
}
