internal struct NudgeJobData // TypeDefIndex: 7100
{
	// Fields
	public IntPtr src; // 0x0
	public IntPtr dst; // 0x8
	public int count; // 0x10
	public IntPtr closingSrc; // 0x18
	public IntPtr closingDst; // 0x20
	public int closingCount; // 0x28
	public Matrix4x4 transform; // 0x2C
	public int vertsBeforeUVDisplacement; // 0x6C
	public int vertsAfterUVDisplacement; // 0x70
}
