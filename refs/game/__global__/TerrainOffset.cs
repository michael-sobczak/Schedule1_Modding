public class TerrainOffset : MonoBehaviour // TypeDefIndex: 14231
{
	// Fields
	public AimIK aimIK; // 0x20
	public Vector3 raycastOffset; // 0x28
	public LayerMask raycastLayers; // 0x34
	public float min; // 0x38
	public float max; // 0x3C
	public float lerpSpeed; // 0x40
	private RaycastHit hit; // 0x44
	private Vector3 offset; // 0x70

	// Methods

	// RVA: 0x1F4C420 Offset: 0x1F4AE20 VA: 0x181F4C420
	private void LateUpdate() { }

	// RVA: 0x1F4C160 Offset: 0x1F4AB60 VA: 0x181F4C160
	private Vector3 GetGroundHeightOffset(Vector3 worldPosition) { }

	// RVA: 0x1F4C6B0 Offset: 0x1F4B0B0 VA: 0x181F4C6B0
	public void .ctor() { }
}
