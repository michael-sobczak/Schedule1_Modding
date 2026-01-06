public class FBIKBoxing : MonoBehaviour // TypeDefIndex: 14250
{
	// Fields
	[Tooltip("The target we want to hit")]
	public Transform target; // 0x20
	[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
	public Transform pin; // 0x28
	[Tooltip("The Full Body Biped IK component")]
	public FullBodyBipedIK ik; // 0x30
	[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
	public AimIK aim; // 0x38
	[Tooltip("The master weight")]
	public float weight; // 0x40
	[Tooltip("The effector type of the punching hand")]
	public FullBodyBipedEffector effector; // 0x44
	[Tooltip("Weight of aiming the body to follow the target")]
	public AnimationCurve aimWeight; // 0x48
	private Animator animator; // 0x50

	// Methods

	// RVA: 0x1F3D8F0 Offset: 0x1F3C2F0 VA: 0x181F3D8F0
	private void Start() { }

	// RVA: 0x1F3D6F0 Offset: 0x1F3C0F0 VA: 0x181F3D6F0
	private void LateUpdate() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
