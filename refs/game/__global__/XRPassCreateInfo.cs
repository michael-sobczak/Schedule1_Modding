public struct XRPassCreateInfo // TypeDefIndex: 13496
{
	// Fields
	internal RenderTargetIdentifier renderTarget; // 0x0
	internal RenderTextureDescriptor renderTargetDesc; // 0x28
	internal ScriptableCullingParameters cullingParameters; // 0x60
	internal Material occlusionMeshMaterial; // 0x690
	internal float occlusionMeshScale; // 0x698
	internal IntPtr foveatedRenderingInfo; // 0x6A0
	internal int multipassId; // 0x6A8
	internal int cullingPassId; // 0x6AC
	internal bool copyDepth; // 0x6B0
	internal XRDisplaySubsystem.XRRenderPass xrSdkRenderPass; // 0x6B8
}
