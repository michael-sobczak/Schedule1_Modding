public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 16104
{
	// Fields
	[Space]
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; // 0x100
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x104
	[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_FrameDamping; // 0x108
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x10C
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; // 0x110
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; // 0x114
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; // 0x118
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; // 0x11C
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	[Range(1, 179)]
	public float m_MinimumFOV; // 0x120
	[Range(1, 179)]
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	public float m_MaximumFOV; // 0x124
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; // 0x128
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; // 0x12C
	private float m_prevFramingDistance; // 0x130
	private float m_prevFOV; // 0x134
	[CompilerGenerated]
	private Bounds <LastBounds>k__BackingField; // 0x138
	[CompilerGenerated]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x150

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0xBFD040 Offset: 0xBFBA40 VA: 0x180BFD040
	private void OnValidate() { }

	[CompilerGenerated]
	// RVA: 0xBFD380 Offset: 0xBFBD80 VA: 0x180BFD380
	public Bounds get_LastBounds() { }

	[CompilerGenerated]
	// RVA: 0xBFD3D0 Offset: 0xBFBDD0 VA: 0x180BFD3D0
	private void set_LastBounds(Bounds value) { }

	[CompilerGenerated]
	// RVA: 0xBFD350 Offset: 0xBFBD50 VA: 0x180BFD350
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGenerated]
	// RVA: 0xBFD3A0 Offset: 0xBFBDA0 VA: 0x180BFD3A0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0xBFBB90 Offset: 0xBFA590 VA: 0x180BFBB90 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xBFC1C0 Offset: 0xBFABC0 VA: 0x180BFC1C0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBFBF70 Offset: 0xBFA970 VA: 0x180BFBF70
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0xBFBBB0 Offset: 0xBFA5B0 VA: 0x180BFBBB0
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0xBFD110 Offset: 0xBFBB10 VA: 0x180BFD110
	public void .ctor() { }
}
