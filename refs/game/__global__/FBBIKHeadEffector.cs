public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 14091
{
	// Fields
	[Tooltip("Reference to the FBBIK component.")]
	public FullBodyBipedIK ik; // 0x20
	[LargeHeader("Position")]
	[Range(0, 1)]
	[Tooltip("Master weight for positioning the head.")]
	public float positionWeight; // 0x28
	[Range(0, 1)]
	[Tooltip("The weight of moving the body along with the head")]
	public float bodyWeight; // 0x2C
	[Tooltip("The weight of moving the thighs along with the head")]
	[Range(0, 1)]
	public float thighWeight; // 0x30
	[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
	public bool handsPullBody; // 0x34
	[LargeHeader("Rotation")]
	[Tooltip("The weight of rotating the head bone after solving")]
	[Range(0, 1)]
	public float rotationWeight; // 0x38
	[Tooltip("Clamping the rotation of the body")]
	[Range(0, 1)]
	public float bodyClampWeight; // 0x3C
	[Range(0, 1)]
	[Tooltip("Clamping the rotation of the head")]
	public float headClampWeight; // 0x40
	[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
	[Range(0, 1)]
	public float bendWeight; // 0x44
	[Tooltip("The bones to use for bending.")]
	public FBBIKHeadEffector.BendBone[] bendBones; // 0x48
	[LargeHeader("CCD")]
	[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
	[Range(0, 1)]
	public float CCDWeight; // 0x50
	[Tooltip("The weight of rolling the bones in towards the target")]
	[Range(0, 1)]
	public float roll; // 0x54
	[Range(0, 1000)]
	[Tooltip("Smoothing the CCD effect.")]
	public float damper; // 0x58
	[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
	public Transform[] CCDBones; // 0x60
	[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
	[LargeHeader("Stretching")]
	[Range(0, 1)]
	public float postStretchWeight; // 0x68
	[Tooltip("Stretch magnitude limit.")]
	public float maxStretch; // 0x6C
	[Tooltip("If > 0, dampers the stretching effect.")]
	public float stretchDamper; // 0x70
	[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
	public bool fixHead; // 0x74
	[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
	public Transform[] stretchBones; // 0x78
	[LargeHeader("Chest Direction")]
	public Vector3 chestDirection; // 0x80
	[Range(0, 1)]
	public float chestDirectionWeight; // 0x8C
	public Transform[] chestBones; // 0x90
	public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x98
	private Vector3 offset; // 0xA0
	private Vector3 headToBody; // 0xAC
	private Vector3 shoulderCenterToHead; // 0xB8
	private Vector3 headToLeftThigh; // 0xC4
	private Vector3 headToRightThigh; // 0xD0
	private Vector3 leftShoulderPos; // 0xDC
	private Vector3 rightShoulderPos; // 0xE8
	private float shoulderDist; // 0xF4
	private float leftShoulderDist; // 0xF8
	private float rightShoulderDist; // 0xFC
	private Quaternion chestRotation; // 0x100
	private Quaternion headRotationRelativeToRoot; // 0x110
	private Quaternion[] ccdDefaultLocalRotations; // 0x120
	private Vector3 headLocalPosition; // 0x128
	private Quaternion headLocalRotation; // 0x134
	private Vector3[] stretchLocalPositions; // 0x148
	private Quaternion[] stretchLocalRotations; // 0x150
	private Vector3[] chestLocalPositions; // 0x158
	private Quaternion[] chestLocalRotations; // 0x160
	private int bendBonesCount; // 0x168
	private int ccdBonesCount; // 0x16C
	private int stretchBonesCount; // 0x170
	private int chestBonesCount; // 0x174

	// Methods

	// RVA: 0x1EB3BD0 Offset: 0x1EB25D0 VA: 0x181EB3BD0
	private void Start() { }

	// RVA: 0x1EB29C0 Offset: 0x1EB13C0 VA: 0x181EB29C0
	private void OnStoreDefaultLocalState() { }

	// RVA: 0x1EB1770 Offset: 0x1EB0170 VA: 0x181EB1770
	private void OnFixTransforms() { }

	// RVA: 0x1EB1FC0 Offset: 0x1EB09C0 VA: 0x181EB1FC0
	private void OnPreRead() { }

	// RVA: 0x1EB3500 Offset: 0x1EB1F00 VA: 0x181EB3500
	private void SpineBend() { }

	// RVA: 0x1EAFB00 Offset: 0x1EAE500 VA: 0x181EAFB00
	private void CCDPass() { }

	// RVA: 0x1EB0570 Offset: 0x1EAEF70 VA: 0x181EB0570
	private void Iterate(int iteration) { }

	// RVA: 0x1EB1C50 Offset: 0x1EB0650 VA: 0x181EB1C50
	private void OnPostUpdate() { }

	// RVA: 0x1EB0120 Offset: 0x1EAEB20 VA: 0x181EB0120
	private void ChestDirection() { }

	// RVA: 0x1EB2FC0 Offset: 0x1EB19C0 VA: 0x181EB2FC0
	private void PostStretching() { }

	// RVA: 0x1EB11A0 Offset: 0x1EAFBA0 VA: 0x181EB11A0
	private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) { }

	// RVA: 0x1EB33A0 Offset: 0x1EB1DA0 VA: 0x181EB33A0
	private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) { }

	// RVA: 0x1EB12E0 Offset: 0x1EAFCE0 VA: 0x181EB12E0
	private void OnDestroy() { }

	// RVA: 0x1EB4240 Offset: 0x1EB2C40 VA: 0x181EB4240
	public void .ctor() { }
}
