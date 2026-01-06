public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 16049
{
	// Fields
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; // 0xA8
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
	[NoSaveDuringPlay]
	[VcamTargetProperty]
	public Transform m_Follow; // 0xB0
	[NoSaveDuringPlay]
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; // 0xB8
	[NoSaveDuringPlay]
	[HideInInspector]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
	[Tooltip("Wait this many seconds before activating a new child camera")]
	public float m_ActivateAfter; // 0xC8
	[Tooltip("An active camera must be active for at least this many seconds")]
	public float m_MinDuration; // 0xCC
	[Tooltip("If checked, camera choice will be randomized if multiple cameras are equally desirable.  Otherwise, child list order and child camera priority will be used.")]
	public bool m_RandomizeChoice; // 0xD0
	[CinemachineBlendDefinitionProperty]
	[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Cameras")]
	public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
	[HideInInspector]
	public CinemachineBlenderSettings m_CustomBlends; // 0xE8
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xF0
	private CameraState m_State; // 0xF8
	private float mActivationTime; // 0x1E0
	private float mPendingActivationTime; // 0x1E4
	private ICinemachineCamera mPendingCamera; // 0x1E8
	private CinemachineBlend mActiveBlend; // 0x1F0
	private bool mRandomizeNow; // 0x1F8
	private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x200
	private ICinemachineCamera m_TransitioningFrom; // 0x208

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool IsBlending { get; }
	public CinemachineBlend ActiveBlend { get; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0xBE2F00 Offset: 0xBE1900 VA: 0x180BE2F00 Slot: 26
	public override string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public ICinemachineCamera get_LiveChild() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_LiveChild(ICinemachineCamera value) { }

	// RVA: 0xBE3030 Offset: 0xBE1A30 VA: 0x180BE3030 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0xBE1E50 Offset: 0xBE0850 VA: 0x180BE1E50 Slot: 28
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xBDC7D0 Offset: 0xBDB1D0 VA: 0x180BDC7D0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	// RVA: 0xBDC7B0 Offset: 0xBDB1B0 VA: 0x180BDC7B0 Slot: 31
	public override Transform get_Follow() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xBE2580 Offset: 0xBE0F80 VA: 0x180BE2580 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBE16B0 Offset: 0xBE00B0 VA: 0x180BE16B0 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBE17B0 Offset: 0xBE01B0 VA: 0x180BE17B0 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBE21A0 Offset: 0xBE0BA0 VA: 0x180BE21A0 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xBE2070 Offset: 0xBE0A70 VA: 0x180BE2070 Slot: 43
	protected override void OnDisable() { }

	// RVA: 0xBE2660 Offset: 0xBE1060 VA: 0x180BE2660
	public void OnTransformChildrenChanged() { }

	// RVA: 0xBE2400 Offset: 0xBE0E00 VA: 0x180BE2400
	private void OnGuiHandler() { }

	// RVA: 0x7262B0 Offset: 0x724CB0 VA: 0x1807262B0
	public bool get_IsBlending() { }

	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public CinemachineBlend get_ActiveBlend() { }

	// RVA: 0xBE2EE0 Offset: 0xBE18E0 VA: 0x180BE2EE0
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0xBE1DF0 Offset: 0xBE07F0 VA: 0x180BE1DF0
	private void InvalidateListOfChildren() { }

	// RVA: 0xBE2AD0 Offset: 0xBE14D0 VA: 0x180BE2AD0
	public void ResetRandomization() { }

	// RVA: 0xBE2B00 Offset: 0xBE1500 VA: 0x180BE2B00
	private void UpdateListOfChildren() { }

	// RVA: 0xBE0E30 Offset: 0xBDF830 VA: 0x180BE0E30
	private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) { }

	// RVA: 0xBE27E0 Offset: 0xBE11E0 VA: 0x180BE27E0
	private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) { }

	// RVA: 0xBE1E80 Offset: 0xBE0880 VA: 0x180BE1E80
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0xBE26D0 Offset: 0xBE10D0 VA: 0x180BE26D0 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBE2D20 Offset: 0xBE1720 VA: 0x180BE2D20
	public void .ctor() { }
}
