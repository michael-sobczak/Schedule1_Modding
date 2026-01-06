public sealed class ShaderDebugPrintManager // TypeDefIndex: 13702
{
	// Fields
	private static readonly ShaderDebugPrintManager s_Instance; // 0x0
	private const int k_DebugUAVSlot = 7;
	private const int k_FramesInFlight = 4;
	private const int k_MaxBufferElements = 16384;
	private List<GraphicsBuffer> m_OutputBuffers; // 0x10
	private List<AsyncGPUReadbackRequest> m_ReadbackRequests; // 0x18
	private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction; // 0x20
	private int m_FrameCounter; // 0x28
	private bool m_FrameCleared; // 0x2C
	private string m_OutputLine; // 0x30
	private Action<string> m_OutputAction; // 0x38
	private static readonly int m_ShaderPropertyIDInputMouse; // 0x8
	private static readonly int m_ShaderPropertyIDInputFrame; // 0xC
	private const uint k_TypeHasTag = 128;

	// Properties
	public static ShaderDebugPrintManager instance { get; }
	public string outputLine { get; }
	public Action<string> outputAction { set; }

	// Methods

	// RVA: 0x2A14730 Offset: 0x2A13130 VA: 0x182A14730
	private int DebugValueTypeToElemSize(ShaderDebugPrintManager.DebugValueType type) { }

	// RVA: 0x2A14C60 Offset: 0x2A13660 VA: 0x182A14C60
	private void .ctor() { }

	// RVA: 0x2A14F60 Offset: 0x2A13960 VA: 0x182A14F60
	public static ShaderDebugPrintManager get_instance() { }

	// RVA: 0x2A14AA0 Offset: 0x2A134A0 VA: 0x182A14AA0
	public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input) { }

	// RVA: 0x2A148B0 Offset: 0x2A132B0 VA: 0x182A148B0
	public void SetShaderDebugPrintBindings(CommandBuffer cmd) { }

	// RVA: 0x2A14630 Offset: 0x2A13030 VA: 0x182A14630
	private void ClearShaderDebugPrintBuffer() { }

	// RVA: 0x2A13860 Offset: 0x2A12260 VA: 0x182A13860
	private void BufferReadComplete(AsyncGPUReadbackRequest request) { }

	// RVA: 0x2A147F0 Offset: 0x2A131F0 VA: 0x182A147F0
	public void EndFrame() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_outputLine() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_outputAction(Action<string> value) { }

	// RVA: 0x2A147A0 Offset: 0x2A131A0 VA: 0x182A147A0
	public void DefaultOutput(string line) { }

	// RVA: 0x2A14BA0 Offset: 0x2A135A0 VA: 0x182A14BA0
	private static void .cctor() { }
}
