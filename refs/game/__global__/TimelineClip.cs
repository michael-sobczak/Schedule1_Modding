public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 17376
{
	// Fields
	private const int k_LatestVersion = 1;
	[HideInInspector]
	[SerializeField]
	private int m_Version; // 0x10
	public static readonly ClipCaps kDefaultClipCaps; // 0x0
	public static readonly float kDefaultClipDurationInSeconds; // 0x4
	public static readonly double kTimeScaleMin; // 0x8
	public static readonly double kTimeScaleMax; // 0x10
	internal static readonly string kDefaultCurvesName; // 0x18
	internal static readonly double kMinDuration; // 0x20
	internal static readonly double kMaxTimeValue; // 0x28
	[SerializeField]
	private double m_Start; // 0x18
	[SerializeField]
	private double m_ClipIn; // 0x20
	[SerializeField]
	private Object m_Asset; // 0x28
	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	private double m_Duration; // 0x30
	[SerializeField]
	private double m_TimeScale; // 0x38
	[SerializeField]
	private TrackAsset m_ParentTrack; // 0x40
	[SerializeField]
	private double m_EaseInDuration; // 0x48
	[SerializeField]
	private double m_EaseOutDuration; // 0x50
	[SerializeField]
	private double m_BlendInDuration; // 0x58
	[SerializeField]
	private double m_BlendOutDuration; // 0x60
	[SerializeField]
	private AnimationCurve m_MixInCurve; // 0x68
	[SerializeField]
	private AnimationCurve m_MixOutCurve; // 0x70
	[SerializeField]
	private TimelineClip.BlendCurveMode m_BlendInCurveMode; // 0x78
	[SerializeField]
	private TimelineClip.BlendCurveMode m_BlendOutCurveMode; // 0x7C
	[SerializeField]
	private List<string> m_ExposedParameterNames; // 0x80
	[SerializeField]
	private AnimationClip m_AnimationCurves; // 0x88
	[SerializeField]
	private bool m_Recordable; // 0x90
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_PostExtrapolationMode; // 0x94
	[SerializeField]
	private TimelineClip.ClipExtrapolation m_PreExtrapolationMode; // 0x98
	[SerializeField]
	private double m_PostExtrapolationTime; // 0xA0
	[SerializeField]
	private double m_PreExtrapolationTime; // 0xA8
	[SerializeField]
	private string m_DisplayName; // 0xB0

	// Properties
	public bool hasPreExtrapolation { get; }
	public bool hasPostExtrapolation { get; }
	public double timeScale { get; set; }
	public double start { get; set; }
	public double duration { get; set; }
	public double end { get; }
	public double clipIn { get; set; }
	public string displayName { get; set; }
	public double clipAssetDuration { get; }
	public AnimationClip curves { get; set; }
	private string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName { get; }
	public bool hasCurves { get; }
	public Object asset { get; set; }
	private Object UnityEngine.Timeline.ICurvesOwner.assetOwner { get; }
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack { get; }
	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", True)]
	public Object underlyingAsset { get; set; }
	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", False)]
	public TrackAsset parentTrack { get; set; }
	public double easeInDuration { get; set; }
	public double easeOutDuration { get; set; }
	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", True)]
	public double eastOutTime { get; }
	public double easeOutTime { get; }
	public double blendInDuration { get; set; }
	public double blendOutDuration { get; set; }
	public TimelineClip.BlendCurveMode blendInCurveMode { get; set; }
	public TimelineClip.BlendCurveMode blendOutCurveMode { get; set; }
	public bool hasBlendIn { get; }
	public bool hasBlendOut { get; }
	public AnimationCurve mixInCurve { get; set; }
	public float mixInPercentage { get; }
	public double mixInDuration { get; }
	public AnimationCurve mixOutCurve { get; set; }
	public double mixOutTime { get; }
	public double mixOutDuration { get; }
	public float mixOutPercentage { get; }
	public bool recordable { get; set; }
	[Obsolete("exposedParameter is deprecated and will be removed in a future release", True)]
	public List<string> exposedParameters { get; }
	public ClipCaps clipCaps { get; }
	public AnimationClip animationClip { get; }
	public TimelineClip.ClipExtrapolation postExtrapolationMode { get; set; }
	public TimelineClip.ClipExtrapolation preExtrapolationMode { get; set; }
	public double extrapolatedStart { get; }
	public double extrapolatedDuration { get; }

	// Methods

	// RVA: 0x2C4F540 Offset: 0x2C4DF40 VA: 0x182C4F540
	private void UpgradeToLatestVersion() { }

	// RVA: 0x2C4F6E0 Offset: 0x2C4E0E0 VA: 0x182C4F6E0
	internal void .ctor(TrackAsset parent) { }

	// RVA: 0x2C4FE60 Offset: 0x2C4E860 VA: 0x182C4FE60
	public bool get_hasPreExtrapolation() { }

	// RVA: 0x2C4FE40 Offset: 0x2C4E840 VA: 0x182C4FE40
	public bool get_hasPostExtrapolation() { }

	// RVA: 0x2C50250 Offset: 0x2C4EC50 VA: 0x182C50250
	public double get_timeScale() { }

	// RVA: 0x2C509A0 Offset: 0x2C4F3A0 VA: 0x182C509A0
	public void set_timeScale(double value) { }

	// RVA: 0x18A4000 Offset: 0x18A2A00 VA: 0x1818A4000
	public double get_start() { }

	// RVA: 0x2C50890 Offset: 0x2C4F290 VA: 0x182C50890
	public void set_start(double value) { }

	// RVA: 0x2874710 Offset: 0x2873110 VA: 0x182874710 Slot: 6
	public double get_duration() { }

	// RVA: 0x2C50530 Offset: 0x2C4EF30 VA: 0x182C50530
	public void set_duration(double value) { }

	// RVA: 0x2C4FB90 Offset: 0x2C4E590 VA: 0x182C4FB90
	public double get_end() { }

	// RVA: 0x2C4F980 Offset: 0x2C4E380 VA: 0x182C4F980
	public double get_clipIn() { }

	// RVA: 0x2C50450 Offset: 0x2C4EE50 VA: 0x182C50450
	public void set_clipIn(double value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public string get_displayName() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_displayName(string value) { }

	// RVA: 0x2C4F880 Offset: 0x2C4E280 VA: 0x182C4F880
	public double get_clipAssetDuration() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 4
	public AnimationClip get_curves() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void set_curves(AnimationClip value) { }

	// RVA: 0x2C4F580 Offset: 0x2C4DF80 VA: 0x182C4F580 Slot: 8
	private string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	// RVA: 0x2C4FDB0 Offset: 0x2C4E7B0 VA: 0x182C4FDB0 Slot: 5
	public bool get_hasCurves() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 9
	public Object get_asset() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_asset(Object value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 10
	private Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 11
	private TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public Object get_underlyingAsset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_underlyingAsset(Object value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public TrackAsset get_parentTrack() { }

	// RVA: 0x2C50800 Offset: 0x2C4F200 VA: 0x182C50800
	public void set_parentTrack(TrackAsset value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public TrackAsset GetParentTrack() { }

	// RVA: 0x2C4EF70 Offset: 0x2C4D970 VA: 0x182C4EF70
	internal void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	// RVA: 0x2C4F9B0 Offset: 0x2C4E3B0 VA: 0x182C4F9B0
	public double get_easeInDuration() { }

	// RVA: 0x2C505E0 Offset: 0x2C4EFE0 VA: 0x182C505E0
	public void set_easeInDuration(double value) { }

	// RVA: 0x2C4FA80 Offset: 0x2C4E480 VA: 0x182C4FA80
	public double get_easeOutDuration() { }

	// RVA: 0x2C506F0 Offset: 0x2C4F0F0 VA: 0x182C506F0
	public void set_easeOutDuration(double value) { }

	// RVA: 0x2C4FB50 Offset: 0x2C4E550 VA: 0x182C4FB50
	public double get_eastOutTime() { }

	// RVA: 0x2C4FB50 Offset: 0x2C4E550 VA: 0x182C4FB50
	public double get_easeOutTime() { }

	// RVA: 0x2C4F820 Offset: 0x2C4E220 VA: 0x182C4F820
	public double get_blendInDuration() { }

	// RVA: 0x2C50330 Offset: 0x2C4ED30 VA: 0x182C50330
	public void set_blendInDuration(double value) { }

	// RVA: 0x2C4F850 Offset: 0x2C4E250 VA: 0x182C4F850
	public double get_blendOutDuration() { }

	// RVA: 0x2C503C0 Offset: 0x2C4EDC0 VA: 0x182C503C0
	public void set_blendOutDuration(double value) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public TimelineClip.BlendCurveMode get_blendInCurveMode() { }

	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	public void set_blendInCurveMode(TimelineClip.BlendCurveMode value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public TimelineClip.BlendCurveMode get_blendOutCurveMode() { }

	// RVA: 0xD9EBC0 Offset: 0xD9D5C0 VA: 0x180D9EBC0
	public void set_blendOutCurveMode(TimelineClip.BlendCurveMode value) { }

	// RVA: 0x2C4FD30 Offset: 0x2C4E730 VA: 0x182C4FD30
	public bool get_hasBlendIn() { }

	// RVA: 0x2C4FD70 Offset: 0x2C4E770 VA: 0x182C4FD70
	public bool get_hasBlendOut() { }

	// RVA: 0x2C4FE80 Offset: 0x2C4E880 VA: 0x182C4FE80
	public AnimationCurve get_mixInCurve() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_mixInCurve(AnimationCurve value) { }

	// RVA: 0x2C50010 Offset: 0x2C4EA10 VA: 0x182C50010
	public float get_mixInPercentage() { }

	// RVA: 0x2C4FF10 Offset: 0x2C4E910 VA: 0x182C4FF10
	public double get_mixInDuration() { }

	// RVA: 0x2C50030 Offset: 0x2C4EA30 VA: 0x182C50030
	public AnimationCurve get_mixOutCurve() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_mixOutCurve(AnimationCurve value) { }

	// RVA: 0x2C50180 Offset: 0x2C4EB80 VA: 0x182C50180
	public double get_mixOutTime() { }

	// RVA: 0x2C500C0 Offset: 0x2C4EAC0 VA: 0x182C500C0
	public double get_mixOutDuration() { }

	// RVA: 0x2C50120 Offset: 0x2C4EB20 VA: 0x182C50120
	public float get_mixOutPercentage() { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	public bool get_recordable() { }

	// RVA: 0x979B10 Offset: 0x978510 VA: 0x180979B10
	internal void set_recordable(bool value) { }

	// RVA: 0x2C4FBA0 Offset: 0x2C4E5A0 VA: 0x182C4FBA0
	public List<string> get_exposedParameters() { }

	// RVA: 0x2C4F8F0 Offset: 0x2C4E2F0 VA: 0x182C4F8F0
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2C4EBA0 Offset: 0x2C4D5A0 VA: 0x182C4EBA0
	internal int Hash() { }

	// RVA: 0x2C4E7A0 Offset: 0x2C4D1A0 VA: 0x182C4E7A0
	public float EvaluateMixOut(double time) { }

	// RVA: 0x2C4E630 Offset: 0x2C4D030 VA: 0x182C4E630
	public float EvaluateMixIn(double time) { }

	// RVA: 0x2C4EA00 Offset: 0x2C4D400 VA: 0x182C4EA00
	private static AnimationCurve GetDefaultMixInCurve() { }

	// RVA: 0x2C4EA30 Offset: 0x2C4D430 VA: 0x182C4EA30
	private static AnimationCurve GetDefaultMixOutCurve() { }

	// RVA: 0x2C4F110 Offset: 0x2C4DB10 VA: 0x182C4F110
	public double ToLocalTime(double time) { }

	// RVA: 0x2C4F0A0 Offset: 0x2C4DAA0 VA: 0x182C4F0A0
	public double ToLocalTimeUnbound(double time) { }

	// RVA: 0x2C4E9A0 Offset: 0x2C4D3A0 VA: 0x182C4E9A0
	internal double FromLocalTimeUnbound(double time) { }

	// RVA: 0x2C4F730 Offset: 0x2C4E130 VA: 0x182C4F730
	public AnimationClip get_animationClip() { }

	// RVA: 0x2C4EE30 Offset: 0x2C4D830 VA: 0x182C4EE30
	private static double SanitizeTimeValue(double value, double defaultValue) { }

	// RVA: 0x2C501F0 Offset: 0x2C4EBF0 VA: 0x182C501F0
	public TimelineClip.ClipExtrapolation get_postExtrapolationMode() { }

	// RVA: 0x2C50810 Offset: 0x2C4F210 VA: 0x182C50810
	internal void set_postExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x2C50220 Offset: 0x2C4EC20 VA: 0x182C50220
	public TimelineClip.ClipExtrapolation get_preExtrapolationMode() { }

	// RVA: 0x2C50850 Offset: 0x2C4F250 VA: 0x182C50850
	internal void set_preExtrapolationMode(TimelineClip.ClipExtrapolation value) { }

	// RVA: 0x2C4F080 Offset: 0x2C4DA80 VA: 0x182C4F080
	internal void SetPostExtrapolationTime(double time) { }

	// RVA: 0x2C4F090 Offset: 0x2C4DA90 VA: 0x182C4F090
	internal void SetPreExtrapolationTime(double time) { }

	// RVA: 0x2C4ECB0 Offset: 0x2C4D6B0 VA: 0x182C4ECB0
	public bool IsExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x2C4EDD0 Offset: 0x2C4D7D0 VA: 0x182C4EDD0
	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x2C4ED60 Offset: 0x2C4D760 VA: 0x182C4ED60
	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	// RVA: 0x2C4FD10 Offset: 0x2C4E710 VA: 0x182C4FD10
	public double get_extrapolatedStart() { }

	// RVA: 0x2C4FC30 Offset: 0x2C4E630 VA: 0x182C4FC30
	public double get_extrapolatedDuration() { }

	// RVA: 0x2C4EA60 Offset: 0x2C4D460 VA: 0x182C4EA60
	private static double GetExtrapolatedTime(double time, TimelineClip.ClipExtrapolation mode, double duration) { }

	// RVA: 0x2C4E550 Offset: 0x2C4CF50 VA: 0x182C4E550 Slot: 7
	public void CreateCurves(string curvesClipName) { }

	// RVA: 0x2C4F570 Offset: 0x2C4DF70 VA: 0x182C4F570 Slot: 12
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2C4F540 Offset: 0x2C4DF40 VA: 0x182C4F540 Slot: 13
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2C4F2D0 Offset: 0x2C4DCD0 VA: 0x182C4F2D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C4E400 Offset: 0x2C4CE00 VA: 0x182C4E400
	public void ConformEaseValues() { }

	// RVA: 0x2C4E310 Offset: 0x2C4CD10 VA: 0x182C4E310
	private static double CalculateEasingRatio(double easeIn, double easeOut) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpdateDirty(double oldValue, double newValue) { }

	// RVA: 0x2C4F5D0 Offset: 0x2C4DFD0 VA: 0x182C4F5D0
	private static void .cctor() { }
}
