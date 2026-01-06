internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 18319
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x2C74010 Offset: 0x2C72A10 VA: 0x182C74010
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	// RVA: 0x2C73EB0 Offset: 0x2C728B0 VA: 0x182C73EB0
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	// RVA: 0x2C74510 Offset: 0x2C72F10 VA: 0x182C74510
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C745F0 Offset: 0x2C72FF0 VA: 0x182C745F0
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	// RVA: 0x2C74260 Offset: 0x2C72C60 VA: 0x182C74260 Slot: 5
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x2C74350 Offset: 0x2C72D50 VA: 0x182C74350
	public void SetAbsoluteMotion(bool value) { }

	[NativeThrows]
	// RVA: 0x2C73E30 Offset: 0x2C72830 VA: 0x182C73E30
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x2C74300 Offset: 0x2C72D00 VA: 0x182C74300
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x2C743D0 Offset: 0x2C72DD0 VA: 0x182C743D0
	private static void .cctor() { }

	// RVA: 0x2C73DE0 Offset: 0x2C727E0 VA: 0x182C73DE0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}
