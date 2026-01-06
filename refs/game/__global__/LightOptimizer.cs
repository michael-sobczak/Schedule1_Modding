public class LightOptimizer : MonoBehaviour // TypeDefIndex: 1912
{
	// Fields
	public bool LightsEnabled; // 0x20
	[Header("References")]
	[SerializeField]
	protected BoxCollider[] activationZones; // 0x28
	[SerializeField]
	protected Transform[] viewPoints; // 0x30
	[Header("Settings")]
	public float checkRange; // 0x38
	protected OptimizedLight[] lights; // 0x40

	// Methods

	// RVA: 0x77CE90 Offset: 0x77B890 VA: 0x18077CE90
	public void Awake() { }

	// RVA: 0x77CEF0 Offset: 0x77B8F0 VA: 0x18077CEF0
	public void FixedUpdate() { }

	// RVA: 0x77CD90 Offset: 0x77B790 VA: 0x18077CD90
	public void ApplyLights() { }

	// RVA: 0x77D430 Offset: 0x77BE30 VA: 0x18077D430
	public bool PointInCameraView(Vector3 point) { }

	// RVA: 0x644CF0 Offset: 0x6436F0 VA: 0x180644CF0
	public bool Is01(float a) { }

	// RVA: 0x77D420 Offset: 0x77BE20 VA: 0x18077D420
	public void LightsEnabled_True() { }

	// RVA: 0x77D410 Offset: 0x77BE10 VA: 0x18077D410
	public void LightsEnabled_False() { }

	// RVA: 0x77D810 Offset: 0x77C210 VA: 0x18077D810
	public void .ctor() { }
}
