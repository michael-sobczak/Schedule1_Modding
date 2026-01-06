public enum DynamicOcclusionUpdateRate // TypeDefIndex: 267
{
	// Fields
	public int value__; // 0x0
	public const DynamicOcclusionUpdateRate Never = 1;
	public const DynamicOcclusionUpdateRate OnEnable = 2;
	public const DynamicOcclusionUpdateRate OnBeamMove = 4;
	public const DynamicOcclusionUpdateRate EveryXFrames = 8;
	public const DynamicOcclusionUpdateRate OnBeamMoveAndEveryXFrames = 12;
}
