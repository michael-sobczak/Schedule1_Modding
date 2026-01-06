public struct RendererListParams : IEquatable<RendererListParams> // TypeDefIndex: 12256
{
	// Fields
	public static readonly RendererListParams Invalid; // 0x0
	public CullingResults cullingResults; // 0x0
	public DrawingSettings drawSettings; // 0x10
	public FilteringSettings filteringSettings; // 0xD4
	public ShaderTagId tagName; // 0xEC
	public bool isPassTagName; // 0xF0
	public Nullable<NativeArray<ShaderTagId>> tagValues; // 0xF8
	public Nullable<NativeArray<RenderStateBlock>> stateBlocks; // 0x110

	// Properties
	internal int numStateBlocks { get; }
	internal IntPtr stateBlocksPtr { get; }
	internal IntPtr tagsValuePtr { get; }

	// Methods

	// RVA: 0x2CE8810 Offset: 0x2CE7210 VA: 0x182CE8810
	internal int get_numStateBlocks() { }

	// RVA: 0x2CE8880 Offset: 0x2CE7280 VA: 0x182CE8880
	internal IntPtr get_stateBlocksPtr() { }

	// RVA: 0x2CE8920 Offset: 0x2CE7320 VA: 0x182CE8920
	internal IntPtr get_tagsValuePtr() { }

	// RVA: 0x2CE76D0 Offset: 0x2CE60D0 VA: 0x182CE76D0
	internal void Dispose() { }

	// RVA: 0x2CE82C0 Offset: 0x2CE6CC0 VA: 0x182CE82C0
	internal void Validate() { }

	// RVA: 0x2CE7920 Offset: 0x2CE6320 VA: 0x182CE7920 Slot: 4
	public bool Equals(RendererListParams other) { }

	// RVA: 0x2CE77E0 Offset: 0x2CE61E0 VA: 0x182CE77E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CE80F0 Offset: 0x2CE6AF0 VA: 0x182CE80F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CE87D0 Offset: 0x2CE71D0 VA: 0x182CE87D0
	private static void .cctor() { }
}
