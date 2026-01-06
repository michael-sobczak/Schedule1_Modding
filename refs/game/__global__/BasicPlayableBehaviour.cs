public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 17430
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x2C42210 Offset: 0x2C40C10 VA: 0x182C42210 Slot: 14
	public virtual double get_duration() { }

	// RVA: 0x2C42260 Offset: 0x2C40C60 VA: 0x182C42260 Slot: 15
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2C42140 Offset: 0x2C40B40 VA: 0x182C42140 Slot: 24
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
