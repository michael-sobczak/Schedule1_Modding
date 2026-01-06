public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 16070
{
	// Fields
	public const int MaxCameras = 8;
	[Tooltip("The weight of the first tracked camera")]
	public float m_Weight0; // 0xA8
	[Tooltip("The weight of the second tracked camera")]
	public float m_Weight1; // 0xAC
	[Tooltip("The weight of the third tracked camera")]
	public float m_Weight2; // 0xB0
	[Tooltip("The weight of the fourth tracked camera")]
	public float m_Weight3; // 0xB4
	[Tooltip("The weight of the fifth tracked camera")]
	public float m_Weight4; // 0xB8
	[Tooltip("The weight of the sixth tracked camera")]
	public float m_Weight5; // 0xBC
	[Tooltip("The weight of the seventh tracked camera")]
	public float m_Weight6; // 0xC0
	[Tooltip("The weight of the eighth tracked camera")]
	public float m_Weight7; // 0xC4
	private CameraState m_State; // 0xC8
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private Transform <LookAt>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; // 0x1C0
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x1C8
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x1D0

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0xBF11E0 Offset: 0xBEFBE0 VA: 0x180BF11E0
	public float GetWeight(int index) { }

	// RVA: 0xBF2060 Offset: 0xBF0A60 VA: 0x180BF2060
	public void SetWeight(int index, float w) { }

	// RVA: 0xBF0F90 Offset: 0xBEF990 VA: 0x180BF0F90
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xBF1DE0 Offset: 0xBF07E0 VA: 0x180BF1DE0
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	private ICinemachineCamera get_LiveChild() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	private void set_LiveChild(ICinemachineCamera value) { }

	// RVA: 0xBF2640 Offset: 0xBF1040 VA: 0x180BF2640 Slot: 27
	public override CameraState get_State() { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970 Slot: 29
	public override Transform get_LookAt() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0 Slot: 30
	public override void set_LookAt(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980 Slot: 31
	public override Transform get_Follow() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xBF1B40 Offset: 0xBF0540 VA: 0x180BF1B40 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBF0E90 Offset: 0xBEF890 VA: 0x180BF0E90 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBF1AE0 Offset: 0xBF04E0 VA: 0x180BF1AE0 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xBF19C0 Offset: 0xBF03C0 VA: 0x180BF19C0
	public void OnTransformChildrenChanged() { }

	// RVA: 0xBF1D80 Offset: 0xBF0780 VA: 0x180BF1D80 Slot: 41
	protected override void OnValidate() { }

	// RVA: 0xBF1A20 Offset: 0xBF0420 VA: 0x180BF1A20 Slot: 28
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xBF2610 Offset: 0xBF1010 VA: 0x180BF2610
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0xBF19C0 Offset: 0xBF03C0 VA: 0x180BF19C0
	protected void InvalidateListOfChildren() { }

	// RVA: 0xBF21D0 Offset: 0xBF0BD0 VA: 0x180BF21D0
	protected void ValidateListOfChildren() { }

	// RVA: 0xBF1C20 Offset: 0xBF0620 VA: 0x180BF1C20 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBF1310 Offset: 0xBEFD10 VA: 0x180BF1310 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBF2440 Offset: 0xBF0E40 VA: 0x180BF2440
	public void .ctor() { }
}
