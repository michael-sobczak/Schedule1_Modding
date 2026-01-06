internal sealed class RenderTargetBufferSystem // TypeDefIndex: 9164
{
	// Fields
	private RenderTargetBufferSystem.SwapBuffer m_A; // 0x10
	private RenderTargetBufferSystem.SwapBuffer m_B; // 0x30
	private static bool m_AisBackBuffer; // 0x0
	private static RenderTextureDescriptor m_Desc; // 0x4
	private FilterMode m_FilterMode; // 0x50
	private bool m_AllowMSAA; // 0x54

	// Properties
	private RenderTargetBufferSystem.SwapBuffer backBuffer { get; }
	private RenderTargetBufferSystem.SwapBuffer frontBuffer { get; }

	// Methods

	// RVA: 0x2B7CA30 Offset: 0x2B7B430 VA: 0x182B7CA30
	private ref RenderTargetBufferSystem.SwapBuffer get_backBuffer() { }

	// RVA: 0x2B7CAA0 Offset: 0x2B7B4A0 VA: 0x182B7CAA0
	private ref RenderTargetBufferSystem.SwapBuffer get_frontBuffer() { }

	// RVA: 0x2B7C990 Offset: 0x2B7B390 VA: 0x182B7C990
	public void .ctor(string name) { }

	// RVA: 0x2B7BF80 Offset: 0x2B7A980 VA: 0x182B7BF80
	public void Dispose() { }

	// RVA: 0x2B7C3B0 Offset: 0x2B7ADB0 VA: 0x182B7C3B0
	public RTHandle PeekBackBuffer() { }

	// RVA: 0x2B7C060 Offset: 0x2B7AA60 VA: 0x182B7C060
	public RTHandle GetBackBuffer(CommandBuffer cmd) { }

	// RVA: 0x2B7C1B0 Offset: 0x2B7ABB0 VA: 0x182B7C1B0
	public RTHandle GetFrontBuffer(CommandBuffer cmd) { }

	// RVA: 0x2B7C8F0 Offset: 0x2B7B2F0 VA: 0x182B7C8F0
	public void Swap() { }

	// RVA: 0x2B7C4E0 Offset: 0x2B7AEE0 VA: 0x182B7C4E0
	private void ReAllocate(CommandBuffer cmd) { }

	// RVA: 0x2B7BF10 Offset: 0x2B7A910 VA: 0x182B7BF10
	public void Clear() { }

	// RVA: 0x2B7C790 Offset: 0x2B7B190 VA: 0x182B7C790
	public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode) { }

	// RVA: 0x2B7C190 Offset: 0x2B7AB90 VA: 0x182B7C190
	public RTHandle GetBufferA() { }

	// RVA: 0x2B7BFE0 Offset: 0x2B7A9E0 VA: 0x182B7BFE0
	public void EnableMSAA(bool enable) { }

	// RVA: 0x2B7C950 Offset: 0x2B7B350 VA: 0x182B7C950
	private static void .cctor() { }
}
