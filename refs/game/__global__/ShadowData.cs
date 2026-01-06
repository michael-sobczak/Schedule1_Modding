public struct ShadowData // TypeDefIndex: 9075
{
	// Fields
	public bool supportsMainLightShadows; // 0x0
	internal bool mainLightShadowsEnabled; // 0x1
	[Obsolete("Obsolete, this feature was replaced by new 'ScreenSpaceShadows' renderer feature")]
	public bool requiresScreenSpaceShadowResolve; // 0x2
	public int mainLightShadowmapWidth; // 0x4
	public int mainLightShadowmapHeight; // 0x8
	public int mainLightShadowCascadesCount; // 0xC
	public Vector3 mainLightShadowCascadesSplit; // 0x10
	public float mainLightShadowCascadeBorder; // 0x1C
	public bool supportsAdditionalLightShadows; // 0x20
	internal bool additionalLightShadowsEnabled; // 0x21
	public int additionalLightsShadowmapWidth; // 0x24
	public int additionalLightsShadowmapHeight; // 0x28
	public bool supportsSoftShadows; // 0x2C
	public int shadowmapDepthBufferBits; // 0x30
	public List<Vector4> bias; // 0x38
	public List<int> resolution; // 0x40
	internal bool isKeywordAdditionalLightShadowsEnabled; // 0x48
	internal bool isKeywordSoftShadowsEnabled; // 0x49
}
