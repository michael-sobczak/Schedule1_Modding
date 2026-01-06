public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 16211
{
	// Fields
	[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x30
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	[CinemachineImpulseChannelProperty]
	public int m_ChannelMask; // 0x34
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float m_Gain; // 0x38
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool m_Use2DDistance; // 0x3C
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool m_UseCameraSpace; // 0x3D
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings; // 0x40

	// Methods

	// RVA: 0xC2AF00 Offset: 0xC29900 VA: 0x180C2AF00
	private void Reset() { }

	// RVA: 0xC2A990 Offset: 0xC29390 VA: 0x180C2A990 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xC2AF80 Offset: 0xC29980 VA: 0x180C2AF80
	public void .ctor() { }
}
