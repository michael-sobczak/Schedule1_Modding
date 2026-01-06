public class DraggableConstraint : MonoBehaviour // TypeDefIndex: 774
{
	// Fields
	public Transform Container; // 0x20
	public Rigidbody Anchor; // 0x28
	public bool ProportionalZClamp; // 0x30
	public bool AlignUpToContainerPlane; // 0x31
	[Header("Up Direction Clamping")]
	public bool ClampUpDirection; // 0x32
	public float UpDirectionMaxDifference; // 0x34
	private Vector3 startLocalPos; // 0x38
	private Draggable draggable; // 0x48
	private ConfigurableJoint joint; // 0x50

	// Properties
	private Vector3 RelativePos { get; }

	// Methods

	// RVA: 0x588550 Offset: 0x586F50 VA: 0x180588550
	private Vector3 get_RelativePos() { }

	// RVA: 0x588300 Offset: 0x586D00 VA: 0x180588300
	private void Start() { }

	// RVA: 0x588190 Offset: 0x586B90 VA: 0x180588190
	public void SetContainer(Transform container) { }

	// RVA: 0x587670 Offset: 0x586070 VA: 0x180587670 Slot: 4
	protected virtual void FixedUpdate() { }

	// RVA: 0x587680 Offset: 0x586080 VA: 0x180587680 Slot: 5
	protected virtual void LateUpdate() { }

	// RVA: 0x587FF0 Offset: 0x5869F0 VA: 0x180587FF0
	private void ProportionalClamp() { }

	// RVA: 0x587850 Offset: 0x586250 VA: 0x180587850
	private void LockRotationX() { }

	// RVA: 0x587C20 Offset: 0x586620 VA: 0x180587C20
	private void LockRotationY() { }

	// RVA: 0x587210 Offset: 0x585C10 VA: 0x180587210
	private void AlignToContainerPlane() { }

	// RVA: 0x5874B0 Offset: 0x585EB0 VA: 0x1805874B0
	private void ClampUpRot() { }

	// RVA: 0x588540 Offset: 0x586F40 VA: 0x180588540
	public void .ctor() { }
}
