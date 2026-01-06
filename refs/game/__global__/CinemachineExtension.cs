public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 16144
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x20
	private Dictionary<ICinemachineCamera, object> mExtraState; // 0x28

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }
	public virtual bool RequiresUserInput { get; }

	// Methods

	// RVA: 0xC19F20 Offset: 0xC18920 VA: 0x180C19F20
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0x95E000 Offset: 0x95CA00 VA: 0x18095E000 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x971D10 Offset: 0x970710 VA: 0x180971D10 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x95E000 Offset: 0x95CA00 VA: 0x18095E000
	internal void EnsureStarted() { }

	// RVA: 0xC19DB0 Offset: 0xC187B0 VA: 0x180C19DB0 Slot: 7
	protected virtual void ConnectToVcam(bool connect) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0xC19F00 Offset: 0xC18900 VA: 0x180C19F00
	public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 13
	public virtual float GetMaxDampTime() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public virtual bool get_RequiresUserInput() { }

	// RVA: -1 Offset: -1
	protected T GetExtraState<T>(ICinemachineCamera vcam) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE60300 Offset: 0xE5ED00 VA: 0x180E60300
	|-CinemachineExtension.GetExtraState<object>
	*/

	// RVA: -1 Offset: -1
	protected List<T> GetAllExtraStates<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE60090 Offset: 0xE5EA90 VA: 0x180E60090
	|-CinemachineExtension.GetAllExtraStates<object>
	*/

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
