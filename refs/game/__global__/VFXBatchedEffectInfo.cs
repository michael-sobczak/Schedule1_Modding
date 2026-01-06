public struct VFXBatchedEffectInfo // TypeDefIndex: 19115
{
	// Fields
	public VisualEffectAsset vfxAsset; // 0x0
	public uint activeBatchCount; // 0x8
	public uint inactiveBatchCount; // 0xC
	public uint activeInstanceCount; // 0x10
	public uint unbatchedInstanceCount; // 0x14
	public uint totalInstanceCapacity; // 0x18
	public uint maxInstancePerBatchCapacity; // 0x1C
	public ulong totalGPUSizeInBytes; // 0x20
	public ulong totalCPUSizeInBytes; // 0x28
}
