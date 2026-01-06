public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner // TypeDefIndex: 17389
{
	// Fields
	private const int k_LatestVersion = 3;
	[HideInInspector]
	[SerializeField]
	private int m_Version; // 0x18
	[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", False)]
	[FormerlySerializedAs("m_animClip")]
	[HideInInspector]
	[SerializeField]
	internal AnimationClip m_AnimClip; // 0x20
	private static TrackAsset.TransientBuildData s_BuildData; // 0x0
	internal const string kDefaultCurvesName = "Track Parameters";
	[CompilerGenerated]
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
	[CompilerGenerated]
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
	[HideInInspector]
	[SerializeField]
	private bool m_Locked; // 0x28
	[HideInInspector]
	[SerializeField]
	private bool m_Muted; // 0x29
	[HideInInspector]
	[SerializeField]
	private string m_CustomPlayableFullTypename; // 0x30
	[HideInInspector]
	[SerializeField]
	private AnimationClip m_Curves; // 0x38
	[SerializeField]
	[HideInInspector]
	private PlayableAsset m_Parent; // 0x40
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Children; // 0x48
	private int m_ItemsHash; // 0x50
	private TimelineClip[] m_ClipsCache; // 0x58
	private DiscreteTime m_Start; // 0x60
	private DiscreteTime m_End; // 0x68
	private bool m_CacheSorted; // 0x70
	private Nullable<bool> m_SupportsNotifications; // 0x71
	private static TrackAsset[] s_EmptyCache; // 0x28
	private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x78
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
	[HideInInspector]
	[SerializeField]
	protected internal List<TimelineClip> m_Clips; // 0x80
	[SerializeField]
	[HideInInspector]
	private MarkerList m_Markers; // 0x88

	// Properties
	public double start { get; }
	public double end { get; }
	public sealed override double duration { get; }
	public bool muted { get; set; }
	public bool mutedInHierarchy { get; }
	public TimelineAsset timelineAsset { get; }
	public PlayableAsset parent { get; set; }
	internal TimelineClip[] clips { get; }
	public virtual bool isEmpty { get; }
	public bool hasClips { get; }
	public bool hasCurves { get; }
	public bool isSubTrack { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	internal string customPlayableTypename { get; set; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.asset { get; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	internal List<ScriptableObject> subTracksObjects { get; }
	public bool locked { get; set; }
	public bool lockedInHierarchy { get; }
	public bool supportsNotifications { get; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	protected virtual void OnBeforeTrackSerialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	protected virtual void OnAfterTrackDeserialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x2C55D90 Offset: 0x2C54790 VA: 0x182C55D90 Slot: 9
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2C55AD0 Offset: 0x2C544D0 VA: 0x182C55AD0 Slot: 10
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpgradeToLatestVersion() { }

	[CompilerGenerated]
	// RVA: 0x2C56940 Offset: 0x2C55340 VA: 0x182C56940
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x2C576B0 Offset: 0x2C560B0 VA: 0x182C576B0
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x2C56A50 Offset: 0x2C55450 VA: 0x182C56A50
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[CompilerGenerated]
	// RVA: 0x2C577C0 Offset: 0x2C561C0 VA: 0x182C577C0
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	// RVA: 0x2C573F0 Offset: 0x2C55DF0 VA: 0x182C573F0
	public double get_start() { }

	// RVA: 0x2C56CD0 Offset: 0x2C556D0 VA: 0x182C56CD0
	public double get_end() { }

	// RVA: 0x2C56C30 Offset: 0x2C55630 VA: 0x182C56C30 Slot: 7
	public sealed override double get_duration() { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_muted() { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_muted(bool value) { }

	// RVA: 0x2C571B0 Offset: 0x2C55BB0 VA: 0x182C571B0
	public bool get_mutedInHierarchy() { }

	// RVA: 0x2C57510 Offset: 0x2C55F10 VA: 0x182C57510
	public TimelineAsset get_timelineAsset() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public PlayableAsset get_parent() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_parent(PlayableAsset value) { }

	// RVA: 0x2C54A20 Offset: 0x2C53420 VA: 0x182C54A20
	public IEnumerable<TimelineClip> GetClips() { }

	// RVA: 0x2C56B60 Offset: 0x2C55560 VA: 0x182C56B60
	internal TimelineClip[] get_clips() { }

	// RVA: 0x2C56E40 Offset: 0x2C55840 VA: 0x182C56E40 Slot: 23
	public virtual bool get_isEmpty() { }

	// RVA: 0x2C56D60 Offset: 0x2C55760 VA: 0x182C56D60
	public bool get_hasClips() { }

	// RVA: 0x2C56DB0 Offset: 0x2C557B0 VA: 0x182C56DB0 Slot: 13
	public bool get_hasCurves() { }

	// RVA: 0x2C56EE0 Offset: 0x2C558E0 VA: 0x182C56EE0
	public bool get_isSubTrack() { }

	[IteratorStateMachine(typeof(TrackAsset.<get_outputs>d__65))]
	// RVA: 0x2C57370 Offset: 0x2C55D70 VA: 0x182C57370 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C547B0 Offset: 0x2C531B0 VA: 0x182C547B0
	public IEnumerable<TrackAsset> GetChildTracks() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal string get_customPlayableTypename() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_customPlayableTypename(string value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 12
	public AnimationClip get_curves() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x2C55F30 Offset: 0x2C54930 VA: 0x182C55F30 Slot: 16
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 17
	private Object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	// RVA: 0x2C55F20 Offset: 0x2C54920 VA: 0x182C55F20 Slot: 18
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 19
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal List<ScriptableObject> get_subTracksObjects() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_locked() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_locked(bool value) { }

	// RVA: 0x2C56FF0 Offset: 0x2C559F0 VA: 0x182C56FF0
	public bool get_lockedInHierarchy() { }

	// RVA: 0x2C57480 Offset: 0x2C55E80 VA: 0x182C57480
	public bool get_supportsNotifications() { }

	// RVA: 0x2C56560 Offset: 0x2C54F60 VA: 0x182C56560
	private void __internalAwake() { }

	// RVA: 0x2C522F0 Offset: 0x2C50CF0 VA: 0x182C522F0 Slot: 15
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x2C53AF0 Offset: 0x2C524F0 VA: 0x182C53AF0 Slot: 24
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x2C53770 Offset: 0x2C52170 VA: 0x182C53770 Slot: 6
	public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x2C523A0 Offset: 0x2C50DA0 VA: 0x182C523A0
	public TimelineClip CreateDefaultClip() { }

	// RVA: -1 Offset: -1
	public TimelineClip CreateClip<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF618E0 Offset: 0xF602E0 VA: 0x180F618E0
	|-TrackAsset.CreateClip<object>
	*/

	// RVA: 0x2C53B70 Offset: 0x2C52570 VA: 0x182C53B70
	public bool DeleteClip(TimelineClip clip) { }

	// RVA: 0x2C52680 Offset: 0x2C51080 VA: 0x182C52680
	public IMarker CreateMarker(Type type, double time) { }

	// RVA: -1 Offset: -1
	public T CreateMarker<T>(double time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61950 Offset: 0xF60350 VA: 0x180F61950
	|-TrackAsset.CreateMarker<object>
	*/

	// RVA: 0x2C53CD0 Offset: 0x2C526D0 VA: 0x182C53CD0
	public bool DeleteMarker(IMarker marker) { }

	// RVA: 0x2C54EB0 Offset: 0x2C538B0 VA: 0x182C54EB0
	public IEnumerable<IMarker> GetMarkers() { }

	// RVA: 0x2C54E00 Offset: 0x2C53800 VA: 0x182C54E00
	public int GetMarkerCount() { }

	// RVA: 0x2C54E50 Offset: 0x2C53850 VA: 0x182C54E50
	public IMarker GetMarker(int idx) { }

	// RVA: 0x2C521B0 Offset: 0x2C50BB0 VA: 0x182C521B0
	internal TimelineClip CreateClip(Type requestedType) { }

	// RVA: 0x2C51A60 Offset: 0x2C50460 VA: 0x182C51A60
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	// RVA: 0x2C51F60 Offset: 0x2C50960 VA: 0x182C51F60
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	// RVA: 0x2C51CB0 Offset: 0x2C506B0 VA: 0x182C51CB0
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	// RVA: 0x2C51AA0 Offset: 0x2C504A0 VA: 0x182C51AA0
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	// RVA: 0x2C513D0 Offset: 0x2C4FDD0 VA: 0x182C513D0
	internal void ClearMarkers() { }

	// RVA: 0x2C51050 Offset: 0x2C4FA50 VA: 0x182C51050
	internal void AddMarker(ScriptableObject e) { }

	// RVA: 0x2C53C90 Offset: 0x2C52690 VA: 0x182C53C90
	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	// RVA: 0x2C55070 Offset: 0x2C53A70 VA: 0x182C55070
	private int GetTimeRangeHash() { }

	// RVA: 0x2C50F60 Offset: 0x2C4F960 VA: 0x182C50F60
	internal void AddClip(TimelineClip newClip) { }

	// RVA: 0x2C530A0 Offset: 0x2C51AA0 VA: 0x182C530A0
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	// RVA: 0x2C53400 Offset: 0x2C51E00 VA: 0x182C53400
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x2C514C0 Offset: 0x2C4FEC0 VA: 0x182C514C0 Slot: 25
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x2C53CE0 Offset: 0x2C526E0 VA: 0x182C53CE0
	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	// RVA: 0x2C53F40 Offset: 0x2C52940 VA: 0x182C53F40
	private void GatherNotifications(List<IMarker> markers) { }

	// RVA: 0x2C526B0 Offset: 0x2C510B0 VA: 0x182C526B0 Slot: 26
	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x2C518F0 Offset: 0x2C502F0 VA: 0x182C518F0
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	// RVA: 0x2C55980 Offset: 0x2C54380 VA: 0x182C55980
	internal void SortClips() { }

	// RVA: 0x2C51340 Offset: 0x2C4FD40 VA: 0x182C51340
	internal void ClearClipsInternal() { }

	// RVA: 0x2C51440 Offset: 0x2C4FE40 VA: 0x182C51440
	internal void ClearSubTracksInternal() { }

	// RVA: 0x6EFF00 Offset: 0x6EE900 VA: 0x1806EFF00
	internal void OnClipMove() { }

	// RVA: 0x2C52DC0 Offset: 0x2C517C0 VA: 0x182C52DC0
	internal TimelineClip CreateNewClipContainerInternal() { }

	// RVA: 0x2C50EB0 Offset: 0x2C4F8B0 VA: 0x182C50EB0
	internal void AddChild(TrackAsset child) { }

	// RVA: 0x2C55680 Offset: 0x2C54080 VA: 0x182C55680
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	// RVA: 0x2C558F0 Offset: 0x2C542F0 VA: 0x182C558F0
	internal bool RemoveSubTrack(TrackAsset child) { }

	// RVA: 0x2C55880 Offset: 0x2C54280 VA: 0x182C55880
	internal void RemoveClip(TimelineClip clip) { }

	// RVA: 0x2C54A30 Offset: 0x2C53430 VA: 0x182C54A30 Slot: 27
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0xDAA0B0 Offset: 0xDA8AB0 VA: 0x180DAA0B0 Slot: 28
	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x2C541C0 Offset: 0x2C52BC0 VA: 0x182C541C0 Slot: 29
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C54C70 Offset: 0x2C53670 VA: 0x182C54C70
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	// RVA: 0x2C562C0 Offset: 0x2C54CC0 VA: 0x182C562C0
	internal bool ValidateClipType(Type clipType) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 30
	protected virtual void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x2C56160 Offset: 0x2C54B60 VA: 0x182C56160
	private void UpdateDuration() { }

	// RVA: 0x2C51060 Offset: 0x2C4FA60 VA: 0x182C51060 Slot: 31
	protected internal virtual int CalculateItemsHash() { }

	// RVA: 0x2C537D0 Offset: 0x2C521D0 VA: 0x182C537D0 Slot: 32
	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	// RVA: 0x2C55330 Offset: 0x2C53D30 VA: 0x182C55330
	internal void Invalidate() { }

	// RVA: 0x2C54EE0 Offset: 0x2C538E0 VA: 0x182C54EE0
	internal double GetNotificationDuration() { }

	// RVA: 0x2C510F0 Offset: 0x2C4FAF0 VA: 0x182C510F0 Slot: 33
	internal virtual bool CanCompileClips() { }

	// RVA: 0x2C51320 Offset: 0x2C4FD20 VA: 0x182C51320 Slot: 34
	public virtual bool CanCreateTrackMixer() { }

	// RVA: 0x2C553E0 Offset: 0x2C53DE0 VA: 0x182C553E0
	internal bool IsCompilable() { }

	// RVA: 0x2C55F60 Offset: 0x2C54960 VA: 0x182C55F60
	private void UpdateChildTrackCache() { }

	// RVA: 0x2C552C0 Offset: 0x2C53CC0 VA: 0x182C552C0 Slot: 35
	internal virtual int Hash() { }

	// RVA: 0x2C547D0 Offset: 0x2C531D0 VA: 0x182C547D0
	private int GetClipsHash() { }

	// RVA: 0x2C546E0 Offset: 0x2C530E0 VA: 0x182C546E0
	protected static int GetAnimationClipHash(AnimationClip clip) { }

	// RVA: 0x2C55290 Offset: 0x2C53C90 VA: 0x182C55290
	private bool HasNotifications() { }

	// RVA: 0x2C51150 Offset: 0x2C4FB50 VA: 0x182C51150
	private bool CanCompileNotifications() { }

	// RVA: 0x2C51190 Offset: 0x2C4FB90 VA: 0x182C51190
	private bool CanCreateMixerRecursive() { }

	// RVA: 0x2C56850 Offset: 0x2C55250 VA: 0x182C56850
	protected void .ctor() { }

	// RVA: 0x2C56640 Offset: 0x2C55040 VA: 0x182C56640
	private static void .cctor() { }
}
