internal class LineTag // TypeDefIndex: 5442
{
	// Fields
	private Font font; // 0x10
	private Color color; // 0x18
	private Color back_color; // 0x30
	private Font link_font; // 0x48
	private bool is_link; // 0x50
	private string link_text; // 0x58
	private int start; // 0x60
	private int height; // 0x64
	private int ascent; // 0x68
	private int descent; // 0x6C
	private int shift; // 0x70
	private Line line; // 0x78
	private LineTag next; // 0x80
	private LineTag previous; // 0x88

	// Properties
	public int Ascent { get; }
	public Color BackColor { get; }
	public Color ColorToDisplay { get; }
	public Color Color { get; set; }
	public int End { get; }
	public Font FontToDisplay { get; }
	public Font Font { get; set; }
	public int Height { get; set; }
	public virtual bool IsTextTag { get; }
	public int Length { get; }
	public Line Line { get; set; }
	public LineTag Next { get; set; }
	public LineTag Previous { get; set; }
	public int Shift { get; set; }
	public int Start { get; set; }
	public float Width { get; }
	public float X { get; }
	public bool IsLink { get; set; }
	public string LinkText { get; set; }

	// Methods

	// RVA: 0x2351F20 Offset: 0x2350920 VA: 0x182351F20
	public void .ctor(Line line, int start) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public int get_Ascent() { }

	// RVA: 0xCCD880 Offset: 0xCCC280 VA: 0x180CCD880
	public Color get_BackColor() { }

	// RVA: 0x2351F90 Offset: 0x2350990 VA: 0x182351F90
	public Color get_ColorToDisplay() { }

	// RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	public Color get_Color() { }

	// RVA: 0x2352370 Offset: 0x2350D70 VA: 0x182352370
	public void set_Color(Color value) { }

	// RVA: 0x2351FE0 Offset: 0x23509E0 VA: 0x182351FE0
	public int get_End() { }

	// RVA: 0x2352050 Offset: 0x2350A50 VA: 0x182352050
	public Font get_FontToDisplay() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Font get_Font() { }

	// RVA: 0x2352390 Offset: 0x2350D90 VA: 0x182352390
	public void set_Font(Font value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_Height() { }

	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_Height(int value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	public virtual bool get_IsTextTag() { }

	// RVA: 0x2352120 Offset: 0x2350B20 VA: 0x182352120
	public int get_Length() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Line get_Line() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_Line(Line value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public LineTag get_Next() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_Next(LineTag value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public LineTag get_Previous() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_Previous(LineTag value) { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public int get_Shift() { }

	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_Shift(int value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_Start() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_Start(int value) { }

	// RVA: 0x2352190 Offset: 0x2350B90 VA: 0x182352190
	public float get_Width() { }

	// RVA: 0x23522D0 Offset: 0x2350CD0 VA: 0x1823522D0
	public float get_X() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_IsLink() { }

	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	public void set_IsLink(bool value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_LinkText() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_LinkText(string value) { }

	// RVA: 0x23504E0 Offset: 0x234EEE0 VA: 0x1823504E0
	public LineTag Break(int pos) { }

	// RVA: 0x2350640 Offset: 0x234F040 VA: 0x182350640
	public bool Combine(LineTag other) { }

	// RVA: 0x23506D0 Offset: 0x234F0D0 VA: 0x1823506D0
	public void CopyFormattingFrom(LineTag other) { }

	// RVA: 0x2350740 Offset: 0x234F140 VA: 0x182350740 Slot: 5
	public virtual void Draw(Graphics dc, Color color, float xoff, float y, int drawStart, int drawEnd, string text, out Rectangle measuredText, bool measureText) { }

	// RVA: 0x2350B40 Offset: 0x234F540 VA: 0x182350B40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2350CC0 Offset: 0x234F6C0 VA: 0x182350CC0
	public static LineTag FindTag(Line line, int pos) { }

	// RVA: 0x2350D40 Offset: 0x234F740 VA: 0x182350D40
	public static bool FormatText(Line line, int formatStart, int length, Font font, Color color, Color backColor, FormatSpecified specified) { }

	// RVA: 0x2351490 Offset: 0x234FE90 VA: 0x182351490
	public int GetCharIndex(int x) { }

	// RVA: 0x2351740 Offset: 0x2350140 VA: 0x182351740
	public static LineTag GetFinalTag(LineTag tag) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2351840 Offset: 0x2350240 VA: 0x182351840 Slot: 6
	internal virtual int MaxHeight() { }

	// RVA: 0x2351860 Offset: 0x2350260 VA: 0x182351860
	private static void SetFormat(LineTag tag, Font font, Color color, Color back_color, FormatSpecified specified) { }

	// RVA: 0x2351900 Offset: 0x2350300 VA: 0x182351900 Slot: 7
	public virtual SizeF SizeOfPosition(Graphics dc, int pos) { }

	// RVA: 0x2351B30 Offset: 0x2350530 VA: 0x182351B30 Slot: 8
	public virtual string Text() { }

	// RVA: 0x2351BC0 Offset: 0x23505C0 VA: 0x182351BC0 Slot: 3
	public override string ToString() { }
}
