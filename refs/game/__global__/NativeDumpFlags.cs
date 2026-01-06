internal enum NativeDumpFlags // TypeDefIndex: 16293
{
	// Fields
	public int value__; // 0x0
	public const NativeDumpFlags None = 0;
	public const NativeDumpFlags IL = 1;
	public const NativeDumpFlags Unused = 2;
	public const NativeDumpFlags IR = 4;
	public const NativeDumpFlags IROptimized = 8;
	public const NativeDumpFlags Asm = 16;
	public const NativeDumpFlags Function = 32;
	public const NativeDumpFlags Analysis = 64;
	public const NativeDumpFlags IRPassAnalysis = 128;
	public const NativeDumpFlags ILPre = 256;
	public const NativeDumpFlags IRPerEntryPoint = 512;
	public const NativeDumpFlags All = 1021;
}
