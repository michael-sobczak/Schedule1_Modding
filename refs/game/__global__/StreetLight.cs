public class StreetLight : MonoBehaviour // TypeDefIndex: 3377
{
	// Fields
	public static Vector3 POWER_ORIGIN; // 0x0
	[Header("References")]
	[SerializeField]
	protected MeshRenderer LightRend; // 0x20
	[SerializeField]
	protected Light Light; // 0x28
	[SerializeField]
	protected VolumetricLightTracker BeamTracker; // 0x30
	[Header("Materials")]
	public Material LightOnMat; // 0x38
	public Material LightOffMat; // 0x40
	[Header("Timing")]
	public int StartTime; // 0x48
	public int EndTime; // 0x4C
	public int StartTimeOffset; // 0x50
	[Header("Settings")]
	public bool ShadowsEnabled; // 0x54
	public float LightMaxDistance; // 0x58
	public float SoftShadowsThreshold; // 0x5C
	public float HardShadowsThreshold; // 0x60
	private bool isOn; // 0x64

	// Methods

	// RVA: 0xA78920 Offset: 0xA77320 VA: 0x180A78920 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750
	private void Start() { }

	// RVA: 0xA79090 Offset: 0xA77A90 VA: 0x180A79090 Slot: 5
	protected virtual void UpdateState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDrawGizmos() { }

	// RVA: 0xA78BB0 Offset: 0xA775B0 VA: 0x180A78BB0
	private void SetState(bool on) { }

	// RVA: 0xA78E70 Offset: 0xA77870 VA: 0x180A78E70
	private void UpdateShadows() { }

	// RVA: 0xA791E0 Offset: 0xA77BE0 VA: 0x180A791E0
	public void .ctor() { }

	// RVA: 0xA79180 Offset: 0xA77B80 VA: 0x180A79180
	private static void .cctor() { }
}
