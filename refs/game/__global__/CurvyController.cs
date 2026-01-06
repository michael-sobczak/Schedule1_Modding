public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 10585
{
	// Fields
	[Section("General", True, False, 100, Sort = 0, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_general")]
	[Label(Tooltip = "Determines when to update")]
	public CurvyUpdateMethod UpdateIn; // 0x30
	[SerializeField]
	[FieldCondition("IsNeededRigidbodyMissing", True, False, 6, "Missing Rigidbody component. Its 'Is Kinematic' setting should be set to true", 1)]
	[FieldCondition("IsNeeded2DRigidbodyMissing", True, False, 6, "Missing Rigidbody 2D component. Its 'Body Type' setting should be set to 'Kinematic'", 1)]
	[FieldCondition("IsNeededRigidbodyNotKinematic", True, False, 6, "Rigidbody's 'Is Kinematic' setting should be set to true", 1)]
	[FieldCondition("IsNeeded2DRigidbodyNotKinematic", True, False, 6, "Rigidbody 2Ds 'Body Type' setting should be set to 'Kinematic'", 1)]
	[FieldCondition("targetComponent", 0, True, 4, "The rigidbody's position and rotation are updated at the physics simulation, and not at the selected 'Update In' method. Please consider this if getting the position or rotation via script.", 1)]
	[Tooltip("The component controlled by the controller")]
	[FieldCondition("targetComponent", 0, False, 4, "The transform's position and rotation are updated at the selected 'Update In' method.", 1)]
	private TargetComponent targetComponent; // 0x34
	[Section("Position", True, False, 100, Sort = 100, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_position")]
	[SerializeField]
	private CurvyPositionMode m_PositionMode; // 0x38
	[RangeEx(0, "maxPosition", "", "")]
	[FieldCondition("ShouldDisablePositionSlider", True, False, 3, null, 1)]
	[FormerlySerializedAs("m_InitialPosition")]
	[SerializeField]
	protected float m_Position; // 0x3C
	[Section("Motion", True, False, 100, Sort = 200, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_move")]
	[SerializeField]
	private CurvyController.MoveModeEnum m_MoveMode; // 0x40
	[Positive]
	[SerializeField]
	private float m_Speed; // 0x44
	[SerializeField]
	private MovementDirection m_Direction; // 0x48
	[SerializeField]
	private CurvyClamping m_Clamping; // 0x4C
	[Tooltip("Defines what motions are to be frozen")]
	[FieldCondition("AreConstraintsConflicting", True, False, 5, "The controller targets a Rididbody that has constraints on it. This can creates conflicts with the controller's constraints", 1)]
	[SerializeField]
	[Label("Constraints", "")]
	private MotionConstraints motionConstraints; // 0x50
	[Tooltip("Start playing automatically when entering play mode")]
	[SerializeField]
	private bool m_PlayAutomatically; // 0x54
	[Label("Source", "Source Vector")]
	[Section("Orientation", True, False, 100, Sort = 300, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_orientation")]
	[SerializeField]
	[FieldCondition("ShowOrientationSection", False, False, 0, null, 1, Action = 1)]
	private OrientationModeEnum m_OrientationMode; // 0x58
	[Label("Lock Rotation", "When set, the controller will enforce the rotation to not change")]
	[SerializeField]
	private bool m_LockRotation; // 0x5C
	[SerializeField]
	[FieldCondition("m_OrientationMode", 0, False, 1, "ShowOrientationSection", False, False, Action = 1)]
	[Label("Target", "Target Vector3")]
	private OrientationAxisEnum m_OrientationAxis; // 0x60
	[FieldCondition("m_OrientationMode", 0, False, 1, "ShowOrientationSection", False, False, Action = 1)]
	[SerializeField]
	[Tooltip("Should the orientation ignore the movement direction?")]
	private bool m_IgnoreDirection; // 0x64
	[Min(0, "Direction Damping Time", "If non zero, the direction vector (forward) of the controlled object will not be updated instantly, but using a damping effect that will last the specified amount of time.")]
	[FieldCondition("ShowOrientationSection", False, False, 0, null, 1, Action = 1)]
	[SerializeField]
	private float m_DampingDirection; // 0x68
	[Min(0, "Up Damping Time", "If non zero, the up vector of the controlled object will not be updated instantly, but using a damping effect that will last the specified amount of time.")]
	[FieldCondition("ShowOrientationSection", False, False, 0, null, 1, Action = 1)]
	[SerializeField]
	private float m_DampingUp; // 0x6C
	[SerializeField]
	[Section("Offset", True, False, 100, Sort = 400, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_orientation")]
	[FieldCondition("ShowOffsetSection", False, False, 0, null, 1, Action = 1)]
	[RangeEx(-180, 180, "", "")]
	private float m_OffsetAngle; // 0x70
	[SerializeField]
	[FieldCondition("ShowOffsetSection", False, False, 0, null, 1, Action = 1)]
	private float m_OffsetRadius; // 0x74
	[Label("Compensate Offset", "Adjusts speed to match the change of travel distance due to offset")]
	[SerializeField]
	[FieldCondition("ShowOffsetSection", False, False, 0, null, 1, Action = 1)]
	private bool m_OffsetCompensation; // 0x78
	[Section("Events", True, False, 100, Sort = 500)]
	[SerializeField]
	protected ControllerEvent onInitialized; // 0x80
	protected const string ControllerNotReadyMessage = "The controller is not yet ready";
	[CompilerGenerated]
	private readonly CurvyController.OrientationDamper <Damper>k__BackingField; // 0x88
	protected CurvyController.CurvyControllerState State; // 0x90
	protected float PrePlayPosition; // 0x94
	protected MovementDirection PrePlayDirection; // 0x98
	protected Quaternion LockedRotation; // 0x9C
	[CompilerGenerated]
	private bool <isInitialized>k__BackingField; // 0xAC

	// Properties
	public ControllerEvent OnInitialized { get; }
	public TargetComponent TargetComponent { get; set; }
	public CurvyPositionMode PositionMode { get; set; }
	public CurvyController.MoveModeEnum MoveMode { get; set; }
	public bool PlayAutomatically { get; set; }
	public CurvyClamping Clamping { get; set; }
	public MotionConstraints MotionConstraints { get; set; }
	public OrientationModeEnum OrientationMode { get; set; }
	public bool LockRotation { get; set; }
	public OrientationAxisEnum OrientationAxis { get; set; }
	public float DirectionDampingTime { get; set; }
	public float UpDampingTime { get; set; }
	public bool IgnoreDirection { get; set; }
	public float OffsetAngle { get; set; }
	public float OffsetRadius { get; set; }
	public bool OffsetCompensation { get; set; }
	public float Speed { get; set; }
	public float RelativePosition { get; set; }
	public float AbsolutePosition { get; set; }
	public float Position { get; set; }
	public MovementDirection MovementDirection { get; set; }
	public CurvyController.CurvyControllerState PlayState { get; }
	public abstract bool IsReady { get; }
	protected virtual bool ShouldDisablePositionSlider { get; }
	[NotNull]
	protected CurvyController.OrientationDamper Damper { get; }
	public virtual Transform Transform { get; }
	public virtual Rigidbody Rigidbody { get; }
	public virtual Rigidbody2D Rigidbody2D { get; }
	protected virtual bool ShowOrientationSection { get; }
	protected virtual bool ShowOffsetSection { get; }
	public abstract float Length { get; }
	protected bool isInitialized { get; set; }
	protected float TimeSinceLastUpdate { get; }
	protected bool UseOffset { get; }
	private float maxPosition { get; }
	private bool IsNeededRigidbodyMissing { get; }
	private bool IsNeeded2DRigidbodyMissing { get; }
	private bool IsNeededRigidbodyNotKinematic { get; }
	private bool IsNeeded2DRigidbodyNotKinematic { get; }
	private bool AreConstraintsConflicting { get; }
	[UsedImplicitly]
	[Obsolete]
	protected Vector3 DirectionDampingVelocity { get; set; }
	[Obsolete]
	[UsedImplicitly]
	protected Vector3 UpDampingVelocity { get; set; }

	// Methods

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public ControllerEvent get_OnInitialized() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public TargetComponent get_TargetComponent() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_TargetComponent(TargetComponent value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public CurvyPositionMode get_PositionMode() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_PositionMode(CurvyPositionMode value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public CurvyController.MoveModeEnum get_MoveMode() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void set_MoveMode(CurvyController.MoveModeEnum value) { }

	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool get_PlayAutomatically() { }

	// RVA: 0x4E2920 Offset: 0x4E1320 VA: 0x1804E2920
	public void set_PlayAutomatically(bool value) { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public CurvyClamping get_Clamping() { }

	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void set_Clamping(CurvyClamping value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public MotionConstraints get_MotionConstraints() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_MotionConstraints(MotionConstraints value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public OrientationModeEnum get_OrientationMode() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_OrientationMode(OrientationModeEnum value) { }

	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	public bool get_LockRotation() { }

	// RVA: 0x4E2840 Offset: 0x4E1240 VA: 0x1804E2840
	public void set_LockRotation(bool value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public OrientationAxisEnum get_OrientationAxis() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_OrientationAxis(OrientationAxisEnum value) { }

	// RVA: 0x4CD9E0 Offset: 0x4CC3E0 VA: 0x1804CD9E0
	public float get_DirectionDampingTime() { }

	// RVA: 0x4E27F0 Offset: 0x4E11F0 VA: 0x1804E27F0
	public void set_DirectionDampingTime(float value) { }

	// RVA: 0x4CD190 Offset: 0x4CBB90 VA: 0x1804CD190
	public float get_UpDampingTime() { }

	// RVA: 0x4E2B50 Offset: 0x4E1550 VA: 0x1804E2B50
	public void set_UpDampingTime(float value) { }

	// RVA: 0x4E21A0 Offset: 0x4E0BA0 VA: 0x1804E21A0
	public bool get_IgnoreDirection() { }

	// RVA: 0x4E2830 Offset: 0x4E1230 VA: 0x1804E2830
	public void set_IgnoreDirection(bool value) { }

	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_OffsetAngle() { }

	// RVA: 0x4E28D0 Offset: 0x4E12D0 VA: 0x1804E28D0
	public void set_OffsetAngle(float value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_OffsetRadius() { }

	// RVA: 0x4E28F0 Offset: 0x4E12F0 VA: 0x1804E28F0
	public void set_OffsetRadius(float value) { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_OffsetCompensation() { }

	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	public void set_OffsetCompensation(bool value) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_Speed() { }

	// RVA: 0x4E2B20 Offset: 0x4E1520 VA: 0x1804E2B20
	public void set_Speed(float value) { }

	// RVA: 0x4E24B0 Offset: 0x4E0EB0 VA: 0x1804E24B0
	public float get_RelativePosition() { }

	// RVA: 0x4E2A60 Offset: 0x4E1460 VA: 0x1804E2A60
	public void set_RelativePosition(float value) { }

	// RVA: 0x4E1F70 Offset: 0x4E0970 VA: 0x1804E1F70
	public float get_AbsolutePosition() { }

	// RVA: 0x4E2720 Offset: 0x4E1120 VA: 0x1804E2720
	public void set_AbsolutePosition(float value) { }

	// RVA: 0x4E2440 Offset: 0x4E0E40 VA: 0x1804E2440
	public float get_Position() { }

	// RVA: 0x4E2940 Offset: 0x4E1340 VA: 0x1804E2940
	public void set_Position(float value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public MovementDirection get_MovementDirection() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_MovementDirection(MovementDirection value) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public CurvyController.CurvyControllerState get_PlayState() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsReady();

	// RVA: 0x4E2650 Offset: 0x4E1050 VA: 0x1804E2650 Slot: 12
	protected virtual bool get_ShouldDisablePositionSlider() { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	protected CurvyController.OrientationDamper get_Damper() { }

	// RVA: 0x4E10A0 Offset: 0x4DFAA0 VA: 0x1804E10A0 Slot: 4
	protected override void OnEnable() { }

	[UsedImplicitly]
	// RVA: 0x4E1AF0 Offset: 0x4E04F0 VA: 0x1804E1AF0 Slot: 13
	protected virtual void Start() { }

	// RVA: 0x4E1060 Offset: 0x4DFA60 VA: 0x1804E1060 Slot: 6
	protected override void OnDisable() { }

	[UsedImplicitly]
	// RVA: 0x4E1E40 Offset: 0x4E0840 VA: 0x1804E1E40 Slot: 14
	protected virtual void Update() { }

	[UsedImplicitly]
	// RVA: 0x4E0FB0 Offset: 0x4DF9B0 VA: 0x1804E0FB0 Slot: 15
	protected virtual void LateUpdate() { }

	[UsedImplicitly]
	// RVA: 0x4E0360 Offset: 0x4DED60 VA: 0x1804E0360 Slot: 16
	protected virtual void FixedUpdate() { }

	// RVA: 0x4E1110 Offset: 0x4DFB10 VA: 0x1804E1110 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 17
	public virtual Transform get_Transform() { }

	[CanBeNull]
	// RVA: 0x4E2600 Offset: 0x4E1000 VA: 0x1804E2600 Slot: 18
	public virtual Rigidbody get_Rigidbody() { }

	[CanBeNull]
	// RVA: 0x4E25B0 Offset: 0x4E0FB0 VA: 0x1804E25B0 Slot: 19
	public virtual Rigidbody2D get_Rigidbody2D() { }

	// RVA: 0x4E0B40 Offset: 0x4DF540 VA: 0x1804E0B40 Slot: 20
	protected virtual void InitializedApplyDeltaTime(float deltaTime) { }

	// RVA: 0x4DFC30 Offset: 0x4DE630 VA: 0x1804DFC30 Slot: 21
	protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward) { }

	// RVA: 0x4E09A0 Offset: 0x4DF3A0 VA: 0x1804E09A0 Slot: 22
	protected virtual void Initialize() { }

	// RVA: 0x4E0330 Offset: 0x4DED30 VA: 0x1804E0330 Slot: 23
	protected virtual void Deinitialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 24
	protected virtual void BindEvents() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 25
	protected virtual void UnbindEvents() { }

	// RVA: 0x4E1230 Offset: 0x4DFC30 VA: 0x1804E1230 Slot: 26
	protected virtual void SavePrePlayState() { }

	// RVA: 0x4E1210 Offset: 0x4DFC10 VA: 0x1804E1210 Slot: 27
	protected virtual void RestorePrePlayState() { }

	// RVA: 0x4E1200 Offset: 0x4DFC00 VA: 0x1804E1200 Slot: 28
	protected virtual void ResetPrePlayState() { }

	// RVA: 0x4E0680 Offset: 0x4DF080 VA: 0x1804E0680 Slot: 29
	protected virtual void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	// RVA: 0x4E1690 Offset: 0x4E0090 VA: 0x1804E1690 Slot: 30
	protected virtual void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 31
	protected virtual void UserAfterInit() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 32
	protected virtual void UserAfterUpdate() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 33
	protected virtual bool get_ShowOrientationSection() { }

	// RVA: 0x4E2680 Offset: 0x4E1080 VA: 0x1804E2680 Slot: 34
	protected virtual bool get_ShowOffsetSection() { }

	// RVA: -1 Offset: -1 Slot: 35
	public abstract float get_Length();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void Advance(float speed, float deltaTime);

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract void SimulateAdvance(ref float tf, ref MovementDirection direction, float speed, float deltaTime);

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract float AbsoluteToRelative(float worldUnitDistance);

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract float RelativeToAbsolute(float relativeDistance);

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

	// RVA: -1 Offset: -1 Slot: 42
	protected abstract Vector3 GetOrientation(float tf);

	// RVA: -1 Offset: -1 Slot: 43
	protected abstract Vector3 GetTangent(float tf);

	// RVA: 0x4E1E70 Offset: 0x4E0870 VA: 0x1804E1E70
	public void .ctor() { }

	// RVA: 0x4E11A0 Offset: 0x4DFBA0 VA: 0x1804E11A0
	public void Play() { }

	// RVA: 0x4E1B60 Offset: 0x4E0560 VA: 0x1804E1B60
	public void Stop() { }

	// RVA: 0x4E1180 Offset: 0x4DFB80 VA: 0x1804E1180
	public void Pause() { }

	// RVA: 0x4E11F0 Offset: 0x4DFBF0 VA: 0x1804E11F0
	public void Refresh() { }

	// RVA: 0x4DF690 Offset: 0x4DE090 VA: 0x1804DF690
	public void ApplyDeltaTime(float deltaTime) { }

	// RVA: 0x4E1C90 Offset: 0x4E0690 VA: 0x1804E1C90
	public void TeleportTo(float newPosition) { }

	// RVA: 0x4E1BB0 Offset: 0x4E05B0 VA: 0x1804E1BB0
	public void TeleportBy(float distance, MovementDirection direction) { }

	// RVA: 0x4E1250 Offset: 0x4DFC50 VA: 0x1804E1250
	public void SetFromString(string fieldAndValue) { }

	[CompilerGenerated]
	// RVA: 0x4E2700 Offset: 0x4E1100 VA: 0x1804E2700
	protected bool get_isInitialized() { }

	[CompilerGenerated]
	// RVA: 0x4E2B90 Offset: 0x4E1590 VA: 0x1804E2B90
	private void set_isInitialized(bool value) { }

	// RVA: 0x4E2690 Offset: 0x4E1090 VA: 0x1804E2690
	protected float get_TimeSinceLastUpdate() { }

	// RVA: 0x4E26E0 Offset: 0x4E10E0 VA: 0x1804E26E0
	protected bool get_UseOffset() { }

	// RVA: 0x4DF740 Offset: 0x4DE140 VA: 0x1804DF740
	protected static Vector3 ApplyOffset(Vector3 position, Vector3 tangent, Vector3 up, float offsetAngle, float offsetRadius) { }

	// RVA: 0x4E0390 Offset: 0x4DED90 VA: 0x1804E0390
	protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length) { }

	// RVA: 0x4E2710 Offset: 0x4E1110 VA: 0x1804E2710
	private float get_maxPosition() { }

	// RVA: 0x4E0420 Offset: 0x4DEE20 VA: 0x1804E0420
	protected float GetMaxPosition(CurvyPositionMode positionMode) { }

	// RVA: 0x4DF840 Offset: 0x4DE240 VA: 0x1804DF840
	protected float ComputeOffsetCompensatedSpeed(float deltaTime) { }

	// RVA: 0x4E04C0 Offset: 0x4DEEC0 VA: 0x1804E04C0
	private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward) { }

	// RVA: 0x4E22D0 Offset: 0x4E0CD0 VA: 0x1804E22D0
	private bool get_IsNeededRigidbodyMissing() { }

	// RVA: 0x4E21B0 Offset: 0x4E0BB0 VA: 0x1804E21B0
	private bool get_IsNeeded2DRigidbodyMissing() { }

	// RVA: 0x4E2350 Offset: 0x4E0D50 VA: 0x1804E2350
	private bool get_IsNeededRigidbodyNotKinematic() { }

	// RVA: 0x4E2230 Offset: 0x4E0C30 VA: 0x1804E2230
	private bool get_IsNeeded2DRigidbodyNotKinematic() { }

	// RVA: 0x4E2070 Offset: 0x4E0A70 VA: 0x1804E2070
	private bool get_AreConstraintsConflicting() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public void OnBeforeSerialize() { }

	// RVA: 0x4E1030 Offset: 0x4DFA30 VA: 0x1804E1030 Slot: 44
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x4E2170 Offset: 0x4E0B70 VA: 0x1804E2170
	protected Vector3 get_DirectionDampingVelocity() { }

	// RVA: 0x4E2800 Offset: 0x4E1200 VA: 0x1804E2800
	protected void set_DirectionDampingVelocity(Vector3 value) { }

	// RVA: 0x4E26B0 Offset: 0x4E10B0 VA: 0x1804E26B0
	protected Vector3 get_UpDampingVelocity() { }

	// RVA: 0x4E2B60 Offset: 0x4E1560 VA: 0x1804E2B60
	protected void set_UpDampingVelocity(Vector3 value) { }
}
