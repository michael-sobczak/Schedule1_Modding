internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 13526
{
	// Fields
	internal PassData data; // 0x0
	internal RenderFunc<PassData> renderFunc; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void Execute(RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5D30 Offset: 0x11A4730 VA: 0x1811A5D30
	|-RenderGraphPass<object>.Execute
	*/

	// RVA: -1 Offset: -1
	public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5D90 Offset: 0x11A4790 VA: 0x1811A5D90
	|-RenderGraphPass<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Release(RenderGraphObjectPool pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5E10 Offset: 0x11A4810 VA: 0x1811A5E10
	|-RenderGraphPass<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool HasRenderFunc() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BB2B0 Offset: 0x9B9CB0 VA: 0x1809BB2B0
	|-RenderGraphPass<object>.HasRenderFunc
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5EA0 Offset: 0x11A48A0 VA: 0x1811A5EA0
	|-RenderGraphPass<object>..ctor
	*/
}
