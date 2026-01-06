public struct CameraProperties : IEquatable<CameraProperties> // TypeDefIndex: 12237
{
	// Fields
	private const int k_NumLayers = 32;
	private Rect screenRect; // 0x0
	private Vector3 viewDir; // 0x10
	private float projectionNear; // 0x1C
	private float projectionFar; // 0x20
	private float cameraNear; // 0x24
	private float cameraFar; // 0x28
	private float cameraAspect; // 0x2C
	private Matrix4x4 cameraToWorld; // 0x30
	private Matrix4x4 actualWorldToClip; // 0x70
	private Matrix4x4 cameraClipToWorld; // 0xB0
	private Matrix4x4 cameraWorldToClip; // 0xF0
	private Matrix4x4 implicitProjection; // 0x130
	private Matrix4x4 stereoWorldToClipLeft; // 0x170
	private Matrix4x4 stereoWorldToClipRight; // 0x1B0
	private Matrix4x4 worldToCamera; // 0x1F0
	private Vector3 up; // 0x230
	private Vector3 right; // 0x23C
	private Vector3 transformDirection; // 0x248
	private Vector3 cameraEuler; // 0x254
	private Vector3 velocity; // 0x260
	private float farPlaneWorldSpaceLength; // 0x26C
	private uint rendererCount; // 0x270
	private const int k_PlaneCount = 6;
	[FixedBuffer(typeof(byte), 96)]
	internal CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x274
	[FixedBuffer(typeof(byte), 96)]
	internal CameraProperties.<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2D4
	private float baseFarDistance; // 0x334
	private Vector3 shadowCullCenter; // 0x338
	[FixedBuffer(typeof(float), 32)]
	internal CameraProperties.<layerCullDistances>e__FixedBuffer layerCullDistances; // 0x344
	private int layerCullSpherical; // 0x3C4
	private CoreCameraValues coreCameraValues; // 0x3C8
	private uint cameraType; // 0x3D4
	private int projectionIsOblique; // 0x3D8
	private int isImplicitProjectionMatrix; // 0x3DC

	// Methods

	// RVA: 0x2CD7E30 Offset: 0x2CD6830 VA: 0x182CD7E30
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x2CD7830 Offset: 0x2CD6230 VA: 0x182CD7830
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x2CD5E60 Offset: 0x2CD4860 VA: 0x182CD5E60 Slot: 4
	public bool Equals(CameraProperties other) { }

	// RVA: 0x2CD76F0 Offset: 0x2CD60F0 VA: 0x182CD76F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CD7940 Offset: 0x2CD6340 VA: 0x182CD7940 Slot: 2
	public override int GetHashCode() { }
}
