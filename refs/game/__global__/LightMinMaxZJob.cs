internal struct LightMinMaxZJob : IJobFor // TypeDefIndex: 9027
{
	// Fields
	public Fixed2<float4x4> worldToViews; // 0x0
	[ReadOnly]
	public NativeArray<VisibleLight> lights; // 0x80
	public NativeArray<float2> minMaxZs; // 0x90

	// Methods

	// RVA: 0x2B16860 Offset: 0x2B15260 VA: 0x182B16860 Slot: 4
	public void Execute(int index) { }
}
