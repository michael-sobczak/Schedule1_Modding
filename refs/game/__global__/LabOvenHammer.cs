public class LabOvenHammer : MonoBehaviour // TypeDefIndex: 3259
{
	// Fields
	public Draggable Draggable; // 0x20
	public DraggableConstraint Constraint; // 0x28
	public RotateRigidbodyToTarget Rotator; // 0x30
	public Transform CoM; // 0x38
	public Transform ImpactPoint; // 0x40
	public SmoothedVelocityCalculator VelocityCalculator; // 0x48
	[Header("Settings")]
	public float MinHeight; // 0x50
	public float MaxHeight; // 0x54
	public float MinAngle; // 0x58
	public float MaxAngle; // 0x5C
	public UnityEvent<Collision> onCollision; // 0x60

	// Methods

	// RVA: 0xA17370 Offset: 0xA15D70 VA: 0x180A17370
	private void Start() { }

	// RVA: 0xA173D0 Offset: 0xA15DD0 VA: 0x180A173D0
	private void Update() { }

	// RVA: 0xA17310 Offset: 0xA15D10 VA: 0x180A17310
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0xA17520 Offset: 0xA15F20 VA: 0x180A17520
	public void .ctor() { }
}
