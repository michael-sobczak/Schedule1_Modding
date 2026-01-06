public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 18315
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x2C720F0 Offset: 0x2C70AF0 VA: 0x182C720F0
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x2C72000 Offset: 0x2C70A00 VA: 0x182C72000
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x2C72470 Offset: 0x2C70E70 VA: 0x182C72470
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x2C72550 Offset: 0x2C70F50 VA: 0x182C72550
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	// RVA: 0x2C722B0 Offset: 0x2C70CB0 VA: 0x182C722B0 Slot: 5
	public bool Equals(AnimationClipPlayable other) { }

	// RVA: 0x2C72330 Offset: 0x2C70D30 VA: 0x182C72330
	public void SetApplyFootIK(bool value) { }

	// RVA: 0x2C72420 Offset: 0x2C70E20 VA: 0x182C72420
	internal void SetRemoveStartOffset(bool value) { }

	// RVA: 0x2C723D0 Offset: 0x2C70DD0 VA: 0x182C723D0
	internal void SetOverrideLoopTime(bool value) { }

	// RVA: 0x2C72380 Offset: 0x2C70D80 VA: 0x182C72380
	internal void SetLoopTime(bool value) { }

	[NativeThrows]
	// RVA: 0x2C71FA0 Offset: 0x2C709A0 VA: 0x182C71FA0
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	[NativeThrows]
	// RVA: 0x2C72330 Offset: 0x2C70D30 VA: 0x182C72330
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x2C72420 Offset: 0x2C70E20 VA: 0x182C72420
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x2C723D0 Offset: 0x2C70DD0 VA: 0x182C723D0
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrows]
	// RVA: 0x2C72380 Offset: 0x2C70D80 VA: 0x182C72380
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x2C71F40 Offset: 0x2C70940 VA: 0x182C71F40
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }
}
