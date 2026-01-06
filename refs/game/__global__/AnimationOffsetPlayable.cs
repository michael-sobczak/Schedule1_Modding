internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 18320
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x2C74910 Offset: 0x2C73310 VA: 0x182C74910
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x2C74780 Offset: 0x2C73180 VA: 0x182C74780
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x2C74D80 Offset: 0x2C73780 VA: 0x182C74D80
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C74E60 Offset: 0x2C73860 VA: 0x182C74E60
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

	// RVA: 0x2C74BA0 Offset: 0x2C735A0 VA: 0x182C74BA0 Slot: 5
	public bool Equals(AnimationOffsetPlayable other) { }

	[NativeThrows]
	// RVA: 0x2C746E0 Offset: 0x2C730E0 VA: 0x182C746E0
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	// RVA: 0x2C74C40 Offset: 0x2C73640 VA: 0x182C74C40
	private static void .cctor() { }

	// RVA: 0x2C74670 Offset: 0x2C73070 VA: 0x182C74670
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) { }
}
