public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver // TypeDefIndex: 8651
{
	// Fields
	[SerializeField]
	private int m_AssetsPPU; // 0x20
	[SerializeField]
	private int m_RefResolutionX; // 0x24
	[SerializeField]
	private int m_RefResolutionY; // 0x28
	[SerializeField]
	private PixelPerfectCamera.CropFrame m_CropFrame; // 0x2C
	[SerializeField]
	private PixelPerfectCamera.GridSnapping m_GridSnapping; // 0x30
	[SerializeField]
	private PixelPerfectCamera.PixelPerfectFilterMode m_FilterMode; // 0x34
	private Camera m_Camera; // 0x38
	private PixelPerfectCameraInternal m_Internal; // 0x40
	private bool m_CinemachineCompatibilityMode; // 0x48

	// Properties
	public PixelPerfectCamera.CropFrame cropFrame { get; set; }
	public PixelPerfectCamera.GridSnapping gridSnapping { get; set; }
	public float orthographicSize { get; }
	public int assetsPPU { get; set; }
	public int refResolutionX { get; set; }
	public int refResolutionY { get; set; }
	[Obsolete("Use gridSnapping instead", False)]
	public bool upscaleRT { get; set; }
	[Obsolete("Use gridSnapping instead", False)]
	public bool pixelSnapping { get; set; }
	[Obsolete("Use cropFrame instead", False)]
	public bool cropFrameX { get; set; }
	[Obsolete("Use cropFrame instead", False)]
	public bool cropFrameY { get; set; }
	[Obsolete("Use cropFrame instead", False)]
	public bool stretchFill { get; set; }
	public int pixelRatio { get; }
	public bool requiresUpscalePass { get; }
	internal FilterMode finalBlitFilterMode { get; }
	internal Vector2Int offscreenRTSize { get; }
	private Vector2Int cameraRTSize { get; }

	// Methods

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public PixelPerfectCamera.CropFrame get_cropFrame() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_cropFrame(PixelPerfectCamera.CropFrame value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public PixelPerfectCamera.GridSnapping get_gridSnapping() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_gridSnapping(PixelPerfectCamera.GridSnapping value) { }

	// RVA: 0x2A747A0 Offset: 0x2A731A0 VA: 0x182A747A0
	public float get_orthographicSize() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 4
	public int get_assetsPPU() { }

	// RVA: 0x2A74830 Offset: 0x2A73230 VA: 0x182A74830 Slot: 5
	public void set_assetsPPU(int value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 6
	public int get_refResolutionX() { }

	// RVA: 0x2A74900 Offset: 0x2A73300 VA: 0x182A74900 Slot: 7
	public void set_refResolutionX(int value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 8
	public int get_refResolutionY() { }

	// RVA: 0x2A74930 Offset: 0x2A73330 VA: 0x182A74930 Slot: 9
	public void set_refResolutionY(int value) { }

	// RVA: 0x6975E0 Offset: 0x695FE0 VA: 0x1806975E0 Slot: 10
	public bool get_upscaleRT() { }

	// RVA: 0x2A74970 Offset: 0x2A73370 VA: 0x182A74970 Slot: 11
	public void set_upscaleRT(bool value) { }

	// RVA: 0x24F8540 Offset: 0x24F6F40 VA: 0x1824F8540 Slot: 12
	public bool get_pixelSnapping() { }

	// RVA: 0x2A748E0 Offset: 0x2A732E0 VA: 0x182A748E0 Slot: 13
	public void set_pixelSnapping(bool value) { }

	// RVA: 0x2A74720 Offset: 0x2A73120 VA: 0x182A74720 Slot: 14
	public bool get_cropFrameX() { }

	// RVA: 0x2A74860 Offset: 0x2A73260 VA: 0x182A74860 Slot: 15
	public void set_cropFrameX(bool value) { }

	// RVA: 0x2A74740 Offset: 0x2A73140 VA: 0x182A74740 Slot: 16
	public bool get_cropFrameY() { }

	// RVA: 0x2A748A0 Offset: 0x2A732A0 VA: 0x182A748A0 Slot: 17
	public void set_cropFrameY(bool value) { }

	// RVA: 0x2A74820 Offset: 0x2A73220 VA: 0x182A74820 Slot: 18
	public bool get_stretchFill() { }

	// RVA: 0x2A74960 Offset: 0x2A73360 VA: 0x182A74960 Slot: 19
	public void set_stretchFill(bool value) { }

	// RVA: 0x2A747C0 Offset: 0x2A731C0 VA: 0x182A747C0
	public int get_pixelRatio() { }

	// RVA: 0x2A74800 Offset: 0x2A73200 VA: 0x182A74800
	public bool get_requiresUpscalePass() { }

	// RVA: 0x2A743D0 Offset: 0x2A72DD0 VA: 0x182A743D0
	public Vector3 RoundToPixel(Vector3 position) { }

	// RVA: 0x2A73C90 Offset: 0x2A72690 VA: 0x182A73C90
	public float CorrectCinemachineOrthoSize(float targetOrthoSize) { }

	// RVA: 0x2A74760 Offset: 0x2A73160 VA: 0x182A74760
	internal FilterMode get_finalBlitFilterMode() { }

	// RVA: 0x2A74770 Offset: 0x2A73170 VA: 0x182A74770
	internal Vector2Int get_offscreenRTSize() { }

	// RVA: 0x2A74650 Offset: 0x2A73050 VA: 0x182A74650
	private Vector2Int get_cameraRTSize() { }

	// RVA: 0x2A73FC0 Offset: 0x2A729C0 VA: 0x182A73FC0
	private void PixelSnap() { }

	// RVA: 0x2A73BF0 Offset: 0x2A725F0 VA: 0x182A73BF0
	private void Awake() { }

	// RVA: 0x2A744B0 Offset: 0x2A72EB0 VA: 0x182A744B0
	private void UpdateCameraProperties() { }

	// RVA: 0x2A73CB0 Offset: 0x2A726B0 VA: 0x182A73CB0
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2A73F50 Offset: 0x2A72950 VA: 0x182A73F50
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2A73E80 Offset: 0x2A72880 VA: 0x182A73E80
	private void OnEnable() { }

	// RVA: 0x2A73D70 Offset: 0x2A72770 VA: 0x182A73D70
	internal void OnDisable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public void OnBeforeSerialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public void OnAfterDeserialize() { }

	// RVA: 0x2A74630 Offset: 0x2A73030 VA: 0x182A74630
	public void .ctor() { }
}
