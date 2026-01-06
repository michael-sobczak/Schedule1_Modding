public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 12302
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2CF2D70 Offset: 0x2CF1770 VA: 0x182CF2D70 Slot: 21
	public virtual object Clone() { }
}
