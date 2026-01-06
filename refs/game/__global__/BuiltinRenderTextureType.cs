public enum BuiltinRenderTextureType // TypeDefIndex: 12176
{
	// Fields
	public int value__; // 0x0
	public const BuiltinRenderTextureType PropertyName = -4;
	public const BuiltinRenderTextureType BufferPtr = -3;
	public const BuiltinRenderTextureType RenderTexture = -2;
	public const BuiltinRenderTextureType BindableTexture = -1;
	public const BuiltinRenderTextureType None = 0;
	public const BuiltinRenderTextureType CurrentActive = 1;
	public const BuiltinRenderTextureType CameraTarget = 2;
	public const BuiltinRenderTextureType Depth = 3;
	public const BuiltinRenderTextureType DepthNormals = 4;
	public const BuiltinRenderTextureType ResolvedDepth = 5;
	[Obsolete("Deferred Lighting has been removed, so PrepassNormalsSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassNormalsSpec = 7;
	[Obsolete("Deferred Lighting has been removed, so PrepassLight built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLight = 8;
	[Obsolete("Deferred Lighting has been removed, so PrepassLightSpec built-in render texture type is never used now.", False)]
	public const BuiltinRenderTextureType PrepassLightSpec = 9;
	public const BuiltinRenderTextureType GBuffer0 = 10;
	public const BuiltinRenderTextureType GBuffer1 = 11;
	public const BuiltinRenderTextureType GBuffer2 = 12;
	public const BuiltinRenderTextureType GBuffer3 = 13;
	public const BuiltinRenderTextureType Reflections = 14;
	public const BuiltinRenderTextureType MotionVectors = 15;
	public const BuiltinRenderTextureType GBuffer4 = 16;
	public const BuiltinRenderTextureType GBuffer5 = 17;
	public const BuiltinRenderTextureType GBuffer6 = 18;
	public const BuiltinRenderTextureType GBuffer7 = 19;
}
