public enum RenderingPath // TypeDefIndex: 11679
{
	// Fields
	public int value__; // 0x0
	public const RenderingPath UsePlayerSettings = -1;
	public const RenderingPath VertexLit = 0;
	public const RenderingPath Forward = 1;
	[Obsolete("DeferredLighting has been removed. Use DeferredShading, Forward or HDRP/URP instead.", False)]
	public const RenderingPath DeferredLighting = 2;
	public const RenderingPath DeferredShading = 3;
}
