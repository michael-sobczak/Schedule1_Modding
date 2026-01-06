public class CinemachineImpulseDefinition // TypeDefIndex: 16209
{
	// Fields
	[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
	[CinemachineImpulseChannelProperty]
	public int m_ImpulseChannel; // 0x10
	[Tooltip("Shape of the impact signal")]
	public CinemachineImpulseDefinition.ImpulseShapes m_ImpulseShape; // 0x14
	[Tooltip("Defines the custom shape of the impact signal that will be generated.")]
	public AnimationCurve m_CustomImpulseShape; // 0x18
	[Tooltip("The time during which the impact signal will occur.  The signal shape will be stretched to fill that time.")]
	public float m_ImpulseDuration; // 0x20
	[Tooltip("How the impulse travels through space and time.")]
	public CinemachineImpulseDefinition.ImpulseTypes m_ImpulseType; // 0x24
	[Tooltip("This defines how the widely signal will spread within the effect radius before dissipating with distance from the impact point")]
	[Range(0, 1)]
	public float m_DissipationRate; // 0x28
	[Header("Signal Shape")]
	[Tooltip("Legacy mode only: Defines the signal that will be generated.")]
	[CinemachineEmbeddedAssetProperty(True)]
	public SignalSourceAsset m_RawSignal; // 0x30
	[Tooltip("Legacy mode only: Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
	public float m_AmplitudeGain; // 0x38
	[Tooltip("Legacy mode only: Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
	public float m_FrequencyGain; // 0x3C
	[Tooltip("Legacy mode only: How to fit the signal into the envelope time")]
	public CinemachineImpulseDefinition.RepeatMode m_RepeatMode; // 0x40
	[Tooltip("Legacy mode only: Randomize the signal start time")]
	public bool m_Randomize; // 0x44
	[Tooltip("Legacy mode only: This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
	public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x48
	[Header("Spatial Range")]
	[Tooltip("Legacy mode only: The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
	public float m_ImpactRadius; // 0x68
	[Tooltip("Legacy mode only: How the signal direction behaves as the listener moves away from the origin.")]
	public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x6C
	[Tooltip("Legacy mode only: This defines how the signal will dissipate with distance beyond the impact radius.")]
	public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x70
	[Tooltip("The signal will have no effect outside this radius surrounding the impact point.")]
	public float m_DissipationDistance; // 0x74
	[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
	public float m_PropagationSpeed; // 0x78
	private static AnimationCurve[] sStandardShapes; // 0x0

	// Properties
	internal AnimationCurve ImpulseCurve { get; }

	// Methods

	// RVA: 0xC2A700 Offset: 0xC29100 VA: 0x180C2A700
	public void OnValidate() { }

	// RVA: 0xC293E0 Offset: 0xC27DE0 VA: 0x180C293E0
	private static void CreateStandardShapes() { }

	// RVA: 0xC2A420 Offset: 0xC28E20 VA: 0x180C2A420
	internal static AnimationCurve GetStandardCurve(CinemachineImpulseDefinition.ImpulseShapes shape) { }

	// RVA: 0xC2A8D0 Offset: 0xC292D0 VA: 0x180C2A8D0
	internal AnimationCurve get_ImpulseCurve() { }

	// RVA: 0xC293A0 Offset: 0xC27DA0 VA: 0x180C293A0
	public void CreateEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0xC29170 Offset: 0xC27B70 VA: 0x180C29170
	public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0xC2A4A0 Offset: 0xC28EA0 VA: 0x180C2A4A0
	private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0xC2A7F0 Offset: 0xC291F0 VA: 0x180C2A7F0
	public void .ctor() { }
}
