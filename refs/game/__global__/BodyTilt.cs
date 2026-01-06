public class BodyTilt : OffsetModifier // TypeDefIndex: 14183
{
	// Fields
	[Tooltip("Speed of tilting")]
	public float tiltSpeed; // 0x38
	[Tooltip("Sensitivity of tilting")]
	public float tiltSensitivity; // 0x3C
	[Tooltip("The OffsetPose components")]
	public OffsetPose poseLeft; // 0x40
	[Tooltip("The OffsetPose components")]
	public OffsetPose poseRight; // 0x48
	private float tiltAngle; // 0x50
	private Vector3 lastForward; // 0x54

	// Methods

	// RVA: 0x1F1BD10 Offset: 0x1F1A710 VA: 0x181F1BD10 Slot: 5
	protected override void Start() { }

	// RVA: 0x1F1B970 Offset: 0x1F1A370 VA: 0x181F1B970 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F1BDC0 Offset: 0x1F1A7C0 VA: 0x181F1BDC0
	public void .ctor() { }
}
