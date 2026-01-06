public static class Blitter // TypeDefIndex: 13846
{
	// Fields
	private static Material s_Blit; // 0x0
	private static Material s_BlitTexArray; // 0x8
	private static Material s_BlitTexArraySingleSlice; // 0x10
	private static Material s_BlitColorAndDepth; // 0x18
	private static MaterialPropertyBlock s_PropertyBlock; // 0x20
	private static Mesh s_TriangleMesh; // 0x28
	private static Mesh s_QuadMesh; // 0x30
	private static LocalKeyword s_DecodeHdrKeyword; // 0x38

	// Methods

	// RVA: 0x2A373B0 Offset: 0x2A35DB0 VA: 0x182A373B0
	public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS) { }

	// RVA: 0x2A36C70 Offset: 0x2A35670 VA: 0x182A36C70
	public static void Cleanup() { }

	// RVA: 0x2A372E0 Offset: 0x2A35CE0 VA: 0x182A372E0
	public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = False) { }

	// RVA: 0x2A370B0 Offset: 0x2A35AB0 VA: 0x182A370B0
	private static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass) { }

	// RVA: 0x2A36E70 Offset: 0x2A35870 VA: 0x182A36E70
	internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass) { }

	// RVA: 0x2A36A60 Offset: 0x2A35460 VA: 0x182A36A60
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	// RVA: 0x2A36170 Offset: 0x2A34B70 VA: 0x182A36170
	public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	// RVA: 0x2A34370 Offset: 0x2A32D70 VA: 0x182A34370
	public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth) { }

	// RVA: 0x2A364D0 Offset: 0x2A34ED0 VA: 0x182A364D0
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x2A36610 Offset: 0x2A35010 VA: 0x182A36610
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x2A362E0 Offset: 0x2A34CE0 VA: 0x182A362E0
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass) { }

	// RVA: 0x2A36770 Offset: 0x2A35170 VA: 0x182A36770
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	// RVA: 0x2A36970 Offset: 0x2A35370 VA: 0x182A36970
	public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass) { }

	// RVA: 0x2A339B0 Offset: 0x2A323B0 VA: 0x182A339B0
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x2A33700 Offset: 0x2A32100 VA: 0x182A33700
	public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x2A341B0 Offset: 0x2A32BB0 VA: 0x182A341B0
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) { }

	// RVA: 0x2A33E40 Offset: 0x2A32840 VA: 0x182A33E40
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	// RVA: 0x2A33D50 Offset: 0x2A32750 VA: 0x182A33D50
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x2A33B70 Offset: 0x2A32570 VA: 0x182A33B70
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0, bool bilinear = False) { }

	// RVA: 0x2A35F20 Offset: 0x2A34920 VA: 0x182A35F20
	public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) { }

	// RVA: 0x2A35B60 Offset: 0x2A34560 VA: 0x182A35B60
	public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x2A357A0 Offset: 0x2A341A0 VA: 0x182A357A0
	public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x2A351C0 Offset: 0x2A33BC0 VA: 0x182A351C0
	public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x2A34EE0 Offset: 0x2A338E0 VA: 0x182A34EE0
	public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	// RVA: 0x2A34CA0 Offset: 0x2A336A0 VA: 0x182A34CA0
	public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x2A34890 Offset: 0x2A33290 VA: 0x182A34890
	public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Nullable<Vector4> decodeInstructions) { }

	// RVA: 0x2A34590 Offset: 0x2A32F90 VA: 0x182A34590
	public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x2A354A0 Offset: 0x2A33EA0 VA: 0x182A354A0
	public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex) { }

	// RVA: 0x2A38090 Offset: 0x2A36A90 VA: 0x182A38090
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2A37E10 Offset: 0x2A36810 VA: 0x182A37E10
	internal static Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|9_0(float z) { }

	[CompilerGenerated]
	// RVA: 0x2A37D00 Offset: 0x2A36700 VA: 0x182A37D00
	internal static Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|9_1() { }

	[CompilerGenerated]
	// RVA: 0x2A37FD0 Offset: 0x2A369D0 VA: 0x182A37FD0
	internal static Vector3[] <Initialize>g__GetQuadVertexPosition|9_2(float z) { }

	[CompilerGenerated]
	// RVA: 0x2A37EE0 Offset: 0x2A368E0 VA: 0x182A37EE0
	internal static Vector2[] <Initialize>g__GetQuadTexCoord|9_3() { }
}
