public class IKMappingBone : IKMapping // TypeDefIndex: 14099
{
	// Fields
	public Transform bone; // 0x10
	[Range(0, 1)]
	public float maintainRotationWeight; // 0x18
	private IKMapping.BoneMap boneMap; // 0x20

	// Methods

	// RVA: 0x1ED1B30 Offset: 0x1ED0530 VA: 0x181ED1B30 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x1ED1CA0 Offset: 0x1ED06A0 VA: 0x181ED1CA0
	public void .ctor() { }

	// RVA: 0x1ED1D40 Offset: 0x1ED0740 VA: 0x181ED1D40
	public void .ctor(Transform bone) { }

	// RVA: 0x1ED1C10 Offset: 0x1ED0610 VA: 0x181ED1C10
	public void StoreDefaultLocalState() { }

	// RVA: 0x1ED1A10 Offset: 0x1ED0410 VA: 0x181ED1A10
	public void FixTransforms() { }

	// RVA: 0x1ED1A50 Offset: 0x1ED0450 VA: 0x181ED1A50 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ED1BD0 Offset: 0x1ED05D0 VA: 0x181ED1BD0
	public void ReadPose() { }

	// RVA: 0x1ED1C70 Offset: 0x1ED0670 VA: 0x181ED1C70
	public void WritePose(float solverWeight) { }
}
