public struct LightDataGI // TypeDefIndex: 12329
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x2CF0AC0 Offset: 0x2CEF4C0 VA: 0x182CF0AC0
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x2CF0BD0 Offset: 0x2CEF5D0 VA: 0x182CF0BD0
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x2CF0A40 Offset: 0x2CEF440 VA: 0x182CF0A40
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x2CF0D30 Offset: 0x2CEF730 VA: 0x182CF0D30
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x2CF0C40 Offset: 0x2CEF640 VA: 0x182CF0C40
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x2CF0CB0 Offset: 0x2CEF6B0 VA: 0x182CF0CB0
	public void Init(ref DirectionalLight light) { }

	// RVA: 0x2CF0DA0 Offset: 0x2CEF7A0 VA: 0x182CF0DA0
	public void Init(ref PointLight light) { }

	// RVA: 0x2CF0B40 Offset: 0x2CEF540 VA: 0x182CF0B40
	public void Init(ref SpotLight light) { }

	// RVA: 0x2CF0A30 Offset: 0x2CEF430 VA: 0x182CF0A30
	public void InitNoBake(int lightInstanceID) { }
}
