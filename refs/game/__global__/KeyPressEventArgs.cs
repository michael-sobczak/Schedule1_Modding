public class KeyPressEventArgs : EventArgs // TypeDefIndex: 5428
{
	// Fields
	private char key_char; // 0x10
	private bool event_handled; // 0x12

	// Properties
	public bool Handled { get; set; }
	public char KeyChar { get; }

	// Methods

	// RVA: 0x234D830 Offset: 0x234C230 VA: 0x18234D830
	public void .ctor(char keyChar) { }

	// RVA: 0x4B9D00 Offset: 0x4B8700 VA: 0x1804B9D00
	public bool get_Handled() { }

	// RVA: 0x4B9D60 Offset: 0x4B8760 VA: 0x1804B9D60
	public void set_Handled(bool value) { }

	// RVA: 0xB25AF0 Offset: 0xB244F0 VA: 0x180B25AF0
	public char get_KeyChar() { }
}
