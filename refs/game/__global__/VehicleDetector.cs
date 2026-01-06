public class VehicleDetector : MonoBehaviour // TypeDefIndex: 1945
{
	// Fields
	public const float ACTIVATION_DISTANCE_SQ = 400;
	public List<LandVehicle> vehicles; // 0x20
	public LandVehicle closestVehicle; // 0x28
	[CompilerGenerated]
	private bool <IgnoreNewDetections>k__BackingField; // 0x30
	private bool ignoreExit; // 0x31
	private Collider[] detectionColliders; // 0x38
	private bool collidersEnabled; // 0x40

	// Properties
	public bool IgnoreNewDetections { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IgnoreNewDetections() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IgnoreNewDetections(bool value) { }

	// RVA: 0x7A8840 Offset: 0x7A7240 VA: 0x1807A8840
	private void Awake() { }

	// RVA: 0x7A91F0 Offset: 0x7A7BF0 VA: 0x1807A91F0
	private void Start() { }

	// RVA: 0x7A8C10 Offset: 0x7A7610 VA: 0x1807A8C10
	private void OnDestroy() { }

	// RVA: 0x7A8D30 Offset: 0x7A7730 VA: 0x1807A8D30
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x7A89A0 Offset: 0x7A73A0 VA: 0x1807A89A0
	private void MinPass() { }

	// RVA: 0x7A8EC0 Offset: 0x7A78C0 VA: 0x1807A8EC0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x7A90E0 Offset: 0x7A7AE0 VA: 0x1807A90E0
	private void SortVehicles() { }

	// RVA: 0x7A9000 Offset: 0x7A7A00 VA: 0x1807A9000
	public void SetIgnoreNewCollisions(bool ignore) { }

	// RVA: 0x7A87A0 Offset: 0x7A71A0 VA: 0x1807A87A0
	public bool AreAnyVehiclesOccupied() { }

	// RVA: 0x7A8930 Offset: 0x7A7330 VA: 0x1807A8930
	public void Clear() { }

	// RVA: 0x7A9430 Offset: 0x7A7E30 VA: 0x1807A9430
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7A92F0 Offset: 0x7A7CF0 VA: 0x1807A92F0
	private float <SortVehicles>b__16_0(LandVehicle x) { }
}
