public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 16069
{
	// Fields
	[VcamTargetProperty]
	[NoSaveDuringPlay]
	[Tooltip("Object for the camera children to look at (the aim target).")]
	public Transform m_LookAt; // 0xA8
	[NoSaveDuringPlay]
	[VcamTargetProperty]
	[Tooltip("Object for the camera children wants to move with (the body target).")]
	public Transform m_Follow; // 0xB0
	[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
	[FormerlySerializedAs("m_UseCommonLensSetting")]
	public bool m_CommonLens; // 0xB8
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active")]
	[FormerlySerializedAs("m_LensAttributes")]
	public LensSettings m_Lens; // 0xBC
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xF0
	[FormerlySerializedAs("m_BlendHint")]
	[FormerlySerializedAs("m_PositionBlending")]
	[HideInInspector]
	[SerializeField]
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0x100
	[Header("Axis Control")]
	[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
	[AxisStateProperty]
	public AxisState m_YAxis; // 0x108
	[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
	public AxisState.Recentering m_YAxisRecentering; // 0x178
	[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs' OrbitalTransposer component")]
	[AxisStateProperty]
	public AxisState m_XAxis; // 0x198
	[OrbitalTransposerHeadingProperty]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0x208
	[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
	public AxisState.Recentering m_RecenterToTargetHeading; // 0x214
	[Header("Orbits")]
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x234
	[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
	[Range(0, 1)]
	[FormerlySerializedAs("m_SplineTension")]
	public float m_SplineCurvature; // 0x238
	[Tooltip("The radius and height of the three orbiting rigs.")]
	public CinemachineFreeLook.Orbit[] m_Orbits; // 0x240
	[FormerlySerializedAs("m_HeadingBias")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyHeadingBias; // 0x248
	private bool mUseLegacyRigDefinitions; // 0x24C
	private bool mIsDestroyed; // 0x24D
	private CameraState m_State; // 0x250
	[HideInInspector]
	[SerializeField]
	[NoSaveDuringPlay]
	private CinemachineVirtualCamera[] m_Rigs; // 0x338
	private CinemachineOrbitalTransposer[] mOrbitals; // 0x340
	private CinemachineBlend mBlendA; // 0x348
	private CinemachineBlend mBlendB; // 0x350
	public static CinemachineFreeLook.CreateRigDelegate CreateRigOverride; // 0x0
	public static CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride; // 0x8
	private float m_CachedXAxisHeading; // 0x358
	private float m_LastHeadingUpdateFrame; // 0x35C
	private CinemachineFreeLook.Orbit[] m_CachedOrbits; // 0x360
	private float m_CachedTension; // 0x368
	private Vector4[] m_CachedKnots; // 0x370
	private Vector4[] m_CachedCtrl1; // 0x378
	private Vector4[] m_CachedCtrl2; // 0x380

	// Properties
	internal bool RigsAreCreated { get; }
	public static string[] RigNames { get; }
	public override bool PreviousStateIsValid { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0xBEE520 Offset: 0xBECF20 VA: 0x180BEE520 Slot: 41
	protected override void OnValidate() { }

	// RVA: 0xBECB70 Offset: 0xBEB570 VA: 0x180BECB70
	public CinemachineVirtualCamera GetRig(int i) { }

	// RVA: 0xBF03C0 Offset: 0xBEEDC0 VA: 0x180BF03C0
	internal bool get_RigsAreCreated() { }

	// RVA: 0xBF02F0 Offset: 0xBEECF0 VA: 0x180BF02F0
	public static string[] get_RigNames() { }

	// RVA: 0xBEDF10 Offset: 0xBEC910 VA: 0x180BEDF10 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xBEF740 Offset: 0xBEE140 VA: 0x180BEF740
	public void UpdateInputAxisProvider() { }

	// RVA: 0xBEDDC0 Offset: 0xBEC7C0 VA: 0x180BEDDC0 Slot: 37
	protected override void OnDestroy() { }

	// RVA: 0xBED760 Offset: 0xBEC160 VA: 0x180BED760
	private void OnTransformChildrenChanged() { }

	// RVA: 0xBEED10 Offset: 0xBED710 VA: 0x180BEED10
	private void Reset() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0 Slot: 33
	public override bool get_PreviousStateIsValid() { }

	// RVA: 0xBF0480 Offset: 0xBEEE80 VA: 0x180BF0480 Slot: 34
	public override void set_PreviousStateIsValid(bool value) { }

	// RVA: 0xBF03E0 Offset: 0xBEEDE0 VA: 0x180BF03E0 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0xBDC7D0 Offset: 0xBDB1D0 VA: 0x180BDC7D0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	// RVA: 0xBDC7B0 Offset: 0xBDB1B0 VA: 0x180BDC7B0 Slot: 31
	public override Transform get_Follow() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xBED780 Offset: 0xBEC180 VA: 0x180BED780 Slot: 28
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0xBEDFC0 Offset: 0xBEC9C0 VA: 0x180BEDFC0 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBEC680 Offset: 0xBEB080 VA: 0x180BEC680 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBED000 Offset: 0xBEBA00 VA: 0x180BED000 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBEE0B0 Offset: 0xBECAB0 VA: 0x180BEE0B0 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 40
	internal override bool RequiresUserInput() { }

	// RVA: 0xBECBD0 Offset: 0xBEB5D0 VA: 0x180BECBD0
	private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	// RVA: 0xBEED30 Offset: 0xBED730 VA: 0x180BEED30
	private float SteepestDescent(Vector3 cameraOffset) { }

	// RVA: 0xBED760 Offset: 0xBEC160 VA: 0x180BED760
	private void InvalidateRigCache() { }

	// RVA: 0xBEC160 Offset: 0xBEAB60 VA: 0x180BEC160
	private void DestroyRigs() { }

	// RVA: 0xBEB7B0 Offset: 0xBEA1B0 VA: 0x180BEB7B0
	private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) { }

	// RVA: 0xBEF7C0 Offset: 0xBEE1C0 VA: 0x180BEF7C0
	private bool UpdateRigCache() { }

	// RVA: 0xBED890 Offset: 0xBEC290 VA: 0x180BED890
	private List<CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital) { }

	// RVA: 0xBEFBC0 Offset: 0xBEE5C0 VA: 0x180BEFBC0
	private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	// RVA: 0xBEE660 Offset: 0xBED060 VA: 0x180BEE660
	private void PushSettingsToRigs() { }

	// RVA: 0xBECFD0 Offset: 0xBEB9D0 VA: 0x180BECFD0
	private float GetYAxisValue() { }

	// RVA: 0xBEB500 Offset: 0xBE9F00 VA: 0x180BEB500
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBEC8C0 Offset: 0xBEB2C0 VA: 0x180BEC8C0
	public Vector3 GetLocalPositionForCameraFromInput(float t) { }

	// RVA: 0xBEF1D0 Offset: 0xBEDBD0 VA: 0x180BEF1D0
	private void UpdateCachedSpline() { }

	// RVA: 0xBEDD00 Offset: 0xBEC700 VA: 0x180BEDD00 Slot: 48
	internal override void OnBeforeSerialize() { }

	// RVA: 0xBEFD70 Offset: 0xBEE770 VA: 0x180BEFD70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xBEEF50 Offset: 0xBED950 VA: 0x180BEEF50
	private float <SteepestDescent>g__AngleFunction|47_0(float input, ref CinemachineFreeLook.<>c__DisplayClass47_0 ) { }

	[CompilerGenerated]
	// RVA: 0xBEF160 Offset: 0xBEDB60 VA: 0x180BEF160
	private float <SteepestDescent>g__SlopeOfAngleFunction|47_1(float input, ref CinemachineFreeLook.<>c__DisplayClass47_0 ) { }

	[CompilerGenerated]
	// RVA: 0xBEF050 Offset: 0xBEDA50 VA: 0x180BEF050
	private float <SteepestDescent>g__InitialGuess|47_2(ref CinemachineFreeLook.<>c__DisplayClass47_0 ) { }

	[CompilerGenerated]
	// RVA: 0xBEF010 Offset: 0xBEDA10 VA: 0x180BEF010
	private void <SteepestDescent>g__ChooseBestAngle|47_3(float referenceAngle, ref CinemachineFreeLook.<>c__DisplayClass47_0 , ref CinemachineFreeLook.<>c__DisplayClass47_1 ) { }
}
