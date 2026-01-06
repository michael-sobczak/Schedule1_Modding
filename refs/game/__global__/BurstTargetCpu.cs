internal enum BurstTargetCpu // TypeDefIndex: 16292
{
	// Fields
	public int value__; // 0x0
	public const BurstTargetCpu Auto = 0;
	public const BurstTargetCpu X86_SSE2 = 1;
	public const BurstTargetCpu X86_SSE4 = 2;
	public const BurstTargetCpu X64_SSE2 = 3;
	public const BurstTargetCpu X64_SSE4 = 4;
	public const BurstTargetCpu AVX = 5;
	public const BurstTargetCpu AVX2 = 6;
	public const BurstTargetCpu WASM32 = 7;
	public const BurstTargetCpu ARMV7A_NEON32 = 8;
	public const BurstTargetCpu ARMV8A_AARCH64 = 9;
	public const BurstTargetCpu THUMB2_NEON32 = 10;
	public const BurstTargetCpu ARMV8A_AARCH64_HALFFP = 11;
	public const BurstTargetCpu ARMV9A = 12;
}
