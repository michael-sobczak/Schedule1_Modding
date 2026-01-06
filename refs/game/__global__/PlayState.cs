public enum PlayState // TypeDefIndex: 12308
{
	// Fields
	public int value__; // 0x0
	public const PlayState Paused = 0;
	public const PlayState Playing = 1;
	[Obsolete("Delayed is obsolete; use a custom ScriptPlayable to implement this feature", False)]
	public const PlayState Delayed = 2;
}
