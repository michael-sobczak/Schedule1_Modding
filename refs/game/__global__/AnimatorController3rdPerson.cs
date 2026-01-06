public class AnimatorController3rdPerson : MonoBehaviour // TypeDefIndex: 14241
{
	// Fields
	public float rotateSpeed; // 0x20
	public float blendSpeed; // 0x24
	public float maxAngle; // 0x28
	public float moveSpeed; // 0x2C
	public float rootMotionWeight; // 0x30
	protected Animator animator; // 0x38
	protected Vector3 moveBlend; // 0x40
	protected Vector3 moveInput; // 0x4C
	protected Vector3 velocity; // 0x58

	// Methods

	// RVA: 0x1F39AB0 Offset: 0x1F384B0 VA: 0x181F39AB0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1F39770 Offset: 0x1F38170 VA: 0x181F39770
	private void OnAnimatorMove() { }

	// RVA: 0x1F394E0 Offset: 0x1F37EE0 VA: 0x181F394E0 Slot: 5
	public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) { }

	// RVA: 0x1F39B00 Offset: 0x1F38500 VA: 0x181F39B00
	public void .ctor() { }
}
