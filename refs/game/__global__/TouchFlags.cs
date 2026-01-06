internal enum TouchFlags // TypeDefIndex: 7655
{
	// Fields
	public byte value__; // 0x0
	public const TouchFlags IndirectTouch = 1;
	public const TouchFlags PrimaryTouch = 8;
	public const TouchFlags TapPress = 16;
	public const TouchFlags TapRelease = 32;
	public const TouchFlags OrphanedPrimaryTouch = 64;
	public const TouchFlags BeganInSameFrame = 128;
}
