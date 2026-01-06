public struct BlendState : IEquatable<BlendState> // TypeDefIndex: 12232
{
	// Fields
	private RenderTargetBlendState m_BlendState0; // 0x0
	private RenderTargetBlendState m_BlendState1; // 0x8
	private RenderTargetBlendState m_BlendState2; // 0x10
	private RenderTargetBlendState m_BlendState3; // 0x18
	private RenderTargetBlendState m_BlendState4; // 0x20
	private RenderTargetBlendState m_BlendState5; // 0x28
	private RenderTargetBlendState m_BlendState6; // 0x30
	private RenderTargetBlendState m_BlendState7; // 0x38
	private byte m_SeparateMRTBlendStates; // 0x40
	private byte m_AlphaToMask; // 0x41
	private short m_Padding; // 0x42

	// Properties
	public static BlendState defaultValue { get; }
	public RenderTargetBlendState blendState0 { set; }

	// Methods

	// RVA: 0x2CD5DD0 Offset: 0x2CD47D0 VA: 0x182CD5DD0
	public static BlendState get_defaultValue() { }

	// RVA: 0x2CD5CF0 Offset: 0x2CD46F0 VA: 0x182CD5CF0
	public void .ctor(bool separateMRTBlend = False, bool alphaToMask = False) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void set_blendState0(RenderTargetBlendState value) { }

	// RVA: 0x2CD5960 Offset: 0x2CD4360 VA: 0x182CD5960 Slot: 4
	public bool Equals(BlendState other) { }

	// RVA: 0x2CD5B40 Offset: 0x2CD4540 VA: 0x182CD5B40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CD5C00 Offset: 0x2CD4600 VA: 0x182CD5C00 Slot: 2
	public override int GetHashCode() { }
}
