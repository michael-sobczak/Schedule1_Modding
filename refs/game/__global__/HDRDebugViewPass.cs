internal class HDRDebugViewPass : ScriptableRenderPass // TypeDefIndex: 8948
{
	// Fields
	private HDRDebugViewPass.PassData m_PassData; // 0xE0
	private RTHandle m_CIExyTarget; // 0xE8
	private RTHandle m_PassthroughRT; // 0xF0
	private RTHandle m_CameraTargetHandle; // 0xF8

	// Methods

	// RVA: 0x2B026B0 Offset: 0x2B010B0 VA: 0x182B026B0
	public void .ctor(Material mat) { }

	// RVA: 0x2B01620 Offset: 0x2B00020 VA: 0x182B01620
	public static void ConfigureDescriptor(ref RenderTextureDescriptor descriptor) { }

	// RVA: 0x2B01590 Offset: 0x2AFFF90 VA: 0x182B01590
	public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor) { }

	// RVA: 0x2B02340 Offset: 0x2B00D40 VA: 0x182B02340
	internal static Vector4 GetLuminanceParameters(ref CameraData cameraData) { }

	// RVA: 0x2B016B0 Offset: 0x2B000B0 VA: 0x182B016B0
	private static void ExecuteCIExyPrepass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture) { }

	// RVA: 0x2B01AA0 Offset: 0x2B004A0 VA: 0x182B01AA0
	private static void ExecuteHDRDebugViewFinalPass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget) { }

	// RVA: 0x2B01660 Offset: 0x2B00060 VA: 0x182B01660
	public void Dispose() { }

	// RVA: 0x2B024A0 Offset: 0x2B00EA0 VA: 0x182B024A0
	public void Setup(ref CameraData cameraData, HDRDebugMode hdrdebugMode) { }

	// RVA: 0x2B01E40 Offset: 0x2B00840 VA: 0x182B01E40 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B01D90 Offset: 0x2B00790 VA: 0x182B01D90
	private void ExecutePass(CommandBuffer cmd, HDRDebugViewPass.PassData data, RTHandle sourceTexture, RTHandle xyTarget) { }
}
