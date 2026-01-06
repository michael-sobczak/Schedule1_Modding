public struct VisibleLight : IEquatable<VisibleLight> // TypeDefIndex: 12279
{
	// Fields
	private LightType m_LightType; // 0x0
	private Color m_FinalColor; // 0x4
	private Rect m_ScreenRect; // 0x14
	private Matrix4x4 m_LocalToWorldMatrix; // 0x24
	private float m_Range; // 0x64
	private float m_SpotAngle; // 0x68
	private int m_InstanceId; // 0x6C
	private VisibleLightFlags m_Flags; // 0x70

	// Properties
	public Light light { get; }
	public LightType lightType { get; }
	public Color finalColor { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public float range { get; }
	public float spotAngle { get; }

	// Methods

	// RVA: 0x2CFFCA0 Offset: 0x2CFE6A0 VA: 0x182CFFCA0
	public Light get_light() { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public LightType get_lightType() { }

	// RVA: 0x2CFFC90 Offset: 0x2CFE690 VA: 0x182CFFC90
	public Color get_finalColor() { }

	// RVA: 0x2CFFD20 Offset: 0x2CFE720 VA: 0x182CFFD20
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2CFFD50 Offset: 0x2CFE750 VA: 0x182CFFD50
	public float get_range() { }

	// RVA: 0x2CFFD60 Offset: 0x2CFE760 VA: 0x182CFFD60
	public float get_spotAngle() { }

	// RVA: 0x2CFF800 Offset: 0x2CFE200 VA: 0x182CFF800 Slot: 4
	public bool Equals(VisibleLight other) { }

	// RVA: 0x2CFFA70 Offset: 0x2CFE470 VA: 0x182CFFA70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CFFB60 Offset: 0x2CFE560 VA: 0x182CFFB60 Slot: 2
	public override int GetHashCode() { }
}
