public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 18323
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AnimationPlayableOutput Null { get; }

	// Methods

	// RVA: 0x2C75130 Offset: 0x2C73B30 VA: 0x182C75130
	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	// RVA: 0x2C75460 Offset: 0x2C73E60 VA: 0x182C75460
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x2C75540 Offset: 0x2C73F40 VA: 0x182C75540
	public static AnimationPlayableOutput get_Null() { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x2C72550 Offset: 0x2C70F50 VA: 0x182C72550
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	// RVA: 0x2C75670 Offset: 0x2C74070 VA: 0x182C75670
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x2C753D0 Offset: 0x2C73DD0 VA: 0x182C753D0
	public Animator GetTarget() { }

	// RVA: 0x2C75410 Offset: 0x2C73E10 VA: 0x182C75410
	public void SetTarget(Animator value) { }

	[NativeThrows]
	// RVA: 0x2C753D0 Offset: 0x2C73DD0 VA: 0x182C753D0
	private static Animator InternalGetTarget(ref PlayableOutputHandle handle) { }

	[NativeThrows]
	// RVA: 0x2C75410 Offset: 0x2C73E10 VA: 0x182C75410
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }
}
