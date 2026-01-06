public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 18967
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AudioPlayableOutput Null { get; }

	// Methods

	// RVA: 0x2C7BC40 Offset: 0x2C7A640 VA: 0x182C7BC40
	public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) { }

	// RVA: 0x2C7BF80 Offset: 0x2C7A980 VA: 0x182C7BF80
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x2C7C060 Offset: 0x2C7AA60 VA: 0x182C7C060
	public static AudioPlayableOutput get_Null() { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x2C72550 Offset: 0x2C70F50 VA: 0x182C72550
	public static PlayableOutput op_Implicit(AudioPlayableOutput output) { }

	// RVA: 0x2C7C190 Offset: 0x2C7AB90 VA: 0x182C7C190
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x2C7BF30 Offset: 0x2C7A930 VA: 0x182C7BF30
	public void SetTarget(AudioSource value) { }

	// RVA: 0x2C7BEE0 Offset: 0x2C7A8E0 VA: 0x182C7BEE0
	public void SetEvaluateOnSeek(bool value) { }

	[NativeThrows]
	// RVA: 0x2C7BF30 Offset: 0x2C7A930 VA: 0x182C7BF30
	private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) { }

	[NativeThrows]
	// RVA: 0x2C7BEE0 Offset: 0x2C7A8E0 VA: 0x182C7BEE0
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }
}
