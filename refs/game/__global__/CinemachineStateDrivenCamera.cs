public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 16080
{
	// Fields
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; // 0xA8
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[NoSaveDuringPlay]
	[VcamTargetProperty]
	public Transform m_Follow; // 0xB0
	[NoSaveDuringPlay]
	[Space]
	[Tooltip("The state machine whose state changes will drive this camera's choice of active child")]
	public Animator m_AnimatedTarget; // 0xB8
	[Tooltip("Which layer in the target state machine to observe")]
	[NoSaveDuringPlay]
	public int m_LayerIndex; // 0xC0
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; // 0xC4
	[SerializeField]
	[HideInInspector]
	[NoSaveDuringPlay]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC8
	[Tooltip("The set of instructions associating virtual cameras with states.  These instructions are used to choose the live child at any given moment")]
	public CinemachineStateDrivenCamera.Instruction[] m_Instructions; // 0xD0
	[CinemachineBlendDefinitionProperty]
	[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Camera children")]
	public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
	[Tooltip("This is the asset which contains custom settings for specific child blends")]
	public CinemachineBlenderSettings m_CustomBlends; // 0xE8
	[SerializeField]
	[HideInInspector]
	internal CinemachineStateDrivenCamera.ParentHash[] m_ParentHash; // 0xF0
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xF8
	private ICinemachineCamera m_TransitioningFrom; // 0x100
	private CameraState m_State; // 0x108
	private Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>> mHashCache; // 0x1F0
	private float mActivationTime; // 0x1F8
	private CinemachineStateDrivenCamera.Instruction mActiveInstruction; // 0x200
	private float mPendingActivationTime; // 0x218
	private CinemachineStateDrivenCamera.Instruction mPendingInstruction; // 0x220
	private CinemachineBlend mActiveBlend; // 0x238
	private Dictionary<int, int> mInstructionDictionary; // 0x240
	private Dictionary<int, int> mStateParentLookup; // 0x248
	private List<AnimatorClipInfo> m_clipInfoList; // 0x250

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	public bool IsBlending { get; }
	public CinemachineBlend ActiveBlend { get; }

	// Methods

	// RVA: 0xC045F0 Offset: 0xC02FF0 VA: 0x180C045F0 Slot: 26
	public override string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public ICinemachineCamera get_LiveChild() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	public void set_LiveChild(ICinemachineCamera value) { }

	// RVA: 0xC03290 Offset: 0xC01C90 VA: 0x180C03290 Slot: 28
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xC04730 Offset: 0xC03130 VA: 0x180C04730 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0xBDC7D0 Offset: 0xBDB1D0 VA: 0x180BDC7D0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	// RVA: 0xBDC7B0 Offset: 0xBDB1B0 VA: 0x180BDC7B0 Slot: 31
	public override Transform get_Follow() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xC03C80 Offset: 0xC02680 VA: 0x180C03C80 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xC02920 Offset: 0xC01320 VA: 0x180C02920 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xC03D60 Offset: 0xC02760 VA: 0x180C03D60 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC02B60 Offset: 0xC01560 VA: 0x180C02B60 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC038B0 Offset: 0xC022B0 VA: 0x180C038B0 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xC03780 Offset: 0xC02180 VA: 0x180C03780 Slot: 43
	protected override void OnDisable() { }

	// RVA: 0xC03250 Offset: 0xC01C50 VA: 0x180C03250
	public void OnTransformChildrenChanged() { }

	// RVA: 0xC03B00 Offset: 0xC02500 VA: 0x180C03B00
	private void OnGuiHandler() { }

	// RVA: 0xC045D0 Offset: 0xC02FD0 VA: 0x180C045D0
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0xC04720 Offset: 0xC03120 VA: 0x180C04720
	public bool get_IsBlending() { }

	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	public CinemachineBlend get_ActiveBlend() { }

	// RVA: 0xC028A0 Offset: 0xC012A0 VA: 0x180C028A0
	public static int CreateFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0xC034B0 Offset: 0xC01EB0 VA: 0x180C034B0
	private int LookupFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0xC03250 Offset: 0xC01C50 VA: 0x180C03250
	private void InvalidateListOfChildren() { }

	// RVA: 0xC03E30 Offset: 0xC02830 VA: 0x180C03E30
	private void UpdateListOfChildren() { }

	// RVA: 0xC04030 Offset: 0xC02A30 VA: 0x180C04030
	internal void ValidateInstructions() { }

	// RVA: 0xC02230 Offset: 0xC00C30 VA: 0x180C02230
	private CinemachineVirtualCameraBase ChooseCurrentCamera() { }

	// RVA: 0xC02A20 Offset: 0xC01420 VA: 0x180C02A20
	private int GetClipHash(int hash, List<AnimatorClipInfo> clips) { }

	// RVA: 0xC032C0 Offset: 0xC01CC0 VA: 0x180C032C0
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0xC043B0 Offset: 0xC02DB0 VA: 0x180C043B0
	public void .ctor() { }
}
