public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 18317
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x2C72EC0 Offset: 0x2C718C0 VA: 0x182C72EC0
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) { }

	// RVA: 0x2C72D60 Offset: 0x2C71760 VA: 0x182C72D60
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x2C73460 Offset: 0x2C71E60 VA: 0x182C73460
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C735A0 Offset: 0x2C71FA0 VA: 0x182C735A0
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	// RVA: 0x2C73080 Offset: 0x2C71A80 VA: 0x182C73080 Slot: 5
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x2C73170 Offset: 0x2C71B70 VA: 0x182C73170
	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[NativeThrows]
	// RVA: 0x2C72CE0 Offset: 0x2C716E0 VA: 0x182C72CE0
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x2C73380 Offset: 0x2C71D80 VA: 0x182C73380
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x2C73120 Offset: 0x2C71B20 VA: 0x182C73120
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	// RVA: 0x2C733D0 Offset: 0x2C71DD0 VA: 0x182C733D0
	private static void .cctor() { }

	// RVA: 0x2C72C90 Offset: 0x2C71690 VA: 0x182C72C90
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}
