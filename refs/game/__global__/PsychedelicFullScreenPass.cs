public class PsychedelicFullScreenPass : ScriptableRenderPass // TypeDefIndex: 3395
{
	// Fields
	private PsychedelicFullScreenFeature.Settings _settings; // 0xE0
	private RTHandle _source; // 0xE8
	private RTHandle _tempTexture; // 0xF0
	private Material _material; // 0xF8
	private static readonly int BLEND_ID; // 0x0
	private static readonly int NOISE_SCALE_ID; // 0x4
	private static readonly int PAN_SPEED_ID; // 0x8
	private static readonly int DOES_BOUNCE_ID; // 0xC
	private static readonly int AMPLITUDE_ID; // 0x10

	// Methods

	// RVA: 0xA785C0 Offset: 0xA76FC0 VA: 0x180A785C0
	public void .ctor(PsychedelicFullScreenFeature.Settings settings) { }

	// RVA: 0xA78380 Offset: 0xA76D80 VA: 0x180A78380 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0xA78000 Offset: 0xA76A00 VA: 0x180A78000 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0xA784C0 Offset: 0xA76EC0 VA: 0x180A784C0
	private static void .cctor() { }
}
