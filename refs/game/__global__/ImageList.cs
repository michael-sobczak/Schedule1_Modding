public sealed class ImageList : Component // TypeDefIndex: 5408
{
	// Fields
	private static readonly Size DefaultImageSize; // 0x0
	private static readonly Color DefaultTransparentColor; // 0x8
	private readonly ImageList.ImageCollection images; // 0x28
	private static object RecreateHandleEvent; // 0x20

	// Properties
	public ColorDepth ColorDepth { set; }
	[DesignerSerializationVisibility(0)]
	[MergableProperty(False)]
	[DefaultValue(null)]
	public ImageList.ImageCollection Images { get; }
	[Localizable(True)]
	public Size ImageSize { get; set; }
	public Color TransparentColor { set; }

	// Methods

	// RVA: 0x2348F40 Offset: 0x2347940 VA: 0x182348F40
	public void .ctor() { }

	// RVA: 0x2348E40 Offset: 0x2347840 VA: 0x182348E40
	private static void .cctor() { }

	// RVA: 0x2348BD0 Offset: 0x23475D0 VA: 0x182348BD0
	private void OnRecreateHandle() { }

	// RVA: 0x23490F0 Offset: 0x2347AF0 VA: 0x1823490F0
	public void set_ColorDepth(ColorDepth value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ImageList.ImageCollection get_Images() { }

	// RVA: 0x23490D0 Offset: 0x2347AD0 VA: 0x1823490D0
	public Size get_ImageSize() { }

	// RVA: 0x2349270 Offset: 0x2347C70 VA: 0x182349270
	public void set_ImageSize(Size value) { }

	// RVA: 0x2349340 Offset: 0x2347D40 VA: 0x182349340
	public void set_TransparentColor(Color value) { }

	// RVA: 0x2348A90 Offset: 0x2347490 VA: 0x182348A90
	public void Draw(Graphics g, Point pt, int index) { }

	// RVA: 0x2348AF0 Offset: 0x23474F0 VA: 0x182348AF0
	public void Draw(Graphics g, int x, int y, int index) { }

	// RVA: 0x2348B60 Offset: 0x2347560 VA: 0x182348B60
	public void Draw(Graphics g, int x, int y, int width, int height, int index) { }

	// RVA: 0x2348CD0 Offset: 0x23476D0 VA: 0x182348CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2348A40 Offset: 0x2347440 VA: 0x182348A40 Slot: 12
	protected override void Dispose(bool disposing) { }
}
