internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource // TypeDefIndex: 13545
{
	// Fields
	public DescType desc; // 0x0
	public ResType graphicsResource; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-RenderGraphResource<ComputeBufferDesc, object>..ctor
	|-RenderGraphResource<TextureDesc, object>..ctor
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Reset(IRenderGraphResourcePool pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A7410 Offset: 0x11A5E10 VA: 0x1811A7410
	|-RenderGraphResource<ComputeBufferDesc, object>.Reset
	|
	|-RVA: 0x11A74A0 Offset: 0x11A5EA0 VA: 0x1811A74A0
	|-RenderGraphResource<TextureDesc, object>.Reset
	|
	|-RVA: 0x11A7440 Offset: 0x11A5E40 VA: 0x1811A7440
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB27DD0 Offset: 0xB267D0 VA: 0x180B27DD0
	|-RenderGraphResource<ComputeBufferDesc, object>.IsCreated
	|
	|-RVA: 0x11A73B0 Offset: 0x11A5DB0 VA: 0x1811A73B0
	|-RenderGraphResource<TextureDesc, object>.IsCreated
	|
	|-RVA: 0x11A7380 Offset: 0x11A5D80 VA: 0x1811A7380
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void ReleaseGraphicsResource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A73C0 Offset: 0x11A5DC0 VA: 0x1811A73C0
	|-RenderGraphResource<ComputeBufferDesc, object>.ReleaseGraphicsResource
	|
	|-RVA: 0x11A73D0 Offset: 0x11A5DD0 VA: 0x1811A73D0
	|-RenderGraphResource<TextureDesc, object>.ReleaseGraphicsResource
	|
	|-RVA: 0x11A73E0 Offset: 0x11A5DE0 VA: 0x1811A73E0
	|-RenderGraphResource<__Il2CppFullySharedGenericStructType, object>.ReleaseGraphicsResource
	*/
}
