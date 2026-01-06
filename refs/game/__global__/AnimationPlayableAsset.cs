public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver // TypeDefIndex: 17362
{
	// Fields
	[SerializeField]
	private AnimationClip m_Clip; // 0x18
	[SerializeField]
	private Vector3 m_Position; // 0x20
	[SerializeField]
	private Vector3 m_EulerAngles; // 0x2C
	[SerializeField]
	private bool m_UseTrackMatchFields; // 0x38
	[SerializeField]
	private MatchTargetFields m_MatchTargetFields; // 0x3C
	[SerializeField]
	private bool m_RemoveStartOffset; // 0x40
	[SerializeField]
	private bool m_ApplyFootIK; // 0x41
	[SerializeField]
	private AnimationPlayableAsset.LoopMode m_Loop; // 0x44
	[CompilerGenerated]
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; // 0x48
	private static readonly int k_LatestVersion; // 0x0
	[SerializeField]
	[HideInInspector]
	private int m_Version; // 0x4C
	[SerializeField]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[HideInInspector]
	private Quaternion m_Rotation; // 0x50

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public Vector3 eulerAngles { get; set; }
	public bool useTrackMatchFields { get; set; }
	public MatchTargetFields matchTargetFields { get; set; }
	public bool removeStartOffset { get; set; }
	public bool applyFootIK { get; set; }
	public AnimationPlayableAsset.LoopMode loop { get; set; }
	internal bool hasRootTransforms { get; }
	internal AppliedOffsetMode appliedOffsetMode { get; set; }
	public AnimationClip clip { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x4DA100 Offset: 0x4D8B00 VA: 0x1804DA100
	public Vector3 get_position() { }

	// RVA: 0x4DA200 Offset: 0x4D8C00 VA: 0x1804DA200
	public void set_position(Vector3 value) { }

	// RVA: 0x2C3C860 Offset: 0x2C3B260 VA: 0x182C3C860
	public Quaternion get_rotation() { }

	// RVA: 0x2C3C980 Offset: 0x2C3B380 VA: 0x182C3C980
	public void set_rotation(Quaternion value) { }

	// RVA: 0x4DA0C0 Offset: 0x4D8AC0 VA: 0x1804DA0C0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x4DA1E0 Offset: 0x4D8BE0 VA: 0x1804DA1E0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_useTrackMatchFields() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_useTrackMatchFields(bool value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public MatchTargetFields get_matchTargetFields() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_matchTargetFields(MatchTargetFields value) { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_removeStartOffset() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_removeStartOffset(bool value) { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	public bool get_applyFootIK() { }

	// RVA: 0x242D200 Offset: 0x242BC00 VA: 0x18242D200
	public void set_applyFootIK(bool value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public AnimationPlayableAsset.LoopMode get_loop() { }

	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	public void set_loop(AnimationPlayableAsset.LoopMode value) { }

	// RVA: 0x2C3C740 Offset: 0x2C3B140 VA: 0x182C3C740
	internal bool get_hasRootTransforms() { }

	[CompilerGenerated]
	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	[CompilerGenerated]
	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AnimationClip get_clip() { }

	// RVA: 0x2C3C8D0 Offset: 0x2C3B2D0 VA: 0x182C3C8D0
	public void set_clip(AnimationClip value) { }

	// RVA: 0x2C3C6D0 Offset: 0x2C3B0D0 VA: 0x182C3C6D0 Slot: 7
	public override double get_duration() { }

	[IteratorStateMachine(typeof(AnimationPlayableAsset.<get_outputs>d__45))]
	// RVA: 0x2C3C7E0 Offset: 0x2C3B1E0 VA: 0x182C3C7E0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C3BEF0 Offset: 0x2C3A8F0 VA: 0x182C3BEF0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x2C3BAA0 Offset: 0x2C3A4A0 VA: 0x182C3BAA0
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, AnimationPlayableAsset.LoopMode loop) { }

	// RVA: 0x2C3C2D0 Offset: 0x2C3ACD0 VA: 0x182C3C2D0
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	// RVA: 0x2C3C340 Offset: 0x2C3AD40 VA: 0x182C3C340
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	// RVA: 0x2C3C5F0 Offset: 0x2C3AFF0 VA: 0x182C3C5F0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2C3C240 Offset: 0x2C3AC40 VA: 0x182C3C240
	public void ResetOffsets() { }

	// RVA: 0x2C3C020 Offset: 0x2C3AA20 VA: 0x182C3C020 Slot: 10
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C3C0F0 Offset: 0x2C3AAF0 VA: 0x182C3C0F0
	internal static bool HasRootTransforms(AnimationClip clip) { }

	// RVA: 0x2C3C440 Offset: 0x2C3AE40 VA: 0x182C3C440 Slot: 11
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2C3C360 Offset: 0x2C3AD60 VA: 0x182C3C360 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2C3C1A0 Offset: 0x2C3ABA0 VA: 0x182C3C1A0
	private void OnUpgradeFromVersion(int oldVersion) { }

	// RVA: 0x2C3C4E0 Offset: 0x2C3AEE0 VA: 0x182C3C4E0
	public void .ctor() { }

	// RVA: 0x2C3C4A0 Offset: 0x2C3AEA0 VA: 0x182C3C4A0
	private static void .cctor() { }
}
