public static class PipelineUtilities // TypeDefIndex: 18850
{
	// Fields
	private const string renderDataListFieldName = "m_RendererDataList";

	// Methods

	// RVA: 0x1F61B00 Offset: 0x1F60500 VA: 0x181F61B00
	public static UniversalRendererData GetRenderer(string guid) { }

	// RVA: 0x1F61E20 Offset: 0x1F60820 VA: 0x181F61E20
	public static void ValidatePipelineRenderers(ScriptableRendererData pass) { }

	// RVA: 0x1F61120 Offset: 0x1F5FB20 VA: 0x181F61120
	private static void AddRendererToPipeline(ScriptableRendererData pass) { }

	// RVA: 0x1F61B60 Offset: 0x1F60560 VA: 0x181F61B60
	public static void RemoveRendererFromPipeline(ScriptableRendererData pass) { }

	// RVA: 0x1F61720 Offset: 0x1F60120 VA: 0x181F61720
	private static int GetDefaultRendererIndex(UniversalRenderPipelineAsset asset) { }

	// RVA: 0x1F61820 Offset: 0x1F60220 VA: 0x181F61820
	public static ScriptableRendererData GetDefaultRenderer() { }

	// RVA: -1 Offset: -1
	public static bool RenderFeatureAdded<T>(bool addIfMissing = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1E9C0 Offset: 0xF1D3C0 VA: 0x180F1E9C0
	|-PipelineUtilities.RenderFeatureAdded<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void AddRenderFeature<T>(ScriptableRendererData forwardRenderer, bool persistent = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1D670 Offset: 0xF1C070 VA: 0x180F1D670
	|-PipelineUtilities.AddRenderFeature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F614C0 Offset: 0x1F5FEC0 VA: 0x181F614C0
	public static void AssignRendererToCamera(UniversalAdditionalCameraData camData, ScriptableRendererData pass) { }
}
