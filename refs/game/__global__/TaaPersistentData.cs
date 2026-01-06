internal sealed class TaaPersistentData // TypeDefIndex: 9019
{
	// Fields
	private static GraphicsFormat[] formatList; // 0x0
	private RenderTextureDescriptor m_RtDesc; // 0x10
	private RTHandle m_AccumulationTexture; // 0x48
	private RTHandle m_AccumulationTexture2; // 0x50
	private int m_LastAccumUpdateFrameIndex; // 0x58
	private int m_LastAccumUpdateFrameIndex2; // 0x5C

	// Properties
	public RenderTextureDescriptor rtd { get; }

	// Methods

	// RVA: 0x2B2C150 Offset: 0x2B2AB50 VA: 0x182B2C150
	public RenderTextureDescriptor get_rtd() { }

	// RVA: 0x2B2C140 Offset: 0x2B2AB40 VA: 0x182B2C140
	public RTHandle accumulationTexture(int index) { }

	// RVA: 0x2B2BAB0 Offset: 0x2B2A4B0 VA: 0x182B2BAB0
	public int GetLastAccumFrameIndex(int index) { }

	// RVA: 0x2B2BDE0 Offset: 0x2B2A7E0 VA: 0x182B2BDE0
	public void SetLastAccumFrameIndex(int index, int value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2B2BAC0 Offset: 0x2B2A4C0 VA: 0x182B2BAC0
	public void Init(int sizeX, int sizeY, int volumeDepth, GraphicsFormat format, VRTextureUsage vrUsage, TextureDimension texDim) { }

	// RVA: 0x2B2B920 Offset: 0x2B2A320 VA: 0x182B2B920
	public bool AllocateTargets(bool xrMultipassEnabled = False) { }

	// RVA: 0x2B2BA50 Offset: 0x2B2A450 VA: 0x182B2BA50
	public void DeallocateTargets() { }

	// RVA: 0x2B2C0B0 Offset: 0x2B2AAB0 VA: 0x182B2C0B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2B2BDF0 Offset: 0x2B2A7F0 VA: 0x182B2BDF0
	internal static GraphicsFormat <Init>g__CheckFormat|12_0(GraphicsFormat format, FormatUsage usage) { }

	[CompilerGenerated]
	// RVA: 0x2B2BF80 Offset: 0x2B2A980 VA: 0x182B2BF80
	internal static GraphicsFormat <Init>g__FindFormat|12_1(FormatUsage usage) { }
}
