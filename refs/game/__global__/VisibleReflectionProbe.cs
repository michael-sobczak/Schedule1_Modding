public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe> // TypeDefIndex: 12281
{
	// Fields
	private Bounds m_Bounds; // 0x0
	private Matrix4x4 m_LocalToWorldMatrix; // 0x18
	private Vector4 m_HdrData; // 0x58
	private Vector3 m_Center; // 0x68
	private float m_BlendDistance; // 0x74
	private int m_Importance; // 0x78
	private int m_BoxProjection; // 0x7C
	private int m_InstanceId; // 0x80
	private int m_TextureId; // 0x84

	// Properties
	public Texture texture { get; }
	public ReflectionProbe reflectionProbe { get; }
	public Bounds bounds { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Vector4 hdrData { get; }
	public float blendDistance { get; }
	public int importance { get; }
	public bool isBoxProjection { get; }

	// Methods

	// RVA: 0x2D00440 Offset: 0x2CFEE40 VA: 0x182D00440
	public Texture get_texture() { }

	// RVA: 0x2D003C0 Offset: 0x2CFEDC0 VA: 0x182D003C0
	public ReflectionProbe get_reflectionProbe() { }

	// RVA: 0x2D00300 Offset: 0x2CFED00 VA: 0x182D00300
	public Bounds get_bounds() { }

	// RVA: 0x2D00390 Offset: 0x2CFED90 VA: 0x182D00390
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2D00320 Offset: 0x2CFED20 VA: 0x182D00320
	public Vector4 get_hdrData() { }

	// RVA: 0x2D002F0 Offset: 0x2CFECF0 VA: 0x182D002F0
	public float get_blendDistance() { }

	// RVA: 0x2D00330 Offset: 0x2CFED30 VA: 0x182D00330
	public int get_importance() { }

	// RVA: 0x2D00340 Offset: 0x2CFED40 VA: 0x182D00340
	public bool get_isBoxProjection() { }

	// RVA: 0x2CFFE80 Offset: 0x2CFE880 VA: 0x182CFFE80 Slot: 4
	public bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x2CFFD70 Offset: 0x2CFE770 VA: 0x182CFFD70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D00120 Offset: 0x2CFEB20 VA: 0x182D00120 Slot: 2
	public override int GetHashCode() { }
}
