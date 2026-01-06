public struct FrameData // TypeDefIndex: 12291
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30

	// Properties
	public float deltaTime { get; }
	public float effectiveSpeed { get; }
	public FrameData.EvaluationType evaluationType { get; }
	public bool seekOccurred { get; }
	public bool timeLooped { get; }
	public bool timeHeld { get; }
	public PlayableOutput output { get; }
	public PlayState effectivePlayState { get; }

	// Methods

	// RVA: 0x2CEF740 Offset: 0x2CEE140 VA: 0x182CEF740
	private bool HasFlags(FrameData.Flags flag) { }

	// RVA: 0x2CEF750 Offset: 0x2CEE150 VA: 0x182CEF750
	public float get_deltaTime() { }

	// RVA: 0x2CD4100 Offset: 0x2CD2B00 VA: 0x182CD4100
	public float get_effectiveSpeed() { }

	// RVA: 0x2CEF780 Offset: 0x2CEE180 VA: 0x182CEF780
	public FrameData.EvaluationType get_evaluationType() { }

	// RVA: 0x2CEF7A0 Offset: 0x2CEE1A0 VA: 0x182CEF7A0
	public bool get_seekOccurred() { }

	// RVA: 0x2CEF7C0 Offset: 0x2CEE1C0 VA: 0x182CEF7C0
	public bool get_timeLooped() { }

	// RVA: 0x2CEF7B0 Offset: 0x2CEE1B0 VA: 0x182CEF7B0
	public bool get_timeHeld() { }

	// RVA: 0x2CEF790 Offset: 0x2CEE190 VA: 0x182CEF790
	public PlayableOutput get_output() { }

	// RVA: 0x2CEF760 Offset: 0x2CEE160 VA: 0x182CEF760
	public PlayState get_effectivePlayState() { }
}
