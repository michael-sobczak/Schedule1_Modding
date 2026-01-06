public class VRIKCalibrationBasic : MonoBehaviour // TypeDefIndex: 14292
{
	// Fields
	[Tooltip("The VRIK component.")]
	public VRIK ik; // 0x20
	[Tooltip("HMD.")]
	[Header("Head")]
	public Transform centerEyeAnchor; // 0x28
	[Tooltip("Position offset of the camera from the head bone (root space).")]
	public Vector3 headAnchorPositionOffset; // 0x30
	[Tooltip("Rotation offset of the camera from the head bone (root space).")]
	public Vector3 headAnchorRotationOffset; // 0x3C
	[Tooltip("Left Hand Controller")]
	[Header("Hands")]
	public Transform leftHandAnchor; // 0x48
	[Tooltip("Right Hand Controller")]
	public Transform rightHandAnchor; // 0x50
	[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
	public Vector3 handAnchorPositionOffset; // 0x58
	[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
	public Vector3 handAnchorRotationOffset; // 0x64
	[Header("Scale")]
	[Tooltip("Multiplies the scale of the root.")]
	public float scaleMlp; // 0x70
	[Header("Data stored by Calibration")]
	public VRIKCalibrator.CalibrationData data; // 0x78

	// Methods

	// RVA: 0x1F58280 Offset: 0x1F56C80 VA: 0x181F58280
	private void LateUpdate() { }

	// RVA: 0x1F58490 Offset: 0x1F56E90 VA: 0x181F58490
	public void .ctor() { }
}
