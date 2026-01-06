internal class TextureBlitter : IDisposable // TypeDefIndex: 7136
{
	// Fields
	private static readonly int[] k_TextureIds; // 0x0
	private static ProfilerMarker s_CommitSampler; // 0x8
	private TextureBlitter.BlitInfo[] m_SingleBlit; // 0x10
	private Material m_BlitMaterial; // 0x18
	private MaterialPropertyBlock m_Properties; // 0x20
	private RectInt m_Viewport; // 0x28
	private RenderTexture m_PrevRT; // 0x38
	private List<TextureBlitter.BlitInfo> m_PendingBlits; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_disposed(bool value) { }

	// RVA: 0x2E1E9A0 Offset: 0x2E1D3A0 VA: 0x182E1E9A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E1EA10 Offset: 0x2E1D410 VA: 0x182E1EA10 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2E1F370 Offset: 0x2E1DD70 VA: 0x182E1F370
	private static void .cctor() { }

	// RVA: 0x2E1F4A0 Offset: 0x2E1DEA0 VA: 0x182E1F4A0
	public void .ctor(int capacity = 512) { }

	// RVA: 0x2E1F1E0 Offset: 0x2E1DBE0 VA: 0x182E1F1E0
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x2E1E760 Offset: 0x2E1D160 VA: 0x182E1E760
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x2E1E8A0 Offset: 0x2E1D2A0 VA: 0x182E1E8A0
	public void Commit(RenderTexture dst) { }

	// RVA: 0x2E1E520 Offset: 0x2E1CF20 VA: 0x182E1E520
	private void BeginBlit(RenderTexture dst) { }

	// RVA: 0x2E1EA90 Offset: 0x2E1D490 VA: 0x182E1EA90
	private void DoBlit(IList<TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x2E1F140 Offset: 0x2E1DB40 VA: 0x182E1F140
	private void EndBlit() { }
}
