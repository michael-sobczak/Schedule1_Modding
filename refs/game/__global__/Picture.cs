internal class Picture // TypeDefIndex: 5211
{
	// Fields
	private Minor image_type; // 0x10
	private Image image; // 0x18
	private MemoryStream data; // 0x20
	private float width; // 0x28
	private float height; // 0x2C
	private static readonly float dpix; // 0x0

	// Properties
	public Minor ImageType { get; set; }
	public MemoryStream Data { get; }
	public float Width { get; }
	public float Height { get; }
	public SizeF Size { get; }

	// Methods

	// RVA: 0x21D2970 Offset: 0x21D1370 VA: 0x1821D2970
	public void .ctor() { }

	// RVA: 0x21D2920 Offset: 0x21D1320 VA: 0x1821D2920
	private static void .cctor() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public Minor get_ImageType() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_ImageType(Minor value) { }

	// RVA: 0x21D2990 Offset: 0x21D1390 VA: 0x1821D2990
	public MemoryStream get_Data() { }

	// RVA: 0x21D2BA0 Offset: 0x21D15A0 VA: 0x1821D2BA0
	public float get_Width() { }

	// RVA: 0x21D2A00 Offset: 0x21D1400 VA: 0x1821D2A00
	public float get_Height() { }

	// RVA: 0x21D2A80 Offset: 0x21D1480 VA: 0x1821D2A80
	public SizeF get_Size() { }

	// RVA: 0x21D2850 Offset: 0x21D1250 VA: 0x1821D2850
	public void SetWidthFromTwips(int twips) { }

	// RVA: 0x21D27C0 Offset: 0x21D11C0 VA: 0x1821D27C0
	public void SetHeightFromTwips(int twips) { }

	// RVA: 0x21D2790 Offset: 0x21D1190 VA: 0x1821D2790
	public bool IsValid() { }

	// RVA: 0x21D28E0 Offset: 0x21D12E0 VA: 0x1821D28E0
	public Image ToImage() { }
}
