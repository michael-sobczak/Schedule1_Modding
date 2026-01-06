public class SimpleCameraController : MonoBehaviour // TypeDefIndex: 224
{
	// Fields
	private SimpleCameraController.CameraState m_TargetCameraState; // 0x20
	private SimpleCameraController.CameraState m_InterpolatingCameraState; // 0x28
	[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
	[Header("Movement Settings")]
	public float boost; // 0x30
	[Range(0.001, 1)]
	[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
	public float positionLerpTime; // 0x34
	[Tooltip("X = Change in mouse position.
Y = Multiplicative factor for camera rotation.")]
	[Header("Rotation Settings")]
	public AnimationCurve mouseSensitivityCurve; // 0x38
	[Range(0.001, 1)]
	[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
	public float rotationLerpTime; // 0x40
	[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
	public bool invertY; // 0x44

	// Methods

	// RVA: 0x6A0B90 Offset: 0x69F590 VA: 0x1806A0B90
	private void OnEnable() { }

	// RVA: 0x6A0870 Offset: 0x69F270 VA: 0x1806A0870
	private Vector3 GetInputTranslationDirection() { }

	// RVA: 0x6A0BF0 Offset: 0x69F5F0 VA: 0x1806A0BF0
	private void Update() { }

	// RVA: 0x6A1060 Offset: 0x69FA60 VA: 0x1806A1060
	public void .ctor() { }
}
