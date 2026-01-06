public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 17383
{
	// Fields
	private const int k_LatestVersion = 0;
	[HideInInspector]
	[SerializeField]
	private int m_Version; // 0x18
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Tracks; // 0x20
	[HideInInspector]
	[SerializeField]
	private double m_FixedDuration; // 0x28
	[HideInInspector]
	private TrackAsset[] m_CacheOutputTracks; // 0x30
	[HideInInspector]
	private List<TrackAsset> m_CacheRootTracks; // 0x38
	[HideInInspector]
	private TrackAsset[] m_CacheFlattenedTracks; // 0x40
	[HideInInspector]
	[SerializeField]
	private TimelineAsset.EditorSettings m_EditorSettings; // 0x48
	[SerializeField]
	private TimelineAsset.DurationMode m_DurationMode; // 0x50
	[HideInInspector]
	[SerializeField]
	private MarkerTrack m_MarkerTrack; // 0x58

	// Properties
	public TimelineAsset.EditorSettings editorSettings { get; }
	public override double duration { get; }
	public double fixedDuration { get; set; }
	public TimelineAsset.DurationMode durationMode { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }
	public int outputTrackCount { get; }
	public int rootTrackCount { get; }
	internal TrackAsset[] flattenedTracks { get; }
	public MarkerTrack markerTrack { get; }
	internal List<ScriptableObject> trackObjects { get; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpgradeToLatestVersion() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public TimelineAsset.EditorSettings get_editorSettings() { }

	// RVA: 0x2C4DD40 Offset: 0x2C4C740 VA: 0x182C4DD40 Slot: 7
	public override double get_duration() { }

	// RVA: 0x2C4DE10 Offset: 0x2C4C810 VA: 0x182C4DE10
	public double get_fixedDuration() { }

	// RVA: 0x2C4E190 Offset: 0x2C4CB90 VA: 0x182C4E190
	public void set_fixedDuration(double value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public TimelineAsset.DurationMode get_durationMode() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_durationMode(TimelineAsset.DurationMode value) { }

	[IteratorStateMachine(typeof(TimelineAsset.<get_outputs>d__27))]
	// RVA: 0x2C4E0C0 Offset: 0x2C4CAC0 VA: 0x182C4E0C0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C4DB90 Offset: 0x2C4C590 VA: 0x182C4DB90 Slot: 11
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2C4E090 Offset: 0x2C4CA90 VA: 0x182C4E090
	public int get_outputTrackCount() { }

	// RVA: 0x2C4E140 Offset: 0x2C4CB40 VA: 0x182C4E140
	public int get_rootTrackCount() { }

	// RVA: 0x2C4D1E0 Offset: 0x2C4BBE0 VA: 0x182C4D1E0
	private void OnValidate() { }

	// RVA: 0x2C4CE60 Offset: 0x2C4B860 VA: 0x182C4CE60
	public TrackAsset GetRootTrack(int index) { }

	// RVA: 0x2C4CEC0 Offset: 0x2C4B8C0 VA: 0x182C4CEC0
	public IEnumerable<TrackAsset> GetRootTracks() { }

	// RVA: 0x2C4CDF0 Offset: 0x2C4B7F0 VA: 0x182C4CDF0
	public TrackAsset GetOutputTrack(int index) { }

	// RVA: 0x2C4CE40 Offset: 0x2C4B840 VA: 0x182C4CE40
	public IEnumerable<TrackAsset> GetOutputTracks() { }

	// RVA: 0x2C4CEE0 Offset: 0x2C4B8E0 VA: 0x182C4CEE0
	private static double GetValidFrameRate(double frameRate) { }

	// RVA: 0x2C4D690 Offset: 0x2C4C090 VA: 0x182C4D690
	private void UpdateRootTrackCache() { }

	// RVA: 0x2C4D490 Offset: 0x2C4BE90 VA: 0x182C4D490
	private void UpdateOutputTrackCache() { }

	// RVA: 0x2C4DF20 Offset: 0x2C4C920 VA: 0x182C4DF20
	internal TrackAsset[] get_flattenedTracks() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public MarkerTrack get_markerTrack() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal List<ScriptableObject> get_trackObjects() { }

	// RVA: 0x2C4B470 Offset: 0x2C49E70 VA: 0x182C4B470
	internal void AddTrackInternal(TrackAsset track) { }

	// RVA: 0x2C4D220 Offset: 0x2C4BC20 VA: 0x182C4D220
	internal void RemoveTrack(TrackAsset track) { }

	// RVA: 0x2C4BBA0 Offset: 0x2C4A5A0 VA: 0x182C4BBA0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0xBCB890 Offset: 0xBCA290 VA: 0x180BCB890 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2C4D3A0 Offset: 0x2C4BDA0 VA: 0x182C4D3A0 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2C4D950 Offset: 0x2C4C350 VA: 0x182C4D950
	private void __internalAwake() { }

	// RVA: 0x2C4CBF0 Offset: 0x2C4B5F0 VA: 0x182C4CBF0 Slot: 12
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C4BA90 Offset: 0x2C4A490 VA: 0x182C4BA90
	public void CreateMarkerTrack() { }

	// RVA: 0x2C4CF90 Offset: 0x2C4B990 VA: 0x182C4CF90
	internal void Invalidate() { }

	// RVA: 0x2C4D3F0 Offset: 0x2C4BDF0 VA: 0x182C4D3F0
	internal void UpdateFixedDurationWithItemsDuration() { }

	// RVA: 0x2C4B820 Offset: 0x2C4A220 VA: 0x182C4B820
	private DiscreteTime CalculateItemsDuration() { }

	// RVA: 0x2C4B230 Offset: 0x2C49C30 VA: 0x182C4B230
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) { }

	// RVA: 0x2C4BD90 Offset: 0x2C4A790 VA: 0x182C4BD90
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(TrackAsset parent, string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61380 Offset: 0xF5FD80 VA: 0x180F61380
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>(string trackName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61550 Offset: 0xF5FF50 VA: 0x180F61550
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: -1 Offset: -1
	public T CreateTrack<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61470 Offset: 0xF5FE70 VA: 0x180F61470
	|-TimelineAsset.CreateTrack<object>
	*/

	// RVA: 0x2C4C0E0 Offset: 0x2C4AAE0 VA: 0x182C4C0E0
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x2C4C6A0 Offset: 0x2C4B0A0 VA: 0x182C4C6A0
	public bool DeleteTrack(TrackAsset track) { }

	// RVA: 0x2C4CFE0 Offset: 0x2C4B9E0 VA: 0x182C4CFE0
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x2C4B560 Offset: 0x2C49F60 VA: 0x182C4B560
	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	// RVA: 0x2C4C3F0 Offset: 0x2C4ADF0 VA: 0x182C4C3F0
	private void DeleteRecordedAnimation(TrackAsset track) { }

	// RVA: 0x2C4C540 Offset: 0x2C4AF40 VA: 0x182C4C540
	private void DeleteRecordedAnimation(TimelineClip clip) { }

	// RVA: 0x2C4DAD0 Offset: 0x2C4C4D0 VA: 0x182C4DAD0
	public void .ctor() { }
}
