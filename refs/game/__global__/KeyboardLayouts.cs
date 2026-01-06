internal class KeyboardLayouts // TypeDefIndex: 5429
{
	// Fields
	private KeyboardLayout[] keyboard_layouts; // 0x10
	public int[][] vkey_table; // 0x18
	public short[][] scan_table; // 0x20

	// Properties
	public KeyboardLayout[] Layouts { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x234D890 Offset: 0x234C290 VA: 0x18234D890
	public void LoadLayouts() { }

	// RVA: 0x234DB20 Offset: 0x234C520 VA: 0x18234DB20
	public KeyboardLayout[] get_Layouts() { }
}
