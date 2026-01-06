public class ScrollEventArgs : EventArgs // TypeDefIndex: 5556
{
	// Fields
	private ScrollEventType type; // 0x10
	private int new_value; // 0x14
	private int old_value; // 0x18
	private ScrollOrientation scroll_orientation; // 0x1C

	// Properties
	public int NewValue { get; set; }

	// Methods

	// RVA: 0x21E12C0 Offset: 0x21DFCC0 VA: 0x1821E12C0
	public void .ctor(ScrollEventType type, int newValue) { }

	// RVA: 0x21E1340 Offset: 0x21DFD40 VA: 0x1821E1340
	public void .ctor(ScrollEventType type, int oldValue, int newValue, ScrollOrientation scroll) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_NewValue() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_NewValue(int value) { }
}
