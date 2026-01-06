public class KeyEventArgs : EventArgs // TypeDefIndex: 5427
{
	// Fields
	private Keys key_data; // 0x10
	private bool event_handled; // 0x14
	private bool supress_key_press; // 0x15

	// Properties
	public virtual bool Alt { get; }
	public bool Control { get; }
	public bool Handled { get; set; }
	public Keys KeyCode { get; }
	public Keys KeyData { get; }
	public Keys Modifiers { get; }
	public bool SuppressKeyPress { get; }

	// Methods

	// RVA: 0x234D790 Offset: 0x234C190 VA: 0x18234D790
	public void .ctor(Keys keyData) { }

	// RVA: 0x234D800 Offset: 0x234C200 VA: 0x18234D800 Slot: 4
	public virtual bool get_Alt() { }

	// RVA: 0x234D810 Offset: 0x234C210 VA: 0x18234D810
	public bool get_Control() { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Handled() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_Handled(bool value) { }

	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public Keys get_KeyCode() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public Keys get_KeyData() { }

	// RVA: 0x234D820 Offset: 0x234C220 VA: 0x18234D820
	public Keys get_Modifiers() { }

	// RVA: 0x1BBB9B0 Offset: 0x1BBA3B0 VA: 0x181BBB9B0
	public bool get_SuppressKeyPress() { }
}
