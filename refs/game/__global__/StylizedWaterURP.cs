public class StylizedWaterURP : MonoBehaviour // TypeDefIndex: 18816
{
	// Fields
	public bool refractionExpanded; // 0x20
	public bool vertexPaintingExpanded; // 0x21
	public bool surfaceFoamExpanded; // 0x22
	public bool foamShadowsExpanded; // 0x23
	public bool intersectionEffectsExpanded; // 0x24
	public bool planarReflectionsExpanded; // 0x25
	private const string shaderName = "Stylized Water";
	private const string mobileShaderName = "Stylized Water Mobile";
	private const string underwaterShaderName = "Stylized Water Underwater";
	[Range(0, 1)]
	public float reflectionStrength; // 0x28
	[Range(0, 7)]
	public float reflectionFresnel; // 0x2C
	public bool useColorGradient; // 0x30
	[GradientUsage(True)]
	public Gradient colorGradient; // 0x38
	public Texture2D colorGradientTexture; // 0x40
	[ColorUsage(True, True)]
	public Color shallowColor; // 0x48
	[ColorUsage(True, True)]
	public Color deepColor; // 0x58
	[Range(0, 4)]
	public float colorDepth; // 0x68
	[ColorUsage(True, True)]
	public Color horizonColor; // 0x6C
	[Range(0, 20)]
	public float horizonDistance; // 0x7C
	[Range(0, 1)]
	public float shoreFade; // 0x80
	[ColorUsage(False, False)]
	public Color shoreColor; // 0x84
	[Range(0, 1)]
	public float shoreStrength; // 0x94
	[Range(0, 1)]
	public float shoreBlend; // 0x98
	[Range(0, 3)]
	public float shoreDepth; // 0x9C
	[ColorUsage(False, False)]
	public Color waveColor; // 0xA0
	[ColorUsage(False, False)]
	public Color underwaterColor; // 0xB0
	[Range(0, 1)]
	public float underwaterColorStrength; // 0xC0
	[Range(0, 0.3)]
	public float underwaterRefractionStrength; // 0xC4
	public Texture surfaceFoamTexture; // 0xC8
	public Vector2 surfaceFoamSampling; // 0xD0
	[Range(0, 1)]
	public float surfaceFoamCutoff; // 0xD8
	[Range(0, 3)]
	public float surfaceFoamDistortion; // 0xDC
	[Range(0, 1)]
	public float surfaceFoamBlend; // 0xE0
	[ColorUsage(True, False)]
	public Color surfaceFoamColor1; // 0xE4
	[ColorUsage(True, False)]
	public Color surfaceFoamColor2; // 0xF4
	public Vector4 surfaceFoamMovement; // 0x104
	[Range(0, 1)]
	public float surfaceFoamDirection1; // 0x114
	[Range(0, 1)]
	public float surfaceFoamDirection2; // 0x118
	[Range(0, 2)]
	public float surfaceFoamSpeed1; // 0x11C
	[Range(0, 2)]
	public float surfaceFoamSpeed2; // 0x120
	public Vector4 surfaceFoamTilingAndOffset; // 0x124
	[Range(0, 1)]
	public float surfaceFoamOffsetX; // 0x134
	[Range(0, 1)]
	public float surfaceFoamOffsetY; // 0x138
	[Range(0, 2)]
	public float surfaceFoamScale1; // 0x13C
	[Range(0, 2)]
	public float surfaceFoamScale2; // 0x140
	public bool enableSurfaceFoam; // 0x144
	[Range(0, 1)]
	public float surfaceFoamHeightMask; // 0x148
	[Range(0, 1)]
	public float surfaceFoamHeightMaskSmoothness; // 0x14C
	public bool enableHeightMask; // 0x150
	[Range(0, 1)]
	public float foamShadowStrength; // 0x154
	[Range(0, 10)]
	public float foamShadowDepth; // 0x158
	[Range(0, 15)]
	public float surfaceFoamShadowProjection; // 0x15C
	[Range(0, 15)]
	public float intersectionFoamShadowProjection; // 0x160
	public StylizedWaterURP.FoamMovement foamMovement; // 0x164
	[Range(0, 3)]
	public float intersectionFoamDepth; // 0x168
	public Texture intersectionFoamTexture; // 0x170
	[ColorUsage(True, False)]
	public Color intersectionFoamColor; // 0x178
	public Vector2 intersectionFoamMovement; // 0x188
	[Range(0, 1)]
	public float intersectionFoamDirection; // 0x190
	[Range(0, 2)]
	public float intersectionFoamSpeed; // 0x194
	[Range(0, 2)]
	public float intersectionFoamScale; // 0x198
	public Vector2 intersectionFoamSampling; // 0x19C
	[Range(0, 1)]
	public float intersectionFoamCutoff; // 0x1A4
	[Range(0, 3)]
	public float intersectionFoamDistortion; // 0x1A8
	public bool enableIntersectionEffects; // 0x1AC
	[Range(0, 1)]
	public float intersectionFoamBlend; // 0x1B0
	[Range(0, 1)]
	public float intersectionWaterBlend; // 0x1B4
	[Range(-5, 5)]
	public float shoreFoamSpeed; // 0x1B8
	[Range(0, 2)]
	public float shoreFoamWidth; // 0x1BC
	[Range(0, 40)]
	public float shoreFoamFrequency; // 0x1C0
	[Range(0, 5)]
	public float shoreFoamBreakupStrength; // 0x1C4
	[Range(0, 50)]
	public float shoreFoamBreakupScale; // 0x1C8
	public StylizedWaterURP.Lighting lighting; // 0x1CC
	[Range(0, 1)]
	public float lightingSmoothness; // 0x1D0
	[ColorUsage(False, True)]
	public Color lightingSpecularColor; // 0x1D4
	[ColorUsage(False, True)]
	public Color lightingDiffuseColor; // 0x1E4
	[Range(0, 1)]
	public float lightingHardness; // 0x1F4
	public Texture normalsTexture; // 0x1F8
	public Vector2 normalsMovement; // 0x200
	[Range(0, 1)]
	public float normalsStrength; // 0x208
	[Range(0.01, 2)]
	public float normalsScale; // 0x20C
	[Range(0, 0.3)]
	public float normalsSpeed; // 0x210
	[Range(0, 0.3)]
	public float refractionStrength; // 0x214
	public Vector3 waveVisuals; // 0x218
	[Range(0, 0.5)]
	public float waveSteepness; // 0x224
	[Range(0, 20)]
	public float waveLength; // 0x228
	[Range(0, 3)]
	public float waveSpeed; // 0x22C
	public Vector4 waveDirections; // 0x230
	[Range(0, 1)]
	public float waveDirection1; // 0x240
	[Range(0, 1)]
	public float waveDirection2; // 0x244
	[Range(0, 1)]
	public float waveDirection3; // 0x248
	[Range(0, 1)]
	public float waveDirection4; // 0x24C
	public StylizedWaterURP.WaterUVs waterUVs; // 0x250
	public bool hideComponents; // 0x254
	public bool enableFoamShadows; // 0x255
	public bool enableRefraction; // 0x256
	public MeshRenderer meshRenderer; // 0x258
	public MeshFilter meshFilter; // 0x260
	public Material material; // 0x268

	// Methods

	// RVA: 0x1F76CF0 Offset: 0x1F756F0 VA: 0x181F76CF0
	private void OnEnable() { }

	// RVA: 0x1F781E0 Offset: 0x1F76BE0 VA: 0x181F781E0
	private void Reset() { }

	// RVA: 0x1F780A0 Offset: 0x1F76AA0 VA: 0x181F780A0
	private void ResetHideFlags() { }

	// RVA: 0x1F76CE0 Offset: 0x1F756E0 VA: 0x181F76CE0
	private void OnDisable() { }

	// RVA: 0x1F76CE0 Offset: 0x1F756E0 VA: 0x181F76CE0
	private void OnDestroy() { }

	// RVA: 0x1F781F0 Offset: 0x1F76BF0 VA: 0x181F781F0
	private void SafeDestroyObject(Object obj) { }

	// RVA: 0x1F76F90 Offset: 0x1F75990 VA: 0x181F76F90
	public void ReadMaterialProperties() { }

	// RVA: 0x1F78290 Offset: 0x1F76C90 VA: 0x181F78290
	public void WriteMaterialProperties() { }

	// RVA: 0x1F76CD0 Offset: 0x1F756D0 VA: 0x181F76CD0
	public float GetWaveSteepness() { }

	// RVA: 0x1F76CB0 Offset: 0x1F756B0 VA: 0x181F76CB0
	public float GetWaveLength() { }

	// RVA: 0x1F76CC0 Offset: 0x1F756C0 VA: 0x181F76CC0
	public float GetWaveSpeed() { }

	// RVA: 0x1F76C10 Offset: 0x1F75610 VA: 0x181F76C10
	public float[] GetWaveDirections() { }

	// RVA: 0x1F793D0 Offset: 0x1F77DD0 VA: 0x181F793D0
	public void .ctor() { }
}
