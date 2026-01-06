public class CurvyConnection : DTVersionedMonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 10523
{
	// Fields
	[SerializeField]
	[Hide]
	private List<CurvySplineSegment> m_ControlPoints; // 0x30
	private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints; // 0x38
	[NotNull]
	private readonly CurvyConnection.TransformSynchronizer transformSynchronizer; // 0x40
	[NotNull]
	private readonly CurvyConnection.UndoFixer undoFixer; // 0x48

	// Properties
	public ReadOnlyCollection<CurvySplineSegment> ControlPointsList { get; }
	public int Count { get; }
	public CurvySplineSegment Item { get; }

	// Methods

	// RVA: 0x4A3420 Offset: 0x4A1E20 VA: 0x1804A3420
	public void .ctor() { }

	// RVA: 0x4A3590 Offset: 0x4A1F90 VA: 0x1804A3590
	public ReadOnlyCollection<CurvySplineSegment> get_ControlPointsList() { }

	// RVA: 0x4A3600 Offset: 0x4A2000 VA: 0x1804A3600
	public int get_Count() { }

	// RVA: 0x4A3640 Offset: 0x4A2040 VA: 0x1804A3640
	public CurvySplineSegment get_Item(int idx) { }

	// RVA: 0x4A2B40 Offset: 0x4A1540 VA: 0x1804A2B40 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4A2AA0 Offset: 0x4A14A0 VA: 0x1804A2AA0 Slot: 6
	protected override void OnDisable() { }

	[UsedImplicitly]
	// RVA: 0x4A33B0 Offset: 0x4A1DB0 VA: 0x1804A33B0
	private void Update() { }

	[UsedImplicitly]
	// RVA: 0x4A2870 Offset: 0x4A1270 VA: 0x1804A2870
	private void LateUpdate() { }

	[UsedImplicitly]
	// RVA: 0x4A2800 Offset: 0x4A1200 VA: 0x1804A2800
	private void FixedUpdate() { }

	[UsedImplicitly]
	// RVA: 0x4A28F0 Offset: 0x4A12F0 VA: 0x1804A28F0
	private void OnDestroy() { }

	// RVA: 0x4A2400 Offset: 0x4A0E00 VA: 0x1804A2400
	public static CurvyConnection Create(CurvySplineSegment[] controlPoints) { }

	// RVA: 0x4A1F90 Offset: 0x4A0990 VA: 0x1804A1F90
	public void AddControlPoints(CurvySplineSegment[] controlPoints) { }

	// RVA: 0x4A2130 Offset: 0x4A0B30 VA: 0x1804A2130
	public void AutoSetFollowUp() { }

	// RVA: 0x4A2F30 Offset: 0x4A1930 VA: 0x1804A2F30
	public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = True) { }

	// RVA: 0x4A27B0 Offset: 0x4A11B0 VA: 0x1804A27B0
	public void Delete() { }

	[Obsolete("Inline the method's body if needed")]
	// RVA: 0x4A2DF0 Offset: 0x4A17F0 VA: 0x1804A2DF0
	public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source) { }

	// RVA: 0x4A32B0 Offset: 0x4A1CB0 VA: 0x1804A32B0
	public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation) { }

	// RVA: 0x4A28E0 Offset: 0x4A12E0 VA: 0x1804A28E0 Slot: 9
	public void OnBeforeSerialize() { }

	// RVA: 0x4A28E0 Offset: 0x4A12E0 VA: 0x1804A28E0 Slot: 10
	public void OnAfterDeserialize() { }

	// RVA: 0x4A3160 Offset: 0x4A1B60 VA: 0x1804A3160
	private void RemoveNullCPs() { }

	// RVA: 0x4A27E0 Offset: 0x4A11E0 VA: 0x1804A27E0
	private void DoUpdate() { }

	// RVA: 0x4A2C10 Offset: 0x4A1610 VA: 0x1804A2C10
	private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1) { }

	// RVA: 0x4A3280 Offset: 0x4A1C80 VA: 0x1804A3280 Slot: 5
	protected override void ResetOnEnable() { }
}
