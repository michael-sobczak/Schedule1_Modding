public class AvatarFootstepDetector : MonoBehaviour // TypeDefIndex: 3143
{
	// Fields
	public const float GROUND_DETECTION_RANGE = 0.15;
	public Avatar Avatar; // 0x20
	public Transform ReferencePoint; // 0x28
	public Transform LeftBone; // 0x30
	public Transform RightBone; // 0x38
	public float StepThreshold; // 0x40
	public LayerMask GroundDetectionMask; // 0x44
	public float MaxDetectionRange; // 0x48
	private bool leftDown; // 0x4C
	private bool rightDown; // 0x4D
	public UnityEvent<EMaterialType, float> onStep; // 0x50

	// Methods

	// RVA: 0x9AEA00 Offset: 0x9AD400 VA: 0x1809AEA00
	private void LateUpdate() { }

	// RVA: 0x9AED00 Offset: 0x9AD700 VA: 0x1809AED00
	public void TriggerStep() { }

	// RVA: 0x9AE780 Offset: 0x9AD180 VA: 0x1809AE780
	public bool IsGrounded(out EMaterialType surfaceType) { }

	// RVA: 0x9AED80 Offset: 0x9AD780 VA: 0x1809AED80
	public void .ctor() { }
}
