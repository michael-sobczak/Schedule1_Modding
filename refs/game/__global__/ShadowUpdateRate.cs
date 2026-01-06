public enum ShadowUpdateRate // TypeDefIndex: 269
{
	// Fields
	public int value__; // 0x0
	public const ShadowUpdateRate Never = 1;
	public const ShadowUpdateRate OnEnable = 2;
	public const ShadowUpdateRate OnBeamMove = 4;
	public const ShadowUpdateRate EveryXFrames = 8;
	public const ShadowUpdateRate OnBeamMoveAndEveryXFrames = 12;
}
