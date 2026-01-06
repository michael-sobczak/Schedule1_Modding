public abstract class CharacterAnimationBase : MonoBehaviour // TypeDefIndex: 14296
{
	// Fields
	public bool smoothFollow; // 0x20
	public float smoothFollowSpeed; // 0x24
	protected bool animatePhysics; // 0x28
	private Vector3 lastPosition; // 0x2C
	private Vector3 localPosition; // 0x38
	private Quaternion localRotation; // 0x44
	private Quaternion lastRotation; // 0x54

	// Properties
	public virtual bool animationGrounded { get; }

	// Methods

	// RVA: 0x7262C0 Offset: 0x724CC0 VA: 0x1807262C0 Slot: 4
	public virtual Vector3 GetPivotPoint() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 5
	public virtual bool get_animationGrounded() { }

	// RVA: 0x1F50490 Offset: 0x1F4EE90 VA: 0x181F50490
	public float GetAngleFromForward(Vector3 worldDirection) { }

	// RVA: 0x1F50930 Offset: 0x1F4F330 VA: 0x181F50930 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x1F504F0 Offset: 0x1F4EEF0 VA: 0x181F504F0 Slot: 7
	protected virtual void LateUpdate() { }

	// RVA: 0x1F50480 Offset: 0x1F4EE80 VA: 0x181F50480 Slot: 8
	protected virtual void FixedUpdate() { }

	// RVA: 0x1F50500 Offset: 0x1F4EF00 VA: 0x181F50500
	private void SmoothFollow() { }

	// RVA: 0x1F50AD0 Offset: 0x1F4F4D0 VA: 0x181F50AD0
	protected void .ctor() { }
}
