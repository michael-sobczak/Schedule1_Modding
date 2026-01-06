public class BipedIKvsAnimatorIK : MonoBehaviour // TypeDefIndex: 14232
{
	// Fields
	[LargeHeader("References")]
	public Animator animator; // 0x20
	public BipedIK bipedIK; // 0x28
	[LargeHeader("Look At")]
	public Transform lookAtTargetBiped; // 0x30
	public Transform lookAtTargetAnimator; // 0x38
	[Range(0, 1)]
	public float lookAtWeight; // 0x40
	[Range(0, 1)]
	public float lookAtBodyWeight; // 0x44
	[Range(0, 1)]
	public float lookAtHeadWeight; // 0x48
	[Range(0, 1)]
	public float lookAtEyesWeight; // 0x4C
	[Range(0, 1)]
	public float lookAtClampWeight; // 0x50
	[Range(0, 1)]
	public float lookAtClampWeightHead; // 0x54
	[Range(0, 1)]
	public float lookAtClampWeightEyes; // 0x58
	[LargeHeader("Foot")]
	public Transform footTargetBiped; // 0x60
	public Transform footTargetAnimator; // 0x68
	[Range(0, 1)]
	public float footPositionWeight; // 0x70
	[Range(0, 1)]
	public float footRotationWeight; // 0x74
	[LargeHeader("Hand")]
	public Transform handTargetBiped; // 0x78
	public Transform handTargetAnimator; // 0x80
	[Range(0, 1)]
	public float handPositionWeight; // 0x88
	[Range(0, 1)]
	public float handRotationWeight; // 0x8C

	// Methods

	// RVA: 0x1F39C50 Offset: 0x1F38650 VA: 0x181F39C50
	private void OnAnimatorIK(int layer) { }

	// RVA: 0x1F3A370 Offset: 0x1F38D70 VA: 0x181F3A370
	public void .ctor() { }
}
