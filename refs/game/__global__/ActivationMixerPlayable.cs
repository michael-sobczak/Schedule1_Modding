internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 17352
{
	// Fields
	private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0x10
	private bool m_BoundGameObjectInitialStateIsActive; // 0x14
	private GameObject m_BoundGameObject; // 0x18

	// Properties
	public ActivationTrack.PostPlaybackState postPlaybackState { get; set; }

	// Methods

	// RVA: 0x2C3AB60 Offset: 0x2C39560 VA: 0x182C3AB60
	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public ActivationTrack.PostPlaybackState get_postPlaybackState() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_postPlaybackState(ActivationTrack.PostPlaybackState value) { }

	// RVA: 0x2C3AC00 Offset: 0x2C39600 VA: 0x182C3AC00 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x2C3ACD0 Offset: 0x2C396D0 VA: 0x182C3ACD0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
