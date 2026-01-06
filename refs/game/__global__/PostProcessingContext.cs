public class PostProcessingContext // TypeDefIndex: 216
{
	// Fields
	public PostProcessingProfile profile; // 0x10
	public Camera camera; // 0x18
	public MaterialFactory materialFactory; // 0x20
	public RenderTextureFactory renderTextureFactory; // 0x28
	[CompilerGenerated]
	private bool <interrupted>k__BackingField; // 0x30

	// Properties
	public bool interrupted { get; set; }
	public bool isGBufferAvailable { get; }
	public bool isHdr { get; }
	public int width { get; }
	public int height { get; }
	public Rect viewport { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_interrupted() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	private void set_interrupted(bool value) { }

	// RVA: 0x578DC0 Offset: 0x5777C0 VA: 0x180578DC0
	public void Interrupt() { }

	// RVA: 0x69EED0 Offset: 0x69D8D0 VA: 0x18069EED0
	public PostProcessingContext Reset() { }

	// RVA: 0x69EF50 Offset: 0x69D950 VA: 0x18069EF50
	public bool get_isGBufferAvailable() { }

	// RVA: 0x69EF80 Offset: 0x69D980 VA: 0x18069EF80
	public bool get_isHdr() { }

	// RVA: 0x69EFE0 Offset: 0x69D9E0 VA: 0x18069EFE0
	public int get_width() { }

	// RVA: 0x69EF30 Offset: 0x69D930 VA: 0x18069EF30
	public int get_height() { }

	// RVA: 0x69EFA0 Offset: 0x69D9A0 VA: 0x18069EFA0
	public Rect get_viewport() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
