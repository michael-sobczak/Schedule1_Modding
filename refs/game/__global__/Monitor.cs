public abstract class Monitor // TypeDefIndex: 17013
{
	// Fields
	[CompilerGenerated]
	private RenderTexture <output>k__BackingField; // 0x10
	internal bool requested; // 0x18

	// Properties
	public RenderTexture output { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public RenderTexture get_output() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_output(RenderTexture value) { }

	// RVA: 0x29AC970 Offset: 0x29AB370 VA: 0x1829AC970
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 5
	internal virtual bool NeedsHalfRes() { }

	// RVA: 0x29AC7D0 Offset: 0x29AB1D0 VA: 0x1829AC7D0
	protected void CheckOutput(int width, int height) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	internal virtual void OnEnable() { }

	// RVA: 0x29ACAA0 Offset: 0x29AB4A0 VA: 0x1829ACAA0 Slot: 7
	internal virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Render(PostProcessRenderContext context);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
