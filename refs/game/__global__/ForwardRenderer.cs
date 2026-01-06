public sealed class ForwardRenderer : ScriptableRenderer // TypeDefIndex: 8862
{
	// Fields
	private static readonly string k_ErrorMessage; // 0x0

	// Methods

	// RVA: 0x2AE88D0 Offset: 0x2AE72D0 VA: 0x182AE88D0
	public void .ctor(ForwardRendererData data) { }

	// RVA: 0x2AE8760 Offset: 0x2AE7160 VA: 0x182AE8760 Slot: 10
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AE86E0 Offset: 0x2AE70E0 VA: 0x182AE86E0 Slot: 11
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AE8660 Offset: 0x2AE7060 VA: 0x182AE8660 Slot: 12
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x2AE85A0 Offset: 0x2AE6FA0 VA: 0x182AE85A0 Slot: 13
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x2AE87E0 Offset: 0x2AE71E0 VA: 0x182AE87E0 Slot: 16
	internal override void SwapColorBuffer(CommandBuffer cmd) { }

	// RVA: 0x2AE8620 Offset: 0x2AE7020 VA: 0x182AE8620 Slot: 6
	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd) { }

	// RVA: 0x2AE8860 Offset: 0x2AE7260 VA: 0x182AE8860
	private static void .cctor() { }
}
