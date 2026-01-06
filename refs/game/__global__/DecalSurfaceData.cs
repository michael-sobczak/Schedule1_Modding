internal enum DecalSurfaceData // TypeDefIndex: 8977
{
	// Fields
	public int value__; // 0x0
	[Tooltip("Decals will affect only base color and emission.")]
	public const DecalSurfaceData Albedo = 0;
	[Tooltip("Decals will affect only base color, normal and emission.")]
	public const DecalSurfaceData AlbedoNormal = 1;
	[Tooltip("Decals will affect base color, normal, metallic, ambient occlusion, smoothness and emission.")]
	public const DecalSurfaceData AlbedoNormalMAOS = 2;
}
