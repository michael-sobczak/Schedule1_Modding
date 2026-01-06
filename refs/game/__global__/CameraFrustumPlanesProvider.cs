public class CameraFrustumPlanesProvider // TypeDefIndex: 10492
{
	// Fields
	private static readonly Lazy<CameraFrustumPlanesProvider> instance; // 0x0
	private static object lockObject; // 0x8
	private readonly Plane[] cachedPlanes; // 0x10
	private Vector3 cachedPosition; // 0x18
	private Vector3 cachedForward; // 0x24
	private float cachedFov; // 0x30
	private int cachedPixelWidth; // 0x34
	private int cachedPixelHeight; // 0x38

	// Properties
	public static CameraFrustumPlanesProvider Instance { get; }

	// Methods

	// RVA: 0x4A1940 Offset: 0x4A0340 VA: 0x1804A1940
	public static CameraFrustumPlanesProvider get_Instance() { }

	// RVA: 0x4A1310 Offset: 0x49FD10 VA: 0x1804A1310
	public Plane[] GetFrustumPlanes(Camera camera) { }

	// RVA: 0x4A1680 Offset: 0x4A0080 VA: 0x1804A1680
	private bool IsCacheOutdated(Vector3 cameraPosition, Vector3 cameraZDirection, int cameraPixelWidth, int cameraPixelHeight, float cameraFieldOfView) { }

	// RVA: 0x4A18B0 Offset: 0x4A02B0 VA: 0x1804A18B0
	public void .ctor() { }

	// RVA: 0x4A1750 Offset: 0x4A0150 VA: 0x1804A1750
	private static void .cctor() { }
}
