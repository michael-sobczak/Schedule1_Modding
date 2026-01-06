internal struct SpriteChannelInfo // TypeDefIndex: 11900
{
	// Fields
	[NativeName("buffer")]
	private IntPtr m_Buffer; // 0x0
	[NativeName("count")]
	private int m_Count; // 0x8
	[NativeName("offset")]
	private int m_Offset; // 0xC
	[NativeName("stride")]
	private int m_Stride; // 0x10

	// Properties
	public void* buffer { get; }
	public int count { get; }
	public int offset { get; }
	public int stride { get; }

	// Methods

	// RVA: 0x2CC7360 Offset: 0x2CC5D60 VA: 0x182CC7360
	public void* get_buffer() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_count() { }

	// RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	public int get_offset() { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public int get_stride() { }
}
