public struct LightData // TypeDefIndex: 9073
{
	// Fields
	public int mainLightIndex; // 0x0
	public int additionalLightsCount; // 0x4
	public int maxPerObjectAdditionalLightsCount; // 0x8
	public NativeArray<VisibleLight> visibleLights; // 0x10
	public bool shadeAdditionalLightsPerVertex; // 0x20
	public bool supportsMixedLighting; // 0x21
	public bool reflectionProbeBoxProjection; // 0x22
	public bool reflectionProbeBlending; // 0x23
	public bool supportsLightLayers; // 0x24
	public bool supportsAdditionalLights; // 0x25
}
