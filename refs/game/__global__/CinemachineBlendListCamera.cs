public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 16038
{
	// Fields
	[VcamTargetProperty]
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	public Transform m_LookAt; // 0xA8
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	[NoSaveDuringPlay]
	public Transform m_Follow; // 0xB0
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; // 0xB8
	[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
	public bool m_Loop; // 0xB9
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
	[Tooltip("The set of instructions for enabling child cameras.")]
	public CinemachineBlendListCamera.Instruction[] m_Instructions; // 0xC8
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xD0
	private ICinemachineCamera m_TransitioningFrom; // 0xD8
	private CameraState m_State; // 0xE0
	private float mActivationTime; // 0x1C8
	private int mCurrentInstruction; // 0x1CC
	private CinemachineBlend mActiveBlend; // 0x1D0

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	public bool IsBlending { get; }

	// Methods

	// RVA: 0xBDC680 Offset: 0xBDB080 VA: 0x180BDC680 Slot: 26
	public override string get_Description() { }

	// RVA: 0xBDC040 Offset: 0xBDAA40 VA: 0x180BDC040
	private void Reset() { }

	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public ICinemachineCamera get_LiveChild() { }

	[CompilerGenerated]
	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	public void set_LiveChild(ICinemachineCamera value) { }

	// RVA: 0xBDB8D0 Offset: 0xBDA2D0 VA: 0x180BDB8D0 Slot: 28
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xBDC7E0 Offset: 0xBDB1E0 VA: 0x180BDC7E0 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0xBDC7D0 Offset: 0xBDB1D0 VA: 0x180BDC7D0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	// RVA: 0xBDC7B0 Offset: 0xBDB1B0 VA: 0x180BDC7B0 Slot: 31
	public override Transform get_Follow() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xBDBE10 Offset: 0xBDA810 VA: 0x180BDBE10 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBDB1A0 Offset: 0xBD9BA0 VA: 0x180BDB1A0 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBDBEF0 Offset: 0xBDA8F0 VA: 0x180BDBEF0 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBDB2A0 Offset: 0xBD9CA0 VA: 0x180BDB2A0 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBDBA30 Offset: 0xBDA430 VA: 0x180BDBA30 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xBDB900 Offset: 0xBDA300 VA: 0x180BDB900 Slot: 43
	protected override void OnDisable() { }

	// RVA: 0xBDB890 Offset: 0xBDA290 VA: 0x180BDB890
	private void OnTransformChildrenChanged() { }

	// RVA: 0xBDBC90 Offset: 0xBDA690 VA: 0x180BDBC90
	private void OnGuiHandler() { }

	// RVA: 0xBDC660 Offset: 0xBDB060 VA: 0x180BDC660
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0xBDC7C0 Offset: 0xBDB1C0 VA: 0x180BDC7C0
	public bool get_IsBlending() { }

	// RVA: 0xBDB890 Offset: 0xBDA290 VA: 0x180BDB890
	private void InvalidateListOfChildren() { }

	// RVA: 0xBDC0C0 Offset: 0xBDAAC0 VA: 0x180BDC0C0
	private void UpdateListOfChildren() { }

	// RVA: 0xBDC2A0 Offset: 0xBDACA0 VA: 0x180BDC2A0
	internal void ValidateInstructions() { }

	// RVA: 0xBDAF80 Offset: 0xBD9980 VA: 0x180BDAF80
	private void AdvanceCurrentInstruction(float deltaTime) { }

	// RVA: 0xBDC4D0 Offset: 0xBDAED0 VA: 0x180BDC4D0
	public void .ctor() { }
}
