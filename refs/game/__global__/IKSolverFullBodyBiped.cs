public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 14117
{
	// Fields
	public Transform rootNode; // 0xD0
	[Range(0, 1)]
	public float spineStiffness; // 0xD8
	[Range(-1, 1)]
	public float pullBodyVertical; // 0xDC
	[Range(-1, 1)]
	public float pullBodyHorizontal; // 0xE0
	[CompilerGenerated]
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x1EE2980 Offset: 0x1EE1380 VA: 0x181EE2980
	public IKEffector get_bodyEffector() { }

	// RVA: 0x1EE2AD0 Offset: 0x1EE14D0 VA: 0x181EE2AD0
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x1EE2C70 Offset: 0x1EE1670 VA: 0x181EE2C70
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x1EE2B00 Offset: 0x1EE1500 VA: 0x181EE2B00
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x1EE2CA0 Offset: 0x1EE16A0 VA: 0x181EE2CA0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x1EE2A40 Offset: 0x1EE1440 VA: 0x181EE2A40
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x1EE2BE0 Offset: 0x1EE15E0 VA: 0x181EE2BE0
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x1EE2A10 Offset: 0x1EE1410 VA: 0x181EE2A10
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x1EE2BB0 Offset: 0x1EE15B0 VA: 0x181EE2BB0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x1EE29B0 Offset: 0x1EE13B0 VA: 0x181EE29B0
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x1EE2B50 Offset: 0x1EE1550 VA: 0x181EE2B50
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x1EE2A70 Offset: 0x1EE1470 VA: 0x181EE2A70
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x1EE2C10 Offset: 0x1EE1610 VA: 0x181EE2C10
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x1EE29E0 Offset: 0x1EE13E0 VA: 0x181EE29E0
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x1EE2B80 Offset: 0x1EE1580 VA: 0x181EE2B80
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x1EE2AA0 Offset: 0x1EE14A0 VA: 0x181EE2AA0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x1EE2C40 Offset: 0x1EE1640 VA: 0x181EE2C40
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x1EDFB20 Offset: 0x1EDE520 VA: 0x181EDFB20
	public IKMappingBone get_headMapping() { }

	// RVA: 0x1EE0560 Offset: 0x1EDEF60 VA: 0x181EE0560
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x1EE05D0 Offset: 0x1EDEFD0 VA: 0x181EE05D0
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x1EDF560 Offset: 0x1EDDF60 VA: 0x181EDF560
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x1EDF5F0 Offset: 0x1EDDFF0 VA: 0x181EDF5F0
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x1EDF6E0 Offset: 0x1EDE0E0 VA: 0x181EDF6E0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x1EDF840 Offset: 0x1EDE240 VA: 0x181EDF840
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x1EDFC00 Offset: 0x1EDE600 VA: 0x181EDFC00
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x1EDFCA0 Offset: 0x1EDE6A0 VA: 0x181EDFCA0
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x1EDFB20 Offset: 0x1EDE520 VA: 0x181EDFB20
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x1EDF200 Offset: 0x1EDDC00 VA: 0x181EDF200
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x1EDFE40 Offset: 0x1EDE840 VA: 0x181EDFE40 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x1EE0990 Offset: 0x1EDF390 VA: 0x181EE0990
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x1EDEBA0 Offset: 0x1EDD5A0 VA: 0x181EDEBA0
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x1EE0920 Offset: 0x1EDF320 VA: 0x181EE0920
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGenerated]
	// RVA: 0x1EE2B30 Offset: 0x1EE1530 VA: 0x181EE2B30
	public Vector3 get_pullBodyOffset() { }

	[CompilerGenerated]
	// RVA: 0x1EE2CD0 Offset: 0x1EE16D0 VA: 0x181EE2CD0
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x1EE0690 Offset: 0x1EDF090 VA: 0x181EE0690
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x1EDFB50 Offset: 0x1EDE550 VA: 0x181EDFB50
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x1EDFD90 Offset: 0x1EDE790 VA: 0x181EDFD90
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x1EDEAE0 Offset: 0x1EDD4E0 VA: 0x181EDEAE0
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x1EE01F0 Offset: 0x1EDEBF0 VA: 0x181EE01F0 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x1EE0010 Offset: 0x1EDEA10 VA: 0x181EE0010
	private void PullBody() { }

	// RVA: 0x1EDF290 Offset: 0x1EDDC90 VA: 0x181EDF290
	private Vector3 GetBodyOffset() { }

	// RVA: 0x1EDF8D0 Offset: 0x1EDE2D0 VA: 0x181EDF8D0
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x1EDE6D0 Offset: 0x1EDD0D0 VA: 0x181EDE6D0 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x1EE2650 Offset: 0x1EE1050 VA: 0x181EE2650 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x1EE2830 Offset: 0x1EE1230 VA: 0x181EE2830
	public void .ctor() { }
}
