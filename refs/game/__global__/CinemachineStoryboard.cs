public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 16084
{
	// Fields
	[Tooltip("If checked, all storyboards are globally muted")]
	public static bool s_StoryboardGlobalMute; // 0x0
	[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera's output")]
	public bool m_ShowImage; // 0x30
	[Tooltip("The image to display")]
	public Texture m_Image; // 0x38
	[Tooltip("How to handle differences between image aspect and screen aspect")]
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x40
	[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
	[Range(0, 1)]
	public float m_Alpha; // 0x44
	[Tooltip("The screen-space position at which to display the image.  Zero is center")]
	public Vector2 m_Center; // 0x48
	[Tooltip("The screen-space rotation to apply to the image")]
	public Vector3 m_Rotation; // 0x50
	[Tooltip("The screen-space scaling to apply to the image")]
	public Vector2 m_Scale; // 0x5C
	[Tooltip("If checked, X and Y scale are synchronized")]
	public bool m_SyncScale; // 0x64
	[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
	public bool m_MuteCamera; // 0x65
	[Tooltip("Wipe the image on and off horizontally")]
	[Range(-1, 1)]
	public float m_SplitView; // 0x68
	[Tooltip("The render mode of the canvas on which the storyboard is drawn.")]
	public CinemachineStoryboard.StoryboardRenderMode m_RenderMode; // 0x6C
	[Tooltip("Allows ordering canvases to render on top or below other canvases.")]
	public int m_SortingOrder; // 0x70
	[Tooltip("How far away from the camera is the Canvas generated.")]
	public float m_PlaneDistance; // 0x74
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x78

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0xC05FA0 Offset: 0xC049A0 VA: 0x180C05FA0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xC063D0 Offset: 0xC04DD0 VA: 0x180C063D0
	private void UpdateRenderCanvas() { }

	// RVA: 0xC049A0 Offset: 0xC033A0 VA: 0x180C049A0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0xC066F0 Offset: 0xC050F0 VA: 0x180C066F0
	private string get_CanvasName() { }

	// RVA: 0xC047D0 Offset: 0xC031D0 VA: 0x180C047D0
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0xC053E0 Offset: 0xC03DE0 VA: 0x180C053E0
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0xC04B10 Offset: 0xC03510 VA: 0x180C04B10
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0xC05070 Offset: 0xC03A70 VA: 0x180C05070
	private void DestroyCanvas() { }

	// RVA: 0xC05880 Offset: 0xC04280 VA: 0x180C05880
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0xC060B0 Offset: 0xC04AB0 VA: 0x180C060B0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC052C0 Offset: 0xC03CC0 VA: 0x180C052C0
	private static void InitializeModule() { }

	// RVA: 0xC065A0 Offset: 0xC04FA0 VA: 0x180C065A0
	public void .ctor() { }
}
