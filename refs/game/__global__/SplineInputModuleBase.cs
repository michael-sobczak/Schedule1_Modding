public abstract class SplineInputModuleBase : CGModule // TypeDefIndex: 10603
{
	// Fields
	[Tooltip("Makes this module use the cached approximations of the spline's positions and tangents")]
	[SerializeField]
	[Tab("General")]
	private bool m_UseCache; // 0xC0
	[Tooltip("Whether to use local or global coordinates of the input's control points.
Using the global space when the input's transform is updating every frame will lead to the generator refreshing too frequently")]
	[SerializeField]
	private bool m_UseGlobalSpace; // 0xC1
	[SerializeField]
	[Tab("Range")]
	protected CurvySplineSegment m_StartCP; // 0xC8
	[SerializeField]
	[FieldCondition("m_StartCP", null, True, 0, null, 1, Action = 2)]
	protected CurvySplineSegment m_EndCP; // 0xD0

	// Properties
	public bool UseCache { get; set; }
	public CurvySplineSegment StartCP { get; set; }
	public CurvySplineSegment EndCP { get; set; }
	public bool UseGlobalSpace { get; set; }
	public override bool IsConfigured { get; }
	public override bool IsInitialized { get; }
	public bool PathIsClosed { get; }
	protected abstract CurvySpline InputSpline { get; set; }

	// Methods

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_UseCache() { }

	// RVA: 0x4EE430 Offset: 0x4ECE30 VA: 0x1804EE430
	public void set_UseCache(bool value) { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public CurvySplineSegment get_StartCP() { }

	// RVA: 0x4EE380 Offset: 0x4ECD80 VA: 0x1804EE380
	public void set_StartCP(CurvySplineSegment value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public CurvySplineSegment get_EndCP() { }

	// RVA: 0x4EE2D0 Offset: 0x4ECCD0 VA: 0x1804EE2D0
	public void set_EndCP(CurvySplineSegment value) { }

	// RVA: 0x4E8CC0 Offset: 0x4E76C0 VA: 0x1804E8CC0
	public bool get_UseGlobalSpace() { }

	// RVA: 0x4EE470 Offset: 0x4ECE70 VA: 0x1804EE470
	public void set_UseGlobalSpace(bool value) { }

	// RVA: 0x4EE060 Offset: 0x4ECA60 VA: 0x1804EE060 Slot: 9
	public override bool get_IsConfigured() { }

	// RVA: 0x4EE130 Offset: 0x4ECB30 VA: 0x1804EE130 Slot: 10
	public override bool get_IsInitialized() { }

	// RVA: 0x4EE1F0 Offset: 0x4ECBF0 VA: 0x1804EE1F0 Slot: 18
	public bool get_PathIsClosed() { }

	// RVA: 0x4ED6E0 Offset: 0x4EC0E0 VA: 0x1804ED6E0
	public void SetRange(CurvySplineSegment rangeStart, CurvySplineSegment rangeEnd) { }

	// RVA: 0x4E9ED0 Offset: 0x4E88D0 VA: 0x1804E9ED0
	public void ClearRange() { }

	// RVA: 0x4EC8E0 Offset: 0x4EB2E0 VA: 0x1804EC8E0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4EC690 Offset: 0x4EB090 VA: 0x1804EC690 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4ED010 Offset: 0x4EBA10 VA: 0x1804ED010 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4ED550 Offset: 0x4EBF50 VA: 0x1804ED550 Slot: 13
	public override void Reset() { }

	// RVA: 0x4ECEE0 Offset: 0x4EB8E0 VA: 0x1804ECEE0
	private void OnSplineRefreshed(CurvySplineEventArgs e) { }

	// RVA: 0x4ECDA0 Offset: 0x4EB7A0 VA: 0x1804ECDA0
	private void OnSplineInitialized(CurvySplineEventArgs e) { }

	// RVA: 0x4EC930 Offset: 0x4EB330 VA: 0x1804EC930
	private void OnInputSplineCoordinatesChanged(CurvySpline sender) { }

	// RVA: 0x4EA4D0 Offset: 0x4E8ED0 VA: 0x1804EA4D0
	private void ForceRefresh() { }

	// RVA: 0x4EDFC0 Offset: 0x4EC9C0 VA: 0x1804EDFC0
	private bool getPathClosed(CurvySpline spline) { }

	[CanBeNull]
	// RVA: 0x4EA500 Offset: 0x4E8F00 VA: 0x1804EA500
	protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options) { }

	// RVA: 0x4ED090 Offset: 0x4EBA90 VA: 0x1804ED090
	private static void ProcessControlPointOptions(ControlPointOption options, int positionsCount, List<SamplePointsMaterialGroup> shapeMaterialGroups, List<SamplePointUData> extendedUVData, List<DuplicateSamplePoint> duplicatePoints, ref SamplePointsMaterialGroup currentMaterialGroup, ref SamplePointsPatch currentPatch, out float currentDistance, out bool duplicatePoint) { }

	// RVA: 0x4E9FB0 Offset: 0x4E89B0 VA: 0x1804E9FB0
	private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, SubArrayList<float> sourceFs, SubArrayList<float> relativeFs, bool isFullPath, SubArrayList<Vector3> positions, SubArrayList<Vector3> tangents, SubArrayList<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform) { }

	// RVA: 0x4E8EB0 Offset: 0x4E78B0 VA: 0x1804E8EB0
	private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, ref SubArrayList<float> sourceFList, ref SubArrayList<float> relativeFList, ref SubArrayList<Vector3> positionList, ref SubArrayList<Vector3> tangentList, ref SubArrayList<Vector3> upList) { }

	// RVA: 0x4EC310 Offset: 0x4EAD10 VA: 0x1804EC310
	private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist) { }

	// RVA: 0x4E9010 Offset: 0x4E7A10 VA: 0x1804E9010
	private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data) { }

	// RVA: 0x4EDE70 Offset: 0x4EC870 VA: 0x1804EDE70
	private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp) { }

	// RVA: 0x4EDD00 Offset: 0x4EC700 VA: 0x1804EDD00
	private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp) { }

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract CurvySpline get_InputSpline();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void set_InputSpline(CurvySpline value);

	// RVA: 0x4ECAB0 Offset: 0x4EB4B0 VA: 0x1804ECAB0 Slot: 21
	protected virtual void OnSplineAssigned() { }

	// RVA: 0x4ED7E0 Offset: 0x4EC1E0 VA: 0x1804ED7E0
	protected void ValidateStartAndEndCps() { }

	// RVA: 0x4EDCF0 Offset: 0x4EC6F0 VA: 0x1804EDCF0
	protected void .ctor() { }
}
