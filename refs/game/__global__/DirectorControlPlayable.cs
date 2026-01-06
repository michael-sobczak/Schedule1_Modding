public class DirectorControlPlayable : PlayableBehaviour // TypeDefIndex: 17431
{
	// Fields
	public PlayableDirector director; // 0x10
	private bool m_SyncTime; // 0x18
	private double m_AssetDuration; // 0x20

	// Methods

	// RVA: 0x2C45AC0 Offset: 0x2C444C0 VA: 0x182C45AC0
	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) { }

	// RVA: 0x2C46040 Offset: 0x2C44A40 VA: 0x182C46040 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x2C460F0 Offset: 0x2C44AF0 VA: 0x182C460F0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2C45F60 Offset: 0x2C44960 VA: 0x182C45F60 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2C45E80 Offset: 0x2C44880 VA: 0x182C45E80 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2C46540 Offset: 0x2C44F40 VA: 0x182C46540 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2C46940 Offset: 0x2C45340 VA: 0x182C46940
	private void SyncSpeed(double speed) { }

	// RVA: 0x2C46AB0 Offset: 0x2C454B0 VA: 0x182C46AB0
	private void SyncStart(PlayableGraph graph, double time) { }

	// RVA: 0x2C46B70 Offset: 0x2C45570 VA: 0x182C46B70
	private void SyncStop(PlayableGraph graph, double time) { }

	// RVA: 0x2C45C00 Offset: 0x2C44600 VA: 0x182C45C00
	private bool DetectDiscontinuity(Playable playable, FrameData info) { }

	// RVA: 0x2C45D20 Offset: 0x2C44720 VA: 0x182C45D20
	private bool DetectOutOfSync(Playable playable) { }

	// RVA: 0x2C46C40 Offset: 0x2C45640 VA: 0x182C46C40
	private void UpdateTime(Playable playable) { }

	// RVA: 0x2C46DE0 Offset: 0x2C457E0 VA: 0x182C46DE0
	public void .ctor() { }
}
