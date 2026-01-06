public class NatureMaterial : LitMaterial // TypeDefIndex: 18229
{
	// Properties
	[ShaderProperty("_ScaleFade")]
	public Vector2 ScaleFade { get; set; }
	[ShaderProperty("_NatureRendererDistanceControl")]
	public bool NatureRendererControlsDistance { get; set; }
	[ShaderProperty("_ColorCorrection")]
	public NatureMaterial.ColorCorrectionMode ColorCorrection { get; set; }
	[ShaderProperty("_HSL")]
	public Vector3 HSL { get; set; }
	[ShaderProperty("_HSLVariation")]
	public Vector3 HSLVariation { get; set; }
	[ShaderProperty("_TintVariation")]
	public Color TintVariation { get; set; }
	[ShaderProperty("_ColorVariationSpread")]
	public float ColorVariationSpread { get; set; }
	[ShaderProperty("_VertexNormalStrength")]
	public float VertexNormalStrength { get; set; }
	[ShaderProperty("_SecondaryMaps")]
	public float SecondaryMaps { get; set; }
	[ShaderProperty("_SecondaryAlbedo")]
	public Texture SecondaryAlbedoMap { get; set; }
	[ShaderProperty("_SecondaryGlossiness")]
	public float SecondaryGlossiness { get; set; }
	[ShaderProperty("_SecondaryGlossRemap")]
	public Vector2 SecondaryGlossRemap { get; set; }
	[ShaderProperty("_SecondaryMetallic")]
	public float SecondaryMetallic { get; set; }
	[ShaderProperty("_SecondaryMetallicGlossMap")]
	public Texture SecondaryMetallicGlossMap { get; set; }
	[ShaderProperty("_SecondaryNormalMap")]
	public Texture SecondaryNormalMap { get; set; }
	[ShaderProperty("_SecondaryNormalMapScale")]
	public float SecondaryNormalMapScale { get; set; }
	[ShaderProperty("_SecondaryOcclusionMap")]
	public Texture SecondaryOcclusionMap { get; set; }
	[ShaderProperty("_SecondaryOcclusionRemap")]
	public Vector2 SecondaryOcclusionRemap { get; set; }
	[ShaderProperty("_SecondaryPackedMap")]
	public Texture SecondaryPackedMap { get; set; }
	public bool BakedMeshData { get; set; }
	public float ObjectHeight { get; set; }
	public float ObjectRadius { get; set; }
	[ShaderProperty("_Wind")]
	public bool WindEnabled { get; set; }
	[Obsolete("Use 'WindEnabled' and 'BakedMeshData' instead")]
	public NatureMaterial.WindMode Wind { get; set; }
	[ShaderProperty("_WindVariation")]
	public float WindVariation { get; set; }
	[ShaderProperty("_WindStrength")]
	public float WindStrength { get; set; }
	[ShaderProperty("_TurbulenceStrength")]
	public float TurbulenceStrength { get; set; }
	[ShaderProperty("_RecalculateWindNormals")]
	public float RecalculateWindNormals { get; set; }
	[ShaderProperty("_WindFade")]
	public Vector2 WindFade { get; set; }
	[ShaderProperty("_TrunkBendFactor")]
	public Vector2 TrunkBendFactor { get; set; }
	[ShaderProperty("_Interaction")]
	public float Interaction { get; set; }
	[ShaderProperty("_InteractionDuration")]
	public float InteractionDuration { get; set; }
	[ShaderProperty("_InteractionStrength")]
	public float InteractionStrength { get; set; }
	[ShaderProperty("_InteractionPushDown")]
	public float InteractionPushDown { get; set; }
	[ShaderProperty("_TranslucencyBlendMode")]
	public NatureMaterial.BlendMode TranslucencyBlendMode { get; set; }
	[ShaderProperty("_TranslucencyStrength")]
	public float TranslucencyStrength { get; set; }
	[ShaderProperty("_TranslucencyDistortion")]
	public float TranslucencyDistortion { get; set; }
	[ShaderProperty("_TranslucencyScattering")]
	public float TranslucencyScattering { get; set; }
	[ShaderProperty("_TranslucencyColor")]
	public float TranslucencyColor { get; set; }
	[ShaderProperty("_TranslucencyAmbient")]
	public float TranslucencyAmbient { get; set; }
	[ShaderProperty("_ThicknessMap")]
	public Texture ThicknessMap { get; set; }
	[ShaderProperty("_ThicknessRemap")]
	public Vector2 ThicknessRemap { get; set; }
	[ShaderProperty("_Overlay")]
	public bool Overlay { get; set; }
	[ShaderProperty("_SampleAlphaOverlay")]
	public bool SampleAlphaOverlay { get; set; }
	[ShaderProperty("_SampleColorOverlay")]
	public bool SampleColorOverlay { get; set; }
	[ShaderProperty("_PerspectiveCorrection")]
	public float PerspectiveCorrection { get; set; }
	[ShaderProperty("_LightingQuality")]
	public NatureMaterial.LightingQuality Lighting { get; set; }

	// Methods

	// RVA: 0x2F649F0 Offset: 0x2F633F0 VA: 0x182F649F0
	public Vector2 get_ScaleFade() { }

	// RVA: 0x2F65A10 Offset: 0x2F64410 VA: 0x182F65A10
	public void set_ScaleFade(Vector2 value) { }

	// RVA: 0x2F64770 Offset: 0x2F63170 VA: 0x182F64770
	public bool get_NatureRendererControlsDistance() { }

	// RVA: 0x2F656D0 Offset: 0x2F640D0 VA: 0x182F656D0
	public void set_NatureRendererControlsDistance(bool value) { }

	// RVA: 0x2F644B0 Offset: 0x2F62EB0 VA: 0x182F644B0
	public NatureMaterial.ColorCorrectionMode get_ColorCorrection() { }

	// RVA: 0x2F652F0 Offset: 0x2F63CF0 VA: 0x182F652F0
	public void set_ColorCorrection(NatureMaterial.ColorCorrectionMode value) { }

	// RVA: 0x2F645B0 Offset: 0x2F62FB0 VA: 0x182F645B0
	public Vector3 get_HSL() { }

	// RVA: 0x2F65450 Offset: 0x2F63E50 VA: 0x182F65450
	public void set_HSL(Vector3 value) { }

	// RVA: 0x2F64540 Offset: 0x2F62F40 VA: 0x182F64540
	public Vector3 get_HSLVariation() { }

	// RVA: 0x2F653B0 Offset: 0x2F63DB0 VA: 0x182F653B0
	public void set_HSLVariation(Vector3 value) { }

	// RVA: 0x2F64DF0 Offset: 0x2F637F0 VA: 0x182F64DF0
	public Color get_TintVariation() { }

	// RVA: 0x2F66010 Offset: 0x2F64A10 VA: 0x182F66010
	public void set_TintVariation(Color value) { }

	// RVA: 0x2F64500 Offset: 0x2F62F00 VA: 0x182F64500
	public float get_ColorVariationSpread() { }

	// RVA: 0x2F65350 Offset: 0x2F63D50 VA: 0x182F65350
	public void set_ColorVariationSpread(float value) { }

	// RVA: 0x2F65080 Offset: 0x2F63A80 VA: 0x182F65080
	public float get_VertexNormalStrength() { }

	// RVA: 0x2F663A0 Offset: 0x2F64DA0 VA: 0x182F663A0
	public void set_VertexNormalStrength(float value) { }

	// RVA: 0x2F64B30 Offset: 0x2F63530 VA: 0x182F64B30
	public float get_SecondaryMaps() { }

	// RVA: 0x2F65BF0 Offset: 0x2F645F0 VA: 0x182F65BF0
	public void set_SecondaryMaps(float value) { }

	// RVA: 0x2F64A50 Offset: 0x2F63450 VA: 0x182F64A50
	public Texture get_SecondaryAlbedoMap() { }

	// RVA: 0x2F65AA0 Offset: 0x2F644A0 VA: 0x182F65AA0
	public void set_SecondaryAlbedoMap(Texture value) { }

	// RVA: 0x2F64AF0 Offset: 0x2F634F0 VA: 0x182F64AF0
	public float get_SecondaryGlossiness() { }

	// RVA: 0x2F65B90 Offset: 0x2F64590 VA: 0x182F65B90
	public void set_SecondaryGlossiness(float value) { }

	// RVA: 0x2F64A90 Offset: 0x2F63490 VA: 0x182F64A90
	public Vector2 get_SecondaryGlossRemap() { }

	// RVA: 0x2F65B00 Offset: 0x2F64500 VA: 0x182F65B00
	public void set_SecondaryGlossRemap(Vector2 value) { }

	// RVA: 0x2F64BB0 Offset: 0x2F635B0 VA: 0x182F64BB0
	public float get_SecondaryMetallic() { }

	// RVA: 0x2F65CB0 Offset: 0x2F646B0 VA: 0x182F65CB0
	public void set_SecondaryMetallic(float value) { }

	// RVA: 0x2F64B70 Offset: 0x2F63570 VA: 0x182F64B70
	public Texture get_SecondaryMetallicGlossMap() { }

	// RVA: 0x2F65C50 Offset: 0x2F64650 VA: 0x182F65C50
	public void set_SecondaryMetallicGlossMap(Texture value) { }

	// RVA: 0x2F64C30 Offset: 0x2F63630 VA: 0x182F64C30
	public Texture get_SecondaryNormalMap() { }

	// RVA: 0x2F65D70 Offset: 0x2F64770 VA: 0x182F65D70
	public void set_SecondaryNormalMap(Texture value) { }

	// RVA: 0x2F64BF0 Offset: 0x2F635F0 VA: 0x182F64BF0
	public float get_SecondaryNormalMapScale() { }

	// RVA: 0x2F65D10 Offset: 0x2F64710 VA: 0x182F65D10
	public void set_SecondaryNormalMapScale(float value) { }

	// RVA: 0x2F64C70 Offset: 0x2F63670 VA: 0x182F64C70
	public Texture get_SecondaryOcclusionMap() { }

	// RVA: 0x2F65DD0 Offset: 0x2F647D0 VA: 0x182F65DD0
	public void set_SecondaryOcclusionMap(Texture value) { }

	// RVA: 0x2F64CB0 Offset: 0x2F636B0 VA: 0x182F64CB0
	public Vector2 get_SecondaryOcclusionRemap() { }

	// RVA: 0x2F65E30 Offset: 0x2F64830 VA: 0x182F65E30
	public void set_SecondaryOcclusionRemap(Vector2 value) { }

	// RVA: 0x2F64D10 Offset: 0x2F63710 VA: 0x182F64D10
	public Texture get_SecondaryPackedMap() { }

	// RVA: 0x2F65EC0 Offset: 0x2F648C0 VA: 0x182F65EC0
	public void set_SecondaryPackedMap(Texture value) { }

	// RVA: 0x2F64460 Offset: 0x2F62E60 VA: 0x182F64460
	public bool get_BakedMeshData() { }

	// RVA: 0x2F65280 Offset: 0x2F63C80 VA: 0x182F65280
	public void set_BakedMeshData(bool value) { }

	// RVA: 0x2F647D0 Offset: 0x2F631D0 VA: 0x182F647D0
	public float get_ObjectHeight() { }

	// RVA: 0x2F65740 Offset: 0x2F64140 VA: 0x182F65740
	public void set_ObjectHeight(float value) { }

	// RVA: 0x2F64810 Offset: 0x2F63210 VA: 0x182F64810
	public float get_ObjectRadius() { }

	// RVA: 0x2F657A0 Offset: 0x2F641A0 VA: 0x182F657A0
	public void set_ObjectRadius(float value) { }

	// RVA: 0x2F650C0 Offset: 0x2F63AC0 VA: 0x182F650C0
	public bool get_WindEnabled() { }

	// RVA: 0x2F66400 Offset: 0x2F64E00 VA: 0x182F66400
	public void set_WindEnabled(bool value) { }

	// RVA: 0x2F651F0 Offset: 0x2F63BF0 VA: 0x182F651F0
	public NatureMaterial.WindMode get_Wind() { }

	// RVA: 0x2F665C0 Offset: 0x2F64FC0 VA: 0x182F665C0
	public void set_Wind(NatureMaterial.WindMode value) { }

	// RVA: 0x2F651B0 Offset: 0x2F63BB0 VA: 0x182F651B0
	public float get_WindVariation() { }

	// RVA: 0x2F66560 Offset: 0x2F64F60 VA: 0x182F66560
	public void set_WindVariation(float value) { }

	// RVA: 0x2F65170 Offset: 0x2F63B70 VA: 0x182F65170
	public float get_WindStrength() { }

	// RVA: 0x2F66500 Offset: 0x2F64F00 VA: 0x182F66500
	public void set_WindStrength(float value) { }

	// RVA: 0x2F65040 Offset: 0x2F63A40 VA: 0x182F65040
	public float get_TurbulenceStrength() { }

	// RVA: 0x2F66340 Offset: 0x2F64D40 VA: 0x182F66340
	public void set_TurbulenceStrength(float value) { }

	// RVA: 0x2F648F0 Offset: 0x2F632F0 VA: 0x182F648F0
	public float get_RecalculateWindNormals() { }

	// RVA: 0x2F658D0 Offset: 0x2F642D0 VA: 0x182F658D0
	public void set_RecalculateWindNormals(float value) { }

	// RVA: 0x2F65110 Offset: 0x2F63B10 VA: 0x182F65110
	public Vector2 get_WindFade() { }

	// RVA: 0x2F66470 Offset: 0x2F64E70 VA: 0x182F66470
	public void set_WindFade(Vector2 value) { }

	// RVA: 0x2F64FE0 Offset: 0x2F639E0 VA: 0x182F64FE0
	public Vector2 get_TrunkBendFactor() { }

	// RVA: 0x2F662B0 Offset: 0x2F64CB0 VA: 0x182F662B0
	public void set_TrunkBendFactor(Vector2 value) { }

	// RVA: 0x2F646E0 Offset: 0x2F630E0 VA: 0x182F646E0
	public float get_Interaction() { }

	// RVA: 0x2F65610 Offset: 0x2F64010 VA: 0x182F65610
	public void set_Interaction(float value) { }

	// RVA: 0x2F64620 Offset: 0x2F63020 VA: 0x182F64620
	public float get_InteractionDuration() { }

	// RVA: 0x2F654F0 Offset: 0x2F63EF0 VA: 0x182F654F0
	public void set_InteractionDuration(float value) { }

	// RVA: 0x2F646A0 Offset: 0x2F630A0 VA: 0x182F646A0
	public float get_InteractionStrength() { }

	// RVA: 0x2F655B0 Offset: 0x2F63FB0 VA: 0x182F655B0
	public void set_InteractionStrength(float value) { }

	// RVA: 0x2F64660 Offset: 0x2F63060 VA: 0x182F64660
	public float get_InteractionPushDown() { }

	// RVA: 0x2F65550 Offset: 0x2F63F50 VA: 0x182F65550
	public void set_InteractionPushDown(float value) { }

	// RVA: 0x2F64E90 Offset: 0x2F63890 VA: 0x182F64E90
	public NatureMaterial.BlendMode get_TranslucencyBlendMode() { }

	// RVA: 0x2F660D0 Offset: 0x2F64AD0 VA: 0x182F660D0
	public void set_TranslucencyBlendMode(NatureMaterial.BlendMode value) { }

	// RVA: 0x2F64FA0 Offset: 0x2F639A0 VA: 0x182F64FA0
	public float get_TranslucencyStrength() { }

	// RVA: 0x2F66250 Offset: 0x2F64C50 VA: 0x182F66250
	public void set_TranslucencyStrength(float value) { }

	// RVA: 0x2F64F20 Offset: 0x2F63920 VA: 0x182F64F20
	public float get_TranslucencyDistortion() { }

	// RVA: 0x2F66190 Offset: 0x2F64B90 VA: 0x182F66190
	public void set_TranslucencyDistortion(float value) { }

	// RVA: 0x2F64F60 Offset: 0x2F63960 VA: 0x182F64F60
	public float get_TranslucencyScattering() { }

	// RVA: 0x2F661F0 Offset: 0x2F64BF0 VA: 0x182F661F0
	public void set_TranslucencyScattering(float value) { }

	// RVA: 0x2F64EE0 Offset: 0x2F638E0 VA: 0x182F64EE0
	public float get_TranslucencyColor() { }

	// RVA: 0x2F66130 Offset: 0x2F64B30 VA: 0x182F66130
	public void set_TranslucencyColor(float value) { }

	// RVA: 0x2F64E50 Offset: 0x2F63850 VA: 0x182F64E50
	public float get_TranslucencyAmbient() { }

	// RVA: 0x2F66070 Offset: 0x2F64A70 VA: 0x182F66070
	public void set_TranslucencyAmbient(float value) { }

	// RVA: 0x2F64D50 Offset: 0x2F63750 VA: 0x182F64D50
	public Texture get_ThicknessMap() { }

	// RVA: 0x2F65F20 Offset: 0x2F64920 VA: 0x182F65F20
	public void set_ThicknessMap(Texture value) { }

	// RVA: 0x2F64D90 Offset: 0x2F63790 VA: 0x182F64D90
	public Vector2 get_ThicknessRemap() { }

	// RVA: 0x2F65F80 Offset: 0x2F64980 VA: 0x182F65F80
	public void set_ThicknessRemap(Vector2 value) { }

	// RVA: 0x2F64850 Offset: 0x2F63250 VA: 0x182F64850
	public bool get_Overlay() { }

	// RVA: 0x2F65800 Offset: 0x2F64200 VA: 0x182F65800
	public void set_Overlay(bool value) { }

	// RVA: 0x2F64930 Offset: 0x2F63330 VA: 0x182F64930
	public bool get_SampleAlphaOverlay() { }

	// RVA: 0x2F65930 Offset: 0x2F64330 VA: 0x182F65930
	public void set_SampleAlphaOverlay(bool value) { }

	// RVA: 0x2F64990 Offset: 0x2F63390 VA: 0x182F64990
	public bool get_SampleColorOverlay() { }

	// RVA: 0x2F659A0 Offset: 0x2F643A0 VA: 0x182F659A0
	public void set_SampleColorOverlay(bool value) { }

	// RVA: 0x2F648B0 Offset: 0x2F632B0 VA: 0x182F648B0
	public float get_PerspectiveCorrection() { }

	// RVA: 0x2F65870 Offset: 0x2F64270 VA: 0x182F65870
	public void set_PerspectiveCorrection(float value) { }

	// RVA: 0x2F64720 Offset: 0x2F63120 VA: 0x182F64720
	public NatureMaterial.LightingQuality get_Lighting() { }

	// RVA: 0x2F65670 Offset: 0x2F64070 VA: 0x182F65670
	public void set_Lighting(NatureMaterial.LightingQuality value) { }

	// RVA: 0x2F64450 Offset: 0x2F62E50 VA: 0x182F64450
	public void .ctor(Material material) { }

	// RVA: 0x2F63FC0 Offset: 0x2F629C0 VA: 0x182F63FC0 Slot: 4
	public override void Validate(bool clean) { }

	// RVA: 0x2F63890 Offset: 0x2F62290 VA: 0x182F63890
	private void ValidateMeshData() { }

	// RVA: 0x2F63610 Offset: 0x2F62010 VA: 0x182F63610
	private void ValidateColorCorrection() { }

	// RVA: 0x2F63EF0 Offset: 0x2F628F0 VA: 0x182F63EF0
	private void ValidateWind() { }

	// RVA: 0x2F636E0 Offset: 0x2F620E0 VA: 0x182F636E0
	private void ValidateInteraction() { }

	// RVA: 0x2F63910 Offset: 0x2F62310 VA: 0x182F63910
	private void ValidateOverlay() { }

	// RVA: 0x2F63BF0 Offset: 0x2F625F0 VA: 0x182F63BF0 Slot: 7
	protected override void ValidateTranslucency() { }

	// RVA: 0x2F637C0 Offset: 0x2F621C0 VA: 0x182F637C0
	private void ValidateLightingQuality() { }

	// RVA: 0x2F63990 Offset: 0x2F62390 VA: 0x182F63990
	private void ValidateSecondaryMaps() { }
}
