public class ActivationControlPlayable : PlayableBehaviour // TypeDefIndex: 17429
{
	// Fields
	public GameObject gameObject; // 0x10
	public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x18
	private ActivationControlPlayable.InitialState m_InitialState; // 0x1C

	// Methods

	// RVA: 0x2C3A700 Offset: 0x2C39100 VA: 0x182C3A700
	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlaybackState) { }

	// RVA: 0x2C3A8F0 Offset: 0x2C392F0 VA: 0x182C3A8F0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2C3A850 Offset: 0x2C39250 VA: 0x182C3A850 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2C3AAD0 Offset: 0x2C394D0 VA: 0x182C3AAD0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object userData) { }

	// RVA: 0x2C3A970 Offset: 0x2C39370 VA: 0x182C3A970 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x2C3AA00 Offset: 0x2C39400 VA: 0x182C3AA00 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x2C3AB50 Offset: 0x2C39550 VA: 0x182C3AB50
	public void .ctor() { }
}
