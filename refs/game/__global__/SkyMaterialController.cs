public class SkyMaterialController // TypeDefIndex: 466
{
	// Fields
	[SerializeField]
	private Material _skyboxMaterial; // 0x10
	[SerializeField]
	private Color _skyColor; // 0x18
	[SerializeField]
	private Color _skyMiddleColor; // 0x28
	[SerializeField]
	private Color _horizonColor; // 0x38
	[SerializeField]
	[Range(-1, 1)]
	private float _gradientFadeBegin; // 0x48
	[Range(0, 2)]
	[SerializeField]
	private float _gradientFadeLength; // 0x4C
	[SerializeField]
	[Range(0, 1)]
	private float _skyMiddlePosition; // 0x50
	[SerializeField]
	private Cubemap _backgroundCubemap; // 0x58
	[Range(-1, 1)]
	[SerializeField]
	private float _starFadeBegin; // 0x60
	[SerializeField]
	[Range(0, 2)]
	private float _starFadeLength; // 0x64
	[SerializeField]
	[Range(0, 1)]
	private float _horizonDistanceScale; // 0x68
	[SerializeField]
	private Texture _starBasicCubemap; // 0x70
	[SerializeField]
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField]
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField]
	private float _starBasicOpacity; // 0x80
	[SerializeField]
	private Color _starBasicTintColor; // 0x84
	[SerializeField]
	private float _starBasicExponent; // 0x94
	[SerializeField]
	private float _starBasicIntensity; // 0x98
	[SerializeField]
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField]
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField]
	private Color _starLayer1Color; // 0xB0
	[SerializeField]
	[Range(0, 0.1)]
	private float _starLayer1MaxRadius; // 0xC0
	[Range(0, 1)]
	[SerializeField]
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField]
	[Range(0, 10)]
	private float _starLayer1TwinkleSpeed; // 0xC8
	[Range(0, 10)]
	[SerializeField]
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField]
	[Range(0.0001, 0.9999)]
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField]
	[Range(1, 10)]
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField]
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField]
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField]
	[Range(0, 1)]
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField]
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField]
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField]
	private Color _starLayer2Color; // 0x100
	[SerializeField]
	[Range(0, 0.1)]
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField]
	[Range(0, 1)]
	private float _starLayer2TwinkleAmount; // 0x114
	[Range(0, 10)]
	[SerializeField]
	private float _starLayer2TwinkleSpeed; // 0x118
	[Range(0, 10)]
	[SerializeField]
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField]
	[Range(0.0001, 0.9999)]
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField]
	[Range(1, 10)]
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField]
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField]
	private int _starLayer2SpriteItemCount; // 0x138
	[Range(0, 1)]
	[SerializeField]
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField]
	private Texture _starLayer3Texture; // 0x140
	[SerializeField]
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField]
	private Color _starLayer3Color; // 0x150
	[SerializeField]
	[Range(0, 0.1)]
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField]
	[Range(0, 1)]
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField]
	[Range(0, 10)]
	private float _starLayer3TwinkleSpeed; // 0x168
	[Range(0, 10)]
	[SerializeField]
	private float _starLayer3RotationSpeed; // 0x16C
	[Range(0.0001, 0.9999)]
	[SerializeField]
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField]
	[Range(1, 10)]
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField]
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField]
	private int _starLayer3SpriteItemCount; // 0x188
	[Range(0, 1)]
	[SerializeField]
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField]
	private Texture _moonTexture; // 0x190
	[SerializeField]
	private float _moonRotationSpeed; // 0x198
	[SerializeField]
	private Color _moonColor; // 0x19C
	[SerializeField]
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField]
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField]
	[Range(0, 1)]
	private float _moonSize; // 0x1F8
	[Range(0.0001, 0.9999)]
	[SerializeField]
	private float _moonEdgeFeathering; // 0x1FC
	[Range(1, 10)]
	[SerializeField]
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField]
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField]
	private int _moonSpriteItemCount; // 0x214
	[Range(0, 1)]
	[SerializeField]
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField]
	[Range(0, 1)]
	private float _moonAlpha; // 0x21C
	[SerializeField]
	private Texture _sunTexture; // 0x220
	[SerializeField]
	private Color _sunColor; // 0x228
	[SerializeField]
	private float _sunRotationSpeed; // 0x238
	[SerializeField]
	private Vector3 _sunDirection; // 0x23C
	[SerializeField]
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField]
	[Range(0, 1)]
	private float _sunSize; // 0x288
	[SerializeField]
	[Range(0.0001, 0.9999)]
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField]
	[Range(1, 10)]
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField]
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField]
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField]
	[Range(0, 1)]
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[Range(0, 1)]
	[SerializeField]
	private float _sunAlpha; // 0x2AC
	[Range(-1, 1)]
	[SerializeField]
	private float _cloudBegin; // 0x2B0
	private float _cloudTextureTiling; // 0x2B4
	[SerializeField]
	private Color _cloudColor; // 0x2B8
	[SerializeField]
	private Texture _cloudTexture; // 0x2C8
	[SerializeField]
	private Texture _artCloudCustomTexture; // 0x2D0
	[SerializeField]
	private float _cloudDensity; // 0x2D8
	[SerializeField]
	private float _cloudSpeed; // 0x2DC
	[SerializeField]
	private float _cloudDirection; // 0x2E0
	[SerializeField]
	private float _cloudHeight; // 0x2E4
	[SerializeField]
	private Color _cloudColor1; // 0x2E8
	[SerializeField]
	private Color _cloudColor2; // 0x2F8
	[SerializeField]
	private float _cloudFadePosition; // 0x308
	[SerializeField]
	private float _cloudFadeAmount; // 0x30C
	[SerializeField]
	private float _cloudAlpha; // 0x310
	[SerializeField]
	private Texture _cloudCubemap; // 0x318
	[SerializeField]
	private float _cloudCubemapRotationSpeed; // 0x320
	[SerializeField]
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x328
	[SerializeField]
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x330
	[SerializeField]
	private float _cloudCubemapDoubleLayerHeight; // 0x334
	[SerializeField]
	private Color _cloudCubemapDoubleLayerTintColor; // 0x338
	[SerializeField]
	private Color _cloudCubemapTintColor; // 0x348
	[SerializeField]
	private float _cloudCubemapHeight; // 0x358
	[SerializeField]
	private Texture _cloudCubemapNormalTexture; // 0x360
	[SerializeField]
	private Color _cloudCubemapNormalLitColor; // 0x368
	[SerializeField]
	private Color _cloudCubemapNormalShadowColor; // 0x378
	[SerializeField]
	private float _cloudCubemapNormalRotationSpeed; // 0x388
	[SerializeField]
	private float _cloudCubemapNormalHeight; // 0x38C
	[SerializeField]
	private float _cloudCubemapNormalAmbientItensity; // 0x390
	[SerializeField]
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x398
	[SerializeField]
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3A0
	[SerializeField]
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3A4
	[SerializeField]
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3A8
	[SerializeField]
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3B8
	[SerializeField]
	private Vector3 _cloudCubemapNormalLightDirection; // 0x3C8
	[SerializeField]
	private Color _fogColor; // 0x3D4
	[SerializeField]
	private float _fogDensity; // 0x3E4
	[SerializeField]
	private float _fogHeight; // 0x3E8

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public float MoonAlpha { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float SunAlpha { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float CloudSpeed { get; set; }
	public float CloudDirection { get; set; }
	public float CloudHeight { get; set; }
	public Color CloudColor1 { get; set; }
	public Color CloudColor2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float CloudAlpha { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Material get_SkyboxMaterial() { }

	// RVA: 0x9E3310 Offset: 0x9E1D10 VA: 0x1809E3310
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Color get_SkyColor() { }

	// RVA: 0x9E31D0 Offset: 0x9E1BD0 VA: 0x1809E31D0
	public void set_SkyColor(Color value) { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public Color get_SkyMiddleColor() { }

	// RVA: 0x9E3240 Offset: 0x9E1C40 VA: 0x1809E3240
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	public Color get_HorizonColor() { }

	// RVA: 0x9E2C00 Offset: 0x9E1600 VA: 0x1809E2C00
	public void set_HorizonColor(Color value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_GradientFadeBegin() { }

	// RVA: 0x9E2BE0 Offset: 0x9E15E0 VA: 0x1809E2BE0
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_GradientFadeLength() { }

	// RVA: 0x9E2BF0 Offset: 0x9E15F0 VA: 0x1809E2BF0
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x9E32B0 Offset: 0x9E1CB0 VA: 0x1809E32B0
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x9E1C70 Offset: 0x9E0670 VA: 0x1809E1C70
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_StarFadeBegin() { }

	// RVA: 0x9E3600 Offset: 0x9E2000 VA: 0x1809E3600
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float get_StarFadeLength() { }

	// RVA: 0x9E3610 Offset: 0x9E2010 VA: 0x1809E3610
	public void set_StarFadeLength(float value) { }

	// RVA: 0x4CD9E0 Offset: 0x4CC3E0 VA: 0x1804CD9E0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x9E2C70 Offset: 0x9E1670 VA: 0x1809E2C70
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x9E3340 Offset: 0x9E1D40 VA: 0x1809E3340
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x6A5230 Offset: 0x6A3C30 VA: 0x1806A5230
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x9E35A0 Offset: 0x9E1FA0 VA: 0x1809E35A0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x80E390 Offset: 0x80CD90 VA: 0x18080E390
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x9E3540 Offset: 0x9E1F40 VA: 0x1809E3540
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_StarBasicOpacity() { }

	// RVA: 0x9E3470 Offset: 0x9E1E70 VA: 0x1809E3470
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x9E1AD0 Offset: 0x9E04D0 VA: 0x1809E1AD0
	public Color get_StarBasicTintColor() { }

	// RVA: 0x9E34D0 Offset: 0x9E1ED0 VA: 0x1809E34D0
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x8D2000 Offset: 0x8D0A00 VA: 0x1808D2000
	public float get_StarBasicExponent() { }

	// RVA: 0x9E33B0 Offset: 0x9E1DB0 VA: 0x1809E33B0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x8B33F0 Offset: 0x8B1DF0 VA: 0x1808B33F0
	public float get_StarBasicIntensity() { }

	// RVA: 0x9E3410 Offset: 0x9E1E10 VA: 0x1809E3410
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x9E3940 Offset: 0x9E2340 VA: 0x1809E3940
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x9E36F0 Offset: 0x9E20F0 VA: 0x1809E36F0
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x9E1AE0 Offset: 0x9E04E0 VA: 0x1809E1AE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x9E3680 Offset: 0x9E2080 VA: 0x1809E3680
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x8D1FF0 Offset: 0x8D09F0 VA: 0x1808D1FF0
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x9E37C0 Offset: 0x9E21C0 VA: 0x1809E37C0
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x4E8C80 Offset: 0x4E7680 VA: 0x1804E8C80
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x9E39C0 Offset: 0x9E23C0 VA: 0x1809E39C0
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x526FD0 Offset: 0x5259D0 VA: 0x180526FD0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x9E3A20 Offset: 0x9E2420 VA: 0x1809E3A20
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x673C50 Offset: 0x672650 VA: 0x180673C50
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x9E3820 Offset: 0x9E2220 VA: 0x1809E3820
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x9E3760 Offset: 0x9E2160 VA: 0x1809E3760
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x510B20 Offset: 0x50F520 VA: 0x180510B20
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x9E3620 Offset: 0x9E2020 VA: 0x1809E3620
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x9E1040 Offset: 0x9DFA40 VA: 0x1809E1040
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x9E0F30 Offset: 0x9DF930 VA: 0x1809E0F30
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x51E8D0 Offset: 0x51D2D0 VA: 0x18051E8D0
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x9E38E0 Offset: 0x9E22E0 VA: 0x1809E38E0
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x51D960 Offset: 0x51C360 VA: 0x18051D960
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x9E3880 Offset: 0x9E2280 VA: 0x1809E3880
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x9E3DA0 Offset: 0x9E27A0 VA: 0x1809E3DA0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x9E3B50 Offset: 0x9E2550 VA: 0x1809E3B50
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x9E1AF0 Offset: 0x9E04F0 VA: 0x1809E1AF0
	public Color get_StarLayer2Color() { }

	// RVA: 0x9E3AE0 Offset: 0x9E24E0 VA: 0x1809E3AE0
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x513110 Offset: 0x511B10 VA: 0x180513110
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x9E3C20 Offset: 0x9E2620 VA: 0x1809E3C20
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x513360 Offset: 0x511D60 VA: 0x180513360
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x9E3E20 Offset: 0x9E2820 VA: 0x1809E3E20
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x5933D0 Offset: 0x591DD0 VA: 0x1805933D0
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x9E3E80 Offset: 0x9E2880 VA: 0x1809E3E80
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x5933C0 Offset: 0x591DC0 VA: 0x1805933C0
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x9E3C80 Offset: 0x9E2680 VA: 0x1809E3C80
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x5AB790 Offset: 0x5AA190 VA: 0x1805AB790
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x9E3BC0 Offset: 0x9E25C0 VA: 0x1809E3BC0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x512AC0 Offset: 0x5114C0 VA: 0x180512AC0
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x9E3A80 Offset: 0x9E2480 VA: 0x1809E3A80
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x9E10D0 Offset: 0x9DFAD0 VA: 0x1809E10D0
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x9E0F50 Offset: 0x9DF950 VA: 0x1809E0F50
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x9E3D40 Offset: 0x9E2740 VA: 0x1809E3D40
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x512BF0 Offset: 0x5115F0 VA: 0x180512BF0
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x9E3CE0 Offset: 0x9E26E0 VA: 0x1809E3CE0
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x9E4200 Offset: 0x9E2C00 VA: 0x1809E4200
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x9E3FB0 Offset: 0x9E29B0 VA: 0x1809E3FB0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x9E1B00 Offset: 0x9E0500 VA: 0x1809E1B00
	public Color get_StarLayer3Color() { }

	// RVA: 0x9E3F40 Offset: 0x9E2940 VA: 0x1809E3F40
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x8D1F50 Offset: 0x8D0950 VA: 0x1808D1F50
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x9E4080 Offset: 0x9E2A80 VA: 0x1809E4080
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x8D1F40 Offset: 0x8D0940 VA: 0x1808D1F40
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x9E4280 Offset: 0x9E2C80 VA: 0x1809E4280
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x9E1B20 Offset: 0x9E0520 VA: 0x1809E1B20
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x9E42E0 Offset: 0x9E2CE0 VA: 0x1809E42E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x653860 Offset: 0x652260 VA: 0x180653860
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x9E40E0 Offset: 0x9E2AE0 VA: 0x1809E40E0
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x6F64F0 Offset: 0x6F4EF0 VA: 0x1806F64F0
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x9E4020 Offset: 0x9E2A20 VA: 0x1809E4020
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x796420 Offset: 0x794E20 VA: 0x180796420
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x9E3EE0 Offset: 0x9E28E0 VA: 0x1809E3EE0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x9E1160 Offset: 0x9DFB60 VA: 0x1809E1160
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x9E0F70 Offset: 0x9DF970 VA: 0x1809E0F70
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x9E1B10 Offset: 0x9E0510 VA: 0x1809E1B10
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x9E41A0 Offset: 0x9E2BA0 VA: 0x1809E41A0
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x726280 Offset: 0x724C80 VA: 0x180726280
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x9E4140 Offset: 0x9E2B40 VA: 0x1809E4140
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Texture get_MoonTexture() { }

	// RVA: 0x9E30A0 Offset: 0x9E1AA0 VA: 0x1809E30A0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x8D1F80 Offset: 0x8D0980 VA: 0x1808D1F80
	public float get_MoonRotationSpeed() { }

	// RVA: 0x9E2F20 Offset: 0x9E1920 VA: 0x1809E2F20
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x9E1A30 Offset: 0x9E0430 VA: 0x1809E1A30
	public Color get_MoonColor() { }

	// RVA: 0x9E2D90 Offset: 0x9E1790 VA: 0x1809E2D90
	public void set_MoonColor(Color value) { }

	// RVA: 0x9E1A40 Offset: 0x9E0440 VA: 0x1809E1A40
	public Vector3 get_MoonDirection() { }

	// RVA: 0x9E2E00 Offset: 0x9E1800 VA: 0x1809E2E00
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x9E1AA0 Offset: 0x9E04A0 VA: 0x1809E1AA0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x9E3120 Offset: 0x9E1B20 VA: 0x1809E3120
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x9E1A70 Offset: 0x9E0470 VA: 0x1809E1A70
	public float get_MoonSize() { }

	// RVA: 0x9E2F80 Offset: 0x9E1980 VA: 0x1809E2F80
	public void set_MoonSize(float value) { }

	// RVA: 0x9E1A60 Offset: 0x9E0460 VA: 0x1809E1A60
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x9E2EC0 Offset: 0x9E18C0 VA: 0x1809E2EC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x9E1A20 Offset: 0x9E0420 VA: 0x1809E1A20
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x9E2D30 Offset: 0x9E1730 VA: 0x1809E2D30
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x9E0FB0 Offset: 0x9DF9B0 VA: 0x1809E0FB0
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x9E0F10 Offset: 0x9DF910 VA: 0x1809E0F10
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x9E1A90 Offset: 0x9E0490 VA: 0x1809E1A90
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x9E3040 Offset: 0x9E1A40 VA: 0x1809E3040
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x9E1A80 Offset: 0x9E0480 VA: 0x1809E1A80
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x9E2FE0 Offset: 0x9E19E0 VA: 0x1809E2FE0
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x9E1A10 Offset: 0x9E0410 VA: 0x1809E1A10
	public float get_MoonAlpha() { }

	// RVA: 0x9E2CD0 Offset: 0x9E16D0 VA: 0x1809E2CD0
	public void set_MoonAlpha(float value) { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public Texture get_SunTexture() { }

	// RVA: 0x9E4710 Offset: 0x9E3110 VA: 0x1809E4710
	public void set_SunTexture(Texture value) { }

	// RVA: 0x9E1B50 Offset: 0x9E0550 VA: 0x1809E1B50
	public Color get_SunColor() { }

	// RVA: 0x9E4400 Offset: 0x9E2E00 VA: 0x1809E4400
	public void set_SunColor(Color value) { }

	// RVA: 0x641250 Offset: 0x63FC50 VA: 0x180641250
	public float get_SunRotationSpeed() { }

	// RVA: 0x9E4590 Offset: 0x9E2F90 VA: 0x1809E4590
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x9E1B60 Offset: 0x9E0560 VA: 0x1809E1B60
	public Vector3 get_SunDirection() { }

	// RVA: 0x9E4470 Offset: 0x9E2E70 VA: 0x1809E4470
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x9E1BC0 Offset: 0x9E05C0 VA: 0x1809E1BC0
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x9E4790 Offset: 0x9E3190 VA: 0x1809E4790
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x9E1B90 Offset: 0x9E0590 VA: 0x1809E1B90
	public float get_SunSize() { }

	// RVA: 0x9E45F0 Offset: 0x9E2FF0 VA: 0x1809E45F0
	public void set_SunSize(float value) { }

	// RVA: 0x9E1B80 Offset: 0x9E0580 VA: 0x1809E1B80
	public float get_SunEdgeFeathering() { }

	// RVA: 0x9E4530 Offset: 0x9E2F30 VA: 0x1809E4530
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x9E1B40 Offset: 0x9E0540 VA: 0x1809E1B40
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x9E43A0 Offset: 0x9E2DA0 VA: 0x1809E43A0
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x9E11F0 Offset: 0x9DFBF0 VA: 0x1809E11F0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x9E0F90 Offset: 0x9DF990 VA: 0x1809E0F90
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x9E1BB0 Offset: 0x9E05B0 VA: 0x1809E1BB0
	public int get_SunSpriteItemCount() { }

	// RVA: 0x9E46B0 Offset: 0x9E30B0 VA: 0x1809E46B0
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x9E1BA0 Offset: 0x9E05A0 VA: 0x1809E1BA0
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x9E4650 Offset: 0x9E3050 VA: 0x1809E4650
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x9E1B30 Offset: 0x9E0530 VA: 0x1809E1B30
	public float get_SunAlpha() { }

	// RVA: 0x9E4340 Offset: 0x9E2D40 VA: 0x1809E4340
	public void set_SunAlpha(float value) { }

	// RVA: 0x9E17B0 Offset: 0x9E01B0 VA: 0x1809E17B0
	public float get_CloudBegin() { }

	// RVA: 0x9E1D40 Offset: 0x9E0740 VA: 0x1809E1D40
	public void set_CloudBegin(float value) { }

	// RVA: 0x9E1950 Offset: 0x9E0350 VA: 0x1809E1950
	public float get_CloudTextureTiling() { }

	// RVA: 0x9E29D0 Offset: 0x9E13D0 VA: 0x1809E29D0
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x9E17E0 Offset: 0x9E01E0 VA: 0x1809E17E0
	public Color get_CloudColor() { }

	// RVA: 0x9E1E80 Offset: 0x9E0880 VA: 0x1809E1E80
	public void set_CloudColor(Color value) { }

	// RVA: 0x9E1960 Offset: 0x9E0360 VA: 0x1809E1960
	public Texture get_CloudTexture() { }

	// RVA: 0x9E2A30 Offset: 0x9E1430 VA: 0x1809E2A30
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x9E1730 Offset: 0x9E0130 VA: 0x1809E1730
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x9E1BF0 Offset: 0x9E05F0 VA: 0x1809E1BF0
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x9E18F0 Offset: 0x9E02F0 VA: 0x1809E18F0
	public float get_CloudDensity() { }

	// RVA: 0x9E2790 Offset: 0x9E1190 VA: 0x1809E2790
	public void set_CloudDensity(float value) { }

	// RVA: 0x9E1940 Offset: 0x9E0340 VA: 0x1809E1940
	public float get_CloudSpeed() { }

	// RVA: 0x9E2970 Offset: 0x9E1370 VA: 0x1809E2970
	public void set_CloudSpeed(float value) { }

	// RVA: 0x9E1900 Offset: 0x9E0300 VA: 0x1809E1900
	public float get_CloudDirection() { }

	// RVA: 0x9E27F0 Offset: 0x9E11F0 VA: 0x1809E27F0
	public void set_CloudDirection(float value) { }

	// RVA: 0x9E1930 Offset: 0x9E0330 VA: 0x1809E1930
	public float get_CloudHeight() { }

	// RVA: 0x9E2910 Offset: 0x9E1310 VA: 0x1809E2910
	public void set_CloudHeight(float value) { }

	// RVA: 0x9E17C0 Offset: 0x9E01C0 VA: 0x1809E17C0
	public Color get_CloudColor1() { }

	// RVA: 0x9E1DA0 Offset: 0x9E07A0 VA: 0x1809E1DA0
	public void set_CloudColor1(Color value) { }

	// RVA: 0x9E17D0 Offset: 0x9E01D0 VA: 0x1809E17D0
	public Color get_CloudColor2() { }

	// RVA: 0x9E1E10 Offset: 0x9E0810 VA: 0x1809E1E10
	public void set_CloudColor2(Color value) { }

	// RVA: 0x9E1920 Offset: 0x9E0320 VA: 0x1809E1920
	public float get_CloudFadePosition() { }

	// RVA: 0x9E28B0 Offset: 0x9E12B0 VA: 0x1809E28B0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x9E1910 Offset: 0x9E0310 VA: 0x1809E1910
	public float get_CloudFadeAmount() { }

	// RVA: 0x9E2850 Offset: 0x9E1250 VA: 0x1809E2850
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x6DFA40 Offset: 0x6DE440 VA: 0x1806DFA40
	public float get_CloudAlpha() { }

	// RVA: 0x9E1CE0 Offset: 0x9E06E0 VA: 0x1809E1CE0
	public void set_CloudAlpha(float value) { }

	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30
	public Texture get_CloudCubemap() { }

	// RVA: 0x9E2710 Offset: 0x9E1110 VA: 0x1809E2710
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x9E18D0 Offset: 0x9E02D0 VA: 0x1809E18D0
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x9E2640 Offset: 0x9E1040 VA: 0x1809E2640
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x9E17F0 Offset: 0x9E01F0 VA: 0x1809E17F0
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x9E1EF0 Offset: 0x9E08F0 VA: 0x1809E1EF0
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x9E1810 Offset: 0x9E0210 VA: 0x1809E1810
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x9E1FD0 Offset: 0x9E09D0 VA: 0x1809E1FD0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x9E1800 Offset: 0x9E0200 VA: 0x1809E1800
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x9E1F70 Offset: 0x9E0970 VA: 0x1809E1F70
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x9E1820 Offset: 0x9E0220 VA: 0x1809E1820
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x9E2030 Offset: 0x9E0A30 VA: 0x1809E2030
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x9E18E0 Offset: 0x9E02E0 VA: 0x1809E18E0
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x9E26A0 Offset: 0x9E10A0 VA: 0x1809E26A0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x6E61E0 Offset: 0x6E4BE0 VA: 0x1806E61E0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x9E20A0 Offset: 0x9E0AA0 VA: 0x1809E20A0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x6DFA30 Offset: 0x6DE430 VA: 0x1806DFA30
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x9E25C0 Offset: 0x9E0FC0 VA: 0x1809E25C0
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x9E18A0 Offset: 0x9E02A0 VA: 0x1809E18A0
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x9E2480 Offset: 0x9E0E80 VA: 0x1809E2480
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x9E18C0 Offset: 0x9E02C0 VA: 0x1809E18C0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x9E2550 Offset: 0x9E0F50 VA: 0x1809E2550
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x9E18B0 Offset: 0x9E02B0 VA: 0x1809E18B0
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x9E24F0 Offset: 0x9E0EF0 VA: 0x1809E24F0
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x9E1870 Offset: 0x9E0270 VA: 0x1809E1870
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x9E2380 Offset: 0x9E0D80 VA: 0x1809E2380
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x9E1830 Offset: 0x9E0230 VA: 0x1809E1830
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x9E2100 Offset: 0x9E0B00 VA: 0x1809E2100
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x67A280 Offset: 0x678C80 VA: 0x18067A280
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x9E2160 Offset: 0x9E0B60 VA: 0x1809E2160
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x9E1850 Offset: 0x9E0250 VA: 0x1809E1850
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x9E22B0 Offset: 0x9E0CB0 VA: 0x1809E22B0
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x9E1800 Offset: 0x9E0200 VA: 0x1809E1800
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x9E21E0 Offset: 0x9E0BE0 VA: 0x1809E21E0
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x9E1840 Offset: 0x9E0240 VA: 0x1809E1840
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x9E2240 Offset: 0x9E0C40 VA: 0x1809E2240
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x9E1860 Offset: 0x9E0260 VA: 0x1809E1860
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x9E2310 Offset: 0x9E0D10 VA: 0x1809E2310
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x9E1880 Offset: 0x9E0280 VA: 0x1809E1880
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x9E23E0 Offset: 0x9E0DE0 VA: 0x1809E23E0
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x9E19E0 Offset: 0x9E03E0 VA: 0x1809E19E0
	public Color get_FogColor() { }

	// RVA: 0x9E2AB0 Offset: 0x9E14B0 VA: 0x1809E2AB0
	public void set_FogColor(Color value) { }

	// RVA: 0x9E19F0 Offset: 0x9E03F0 VA: 0x1809E19F0
	public float get_FogDensity() { }

	// RVA: 0x9E2B20 Offset: 0x9E1520 VA: 0x1809E2B20
	public void set_FogDensity(float value) { }

	// RVA: 0x9E1A00 Offset: 0x9E0400 VA: 0x1809E1A00
	public float get_FogHeight() { }

	// RVA: 0x9E2B80 Offset: 0x9E1580 VA: 0x1809E2B80
	public void set_FogHeight(float value) { }

	// RVA: 0x9E0DB0 Offset: 0x9DF7B0 VA: 0x1809E0DB0
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x9E0E60 Offset: 0x9DF860 VA: 0x1809E0E60
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x9E1280 Offset: 0x9DFC80 VA: 0x1809E1280
	public void .ctor() { }
}
