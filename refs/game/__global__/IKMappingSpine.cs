public class IKMappingSpine : IKMapping // TypeDefIndex: 14102
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[Range(1, 3)]
	public int iterations; // 0x38
	[Range(0, 1)]
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x1ED4230 Offset: 0x1ED2C30 VA: 0x181ED4230 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x1ED56E0 Offset: 0x1ED40E0 VA: 0x181ED56E0
	public void .ctor() { }

	// RVA: 0x1ED54A0 Offset: 0x1ED3EA0 VA: 0x181ED54A0
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x1ED4E80 Offset: 0x1ED3880 VA: 0x181ED4E80
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x1ED4F00 Offset: 0x1ED3900 VA: 0x181ED4F00
	public void StoreDefaultLocalState() { }

	// RVA: 0x1ED3610 Offset: 0x1ED2010 VA: 0x181ED3610
	public void FixTransforms() { }

	// RVA: 0x1ED3860 Offset: 0x1ED2260 VA: 0x181ED3860 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ED4FD0 Offset: 0x1ED39D0 VA: 0x181ED4FD0
	private bool UseFABRIK() { }

	// RVA: 0x1ED4AA0 Offset: 0x1ED34A0 VA: 0x181ED4AA0
	public void ReadPose() { }

	// RVA: 0x1ED5000 Offset: 0x1ED3A00 VA: 0x181ED5000
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x1ED36A0 Offset: 0x1ED20A0 VA: 0x181ED36A0
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x1ED3470 Offset: 0x1ED1E70 VA: 0x181ED3470
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x1ED4630 Offset: 0x1ED3030 VA: 0x181ED4630
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}
