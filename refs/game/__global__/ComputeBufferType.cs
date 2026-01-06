public enum ComputeBufferType // TypeDefIndex: 11683
{
	// Fields
	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[Obsolete("Enum member DrawIndirect has been deprecated. Use IndirectArguments instead (UnityUpgradable) -> IndirectArguments", False)]
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[Obsolete("Enum member GPUMemory has been deprecated. All compute buffers now follow the behavior previously defined by this member.", False)]
	public const ComputeBufferType GPUMemory = 512;
}
