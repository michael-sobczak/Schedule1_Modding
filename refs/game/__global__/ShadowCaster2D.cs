public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver // TypeDefIndex: 8728
{
	// Fields
	private const ShadowCaster2D.ComponentVersions k_CurrentComponentVersion = 1;
	[SerializeField]
	private ShadowCaster2D.ComponentVersions m_ComponentVersion; // 0x30
	[SerializeField]
	private bool m_HasRenderer; // 0x34
	[SerializeField]
	private bool m_UseRendererSilhouette; // 0x35
	[SerializeField]
	private bool m_CastsShadows; // 0x36
	[SerializeField]
	private bool m_SelfShadows; // 0x37
	[SerializeField]
	private int[] m_ApplyToSortingLayers; // 0x38
	[SerializeField]
	private Vector3[] m_ShapePath; // 0x40
	[SerializeField]
	private int m_ShapePathHash; // 0x48
	[SerializeField]
	private Mesh m_Mesh; // 0x50
	[SerializeField]
	private int m_InstanceId; // 0x58
	internal ShadowCasterGroup2D m_ShadowCasterGroup; // 0x60
	internal ShadowCasterGroup2D m_PreviousShadowCasterGroup; // 0x68
	[SerializeField]
	internal Bounds m_LocalBounds; // 0x70
	internal BoundingSphere m_BoundingSphere; // 0x88
	private int m_PreviousShadowGroup; // 0x98
	private bool m_PreviousCastsShadows; // 0x9C
	private int m_PreviousPathHash; // 0xA0
	internal Vector3 m_CachedPosition; // 0xA4
	internal Vector3 m_CachedLossyScale; // 0xB0
	internal Quaternion m_CachedRotation; // 0xBC
	internal Matrix4x4 m_CachedShadowMatrix; // 0xCC
	internal Matrix4x4 m_CachedInverseShadowMatrix; // 0x10C
	internal Matrix4x4 m_CachedLocalToWorldMatrix; // 0x14C

	// Properties
	public Mesh mesh { get; }
	public Vector3[] shapePath { get; }
	internal int shapePathHash { get; set; }
	public bool useRendererSilhouette { get; set; }
	public bool selfShadows { get; set; }
	public bool castsShadows { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Mesh get_mesh() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Vector3[] get_shapePath() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	internal int get_shapePathHash() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	internal void set_shapePathHash(int value) { }

	// RVA: 0x2ACEE20 Offset: 0x2ACD820 VA: 0x182ACEE20 Slot: 4
	internal override void CacheValues() { }

	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void set_useRendererSilhouette(bool value) { }

	// RVA: 0x2ACF810 Offset: 0x2ACE210 VA: 0x182ACF810
	public bool get_useRendererSilhouette() { }

	// RVA: 0x2ACF830 Offset: 0x2ACE230 VA: 0x182ACF830
	public void set_selfShadows(bool value) { }

	// RVA: 0x2ACF800 Offset: 0x2ACE200 VA: 0x182ACF800
	public bool get_selfShadows() { }

	// RVA: 0x2ACF820 Offset: 0x2ACE220 VA: 0x182ACF820
	public void set_castsShadows(bool value) { }

	// RVA: 0x2ACF7F0 Offset: 0x2ACE1F0 VA: 0x182ACF7F0
	public bool get_castsShadows() { }

	// RVA: 0x2ACF290 Offset: 0x2ACDC90 VA: 0x182ACF290
	private static int[] SetDefaultSortingLayers() { }

	// RVA: 0x2ACF040 Offset: 0x2ACDA40 VA: 0x182ACF040
	internal bool IsLit(Light2D light) { }

	// RVA: 0x2ACF0C0 Offset: 0x2ACDAC0 VA: 0x182ACF0C0
	internal bool IsShadowedLayer(int layer) { }

	// RVA: 0x2ACE7F0 Offset: 0x2ACD1F0 VA: 0x182ACE7F0
	private void Awake() { }

	// RVA: 0x2ACF1A0 Offset: 0x2ACDBA0 VA: 0x182ACF1A0
	protected void OnEnable() { }

	// RVA: 0x2ACF190 Offset: 0x2ACDB90 VA: 0x182ACF190
	protected void OnDisable() { }

	// RVA: 0x2ACF5F0 Offset: 0x2ACDFF0 VA: 0x182ACF5F0
	public void Update() { }

	// RVA: 0x2ACF180 Offset: 0x2ACDB80 VA: 0x182ACF180 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x2ACF130 Offset: 0x2ACDB30 VA: 0x182ACF130 Slot: 6
	public void OnAfterDeserialize() { }

	// RVA: 0x2ACF370 Offset: 0x2ACDD70 VA: 0x182ACF370
	private void UpdateBoundingSphere() { }

	// RVA: 0x2ACF7D0 Offset: 0x2ACE1D0 VA: 0x182ACF7D0
	public void .ctor() { }
}
