internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 17357
{
	// Fields
	private AnimationPlayableOutput m_Output; // 0x10
	private AnimationMotionXToDeltaPlayable m_MotionXPlayable; // 0x20
	private readonly List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers; // 0x30

	// Methods

	// RVA: 0x2C3B860 Offset: 0x2C3A260 VA: 0x182C3B860
	public void .ctor(AnimationPlayableOutput output) { }

	// RVA: 0x2C3B420 Offset: 0x2C39E20 VA: 0x182C3B420
	private void FindMixers() { }

	// RVA: 0x2C3B530 Offset: 0x2C39F30 VA: 0x182C3B530
	private void FindMixers(Playable parent, int port, Playable node) { }

	// RVA: 0x2C3B2C0 Offset: 0x2C39CC0 VA: 0x182C3B2C0 Slot: 4
	public void Evaluate() { }
}
