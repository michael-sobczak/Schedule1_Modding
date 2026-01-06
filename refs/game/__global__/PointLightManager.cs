public class PointLightManager : MonoBehaviour, IVolumetricFogManager // TypeDefIndex: 9202
{
	// Fields
	public static bool usingPointLights; // 0x0
	public const int MAX_POINT_LIGHTS = 16;
	[Tooltip("Point lights are sorted by distance to tracking center object")]
	[Header("Point Light Search Settings")]
	public Transform trackingCenter; // 0x20
	[Tooltip("Point lights are sorted by camera distance every certain time interval to ensure the nearest 16 point lights are used.")]
	public float distanceSortTimeInterval; // 0x28
	[Tooltip("Ignore point lights behind camera")]
	public bool excludeLightsBehind; // 0x2C
	[Header("Common Settings")]
	[Tooltip("Global inscattering multiplier for point lights")]
	public float inscattering; // 0x30
	[Tooltip("Global intensity multiplier for point lights")]
	public float intensity; // 0x34
	[Tooltip("Reduces light intensity near point lights")]
	public float insideAtten; // 0x38
	private static readonly List<FogPointLight> pointLights; // 0x8
	private static bool requireRefresh; // 0x10
	private int lastPointLightsCount; // 0x3C
	private Vector4[] pointLightColorBuffer; // 0x40
	private Vector4[] pointLightPositionBuffer; // 0x48
	private float distanceSortLastTime; // 0x50

	// Properties
	public string managerName { get; }

	// Methods

	// RVA: 0x2A97990 Offset: 0x2A96390 VA: 0x182A97990 Slot: 4
	public string get_managerName() { }

	// RVA: 0x2A96C00 Offset: 0x2A95600 VA: 0x182A96C00
	private void OnEnable() { }

	// RVA: 0x2A96AB0 Offset: 0x2A954B0 VA: 0x182A96AB0
	private void LateUpdate() { }

	// RVA: 0x2A96F00 Offset: 0x2A95900 VA: 0x182A96F00
	private void SubmitPointLightData() { }

	// RVA: 0x2A96DE0 Offset: 0x2A957E0 VA: 0x182A96DE0
	public static void RegisterPointLight(FogPointLight fogPointLight) { }

	// RVA: 0x2A977C0 Offset: 0x2A961C0 VA: 0x182A977C0
	public static void UnregisterPointLight(FogPointLight fogPointLight) { }

	// RVA: 0x2A975E0 Offset: 0x2A95FE0 VA: 0x182A975E0
	public void TrackPointLights(bool forceImmediateUpdate = False) { }

	// RVA: 0x2A93050 Offset: 0x2A91A50 VA: 0x182A93050
	private int pointLightsDistanceComparer(FogPointLight l1, FogPointLight l2) { }

	// RVA: 0x2A96D90 Offset: 0x2A95790 VA: 0x182A96D90
	public void Refresh() { }

	// RVA: 0x2A97970 Offset: 0x2A96370 VA: 0x182A97970
	public void .ctor() { }

	// RVA: 0x2A978E0 Offset: 0x2A962E0 VA: 0x182A978E0
	private static void .cctor() { }
}
