public class CommandBuffer : IDisposable // TypeDefIndex: 12210
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { set; }

	// Methods

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	// RVA: 0x2CDB020 Offset: 0x2CD9A20 VA: 0x182CDB020
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	// RVA: 0x2CDA9B0 Offset: 0x2CD93B0 VA: 0x182CDA9B0
	private static IntPtr InitBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = True)]
	// RVA: 0x2CD8D20 Offset: 0x2CD7720 VA: 0x182CD8D20
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = True)]
	// RVA: 0x2CDDF30 Offset: 0x2CDC930 VA: 0x182CDDF30
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2CDB0B0 Offset: 0x2CD9AB0 VA: 0x182CDB0B0
	private void ReleaseBuffer() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = True)]
	// RVA: 0x2CDB3A0 Offset: 0x2CD9DA0 VA: 0x182CDB3A0
	public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	// RVA: 0x2CDB670 Offset: 0x2CDA070 VA: 0x182CDB670
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = True)]
	// RVA: 0x2CDB590 Offset: 0x2CD9F90 VA: 0x182CDB590
	public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = True)]
	// RVA: 0x2CDAF40 Offset: 0x2CD9940 VA: 0x182CDAF40
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	// RVA: 0x2CDAFB0 Offset: 0x2CD99B0 VA: 0x182CDAFB0
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	// RVA: 0x2CDAE60 Offset: 0x2CD9860 VA: 0x182CDAE60
	private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	// RVA: 0x2CDAED0 Offset: 0x2CD98D0 VA: 0x182CDAED0
	private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CD8EF0 Offset: 0x2CD78F0 VA: 0x182CD8EF0
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x2CDDFD0 Offset: 0x2CDC9D0 VA: 0x182CDDFD0
	public void set_name(string value) { }

	[NativeMethod("ClearCommands")]
	// RVA: 0x2CD89D0 Offset: 0x2CD73D0 VA: 0x182CD89D0
	public void Clear() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	// RVA: 0x2CDAB30 Offset: 0x2CD9530 VA: 0x182CDAB30
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethod("AddDrawRenderer")]
	// RVA: 0x2CDADF0 Offset: 0x2CD97F0 VA: 0x182CDADF0
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[NativeMethod("AddDrawRendererList")]
	// RVA: 0x2CDADA0 Offset: 0x2CD97A0 VA: 0x182CDADA0
	private void Internal_DrawRendererList(RendererList rendererList) { }

	[NativeMethod("AddDrawProcedural")]
	// RVA: 0x2CDACC0 Offset: 0x2CD96C0 VA: 0x182CDACC0
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = True)]
	// RVA: 0x2CDAA50 Offset: 0x2CD9450 VA: 0x182CDAA50
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = True)]
	// RVA: 0x2CDAC00 Offset: 0x2CD9600 VA: 0x182CDAC00
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDC350 Offset: 0x2CDAD50 VA: 0x182CDC350
	private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDC2E0 Offset: 0x2CDACE0 VA: 0x182CDC2E0
	private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CD8740 Offset: 0x2CD7140 VA: 0x182CD8740
	public void ClearRandomWriteTargets() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDDA50 Offset: 0x2CDC450 VA: 0x182CDDA50
	public void SetViewport(Rect pixelRect) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CD8E60 Offset: 0x2CD7860 VA: 0x182CD8E60
	public void DisableScissorRect() { }

	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = True)]
	// RVA: 0x2CD8A60 Offset: 0x2CD7460 VA: 0x182CD8A60
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = True)]
	// RVA: 0x2CD8300 Offset: 0x2CD6D00 VA: 0x182CD8300
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = True)]
	// RVA: 0x2CD81F0 Offset: 0x2CD6BF0 VA: 0x182CD81F0
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = True)]
	// RVA: 0x2CDA710 Offset: 0x2CD9110 VA: 0x182CDA710
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x2CDA470 Offset: 0x2CD8E70 VA: 0x182CDA470
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x2CDA060 Offset: 0x2CD8A60 VA: 0x182CDA060
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x2CDA570 Offset: 0x2CD8F70 VA: 0x182CDA570
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x2CDA110 Offset: 0x2CD8B10 VA: 0x182CDA110
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x2CDA610 Offset: 0x2CD9010 VA: 0x182CDA610
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x2CDA810 Offset: 0x2CD9210 VA: 0x182CDA810
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x2CDA380 Offset: 0x2CD8D80 VA: 0x182CDA380
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x2CDA290 Offset: 0x2CD8C90 VA: 0x182CDA290
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2CDA910 Offset: 0x2CD9310 VA: 0x182CDA910
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x2CDA7A0 Offset: 0x2CD91A0 VA: 0x182CDA7A0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = True)]
	// RVA: 0x2CDA000 Offset: 0x2CD8A00 VA: 0x182CDA000
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2CDA4F0 Offset: 0x2CD8EF0 VA: 0x182CDA4F0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2CDA220 Offset: 0x2CD8C20 VA: 0x182CDA220
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = True)]
	// RVA: 0x2CDB0F0 Offset: 0x2CD9AF0 VA: 0x182CDB0F0
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = True)]
	// RVA: 0x2CD8960 Offset: 0x2CD7360 VA: 0x182CD8960
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	// RVA: 0x2CD87E0 Offset: 0x2CD71E0 VA: 0x182CD87E0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x2CD88A0 Offset: 0x2CD72A0 VA: 0x182CD88A0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	// RVA: 0x2CDBB20 Offset: 0x2CDA520 VA: 0x182CDBB20
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = True)]
	// RVA: 0x2CDBB70 Offset: 0x2CDA570 VA: 0x182CDBB70
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = True)]
	// RVA: 0x2CDBBC0 Offset: 0x2CDA5C0 VA: 0x182CDBBC0
	public void SetGlobalInteger(int nameID, int value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	// RVA: 0x2CDC0B0 Offset: 0x2CDAAB0 VA: 0x182CDC0B0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = True)]
	// RVA: 0x2CDB8D0 Offset: 0x2CDA2D0 VA: 0x182CDB8D0
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = True)]
	// RVA: 0x2CDBD10 Offset: 0x2CDA710 VA: 0x182CDBD10
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	// RVA: 0x2CD9E30 Offset: 0x2CD8830 VA: 0x182CD9E30
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	// RVA: 0x2CD8EA0 Offset: 0x2CD78A0 VA: 0x182CD8EA0
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = True)]
	// RVA: 0x2CDC270 Offset: 0x2CDAC70 VA: 0x182CDC270
	private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value) { }

	// RVA: 0x2CDC140 Offset: 0x2CDAB40 VA: 0x182CDC140
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDD9A0 Offset: 0x2CDC3A0 VA: 0x182CDD9A0
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[NativeMethod("AddSetGlobalDepthBias")]
	// RVA: 0x2CDBA70 Offset: 0x2CDA470 VA: 0x182CDBA70
	public void SetGlobalDepthBias(float bias, float slopeBias) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDB760 Offset: 0x2CDA160 VA: 0x182CDB760
	public void SetExecutionFlags(CommandBufferExecutionFlags flags) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDDAE0 Offset: 0x2CDC4E0 VA: 0x182CDDAE0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDBAD0 Offset: 0x2CDA4D0 VA: 0x182CDBAD0
	public void SetGlobalFloatArray(int nameID, float[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDBFA0 Offset: 0x2CDA9A0 VA: 0x182CDBFA0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDBC70 Offset: 0x2CDA670 VA: 0x182CDBC70
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDC1B0 Offset: 0x2CDABB0 VA: 0x182CDC1B0
	public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = True)]
	// RVA: 0x2CDB060 Offset: 0x2CD9A60 VA: 0x182CDB060
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = True)]
	// RVA: 0x2CDDAA0 Offset: 0x2CDC4A0 VA: 0x182CDDAA0
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	// RVA: 0x2CDBDF0 Offset: 0x2CDA7F0 VA: 0x182CDBDF0
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	// RVA: 0x2CDB7E0 Offset: 0x2CDA1E0 VA: 0x182CDB7E0
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	// RVA: 0x2CDB830 Offset: 0x2CDA230 VA: 0x182CDB830
	private void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	// RVA: 0x2CD8130 Offset: 0x2CD6B30 VA: 0x182CD8130
	public void BeginSample(string name) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	// RVA: 0x2CD9ED0 Offset: 0x2CD88D0 VA: 0x182CD9ED0
	public void EndSample(string name) { }

	// RVA: 0x2CD80E0 Offset: 0x2CD6AE0 VA: 0x182CD80E0
	public void BeginSample(CustomSampler sampler) { }

	// RVA: 0x2CD9E80 Offset: 0x2CD8880 VA: 0x182CD9E80
	public void EndSample(CustomSampler sampler) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = True)]
	// RVA: 0x2CD80E0 Offset: 0x2CD6AE0 VA: 0x182CD80E0
	private void BeginSample_CustomSampler(CustomSampler sampler) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = True)]
	// RVA: 0x2CD9E80 Offset: 0x2CD8880 VA: 0x182CD9E80
	private void EndSample_CustomSampler(CustomSampler sampler) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	// RVA: 0x2CDB920 Offset: 0x2CDA320 VA: 0x182CDB920
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	// RVA: 0x2CDBA00 Offset: 0x2CDA400 VA: 0x182CDBA00
	private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = True)]
	// RVA: 0x2CDC100 Offset: 0x2CDAB00 VA: 0x182CDC100
	public void SetInstanceMultiplier(uint multiplier) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = True)]
	// RVA: 0x2CDB7A0 Offset: 0x2CDA1A0 VA: 0x182CDB7A0
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = True)]
	// RVA: 0x2CD8A10 Offset: 0x2CD7410 VA: 0x182CD8A10
	public void ConfigureFoveatedRendering(IntPtr platformData) { }

	// RVA: 0x2CDCE30 Offset: 0x2CDB830 VA: 0x182CDCE30
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x2CDD2C0 Offset: 0x2CDBCC0 VA: 0x182CDD2C0
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x2CDC940 Offset: 0x2CDB340 VA: 0x182CDC940
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2CDCED0 Offset: 0x2CDB8D0 VA: 0x182CDCED0
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	// RVA: 0x2CDD080 Offset: 0x2CDBA80 VA: 0x182CDD080
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2CDD640 Offset: 0x2CDC040 VA: 0x182CDD640
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x2CDD3D0 Offset: 0x2CDBDD0 VA: 0x182CDD3D0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2CDCCC0 Offset: 0x2CDB6C0 VA: 0x182CDCCC0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2CDD720 Offset: 0x2CDC120 VA: 0x182CDD720
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x2CDCA70 Offset: 0x2CDB470 VA: 0x182CDCA70
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2CDC8C0 Offset: 0x2CDB2C0 VA: 0x182CDC8C0
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2CDC5A0 Offset: 0x2CDAFA0 VA: 0x182CDC5A0
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2CDC7C0 Offset: 0x2CDB1C0 VA: 0x182CDC7C0
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2CDC6A0 Offset: 0x2CDB0A0 VA: 0x182CDC6A0
	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x2CDB130 Offset: 0x2CD9B30 VA: 0x182CDB130
	public void SetBufferData(ComputeBuffer buffer, Array data) { }

	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CDA9E0 Offset: 0x2CD93E0 VA: 0x182CDA9E0
	private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2CD9F20 Offset: 0x2CD8920 VA: 0x182CD9F20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2CD8F60 Offset: 0x2CD7960 VA: 0x182CD8F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x2CD8FE0 Offset: 0x2CD79E0 VA: 0x182CD8FE0
	private void Dispose(bool disposing) { }

	// RVA: 0x2CDDF90 Offset: 0x2CDC990 VA: 0x182CDDF90
	public void .ctor() { }

	// RVA: 0x2CD8F60 Offset: 0x2CD7960 VA: 0x182CD8F60
	public void Release() { }

	// RVA: 0x2CD8C40 Offset: 0x2CD7640 VA: 0x182CD8C40
	public GraphicsFence CreateAsyncGraphicsFence() { }

	// RVA: 0x2CD8D70 Offset: 0x2CD7770 VA: 0x182CD8D70
	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	// RVA: 0x2CDDB30 Offset: 0x2CDC530 VA: 0x182CDDB30
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence) { }

	// RVA: 0x2CDDCB0 Offset: 0x2CDC6B0 VA: 0x182CDDCB0
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage) { }

	// RVA: 0x2CDDE40 Offset: 0x2CDC840 VA: 0x182CDDE40
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) { }

	// RVA: 0x2CDB410 Offset: 0x2CD9E10 VA: 0x182CDB410
	public void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	// RVA: 0x2CDB6E0 Offset: 0x2CDA0E0 VA: 0x182CDB6E0
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x2CDB330 Offset: 0x2CD9D30 VA: 0x182CDB330
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x2CDB500 Offset: 0x2CD9F00 VA: 0x182CDB500
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x2CDB480 Offset: 0x2CD9E80 VA: 0x182CDB480
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	// RVA: 0x2CDB2C0 Offset: 0x2CD9CC0 VA: 0x182CDB2C0
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x2CDAED0 Offset: 0x2CD98D0 VA: 0x182CDAED0
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	// RVA: 0x2CD8EF0 Offset: 0x2CD78F0 VA: 0x182CD8EF0
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x2CD9590 Offset: 0x2CD7F90 VA: 0x182CD9590
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD94C0 Offset: 0x2CD7EC0 VA: 0x182CD94C0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD9460 Offset: 0x2CD7E60 VA: 0x182CD9460
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD9530 Offset: 0x2CD7F30 VA: 0x182CD9530
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x2CD9BE0 Offset: 0x2CD85E0 VA: 0x182CD9BE0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD9DE0 Offset: 0x2CD87E0 VA: 0x182CD9DE0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD9E00 Offset: 0x2CD8800 VA: 0x182CD9E00
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x2CD9B90 Offset: 0x2CD8590 VA: 0x182CD9B90
	public void DrawRendererList(RendererList rendererList) { }

	// RVA: 0x2CD9A10 Offset: 0x2CD8410 VA: 0x182CD9A10
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	// RVA: 0x2CD9890 Offset: 0x2CD8290 VA: 0x182CD9890
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	// RVA: 0x2CD9060 Offset: 0x2CD7A60 VA: 0x182CD9060
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x2CD9020 Offset: 0x2CD7A20 VA: 0x182CD9020
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	// RVA: 0x2CD9850 Offset: 0x2CD8250 VA: 0x182CD9850
	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	// RVA: 0x2CDC420 Offset: 0x2CDAE20 VA: 0x182CDC420
	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	// RVA: 0x2CDC4A0 Offset: 0x2CDAEA0 VA: 0x182CDC4A0
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	// RVA: 0x2CDC3A0 Offset: 0x2CDADA0 VA: 0x182CDC3A0
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	// RVA: 0x2CD8AD0 Offset: 0x2CD74D0 VA: 0x182CD8AD0
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x2CD8B80 Offset: 0x2CD7580 VA: 0x182CD8B80
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x2CD8580 Offset: 0x2CD6F80 VA: 0x182CD8580
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x2CD83A0 Offset: 0x2CD6DA0 VA: 0x182CD83A0
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x2CD8660 Offset: 0x2CD7060 VA: 0x182CD8660
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x2CD8490 Offset: 0x2CD6E90 VA: 0x182CD8490
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x2CDC040 Offset: 0x2CDAA40 VA: 0x182CDC040
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x2CDBD60 Offset: 0x2CDA760 VA: 0x182CDBD60
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x2CDBC10 Offset: 0x2CDA610 VA: 0x182CDBC10
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x2CDBF10 Offset: 0x2CDA910 VA: 0x182CDBF10
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x2CDBEB0 Offset: 0x2CDA8B0 VA: 0x182CDBEB0
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x2CDBE50 Offset: 0x2CDA850 VA: 0x182CDBE50
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x2CDB7E0 Offset: 0x2CDA1E0 VA: 0x182CDB7E0
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2CDB830 Offset: 0x2CDA230 VA: 0x182CDB830
	public void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	// RVA: 0x2CDB920 Offset: 0x2CDA320 VA: 0x182CDB920
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	// RVA: 0x2CDB990 Offset: 0x2CDA390 VA: 0x182CDB990
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	// RVA: 0x2CDB020 Offset: 0x2CD9A20 VA: 0x182CDB020
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x2CDB600 Offset: 0x2CDA000 VA: 0x182CDB600
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x2CDAAC0 Offset: 0x2CD94C0 VA: 0x182CDAAC0
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x2CDAD50 Offset: 0x2CD9750 VA: 0x182CDAD50
	private void Internal_DrawRendererList_Injected(ref RendererList rendererList) { }

	// RVA: 0x2CDAC50 Offset: 0x2CD9650 VA: 0x182CDAC50
	private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	// RVA: 0x2CDABB0 Offset: 0x2CD95B0 VA: 0x182CDABB0
	private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport) { }

	// RVA: 0x2CDDA00 Offset: 0x2CDC400 VA: 0x182CDDA00
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x2CD8290 Offset: 0x2CD6C90 VA: 0x182CD8290
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x2CD8180 Offset: 0x2CD6B80 VA: 0x182CD8180
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x2CD9FA0 Offset: 0x2CD89A0 VA: 0x182CD9FA0
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x2CD8780 Offset: 0x2CD7180 VA: 0x182CD8780
	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil) { }

	// RVA: 0x2CDBFF0 Offset: 0x2CDA9F0 VA: 0x182CDBFF0
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x2CDB880 Offset: 0x2CDA280 VA: 0x182CDB880
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x2CDBCC0 Offset: 0x2CDA6C0 VA: 0x182CDBCC0
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x2CDC200 Offset: 0x2CDAC00 VA: 0x182CDC200
	private void SetMaterialKeyword_Injected(Material material, ref LocalKeyword keyword, bool value) { }

	// RVA: 0x2CDD940 Offset: 0x2CDC340 VA: 0x182CDD940
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x2CDC850 Offset: 0x2CDB250 VA: 0x182CDC850
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x2CDC530 Offset: 0x2CDAF30 VA: 0x182CDC530
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2CDC750 Offset: 0x2CDB150 VA: 0x182CDC750
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x2CDC630 Offset: 0x2CDB030 VA: 0x182CDC630
	private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }
}
