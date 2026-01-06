internal class TransparentSettingsPass : ScriptableRenderPass // TypeDefIndex: 8964
{
	// Fields
	private bool m_shouldReceiveShadows; // 0xE0
	private const string m_ProfilerTag = "Transparent Settings Pass";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0

	// Methods

	// RVA: 0x2B2D9F0 Offset: 0x2B2C3F0 VA: 0x182B2D9F0
	public void .ctor(RenderPassEvent evt, bool shadowReceiveSupported) { }

	// RVA: 0x2B2D950 Offset: 0x2B2C350 VA: 0x182B2D950
	public bool Setup() { }

	// RVA: 0x2B2D8E0 Offset: 0x2B2C2E0 VA: 0x182B2D8E0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B2D7C0 Offset: 0x2B2C1C0 VA: 0x182B2D7C0
	public static void ExecutePass(CommandBuffer cmd, bool shouldReceiveShadows) { }

	// RVA: 0x2B2D960 Offset: 0x2B2C360 VA: 0x182B2D960
	private static void .cctor() { }
}
