public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 17456
{
	// Fields
	private IntervalTree<RuntimeElement> m_IntervalTree; // 0x10
	private List<RuntimeElement> m_ActiveClips; // 0x18
	private List<RuntimeElement> m_CurrentListOfActiveClips; // 0x20
	private int m_ActiveBit; // 0x28
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x30
	private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0x38
	internal static bool muteAudioScrubbing; // 0x0

	// Methods

	// RVA: 0x2C60E00 Offset: 0x2C5F800 VA: 0x182C60E00
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x2C60070 Offset: 0x2C5EA70 VA: 0x182C60070
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x2C5FDE0 Offset: 0x2C5E7E0 VA: 0x182C5FDE0
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	// RVA: 0x2C60350 Offset: 0x2C5ED50 VA: 0x182C60350
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	// RVA: 0x2C61170 Offset: 0x2C5FB70 VA: 0x182C61170
	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x2C61080 Offset: 0x2C5FA80 VA: 0x182C61080
	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x2C60920 Offset: 0x2C5F320 VA: 0x182C60920
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	// RVA: 0x2C61900 Offset: 0x2C60300 VA: 0x182C61900 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2C61260 Offset: 0x2C5FC60 VA: 0x182C61260
	private void Evaluate(Playable playable, FrameData frameData) { }

	// RVA: 0x2C5FD70 Offset: 0x2C5E770 VA: 0x182C5FD70
	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	// RVA: 0x2C618B0 Offset: 0x2C602B0 VA: 0x182C618B0
	private static void ForAOTCompilationOnly() { }

	// RVA: 0x2C61990 Offset: 0x2C60390 VA: 0x182C61990
	public void .ctor() { }

	// RVA: 0x2C61950 Offset: 0x2C60350 VA: 0x182C61950
	private static void .cctor() { }
}
