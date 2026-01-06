public struct FrameTiming // TypeDefIndex: 11651
{
	// Fields
	[NativeName("totalFrameTime")]
	public double cpuFrameTime; // 0x0
	[NativeName("mainThreadActiveTime")]
	public double cpuMainThreadFrameTime; // 0x8
	[NativeName("mainThreadPresentWaitTime")]
	public double cpuMainThreadPresentWaitTime; // 0x10
	[NativeName("renderThreadActiveTime")]
	public double cpuRenderThreadFrameTime; // 0x18
	[NativeName("gpuFrameTime")]
	public double gpuFrameTime; // 0x20
	[NativeName("frameStartTimestamp")]
	public ulong frameStartTimestamp; // 0x28
	[NativeName("firstSubmitTimestamp")]
	public ulong firstSubmitTimestamp; // 0x30
	[NativeName("presentFrameTimestamp")]
	public ulong cpuTimePresentCalled; // 0x38
	[NativeName("frameCompleteTimestamp")]
	public ulong cpuTimeFrameComplete; // 0x40
	[NativeName("heightScale")]
	public float heightScale; // 0x48
	[NativeName("widthScale")]
	public float widthScale; // 0x4C
	[NativeName("syncInterval")]
	public uint syncInterval; // 0x50
}
