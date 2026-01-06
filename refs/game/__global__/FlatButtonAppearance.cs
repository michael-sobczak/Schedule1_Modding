public class FlatButtonAppearance // TypeDefIndex: 5363
{
	// Fields
	private Color borderColor; // 0x10
	private int borderSize; // 0x28
	private Color checkedBackColor; // 0x30
	private Color mouseDownBackColor; // 0x48
	private Color mouseOverBackColor; // 0x60
	private ButtonBase owner; // 0x78

	// Properties
	[EditorBrowsable(0)]
	[DefaultValue(typeof(Color), "")]
	[NotifyParentProperty(True)]
	[Browsable(True)]
	public Color BorderColor { get; }
	[Browsable(True)]
	[DefaultValue(1)]
	[EditorBrowsable(0)]
	[NotifyParentProperty(True)]
	public int BorderSize { get; }
	[DefaultValue(typeof(Color), "")]
	[NotifyParentProperty(True)]
	[EditorBrowsable(0)]
	[Browsable(True)]
	public Color CheckedBackColor { get; }
	[Browsable(True)]
	[NotifyParentProperty(True)]
	[EditorBrowsable(0)]
	[DefaultValue(typeof(Color), "")]
	public Color MouseDownBackColor { get; }
	[NotifyParentProperty(True)]
	[DefaultValue(typeof(Color), "")]
	[EditorBrowsable(0)]
	[Browsable(True)]
	public Color MouseOverBackColor { get; }

	// Methods

	// RVA: 0x2326100 Offset: 0x2324B00 VA: 0x182326100
	internal void .ctor(ButtonBase owner) { }

	// RVA: 0xBBD020 Offset: 0xBBBA20 VA: 0x180BBD020
	public Color get_BorderColor() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_BorderSize() { }

	// RVA: 0xCCD880 Offset: 0xCCC280 VA: 0x180CCD880
	public Color get_CheckedBackColor() { }

	// RVA: 0x2326210 Offset: 0x2324C10 VA: 0x182326210
	public Color get_MouseDownBackColor() { }

	// RVA: 0x2326230 Offset: 0x2324C30 VA: 0x182326230
	public Color get_MouseOverBackColor() { }
}
