public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 14242
{
	// Fields
	[Range(0, 1)]
	public float headLookWeight; // 0x68
	public Vector3 gunHoldOffset; // 0x6C
	public Vector3 leftHandOffset; // 0x78
	public Recoil recoil; // 0x88
	private AimIK aim; // 0x90
	private FullBodyBipedIK ik; // 0x98
	private Vector3 headLookAxis; // 0xA0
	private Vector3 leftHandPosRelToRightHand; // 0xAC
	private Quaternion leftHandRotRelToRightHand; // 0xB8
	private Vector3 aimTarget; // 0xC8
	private Quaternion rightHandRotation; // 0xD4

	// Methods

	// RVA: 0x1F39220 Offset: 0x1F37C20 VA: 0x181F39220 Slot: 4
	protected override void Start() { }

	// RVA: 0x1F38820 Offset: 0x1F37220 VA: 0x181F38820 Slot: 5
	public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) { }

	// RVA: 0x1F38F70 Offset: 0x1F37970 VA: 0x181F38F70
	private void Read() { }

	// RVA: 0x1F37C30 Offset: 0x1F36630 VA: 0x181F37C30
	private void AimIK() { }

	// RVA: 0x1F37C90 Offset: 0x1F36690 VA: 0x181F37C90
	private void FBBIK() { }

	// RVA: 0x1F38AF0 Offset: 0x1F374F0 VA: 0x181F38AF0
	private void OnPreRead() { }

	// RVA: 0x1F384B0 Offset: 0x1F36EB0 VA: 0x181F384B0
	private void HeadLookAt(Vector3 lookAtTarget) { }

	// RVA: 0x1F38990 Offset: 0x1F37390 VA: 0x181F38990
	private void OnDestroy() { }

	// RVA: 0x1F394B0 Offset: 0x1F37EB0 VA: 0x181F394B0
	public void .ctor() { }
}
