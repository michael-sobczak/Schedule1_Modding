public static class CommandBufferPool // TypeDefIndex: 13555
{
	// Fields
	private static ObjectPool<CommandBuffer> s_BufferPool; // 0x0

	// Methods

	// RVA: 0x29E5DA0 Offset: 0x29E47A0 VA: 0x1829E5DA0
	public static CommandBuffer Get() { }

	// RVA: 0x29E5E50 Offset: 0x29E4850 VA: 0x1829E5E50
	public static CommandBuffer Get(string name) { }

	// RVA: 0x29E5EF0 Offset: 0x29E48F0 VA: 0x1829E5EF0
	public static void Release(CommandBuffer buffer) { }

	// RVA: 0x29E5F70 Offset: 0x29E4970 VA: 0x1829E5F70
	private static void .cctor() { }
}
