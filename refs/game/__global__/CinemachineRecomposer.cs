public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 16027
{
	// Fields
	[Tooltip("When to apply the adjustment")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x30
	[Tooltip("Tilt the camera by this much")]
	public float m_Tilt; // 0x34
	[Tooltip("Pan the camera by this much")]
	public float m_Pan; // 0x38
	[Tooltip("Roll the camera by this much")]
	public float m_Dutch; // 0x3C
	[Tooltip("Scale the zoom by this amount (normal = 1)")]
	public float m_ZoomScale; // 0x40
	[Range(0, 1)]
	[Tooltip("Lowering this value relaxes the camera's attention to the Follow target (normal = 1)")]
	public float m_FollowAttachment; // 0x44
	[Range(0, 1)]
	[Tooltip("Lowering this value relaxes the camera's attention to the LookAt target (normal = 1)")]
	public float m_LookAtAttachment; // 0x48

	// Methods

	// RVA: 0xBF3A70 Offset: 0xBF2470 VA: 0x180BF3A70
	private void Reset() { }

	// RVA: 0xBF34F0 Offset: 0xBF1EF0 VA: 0x180BF34F0
	private void OnValidate() { }

	// RVA: 0xBF3A50 Offset: 0xBF2450 VA: 0x180BF3A50 Slot: 8
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF3550 Offset: 0xBF1F50 VA: 0x180BF3550 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
