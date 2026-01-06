public struct ShadowSplitData : IEquatable<ShadowSplitData> // TypeDefIndex: 12270
{
	// Fields
	private const int k_MaximumCullingPlaneCount = 10;
	public static readonly int maximumCullingPlaneCount; // 0x0
	private int m_CullingPlaneCount; // 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x4
	private Vector4 m_CullingSphere; // 0xA4
	private float m_ShadowCascadeBlendCullingFactor; // 0xB4
	private float m_CullingNearPlane; // 0xB8
	private Matrix4x4 m_CullingMatrix; // 0xBC

	// Properties
	public int cullingPlaneCount { get; }
	public Vector4 cullingSphere { get; }
	public float shadowCascadeBlendCullingFactor { set; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_cullingPlaneCount() { }

	// RVA: 0x2CFD7E0 Offset: 0x2CFC1E0 VA: 0x182CFD7E0
	public Vector4 get_cullingSphere() { }

	// RVA: 0x2CFD7F0 Offset: 0x2CFC1F0 VA: 0x182CFD7F0
	public void set_shadowCascadeBlendCullingFactor(float value) { }

	// RVA: 0x2CFD5A0 Offset: 0x2CFBFA0 VA: 0x182CFD5A0
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x2CFD2D0 Offset: 0x2CFBCD0 VA: 0x182CFD2D0 Slot: 4
	public bool Equals(ShadowSplitData other) { }

	// RVA: 0x2CFD170 Offset: 0x2CFBB70 VA: 0x182CFD170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFD710 Offset: 0x2CFC110 VA: 0x182CFD710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CFD7A0 Offset: 0x2CFC1A0 VA: 0x182CFD7A0
	private static void .cctor() { }
}
