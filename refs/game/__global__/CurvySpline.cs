public class CurvySpline : DTVersionedMonoBehaviour // TypeDefIndex: 10537
{
	// Fields
	[Obsolete("Use FluffyUnderware.Curvy.AssetInformation instead")]
	public const string VERSION = "8.5.0";
	[Obsolete("Use FluffyUnderware.Curvy.AssetInformation instead")]
	public const string APIVERSION = "850";
	[Obsolete("Use FluffyUnderware.Curvy.AssetInformation instead")]
	public const string WEBROOT = "https://curvyeditor.com/";
	[Obsolete("Use FluffyUnderware.Curvy.AssetInformation instead")]
	public const string DOCLINK = "https://curvyeditor.com/doclink/";
	[HideInInspector]
	public bool ShowGizmos; // 0x30
	[HideInInspector]
	[SerializeField]
	[NotNull]
	private List<CurvySplineSegment> ControlPoints; // 0x38
	[Section("General", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_general")]
	[FormerlySerializedAs("Interpolation")]
	[SerializeField]
	[Tooltip("Interpolation Method")]
	private CurvyInterpolation m_Interpolation; // 0x40
	[SerializeField]
	[Tooltip("Restrict Control Points to a local 2D plane")]
	private bool m_RestrictTo2D; // 0x44
	[FieldAction("CBCheck2DPlanar", 7)]
	[Tooltip("The local 2D plane to restrict the spline's control points to")]
	[SerializeField]
	[FieldCondition("RestrictTo2D", True, False, 0, null, 1)]
	private CurvyPlane restricted2DPlane; // 0x48
	[FormerlySerializedAs("Closed")]
	[SerializeField]
	private bool m_Closed; // 0x4C
	[FieldCondition("CanHaveManualEndCp", Action = 2)]
	[Tooltip("Handle End Control Points automatically?")]
	[SerializeField]
	[FormerlySerializedAs("AutoEndTangents")]
	private bool m_AutoEndTangents; // 0x4D
	[Tooltip("Orientation Flow")]
	[SerializeField]
	[FormerlySerializedAs("Orientation")]
	private CurvyOrientation m_Orientation; // 0x50
	[Section("Global Bezier Options", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_bezier")]
	[GroupCondition("m_Interpolation", 3, False)]
	[SerializeField]
	[RangeEx(0, 1, "Default Distance %", "Handle length by distance to neighbours")]
	private float m_AutoHandleDistance; // 0x54
	[Section("Global TCB Options", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_tcb")]
	[GroupAction("TCBOptionsGUI", 7, Position = 1)]
	[GroupCondition("m_Interpolation", 2, False)]
	[FormerlySerializedAs("Tension")]
	[SerializeField]
	private float m_Tension; // 0x58
	[FormerlySerializedAs("Continuity")]
	[SerializeField]
	private float m_Continuity; // 0x5C
	[SerializeField]
	[FormerlySerializedAs("Bias")]
	private float m_Bias; // 0x60
	[SerializeField]
	[RangeEx(2, "MaxBSplineDegree", "Degree", "The degree of the piecewise polynomial functions.
Is in the range [2; control points count - 1]")]
	[GroupCondition("m_Interpolation", 4, False)]
	[Section("B-Spline Options", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_bspline")]
	private int bSplineDegree; // 0x64
	[Label("Clamped", "Make the curve pass through the first and last control points by increasing the multiplicity of the first and last knots.

In technical terms, when this parameter is true, the knot vector is [0, 0, ...,0, 1, 2, ..., N-1, N, N, ..., N]. When false, it is [0, 1, 2, ..., N-1, N]")]
	[SerializeField]
	[FieldCondition("CanBeClamped", Action = 2)]
	private bool isBSplineClamped; // 0x68
	[SerializeField]
	[Label("Color", "Gizmo color")]
	[FieldAction("ShowGizmoGUI", 7, Position = 0)]
	[Section("Advanced Settings", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_advanced")]
	private Color m_GizmoColor; // 0x6C
	[SerializeField]
	[FieldAction("CheckGizmoColor", 7, Position = 0)]
	[FieldAction("CheckGizmoSelectionColor", 7, Position = 1)]
	[Label("Active Color", "Selected Gizmo color")]
	private Color m_GizmoSelectionColor; // 0x7C
	[SerializeField]
	[RangeEx(1, 100, "", "")]
	[Tooltip("Defines how densely the cached points are. When the value is 100, the number of cached points per world distance unit is equal to the spline's MaxPointsPerUnit")]
	[FormerlySerializedAs("Granularity")]
	private int m_CacheDensity; // 0x8C
	[Tooltip("The maximum number of sampling points per world distance unit. Sampling is used in caching or shape extrusion for example")]
	[SerializeField]
	private float m_MaxPointsPerUnit; // 0x90
	[SerializeField]
	[Tooltip("Use a GameObject pool at runtime")]
	private bool m_UsePooling; // 0x94
	[SerializeField]
	[Tooltip("Use threading where applicable. Threading is is currently not supported when targetting WebGL and Universal Windows Platform")]
	private bool m_UseThreading; // 0x95
	[FormerlySerializedAs("AutoRefresh")]
	[SerializeField]
	[Tooltip("Refresh when Control Point position change?")]
	private bool m_CheckTransform; // 0x96
	[SerializeField]
	private CurvyUpdateMethod m_UpdateIn; // 0x98
	[SerializeField]
	[Group("Events", Expanded = False, Sort = 1000, HelpURL = "https://curvyeditor.com/doclink/curvyspline_events")]
	protected CurvySplineEvent onInitialized; // 0xA0
	[Group("Events", Sort = 1000)]
	[SerializeField]
	protected CurvySplineEvent m_OnRefresh; // 0xA8
	[SerializeField]
	[Group("Events", Sort = 1000)]
	protected CurvySplineEvent m_OnAfterControlPointChanges; // 0xB0
	[SerializeField]
	[Group("Events", Sort = 1000)]
	protected CurvyControlPointEvent m_OnBeforeControlPointAdd; // 0xB8
	[SerializeField]
	[Group("Events", Sort = 1000)]
	protected CurvyControlPointEvent m_OnAfterControlPointAdd; // 0xC0
	[Group("Events", Sort = 1000)]
	[SerializeField]
	protected CurvyControlPointEvent m_OnBeforeControlPointDelete; // 0xC8
	private Action<CurvySpline> onGlobalCoordinatesChanged; // 0xD0
	private bool mIsInitialized; // 0xD8
	private bool isStarted; // 0xD9
	private bool sendOnRefreshEventNextUpdate; // 0xDA
	private readonly List<CurvySplineSegment> mSegments; // 0xE0
	private readonly CurvySpline.DirtinessManager dirtinessManager; // 0xE8
	private readonly CurvySpline.RelationshipCache relationshipCache; // 0xF0
	[NotNull]
	private readonly CurvySpline.SanityChecker sanityChecker; // 0xF8
	[NotNull]
	private readonly CurvySpline.ControlPointsSynchronizer cpsSynchronizer; // 0x100
	[NotNull]
	private readonly CurvySpline.ControlPointNamer controlPointNamer; // 0x108
	[CanBeNull]
	private TransformMonitor transformMonitor; // 0x110
	private Transform cachedTransform; // 0x118
	private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints; // 0x120
	private short[] cachedShortsArray; // 0x128
	private float[] controlPointsDistances; // 0x130
	private readonly Action<CurvySplineSegment, int, int> refreshCurveAction; // 0x138
	private float length; // 0x140
	private int mCacheSize; // 0x144
	private Nullable<Bounds> mBounds; // 0x148
	private readonly CurvySplineEventArgs defaultSplineEventArgs; // 0x168
	private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs; // 0x170
	private readonly CurvyControlPointEventArgs defaultDeleteEventArgs; // 0x178
	private const short CachedControlPointsNameCount = 250;
	private const float MinimalMaxPointsPerUnit = 0.0001;
	private const float MaxSegmentCacheSize = 1000000;
	private const string InvalidCPErrorMessage = "[Curvy] Method called with a control point \'{0}\' that is not part of the current spline \'{1}\'";
	private const int MinBSplineDegree = 2;

	// Properties
	public CurvyInterpolation Interpolation { get; set; }
	public bool RestrictTo2D { get; set; }
	public CurvyPlane Restricted2DPlane { get; set; }
	public float AutoHandleDistance { get; set; }
	public bool Closed { get; set; }
	public bool AutoEndTangents { get; set; }
	public CurvyOrientation Orientation { get; set; }
	public CurvyUpdateMethod UpdateIn { get; set; }
	public Color GizmoColor { get; set; }
	public Color GizmoSelectionColor { get; set; }
	public int CacheDensity { get; set; }
	public float MaxPointsPerUnit { get; set; }
	public bool UsePooling { get; set; }
	public bool UseThreading { get; set; }
	public bool CheckTransform { get; set; }
	public float Tension { get; set; }
	public float Continuity { get; set; }
	public float Bias { get; set; }
	public int BSplineDegree { get; set; }
	public bool IsBSplineClamped { get; set; }
	public bool IsInitialized { get; }
	public Bounds Bounds { get; }
	public int Count { get; }
	public int ControlPointCount { get; }
	public int CacheSize { get; }
	public float Length { get; }
	public bool Dirty { get; }
	public CurvySplineSegment Item { get; }
	public ReadOnlyCollection<CurvySplineSegment> ControlPointsList { get; }
	[CanBeNull]
	public CurvySplineSegment FirstVisibleControlPoint { get; }
	[CanBeNull]
	public CurvySplineSegment LastVisibleControlPoint { get; }
	[CanBeNull]
	public CurvySplineSegment FirstSegment { get; }
	[CanBeNull]
	public CurvySplineSegment LastSegment { get; }
	public bool GlobalCoordinatesChangedThisFrame { get; }
	[CanBeNull]
	public Action<CurvySpline> OnGlobalCoordinatesChanged { get; set; }
	public CurvySplineEvent OnRefresh { get; set; }
	public CurvySplineEvent OnInitialized { get; set; }
	public CurvySplineEvent OnAfterControlPointChanges { get; set; }
	public CurvyControlPointEvent OnBeforeControlPointAdd { get; set; }
	public CurvyControlPointEvent OnAfterControlPointAdd { get; set; }
	public CurvyControlPointEvent OnBeforeControlPointDelete { get; set; }
	[NotNull]
	private TransformMonitor TransformMonitor { get; }
	private List<CurvySplineSegment> Segments { get; }
	private int MaxBSplineDegree { get; }

	// Methods

	// RVA: 0x4B4D50 Offset: 0x4B3750 VA: 0x1804B4D50
	public void .ctor() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public CurvyInterpolation get_Interpolation() { }

	// RVA: 0x4B6990 Offset: 0x4B5390 VA: 0x1804B6990
	public void set_Interpolation(CurvyInterpolation value) { }

	// RVA: 0x495FF0 Offset: 0x4949F0 VA: 0x180495FF0
	public bool get_RestrictTo2D() { }

	// RVA: 0x4B6E10 Offset: 0x4B5810 VA: 0x1804B6E10
	public void set_RestrictTo2D(bool value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public CurvyPlane get_Restricted2DPlane() { }

	// RVA: 0x4B6EE0 Offset: 0x4B58E0 VA: 0x1804B6EE0
	public void set_Restricted2DPlane(CurvyPlane value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_AutoHandleDistance() { }

	// RVA: 0x4B6380 Offset: 0x4B4D80 VA: 0x1804B6380
	public void set_AutoHandleDistance(float value) { }

	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	public bool get_Closed() { }

	// RVA: 0x4B6830 Offset: 0x4B5230 VA: 0x1804B6830
	public void set_Closed(bool value) { }

	// RVA: 0x4B5410 Offset: 0x4B3E10 VA: 0x1804B5410
	public bool get_AutoEndTangents() { }

	// RVA: 0x4B6300 Offset: 0x4B4D00 VA: 0x1804B6300
	public void set_AutoEndTangents(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public CurvyOrientation get_Orientation() { }

	// RVA: 0x4B6D40 Offset: 0x4B5740 VA: 0x1804B6D40
	public void set_Orientation(CurvyOrientation value) { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public CurvyUpdateMethod get_UpdateIn() { }

	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	public void set_UpdateIn(CurvyUpdateMethod value) { }

	// RVA: 0x4B5E00 Offset: 0x4B4800 VA: 0x1804B5E00
	public Color get_GizmoColor() { }

	// RVA: 0x4B6970 Offset: 0x4B5370 VA: 0x1804B6970
	public void set_GizmoColor(Color value) { }

	// RVA: 0x4B5E10 Offset: 0x4B4810 VA: 0x1804B5E10
	public Color get_GizmoSelectionColor() { }

	// RVA: 0x4B6980 Offset: 0x4B5380 VA: 0x1804B6980
	public void set_GizmoSelectionColor(Color value) { }

	// RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0
	public int get_CacheDensity() { }

	// RVA: 0x4B6670 Offset: 0x4B5070 VA: 0x1804B6670
	public void set_CacheDensity(int value) { }

	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	public float get_MaxPointsPerUnit() { }

	// RVA: 0x4B6B60 Offset: 0x4B5560 VA: 0x1804B6B60
	public void set_MaxPointsPerUnit(float value) { }

	// RVA: 0x4B62E0 Offset: 0x4B4CE0 VA: 0x1804B62E0
	public bool get_UsePooling() { }

	// RVA: 0x4B70A0 Offset: 0x4B5AA0 VA: 0x1804B70A0
	public void set_UsePooling(bool value) { }

	// RVA: 0x4B62F0 Offset: 0x4B4CF0 VA: 0x1804B62F0
	public bool get_UseThreading() { }

	// RVA: 0x4B70B0 Offset: 0x4B5AB0 VA: 0x1804B70B0
	public void set_UseThreading(bool value) { }

	// RVA: 0x4B5BE0 Offset: 0x4B45E0 VA: 0x1804B5BE0
	public bool get_CheckTransform() { }

	// RVA: 0x4B6760 Offset: 0x4B5160 VA: 0x1804B6760
	public void set_CheckTransform(bool value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_Tension() { }

	// RVA: 0x4B6FB0 Offset: 0x4B59B0 VA: 0x1804B6FB0
	public void set_Tension(float value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_Continuity() { }

	// RVA: 0x4B6890 Offset: 0x4B5290 VA: 0x1804B6890
	public void set_Continuity(float value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_Bias() { }

	// RVA: 0x4B6590 Offset: 0x4B4F90 VA: 0x1804B6590
	public void set_Bias(float value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_BSplineDegree() { }

	// RVA: 0x4B6470 Offset: 0x4B4E70 VA: 0x1804B6470
	public void set_BSplineDegree(int value) { }

	// RVA: 0x4B5E50 Offset: 0x4B4850 VA: 0x1804B5E50
	public bool get_IsBSplineClamped() { }

	// RVA: 0x4B6A90 Offset: 0x4B5490 VA: 0x1804B6A90
	public void set_IsBSplineClamped(bool value) { }

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	public bool get_IsInitialized() { }

	// RVA: 0x4B5450 Offset: 0x4B3E50 VA: 0x1804B5450
	public Bounds get_Bounds() { }

	// RVA: 0x4B5CC0 Offset: 0x4B46C0 VA: 0x1804B5CC0
	public int get_Count() { }

	// RVA: 0x4B5C10 Offset: 0x4B4610 VA: 0x1804B5C10
	public int get_ControlPointCount() { }

	// RVA: 0x4B5AC0 Offset: 0x4B44C0 VA: 0x1804B5AC0
	public int get_CacheSize() { }

	// RVA: 0x4B5F70 Offset: 0x4B4970 VA: 0x1804B5F70
	public float get_Length() { }

	// RVA: 0x4B5D20 Offset: 0x4B4720 VA: 0x1804B5D20
	public bool get_Dirty() { }

	// RVA: 0x4B5E80 Offset: 0x4B4880 VA: 0x1804B5E80
	public CurvySplineSegment get_Item(int idx) { }

	// RVA: 0x4B5C50 Offset: 0x4B4650 VA: 0x1804B5C50
	public ReadOnlyCollection<CurvySplineSegment> get_ControlPointsList() { }

	// RVA: 0x4B5DC0 Offset: 0x4B47C0 VA: 0x1804B5DC0
	public CurvySplineSegment get_FirstVisibleControlPoint() { }

	// RVA: 0x4B5F30 Offset: 0x4B4930 VA: 0x1804B5F30
	public CurvySplineSegment get_LastVisibleControlPoint() { }

	// RVA: 0x4B5D80 Offset: 0x4B4780 VA: 0x1804B5D80
	public CurvySplineSegment get_FirstSegment() { }

	// RVA: 0x4B5EF0 Offset: 0x4B48F0 VA: 0x1804B5EF0
	public CurvySplineSegment get_LastSegment() { }

	// RVA: 0x4B5E20 Offset: 0x4B4820 VA: 0x1804B5E20
	public bool get_GlobalCoordinatesChangedThisFrame() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public Action<CurvySpline> get_OnGlobalCoordinatesChanged() { }

	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	public void set_OnGlobalCoordinatesChanged(Action<CurvySpline> value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public CurvySplineEvent get_OnRefresh() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	public void set_OnRefresh(CurvySplineEvent value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public CurvySplineEvent get_OnInitialized() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	public void set_OnInitialized(CurvySplineEvent value) { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	public CurvySplineEvent get_OnAfterControlPointChanges() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	public void set_OnAfterControlPointChanges(CurvySplineEvent value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public CurvyControlPointEvent get_OnBeforeControlPointAdd() { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	public void set_OnBeforeControlPointAdd(CurvyControlPointEvent value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public CurvyControlPointEvent get_OnAfterControlPointAdd() { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	public void set_OnAfterControlPointAdd(CurvyControlPointEvent value) { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public CurvyControlPointEvent get_OnBeforeControlPointDelete() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_OnBeforeControlPointDelete(CurvyControlPointEvent value) { }

	// RVA: 0x4AA5D0 Offset: 0x4A8FD0 VA: 0x1804AA5D0
	public static CurvySpline Create() { }

	// RVA: 0x4AA3D0 Offset: 0x4A8DD0 VA: 0x1804AA3D0
	public static CurvySpline Create(CurvySpline takeOptionsFrom) { }

	// RVA: 0x4A9550 Offset: 0x4A7F50 VA: 0x1804A9550
	public static int CalculateCacheSize(int density, float segmentLength, float maxPointsPerUnit) { }

	// RVA: 0x4A96C0 Offset: 0x4A80C0 VA: 0x1804A96C0
	public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit) { }

	// RVA: 0x4A92C0 Offset: 0x4A7CC0 VA: 0x1804A92C0
	public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f) { }

	// RVA: 0x4A9080 Offset: 0x4A7A80 VA: 0x1804A9080
	public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f) { }

	// RVA: 0x4A9810 Offset: 0x4A8210 VA: 0x1804A9810
	public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f) { }

	// RVA: 0x4B4040 Offset: 0x4B2A40 VA: 0x1804B4040
	public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1) { }

	// RVA: 0x4AC980 Offset: 0x4AB380 VA: 0x1804AC980
	public static CurvySplineSegment GetFollowUpHeadingControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headingDirection) { }

	// RVA: 0x4AF8E0 Offset: 0x4AE2E0 VA: 0x1804AF8E0
	public Vector3 Interpolate(float tf, Space space = 1) { }

	// RVA: 0x4AF800 Offset: 0x4AE200 VA: 0x1804AF800
	public Vector3 InterpolateFast(float tf, Space space = 1) { }

	// RVA: 0x4AF710 Offset: 0x4AE110 VA: 0x1804AF710
	public Vector3 InterpolateByDistance(float distance, Space space = 1) { }

	// RVA: 0x4AF620 Offset: 0x4AE020 VA: 0x1804AF620
	public Vector3 InterpolateByDistanceFast(float distance, Space space = 1) { }

	// RVA: 0x4AE290 Offset: 0x4ACC90 VA: 0x1804AE290
	public Vector3 GetTangent(float tf, Space space = 1) { }

	// RVA: 0x4AE370 Offset: 0x4ACD70 VA: 0x1804AE370
	public Vector3 GetTangent(float tf, Vector3 position, Space space = 1) { }

	// RVA: 0x4AE1B0 Offset: 0x4ACBB0 VA: 0x1804AE1B0
	public Vector3 GetTangentFast(float tf, Space space = 1) { }

	// RVA: 0x4AE0C0 Offset: 0x4ACAC0 VA: 0x1804AE0C0
	public Vector3 GetTangentByDistance(float distance, Space space = 1) { }

	// RVA: 0x4ADFD0 Offset: 0x4AC9D0 VA: 0x1804ADFD0
	public Vector3 GetTangentByDistanceFast(float distance, Space space = 1) { }

	// RVA: 0x4AF510 Offset: 0x4ADF10 VA: 0x1804AF510
	public void InterpolateAndGetTangent(float tf, out Vector3 position, out Vector3 tangent, Space space = 1) { }

	// RVA: 0x4AF400 Offset: 0x4ADE00 VA: 0x1804AF400
	public void InterpolateAndGetTangentFast(float tf, out Vector3 position, out Vector3 tangent, Space space = 1) { }

	// RVA: 0x4AD920 Offset: 0x4AC320 VA: 0x1804AD920
	public Vector3 GetOrientationUpFast(float tf, Space space = 1) { }

	// RVA: 0x4AD840 Offset: 0x4AC240 VA: 0x1804AD840
	public Quaternion GetOrientationFast(float tf, bool inverse = False, Space space = 1) { }

	// RVA: -1 Offset: -1
	public T GetMetadata<T>(float tf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6F660 Offset: 0xE6E060 VA: 0x180E6F660
	|-CurvySpline.GetMetadata<object>
	*/

	// RVA: -1 Offset: -1
	public U GetInterpolatedMetadata<T, U>(float tf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6F4E0 Offset: 0xE6DEE0 VA: 0x180E6F4E0
	|-CurvySpline.GetInterpolatedMetadata<object, float>
	|
	|-RVA: 0xE6F3B0 Offset: 0xE6DDB0 VA: 0x180E6F3B0
	|-CurvySpline.GetInterpolatedMetadata<object, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4B4530 Offset: 0x4B2F30 VA: 0x1804B4530
	public float TFToDistance(float tf, CurvyClamping clamping = 0) { }

	// RVA: 0x4B4720 Offset: 0x4B3120 VA: 0x1804B4720
	public CurvySplineSegment TFToSegment(float tf, out float localF, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping) { }

	// RVA: 0x4B4610 Offset: 0x4B3010 VA: 0x1804B4610
	public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping) { }

	// RVA: 0x4B46F0 Offset: 0x4B30F0 VA: 0x1804B46F0
	public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping) { }

	// RVA: 0x4B45E0 Offset: 0x4B2FE0 VA: 0x1804B45E0
	public CurvySplineSegment TFToSegment(float tf) { }

	// RVA: 0x4B4850 Offset: 0x4B3250 VA: 0x1804B4850
	public CurvySplineSegment TFToSegment(float tf, out float localF) { }

	// RVA: 0x4B1F50 Offset: 0x4B0950 VA: 0x1804B1F50
	public float SegmentToTF(CurvySplineSegment segment) { }

	// RVA: 0x4B1FA0 Offset: 0x4B09A0 VA: 0x1804B1FA0
	public float SegmentToTF(CurvySplineSegment segment, float localF) { }

	// RVA: 0x4AAD30 Offset: 0x4A9730 VA: 0x1804AAD30
	public float DistanceToTF(float distance, CurvyClamping clamping = 0) { }

	// RVA: 0x4AAAB0 Offset: 0x4A94B0 VA: 0x1804AAAB0
	public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = 0) { }

	// RVA: 0x4AACF0 Offset: 0x4A96F0 VA: 0x1804AACF0
	public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = 0) { }

	// RVA: 0x4AAB00 Offset: 0x4A9500 VA: 0x1804AAB00
	public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping = 0) { }

	// RVA: 0x4A9BD0 Offset: 0x4A85D0 VA: 0x1804A9BD0
	public float ClampDistance(float distance, CurvyClamping clamping) { }

	// RVA: 0x4A9B30 Offset: 0x4A8530 VA: 0x1804A9B30
	public float ClampDistance(float distance, CurvyClamping clamping, float min, float max) { }

	// RVA: 0x4A9B80 Offset: 0x4A8580 VA: 0x1804A9B80
	public float ClampDistance(float distance, ref int dir, CurvyClamping clamping) { }

	// RVA: 0x4A9AE0 Offset: 0x4A84E0 VA: 0x1804A9AE0
	public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max) { }

	// RVA: 0x4A8FE0 Offset: 0x4A79E0 VA: 0x1804A8FE0
	public CurvySplineSegment Add() { }

	// RVA: 0x4A8840 Offset: 0x4A7240 VA: 0x1804A8840
	public CurvySplineSegment[] Add(int controlPointsCount) { }

	// RVA: 0x4A8E60 Offset: 0x4A7860 VA: 0x1804A8E60
	public CurvySplineSegment Add(Vector3 controlPointPosition, Space space) { }

	// RVA: 0x4A88A0 Offset: 0x4A72A0 VA: 0x1804A88A0
	public CurvySplineSegment[] Add(Vector3[] controlPointsLocalPositions) { }

	// RVA: 0x4A8B80 Offset: 0x4A7580 VA: 0x1804A8B80
	public CurvySplineSegment[] Add(Vector3[] controlPointsPositions, Space space) { }

	// RVA: 0x4AEF60 Offset: 0x4AD960 VA: 0x1804AEF60
	public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = False) { }

	// RVA: 0x4AEE90 Offset: 0x4AD890 VA: 0x1804AEE90
	public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = False, Space space = 0) { }

	// RVA: 0x4AE760 Offset: 0x4AD160 VA: 0x1804AE760
	public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = False) { }

	// RVA: 0x4AEA20 Offset: 0x4AD420 VA: 0x1804AEA20
	public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = False, Space space = 0) { }

	// RVA: 0x4A9E70 Offset: 0x4A8870 VA: 0x1804A9E70
	public void Clear(bool isUndoable = True) { }

	// RVA: 0x4AA9F0 Offset: 0x4A93F0 VA: 0x1804AA9F0
	public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = False) { }

	// RVA: 0x4AA7E0 Offset: 0x4A91E0 VA: 0x1804AA7E0
	public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents, bool isUndoableDeletion) { }

	// RVA: 0x4ADA00 Offset: 0x4AC400 VA: 0x1804ADA00
	public SubArray<Vector3> GetPositionsCache(Space space) { }

	[UsedImplicitly]
	[Obsolete("Use GetPositionsCache instead")]
	// RVA: 0x4AC210 Offset: 0x4AAC10 VA: 0x1804AC210
	public Vector3[] GetApproximation(Space space = 1) { }

	// RVA: 0x4AC2E0 Offset: 0x4AACE0 VA: 0x1804AC2E0
	public Vector3[] GetApproximation(float fromTF, float toTF, bool includeEndPoint = True, Space space = 1) { }

	// RVA: 0x4AE470 Offset: 0x4ACE70 VA: 0x1804AE470
	public SubArray<Vector3> GetTangentsCache(Space space) { }

	[Obsolete("Use GetTangentsCache instead")]
	[UsedImplicitly]
	// RVA: 0x4ABE70 Offset: 0x4AA870 VA: 0x1804ABE70
	public Vector3[] GetApproximationT(Space space = 1) { }

	// RVA: 0x4AD510 Offset: 0x4ABF10 VA: 0x1804AD510
	public SubArray<Vector3> GetNormalsCache(Space space) { }

	[Obsolete("Use GetNormalsCache instead")]
	[UsedImplicitly]
	// RVA: 0x4AC040 Offset: 0x4AAA40 VA: 0x1804AC040
	public Vector3[] GetApproximationUpVectors(Space space = 1) { }

	// RVA: 0x4AD1A0 Offset: 0x4ABBA0 VA: 0x1804AD1A0
	public Vector3 GetNearestPoint(Vector3 position, Space space) { }

	// RVA: 0x4AD010 Offset: 0x4ABA10 VA: 0x1804AD010
	public float GetNearestPointTF(Vector3 localPosition) { }

	// RVA: 0x4AD0E0 Offset: 0x4ABAE0 VA: 0x1804AD0E0
	public float GetNearestPointTF(Vector3 position, Space space) { }

	// RVA: 0x4ACAB0 Offset: 0x4AB4B0 VA: 0x1804ACAB0
	public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint) { }

	// RVA: 0x4AD080 Offset: 0x4ABA80 VA: 0x1804AD080
	public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, Space space) { }

	// RVA: 0x4ACB10 Offset: 0x4AB510 VA: 0x1804ACB10
	public float GetNearestPointTF(Vector3 position, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = 1) { }

	// RVA: 0x4AD140 Offset: 0x4ABB40 VA: 0x1804AD140
	public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = 1) { }

	// RVA: 0x4ACB80 Offset: 0x4AB580 VA: 0x1804ACB80
	public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, out CurvySplineSegment nearestSegment, out float nearestPointLocalF, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = 1) { }

	// RVA: 0x4B1B20 Offset: 0x4B0520 VA: 0x1804B1B20
	public void Refresh() { }

	// RVA: 0x4B2100 Offset: 0x4B0B00 VA: 0x1804B2100
	public void SetDirtyAll() { }

	// RVA: 0x4B20D0 Offset: 0x4B0AD0 VA: 0x1804B20D0
	public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints) { }

	// RVA: 0x4B2280 Offset: 0x4B0C80 VA: 0x1804B2280
	public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType) { }

	// RVA: 0x4B2130 Offset: 0x4B0B30 VA: 0x1804B2130
	public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType) { }

	// RVA: 0x4B4990 Offset: 0x4B3390 VA: 0x1804B4990
	public Vector3 ToWorldPosition(Vector3 localPosition) { }

	// RVA: 0x4B4930 Offset: 0x4B3330 VA: 0x1804B4930
	public Vector3 ToWorldDirection(Vector3 localDirection) { }

	// RVA: 0x4B48D0 Offset: 0x4B32D0 VA: 0x1804B48D0
	public Vector3 ToLocalPosition(Vector3 worldPosition) { }

	// RVA: 0x4B4870 Offset: 0x4B3270 VA: 0x1804B4870
	public Vector3 ToLocalDirection(Vector3 localDirection) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void ApplyControlPointsNames() { }

	// RVA: 0x4B3FE0 Offset: 0x4B29E0 VA: 0x1804B3FE0
	public void SyncSplineFromHierarchy() { }

	[Obsolete]
	[UsedImplicitly]
	// RVA: 0x4AFBE0 Offset: 0x4AE5E0 VA: 0x1804AFBE0
	public bool IsPlanar(out int ignoreAxis) { }

	// RVA: 0x4AFC50 Offset: 0x4AE650 VA: 0x1804AFC50
	public bool IsPlanar(out bool isYZ, out bool isXZ, out bool isXY) { }

	// RVA: 0x4AFEF0 Offset: 0x4AE8F0 VA: 0x1804AFEF0
	public bool IsPlanar(CurvyPlane plane) { }

	// RVA: 0x4B0250 Offset: 0x4AEC50 VA: 0x1804B0250
	public void MakePlanar(CurvyPlane plane) { }

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	[UsedImplicitly]
	// RVA: 0x4B07C0 Offset: 0x4AF1C0 VA: 0x1804B07C0
	public void MakePlanar(int axis) { }

	// RVA: 0x4B36B0 Offset: 0x4B20B0 VA: 0x1804B36B0
	public void Subdivide(CurvySplineSegment fromCP, CurvySplineSegment toCP) { }

	// RVA: 0x4B2EA0 Offset: 0x4B18A0 VA: 0x1804B2EA0
	public void Simplify(CurvySplineSegment fromCP, CurvySplineSegment toCP) { }

	// RVA: 0x4AB450 Offset: 0x4A9E50 VA: 0x1804AB450
	public void Equalize(CurvySplineSegment fromCP, CurvySplineSegment toCP) { }

	// RVA: 0x4B0D80 Offset: 0x4AF780 VA: 0x1804B0D80
	public void Normalize() { }

	// RVA: 0x4B2A30 Offset: 0x4B1430 VA: 0x1804B2A30
	public Vector3 SetPivot(float xRel = 0, float yRel = 0, float zRel = 0, bool preview = False) { }

	// RVA: 0x4ABA50 Offset: 0x4AA450 VA: 0x1804ABA50
	public void Flip() { }

	// RVA: 0x4B0A30 Offset: 0x4AF430 VA: 0x1804B0A30
	public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP) { }

	// RVA: 0x4B0100 Offset: 0x4AEB00 VA: 0x1804B0100
	public void JoinWith(CurvySplineSegment destCP) { }

	// RVA: 0x4B3270 Offset: 0x4B1C70 VA: 0x1804B3270
	public CurvySpline Split(CurvySplineSegment controlPoint) { }

	// RVA: 0x4B23D0 Offset: 0x4B0DD0 VA: 0x1804B23D0
	public void SetFirstControlPoint(CurvySplineSegment controlPoint) { }

	// RVA: 0x4AFAD0 Offset: 0x4AE4D0 VA: 0x1804AFAD0
	public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint) { }

	// RVA: 0x4A97A0 Offset: 0x4A81A0 VA: 0x1804A97A0
	public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint) { }

	// RVA: 0x4AC8B0 Offset: 0x4AB2B0 VA: 0x1804AC8B0
	public short GetControlPointIndex(CurvySplineSegment controlPoint) { }

	// RVA: 0x4ADF80 Offset: 0x4AC980 VA: 0x1804ADF80
	public short GetSegmentIndex(CurvySplineSegment segment) { }

	[CanBeNull]
	// RVA: 0x4AD3D0 Offset: 0x4ABDD0 VA: 0x1804AD3D0
	public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4AD210 Offset: 0x4ABC10 VA: 0x1804AD210
	public short GetNextControlPointIndex(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4AD290 Offset: 0x4ABC90 VA: 0x1804AD290
	public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4ADD00 Offset: 0x4AC700 VA: 0x1804ADD00
	public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4ADB40 Offset: 0x4AC540 VA: 0x1804ADB40
	public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4ADBC0 Offset: 0x4AC5C0 VA: 0x1804ADBC0
	public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint) { }

	[CanBeNull]
	// RVA: 0x4AD460 Offset: 0x4ABE60 VA: 0x1804AD460
	public CurvySplineSegment GetNextSegment(CurvySplineSegment segment) { }

	[CanBeNull]
	// RVA: 0x4ADD90 Offset: 0x4AC790 VA: 0x1804ADD90
	public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment) { }

	// RVA: 0x4AFA20 Offset: 0x4AE420 VA: 0x1804AFA20
	public bool IsControlPointASegment(CurvySplineSegment controlPoint) { }

	// RVA: 0x4AFBA0 Offset: 0x4AE5A0 VA: 0x1804AFBA0
	public bool IsControlPointVisible(CurvySplineSegment controlPoint) { }

	[Obsolete("No more used, will be removed. If you need this method, you can use IsControlPointAnOrientationAnchor while traversing the spline's control points to find the needed information.")]
	[UsedImplicitly]
	// RVA: 0x4AC900 Offset: 0x4AB300 VA: 0x1804AC900
	public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint) { }

	// RVA: 0x4B25F0 Offset: 0x4B0FF0 VA: 0x1804B25F0
	public void SetFromString(string fieldAndValue) { }

	// RVA: 0x4B6220 Offset: 0x4B4C20 VA: 0x1804B6220
	private TransformMonitor get_TransformMonitor() { }

	// RVA: 0x4B1570 Offset: 0x4AFF70 VA: 0x1804B1570 Slot: 7
	protected override void OnValidate() { }

	[UsedImplicitly]
	// RVA: 0x4A8FF0 Offset: 0x4A79F0 VA: 0x1804A8FF0
	private void Awake() { }

	// RVA: 0x4B1430 Offset: 0x4AFE30 VA: 0x1804B1430 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4B3630 Offset: 0x4B2030 VA: 0x1804B3630
	public void Start() { }

	// RVA: 0x4B1400 Offset: 0x4AFE00 VA: 0x1804B1400 Slot: 6
	protected override void OnDisable() { }

	[UsedImplicitly]
	// RVA: 0x4B1270 Offset: 0x4AFC70 VA: 0x1804B1270
	private void OnDestroy() { }

	[UsedImplicitly]
	// RVA: 0x4B4CE0 Offset: 0x4B36E0 VA: 0x1804B4CE0
	private void Update() { }

	[UsedImplicitly]
	// RVA: 0x4B01E0 Offset: 0x4AEBE0 VA: 0x1804B01E0
	private void LateUpdate() { }

	[UsedImplicitly]
	// RVA: 0x4AB9E0 Offset: 0x4AA3E0 VA: 0x1804AB9E0
	private void FixedUpdate() { }

	// RVA: 0x4B61D0 Offset: 0x4B4BD0 VA: 0x1804B61D0
	private List<CurvySplineSegment> get_Segments() { }

	// RVA: 0x4B60E0 Offset: 0x4B4AE0 VA: 0x1804B60E0
	private int get_MaxBSplineDegree() { }

	[MustUseReturnValue]
	// RVA: 0x4AE5B0 Offset: 0x4ACFB0 VA: 0x1804AE5B0
	private bool Initialize() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void HookEditorUpdate() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void UnhookEditorUpdate() { }

	// RVA: 0x4AAE10 Offset: 0x4A9810 VA: 0x1804AAE10
	private void DoUpdate() { }

	// RVA: 0x4A9C10 Offset: 0x4A8610 VA: 0x1804A9C10
	private void ClearBounds() { }

	// RVA: 0x4A97F0 Offset: 0x4A81F0 VA: 0x1804A97F0
	private bool CanHaveManualEndCp() { }

	// RVA: 0x4A9780 Offset: 0x4A8180 VA: 0x1804A9780
	private bool CanBeClamped() { }

	// RVA: 0x4B1ED0 Offset: 0x4B08D0 VA: 0x1804B1ED0
	private void ReverseControlPoints() { }

	// RVA: 0x4AD260 Offset: 0x4ABC60 VA: 0x1804AD260
	private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount) { }

	// RVA: 0x4ADB90 Offset: 0x4AC590 VA: 0x1804ADB90
	private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount) { }

	// RVA: 0x4AFA70 Offset: 0x4AE470 VA: 0x1804AFA70
	private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB, bool isBSpline, int bSplineDegree) { }

	// RVA: 0x4AFAB0 Offset: 0x4AE4B0 VA: 0x1804AFAB0
	private static bool IsControlPointAnOrientationAnchor(bool isVisible, bool isSerializedOrientationAnchor, bool isFirstVisibleControlPoint, bool isLastVisibleControlPoint) { }

	// RVA: 0x4A8620 Offset: 0x4A7020 VA: 0x1804A8620
	private void AddControlPoint(CurvySplineSegment item, bool invalidateAndDirty, bool requestSplineToHierarchySynchronization) { }

	// RVA: 0x4AF250 Offset: 0x4ADC50 VA: 0x1804AF250
	private void InsertControlPoint(int index, CurvySplineSegment item) { }

	// RVA: 0x4B1BA0 Offset: 0x4B05A0 VA: 0x1804B1BA0
	private void RemoveControlPoint(CurvySplineSegment item) { }

	// RVA: 0x4A9CD0 Offset: 0x4A86D0 VA: 0x1804A9CD0
	private void ClearControlPoints(bool invalidateAndDirty, bool requestSplineToHierarchySynchronization) { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x4AF9F0 Offset: 0x4AE3F0 VA: 0x1804AF9F0
	internal void InvalidateControlPointsRelationshipCacheINTERNAL() { }

	[UsedImplicitly]
	// RVA: 0x4B4B10 Offset: 0x4B3510 VA: 0x1804B4B10
	private void UpdateControlPointDistances() { }

	// RVA: 0x4AB1B0 Offset: 0x4A9BB0 VA: 0x1804AB1B0
	private void EnforceTangentContinuity() { }

	// RVA: 0x4B15F0 Offset: 0x4AFFF0 VA: 0x1804B15F0
	private void PrepareThreadCompatibleData() { }

	// RVA: 0x4AD650 Offset: 0x4AC050 VA: 0x1804AD650
	private short[] GetOrientationAnchorIndices() { }

	// RVA: 0x4AF9C0 Offset: 0x4AE3C0 VA: 0x1804AF9C0
	private void InvalidateAccumulators() { }

	// RVA: 0x4B10E0 Offset: 0x4AFAE0 VA: 0x1804B10E0
	internal void NotifyMetaDataModification() { }

	// RVA: 0x4AAA10 Offset: 0x4A9410 VA: 0x1804AAA10
	private void DisposeOfControlPoint(CurvySplineSegment controlPoint, bool isUndoable) { }

	// RVA: 0x4B2DA0 Offset: 0x4B17A0 VA: 0x1804B2DA0
	private bool ShouldUseControlPointPooling(out CurvyGlobalManager curvyGlobalManager) { }

	// RVA: 0x4AEB00 Offset: 0x4AD500 VA: 0x1804AEB00
	private CurvySplineSegment InsertAt(CurvySplineSegment beforeEventCP, Vector3 position, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents, Space space) { }

	[NotNull]
	// RVA: 0x4A8430 Offset: 0x4A6E30 VA: 0x1804A8430
	private CurvySplineSegment AcquireNewControlPoint() { }

	// RVA: 0x4ADE30 Offset: 0x4AC830 VA: 0x1804ADE30
	private SubArray<Vector3> GetSegmentApproximationsInSpace(Func<CurvySplineSegment, SubArray<Vector3>> approximationGetter, Space space) { }

	// RVA: 0x4AA090 Offset: 0x4A8A90 VA: 0x1804AA090
	private SubArray<Vector3> ConcatenateSegmentApproximations(Func<CurvySplineSegment, SubArray<Vector3>> approximationGetter) { }

	// RVA: 0x4B49F0 Offset: 0x4B33F0 VA: 0x1804B49F0
	private void TransformToWorldSpace(SubArray<Vector3> localSpaceVectors) { }

	// RVA: 0x4B19F0 Offset: 0x4B03F0 VA: 0x1804B19F0
	private void PushChildCPsToPool(ComponentPool controlPointPool) { }

	// RVA: 0x4B1510 Offset: 0x4AFF10 VA: 0x1804B1510
	private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e) { }

	// RVA: 0x4B11B0 Offset: 0x4AFBB0 VA: 0x1804B11B0
	private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e) { }

	// RVA: 0x4B10F0 Offset: 0x4AFAF0 VA: 0x1804B10F0
	private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e) { }

	// RVA: 0x4B1210 Offset: 0x4AFC10 VA: 0x1804B1210
	private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e) { }

	// RVA: 0x4B1150 Offset: 0x4AFB50 VA: 0x1804B1150
	private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e) { }

	// RVA: 0x4B1DC0 Offset: 0x4B07C0 VA: 0x1804B1DC0 Slot: 5
	protected override void ResetOnEnable() { }
}
