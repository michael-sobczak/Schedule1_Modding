public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 16026
{
	// Fields
	[Tooltip("Offset the camera's position by this much (camera space)")]
	public Vector3 m_Offset; // 0x30
	[Tooltip("When to apply the offset")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x3C
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition; // 0x40

	// Methods

	// RVA: 0xBE0AA0 Offset: 0xBDF4A0 VA: 0x180BE0AA0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBE0DD0 Offset: 0xBDF7D0 VA: 0x180BE0DD0
	public void .ctor() { }
}
