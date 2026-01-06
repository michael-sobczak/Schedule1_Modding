public class SimpleAimingSystem : MonoBehaviour // TypeDefIndex: 14230
{
	// Fields
	[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
	public AimPoser aimPoser; // 0x20
	[Tooltip("Reference to the AimIK component.")]
	public AimIK aim; // 0x28
	[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
	public LookAtIK lookAt; // 0x30
	[Tooltip("Reference to the Animator component.")]
	public Animator animator; // 0x38
	[Tooltip("Time of cross-fading from pose to pose.")]
	public float crossfadeTime; // 0x40
	[Tooltip("Will keep the aim target at a distance.")]
	public float minAimDistance; // 0x44
	private AimPoser.Pose aimPose; // 0x48
	private AimPoser.Pose lastPose; // 0x50

	// Methods

	// RVA: 0x1F4BE60 Offset: 0x1F4A860 VA: 0x181F4BE60
	private void Start() { }

	// RVA: 0x1F4B8D0 Offset: 0x1F4A2D0 VA: 0x181F4B8D0
	private void LateUpdate() { }

	// RVA: 0x1F4BB10 Offset: 0x1F4A510 VA: 0x181F4BB10
	private void Pose() { }

	// RVA: 0x1F4B980 Offset: 0x1F4A380 VA: 0x181F4B980
	private void LimitAimTarget() { }

	// RVA: 0x1F4B810 Offset: 0x1F4A210 VA: 0x181F4B810
	private void DirectCrossFade(string state, float target) { }

	// RVA: 0x1F4BEA0 Offset: 0x1F4A8A0 VA: 0x181F4BEA0
	public void .ctor() { }
}
