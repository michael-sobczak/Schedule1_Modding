internal struct ReflectionProbeMinMaxZJob : IJobFor // TypeDefIndex: 9028
{
	// Fields
	public Fixed2<float4x4> worldToViews; // 0x0
	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; // 0x80
	public NativeArray<float2> minMaxZs; // 0x90

	// Methods

	// RVA: 0x2B1BC70 Offset: 0x2B1A670 VA: 0x182B1BC70 Slot: 4
	public void Execute(int index) { }
}
