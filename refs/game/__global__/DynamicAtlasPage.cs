internal class DynamicAtlasPage : IDisposable // TypeDefIndex: 6744
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureId <textureId>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderTexture <atlas>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly RenderTextureFormat <format>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly FilterMode <filterMode>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector2Int <minSize>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector2Int <maxSize>k__BackingField; // 0x30
	private readonly int m_1Padding; // 0x38
	private readonly int m_2Padding; // 0x3C
	private Allocator2D m_Allocator; // 0x40
	private TextureBlitter m_Blitter; // 0x48
	private Vector2Int m_CurrentSize; // 0x50
	private static int s_TextureCounter; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x58

	// Properties
	public TextureId textureId { get; set; }
	public RenderTexture atlas { get; set; }
	public RenderTextureFormat format { get; }
	public FilterMode filterMode { get; }
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public TextureId get_textureId() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_textureId(TextureId value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public RenderTexture get_atlas() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_atlas(RenderTexture value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public RenderTextureFormat get_format() { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public FilterMode get_filterMode() { }

	// RVA: 0x2ED78F0 Offset: 0x2ED62F0 VA: 0x182ED78F0
	public void .ctor(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	private void set_disposed(bool value) { }

	// RVA: 0x2ED6E00 Offset: 0x2ED5800 VA: 0x182ED6E00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2ED6C30 Offset: 0x2ED5630 VA: 0x182ED6C30 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2ED6F30 Offset: 0x2ED5930 VA: 0x182ED6F30
	public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect) { }

	// RVA: 0x2ED7760 Offset: 0x2ED6160 VA: 0x182ED7760
	public void Update(Texture2D image, RectInt rect) { }

	// RVA: 0x2ED6E70 Offset: 0x2ED5870 VA: 0x182ED6E70
	public void Remove(Allocator2D.Alloc2D alloc) { }

	// RVA: 0x2ED6AB0 Offset: 0x2ED54B0 VA: 0x182ED6AB0
	public void Commit() { }

	// RVA: 0x2ED72E0 Offset: 0x2ED5CE0 VA: 0x182ED72E0
	private void UpdateAtlasTexture() { }

	// RVA: 0x2ED6AF0 Offset: 0x2ED54F0 VA: 0x182ED6AF0
	private RenderTexture CreateAtlasTexture() { }
}
