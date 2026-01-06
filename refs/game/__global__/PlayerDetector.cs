public class PlayerDetector : MonoBehaviour // TypeDefIndex: 2319
{
	// Fields
	public const float ACTIVATION_DISTANCE_SQ = 400;
	public bool DetectPlayerInVehicle; // 0x20
	public UnityEvent<Player> onPlayerEnter; // 0x28
	public UnityEvent<Player> onPlayerExit; // 0x30
	public UnityEvent onLocalPlayerEnter; // 0x38
	public UnityEvent onLocalPlayerExit; // 0x40
	public List<Player> DetectedPlayers; // 0x48
	[CompilerGenerated]
	private bool <IgnoreNewDetections>k__BackingField; // 0x50
	private bool ignoreExit; // 0x51
	private bool collidersEnabled; // 0x52
	private Collider[] detectionColliders; // 0x58

	// Properties
	public bool IgnoreNewDetections { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_IgnoreNewDetections() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	protected void set_IgnoreNewDetections(bool value) { }

	// RVA: 0x866330 Offset: 0x864D30 VA: 0x180866330
	private void Awake() { }

	// RVA: 0x867020 Offset: 0x865A20 VA: 0x180867020
	private void Start() { }

	// RVA: 0x866740 Offset: 0x865140 VA: 0x180866740
	private void OnDestroy() { }

	// RVA: 0x866530 Offset: 0x864F30 VA: 0x180866530
	private void MinPass() { }

	// RVA: 0x866860 Offset: 0x865260 VA: 0x180866860
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x866420 Offset: 0x864E20 VA: 0x180866420
	private void FixedUpdate() { }

	// RVA: 0x866BD0 Offset: 0x8655D0 VA: 0x180866BD0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x866F40 Offset: 0x865940 VA: 0x180866F40
	public void SetIgnoreNewCollisions(bool ignore) { }

	// RVA: 0x867120 Offset: 0x865B20 VA: 0x180867120
	public void .ctor() { }
}
