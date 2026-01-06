public class PhysicsDamageable : MonoBehaviour, IDamageable // TypeDefIndex: 1989
{
	// Fields
	public const int VELOCITY_HISTORY_LENGTH = 4;
	public Rigidbody Rb; // 0x20
	public float ForceMultiplier; // 0x28
	private List<int> impactHistory; // 0x30
	public Action<Impact> onImpacted; // 0x38
	[CompilerGenerated]
	private Vector3 <averageVelocity>k__BackingField; // 0x40
	private List<Vector3> velocityHistory; // 0x50

	// Properties
	public Vector3 averageVelocity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x79EE30 Offset: 0x79D830 VA: 0x18079EE30
	public Vector3 get_averageVelocity() { }

	[CompilerGenerated]
	// RVA: 0x79EE50 Offset: 0x79D850 VA: 0x18079EE50
	private void set_averageVelocity(Vector3 value) { }

	// RVA: 0x79EAC0 Offset: 0x79D4C0 VA: 0x18079EAC0
	public void OnValidate() { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10 Slot: 7
	public virtual void SendImpact(Impact impact) { }

	// RVA: 0x79EB50 Offset: 0x79D550 VA: 0x18079EB50 Slot: 8
	public virtual void ReceiveImpact(Impact impact) { }

	// RVA: 0x79ED30 Offset: 0x79D730 VA: 0x18079ED30
	public void .ctor() { }

	// RVA: 0x63D6C0 Offset: 0x63C0C0 VA: 0x18063D6C0 Slot: 4
	private GameObject ScheduleOne.Combat.IDamageable.get_gameObject() { }
}
