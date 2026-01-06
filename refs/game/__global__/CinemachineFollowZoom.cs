public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 16063
{
	// Fields
	[Tooltip("The shot width to maintain, in world units, at target distance.")]
	public float m_Width; // 0x30
	[Tooltip("Increase this value to soften the aggressiveness of the follow-zoom.  Small numbers are more responsive, larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_Damping; // 0x34
	[Range(1, 179)]
	[Tooltip("Lower limit for the FOV that this behaviour will generate.")]
	public float m_MinFOV; // 0x38
	[Range(1, 179)]
	[Tooltip("Upper limit for the FOV that this behaviour will generate.")]
	public float m_MaxFOV; // 0x3C

	// Methods

	// RVA: 0xBEB0A0 Offset: 0xBE9AA0 VA: 0x180BEB0A0
	private void OnValidate() { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0xBEB100 Offset: 0xBE9B00 VA: 0x180BEB100 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBEB4D0 Offset: 0xBE9ED0 VA: 0x180BEB4D0
	public void .ctor() { }
}
