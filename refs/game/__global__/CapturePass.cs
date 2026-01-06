internal class CapturePass : ScriptableRenderPass // TypeDefIndex: 8938
{
	// Fields
	private RTHandle m_CameraColorHandle; // 0xE0
	private const string m_ProfilerTag = "Capture Pass";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0

	// Methods

	// RVA: 0x2AFD9B0 Offset: 0x2AFC3B0 VA: 0x182AFD9B0
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2AFD5C0 Offset: 0x2AFBFC0 VA: 0x182AFD5C0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AFD920 Offset: 0x2AFC320 VA: 0x182AFD920
	private static void .cctor() { }
}
