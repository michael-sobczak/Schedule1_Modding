public class CurvySplineSegment : DTVersionedMonoBehaviour, IPoolable // TypeDefIndex: 10546
{
	// Fields
	public static readonly Color GizmoTangentColor; // 0x0
	[Group("General")]
	[SerializeField]
	[FieldAction("CBBakeOrientation", 7, Position = 1)]
	[Label("Bake Orientation", "Automatically apply orientation to CP transforms?")]
	private bool m_AutoBakeOrientation; // 0x30
	[SerializeField]
	[FieldCondition("IsOrientationAnchorEditable", True, False, 0, null, 1)]
	[Tooltip("Check to use this transform's rotation")]
	[Group("General")]
	private bool m_OrientationAnchor; // 0x31
	[SerializeField]
	[FieldCondition("CanHaveSwirl", True, False, 0, null, 1)]
	[Group("General")]
	[Label("Swirl", "Add Swirl to orientation?")]
	private CurvyOrientationSwirl m_Swirl; // 0x34
	[FieldCondition("CanHaveSwirl", True, False, 0, "m_Swirl", 0, True)]
	[Label("Turns", "Number of swirl turns")]
	[Group("General")]
	[SerializeField]
	private float m_SwirlTurns; // 0x38
	[Section("Bezier Options", True, False, 100, Sort = 1, HelpURL = "https://curvyeditor.com/doclink/curvysplinesegment_bezier")]
	[GroupCondition("Interpolation", 3, False)]
	[SerializeField]
	private bool m_AutoHandles; // 0x3C
	[RangeEx(0, 1, "Distance %", "Handle length by distance to neighbours")]
	[FieldCondition("m_AutoHandles", True, False, 0, null, 1, Action = 2)]
	[SerializeField]
	private float m_AutoHandleDistance; // 0x40
	[SerializeField]
	[VectorEx("", "", Precision = 3, Options = 1152, Color = "#FFFF00")]
	[FormerlySerializedAs("HandleIn")]
	private Vector3 m_HandleIn; // 0x44
	[FormerlySerializedAs("HandleOut")]
	[SerializeField]
	[VectorEx("", "", Precision = 3, Options = 1152, Color = "#00FF00")]
	private Vector3 m_HandleOut; // 0x50
	[Section("TCB Options", True, False, 100, Sort = 1, HelpURL = "https://curvyeditor.com/doclink/curvysplinesegment_tcb")]
	[GroupCondition("Interpolation", 2, False)]
	[GroupAction("TCBOptionsGUI", 7, Position = 1)]
	[Label("Local Tension", "Override Spline Tension?")]
	[SerializeField]
	[FormerlySerializedAs("OverrideGlobalTension")]
	private bool m_OverrideGlobalTension; // 0x5C
	[Label("Local Continuity", "Override Spline Continuity?")]
	[SerializeField]
	[FormerlySerializedAs("OverrideGlobalContinuity")]
	private bool m_OverrideGlobalContinuity; // 0x5D
	[Label("Local Bias", "Override Spline Bias?")]
	[SerializeField]
	[FormerlySerializedAs("OverrideGlobalBias")]
	private bool m_OverrideGlobalBias; // 0x5E
	[Tooltip("Synchronize Start and End Values")]
	[FormerlySerializedAs("SynchronizeTCB")]
	[SerializeField]
	private bool m_SynchronizeTCB; // 0x5F
	[Label("Tension", "")]
	[FieldCondition("m_OverrideGlobalTension", True, False, 0, null, 1)]
	[SerializeField]
	[FormerlySerializedAs("StartTension")]
	private float m_StartTension; // 0x60
	[Label("Tension (End)", "")]
	[FieldCondition("m_OverrideGlobalTension", True, False, 0, "m_SynchronizeTCB", False, False)]
	[SerializeField]
	[FormerlySerializedAs("EndTension")]
	private float m_EndTension; // 0x64
	[Label("Continuity", "")]
	[FieldCondition("m_OverrideGlobalContinuity", True, False, 0, null, 1)]
	[SerializeField]
	[FormerlySerializedAs("StartContinuity")]
	private float m_StartContinuity; // 0x68
	[SerializeField]
	[Label("Continuity (End)", "")]
	[FieldCondition("m_OverrideGlobalContinuity", True, False, 0, "m_SynchronizeTCB", False, False)]
	[FormerlySerializedAs("EndContinuity")]
	private float m_EndContinuity; // 0x6C
	[FormerlySerializedAs("StartBias")]
	[SerializeField]
	[FieldCondition("m_OverrideGlobalBias", True, False, 0, null, 1)]
	[Label("Bias", "")]
	private float m_StartBias; // 0x70
	[Label("Bias (End)", "")]
	[FieldCondition("m_OverrideGlobalBias", True, False, 0, "m_SynchronizeTCB", False, False)]
	[SerializeField]
	[FormerlySerializedAs("EndBias")]
	private float m_EndBias; // 0x74
	[SerializeField]
	[HideInInspector]
	private CurvySplineSegment m_FollowUp; // 0x78
	[HideInInspector]
	[SerializeField]
	private ConnectionHeadingEnum m_FollowUpHeading; // 0x80
	[SerializeField]
	[HideInInspector]
	private bool m_ConnectionSyncPosition; // 0x84
	[SerializeField]
	[HideInInspector]
	private bool m_ConnectionSyncRotation; // 0x85
	[HideInInspector]
	[SerializeField]
	private CurvyConnection m_Connection; // 0x88
	private Transform cachedTransform; // 0x90
	[CanBeNull]
	private CurvySplineSegment cachedNextControlPoint; // 0x98
	[CanBeNull]
	private CurvySplineSegment.ThreadSafeData threadSafeData; // 0xA0
	private CurvySpline mSpline; // 0xA8
	private Nullable<Bounds> mBounds; // 0xB0
	private readonly HashSet<CurvyMetadataBase> mMetadata; // 0xD0
	private Nullable<Vector3> lastProcessedLocalPosition; // 0xD8
	private Nullable<Quaternion> lastProcessedLocalRotation; // 0xE8
	private float distance; // 0xFC
	private float length; // 0x100
	private SubArray<Vector3> bSplineP0Array; // 0x108
	private CurvySplineSegment.ControlPointExtrinsicProperties extrinsicProperties; // 0x118
	[NotNull]
	private readonly CurvySplineSegment.Approximations approximations; // 0x130

	// Properties
	[UsedImplicitly]
	[Obsolete("Use GetPositionsApproximation instead")]
	public Vector3[] Approximation { get; set; }
	[Obsolete("Use GetDistancesApproximation instead")]
	[UsedImplicitly]
	public float[] ApproximationDistances { get; set; }
	[Obsolete("Use GetUpsApproximation instead")]
	[UsedImplicitly]
	public Vector3[] ApproximationUp { get; set; }
	[UsedImplicitly]
	[Obsolete("Use GetTangentsApproximation instead")]
	public Vector3[] ApproximationT { get; set; }
	public bool AutoBakeOrientation { get; set; }
	public bool SerializedOrientationAnchor { get; set; }
	public CurvyOrientationSwirl Swirl { get; set; }
	public float SwirlTurns { get; set; }
	public Vector3 HandleIn { get; set; }
	public Vector3 HandleOut { get; set; }
	public Vector3 HandleInPosition { get; set; }
	public Vector3 HandleOutPosition { get; set; }
	public bool AutoHandles { get; set; }
	public float AutoHandleDistance { get; set; }
	public bool SynchronizeTCB { get; set; }
	public bool OverrideGlobalTension { get; set; }
	public bool OverrideGlobalContinuity { get; set; }
	public bool OverrideGlobalBias { get; set; }
	public float StartTension { get; set; }
	public float StartContinuity { get; set; }
	public float StartBias { get; set; }
	public float EndTension { get; set; }
	public float EndContinuity { get; set; }
	public float EndBias { get; set; }
	public TcbParameters EffectiveTcbParameters { get; }
	[CanBeNull]
	public CurvySplineSegment FollowUp { get; set; }
	public ConnectionHeadingEnum FollowUpHeading { get; set; }
	public bool ConnectionSyncPosition { get; set; }
	public bool ConnectionSyncRotation { get; set; }
	public CurvyConnection Connection { get; set; }
	public SubArray<Vector3> PositionsApproximation { get; }
	public SubArray<Vector3> TangentsApproximation { get; }
	public SubArray<Vector3> UpsApproximation { get; }
	public SubArray<float> DistancesApproximation { get; }
	public int CacheSize { get; }
	public Bounds Bounds { get; }
	public float Length { get; set; }
	public float Distance { get; set; }
	public float TF { get; set; }
	public bool IsFirstControlPoint { get; }
	public bool IsLastControlPoint { get; }
	public HashSet<CurvyMetadataBase> Metadata { get; }
	[CanBeNull]
	public CurvySpline Spline { get; }
	public bool HasUnprocessedLocalPosition { get; }
	public bool HasUnprocessedLocalOrientation { get; }
	[UsedImplicitly]
	[Obsolete("Use OrientationInfluencesSpline instead")]
	public bool OrientatinInfluencesSpline { get; }
	public bool OrientationInfluencesSpline { get; }
	private CurvyInterpolation Interpolation { get; }
	private bool IsDynamicOrientation { get; }
	private bool IsOrientationAnchorEditable { get; }
	private bool CanHaveSwirl { get; }
	private SubArray<Vector3> BSplineP0Array { get; }
	private bool CanTouchItsSpline { get; }

	// Methods

	// RVA: 0x4CC6E0 Offset: 0x4CB0E0 VA: 0x1804CC6E0
	public Vector3[] get_Approximation() { }

	// RVA: 0x4CEA20 Offset: 0x4CD420 VA: 0x1804CEA20
	public void set_Approximation(Vector3[] value) { }

	// RVA: 0x4CC470 Offset: 0x4CAE70 VA: 0x1804CC470
	public float[] get_ApproximationDistances() { }

	// RVA: 0x4CE690 Offset: 0x4CD090 VA: 0x1804CE690
	public void set_ApproximationDistances(float[] value) { }

	// RVA: 0x4CC610 Offset: 0x4CB010 VA: 0x1804CC610
	public Vector3[] get_ApproximationUp() { }

	// RVA: 0x4CE8F0 Offset: 0x4CD2F0 VA: 0x1804CE8F0
	public void set_ApproximationUp(Vector3[] value) { }

	// RVA: 0x4CC540 Offset: 0x4CAF40 VA: 0x1804CC540
	public Vector3[] get_ApproximationT() { }

	// RVA: 0x4CE7C0 Offset: 0x4CD1C0 VA: 0x1804CE7C0
	public void set_ApproximationT(Vector3[] value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_AutoBakeOrientation() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_AutoBakeOrientation(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_SerializedOrientationAnchor() { }

	// RVA: 0x4CF7D0 Offset: 0x4CE1D0 VA: 0x1804CF7D0
	public void set_SerializedOrientationAnchor(bool value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public CurvyOrientationSwirl get_Swirl() { }

	// RVA: 0x4CFB20 Offset: 0x4CE520 VA: 0x1804CFB20
	public void set_Swirl(CurvyOrientationSwirl value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_SwirlTurns() { }

	// RVA: 0x4CFA80 Offset: 0x4CE480 VA: 0x1804CFA80
	public void set_SwirlTurns(float value) { }

	// RVA: 0x4CD310 Offset: 0x4CBD10 VA: 0x1804CD310
	public Vector3 get_HandleIn() { }

	// RVA: 0x4CF2F0 Offset: 0x4CDCF0 VA: 0x1804CF2F0
	public void set_HandleIn(Vector3 value) { }

	// RVA: 0x4CD420 Offset: 0x4CBE20 VA: 0x1804CD420
	public Vector3 get_HandleOut() { }

	// RVA: 0x4CF4E0 Offset: 0x4CDEE0 VA: 0x1804CF4E0
	public void set_HandleOut(Vector3 value) { }

	// RVA: 0x4CD220 Offset: 0x4CBC20 VA: 0x1804CD220
	public Vector3 get_HandleInPosition() { }

	// RVA: 0x4CF200 Offset: 0x4CDC00 VA: 0x1804CF200
	public void set_HandleInPosition(Vector3 value) { }

	// RVA: 0x4CD330 Offset: 0x4CBD30 VA: 0x1804CD330
	public Vector3 get_HandleOutPosition() { }

	// RVA: 0x4CF3F0 Offset: 0x4CDDF0 VA: 0x1804CF3F0
	public void set_HandleOutPosition(Vector3 value) { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_AutoHandles() { }

	// RVA: 0x4CEBE0 Offset: 0x4CD5E0 VA: 0x1804CEBE0
	public void set_AutoHandles(bool value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_AutoHandleDistance() { }

	// RVA: 0x4CEB60 Offset: 0x4CD560 VA: 0x1804CEB60
	public void set_AutoHandleDistance(float value) { }

	// RVA: 0x4CDA10 Offset: 0x4CC410 VA: 0x1804CDA10
	public bool get_SynchronizeTCB() { }

	// RVA: 0x4CFBC0 Offset: 0x4CE5C0 VA: 0x1804CFBC0
	public void set_SynchronizeTCB(bool value) { }

	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	public bool get_OverrideGlobalTension() { }

	// RVA: 0x4CF730 Offset: 0x4CE130 VA: 0x1804CF730
	public void set_OverrideGlobalTension(bool value) { }

	// RVA: 0x4CD970 Offset: 0x4CC370 VA: 0x1804CD970
	public bool get_OverrideGlobalContinuity() { }

	// RVA: 0x4CF690 Offset: 0x4CE090 VA: 0x1804CF690
	public void set_OverrideGlobalContinuity(bool value) { }

	// RVA: 0x4CD960 Offset: 0x4CC360 VA: 0x1804CD960
	public bool get_OverrideGlobalBias() { }

	// RVA: 0x4CF5F0 Offset: 0x4CDFF0 VA: 0x1804CF5F0
	public void set_OverrideGlobalBias(bool value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_StartTension() { }

	// RVA: 0x4CF9D0 Offset: 0x4CE3D0 VA: 0x1804CF9D0
	public void set_StartTension(float value) { }

	// RVA: 0x4CD9E0 Offset: 0x4CC3E0 VA: 0x1804CD9E0
	public float get_StartContinuity() { }

	// RVA: 0x4CF920 Offset: 0x4CE320 VA: 0x1804CF920
	public void set_StartContinuity(float value) { }

	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_StartBias() { }

	// RVA: 0x4CF870 Offset: 0x4CE270 VA: 0x1804CF870
	public void set_StartBias(float value) { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float get_EndTension() { }

	// RVA: 0x4CEFB0 Offset: 0x4CD9B0 VA: 0x1804CEFB0
	public void set_EndTension(float value) { }

	// RVA: 0x4CD190 Offset: 0x4CBB90 VA: 0x1804CD190
	public float get_EndContinuity() { }

	// RVA: 0x4CEF00 Offset: 0x4CD900 VA: 0x1804CEF00
	public void set_EndContinuity(float value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_EndBias() { }

	// RVA: 0x4CEE50 Offset: 0x4CD850 VA: 0x1804CEE50
	public void set_EndBias(float value) { }

	// RVA: 0x4CD0D0 Offset: 0x4CBAD0 VA: 0x1804CD0D0
	public TcbParameters get_EffectiveTcbParameters() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public CurvySplineSegment get_FollowUp() { }

	// RVA: 0x4CF150 Offset: 0x4CDB50 VA: 0x1804CF150
	private void set_FollowUp(CurvySplineSegment value) { }

	// RVA: 0x4CD1B0 Offset: 0x4CBBB0 VA: 0x1804CD1B0
	public ConnectionHeadingEnum get_FollowUpHeading() { }

	// RVA: 0x4CF060 Offset: 0x4CDA60 VA: 0x1804CF060
	public void set_FollowUpHeading(ConnectionHeadingEnum value) { }

	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060
	public bool get_ConnectionSyncPosition() { }

	// RVA: 0x4CED80 Offset: 0x4CD780 VA: 0x1804CED80
	public void set_ConnectionSyncPosition(bool value) { }

	// RVA: 0x4CD070 Offset: 0x4CBA70 VA: 0x1804CD070
	public bool get_ConnectionSyncRotation() { }

	// RVA: 0x4CED90 Offset: 0x4CD790 VA: 0x1804CED90
	public void set_ConnectionSyncRotation(bool value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public CurvyConnection get_Connection() { }

	// RVA: 0x4CEDA0 Offset: 0x4CD7A0 VA: 0x1804CEDA0
	internal void set_Connection(CurvyConnection value) { }

	// RVA: 0x4CD990 Offset: 0x4CC390 VA: 0x1804CD990
	public SubArray<Vector3> get_PositionsApproximation() { }

	// RVA: 0x4CDA50 Offset: 0x4CC450 VA: 0x1804CDA50
	public SubArray<Vector3> get_TangentsApproximation() { }

	// RVA: 0x4CDA80 Offset: 0x4CC480 VA: 0x1804CDA80
	public SubArray<Vector3> get_UpsApproximation() { }

	// RVA: 0x4CD0A0 Offset: 0x4CBAA0 VA: 0x1804CD0A0
	public SubArray<float> get_DistancesApproximation() { }

	// RVA: 0x4CCE70 Offset: 0x4CB870 VA: 0x1804CCE70
	public int get_CacheSize() { }

	// RVA: 0x4CC950 Offset: 0x4CB350 VA: 0x1804CC950
	public Bounds get_Bounds() { }

	// RVA: 0x4CD8A0 Offset: 0x4CC2A0 VA: 0x1804CD8A0
	public float get_Length() { }

	// RVA: 0x4CF5E0 Offset: 0x4CDFE0 VA: 0x1804CF5E0
	private void set_Length(float value) { }

	// RVA: 0x4CD090 Offset: 0x4CBA90 VA: 0x1804CD090
	public float get_Distance() { }

	// RVA: 0x4CEE40 Offset: 0x4CD840 VA: 0x1804CEE40
	internal void set_Distance(float value) { }

	// RVA: 0x4CDA20 Offset: 0x4CC420 VA: 0x1804CDA20
	public float get_TF() { }

	[Obsolete("Setting a TF value is not allowed anymore")]
	[UsedImplicitly]
	// RVA: 0x4CFC60 Offset: 0x4CE660 VA: 0x1804CFC60
	internal void set_TF(float value) { }

	// RVA: 0x4CD6D0 Offset: 0x4CC0D0 VA: 0x1804CD6D0
	public bool get_IsFirstControlPoint() { }

	// RVA: 0x4CD700 Offset: 0x4CC100 VA: 0x1804CD700
	public bool get_IsLastControlPoint() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public HashSet<CurvyMetadataBase> get_Metadata() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public CurvySpline get_Spline() { }

	// RVA: 0x4CD4F0 Offset: 0x4CBEF0 VA: 0x1804CD4F0
	public bool get_HasUnprocessedLocalPosition() { }

	// RVA: 0x4CD440 Offset: 0x4CBE40 VA: 0x1804CD440
	public bool get_HasUnprocessedLocalOrientation() { }

	// RVA: 0x4CD8B0 Offset: 0x4CC2B0 VA: 0x1804CD8B0
	public bool get_OrientatinInfluencesSpline() { }

	// RVA: 0x4CD8C0 Offset: 0x4CC2C0 VA: 0x1804CD8C0
	public bool get_OrientationInfluencesSpline() { }

	// RVA: 0x4C9E50 Offset: 0x4C8850 VA: 0x1804C9E50
	public void SetBezierHandleIn(Vector3 position, Space space = 1, CurvyBezierModeEnum mode = 0) { }

	// RVA: 0x4CA4E0 Offset: 0x4C8EE0 VA: 0x1804CA4E0
	public void SetBezierHandleOut(Vector3 position, Space space = 1, CurvyBezierModeEnum mode = 0) { }

	// RVA: 0x4CADE0 Offset: 0x4C97E0 VA: 0x1804CADE0
	public void SetBezierHandles(float distanceFrag = -1, bool setIn = True, bool setOut = True, bool noDirtying = False) { }

	// RVA: 0x4CAB80 Offset: 0x4C9580 VA: 0x1804CAB80
	public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = True, bool setOut = True, bool noDirtying = False) { }

	// RVA: 0x4CB280 Offset: 0x4C9C80 VA: 0x1804CB280
	public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = 2) { }

	// RVA: 0x4C9B40 Offset: 0x4C8540 VA: 0x1804C9B40
	public void ResetConnectionUnrelatedProperties() { }

	// RVA: 0x4C7560 Offset: 0x4C5F60 VA: 0x1804C7560
	public void Disconnect() { }

	// RVA: 0x4C74A0 Offset: 0x4C5EA0 VA: 0x1804C74A0
	public void Disconnect(bool destroyEmptyConnection) { }

	// RVA: 0x4C8DD0 Offset: 0x4C77D0 VA: 0x1804C8DD0
	public Vector3 Interpolate(float localF, Space space = 1) { }

	// RVA: 0x4C8C20 Offset: 0x4C7620 VA: 0x1804C8C20
	public Vector3 InterpolateFast(float localF, Space space = 1) { }

	// RVA: 0x4C86E0 Offset: 0x4C70E0 VA: 0x1804C86E0
	public Vector3 GetTangent(float localF, Space space = 1) { }

	// RVA: 0x4C8450 Offset: 0x4C6E50 VA: 0x1804C8450
	public Vector3 GetTangent(float localF, Vector3 position, Space space = 1) { }

	// RVA: 0x4C82A0 Offset: 0x4C6CA0 VA: 0x1804C82A0
	public Vector3 GetTangentFast(float localF, Space space = 1) { }

	// RVA: 0x4C8B50 Offset: 0x4C7550 VA: 0x1804C8B50
	public void InterpolateAndGetTangent(float localF, out Vector3 position, out Vector3 tangent, Space space = 1) { }

	// RVA: 0x4C8890 Offset: 0x4C7290 VA: 0x1804C8890
	public void InterpolateAndGetTangentFast(float localF, out Vector3 position, out Vector3 tangent, Space space = 1) { }

	// RVA: 0x4C8040 Offset: 0x4C6A40 VA: 0x1804C8040
	public Vector3 GetOrientationUpFast(float localF, Space space = 1) { }

	// RVA: 0x4C7C00 Offset: 0x4C6600 VA: 0x1804C7C00
	public Quaternion GetOrientationFast(float localF, bool inverse = False, Space space = 1) { }

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	[UsedImplicitly]
	// RVA: 0x4C9A60 Offset: 0x4C8460 VA: 0x1804C9A60
	public void ReloadMetaData() { }

	// RVA: 0x4C99F0 Offset: 0x4C83F0 VA: 0x1804C99F0
	public void RegisterMetaData(CurvyMetadataBase metaData) { }

	// RVA: 0x4CBE50 Offset: 0x4CA850 VA: 0x1804CBE50
	public void UnregisterMetaData(CurvyMetadataBase metaData) { }

	// RVA: -1 Offset: -1
	public T GetMetadata<T>(bool autoCreate = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6F0D0 Offset: 0xE6DAD0 VA: 0x180E6F0D0
	|-CurvySplineSegment.GetMetadata<object>
	*/

	// RVA: -1 Offset: -1
	public U GetInterpolatedMetadata<T, U>(float f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EFA0 Offset: 0xE6D9A0 VA: 0x180E6EFA0
	|-CurvySplineSegment.GetInterpolatedMetadata<object, float>
	|
	|-RVA: 0xE6EDC0 Offset: 0xE6D7C0 VA: 0x180E6EDC0
	|-CurvySplineSegment.GetInterpolatedMetadata<object, __Il2CppFullySharedGenericType>
	*/

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x4C7400 Offset: 0x4C5E00 VA: 0x1804C7400
	public void DeleteMetadata() { }

	// RVA: 0x4C7B00 Offset: 0x4C6500 VA: 0x1804C7B00
	public float GetNearestPointF(Vector3 position, Space space = 1) { }

	// RVA: 0x4C7610 Offset: 0x4C6010 VA: 0x1804C7610
	public float DistanceToLocalF(float localDistance) { }

	// RVA: 0x4C9370 Offset: 0x4C7D70 VA: 0x1804C9370
	public float LocalFToDistance(float localF) { }

	// RVA: 0x4C9470 Offset: 0x4C7E70 VA: 0x1804C9470
	public float LocalFToTF(float localF) { }

	// RVA: 0x4CBCE0 Offset: 0x4CA6E0 VA: 0x1804CBCE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x4C7090 Offset: 0x4C5A90 VA: 0x1804C7090
	public void BakeOrientationToTransform() { }

	// RVA: 0x4CC180 Offset: 0x4CAB80 VA: 0x1804CC180
	public int getApproximationIndexINTERNAL(float localF, out float frag) { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void LinkToSpline(CurvySpline spline) { }

	[Obsolete("Use the other overload instead")]
	[UsedImplicitly]
	// RVA: 0x4CBE30 Offset: 0x4CA830 VA: 0x1804CBE30
	public void UnlinkFromSpline() { }

	// RVA: 0x4CBDA0 Offset: 0x4CA7A0 VA: 0x1804CBDA0
	public void UnlinkFromSpline(CurvySpline spline) { }

	// RVA: 0x4CB420 Offset: 0x4C9E20 VA: 0x1804CB420
	public void SetLocalPosition(Vector3 newPosition) { }

	// RVA: 0x4CB880 Offset: 0x4CA280 VA: 0x1804CB880
	public void SetPosition(Vector3 value) { }

	// RVA: 0x4CB650 Offset: 0x4CA050 VA: 0x1804CB650
	public void SetLocalRotation(Quaternion value) { }

	// RVA: 0x4CBAB0 Offset: 0x4CA4B0 VA: 0x1804CBAB0
	public void SetRotation(Quaternion value) { }

	// RVA: 0x4C7170 Offset: 0x4C5B70 VA: 0x1804C7170
	public static bool CanFollowUpHeadToStart(CurvySplineSegment followUp) { }

	// RVA: 0x4C7130 Offset: 0x4C5B30 VA: 0x1804C7130
	public static bool CanFollowUpHeadToEnd(CurvySplineSegment followUp) { }

	// RVA: 0x4C6E30 Offset: 0x4C5830 VA: 0x1804C6E30
	public static Vector3 BSpline(ReadOnlyCollection<CurvySplineSegment> controlPoints, float tf, bool isClamped, bool isClosed, int degree, Vector3[] p0Array) { }

	// RVA: 0x4C94B0 Offset: 0x4C7EB0 VA: 0x1804C94B0 Slot: 9
	public void OnBeforePush() { }

	// RVA: 0x4C94A0 Offset: 0x4C7EA0 VA: 0x1804C94A0 Slot: 10
	public void OnAfterPop() { }

	[UsedImplicitly]
	// RVA: 0x4C6DF0 Offset: 0x4C57F0 VA: 0x1804C6DF0
	private void Awake() { }

	// RVA: 0x4C9700 Offset: 0x4C8100 VA: 0x1804C9700 Slot: 4
	protected override void OnEnable() { }

	[UsedImplicitly]
	// RVA: 0x4C9610 Offset: 0x4C8010 VA: 0x1804C9610
	private void OnDestroy() { }

	// RVA: 0x4C97F0 Offset: 0x4C81F0 VA: 0x1804C97F0 Slot: 7
	protected override void OnValidate() { }

	[UsedImplicitly]
	[Obsolete("Use ResetConnectionUnrelatedProperties instead")]
	// RVA: 0x4C9D10 Offset: 0x4C8710 VA: 0x1804C9D10
	public void Reset() { }

	// RVA: 0x4CD5C0 Offset: 0x4CBFC0 VA: 0x1804CD5C0
	private CurvyInterpolation get_Interpolation() { }

	// RVA: 0x4CD640 Offset: 0x4CC040 VA: 0x1804CD640
	private bool get_IsDynamicOrientation() { }

	// RVA: 0x4CD760 Offset: 0x4CC160 VA: 0x1804CD760
	private bool get_IsOrientationAnchorEditable() { }

	// RVA: 0x4CCEA0 Offset: 0x4CB8A0 VA: 0x1804CCEA0
	private bool get_CanHaveSwirl() { }

	// RVA: 0x4CC7B0 Offset: 0x4CB1B0 VA: 0x1804CC7B0
	private SubArray<Vector3> get_BSplineP0Array() { }

	// RVA: 0x4C79F0 Offset: 0x4C63F0 VA: 0x1804C79F0
	private static void GetBSplineP0s(ReadOnlyCollection<CurvySplineSegment> controlPoints, int controlPointsCount, int degree, int k, Vector3[] pArray) { }

	// RVA: 0x4CB260 Offset: 0x4C9C60 VA: 0x1804CB260
	internal void SetExtrinsicPropertiesINTERNAL(CurvySplineSegment.ControlPointExtrinsicProperties value) { }

	// RVA: 0x4C7AF0 Offset: 0x4C64F0 VA: 0x1804C7AF0
	internal ref CurvySplineSegment.ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL() { }

	// RVA: 0x4CCFF0 Offset: 0x4CB9F0 VA: 0x1804CCFF0
	private bool get_CanTouchItsSpline() { }

	// RVA: 0x4C7700 Offset: 0x4C6100 VA: 0x1804C7700
	private void DoInitialValidations() { }

	// RVA: 0x4C71B0 Offset: 0x4C5BB0 VA: 0x1804C71B0
	private void CheckAgainstMetaDataDuplication() { }

	// RVA: 0x4CB150 Offset: 0x4C9B50 VA: 0x1804CB150
	private bool SetConnection(CurvyConnection newConnection) { }

	// RVA: 0x4C8790 Offset: 0x4C7190 VA: 0x1804C8790
	private static ConnectionHeadingEnum GetValidateConnectionHeading(ConnectionHeadingEnum connectionHeading, CurvySplineSegment followUp) { }

	// RVA: 0x4C9D30 Offset: 0x4C8730 VA: 0x1804C9D30
	private bool SetAutoHandles(bool newValue) { }

	// RVA: 0x4C9920 Offset: 0x4C8320 VA: 0x1804C9920
	internal void PrepareThreadCompatibleDataINTERNAL(bool useFollowUp) { }

	// RVA: 0x4CDAB0 Offset: 0x4CC4B0 VA: 0x1804CDAB0
	internal void refreshCurveINTERNAL() { }

	// RVA: 0x4C81F0 Offset: 0x4C6BF0 VA: 0x1804C81F0
	private int GetSegmentCacheSize() { }

	// RVA: 0x4CE280 Offset: 0x4CCC80 VA: 0x1804CE280
	internal void refreshOrientationNoneINTERNAL() { }

	// RVA: 0x4CE2E0 Offset: 0x4CCCE0 VA: 0x1804CE2E0
	internal void refreshOrientationStaticINTERNAL() { }

	// RVA: 0x4CE220 Offset: 0x4CCC20 VA: 0x1804CE220
	internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp) { }

	[UsedImplicitly]
	// RVA: 0x4CBEE0 Offset: 0x4CA8E0 VA: 0x1804CBEE0
	private void UpdateLasProcessedLocalPosition() { }

	[UsedImplicitly]
	// RVA: 0x4CBF60 Offset: 0x4CA960 VA: 0x1804CBF60
	private void UpdateLasProcessedLocalRotation() { }

	// RVA: 0x4C73E0 Offset: 0x4C5DE0 VA: 0x1804C73E0
	internal void ClearBoundsINTERNAL() { }

	// RVA: 0x4CC200 Offset: 0x4CAC00 VA: 0x1804CC200
	internal Vector3 getOrthoUp0INTERNAL() { }

	// RVA: 0x4CC2F0 Offset: 0x4CACF0 VA: 0x1804CC2F0
	private Vector3 getOrthoUp1INTERNAL() { }

	// RVA: 0x4CBEB0 Offset: 0x4CA8B0 VA: 0x1804CBEB0
	internal void UnsetFollowUpWithoutDirtyingINTERNAL() { }

	[Conditional("CURVY_SANITY_CHECKS")]
	// RVA: 0x4C7870 Offset: 0x4C6270 VA: 0x1804C7870
	private void DoSanityChecks() { }

	[UsedImplicitly]
	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UpdateSelectionIfNeeded() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void ForceHierarchyDrawing() { }

	// RVA: 0x4C9C70 Offset: 0x4C8670 VA: 0x1804C9C70 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x4CC030 Offset: 0x4CAA30 VA: 0x1804CC030
	public void .ctor() { }

	// RVA: 0x4CBFF0 Offset: 0x4CA9F0 VA: 0x1804CBFF0
	private static void .cctor() { }
}
