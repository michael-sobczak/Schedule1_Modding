public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState> // TypeDefIndex: 12265
{
	// Fields
	private byte m_WriteMask; // 0x0
	private byte m_SourceColorBlendMode; // 0x1
	private byte m_DestinationColorBlendMode; // 0x2
	private byte m_SourceAlphaBlendMode; // 0x3
	private byte m_DestinationAlphaBlendMode; // 0x4
	private byte m_ColorBlendOperation; // 0x5
	private byte m_AlphaBlendOperation; // 0x6
	private byte m_Padding; // 0x7

	// Properties
	public static RenderTargetBlendState defaultValue { get; }

	// Methods

	// RVA: 0x2CF8270 Offset: 0x2CF6C70 VA: 0x182CF8270
	public static RenderTargetBlendState get_defaultValue() { }

	// RVA: 0x2CF8240 Offset: 0x2CF6C40 VA: 0x182CF8240
	public void .ctor(ColorWriteMask writeMask = 15, BlendMode sourceColorBlendMode = 1, BlendMode destinationColorBlendMode = 0, BlendMode sourceAlphaBlendMode = 1, BlendMode destinationAlphaBlendMode = 0, BlendOp colorBlendOperation = 0, BlendOp alphaBlendOperation = 0) { }

	// RVA: 0x2CF8050 Offset: 0x2CF6A50 VA: 0x182CF8050 Slot: 4
	public bool Equals(RenderTargetBlendState other) { }

	// RVA: 0x2CF80A0 Offset: 0x2CF6AA0 VA: 0x182CF80A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CF8190 Offset: 0x2CF6B90 VA: 0x182CF8190 Slot: 2
	public override int GetHashCode() { }
}
