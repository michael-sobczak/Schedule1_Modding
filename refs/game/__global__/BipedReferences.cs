public class BipedReferences // TypeDefIndex: 14026
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform leftThigh; // 0x20
	public Transform leftCalf; // 0x28
	public Transform leftFoot; // 0x30
	public Transform rightThigh; // 0x38
	public Transform rightCalf; // 0x40
	public Transform rightFoot; // 0x48
	public Transform leftUpperArm; // 0x50
	public Transform leftForearm; // 0x58
	public Transform leftHand; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	public Transform head; // 0x80
	public Transform[] spine; // 0x88
	public Transform[] eyes; // 0x90

	// Properties
	public virtual bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x1EA1FB0 Offset: 0x1EA09B0 VA: 0x181EA1FB0 Slot: 4
	public virtual bool get_isFilled() { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90
	public bool get_isEmpty() { }

	// RVA: 0x1EA07B0 Offset: 0x1E9F1B0 VA: 0x181EA07B0 Slot: 5
	public virtual bool IsEmpty(bool includeRoot) { }

	// RVA: 0x1E9F260 Offset: 0x1E9DC60 VA: 0x181E9F260 Slot: 6
	public virtual bool Contains(Transform t, bool ignoreRoot = False) { }

	// RVA: 0x1E9EEC0 Offset: 0x1E9D8C0 VA: 0x181E9EEC0
	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x1E9F780 Offset: 0x1E9E180 VA: 0x181E9F780
	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x1E9E930 Offset: 0x1E9D330 VA: 0x181E9E930
	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x1EA1880 Offset: 0x1EA0280 VA: 0x181EA1880
	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x1EA19D0 Offset: 0x1EA03D0 VA: 0x181EA19D0
	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x1EA0B80 Offset: 0x1E9F580 VA: 0x181EA0B80
	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	// RVA: 0x1E9E5D0 Offset: 0x1E9CFD0 VA: 0x181E9E5D0
	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x1E9E7C0 Offset: 0x1E9D1C0 VA: 0x181E9E7C0
	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams) { }

	// RVA: 0x1E9F650 Offset: 0x1E9E050 VA: 0x181E9F650
	private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	// RVA: 0x1E9E6D0 Offset: 0x1E9D0D0 VA: 0x181E9E6D0
	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	// RVA: 0x1EA0C60 Offset: 0x1E9F660 VA: 0x181EA0C60
	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	// RVA: 0x1EA1300 Offset: 0x1E9FD00 VA: 0x181EA1300
	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	// RVA: 0x1EA1AC0 Offset: 0x1EA04C0 VA: 0x181EA1AC0
	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x1EA02C0 Offset: 0x1E9ECC0 VA: 0x181EA02C0
	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x1EA1600 Offset: 0x1EA0000 VA: 0x181EA1600
	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x1EA04B0 Offset: 0x1E9EEB0 VA: 0x181EA04B0
	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	// RVA: 0x1EA0710 Offset: 0x1E9F110 VA: 0x181EA0710
	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	// RVA: 0x1EA1F10 Offset: 0x1EA0910 VA: 0x181EA1F10
	public void .ctor() { }
}
