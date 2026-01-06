public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 16478
{
	// Fields
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField]
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public Sprite get_highlightedSprite() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public Sprite get_pressedSprite() { }

	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Sprite get_selectedSprite() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Sprite get_disabledSprite() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x2F3DFC0 Offset: 0x2F3C9C0 VA: 0x182F3DFC0 Slot: 4
	public bool Equals(SpriteState other) { }
}
