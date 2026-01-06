public class SplineController : CurvyController // TypeDefIndex: 10594
{
	// Fields
	[FieldCondition("m_Spline", null, False, 6, "Missing source Spline", 1)]
	[SerializeField]
	[Section("General", True, False, 100, Sort = 0)]
	protected CurvySpline m_Spline; // 0xB0
	[Tooltip("Whether spline's cache data should be used. Set this to true to gain performance if precision is not required.")]
	[SerializeField]
	private bool m_UseCache; // 0xB8
	[Label("At connection, use", "What spline should the controller use when reaching a Connection")]
	[SerializeField]
	[Section("Connections Handling", True, False, 100, Sort = 250, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_connectionshandling")]
	private SplineControllerConnectionBehavior connectionBehavior; // 0xBC
	[Label("Allow direction change", "When true, the controller will modify its direction to best fit the connected spline")]
	[SerializeField]
	private bool allowDirectionChange; // 0xC0
	[FieldCondition("ShowRandomConnectionOptions", True, False, 0, null, 1)]
	[Label("Reject current spline", "Whether the current spline should be excluded from the randomly selected splines")]
	[SerializeField]
	private bool rejectCurrentSpline; // 0xC1
	[FieldCondition("ShowRandomConnectionOptions", True, False, 0, null, 1)]
	[Label("Reject divergent splines", "Whether splines that diverge from the current spline with more than a specific angle should be excluded from the randomly selected splines")]
	[SerializeField]
	private bool rejectTooDivergentSplines; // 0xC2
	[Range(0, 180)]
	[SerializeField]
	[Label("Max allowed angle", "Maximum allowed divergence angle in degrees")]
	private float maxAllowedDivergenceAngle; // 0xC4
	[SerializeField]
	[Label("Custom Selector", "A custom logic to select which connected spline to follow. Select a Script inheriting from SplineControllerConnectionBehavior")]
	[FieldCondition("connectionBehavior", 4, False, 0, null, 1)]
	[FieldCondition("connectionCustomSelector", null, False, 5, "Missing custom selector", 1)]
	private ConnectedControlPointsSelector connectionCustomSelector; // 0xC8
	[Section("Events", False, False, 1000, HelpURL = "https://curvyeditor.com/doclink/splinecontroller_events")]
	[SerializeField]
	[ArrayEx]
	protected List<OnPositionReachedSettings> onPositionReachedList; // 0xD0
	[SerializeField]
	protected CurvySplineMoveEvent m_OnControlPointReached; // 0xD8
	[SerializeField]
	protected CurvySplineMoveEvent m_OnEndReached; // 0xE0
	[SerializeField]
	protected CurvySplineMoveEvent m_OnSwitch; // 0xE8
	protected readonly SplineController.SplineSwitcher Switcher; // 0xF0
	private CurvySpline prePlaySpline; // 0xF8
	private readonly CurvySplineMoveEventArgs preAllocatedEventArgs; // 0x100
	private const string InvalidSegmentErrorMessage = "[Curvy] Controller {0} reached segment {1} which is invalid segment because it has a length of 0. Please fix the invalid segment to avoid issues with the controller";

	// Properties
	public virtual CurvySpline Spline { get; set; }
	public bool UseCache { get; set; }
	public SplineControllerConnectionBehavior ConnectionBehavior { get; set; }
	public ConnectedControlPointsSelector ConnectionCustomSelector { get; set; }
	public bool AllowDirectionChange { get; set; }
	public bool RejectCurrentSpline { get; set; }
	public bool RejectTooDivergentSplines { get; set; }
	public float MaxAllowedDivergenceAngle { get; set; }
	public List<OnPositionReachedSettings> OnPositionReachedList { get; set; }
	public CurvySplineMoveEvent OnControlPointReached { get; set; }
	public CurvySplineMoveEvent OnEndReached { get; set; }
	public override float Length { get; }
	public bool IsSwitching { get; }
	public float SwitchProgress { get; }
	public CurvySplineMoveEvent OnSwitch { get; set; }
	public override bool IsReady { get; }
	private bool ShowRandomConnectionOptions { get; }
	[Obsolete("Use Switcher instead")]
	[UsedImplicitly]
	protected float SwitchStartTime { get; }
	[Obsolete("Use Switcher instead")]
	[UsedImplicitly]
	protected float SwitchDuration { get; }
	[Obsolete("Use Switcher instead")]
	[UsedImplicitly]
	protected CurvySpline SwitchTarget { get; }
	[UsedImplicitly]
	[Obsolete("Use Switcher instead")]
	protected float TfOnSwitchTarget { get; }
	[Obsolete("Use Switcher instead")]
	[UsedImplicitly]
	protected MovementDirection DirectionOnSwitchTarget { get; }

	// Methods

	// RVA: 0x4E88F0 Offset: 0x4E72F0 VA: 0x1804E88F0
	public void .ctor() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150 Slot: 45
	public virtual CurvySpline get_Spline() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 46
	public virtual void set_Spline(CurvySpline value) { }

	// RVA: 0x4E8DE0 Offset: 0x4E77E0 VA: 0x1804E8DE0
	public bool get_UseCache() { }

	// RVA: 0x4E8EA0 Offset: 0x4E78A0 VA: 0x1804E8EA0
	public void set_UseCache(bool value) { }

	// RVA: 0x4E8B70 Offset: 0x4E7570 VA: 0x1804E8B70
	public SplineControllerConnectionBehavior get_ConnectionBehavior() { }

	// RVA: 0x4E8E00 Offset: 0x4E7800 VA: 0x1804E8E00
	public void set_ConnectionBehavior(SplineControllerConnectionBehavior value) { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public ConnectedControlPointsSelector get_ConnectionCustomSelector() { }

	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	public void set_ConnectionCustomSelector(ConnectedControlPointsSelector value) { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	public bool get_AllowDirectionChange() { }

	// RVA: 0x4E8DF0 Offset: 0x4E77F0 VA: 0x1804E8DF0
	public void set_AllowDirectionChange(bool value) { }

	// RVA: 0x4E8CC0 Offset: 0x4E76C0 VA: 0x1804E8CC0
	public bool get_RejectCurrentSpline() { }

	// RVA: 0x4E8E80 Offset: 0x4E7880 VA: 0x1804E8E80
	public void set_RejectCurrentSpline(bool value) { }

	// RVA: 0x4E8CD0 Offset: 0x4E76D0 VA: 0x1804E8CD0
	public bool get_RejectTooDivergentSplines() { }

	// RVA: 0x4E8E90 Offset: 0x4E7890 VA: 0x1804E8E90
	public void set_RejectTooDivergentSplines(bool value) { }

	// RVA: 0x4E8C80 Offset: 0x4E7680 VA: 0x1804E8C80
	public float get_MaxAllowedDivergenceAngle() { }

	// RVA: 0x4E8E10 Offset: 0x4E7810 VA: 0x1804E8E10
	public void set_MaxAllowedDivergenceAngle(float value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public List<OnPositionReachedSettings> get_OnPositionReachedList() { }

	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	public void set_OnPositionReachedList(List<OnPositionReachedSettings> value) { }

	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public CurvySplineMoveEvent get_OnControlPointReached() { }

	// RVA: 0x4E8E20 Offset: 0x4E7820 VA: 0x1804E8E20
	public void set_OnControlPointReached(CurvySplineMoveEvent value) { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public CurvySplineMoveEvent get_OnEndReached() { }

	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	public void set_OnEndReached(CurvySplineMoveEvent value) { }

	// RVA: 0x4E8C20 Offset: 0x4E7620 VA: 0x1804E8C20 Slot: 35
	public override float get_Length() { }

	// RVA: 0x4E8C00 Offset: 0x4E7600 VA: 0x1804E8C00
	public bool get_IsSwitching() { }

	// RVA: 0x4E8D20 Offset: 0x4E7720 VA: 0x1804E8D20
	public float get_SwitchProgress() { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public CurvySplineMoveEvent get_OnSwitch() { }

	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	public void set_OnSwitch(CurvySplineMoveEvent value) { }

	// RVA: 0x4E8100 Offset: 0x4E6B00 VA: 0x1804E8100 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4E86D0 Offset: 0x4E70D0 VA: 0x1804E86D0 Slot: 47
	public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration) { }

	// RVA: 0x4E6050 Offset: 0x4E4A50 VA: 0x1804E6050
	public void FinishCurrentSwitch() { }

	// RVA: 0x4E4F30 Offset: 0x4E3930 VA: 0x1804E4F30
	public void CancelCurrentSwitch() { }

	// RVA: 0x4E60E0 Offset: 0x4E4AE0 VA: 0x1804E60E0
	public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange) { }

	// RVA: 0x4E8BA0 Offset: 0x4E75A0 VA: 0x1804E8BA0 Slot: 11
	public override bool get_IsReady() { }

	// RVA: 0x4E8480 Offset: 0x4E6E80 VA: 0x1804E8480 Slot: 26
	protected override void SavePrePlayState() { }

	// RVA: 0x4E8440 Offset: 0x4E6E40 VA: 0x1804E8440 Slot: 27
	protected override void RestorePrePlayState() { }

	// RVA: 0x4E8400 Offset: 0x4E6E00 VA: 0x1804E8400 Slot: 28
	protected override void ResetPrePlayState() { }

	// RVA: 0x4E82E0 Offset: 0x4E6CE0 VA: 0x1804E82E0 Slot: 39
	protected override float RelativeToAbsolute(float relativeDistance) { }

	// RVA: 0x4E4C40 Offset: 0x4E3640 VA: 0x1804E4C40 Slot: 38
	protected override float AbsoluteToRelative(float worldUnitDistance) { }

	// RVA: 0x4E6370 Offset: 0x4E4D70 VA: 0x1804E6370 Slot: 40
	protected override Vector3 GetInterpolatedSourcePosition(float tf) { }

	// RVA: 0x4E6480 Offset: 0x4E4E80 VA: 0x1804E6480 Slot: 41
	protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up) { }

	// RVA: 0x4E6AC0 Offset: 0x4E54C0 VA: 0x1804E6AC0 Slot: 43
	protected override Vector3 GetTangent(float tf) { }

	// RVA: 0x4E66F0 Offset: 0x4E50F0 VA: 0x1804E66F0 Slot: 42
	protected override Vector3 GetOrientation(float tf) { }

	// RVA: 0x4E4EA0 Offset: 0x4E38A0 VA: 0x1804E4EA0 Slot: 36
	protected override void Advance(float speed, float deltaTime) { }

	// RVA: 0x4E8650 Offset: 0x4E7050 VA: 0x1804E8650 Slot: 37
	protected override void SimulateAdvance(ref float tf, ref MovementDirection direction, float speed, float deltaTime) { }

	// RVA: 0x4E84D0 Offset: 0x4E6ED0 VA: 0x1804E84D0
	private static void SimulateAdvanceOnSpline(CurvySpline spline, ref float tf, ref MovementDirection direction, float distance, CurvyController.MoveModeEnum moveModeEnum, CurvyClamping curvyClamping) { }

	// RVA: 0x4E78B0 Offset: 0x4E62B0 VA: 0x1804E78B0 Slot: 20
	protected override void InitializedApplyDeltaTime(float deltaTime) { }

	// RVA: 0x4E50E0 Offset: 0x4E3AE0 VA: 0x1804E50E0 Slot: 21
	protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward) { }

	// RVA: 0x4E8330 Offset: 0x4E6D30 VA: 0x1804E8330 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x4E4C90 Offset: 0x4E3690 VA: 0x1804E4C90
	private void AdvanceSwitching(float distance) { }

	// RVA: 0x4E6820 Offset: 0x4E5220 VA: 0x1804E6820
	private void GetSwitchingPositionAndRotation(Vector3 forwardOnCurrentSpline, Vector3 upOnCurrentSpline, Vector3 positionOnCurrentSpline, out Vector3 interpolatedPosition, out Quaternion interpolatedRotation) { }

	// RVA: 0x4E4F90 Offset: 0x4E3990 VA: 0x1804E4F90
	private void ComputePositionAndRotationOnSwitchTarget(out Vector3 positionOnSwitchToSpline, out Quaternion rotationOnSwitchToSpline) { }

	// RVA: 0x4E7DD0 Offset: 0x4E67D0 VA: 0x1804E7DD0
	private static float MovementCompatibleGetPosition(SplineController controller, float clampedPosition, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint) { }

	// RVA: 0x4E8010 Offset: 0x4E6A10 VA: 0x1804E8010
	private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float specialClampedPosition) { }

	// RVA: 0x4E52F0 Offset: 0x4E3CF0 VA: 0x1804E52F0
	private void EventAwareMove(float distance) { }

	// RVA: 0x4E6FF0 Offset: 0x4E59F0 VA: 0x1804E6FF0
	private void HandleOnPositionReachedEvents(CurvyPositionMode positionMode, float startPosition, float endPosition, float endPositionUnclamped, out float postEventsEndPosition, float currentDelta, CurvySplineSegment currentCp, ref bool cancelMovement) { }

	// RVA: 0x4E6CC0 Offset: 0x4E56C0 VA: 0x1804E6CC0
	private Nullable<float> HandleOnPositionReachedEvent(CurvyPositionMode positionMode, float startPosition, float endPositionUnclamped, float currentDelta, CurvySplineSegment currentCp, ref bool cancelMovement, OnPositionReachedSettings settings, Nullable<float> postEventEndPosition) { }

	// RVA: 0x4E7570 Offset: 0x4E5F70 VA: 0x1804E7570
	private void HandleReachingNewControlPoint(CurvySplineSegment controlPoint, float controlPointPosition, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement, out CurvySplineSegment postEventsControlPoint, out bool postEventsIsControllerOnControlPoint, out float postEventsControlPointPosition) { }

	// RVA: 0x4E7A00 Offset: 0x4E6400 VA: 0x1804E7A00
	private void InvokeEventHandler(CurvySplineMoveEvent event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, ref CurvySplineSegment postEventsControlPoint, ref bool postEventsIsControllerOnControlPoint, ref float postEventPosition) { }

	// RVA: 0x4E7C50 Offset: 0x4E6650 VA: 0x1804E7C50
	private void InvokeEventHandler(CurvySplineMoveEvent event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, out CurvySplineSegment postEventsControlPoint, out Nullable<bool> postEventsIsControllerOnControlPoint, out Nullable<float> postEventPosition) { }

	// RVA: 0x4E7350 Offset: 0x4E5D50 VA: 0x1804E7350
	private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints) { }

	// RVA: 0x4E67D0 Offset: 0x4E51D0 VA: 0x1804E67D0
	private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed) { }

	// RVA: 0x4E6BD0 Offset: 0x4E55D0 VA: 0x1804E6BD0
	private CurvySplineSegment HandleFollowUpConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection) { }

	// RVA: 0x4E7840 Offset: 0x4E6240 VA: 0x1804E7840
	private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection) { }

	// RVA: 0x4E62F0 Offset: 0x4E4CF0 VA: 0x1804E62F0
	private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode) { }

	// RVA: 0x4E8CE0 Offset: 0x4E76E0 VA: 0x1804E8CE0
	private bool get_ShowRandomConnectionOptions() { }

	// RVA: 0x4E8D80 Offset: 0x4E7780 VA: 0x1804E8D80
	protected float get_SwitchStartTime() { }

	// RVA: 0x4E8D00 Offset: 0x4E7700 VA: 0x1804E8D00
	protected float get_SwitchDuration() { }

	// RVA: 0x4E8DA0 Offset: 0x4E77A0 VA: 0x1804E8DA0
	protected CurvySpline get_SwitchTarget() { }

	// RVA: 0x4E8DC0 Offset: 0x4E77C0 VA: 0x1804E8DC0
	protected float get_TfOnSwitchTarget() { }

	// RVA: 0x4E8B80 Offset: 0x4E7580 VA: 0x1804E8B80
	protected MovementDirection get_DirectionOnSwitchTarget() { }
}
