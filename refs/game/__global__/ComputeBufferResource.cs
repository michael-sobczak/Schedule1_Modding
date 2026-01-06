internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 13530
{
	// Methods

	// RVA: 0x29C7AD0 Offset: 0x29C64D0 VA: 0x1829C7AD0 Slot: 5
	public override string GetName() { }

	// RVA: 0x29C7930 Offset: 0x29C6330 VA: 0x1829C7930 Slot: 9
	public override void CreatePooledGraphicsResource() { }

	// RVA: 0x29C7C70 Offset: 0x29C6670 VA: 0x1829C7C70 Slot: 11
	public override void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x29C77D0 Offset: 0x29C61D0 VA: 0x1829C77D0 Slot: 10
	public override void CreateGraphicsResource(string name = "") { }

	// RVA: 0x29C7C20 Offset: 0x29C6620 VA: 0x1829C7C20 Slot: 12
	public override void ReleaseGraphicsResource() { }

	// RVA: 0x29C7B20 Offset: 0x29C6520 VA: 0x1829C7B20 Slot: 13
	public override void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x29C7BA0 Offset: 0x29C65A0 VA: 0x1829C7BA0 Slot: 14
	public override void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x29C7DD0 Offset: 0x29C67D0 VA: 0x1829C7DD0
	public void .ctor() { }
}
