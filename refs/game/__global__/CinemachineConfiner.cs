public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 16055
{
	// Fields
	[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
	public CinemachineConfiner.Mode m_ConfineMode; // 0x30
	[Tooltip("The volume within which the camera is to be contained")]
	public Collider m_BoundingVolume; // 0x38
	[Tooltip("The 2D shape within which the camera is to be contained")]
	public Collider2D m_BoundingShape2D; // 0x40
	private Collider2D m_BoundingShape2DCache; // 0x48
	[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
	public bool m_ConfineScreenEdges; // 0x50
	[Range(0, 10)]
	[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
	public float m_Damping; // 0x54
	private List<List<Vector2>> m_pathCache; // 0x58
	private int m_pathTotalPointCount; // 0x60

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0xBE8D60 Offset: 0xBE7760 VA: 0x180BE8D60
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xBE98C0 Offset: 0xBE82C0 VA: 0x180BE98C0
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xBE9960 Offset: 0xBE8360 VA: 0x180BE9960
	private void OnValidate() { }

	// RVA: 0xBE98B0 Offset: 0xBE82B0 VA: 0x180BE98B0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0xBEA2E0 Offset: 0xBE8CE0 VA: 0x180BEA2E0
	public bool get_IsValid() { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0xBE9970 Offset: 0xBE8370 VA: 0x180BE9970 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBE9920 Offset: 0xBE8320 VA: 0x180BE9920
	public void InvalidatePathCache() { }

	// RVA: 0xBE9D20 Offset: 0xBE8720 VA: 0x180BE9D20
	private bool ValidatePathCache() { }

	// RVA: 0xBE8DD0 Offset: 0xBE77D0 VA: 0x180BE8DD0
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0xBE92E0 Offset: 0xBE7CE0 VA: 0x180BE92E0
	private Vector3 ConfineScreenEdges(ref CameraState state) { }

	// RVA: 0xBEA2D0 Offset: 0xBE8CD0 VA: 0x180BEA2D0
	public void .ctor() { }
}
