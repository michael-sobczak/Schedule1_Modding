internal enum VertexFlags // TypeDefIndex: 7092
{
	// Fields
	public int value__; // 0x0
	public const VertexFlags IsSolid = 0;
	public const VertexFlags IsText = 1;
	public const VertexFlags IsTextured = 2;
	public const VertexFlags IsDynamic = 3;
	public const VertexFlags IsSvgGradients = 4;
	[Obsolete("Enum member VertexFlags.LastType has been deprecated. Use VertexFlags.IsGraphViewEdge instead.")]
	public const VertexFlags LastType = 10;
	public const VertexFlags IsGraphViewEdge = 10;
}
