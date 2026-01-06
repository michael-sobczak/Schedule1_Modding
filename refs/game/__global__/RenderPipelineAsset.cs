public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 12259
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual string[] prefixedRenderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Material default2DMaskMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }
	public virtual string renderPipelineShaderTag { get; }

	// Methods

	// RVA: 0x2CE6430 Offset: 0x2CE4E30 VA: 0x182CE6430
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 13
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 19
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 20
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 21
	public virtual Shader get_defaultShader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 22
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 23
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x2CE6710 Offset: 0x2CE5110 VA: 0x182CE6710 Slot: 24
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x2CE6650 Offset: 0x2CE5050 VA: 0x182CE6650 Slot: 26
	protected virtual void OnValidate() { }

	// RVA: 0x2CE6610 Offset: 0x2CE5010 VA: 0x182CE6610 Slot: 27
	protected virtual void OnDisable() { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
