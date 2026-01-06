public class RadiantShadowMap : MonoBehaviour // TypeDefIndex: 18588
{
	// Fields
	private const string RADIANT_GO_NAME = "RadiantGI Capture Camera";
	public static bool installed; // 0x0
	public Transform target; // 0x20
	[Tooltip("The capture extents around target")]
	public float targetCaptureSize; // 0x28
	public RadiantShadowMap.ShadowMapResolution resolution; // 0x2C
	private Light thisLight; // 0x30
	public Camera captureCamera; // 0x38
	private Material captureMat; // 0x40
	private Quaternion lastRotation; // 0x48
	private Vector3 lastTargetPos; // 0x58
	private float lastCaptureSize; // 0x64
	public RenderTexture rtColors; // 0x68
	public RenderTexture rtWorldPos; // 0x70
	public RenderTexture rtNormals; // 0x78
	private bool needShoot; // 0x80

	// Methods

	// RVA: 0x1E90E70 Offset: 0x1E8F870 VA: 0x181E90E70
	private void OnEnable() { }

	// RVA: 0x1E91030 Offset: 0x1E8FA30 VA: 0x181E91030
	private void OnValidate() { }

	// RVA: 0x1E90E60 Offset: 0x1E8F860 VA: 0x181E90E60
	private void OnDestroy() { }

	// RVA: 0x1E91050 Offset: 0x1E8FA50 VA: 0x181E91050
	private void Remove() { }

	// RVA: 0x1E91300 Offset: 0x1E8FD00 VA: 0x181E91300
	private void SetupCamera() { }

	// RVA: 0x1E90690 Offset: 0x1E8F090 VA: 0x181E90690
	private void LateUpdate() { }

	// RVA: 0x1E90070 Offset: 0x1E8EA70 VA: 0x181E90070
	private void CaptureScene() { }

	// RVA: 0x1E90600 Offset: 0x1E8F000 VA: 0x181E90600
	private void DestroyRT(RenderTexture rt) { }

	// RVA: 0x1E914B0 Offset: 0x1E8FEB0 VA: 0x181E914B0
	public void .ctor() { }
}
