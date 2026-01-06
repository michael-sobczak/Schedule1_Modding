public class VRIKCalibrationController : MonoBehaviour // TypeDefIndex: 14293
{
	// Fields
	[Tooltip("Reference to the VRIK component on the avatar.")]
	public VRIK ik; // 0x20
	[Tooltip("The settings for VRIK calibration.")]
	public VRIKCalibrator.Settings settings; // 0x28
	[Tooltip("The HMD.")]
	public Transform headTracker; // 0x30
	[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
	public Transform bodyTracker; // 0x38
	[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
	public Transform leftHandTracker; // 0x40
	[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
	public Transform rightHandTracker; // 0x48
	[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
	public Transform leftFootTracker; // 0x50
	[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
	public Transform rightFootTracker; // 0x58
	[Header("Data stored by Calibration")]
	public VRIKCalibrator.CalibrationData data; // 0x60

	// Methods

	// RVA: 0x1F58500 Offset: 0x1F56F00 VA: 0x181F58500
	private void LateUpdate() { }

	// RVA: 0x1F586B0 Offset: 0x1F570B0 VA: 0x181F586B0
	public void .ctor() { }
}
