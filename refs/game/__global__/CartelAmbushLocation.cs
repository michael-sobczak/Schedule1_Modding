public class CartelAmbushLocation : MonoBehaviour // TypeDefIndex: 2078
{
	// Fields
	public const int REQUIRED_AMBUSH_POINTS = 4;
	[Range(2, 20)]
	[Header("Settings")]
	public float DetectionRadius; // 0x20
	public Transform[] AmbushPoints; // 0x28

	// Methods

	// RVA: 0x8000F0 Offset: 0x7FEAF0 VA: 0x1808000F0
	private void Awake() { }

	// RVA: 0x800400 Offset: 0x7FEE00 VA: 0x180800400
	private void OnDrawGizmos() { }

	// RVA: 0x8005A0 Offset: 0x7FEFA0 VA: 0x1808005A0
	public void .ctor() { }
}
