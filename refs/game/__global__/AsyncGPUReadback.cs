public static class AsyncGPUReadback // TypeDefIndex: 12157
{
	// Methods

	// RVA: 0x2CD4940 Offset: 0x2CD3340 VA: 0x182CD4940
	internal static void ValidateFormat(Texture src, GraphicsFormat dstformat) { }

	// RVA: 0x2CD46D0 Offset: 0x2CD30D0 VA: 0x182CD46D0
	public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x2CD4770 Offset: 0x2CD3170 VA: 0x182CD4770
	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x2CD4550 Offset: 0x2CD2F50 VA: 0x182CD4550
	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[NativeMethod("Request")]
	// RVA: 0x2CD4410 Offset: 0x2CD2E10 VA: 0x182CD4410
	private static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data) { }

	[NativeMethod("Request")]
	// RVA: 0x2CD44D0 Offset: 0x2CD2ED0 VA: 0x182CD44D0
	private static AsyncGPUReadbackRequest Request_Internal_Texture_2(Texture src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data) { }

	// RVA: 0x2CD43B0 Offset: 0x2CD2DB0 VA: 0x182CD43B0
	private static void Request_Internal_GraphicsBuffer_1_Injected(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) { }

	// RVA: 0x2CD4470 Offset: 0x2CD2E70 VA: 0x182CD4470
	private static void Request_Internal_Texture_2_Injected(Texture src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) { }
}
