public class Navigator // TypeDefIndex: 14312
{
	// Fields
	[Tooltip("Should this Navigator be actively seeking a path.")]
	public bool activeTargetSeeking; // 0x10
	[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
	public float cornerRadius; // 0x14
	[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
	public float recalculateOnPathDistance; // 0x18
	[Tooltip("Sample within this distance from sourcePosition.")]
	public float maxSampleDistance; // 0x1C
	[Tooltip("Interval of updating the path")]
	public float nextPathInterval; // 0x20
	[CompilerGenerated]
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGenerated]
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D6370 Offset: 0x4D4D70 VA: 0x1804D6370
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGenerated]
	// RVA: 0x4D6620 Offset: 0x4D5020 VA: 0x1804D6620
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public Navigator.State get_state() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_state(Navigator.State value) { }

	// RVA: 0x1F563E0 Offset: 0x1F54DE0 VA: 0x181F563E0
	public void Initiate(Transform transform) { }

	// RVA: 0x1F564F0 Offset: 0x1F54EF0 VA: 0x181F564F0
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x1F56060 Offset: 0x1F54A60 VA: 0x181F56060
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x1F56110 Offset: 0x1F54B10 VA: 0x181F56110
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x1F564A0 Offset: 0x1F54EA0 VA: 0x181F564A0
	private void Stop() { }

	// RVA: 0x1F56330 Offset: 0x1F54D30 VA: 0x181F56330
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x1F56A30 Offset: 0x1F55430 VA: 0x181F56A30
	public void Visualize() { }

	// RVA: 0x1F56C80 Offset: 0x1F55680 VA: 0x181F56C80
	public void .ctor() { }
}
