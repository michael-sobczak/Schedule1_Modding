public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 16458
{
	// Fields
	[SerializeField]
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField]
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	private bool m_WrapAround; // 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public Navigation.Mode get_mode() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x4C2CD0 Offset: 0x4C16D0 VA: 0x1804C2CD0
	public bool get_wrapAround() { }

	// RVA: 0x27639A0 Offset: 0x27623A0 VA: 0x1827639A0
	public void set_wrapAround(bool value) { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public Selectable get_selectOnUp() { }

	// RVA: 0xCC9B80 Offset: 0xCC8580 VA: 0x180CC9B80
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Selectable get_selectOnDown() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Selectable get_selectOnLeft() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Selectable get_selectOnRight() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x2F2F030 Offset: 0x2F2DA30 VA: 0x182F2F030
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x2F2EF20 Offset: 0x2F2D920 VA: 0x182F2EF20 Slot: 4
	public bool Equals(Navigation other) { }
}
