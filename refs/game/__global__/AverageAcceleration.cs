public class AverageAcceleration : MonoBehaviour // TypeDefIndex: 1895
{
	// Fields
	[CompilerGenerated]
	private Vector3 <Acceleration>k__BackingField; // 0x20
	public Rigidbody Rb; // 0x30
	public float TimeWindow; // 0x38
	private Vector3[] accelerations; // 0x40
	private int currentIndex; // 0x48
	private float timer; // 0x4C
	private Vector3 prevVelocity; // 0x50

	// Properties
	public Vector3 Acceleration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4DA100 Offset: 0x4D8B00 VA: 0x1804DA100
	public Vector3 get_Acceleration() { }

	[CompilerGenerated]
	// RVA: 0x4DA200 Offset: 0x4D8C00 VA: 0x1804DA200
	private void set_Acceleration(Vector3 value) { }

	// RVA: 0x777F60 Offset: 0x776960 VA: 0x180777F60
	private void Start() { }

	// RVA: 0x777CC0 Offset: 0x7766C0 VA: 0x180777CC0
	private void FixedUpdate() { }

	// RVA: 0x778130 Offset: 0x776B30 VA: 0x180778130
	public void .ctor() { }
}
