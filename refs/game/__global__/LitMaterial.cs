public class LitMaterial : BaseMaterial // TypeDefIndex: 18892
{
	// Properties
	[ShaderProperty("_AlphaTest")]
	public bool AlphaTest { get; set; }
	[ShaderProperty("_AlphaTestThreshold")]
	public float AlphaTestThreshold { get; set; }
	[ShaderProperty("_AlphaToMask")]
	public bool AlphaToMask { get; set; }
	[ShaderProperty("_DoubleSidedMode")]
	public bool DoubleSided { get; set; }
	[ShaderProperty("_DoubleSidedNormalMode")]
	public LitMaterial.DoubleSidedNormals DoubleSidedNormalMode { get; set; }
	[ShaderProperty("_Tint")]
	public Color Tint { get; set; }
	[ShaderProperty("_Albedo")]
	public Texture AlbedoMap { get; set; }
	[ShaderProperty("_NormalMap")]
	public Texture NormalMap { get; set; }
	[ShaderProperty("_NormalMapScale")]
	public float NormalMapScale { get; set; }
	[ShaderProperty("_SurfaceMapMethod")]
	public LitMaterial.SurfaceMapMethod SurfaceMap { get; set; }
	[ShaderProperty("_PackedMap")]
	public Texture PackedMap { get; set; }
	[ShaderProperty("_MetallicGlossMap")]
	public Texture MetallicGlossMap { get; set; }
	[ShaderProperty("_OcclusionMap")]
	public Texture OcclusionMap { get; set; }
	[ShaderProperty("_GlossRemap")]
	public Vector2 GlossRemap { get; set; }
	[ShaderProperty("_OcclusionRemap")]
	public Vector2 OcclusionRemap { get; set; }
	[ShaderProperty("_Glossiness")]
	public float Glossiness { get; set; }
	[ShaderProperty("_Metallic")]
	public float Metallic { get; set; }
	[ShaderProperty("_EmissionColor")]
	public Color EmissionColor { get; set; }
	[ShaderProperty("_EmissionMap")]
	public Texture EmissionMap { get; set; }
	[ShaderProperty("_EmissionIntensity")]
	public float EmissionIntensity { get; set; }
	[ShaderProperty("_EmissionExposureWeight")]
	public float EmissionExposureWeight { get; set; }
	[ShaderProperty("_EmissionAffectedByAlbedo")]
	public bool EmissionAffectedByAlbedo { get; set; }
	[ShaderProperty("_Translucency")]
	public bool Translucency { get; set; }
	[ShaderProperty("_DiffusionProfileAsset")]
	public string DiffusionProfile { get; set; }
	[ShaderProperty("_DiffusionProfileHash")]
	public uint DiffusionProfileHash { get; set; }
	[ShaderProperty("_SpecularHighlights")]
	public bool SpecularHighlights { get; set; }
	[ShaderProperty("_MotionVectors")]
	public bool MotionVectors { get; set; }
	[ShaderProperty("_Decals")]
	public bool Decals { get; set; }
	[ShaderProperty("_TemporalAntiAliasing")]
	public bool TemporalAntiAliasing { get; set; }

	// Methods

	// RVA: 0xC85EC0 Offset: 0xC848C0 VA: 0x180C85EC0
	public static Material op_Implicit(LitMaterial material) { }

	// RVA: 0x2F6E670 Offset: 0x2F6D070 VA: 0x182F6E670
	public static LitMaterial op_Implicit(Material material) { }

	// RVA: 0x2F6D640 Offset: 0x2F6C040 VA: 0x182F6D640
	public bool get_AlphaTest() { }

	// RVA: 0x2F6E8E0 Offset: 0x2F6D2E0 VA: 0x182F6E8E0
	public void set_AlphaTest(bool value) { }

	// RVA: 0x2F6D5C0 Offset: 0x2F6BFC0 VA: 0x182F6D5C0
	public float get_AlphaTestThreshold() { }

	// RVA: 0x2F6E830 Offset: 0x2F6D230 VA: 0x182F6E830
	public void set_AlphaTestThreshold(float value) { }

	// RVA: 0x2F6D6D0 Offset: 0x2F6C0D0 VA: 0x182F6D6D0
	public bool get_AlphaToMask() { }

	// RVA: 0x2F6E9A0 Offset: 0x2F6D3A0 VA: 0x182F6E9A0
	public void set_AlphaToMask(bool value) { }

	// RVA: 0x2F6DAE0 Offset: 0x2F6C4E0 VA: 0x182F6DAE0
	public bool get_DoubleSided() { }

	// RVA: 0x2F6EE50 Offset: 0x2F6D850 VA: 0x182F6EE50
	public void set_DoubleSided(bool value) { }

	// RVA: 0x2F6DA50 Offset: 0x2F6C450 VA: 0x182F6DA50
	public LitMaterial.DoubleSidedNormals get_DoubleSidedNormalMode() { }

	// RVA: 0x2F6EDA0 Offset: 0x2F6D7A0 VA: 0x182F6EDA0
	public void set_DoubleSidedNormalMode(LitMaterial.DoubleSidedNormals value) { }

	// RVA: 0x2F6E550 Offset: 0x2F6CF50 VA: 0x182F6E550
	public Color get_Tint() { }

	// RVA: 0x2F6FA10 Offset: 0x2F6E410 VA: 0x182F6FA10
	public void set_Tint(Color value) { }

	// RVA: 0x2F6D490 Offset: 0x2F6BE90 VA: 0x182F6D490
	public Texture get_AlbedoMap() { }

	// RVA: 0x2F6E730 Offset: 0x2F6D130 VA: 0x182F6E730
	public void set_AlbedoMap(Texture value) { }

	// RVA: 0x2F6E160 Offset: 0x2F6CB60 VA: 0x182F6E160
	public Texture get_NormalMap() { }

	// RVA: 0x2F6F5B0 Offset: 0x2F6DFB0 VA: 0x182F6F5B0
	public void set_NormalMap(Texture value) { }

	// RVA: 0x2F6E0E0 Offset: 0x2F6CAE0 VA: 0x182F6E0E0
	public float get_NormalMapScale() { }

	// RVA: 0x2F6F500 Offset: 0x2F6DF00 VA: 0x182F6F500
	public void set_NormalMapScale(float value) { }

	// RVA: 0x2F6E430 Offset: 0x2F6CE30 VA: 0x182F6E430
	public LitMaterial.SurfaceMapMethod get_SurfaceMap() { }

	// RVA: 0x2F6F8A0 Offset: 0x2F6E2A0 VA: 0x182F6F8A0
	public void set_SurfaceMap(LitMaterial.SurfaceMapMethod value) { }

	// RVA: 0x2F6E320 Offset: 0x2F6CD20 VA: 0x182F6E320
	public Texture get_PackedMap() { }

	// RVA: 0x2F6F700 Offset: 0x2F6E100 VA: 0x182F6F700
	public void set_PackedMap(Texture value) { }

	// RVA: 0x2F6DF50 Offset: 0x2F6C950 VA: 0x182F6DF50
	public Texture get_MetallicGlossMap() { }

	// RVA: 0x2F6F330 Offset: 0x2F6DD30 VA: 0x182F6F330
	public void set_MetallicGlossMap(Texture value) { }

	// RVA: 0x2F6E1E0 Offset: 0x2F6CBE0 VA: 0x182F6E1E0
	public Texture get_OcclusionMap() { }

	// RVA: 0x2F6F610 Offset: 0x2F6E010 VA: 0x182F6F610
	public void set_OcclusionMap(Texture value) { }

	// RVA: 0x2F6DE10 Offset: 0x2F6C810 VA: 0x182F6DE10
	public Vector2 get_GlossRemap() { }

	// RVA: 0x2F6F1F0 Offset: 0x2F6DBF0 VA: 0x182F6F1F0
	public void set_GlossRemap(Vector2 value) { }

	// RVA: 0x2F6E260 Offset: 0x2F6CC60 VA: 0x182F6E260
	public Vector2 get_OcclusionRemap() { }

	// RVA: 0x2F6F670 Offset: 0x2F6E070 VA: 0x182F6F670
	public void set_OcclusionRemap(Vector2 value) { }

	// RVA: 0x2F6DED0 Offset: 0x2F6C8D0 VA: 0x182F6DED0
	public float get_Glossiness() { }

	// RVA: 0x2F6F280 Offset: 0x2F6DC80 VA: 0x182F6F280
	public void set_Glossiness(float value) { }

	// RVA: 0x2F6DFD0 Offset: 0x2F6C9D0 VA: 0x182F6DFD0
	public float get_Metallic() { }

	// RVA: 0x2F6F390 Offset: 0x2F6DD90 VA: 0x182F6F390
	public void set_Metallic(float value) { }

	// RVA: 0x2F6DC00 Offset: 0x2F6C600 VA: 0x182F6DC00
	public Color get_EmissionColor() { }

	// RVA: 0x2F6EFD0 Offset: 0x2F6D9D0 VA: 0x182F6EFD0
	public void set_EmissionColor(Color value) { }

	// RVA: 0x2F6DD90 Offset: 0x2F6C790 VA: 0x182F6DD90
	public Texture get_EmissionMap() { }

	// RVA: 0x2F6F190 Offset: 0x2F6DB90 VA: 0x182F6F190
	public void set_EmissionMap(Texture value) { }

	// RVA: 0x2F6DD10 Offset: 0x2F6C710 VA: 0x182F6DD10
	public float get_EmissionIntensity() { }

	// RVA: 0x2F6F0E0 Offset: 0x2F6DAE0 VA: 0x182F6F0E0
	public void set_EmissionIntensity(float value) { }

	// RVA: 0x2F6DC90 Offset: 0x2F6C690 VA: 0x182F6DC90
	public float get_EmissionExposureWeight() { }

	// RVA: 0x2F6F030 Offset: 0x2F6DA30 VA: 0x182F6F030
	public void set_EmissionExposureWeight(float value) { }

	// RVA: 0x2F6DB70 Offset: 0x2F6C570 VA: 0x182F6DB70
	public bool get_EmissionAffectedByAlbedo() { }

	// RVA: 0x2F6EF10 Offset: 0x2F6D910 VA: 0x182F6EF10
	public void set_EmissionAffectedByAlbedo(bool value) { }

	// RVA: 0x2F6E5E0 Offset: 0x2F6CFE0 VA: 0x182F6E5E0
	public bool get_Translucency() { }

	// RVA: 0x2F6FA70 Offset: 0x2F6E470 VA: 0x182F6FA70
	public void set_Translucency(bool value) { }

	// RVA: 0x2F6D880 Offset: 0x2F6C280 VA: 0x182F6D880
	public string get_DiffusionProfile() { }

	// RVA: 0x2F6EBD0 Offset: 0x2F6D5D0 VA: 0x182F6EBD0
	public void set_DiffusionProfile(string value) { }

	// RVA: 0x2F6D7F0 Offset: 0x2F6C1F0 VA: 0x182F6D7F0
	public uint get_DiffusionProfileHash() { }

	// RVA: 0x2F6EB20 Offset: 0x2F6D520 VA: 0x182F6EB20
	public void set_DiffusionProfileHash(uint value) { }

	// RVA: 0x2F6E3A0 Offset: 0x2F6CDA0 VA: 0x182F6E3A0
	public bool get_SpecularHighlights() { }

	// RVA: 0x2F6F7E0 Offset: 0x2F6E1E0 VA: 0x182F6F7E0
	public void set_SpecularHighlights(bool value) { }

	// RVA: 0x2F6E050 Offset: 0x2F6CA50 VA: 0x182F6E050
	public bool get_MotionVectors() { }

	// RVA: 0x2F6F440 Offset: 0x2F6DE40 VA: 0x182F6F440
	public void set_MotionVectors(bool value) { }

	// RVA: 0x2F6D760 Offset: 0x2F6C160 VA: 0x182F6D760
	public bool get_Decals() { }

	// RVA: 0x2F6EA60 Offset: 0x2F6D460 VA: 0x182F6EA60
	public void set_Decals(bool value) { }

	// RVA: 0x2F6E4C0 Offset: 0x2F6CEC0 VA: 0x182F6E4C0
	public bool get_TemporalAntiAliasing() { }

	// RVA: 0x2F6F950 Offset: 0x2F6E350 VA: 0x182F6F950
	public void set_TemporalAntiAliasing(bool value) { }

	// RVA: 0x2F6BBD0 Offset: 0x2F6A5D0 VA: 0x182F6BBD0
	public void .ctor(Material material) { }

	// RVA: 0x2F6CE90 Offset: 0x2F6B890 VA: 0x182F6CE90 Slot: 4
	public override void Validate(bool clean) { }

	// RVA: 0x2F6BCF0 Offset: 0x2F6A6F0 VA: 0x182F6BCF0
	private void ClearKeywords() { }

	// RVA: 0x2F6CB40 Offset: 0x2F6B540 VA: 0x182F6CB40
	private void ValidateSpecularHighlights() { }

	// RVA: 0x2F6C020 Offset: 0x2F6AA20 VA: 0x182F6C020
	private void ValidateAlphaTest() { }

	// RVA: 0x2F6C450 Offset: 0x2F6AE50 VA: 0x182F6C450
	private void ValidateNormalMap() { }

	// RVA: 0x2F6CE40 Offset: 0x2F6B840 VA: 0x182F6CE40 Slot: 7
	protected virtual void ValidateTranslucency() { }

	// RVA: 0x2F6CBF0 Offset: 0x2F6B5F0 VA: 0x182F6CBF0
	private void ValidateSurfaceMap() { }

	// RVA: 0x2F6C2D0 Offset: 0x2F6ACD0 VA: 0x182F6C2D0
	private void ValidateEmission() { }

	// RVA: 0x2F6C220 Offset: 0x2F6AC20 VA: 0x182F6C220
	private void ValidateDecals() { }

	// RVA: 0x2F6C160 Offset: 0x2F6AB60 VA: 0x182F6C160
	private void ValidateAlphaToMask() { }

	// RVA: 0x2F6C7D0 Offset: 0x2F6B1D0 VA: 0x182F6C7D0
	private void ValidateRenderQueue() { }

	// RVA: 0x2F6BF90 Offset: 0x2F6A990 VA: 0x182F6BF90 Slot: 5
	protected override bool GetMotionVectorsEnabled() { }

	// RVA: 0x2F6C5B0 Offset: 0x2F6AFB0 VA: 0x182F6C5B0 Slot: 6
	protected override void ValidatePasses(bool receivesSSR, bool useSplitLighting) { }

	// RVA: 0x2F6BD20 Offset: 0x2F6A720 VA: 0x182F6BD20
	private Vector4 ConvertGUIDToVector4(string guid) { }

	// RVA: 0x2F6BE10 Offset: 0x2F6A810 VA: 0x182F6BE10
	private string ConvertVector4ToGUID(Vector4 vector) { }

	// RVA: 0x2F6BCD0 Offset: 0x2F6A6D0 VA: 0x182F6BCD0
	private float Asfloat(uint val) { }

	// RVA: 0x2F6BCD0 Offset: 0x2F6A6D0 VA: 0x182F6BCD0
	private float Asfloat(int val) { }

	// RVA: 0x2F6BCE0 Offset: 0x2F6A6E0 VA: 0x182F6BCE0
	private int Asint(float val) { }

	// RVA: 0x2F6BCE0 Offset: 0x2F6A6E0 VA: 0x182F6BCE0
	private uint Asuint(float val) { }

	// RVA: 0x2F6BF40 Offset: 0x2F6A940 VA: 0x182F6BF40
	private uint GetDiffusionProfileHash(string assetGuid) { }
}
