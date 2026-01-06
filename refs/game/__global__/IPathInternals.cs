internal interface IPathInternals // TypeDefIndex: 13203
{
	// Properties
	public abstract PathHandler PathHandler { get; }
	public abstract bool Pooled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PathHandler get_PathHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Pooled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Pooled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AdvanceState(PathState s);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnEnterPool();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ReturnPath();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PrepareBase(PathHandler handler);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Prepare();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void CalculateStep(long targetTick);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string DebugString(PathLog logMode);
}
