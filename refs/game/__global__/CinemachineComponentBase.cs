public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 16135
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x20

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }
	public Transform FollowTarget { get; }
	public Transform LookAtTarget { get; }
	public ICinemachineTargetGroup AbstractFollowTargetGroup { get; }
	public CinemachineTargetGroup FollowTargetGroup { get; }
	public Vector3 FollowTargetPosition { get; }
	public Quaternion FollowTargetRotation { get; }
	public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; }
	public CinemachineTargetGroup LookAtTargetGroup { get; }
	public Vector3 LookAtTargetPosition { get; }
	public Quaternion LookAtTargetRotation { get; }
	public CameraState VcamState { get; }
	public abstract bool IsValid { get; }
	public abstract CinemachineCore.Stage Stage { get; }
	public virtual bool BodyAppliesAfterAim { get; }
	public virtual bool RequiresUserInput { get; }

	// Methods

	// RVA: 0xC174E0 Offset: 0xC15EE0 VA: 0x180C174E0
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0xC16DA0 Offset: 0xC157A0 VA: 0x180C16DA0
	public Transform get_FollowTarget() { }

	// RVA: 0xC172F0 Offset: 0xC15CF0 VA: 0x180C172F0
	public Transform get_LookAtTarget() { }

	// RVA: 0xC16800 Offset: 0xC15200 VA: 0x180C16800
	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	// RVA: 0xC168B0 Offset: 0xC152B0 VA: 0x180C168B0
	public CinemachineTargetGroup get_FollowTargetGroup() { }

	// RVA: 0xC16990 Offset: 0xC15390 VA: 0x180C16990
	public Vector3 get_FollowTargetPosition() { }

	// RVA: 0xC16BB0 Offset: 0xC155B0 VA: 0x180C16BB0
	public Quaternion get_FollowTargetRotation() { }

	// RVA: 0xC16880 Offset: 0xC15280 VA: 0x180C16880
	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	// RVA: 0xC16E40 Offset: 0xC15840 VA: 0x180C16E40
	public CinemachineTargetGroup get_LookAtTargetGroup() { }

	// RVA: 0xC16ED0 Offset: 0xC158D0 VA: 0x180C16ED0
	public Vector3 get_LookAtTargetPosition() { }

	// RVA: 0xC17100 Offset: 0xC15B00 VA: 0x180C17100
	public Quaternion get_LookAtTargetRotation() { }

	// RVA: 0xC17390 Offset: 0xC15D90 VA: 0x180C17390
	public CameraState get_VcamState() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsValid();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract CinemachineCore.Stage get_Stage();

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public virtual bool get_BodyAppliesAfterAim() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 12
	public virtual float GetMaxDampTime() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	public virtual bool get_RequiresUserInput() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
