public class IKSolverHeuristic : IKSolver // TypeDefIndex: 14118
{
	// Fields
	public Transform target; // 0x58
	public float tolerance; // 0x60
	public int maxIterations; // 0x64
	public bool useRotationLimits; // 0x68
	public bool XY; // 0x69
	public IKSolver.Bone[] bones; // 0x70
	protected Vector3 lastLocalDirection; // 0x78
	protected float chainLength; // 0x84

	// Properties
	protected virtual int minBones { get; }
	protected virtual bool boneLengthCanBeZero { get; }
	protected virtual bool allowCommonParent { get; }
	protected virtual Vector3 localDirection { get; }
	protected float positionOffset { get; }

	// Methods

	// RVA: 0x1EED0B0 Offset: 0x1EEBAB0 VA: 0x181EED0B0
	public bool SetChain(Transform[] hierarchy, Transform root) { }

	// RVA: 0x1EEBF40 Offset: 0x1EEA940 VA: 0x181EEBF40
	public void AddBone(Transform bone) { }

	// RVA: 0x1EED520 Offset: 0x1EEBF20 VA: 0x181EED520 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x1EEC0E0 Offset: 0x1EEAAE0 VA: 0x181EEC0E0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x1EECC80 Offset: 0x1EEB680 VA: 0x181EECC80 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x1EEC170 Offset: 0x1EEAB70 VA: 0x181EEC170 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 12
	protected virtual int get_minBones() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	protected virtual bool get_boneLengthCanBeZero() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	protected virtual bool get_allowCommonParent() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x1EEC6B0 Offset: 0x1EEB0B0 VA: 0x181EEC6B0
	protected void InitiateBones() { }

	// RVA: 0x1EED600 Offset: 0x1EEC000 VA: 0x181EED600 Slot: 15
	protected virtual Vector3 get_localDirection() { }

	// RVA: 0x1EED760 Offset: 0x1EEC160 VA: 0x181EED760
	protected float get_positionOffset() { }

	// RVA: 0x1EEC270 Offset: 0x1EEAC70 VA: 0x181EEC270
	protected Vector3 GetSingularityOffset() { }

	// RVA: 0x1EED260 Offset: 0x1EEBC60 VA: 0x181EED260
	private bool SingularityDetected() { }

	// RVA: 0x1EED5A0 Offset: 0x1EEBFA0 VA: 0x181EED5A0
	public void .ctor() { }
}
