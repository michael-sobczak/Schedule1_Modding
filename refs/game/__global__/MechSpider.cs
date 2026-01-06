public class MechSpider : MonoBehaviour // TypeDefIndex: 14233
{
	// Fields
	public LayerMask raycastLayers; // 0x20
	public float scale; // 0x24
	public Transform body; // 0x28
	public MechSpiderLeg[] legs; // 0x30
	public float legRotationWeight; // 0x38
	public float rootPositionSpeed; // 0x3C
	public float rootRotationSpeed; // 0x40
	public float breatheSpeed; // 0x44
	public float breatheMagnitude; // 0x48
	public float height; // 0x4C
	public float minHeight; // 0x50
	public float raycastHeight; // 0x54
	public float raycastDistance; // 0x58
	[CompilerGenerated]
	private Vector3 <velocity>k__BackingField; // 0x5C
	private Vector3 lastPosition; // 0x68
	private Vector3 defaultBodyLocalPosition; // 0x74
	private float sine; // 0x80
	private RaycastHit rootHit; // 0x84

	// Properties
	public Vector3 velocity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D6390 Offset: 0x4D4D90 VA: 0x1804D6390
	public Vector3 get_velocity() { }

	[CompilerGenerated]
	// RVA: 0x4D6630 Offset: 0x4D5030 VA: 0x1804D6630
	private void set_velocity(Vector3 value) { }

	// RVA: 0x1F44BB0 Offset: 0x1F435B0 VA: 0x181F44BB0
	private void Start() { }

	// RVA: 0x1F44BF0 Offset: 0x1F435F0 VA: 0x181F44BF0
	private void Update() { }

	// RVA: 0x1F44660 Offset: 0x1F43060 VA: 0x181F44660
	private Vector3 GetLegCentroid() { }

	// RVA: 0x1F44800 Offset: 0x1F43200 VA: 0x181F44800
	private Vector3 GetLegsPlaneNormal() { }

	// RVA: 0x1F457C0 Offset: 0x1F441C0 VA: 0x181F457C0
	public void .ctor() { }
}
