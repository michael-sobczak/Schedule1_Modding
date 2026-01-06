public static class CommandBufferExtensions // TypeDefIndex: 12211
{
	// Methods

	[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchIntoFastMemory")]
	// RVA: 0x2CD7F40 Offset: 0x2CD6940 VA: 0x182CD7F40
	private static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchOutOfFastMemory")]
	// RVA: 0x2CD7FB0 Offset: 0x2CD69B0 VA: 0x182CD7FB0
	private static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents) { }

	[Extension]
	[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
	// RVA: 0x2CD8010 Offset: 0x2CD6A10 VA: 0x182CD8010
	public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) { }

	[Extension]
	[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
	// RVA: 0x2CD8080 Offset: 0x2CD6A80 VA: 0x182CD8080
	public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents) { }
}
