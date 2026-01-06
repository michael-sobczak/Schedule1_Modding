internal class SystemResPool // TypeDefIndex: 5593
{
	// Fields
	private Hashtable pens; // 0x10
	private Hashtable dashpens; // 0x18
	private Hashtable sizedpens; // 0x20
	private Hashtable solidbrushes; // 0x28
	private Hashtable hatchbrushes; // 0x30
	private Hashtable uiImages; // 0x38
	private Hashtable cpcolors; // 0x40

	// Methods

	// RVA: 0x2218770 Offset: 0x2217170 VA: 0x182218770
	public void .ctor() { }

	// RVA: 0x2218110 Offset: 0x2216B10 VA: 0x182218110
	public Pen GetPen(Color color) { }

	// RVA: 0x2217D10 Offset: 0x2216710 VA: 0x182217D10
	public Pen GetDashPen(Color color, DashStyle dashStyle) { }

	// RVA: 0x22182F0 Offset: 0x2216CF0 VA: 0x1822182F0
	public Pen GetSizedPen(Color color, int size) { }

	// RVA: 0x22184C0 Offset: 0x2216EC0 VA: 0x1822184C0
	public SolidBrush GetSolidBrush(Color color) { }

	// RVA: 0x2217EF0 Offset: 0x22168F0 VA: 0x182217EF0
	public HatchBrush GetHatchBrush(HatchStyle hatchStyle, Color foreColor, Color backColor) { }

	// RVA: 0x22177F0 Offset: 0x22161F0 VA: 0x1822177F0
	public void AddUIImage(Image image, string name, int size) { }

	// RVA: 0x22186A0 Offset: 0x22170A0 VA: 0x1822186A0
	public Image GetUIImage(string name, int size) { }

	// RVA: 0x22178F0 Offset: 0x22162F0 VA: 0x1822178F0
	public CPColor GetCPColor(Color color) { }
}
