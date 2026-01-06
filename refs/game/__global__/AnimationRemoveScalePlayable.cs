internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 18325
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x2C75CA0 Offset: 0x2C746A0 VA: 0x182C75CA0
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x2C75B40 Offset: 0x2C74540 VA: 0x182C75B40
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	// RVA: 0x2C760D0 Offset: 0x2C74AD0 VA: 0x182C760D0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C761B0 Offset: 0x2C74BB0 VA: 0x182C761B0
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

	// RVA: 0x2C75EF0 Offset: 0x2C748F0 VA: 0x182C75EF0 Slot: 5
	public bool Equals(AnimationRemoveScalePlayable other) { }

	[NativeThrows]
	// RVA: 0x2C75AC0 Offset: 0x2C744C0 VA: 0x182C75AC0
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x2C75F90 Offset: 0x2C74990 VA: 0x182C75F90
	private static void .cctor() { }

	// RVA: 0x2C75A70 Offset: 0x2C74470 VA: 0x182C75A70
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}
