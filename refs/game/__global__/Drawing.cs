public class Drawing // TypeDefIndex: 1377
{
	// Fields
	[CompilerGenerated]
	private int <Width>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Height>k__BackingField; // 0x14
	[CompilerGenerated]
	private Texture2D <OutputTexture>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <PaintedPixelCount>k__BackingField; // 0x20
	private ushort falloffRadius; // 0x24
	private float[] falloffTable; // 0x28
	private List<SprayStroke> strokes; // 0x30
	public Action onTextureChanged; // 0x38

	// Properties
	public int Width { get; set; }
	public int Height { get; set; }
	public Texture2D OutputTexture { get; set; }
	public int StrokeCount { get; }
	public int PaintedPixelCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Width() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_Width(int value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_Height() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	private void set_Height(int value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Texture2D get_OutputTexture() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_OutputTexture(Texture2D value) { }

	// RVA: 0x65C850 Offset: 0x65B250 VA: 0x18065C850
	public int get_StrokeCount() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_PaintedPixelCount() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_PaintedPixelCount(int value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<SprayStroke> GetStrokes() { }

	// RVA: 0x65C6B0 Offset: 0x65B0B0 VA: 0x18065C6B0
	public void .ctor(int width, int height, ushort falloffRadius, float[] falloffTable, bool initPixels) { }

	// RVA: 0x65C3C0 Offset: 0x65ADC0 VA: 0x18065C3C0
	public Drawing GetCopy() { }

	// RVA: 0x65C040 Offset: 0x65AA40 VA: 0x18065C040
	public void DrawPaintedPixel(PixelData data, bool applyTexture) { }

	// RVA: 0x65C640 Offset: 0x65B040 VA: 0x18065C640
	public static Color LerpUnclampedFast(Color a, Color b, float t) { }

	// RVA: 0x65BFF0 Offset: 0x65A9F0 VA: 0x18065BFF0
	private void ApplyTexture() { }

	// RVA: 0x65C620 Offset: 0x65B020 VA: 0x18065C620
	private bool IsCoordinateInBounds(int x, int y) { }

	// RVA: 0x65BCB0 Offset: 0x65A6B0 VA: 0x18065BCB0
	public void AddStroke(SprayStroke stroke) { }

	// RVA: 0x65BE00 Offset: 0x65A800 VA: 0x18065BE00
	public void AddStrokes(List<SprayStroke> newStrokes) { }
}
