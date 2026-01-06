public class CinemachineIndependentImpulseListener : MonoBehaviour // TypeDefIndex: 16220
{
	// Fields
	private Vector3 impulsePosLastFrame; // 0x20
	private Quaternion impulseRotLastFrame; // 0x2C
	[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
	[CinemachineImpulseChannelProperty]
	public int m_ChannelMask; // 0x3C
	[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
	public float m_Gain; // 0x40
	[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
	public bool m_Use2DDistance; // 0x44
	[Tooltip("Enable this to process all impulse signals in camera space")]
	public bool m_UseLocalSpace; // 0x45
	[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
	public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings; // 0x48

	// Methods

	// RVA: 0xC2C480 Offset: 0xC2AE80 VA: 0x180C2C480
	private void Reset() { }

	// RVA: 0xC2C400 Offset: 0xC2AE00 VA: 0x180C2C400
	private void OnEnable() { }

	// RVA: 0xC2C500 Offset: 0xC2AF00 VA: 0x180C2C500
	private void Update() { }

	// RVA: 0xC2BE90 Offset: 0xC2A890 VA: 0x180C2BE90
	private void LateUpdate() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
