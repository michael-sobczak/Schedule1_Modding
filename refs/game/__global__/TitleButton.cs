internal class TitleButton // TypeDefIndex: 5418
{
	// Fields
	public Rectangle Rectangle; // 0x10
	public ButtonState State; // 0x20
	public CaptionButton Caption; // 0x24
	private EventHandler Clicked; // 0x28
	public bool Visible; // 0x30
	private bool entered; // 0x31

	// Properties
	public bool Entered { get; set; }

	// Methods

	// RVA: 0x2354320 Offset: 0x2352D20 VA: 0x182354320
	public void .ctor(CaptionButton caption, EventHandler clicked) { }

	// RVA: 0x23542A0 Offset: 0x2352CA0 VA: 0x1823542A0
	public void OnClick() { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_Entered() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	public void set_Entered(bool value) { }
}
