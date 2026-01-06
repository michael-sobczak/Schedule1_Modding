public struct LightBakingOutput // TypeDefIndex: 11675
{
	// Fields
	public int probeOcclusionLightIndex; // 0x0
	public int occlusionMaskChannel; // 0x4
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	public LightmapBakeType lightmapBakeType; // 0x8
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	public MixedLightingMode mixedLightingMode; // 0xC
	public bool isBaked; // 0x10
}
