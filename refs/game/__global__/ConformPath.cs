public class ConformPath : CGModule, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10712
{
	// Fields
	private const int DefaultMaxDistance = 100;
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path", ModifiesData = True)]
	public CGModuleInputSlot InPath; // 0xC0
	[HideInInspector]
	[OutputSlotInfo(typeof(CGPath))]
	public CGModuleOutputSlot OutPath; // 0xC8
	[Tooltip("The direction to raycast in ")]
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Direction; // 0xD0
	[SerializeField]
	[Tooltip("The maximum raycast distance")]
	private float m_MaxDistance; // 0xDC
	[SerializeField]
	[Tooltip("Defines an offset shift along the raycast direction")]
	private float m_Offset; // 0xE0
	[SerializeField]
	[Tooltip("If enabled, the entire path is moved to the nearest possible distance. If disabled, each path point is moved individually")]
	private bool m_Warp; // 0xE4
	[SerializeField]
	[Tooltip("The layers to raycast against")]
	private LayerMask m_LayerMask; // 0xE8

	// Properties
	public Vector3 Direction { get; set; }
	public float MaxDistance { get; set; }
	public float Offset { get; set; }
	public bool Warp { get; set; }
	public LayerMask LayerMask { get; set; }
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x51E8B0 Offset: 0x51D2B0 VA: 0x18051E8B0
	public Vector3 get_Direction() { }

	// RVA: 0x51E990 Offset: 0x51D390 VA: 0x18051E990
	public void set_Direction(Vector3 value) { }

	// RVA: 0x5187F0 Offset: 0x5171F0 VA: 0x1805187F0
	public float get_MaxDistance() { }

	// RVA: 0x51EA80 Offset: 0x51D480 VA: 0x18051EA80
	public void set_MaxDistance(float value) { }

	// RVA: 0x51E8E0 Offset: 0x51D2E0 VA: 0x18051E8E0
	public float get_Offset() { }

	// RVA: 0x51EAB0 Offset: 0x51D4B0 VA: 0x18051EAB0
	public void set_Offset(float value) { }

	// RVA: 0x51E980 Offset: 0x51D380 VA: 0x18051E980
	public bool get_Warp() { }

	// RVA: 0x51EAE0 Offset: 0x51D4E0 VA: 0x18051EAE0
	public void set_Warp(bool value) { }

	// RVA: 0x51E8D0 Offset: 0x51D2D0 VA: 0x18051E8D0
	public LayerMask get_LayerMask() { }

	// RVA: 0x51EA20 Offset: 0x51D420 VA: 0x18051EA20
	public void set_LayerMask(LayerMask value) { }

	// RVA: 0x51E430 Offset: 0x51CE30 VA: 0x18051E430 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x51E670 Offset: 0x51D070 VA: 0x18051E670 Slot: 13
	public override void Reset() { }

	// RVA: 0x51E8F0 Offset: 0x51D2F0 VA: 0x18051E8F0 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x51E460 Offset: 0x51CE60 VA: 0x18051E460 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	// RVA: 0x51E3C0 Offset: 0x51CDC0 VA: 0x18051E3C0
	public static void Conform(CGPath path, Transform pathTransform, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp) { }

	[UsedImplicitly]
	[Obsolete("Use the other override")]
	// RVA: 0x51DE90 Offset: 0x51C890 VA: 0x18051DE90
	public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp) { }

	// RVA: 0x51E7D0 Offset: 0x51D1D0 VA: 0x18051E7D0
	public void .ctor() { }
}
