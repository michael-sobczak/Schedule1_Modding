internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 13550
{
	// Fields
	private static int m_TextureCreationIndex; // 0x0

	// Methods

	// RVA: 0x29F85A0 Offset: 0x29F6FA0 VA: 0x1829F85A0 Slot: 5
	public override string GetName() { }

	// RVA: 0x29F8400 Offset: 0x29F6E00 VA: 0x1829F8400 Slot: 9
	public override void CreatePooledGraphicsResource() { }

	// RVA: 0x29F87C0 Offset: 0x29F71C0 VA: 0x1829F87C0 Slot: 11
	public override void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x29F7E20 Offset: 0x29F6820 VA: 0x1829F7E20 Slot: 10
	public override void CreateGraphicsResource(string name = "") { }

	// RVA: 0x29F8760 Offset: 0x29F7160 VA: 0x1829F8760 Slot: 12
	public override void ReleaseGraphicsResource() { }

	// RVA: 0x29F8610 Offset: 0x29F7010 VA: 0x1829F8610 Slot: 13
	public override void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x29F86D0 Offset: 0x29F70D0 VA: 0x1829F86D0 Slot: 14
	public override void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x29F8930 Offset: 0x29F7330 VA: 0x1829F8930
	public void .ctor() { }
}
