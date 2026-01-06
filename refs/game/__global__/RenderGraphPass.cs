internal abstract class RenderGraphPass // TypeDefIndex: 13525
{
	// Fields
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <index>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProfilingSampler <customSampler>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <enableAsyncCompute>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <allowPassCulling>k__BackingField; // 0x29
	[CompilerGenerated]
	private TextureHandle <depthBuffer>k__BackingField; // 0x2C
	[CompilerGenerated]
	private TextureHandle[] <colorBuffers>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <colorBufferMaxIndex>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <refCount>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <generateDebugData>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <allowRendererListCulling>k__BackingField; // 0x49
	public List<ResourceHandle>[] resourceReadLists; // 0x50
	public List<ResourceHandle>[] resourceWriteLists; // 0x58
	public List<ResourceHandle>[] transientResourceList; // 0x60
	public List<RendererListHandle> usedRendererListList; // 0x68

	// Properties
	public string name { get; set; }
	public int index { get; set; }
	public ProfilingSampler customSampler { get; set; }
	public bool enableAsyncCompute { get; set; }
	public bool allowPassCulling { get; set; }
	public TextureHandle depthBuffer { get; set; }
	public TextureHandle[] colorBuffers { get; set; }
	public int colorBufferMaxIndex { get; set; }
	public int refCount { get; set; }
	public bool generateDebugData { get; set; }
	public bool allowRendererListCulling { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public RenderFunc<PassData> GetExecuteDelegate<PassData>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF31FE0 Offset: 0xF309E0 VA: 0x180F31FE0
	|-RenderGraphPass.GetExecuteDelegate<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Execute(RenderGraphContext renderGraphContext);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Release(RenderGraphObjectPool pool);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool HasRenderFunc();

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_index() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	protected void set_index(int value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ProfilingSampler get_customSampler() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_customSampler(ProfilingSampler value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_enableAsyncCompute() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_enableAsyncCompute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_allowPassCulling() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	protected void set_allowPassCulling(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCC4E90 Offset: 0xCC3890 VA: 0x180CC4E90
	public TextureHandle get_depthBuffer() { }

	[CompilerGenerated]
	// RVA: 0x4944B0 Offset: 0x492EB0 VA: 0x1804944B0
	protected void set_depthBuffer(TextureHandle value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public TextureHandle[] get_colorBuffers() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_colorBuffers(TextureHandle[] value) { }

	[CompilerGenerated]
	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_colorBufferMaxIndex() { }

	[CompilerGenerated]
	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	protected void set_colorBufferMaxIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public int get_refCount() { }

	[CompilerGenerated]
	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	protected void set_refCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_generateDebugData() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	protected void set_generateDebugData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_allowRendererListCulling() { }

	[CompilerGenerated]
	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	protected void set_allowRendererListCulling(bool value) { }

	// RVA: 0x29CC860 Offset: 0x29CB260 VA: 0x1829CC860
	public void .ctor() { }

	// RVA: 0x29CC450 Offset: 0x29CAE50 VA: 0x1829CC450
	public void Clear() { }

	// RVA: 0x29CC210 Offset: 0x29CAC10 VA: 0x1829CC210
	public void AddResourceWrite(in ResourceHandle res) { }

	// RVA: 0x29CC0F0 Offset: 0x29CAAF0 VA: 0x1829CC0F0
	public void AddResourceRead(in ResourceHandle res) { }

	// RVA: 0x29CC330 Offset: 0x29CAD30 VA: 0x1829CC330
	public void AddTransientResource(in ResourceHandle res) { }

	// RVA: 0x29CC7C0 Offset: 0x29CB1C0 VA: 0x1829CC7C0
	public void UseRendererList(RendererListHandle rendererList) { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void AllowPassCulling(bool value) { }

	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	public void AllowRendererListCulling(bool value) { }

	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	public void GenerateDebugData(bool value) { }

	// RVA: 0x29CC6C0 Offset: 0x29CB0C0 VA: 0x1829CC6C0
	public void SetColorBuffer(TextureHandle resource, int index) { }

	// RVA: 0x29CC770 Offset: 0x29CB170 VA: 0x1829CC770
	public void SetDepthBuffer(TextureHandle resource, DepthAccess flags) { }
}
