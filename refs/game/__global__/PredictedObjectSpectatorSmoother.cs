internal class PredictedObjectSpectatorSmoother // TypeDefIndex: 12687
{
	// Fields
	private PredictedObjectSpectatorSmoother.GoalData _currentGoalData; // 0x10
	private Transform _graphicalObject; // 0x18
	private bool _smoothPosition; // 0x20
	private bool _smoothRotation; // 0x21
	private uint _interpolation; // 0x24
	private List<PredictedObjectSpectatorSmoother.GoalData> _goalDatas; // 0x28
	private Rigidbody _rigidbody; // 0x30
	private Rigidbody2D _rigidbody2d; // 0x38
	private PredictedObjectSpectatorSmoother.TransformData _preTickTransformdata; // 0x40
	private RigidbodyType _rigidbodyType; // 0x48
	private long _reconcileLocalTick; // 0x50
	private bool _preTickReceived; // 0x58
	private Vector3 _graphicalStartPosition; // 0x5C
	private Quaternion _graphicalStartRotation; // 0x68
	private float _teleportThreshold; // 0x78
	private PredictedObject _predictedObject; // 0x80
	private static Stack<PredictedObjectSpectatorSmoother.GoalData> _goalDataCache; // 0x0
	private uint _localTick; // 0x88
	private uint _ignoredTicks; // 0x8C
	private Vector3 _startWorldPosition; // 0x90
	private const float OVERFLOW_MULTIPLIER = 0.1;
	private const float UNDERFLOW_MULTIPLIER = 0.02;

	// Methods

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void SetGraphicalObject(Transform value) { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void SetInterpolation(uint value) { }

	// RVA: 0xB1B4A0 Offset: 0xB19EA0 VA: 0x180B1B4A0
	public void SetIgnoredTicks(uint value) { }

	// RVA: 0xD4D2A0 Offset: 0xD4BCA0 VA: 0x180D4D2A0
	internal void Initialize(PredictedObject po, RigidbodyType rbType, Rigidbody rb, Rigidbody2D rb2d, Transform graphicalObject, bool smoothPosition, bool smoothRotation, float teleportThreshold) { }

	// RVA: 0xD4D360 Offset: 0xD4BD60 VA: 0x180D4D360
	public void ManualUpdate() { }

	// RVA: 0xD4DA30 Offset: 0xD4C430 VA: 0x180D4DA30
	public void OnPreTick() { }

	// RVA: 0xD4D880 Offset: 0xD4C280 VA: 0x180D4D880
	public void OnPostTick() { }

	// RVA: 0xD4D9F0 Offset: 0xD4C3F0 VA: 0x180D4D9F0
	public void OnPreReplay(uint tick) { }

	// RVA: 0xD4D7F0 Offset: 0xD4C1F0 VA: 0x180D4D7F0
	public void OnPostReplay(uint tick) { }

	// RVA: 0xD4C960 Offset: 0xD4B360 VA: 0x180D4C960
	private bool CanSmooth() { }

	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void SetLocalReconcileTick(long value) { }

	// RVA: 0xD4DE70 Offset: 0xD4C870 VA: 0x180D4DE70
	private void StoreGoalData(PredictedObjectSpectatorSmoother.GoalData gd) { }

	// RVA: 0xD4CF30 Offset: 0xD4B930 VA: 0x180D4CF30
	private bool GraphicalObjectMatches(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0xD4D1D0 Offset: 0xD4BBD0 VA: 0x180D4D1D0
	private bool HasChanged(PredictedObjectSpectatorSmoother.TransformData a, PredictedObjectSpectatorSmoother.TransformData b) { }

	// RVA: 0xD4D080 Offset: 0xD4BA80 VA: 0x180D4D080
	private bool HasChanged(PredictedObjectSpectatorSmoother.TransformData td) { }

	// RVA: 0xD4DCE0 Offset: 0xD4C6E0 VA: 0x180D4DCE0
	private void SetCurrentGoalData(bool afterMove) { }

	// RVA: 0xD4D3E0 Offset: 0xD4BDE0 VA: 0x180D4D3E0
	private void MoveToTarget(float deltaOverride = -1) { }

	// RVA: 0xD4DE40 Offset: 0xD4C840 VA: 0x180D4DE40
	private void SetInstantRates(PredictedObjectSpectatorSmoother.RateData rd) { }

	// RVA: 0xD42AD0 Offset: 0xD414D0 VA: 0x180D42AD0
	private void SetCalculatedRates(PredictedObjectSpectatorSmoother.GoalData prevGoalData, PredictedObjectSpectatorSmoother.GoalData nextGoalData, Channel channel) { }

	// RVA: 0xD4C9D0 Offset: 0xD4B3D0 VA: 0x180D4C9D0
	public void CreateGoalData(uint tick, bool postTick) { }

	// RVA: 0xD4CE60 Offset: 0xD4B860 VA: 0x180D4CE60
	private PredictedObjectSpectatorSmoother.GoalData GetGoalData(uint tick, out int index) { }

	// RVA: 0xD4DBF0 Offset: 0xD4C5F0 VA: 0x180D4DBF0
	private PredictedObjectSpectatorSmoother.GoalData RetrieveGoalData() { }

	// RVA: 0xD4E090 Offset: 0xD4CA90 VA: 0x180D4E090
	public void .ctor() { }

	// RVA: 0xD4E000 Offset: 0xD4CA00 VA: 0x180D4E000
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xD4DFA0 Offset: 0xD4C9A0 VA: 0x180D4DFA0
	private PredictedObjectSpectatorSmoother.GoalData <CreateGoalData>g__MakeGoalDataFromPreTickTransform|44_0() { }
}
