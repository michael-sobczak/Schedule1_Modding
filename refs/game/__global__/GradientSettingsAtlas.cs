internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 7098
{
	// Fields
	private static ProfilerMarker s_MarkerWrite; // 0x0
	private static ProfilerMarker s_MarkerCommit; // 0x8
	private readonly int m_Length; // 0x10
	private readonly int m_ElemWidth; // 0x14
	private BestFitAllocator m_Allocator; // 0x18
	private Texture2D m_Atlas; // 0x20
	private GradientSettingsAtlas.RawTexture m_RawAtlas; // 0x28
	private static int s_TextureCounter; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <MustCommit>k__BackingField; // 0x39

	// Properties
	internal int length { get; }
	protected bool disposed { get; set; }
	public Texture2D atlas { get; }
	public bool MustCommit { get; set; }

	// Methods

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	internal int get_length() { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	private void set_disposed(bool value) { }

	// RVA: 0x2DFB4C0 Offset: 0x2DF9EC0 VA: 0x182DFB4C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFB530 Offset: 0x2DF9F30 VA: 0x182DFB530 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2DFBD30 Offset: 0x2DFA730 VA: 0x182DFBD30
	public void .ctor(int length = 4096) { }

	// RVA: 0x2DFB710 Offset: 0x2DFA110 VA: 0x182DFB710
	public void Reset() { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public Texture2D get_atlas() { }

	// RVA: 0x2DFB220 Offset: 0x2DF9C20 VA: 0x182DFB220
	public Alloc Add(int count) { }

	// RVA: 0x2DFB7D0 Offset: 0x2DFA1D0 VA: 0x182DFB7D0
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_MustCommit() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	private void set_MustCommit(bool value) { }

	// RVA: 0x2DFB300 Offset: 0x2DF9D00 VA: 0x182DFB300
	public void Commit() { }

	// RVA: 0x2DFB5A0 Offset: 0x2DF9FA0 VA: 0x182DFB5A0
	private void PrepareAtlas() { }

	// RVA: 0x2DFBC90 Offset: 0x2DFA690 VA: 0x182DFBC90
	private static void .cctor() { }
}
