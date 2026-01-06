public class Finger // TypeDefIndex: 14057
{
	// Fields
	[Tooltip("Master Weight for the finger.")]
	[Range(0, 1)]
	public float weight; // 0x10
	[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
	[Range(0, 1)]
	public float rotationWeight; // 0x14
	[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
	public Finger.DOF rotationDOF; // 0x18
	[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
	public bool fixBone1Twist; // 0x1C
	[Tooltip("The first bone of the finger.")]
	public Transform bone1; // 0x20
	[Tooltip("The second bone of the finger.")]
	public Transform bone2; // 0x28
	[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
	public Transform bone3; // 0x30
	[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
	public Transform tip; // 0x38
	[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
	public Transform target; // 0x40
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C
	private Vector3 defaultBendNormal; // 0xA8

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_initiated(bool value) { }

	// RVA: 0x1EB9A40 Offset: 0x1EB8440 VA: 0x181EB9A40
	public Vector3 get_IKPosition() { }

	// RVA: 0x1EB9AA0 Offset: 0x1EB84A0 VA: 0x181EB9AA0
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x1EB9A70 Offset: 0x1EB8470 VA: 0x181EB9A70
	public Quaternion get_IKRotation() { }

	// RVA: 0x1EB9AD0 Offset: 0x1EB84D0 VA: 0x181EB9AD0
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x1EB8E30 Offset: 0x1EB7830 VA: 0x181EB8E30
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x1EB84B0 Offset: 0x1EB6EB0 VA: 0x181EB84B0
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x1EB83C0 Offset: 0x1EB6DC0 VA: 0x181EB83C0
	public void FixTransforms() { }

	// RVA: 0x1EB8F30 Offset: 0x1EB7930 VA: 0x181EB8F30
	public void StoreDefaultLocalState() { }

	// RVA: 0x1EB9010 Offset: 0x1EB7A10 VA: 0x181EB9010
	public void Update(float masterWeight) { }

	// RVA: 0x1EB9A20 Offset: 0x1EB8420 VA: 0x181EB9A20
	public void .ctor() { }
}
