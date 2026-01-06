public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 18318
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x2C73850 Offset: 0x2C72250 VA: 0x182C73850
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x2C736F0 Offset: 0x2C720F0 VA: 0x182C736F0
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x2C73C80 Offset: 0x2C72680 VA: 0x182C73C80
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C73D60 Offset: 0x2C72760 VA: 0x182C73D60
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

	// RVA: 0x2C73AA0 Offset: 0x2C724A0 VA: 0x182C73AA0 Slot: 5
	public bool Equals(AnimationMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x2C73670 Offset: 0x2C72070 VA: 0x182C73670
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x2C73B40 Offset: 0x2C72540 VA: 0x182C73B40
	private static void .cctor() { }

	// RVA: 0x2C73620 Offset: 0x2C72020 VA: 0x182C73620
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}
