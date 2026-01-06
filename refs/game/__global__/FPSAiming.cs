public class FPSAiming : MonoBehaviour // TypeDefIndex: 14252
{
	// Fields
	[Range(0, 1)]
	public float aimWeight; // 0x20
	[Range(0, 1)]
	public float sightWeight; // 0x24
	[Range(0, 180)]
	public float maxAngle; // 0x28
	public Vector3 aimOffset; // 0x2C
	public bool animatePhysics; // 0x38
	public Transform gun; // 0x40
	public Transform gunTarget; // 0x48
	public FullBodyBipedIK ik; // 0x50
	public AimIK gunAim; // 0x58
	public AimIK headAim; // 0x60
	public CameraControllerFPS cam; // 0x68
	public Recoil recoil; // 0x70
	[Range(0, 1)]
	public float cameraRecoilWeight; // 0x78
	private Vector3 gunTargetDefaultLocalPosition; // 0x7C
	private Vector3 gunTargetDefaultLocalRotation; // 0x88
	private Vector3 camDefaultLocalPosition; // 0x94
	private Vector3 camRelativeToGunTarget; // 0xA0
	private bool updateFrame; // 0xAC

	// Methods

	// RVA: 0x1F40780 Offset: 0x1F3F180 VA: 0x181F40780
	private void Start() { }

	// RVA: 0x1F3ED10 Offset: 0x1F3D710 VA: 0x181F3ED10
	private void FixedUpdate() { }

	// RVA: 0x1F3ED20 Offset: 0x1F3D720 VA: 0x181F3ED20
	private void LateUpdate() { }

	// RVA: 0x1F3E940 Offset: 0x1F3D340 VA: 0x181F3E940
	private void Aiming() { }

	// RVA: 0x1F3EE50 Offset: 0x1F3D850 VA: 0x181F3EE50
	private void LookDownTheSight() { }

	// RVA: 0x1F40410 Offset: 0x1F3EE10 VA: 0x181F40410
	private void RotateCharacter() { }

	// RVA: 0x1F40960 Offset: 0x1F3F360 VA: 0x181F40960
	public void .ctor() { }
}
