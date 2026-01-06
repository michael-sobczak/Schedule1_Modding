public enum ShaderVariantLogLevel // TypeDefIndex: 13789
{
	// Fields
	public int value__; // 0x0
	[Tooltip("No shader variants are logged")]
	public const ShaderVariantLogLevel Disabled = 0;
	[Tooltip("Only shaders that are compatible with SRPs (e.g., URP, HDRP) are logged")]
	public const ShaderVariantLogLevel OnlySRPShaders = 1;
	[Tooltip("All shader variants are logged")]
	public const ShaderVariantLogLevel AllShaders = 2;
}
