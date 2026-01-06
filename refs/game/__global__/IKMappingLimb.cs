public class IKMappingLimb : IKMapping // TypeDefIndex: 14101
{
	// Fields
	public Transform parentBone; // 0x10
	public Transform bone1; // 0x18
	public Transform bone2; // 0x20
	public Transform bone3; // 0x28
	[Range(0, 1)]
	public float maintainRotationWeight; // 0x30
	[Range(0, 1)]
	public float weight; // 0x34
	public bool updatePlaneRotations; // 0x38
	private IKMapping.BoneMap boneMapParent; // 0x40
	private IKMapping.BoneMap boneMap1; // 0x48
	private IKMapping.BoneMap boneMap2; // 0x50
	private IKMapping.BoneMap boneMap3; // 0x58

	// Methods

	// RVA: 0x1ED23D0 Offset: 0x1ED0DD0 VA: 0x181ED23D0 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x1ED1F40 Offset: 0x1ED0940 VA: 0x181ED1F40
	public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap) { }

	// RVA: 0x1ED2780 Offset: 0x1ED1180 VA: 0x181ED2780
	public void SetLimbOrientation(Vector3 upper, Vector3 lower) { }

	// RVA: 0x1ED30E0 Offset: 0x1ED1AE0 VA: 0x181ED30E0
	public void .ctor() { }

	// RVA: 0x1ED3270 Offset: 0x1ED1C70 VA: 0x181ED3270
	public void .ctor(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x1ED2710 Offset: 0x1ED1110 VA: 0x181ED2710
	public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x1ED2D00 Offset: 0x1ED1700 VA: 0x181ED2D00
	public void StoreDefaultLocalState() { }

	// RVA: 0x1ED1E00 Offset: 0x1ED0800 VA: 0x181ED1E00
	public void FixTransforms() { }

	// RVA: 0x1ED2010 Offset: 0x1ED0A10 VA: 0x181ED2010 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x1ED2610 Offset: 0x1ED1010 VA: 0x181ED2610
	public void ReadPose() { }

	// RVA: 0x1ED2EB0 Offset: 0x1ED18B0 VA: 0x181ED2EB0
	public void WritePose(IKSolverFullBody solver, bool fullBody) { }
}
