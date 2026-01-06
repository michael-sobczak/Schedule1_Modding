public sealed class AmbientProperties // TypeDefIndex: 5222
{
	// Fields
	private Color fore_color; // 0x10
	private Color back_color; // 0x28
	private Font font; // 0x40
	private Cursor cursor; // 0x48

	// Properties
	public Color BackColor { get; }
	public Cursor Cursor { get; }
	public Font Font { get; }
	public Color ForeColor { get; }

	// Methods

	// RVA: 0xCCDAD0 Offset: 0xCCC4D0 VA: 0x180CCDAD0
	public Color get_BackColor() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Cursor get_Cursor() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Font get_Font() { }

	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Color get_ForeColor() { }
}
