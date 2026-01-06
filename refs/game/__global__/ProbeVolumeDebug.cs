internal class ProbeVolumeDebug : IDebugData // TypeDefIndex: 13743
{
	// Fields
	public bool drawProbes; // 0x10
	public bool drawBricks; // 0x11
	public bool drawCells; // 0x12
	public bool realtimeSubdivision; // 0x13
	public int subdivisionCellUpdatePerFrame; // 0x14
	public float subdivisionDelayInSeconds; // 0x18
	public DebugProbeShadingMode probeShading; // 0x1C
	public float probeSize; // 0x20
	public float subdivisionViewCullingDistance; // 0x24
	public float probeCullingDistance; // 0x28
	public int maxSubdivToVisualize; // 0x2C
	public int minSubdivToVisualize; // 0x30
	public float exposureCompensation; // 0x34
	public bool drawVirtualOffsetPush; // 0x38
	public float offsetSize; // 0x3C
	public bool freezeStreaming; // 0x40
	public int otherStateIndex; // 0x44

	// Methods

	// RVA: 0x2A22270 Offset: 0x2A20C70 VA: 0x182A22270
	public void .ctor() { }

	// RVA: 0x2A22220 Offset: 0x2A20C20 VA: 0x182A22220
	private void Init() { }

	// RVA: 0x2A221B0 Offset: 0x2A20BB0 VA: 0x182A221B0 Slot: 4
	public Action GetReset() { }

	[CompilerGenerated]
	// RVA: 0x2A22220 Offset: 0x2A20C20 VA: 0x182A22220
	private void <GetReset>b__19_0() { }
}
