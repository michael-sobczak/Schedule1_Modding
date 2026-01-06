public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor> // TypeDefIndex: 12231
{
	// Fields
	private RenderBufferLoadAction m_LoadAction; // 0x0
	private RenderBufferStoreAction m_StoreAction; // 0x4
	private GraphicsFormat m_Format; // 0x8
	private RenderTargetIdentifier m_LoadStoreTarget; // 0x10
	private RenderTargetIdentifier m_ResolveTarget; // 0x38
	private Color m_ClearColor; // 0x60
	private float m_ClearDepth; // 0x70
	private uint m_ClearStencil; // 0x74

	// Properties
	public RenderBufferLoadAction loadAction { set; }
	public RenderBufferStoreAction storeAction { set; }
	public GraphicsFormat graphicsFormat { get; }
	public RenderTargetIdentifier loadStoreTarget { get; set; }

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_loadAction(RenderBufferLoadAction value) { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_storeAction(RenderBufferStoreAction value) { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2CD4FE0 Offset: 0x2CD39E0 VA: 0x182CD4FE0
	public RenderTargetIdentifier get_loadStoreTarget() { }

	// RVA: 0x2CD5070 Offset: 0x2CD3A70 VA: 0x182CD5070
	public void set_loadStoreTarget(RenderTargetIdentifier value) { }

	// RVA: 0x2CD4A70 Offset: 0x2CD3470 VA: 0x182CD4A70
	public void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults) { }

	// RVA: 0x2CD4A30 Offset: 0x2CD3430 VA: 0x182CD4A30
	public void ConfigureResolveTarget(RenderTargetIdentifier target) { }

	// RVA: 0x2CD4A10 Offset: 0x2CD3410 VA: 0x182CD4A10
	public void ConfigureClear(Color clearColor, float clearDepth = 1, uint clearStencil = 0) { }

	// RVA: 0x2CD4F30 Offset: 0x2CD3930 VA: 0x182CD4F30
	public void .ctor(GraphicsFormat format) { }

	// RVA: 0x2CD4BC0 Offset: 0x2CD35C0 VA: 0x182CD4BC0 Slot: 4
	public bool Equals(AttachmentDescriptor other) { }

	// RVA: 0x2CD4AC0 Offset: 0x2CD34C0 VA: 0x182CD4AC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CD4DB0 Offset: 0x2CD37B0 VA: 0x182CD4DB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CD5000 Offset: 0x2CD3A00 VA: 0x182CD5000
	public static bool op_Inequality(AttachmentDescriptor left, AttachmentDescriptor right) { }
}
