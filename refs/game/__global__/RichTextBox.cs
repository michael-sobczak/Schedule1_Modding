public class RichTextBox : TextBoxBase // TypeDefIndex: 5546
{
	// Fields
	private bool reuse_line; // 0x270
	private StringBuilder rtf_line; // 0x278
	private RichTextBox.RtfSectionStyle rtf_style; // 0x280
	private Stack rtf_section_stack; // 0x288
	private TextMap rtf_text_map; // 0x290
	private int rtf_skip_count; // 0x298
	private int rtf_cursor_x; // 0x29C
	private int rtf_cursor_y; // 0x2A0
	private int rtf_chars; // 0x2A4
	private static object ContentsResizedEvent; // 0x0
	private static object HScrollEvent; // 0x8
	private static object ImeChangeEvent; // 0x10
	private static object LinkClickedEvent; // 0x18
	private static object ProtectedEvent; // 0x20
	private static object SelectionChangedEvent; // 0x28
	private static object VScrollEvent; // 0x30
	private static readonly char[] ReservedRTFChars; // 0x38

	// Properties
	public override Font Font { get; }
	public override Color ForeColor { get; }
	[DefaultValue("")]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public string SelectedRtf { get; set; }

	// Methods

	// RVA: 0x23A9500 Offset: 0x23A7F00 VA: 0x1823A9500
	private static void .cctor() { }

	// RVA: 0x21E0540 Offset: 0x21DEF40 VA: 0x1821E0540 Slot: 63
	public override Font get_Font() { }

	// RVA: 0x23A9790 Offset: 0x23A8190 VA: 0x1823A9790 Slot: 65
	public override Color get_ForeColor() { }

	// RVA: 0x23A97C0 Offset: 0x23A81C0 VA: 0x1823A97C0
	public string get_SelectedRtf() { }

	// RVA: 0x23A9820 Offset: 0x23A8220 VA: 0x1823A9820
	public void set_SelectedRtf(string value) { }

	// RVA: 0x23A8AE0 Offset: 0x23A74E0 VA: 0x1823A8AE0
	private void HandleGroup(RTF rtf) { }

	[MonoInternalNote("Add QuadJust support for justified alignment")]
	// RVA: 0x23A8250 Offset: 0x23A6C50 VA: 0x1823A8250
	private void HandleControl(RTF rtf) { }

	// RVA: 0x23A92E0 Offset: 0x23A7CE0 VA: 0x1823A92E0
	private void SpecialChar(RTF rtf) { }

	// RVA: 0x23A8CE0 Offset: 0x23A76E0 VA: 0x1823A8CE0
	private void HandleText(RTF rtf) { }

	// RVA: 0x23A68F0 Offset: 0x23A52F0 VA: 0x1823A68F0
	private void FlushText(RTF rtf, bool newline) { }

	// RVA: 0x23A8DD0 Offset: 0x23A77D0 VA: 0x1823A8DD0
	private void InsertRTFFromStream(Stream data, int cursor_x, int cursor_y, out int to_x, out int to_y, out int chars) { }

	// RVA: 0x23A64C0 Offset: 0x23A4EC0 VA: 0x1823A64C0
	private void EmitRTFFontProperties(StringBuilder rtf, int prev_index, int font_index, Font prev_font, Font font) { }

	[MonoInternalNote("Emit unicode and other special characters properly")]
	// RVA: 0x23A6780 Offset: 0x23A5180 VA: 0x1823A6780
	private void EmitRTFText(StringBuilder rtf, string text) { }

	// RVA: 0x23A6F20 Offset: 0x23A5920 VA: 0x1823A6F20
	private StringBuilder GenerateRTF(Line start_line, int start_pos, Line end_line, int end_pos) { }
}
