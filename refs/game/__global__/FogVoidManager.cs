public class FogVoidManager : MonoBehaviour, IVolumetricFogManager // TypeDefIndex: 9200
{
	// Fields
	public static bool usingVoids; // 0x0
	public const int MAX_FOG_VOID = 8;
	[Header("Void Search Settings")]
	public Transform trackingCenter; // 0x20
	[Tooltip("Fog voids are sorted by camera distance every certain time interval to ensure the nearest 8 voids are used.")]
	public float distanceSortTimeInterval; // 0x28
	private static readonly List<FogVoid> fogVoids; // 0x8
	private Vector4[] fogVoidPositions; // 0x30
	private Vector4[] fogVoidSizes; // 0x38
	private Matrix4x4[] fogVoidMatrices; // 0x40
	private float distanceSortLastTime; // 0x48
	private static bool requireRefresh; // 0x10
	private int lastFogVoidCount; // 0x4C

	// Properties
	public string managerName { get; }

	// Methods

	// RVA: 0x2A931C0 Offset: 0x2A91BC0 VA: 0x182A931C0 Slot: 4
	public string get_managerName() { }

	// RVA: 0x2A924C0 Offset: 0x2A90EC0 VA: 0x182A924C0
	private void OnEnable() { }

	// RVA: 0x2A92370 Offset: 0x2A90D70 VA: 0x182A92370
	private void LateUpdate() { }

	// RVA: 0x2A92800 Offset: 0x2A91200 VA: 0x182A92800
	private void SubmitFogVoidData() { }

	// RVA: 0x2A926E0 Offset: 0x2A910E0 VA: 0x182A926E0
	public static void RegisterFogVoid(FogVoid fogVoid) { }

	// RVA: 0x2A92E90 Offset: 0x2A91890 VA: 0x182A92E90
	public static void UnregisterFogVoid(FogVoid fogVoid) { }

	// RVA: 0x2A92CB0 Offset: 0x2A916B0 VA: 0x182A92CB0
	public void TrackFogVoids(bool forceImmediateUpdate = False) { }

	// RVA: 0x2A93050 Offset: 0x2A91A50 VA: 0x182A93050
	private int fogVoidDistanceComparer(FogVoid v1, FogVoid v2) { }

	// RVA: 0x2A92690 Offset: 0x2A91090 VA: 0x182A92690
	public void Refresh() { }

	// RVA: 0x2A93040 Offset: 0x2A91A40 VA: 0x182A93040
	public void .ctor() { }

	// RVA: 0x2A92FB0 Offset: 0x2A919B0 VA: 0x182A92FB0
	private static void .cctor() { }
}
