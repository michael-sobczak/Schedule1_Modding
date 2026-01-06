public class Recoil : OffsetModifier // TypeDefIndex: 14217
{
	// Fields
	[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
	public AimIK aimIK; // 0x38
	[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
	public AimIK headIK; // 0x40
	[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
	public bool aimIKSolvedLast; // 0x48
	[Tooltip("Which hand is holding the weapon?")]
	public Recoil.Handedness handedness; // 0x4C
	[Tooltip("Check for 2-handed weapons.")]
	public bool twoHanded; // 0x50
	[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
	public AnimationCurve recoilWeight; // 0x58
	[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
	public float magnitudeRandom; // 0x60
	[Tooltip("How much is the rotation randomized each time Recoil is called?")]
	public Vector3 rotationRandom; // 0x64
	[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
	public Vector3 handRotationOffset; // 0x70
	[Tooltip("Time of blending in another recoil when doing automatic fire.")]
	public float blendTime; // 0x7C
	[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
	[Space(10)]
	public Recoil.RecoilOffset[] offsets; // 0x80
	[HideInInspector]
	public Quaternion rotationOffset; // 0x88
	private float magnitudeMlp; // 0x98
	private float endTime; // 0x9C
	private Quaternion handRotation; // 0xA0
	private Quaternion secondaryHandRelativeRotation; // 0xB0
	private Quaternion randomRotation; // 0xC0
	private float length; // 0xD0
	private bool initiated; // 0xD4
	private float blendWeight; // 0xD8
	private float w; // 0xDC
	private Quaternion primaryHandRotation; // 0xE0
	private bool handRotationsSet; // 0xF0
	private Vector3 aimIKAxis; // 0xF4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x1F2A4C0 Offset: 0x1F28EC0 VA: 0x181F2A4C0
	public bool get_isFinished() { }

	// RVA: 0x1F2A3E0 Offset: 0x1F28DE0 VA: 0x181F2A3E0
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x1F28A50 Offset: 0x1F27450 VA: 0x181F28A50
	public void Fire(float magnitude) { }

	// RVA: 0x1F28FC0 Offset: 0x1F279C0 VA: 0x181F28FC0 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F28720 Offset: 0x1F27120 VA: 0x181F28720
	private void AfterFBBIK() { }

	// RVA: 0x1F28650 Offset: 0x1F27050 VA: 0x181F28650
	private void AfterAimIK() { }

	// RVA: 0x1F2A4E0 Offset: 0x1F28EE0 VA: 0x181F2A4E0
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x1F2A570 Offset: 0x1F28F70 VA: 0x181F2A570
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x1F2A520 Offset: 0x1F28F20 VA: 0x181F2A520
	private Transform get_primaryHand() { }

	// RVA: 0x1F2A5B0 Offset: 0x1F28FB0 VA: 0x181F2A5B0
	private Transform get_secondaryHand() { }

	// RVA: 0x1F28C60 Offset: 0x1F27660 VA: 0x181F28C60 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1F2A410 Offset: 0x1F28E10 VA: 0x181F2A410
	public void .ctor() { }
}
