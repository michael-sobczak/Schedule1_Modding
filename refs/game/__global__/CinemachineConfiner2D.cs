public class CinemachineConfiner2D : CinemachineExtension // TypeDefIndex: 16058
{
	// Fields
	[Tooltip("The 2D shape within which the camera is to be contained.  Can be a 2D polygon or 2D composite collider.")]
	public Collider2D m_BoundingShape2D; // 0x30
	[Range(0, 5)]
	[Tooltip("Damping applied around corners to avoid jumps.  Higher numbers are more gradual.")]
	public float m_Damping; // 0x38
	[Tooltip("To optimize computation and memory costs, set this to the largest view size that the camera is expected to have.  The confiner will not compute a polygon cache for frustum sizes larger than this.  This refers to the size in world units of the frustum at the confiner plane (for orthographic cameras, this is just the orthographic size).  If set to 0, then this parameter is ignored and a polygon cache will be calculated for all potential window sizes.")]
	public float m_MaxWindowSize; // 0x3C
	[Tooltip("For large window sizes, the confiner will potentially generate polygons with zero area.  The padding may be used to add a small amount of area to these polygons, to prevent them from being a series of disconnected dots.")]
	[Range(0, 100)]
	public float m_Padding; // 0x40
	private float m_MaxComputationTimePerFrameInSeconds; // 0x44
	private const float k_cornerAngleTreshold = 10;
	private CinemachineConfiner2D.ShapeCache m_shapeCache; // 0x48

	// Methods

	// RVA: 0xBE8550 Offset: 0xBE6F50 VA: 0x180BE8550
	public void InvalidateCache() { }

	// RVA: 0xBE8D00 Offset: 0xBE7700 VA: 0x180BE8D00
	public bool ValidateCache(float cameraAspectRatio) { }

	// RVA: 0xBE8580 Offset: 0xBE6F80 VA: 0x180BE8580 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBE8490 Offset: 0xBE6E90 VA: 0x180BE8490
	private float CalculateHalfFrustumHeight(in CameraState state, in float cameraPosLocalZ) { }

	// RVA: 0xBE8560 Offset: 0xBE6F60 VA: 0x180BE8560
	private void OnValidate() { }

	// RVA: 0xBE8CF0 Offset: 0xBE76F0 VA: 0x180BE8CF0
	private void Reset() { }

	// RVA: 0xBE8D50 Offset: 0xBE7750 VA: 0x180BE8D50
	public void .ctor() { }
}
