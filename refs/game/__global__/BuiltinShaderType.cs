public enum BuiltinShaderType // TypeDefIndex: 12191
{
	// Fields
	public int value__; // 0x0
	public const BuiltinShaderType DeferredShading = 0;
	public const BuiltinShaderType DeferredReflections = 1;
	[Obsolete("LegacyDeferredLighting has been removed.", False)]
	public const BuiltinShaderType LegacyDeferredLighting = 2;
	public const BuiltinShaderType ScreenSpaceShadows = 3;
	public const BuiltinShaderType DepthNormals = 4;
	public const BuiltinShaderType MotionVectors = 5;
	public const BuiltinShaderType LightHalo = 6;
	public const BuiltinShaderType LensFlare = 7;
}
