public struct RenderStateBlock : IEquatable<RenderStateBlock> // TypeDefIndex: 12263
{
	// Fields
	private BlendState m_BlendState; // 0x0
	private RasterState m_RasterState; // 0x44
	private DepthState m_DepthState; // 0x54
	private StencilState m_StencilState; // 0x56
	private int m_StencilReference; // 0x64
	private RenderStateMask m_Mask; // 0x68

	// Properties
	public BlendState blendState { set; }
	public RasterState rasterState { set; }
	public DepthState depthState { get; set; }
	public StencilState stencilState { get; set; }
	public int stencilReference { get; set; }
	public RenderStateMask mask { get; set; }

	// Methods

	// RVA: 0x2CF7E80 Offset: 0x2CF6880 VA: 0x182CF7E80
	public void .ctor(RenderStateMask mask) { }

	// RVA: 0x2CF7FF0 Offset: 0x2CF69F0 VA: 0x182CF7FF0
	public void set_blendState(BlendState value) { }

	// RVA: 0x2CF8030 Offset: 0x2CF6A30 VA: 0x182CF8030
	public void set_rasterState(RasterState value) { }

	// RVA: 0x2CF7FA0 Offset: 0x2CF69A0 VA: 0x182CF7FA0
	public DepthState get_depthState() { }

	// RVA: 0x2CF8020 Offset: 0x2CF6A20 VA: 0x182CF8020
	public void set_depthState(DepthState value) { }

	// RVA: 0x2CF7FD0 Offset: 0x2CF69D0 VA: 0x182CF7FD0
	public StencilState get_stencilState() { }

	// RVA: 0x2CF8040 Offset: 0x2CF6A40 VA: 0x182CF8040
	public void set_stencilState(StencilState value) { }

	// RVA: 0x2CF7FC0 Offset: 0x2CF69C0 VA: 0x182CF7FC0
	public int get_stencilReference() { }

	// RVA: 0xC27360 Offset: 0xC25D60 VA: 0x180C27360
	public void set_stencilReference(int value) { }

	// RVA: 0x2CF7FB0 Offset: 0x2CF69B0 VA: 0x182CF7FB0
	public RenderStateMask get_mask() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_mask(RenderStateMask value) { }

	// RVA: 0x2CF7AE0 Offset: 0x2CF64E0 VA: 0x182CF7AE0 Slot: 4
	public bool Equals(RenderStateBlock other) { }

	// RVA: 0x2CF7CD0 Offset: 0x2CF66D0 VA: 0x182CF7CD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CF7DD0 Offset: 0x2CF67D0 VA: 0x182CF7DD0 Slot: 2
	public override int GetHashCode() { }
}
