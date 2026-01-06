public sealed class Light : Behaviour // TypeDefIndex: 11676
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativeProperty("LightType")]
	public LightType type { get; set; }
	public float spotAngle { get; set; }
	public float innerSpotAngle { get; }
	public Color color { get; set; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; set; }
	public float bounceIntensity { get; }
	public float shadowBias { get; }
	public float shadowNormalBias { get; }
	public float shadowNearPlane { get; }
	public float range { get; set; }
	public LightBakingOutput bakingOutput { get; }
	public int cullingMask { set; }
	public int renderingLayerMask { set; }
	public LightShadows shadows { get; set; }
	public float shadowStrength { get; }
	public LightShadowResolution shadowResolution { get; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x2C90940 Offset: 0x2C8F340 VA: 0x182C90940
	public LightType get_type() { }

	// RVA: 0x2C90C10 Offset: 0x2C8F610 VA: 0x182C90C10
	public void set_type(LightType value) { }

	// RVA: 0x2C90900 Offset: 0x2C8F300 VA: 0x182C90900
	public float get_spotAngle() { }

	// RVA: 0x2C90BC0 Offset: 0x2C8F5C0 VA: 0x182C90BC0
	public void set_spotAngle(float value) { }

	// RVA: 0x2C906C0 Offset: 0x2C8F0C0 VA: 0x182C906C0
	public float get_innerSpotAngle() { }

	// RVA: 0x2C905F0 Offset: 0x2C8EFF0 VA: 0x182C905F0
	public Color get_color() { }

	// RVA: 0x2C90A10 Offset: 0x2C8F410 VA: 0x182C90A10
	public void set_color(Color value) { }

	// RVA: 0x2C90560 Offset: 0x2C8EF60 VA: 0x182C90560
	public float get_colorTemperature() { }

	// RVA: 0x2C90980 Offset: 0x2C8F380 VA: 0x182C90980
	public bool get_useColorTemperature() { }

	// RVA: 0x2C90700 Offset: 0x2C8F100 VA: 0x182C90700
	public float get_intensity() { }

	// RVA: 0x2C90AA0 Offset: 0x2C8F4A0 VA: 0x182C90AA0
	public void set_intensity(float value) { }

	// RVA: 0x2C90520 Offset: 0x2C8EF20 VA: 0x182C90520
	public float get_bounceIntensity() { }

	// RVA: 0x2C90780 Offset: 0x2C8F180 VA: 0x182C90780
	public float get_shadowBias() { }

	// RVA: 0x2C90800 Offset: 0x2C8F200 VA: 0x182C90800
	public float get_shadowNormalBias() { }

	// RVA: 0x2C907C0 Offset: 0x2C8F1C0 VA: 0x182C907C0
	public float get_shadowNearPlane() { }

	// RVA: 0x2C90740 Offset: 0x2C8F140 VA: 0x182C90740
	public float get_range() { }

	// RVA: 0x2C90AF0 Offset: 0x2C8F4F0 VA: 0x182C90AF0
	public void set_range(float value) { }

	// RVA: 0x2C904D0 Offset: 0x2C8EED0 VA: 0x182C904D0
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x2C90A60 Offset: 0x2C8F460 VA: 0x182C90A60
	public void set_cullingMask(int value) { }

	// RVA: 0x2C90B40 Offset: 0x2C8F540 VA: 0x182C90B40
	public void set_renderingLayerMask(int value) { }

	[NativeMethod("GetShadowType")]
	// RVA: 0x2C908C0 Offset: 0x2C8F2C0 VA: 0x182C908C0
	public LightShadows get_shadows() { }

	[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C90B80 Offset: 0x2C8F580 VA: 0x182C90B80
	public void set_shadows(LightShadows value) { }

	// RVA: 0x2C90880 Offset: 0x2C8F280 VA: 0x182C90880
	public float get_shadowStrength() { }

	// RVA: 0x2C90840 Offset: 0x2C8F240 VA: 0x182C90840
	public LightShadowResolution get_shadowResolution() { }

	// RVA: 0x2C90640 Offset: 0x2C8F040 VA: 0x182C90640
	public float get_cookieSize() { }

	// RVA: 0x2C90680 Offset: 0x2C8F080 VA: 0x182C90680
	public Texture get_cookie() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C905A0 Offset: 0x2C8EFA0 VA: 0x182C905A0
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x2C909C0 Offset: 0x2C8F3C0 VA: 0x182C909C0
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x2C90480 Offset: 0x2C8EE80 VA: 0x182C90480
	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }
}
