public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 17370
{
	// Fields
	private const string k_DefaultInfiniteClipName = "Recorded";
	private const string k_DefaultRecordableClipName = "Recorded";
	[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xA0
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
	private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xA4
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipOffsetPosition")]
	private Vector3 m_InfiniteClipOffsetPosition; // 0xA8
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
	private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xB4
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipTimeOffset")]
	private double m_InfiniteClipTimeOffset; // 0xC0
	[SerializeField]
	[FormerlySerializedAs("m_OpenClipRemoveOffset")]
	private bool m_InfiniteClipRemoveOffset; // 0xC8
	[SerializeField]
	private bool m_InfiniteClipApplyFootIK; // 0xC9
	[SerializeField]
	[HideInInspector]
	private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xCC
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; // 0xD0
	[SerializeField]
	private Vector3 m_Position; // 0xD4
	[SerializeField]
	private Vector3 m_EulerAngles; // 0xE0
	[SerializeField]
	private AvatarMask m_AvatarMask; // 0xF0
	[SerializeField]
	private bool m_ApplyAvatarMask; // 0xF8
	[SerializeField]
	private TrackOffset m_TrackOffset; // 0xFC
	[SerializeField]
	[HideInInspector]
	private AnimationClip m_InfiniteClip; // 0x100
	private static readonly Queue<Transform> s_CachedQueue; // 0x0
	[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", False)]
	[SerializeField]
	[HideInInspector]
	private Quaternion m_OpenClipOffsetRotation; // 0x108
	[SerializeField]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[HideInInspector]
	private Quaternion m_Rotation; // 0x118
	[SerializeField]
	[HideInInspector]
	[Obsolete("Use m_RootTransformOffsetMode", False)]
	private bool m_ApplyOffsets; // 0x128

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	[Obsolete("applyOffset is deprecated. Use trackOffset instead", True)]
	public bool applyOffsets { get; set; }
	public TrackOffset trackOffset { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public AnimationClip infiniteClip { get; set; }
	internal bool infiniteClipRemoveOffset { get; set; }
	public AvatarMask avatarMask { get; set; }
	public bool applyAvatarMask { get; set; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public bool inClipMode { get; }
	public Vector3 infiniteClipOffsetPosition { get; set; }
	public Quaternion infiniteClipOffsetRotation { get; set; }
	public Vector3 infiniteClipOffsetEulerAngles { get; set; }
	internal bool infiniteClipApplyFootIK { get; set; }
	internal double infiniteClipTimeOffset { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; }
	public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; }
	internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; }
	[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", True)]
	[EditorBrowsable(1)]
	public Vector3 openClipOffsetPosition { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", True)]
	public Quaternion openClipOffsetRotation { get; set; }
	[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", True)]
	[EditorBrowsable(1)]
	public Vector3 openClipOffsetEulerAngles { get; set; }
	[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", True)]
	[EditorBrowsable(1)]
	public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; }
	[EditorBrowsable(1)]
	[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", True)]
	public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; }

	// Methods

	// RVA: 0x10F95A0 Offset: 0x10F7FA0 VA: 0x1810F95A0
	public Vector3 get_position() { }

	// RVA: 0x10F9950 Offset: 0x10F8350 VA: 0x1810F9950
	public void set_position(Vector3 value) { }

	// RVA: 0x2C40C70 Offset: 0x2C3F670 VA: 0x182C40C70
	public Quaternion get_rotation() { }

	// RVA: 0x2C40E60 Offset: 0x2C3F860 VA: 0x182C40E60
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2C40AC0 Offset: 0x2C3F4C0 VA: 0x182C40AC0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2C40CE0 Offset: 0x2C3F6E0 VA: 0x182C40CE0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_applyOffsets() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_applyOffsets(bool value) { }

	// RVA: 0x5232A0 Offset: 0x521CA0 VA: 0x1805232A0
	public TrackOffset get_trackOffset() { }

	// RVA: 0x7C2510 Offset: 0x7C0F10 VA: 0x1807C2510
	public void set_trackOffset(TrackOffset value) { }

	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0x2C40DF0 Offset: 0x2C3F7F0 VA: 0x182C40DF0
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public AnimationClip get_infiniteClip() { }

	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	internal void set_infiniteClip(AnimationClip value) { }

	// RVA: 0x1A3AE20 Offset: 0x1A39820 VA: 0x181A3AE20
	internal bool get_infiniteClipRemoveOffset() { }

	// RVA: 0x1A3AF10 Offset: 0x1A39910 VA: 0x181A3AF10
	internal void set_infiniteClipRemoveOffset(bool value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public AvatarMask get_avatarMask() { }

	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_avatarMask(AvatarMask value) { }

	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	public bool get_applyAvatarMask() { }

	// RVA: 0x1A3AEE0 Offset: 0x1A398E0 VA: 0x181A3AEE0
	public void set_applyAvatarMask(bool value) { }

	// RVA: 0x2C3DA50 Offset: 0x2C3C450 VA: 0x182C3DA50 Slot: 33
	internal override bool CanCompileClips() { }

	[IteratorStateMachine(typeof(AnimationTrack.<get_outputs>d__49))]
	// RVA: 0x2C40BF0 Offset: 0x2C3F5F0 VA: 0x182C40BF0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C40AE0 Offset: 0x2C3F4E0 VA: 0x182C40AE0
	public bool get_inClipMode() { }

	// RVA: 0x2C40B50 Offset: 0x2C3F550 VA: 0x182C40B50
	public Vector3 get_infiniteClipOffsetPosition() { }

	// RVA: 0x2C40D30 Offset: 0x2C3F730 VA: 0x182C40D30
	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	// RVA: 0x2C40B70 Offset: 0x2C3F570 VA: 0x182C40B70
	public Quaternion get_infiniteClipOffsetRotation() { }

	// RVA: 0x2C40D50 Offset: 0x2C3F750 VA: 0x182C40D50
	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	// RVA: 0x2C40B30 Offset: 0x2C3F530 VA: 0x182C40B30
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	// RVA: 0x2C40D10 Offset: 0x2C3F710 VA: 0x182C40D10
	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x2C40B20 Offset: 0x2C3F520 VA: 0x182C40B20
	internal bool get_infiniteClipApplyFootIK() { }

	// RVA: 0x2C40D00 Offset: 0x2C3F700 VA: 0x182C40D00
	internal void set_infiniteClipApplyFootIK(bool value) { }

	// RVA: 0x2C40BE0 Offset: 0x2C3F5E0 VA: 0x182C40BE0
	internal double get_infiniteClipTimeOffset() { }

	// RVA: 0x2C40DE0 Offset: 0x2C3F7E0 VA: 0x182C40DE0
	internal void set_infiniteClipTimeOffset(double value) { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	public void set_infiniteClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	// RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830
	public void set_infiniteClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	internal AnimationPlayableAsset.LoopMode get_infiniteClipLoop() { }

	// RVA: 0x1A3AF40 Offset: 0x1A39940 VA: 0x181A3AF40
	internal void set_infiniteClipLoop(AnimationPlayableAsset.LoopMode value) { }

	[ContextMenu("Reset Offsets")]
	// RVA: 0x2C40730 Offset: 0x2C3F130 VA: 0x182C40730
	private void ResetOffsets() { }

	// RVA: 0x2C3DFF0 Offset: 0x2C3C9F0 VA: 0x182C3DFF0
	public TimelineClip CreateClip(AnimationClip clip) { }

	// RVA: 0x2C3E130 Offset: 0x2C3CB30 VA: 0x182C3E130
	public void CreateInfiniteClip(string infiniteClipName) { }

	// RVA: 0x2C3EFC0 Offset: 0x2C3D9C0 VA: 0x182C3EFC0
	public TimelineClip CreateRecordableClip(string animClipName) { }

	// RVA: 0x2C403A0 Offset: 0x2C3EDA0 VA: 0x182C403A0 Slot: 30
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x2C3D960 Offset: 0x2C3C360 VA: 0x182C3D960 Slot: 31
	protected internal override int CalculateItemsHash() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void UpdateClipOffsets() { }

	// RVA: 0x2C3DB10 Offset: 0x2C3C510 VA: 0x182C3DB10
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x2C407C0 Offset: 0x2C3F1C0 VA: 0x182C407C0 Slot: 36
	private Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x2C3E670 Offset: 0x2C3D070 VA: 0x182C3E670 Slot: 26
	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private int GetDefaultBlendCount() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	// RVA: 0x2C3D800 Offset: 0x2C3C200 VA: 0x182C3D800
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	// RVA: 0x2C40620 Offset: 0x2C3F020 VA: 0x182C40620
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	// RVA: 0x2C40820 Offset: 0x2C3F220 VA: 0x182C40820
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

	// RVA: 0x2C40000 Offset: 0x2C3EA00 VA: 0x182C40000
	private bool HasController(GameObject gameObject) { }

	// RVA: 0x2C3F830 Offset: 0x2C3E230 VA: 0x182C3F830
	internal Animator GetBinding(PlayableDirector director) { }

	// RVA: 0x2C3E0A0 Offset: 0x2C3CAA0 VA: 0x182C3E0A0
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x2C3E260 Offset: 0x2C3CC60 VA: 0x182C3E260
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	// RVA: 0x2C3D330 Offset: 0x2C3BD30 VA: 0x182C3D330
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	// RVA: 0x2C3FA20 Offset: 0x2C3E420 VA: 0x182C3FA20 Slot: 27
	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	// RVA: 0x2C3FED0 Offset: 0x2C3E8D0 VA: 0x182C3FED0 Slot: 28
	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	// RVA: 0x2C3D530 Offset: 0x2C3BF30 VA: 0x182C3D530
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 29
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C3F390 Offset: 0x2C3DD90 VA: 0x182C3F390
	private void GetAnimationClips(List<AnimationClip> animClips) { }

	// RVA: 0x2C3FCD0 Offset: 0x2C3E6D0 VA: 0x182C3FCD0
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	// RVA: 0x2C40110 Offset: 0x2C3EB10 VA: 0x182C40110
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	// RVA: 0x2C3FAF0 Offset: 0x2C3E4F0 VA: 0x182C3FAF0
	private Transform GetGenericRootNode(GameObject gameObject) { }

	// RVA: 0x2C3D070 Offset: 0x2C3BA70 VA: 0x182C3D070
	internal bool AnimatesRootTransform() { }

	// RVA: 0x2C3F190 Offset: 0x2C3DB90 VA: 0x182C3F190
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	// RVA: 0x2C40B50 Offset: 0x2C3F550 VA: 0x182C40B50
	public Vector3 get_openClipOffsetPosition() { }

	// RVA: 0x2C40D30 Offset: 0x2C3F730 VA: 0x182C40D30
	public void set_openClipOffsetPosition(Vector3 value) { }

	// RVA: 0x2C40B70 Offset: 0x2C3F570 VA: 0x182C40B70
	public Quaternion get_openClipOffsetRotation() { }

	// RVA: 0x2C40D50 Offset: 0x2C3F750 VA: 0x182C40D50
	public void set_openClipOffsetRotation(Quaternion value) { }

	// RVA: 0x2C40B30 Offset: 0x2C3F530 VA: 0x182C40B30
	public Vector3 get_openClipOffsetEulerAngles() { }

	// RVA: 0x2C40D10 Offset: 0x2C3F710 VA: 0x182C40D10
	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public TimelineClip.ClipExtrapolation get_openClipPreExtrapolation() { }

	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	public void set_openClipPreExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public TimelineClip.ClipExtrapolation get_openClipPostExtrapolation() { }

	// RVA: 0xBBA830 Offset: 0xBB9230 VA: 0x180BBA830
	public void set_openClipPostExtrapolation(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x2C40410 Offset: 0x2C3EE10 VA: 0x182C40410 Slot: 22
	internal override void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x2C408C0 Offset: 0x2C3F2C0 VA: 0x182C408C0
	public void .ctor() { }

	// RVA: 0x2C40830 Offset: 0x2C3F230 VA: 0x182C40830
	private static void .cctor() { }
}
