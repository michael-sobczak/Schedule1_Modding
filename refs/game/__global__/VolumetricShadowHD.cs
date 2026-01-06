public class VolumetricShadowHD : MonoBehaviour // TypeDefIndex: 282
{
	// Fields
	public const string ClassName = "VolumetricShadowHD";
	[SerializeField]
	private float m_Strength; // 0x20
	[SerializeField]
	private ShadowUpdateRate m_UpdateRate; // 0x24
	[SerializeField]
	private int m_WaitXFrames; // 0x28
	[SerializeField]
	private LayerMask m_LayerMask; // 0x2C
	[SerializeField]
	private bool m_UseOcclusionCulling; // 0x30
	[SerializeField]
	private int m_DepthMapResolution; // 0x34
	private VolumetricLightBeamHD m_Master; // 0x38
	private TransformUtils.Packed m_TransformPacked; // 0x40
	private int m_LastFrameRendered; // 0x68
	private Camera m_DepthCamera; // 0x70
	private bool m_NeedToUpdateOcclusionNextFrame; // 0x78
	public static bool _INTERNAL_ApplyRandomFrameOffset; // 0x0

	// Properties
	public float strength { get; set; }
	public ShadowUpdateRate updateRate { get; set; }
	public int waitXFrames { get; set; }
	public LayerMask layerMask { get; set; }
	public bool useOcclusionCulling { get; set; }
	public int depthMapResolution { get; set; }
	public int _INTERNAL_LastFrameRendered { get; }

	// Methods

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_strength() { }

	// RVA: 0x6A7180 Offset: 0x6A5B80 VA: 0x1806A7180
	public void set_strength(float value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public ShadowUpdateRate get_updateRate() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_updateRate(ShadowUpdateRate value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_waitXFrames() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_waitXFrames(int value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public LayerMask get_layerMask() { }

	// RVA: 0x6A7170 Offset: 0x6A5B70 VA: 0x1806A7170
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_useOcclusionCulling() { }

	// RVA: 0x6A71A0 Offset: 0x6A5BA0 VA: 0x1806A71A0
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_depthMapResolution() { }

	// RVA: 0x6A6FC0 Offset: 0x6A59C0 VA: 0x1806A6FC0
	public void set_depthMapResolution(int value) { }

	// RVA: 0x6A6970 Offset: 0x6A5370 VA: 0x1806A6970
	public void ProcessOcclusionManually() { }

	// RVA: 0x6A6D90 Offset: 0x6A5790 VA: 0x1806A6D90
	public void UpdateDepthCameraProperties() { }

	// RVA: 0x6A6980 Offset: 0x6A5380 VA: 0x1806A6980
	private void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source) { }

	// RVA: 0x6A5E00 Offset: 0x6A4800 VA: 0x1806A5E00
	public static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom) { }

	// RVA: 0x6A60E0 Offset: 0x6A4AE0 VA: 0x1806A60E0
	private void Awake() { }

	// RVA: 0x6A6760 Offset: 0x6A5160 VA: 0x1806A6760
	private void OnEnable() { }

	// RVA: 0x6A66D0 Offset: 0x6A50D0 VA: 0x1806A66D0
	private void OnDisable() { }

	// RVA: 0x6A6130 Offset: 0x6A4B30 VA: 0x1806A6130
	private void OnDestroy() { }

	// RVA: 0x6A6940 Offset: 0x6A5340 VA: 0x1806A6940
	private void ProcessOcclusionInternal() { }

	// RVA: 0x6A6690 Offset: 0x6A5090 VA: 0x1806A6690
	private void OnBeamEnabled() { }

	// RVA: 0x6A6850 Offset: 0x6A5250 VA: 0x1806A6850
	public void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom) { }

	// RVA: 0x6A6E30 Offset: 0x6A5830 VA: 0x1806A6E30
	private void Update() { }

	// RVA: 0x6A6B70 Offset: 0x6A5570 VA: 0x1806A6B70
	private void UpdateDepthCameraPropertiesAccordingToBeam() { }

	// RVA: 0x6A6290 Offset: 0x6A4C90 VA: 0x1806A6290
	private void InstantiateOrActivateDepthCamera() { }

	// RVA: 0x6A6130 Offset: 0x6A4B30 VA: 0x1806A6130
	private void DestroyDepthCamera() { }

	// RVA: 0x6A67F0 Offset: 0x6A51F0 VA: 0x1806A67F0
	private void OnValidateProperties() { }

	// RVA: 0x6A6AF0 Offset: 0x6A54F0 VA: 0x1806A6AF0
	private void SetDirty() { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public int get__INTERNAL_LastFrameRendered() { }

	// RVA: 0x6A6F30 Offset: 0x6A5930 VA: 0x1806A6F30
	public void .ctor() { }

	// RVA: 0x6A6EF0 Offset: 0x6A58F0 VA: 0x1806A6EF0
	private static void .cctor() { }
}
