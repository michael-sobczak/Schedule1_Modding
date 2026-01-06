public struct LensSettings // TypeDefIndex: 16176
{
	// Fields
	public static LensSettings Default; // 0x0
	[Range(1, 179)]
	[Tooltip("This is the camera view in degrees. Display will be in vertical degress, unless the associated camera has its FOV axis setting set to Horizontal, in which case display will be in horizontal degress.  Internally, it is always vertical degrees.  For cinematic people, a 50mm lens on a super-35mm sensor would equal a 19.6 degree FOV")]
	public float FieldOfView; // 0x0
	[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
	public float OrthographicSize; // 0x4
	[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
	public float NearClipPlane; // 0x8
	[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
	public float FarClipPlane; // 0xC
	[Range(-180, 180)]
	[Tooltip("Camera Z roll, or tilt, in degrees.")]
	public float Dutch; // 0x10
	[Tooltip("Allows you to select a different camera mode to apply to the Camera component when Cinemachine activates this Virtual Camera.  The changes applied to the Camera component through this setting will remain after the Virtual Camera deactivation.")]
	public LensSettings.OverrideModes ModeOverride; // 0x14
	public Vector2 LensShift; // 0x18
	public Camera.GateFitMode GateFit; // 0x20
	public float FocusDistance; // 0x24
	[SerializeField]
	private Vector2 m_SensorSize; // 0x28
	private bool m_OrthoFromCamera; // 0x30
	private bool m_PhysicalFromCamera; // 0x31

	// Properties
	public bool Orthographic { get; set; }
	public Vector2 SensorSize { get; set; }
	public float Aspect { get; }
	public bool IsPhysicalCamera { get; set; }

	// Methods

	// RVA: 0xC241D0 Offset: 0xC22BD0 VA: 0x180C241D0
	public bool get_Orthographic() { }

	// RVA: 0xC24220 Offset: 0xC22C20 VA: 0x180C24220
	public void set_Orthographic(bool value) { }

	// RVA: 0xC241F0 Offset: 0xC22BF0 VA: 0x180C241F0
	public Vector2 get_SensorSize() { }

	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	public void set_SensorSize(Vector2 value) { }

	// RVA: 0xC24130 Offset: 0xC22B30 VA: 0x180C24130
	public float get_Aspect() { }

	// RVA: 0xC241B0 Offset: 0xC22BB0 VA: 0x180C241B0
	public bool get_IsPhysicalCamera() { }

	// RVA: 0xC24210 Offset: 0xC22C10 VA: 0x180C24210
	public void set_IsPhysicalCamera(bool value) { }

	// RVA: 0xC238A0 Offset: 0xC222A0 VA: 0x180C238A0
	public static LensSettings FromCamera(Camera fromCamera) { }

	// RVA: 0xC23C70 Offset: 0xC22670 VA: 0x180C23C70
	public void SnapshotCameraReadOnlyProperties(Camera camera) { }

	// RVA: 0xC23ED0 Offset: 0xC228D0 VA: 0x180C23ED0
	public void SnapshotCameraReadOnlyProperties(ref LensSettings lens) { }

	// RVA: 0xC240E0 Offset: 0xC22AE0 VA: 0x180C240E0
	public void .ctor(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch) { }

	// RVA: 0xC23A20 Offset: 0xC22420 VA: 0x180C23A20
	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) { }

	// RVA: 0xC23FD0 Offset: 0xC229D0 VA: 0x180C23FD0
	public void Validate() { }

	// RVA: 0xC24050 Offset: 0xC22A50 VA: 0x180C24050
	private static void .cctor() { }
}
