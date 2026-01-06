internal sealed class LogHistogram // TypeDefIndex: 17065
{
	// Fields
	public const int rangeMin = -9;
	public const int rangeMax = 9;
	private const int k_Bins = 128;
	[CompilerGenerated]
	private ComputeBuffer <data>k__BackingField; // 0x10

	// Properties
	public ComputeBuffer data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ComputeBuffer get_data() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_data(ComputeBuffer value) { }

	// RVA: 0x29ABC20 Offset: 0x29AA620 VA: 0x1829ABC20
	public void Generate(PostProcessRenderContext context) { }

	// RVA: 0x29AC0A0 Offset: 0x29AAAA0 VA: 0x1829AC0A0
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	// RVA: 0x29AC0F0 Offset: 0x29AAAF0 VA: 0x1829AC0F0
	public void Release() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
